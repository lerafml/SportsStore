using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Abstract;
using SportsStoreWFA.Models;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.Export;
using Telerik.WinControls;
using System.Collections.Generic;
using SportsStore.Domain.Entities;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Linq;

namespace SportsStoreWFA
{
    public partial class SportsStore : RadForm
    {
        private IProductRepository repository;

        public SportsStore()
        {
            repository = new EFProductRepository();
            InitializeComponent();
        }

        private void Read_Products()
        {
            List<ProductViewModel> result = repository.Products.Select(product => new ProductViewModel
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Description = product.Description,
                CatID = product.CatID,
                Category = product.Category,
                Price = product.Price,
                ImageData = product.ImageData,
                ImageMimeType = product.ImageMimeType
            }).ToList();

            radGridViewProducts.DataSource = result;
        }

        private void SportsStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsStoreDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.sportsStoreDataSet.Products);
            //this.radGridView1.TableElement.RowHeight = 100;
            //for (int i = 0; i < this.sportsStoreDataSet.Products.Rows.Count; i++)
            //{
            //    int id = this.sportsStoreDataSet.Products.Rows[i].Field<Int32>("CatID");
            //    string cat = this.sportsStoreDataSet.Categories.FirstOrDefault(c => c.Field<Int32>("CatId") == id).Field<string>("CatName");
            //    int index = this.sportsStoreDataSet.Products.Columns.IndexOf("Category");
            //    this.sportsStoreDataSet.Products.Rows[i].SetField<string>(index, cat);
            //}

            //-----------------------------GRID VIEW-----------------------------------------------

            Read_Products();

            radGridViewProducts.TableElement.RowHeight = 100;

            radGridViewProducts.Columns["ProductID"].IsVisible = false;
            radGridViewProducts.Columns["ImageMimeType"].IsVisible = false;
            radGridViewProducts.Columns["FileName"].IsVisible = false;
            radGridViewProducts.Columns["CatID"].IsVisible = false;
            radGridViewProducts.Columns["Category"].IsVisible = false;

            radGridViewProducts.Columns["Name"].HeaderText = "Название";
            radGridViewProducts.Columns["Description"].HeaderText = "Описание";
            radGridViewProducts.Columns["ImageData"].HeaderText = "Изображение";
            radGridViewProducts.Columns["Price"].HeaderText = "Цена";

            radGridViewProducts.Columns["Name"].WrapText = true;
            radGridViewProducts.Columns["Description"].WrapText = true;
            radGridViewProducts.Columns["Price"].FormatString = "{0:c}";
            radGridViewProducts.Columns["Name"].TextAlignment = ContentAlignment.MiddleCenter;
            radGridViewProducts.Columns["Description"].TextAlignment = ContentAlignment.MiddleCenter;
            radGridViewProducts.Columns["Price"].TextAlignment = ContentAlignment.MiddleCenter;
            radGridViewProducts.Columns["ImageData"].ImageLayout = ImageLayout.Zoom;

            radGridViewProducts.Columns["Name"].MinWidth = 130;
            radGridViewProducts.Columns["Description"].MinWidth = 250;
            radGridViewProducts.Columns["Price"].MinWidth = 80;
            radGridViewProducts.Columns["Price"].MaxWidth = 80;
            radGridViewProducts.Columns["ImageData"].MinWidth = 100;

            radGridViewProducts.Columns.Add("CategoryName");
            radGridViewProducts.Columns["CategoryName"].HeaderText = "Категория";
            radGridViewProducts.Columns["CategoryName"].MinWidth = 130;
            radGridViewProducts.Columns["CategoryName"].TextAlignment = ContentAlignment.MiddleCenter;
            radGridViewProducts.Columns["CategoryName"].FieldName = "Category.CatName";
            //for (int i = 0; i < radGridView1.Rows.Count; i++)
            //{
            //    int id = radGridView1.Columns["CatID"].in
            //    string name = 
            //}

            radGridViewProducts.Columns.Move(radGridViewProducts.Columns["ImageData"].Index, 0);
            radGridViewProducts.Columns.Move(radGridViewProducts.Columns["CategoryName"].Index, 2);

            // ----------------------------------TREE VIEW-------------------------------------------
            
            List<string> tw = repository.Categories.Select(c => c.CatName).ToList();
            radTreeViewCategories.Nodes.Add("Все категории");
            foreach(var c in tw)
            {
                radTreeViewCategories.Nodes[0].Nodes.Add(c);
            }
            
        }

        //               ФИЛЬТРАЦИЯ ТАБЛИЦЫ ПО КАТЕГОРИЯМ
        private void radTreeView1_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            radTreeViewCategories.SelectedNode = e.Node;
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node.Text == "Все категории")
            {
                for (int i = 0; i < radGridViewProducts.Rows.Count; i++)
                {
                    radGridViewProducts.Rows[i].IsVisible = true;
                }
            }
            else
            {
                for (int i = 0; i < radGridViewProducts.Rows.Count; i++)
                {
                    if ((string)radGridViewProducts.Rows[i].Cells["CategoryName"].Value != e.Node.Text)
                    {
                        radGridViewProducts.Rows[i].IsVisible = false;
                    }
                    else
                    {
                        radGridViewProducts.Rows[i].IsVisible = true;
                    }
                }
                //FilterDescriptor filter = new FilterDescriptor();
                //filter.PropertyName = "CategoryName";
                //filter.Operator = FilterOperator.IsEqualTo;
                //filter.Value = e.Node.Text;
                //radGridView1.EnableFiltering = true;
                //radGridView1.FilterDescriptors.Add(filter);
                //radGridView1.TableElement.ViewElement.UpdateRows(true);
            }
        }

        //-------------------------------------------------------C R U D----------------------------------------------------
        //
        //private void Create_Click(object sender, EventArgs e)
        //{
        //    string category;
        //    try
        //    {
        //        category = radTreeViewCategories.SelectedNode.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        category = "Все категории";
        //    }
        //    CreateForm form = new CreateForm(repository, radGridViewProducts, radTreeViewCategories, category);
        //    form.Show();
        //}

        //private void Update_Click(object sender, EventArgs e)
        //{
        //    CreateForm form = new CreateForm(repository, radGridViewProducts, radTreeViewCategories, radGridViewProducts.SelectedRows);
        //    form.Show();
        //}

        private void ShowEditForm(ProductViewModel product)
        {
            EditForm edit = new EditForm(product);
            edit.DropDownBoxCategory.DataSource = repository.Categories.ToList();

            if (edit.ShowDialog() == DialogResult.OK)
            {
                Product dbProduct = new Product();
                dbProduct.ProductID = product.ProductID;
                dbProduct.Name = product.Name;
                dbProduct.Description = product.Description;
                dbProduct.CatID = product.CatID;
                dbProduct.Price = product.Price;
                dbProduct.ImageData = product.ImageData;
                dbProduct.ImageMimeType = product.ImageMimeType;

                product.Category = repository.Categories.FirstOrDefault(c => c.CatID == product.CatID);

                Product first = repository.Products.FirstOrDefault(p => p.Name == dbProduct.Name);

                if (dbProduct.ProductID == 0 && first != null)
                {
                    RadMessageBox.ThemeName = "Material";
                    RadMessageBox.Show("Такой продукт уже существует!");
                }
                else
                {
                    repository.SaveProduct(dbProduct);

                    if (product.ProductID == 0)
                    {
                        Read_Products();
                    }
                    if (radTreeViewCategories.SelectedNodes.Any())
                    {
                        if (radTreeViewCategories.SelectedNode.Text != "Все категории")
                        {
                            radTreeViewCategories.SelectedNode = radTreeViewCategories.GetNodeByName(product.Category.CatName);
                        }
                    }
                }


            }
        }

        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            ProductViewModel product = new ProductViewModel();
            product.ProductID = 0;

            if (radTreeViewCategories.SelectedNodes.Any())
            {
                if (radTreeViewCategories.SelectedNode.Text != "Все категории")
                {
                    product.CatID = repository.Categories.FirstOrDefault(c => c.CatName == radTreeViewCategories.SelectedNode.Text).CatID;
                }
            }

            ShowEditForm(product);
            radGridViewProducts.Focus();
        }

        private void radButtonEdit_Click(object sender, EventArgs e)
        {
            ProductViewModel product = radGridViewProducts.SelectedRows[0].DataBoundItem as ProductViewModel;
            ShowEditForm(product);
            radGridViewProducts.Focus();
        }

        private void radGridViewProducts_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (radGridViewProducts.CurrentRow.RowElementType == typeof(GridDataRowElement))
            {
                ProductViewModel product = radGridViewProducts.CurrentRow.DataBoundItem as ProductViewModel;
                ShowEditForm(product);
                radGridViewProducts.Focus();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            GridViewRowInfo row = radGridViewProducts.SelectedRows[0];
            RadMessageBox.ThemeName = "Material";
            DialogResult result = RadMessageBox.Show("Вы уверены, что хотите удалить " + (string)row.Cells["Name"].Value + "?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int ProductID = (int)row.Cells["ProductID"].Value;
                repository.DeleteProduct(ProductID);
                row.Delete();
                row.IsVisible = false;
            }
            
        }

        //---------------------PRINT, EXPORT and IMPORT----------------------------------------------
        private void Print_Click(object sender, EventArgs e)
        {
            radGridViewProducts.PrintPreview();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            RadSaveFileDialog sfd = new RadSaveFileDialog();
            sfd.SaveFileDialogForm.ThemeName = "Material";
            sfd.Filter = "Excel файлы (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                ExportToExcelML exporter = new ExportToExcelML(radGridViewProducts);
                exporter.SheetName = "Список продуктов";
                exporter.RunExport(fileName);
                RadMessageBox.ThemeName = "Material";
                RadMessageBox.Show("Файл успешно сохранен!");
            }
        }

        private void ToXML_Click(object sender, EventArgs e)
        {
            RadSaveFileDialog sfd = new RadSaveFileDialog();
            sfd.SaveFileDialogForm.ThemeName = "Material";
            sfd.Filter = "Xml файлы (*.xml)|*.xml";
            List<Product> list = new List<Product>();
            XDocument xml = new XDocument(new XDeclaration("1.0", "windows-1251", null));

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < radGridViewProducts.Rows.Count; i++)
                {
                    GridViewRowInfo rowInfo = radGridViewProducts.Rows[i];
                    if (rowInfo.IsVisible == true)
                    {
                        string rowName = rowInfo.Cells["Name"].Value.ToString();
                        list.Add(repository.Products.FirstOrDefault(p => p.Name == rowName));
                    }
                }

                if (radTreeViewCategories.SelectedNodes.Any())
                {
                    if (repository.Categories.Select(c => c.CatName).ToList().Contains(radTreeViewCategories.SelectedNode.Text))
                    {
                        XElement root = new XElement("Категория", new XAttribute("name", radTreeViewCategories.SelectedNode.Text));

                        foreach (Product p in list)
                        {
                            root.Add(new XElement("Продукт",
                                new XElement("Название", p.Name),
                                new XElement("Описание", p.Description),
                                new XElement("Цена", p.Price)
                                ));
                        }

                        xml.Add(new XElement("Список", root));
                    }
                    else
                    {
                        XElement root = new XElement("Продукты");

                        foreach (Product p in list)
                        {
                            root.Add(new XElement("Продукт",
                                new XElement("Название", p.Name),
                                new XElement("Категория", p.Category.CatName),
                                new XElement("Описание", p.Description),
                                new XElement("Цена", p.Price)
                                ));
                        }

                        xml.Add(new XElement("Список", root));
                    }
                }
                else
                {
                    XElement root = new XElement("Продукты");

                    foreach (Product p in list)
                    {
                        root.Add(new XElement("Продукт",
                            new XElement("Название", p.Name),
                            new XElement("Категория", p.Category.CatName),
                            new XElement("Описание", p.Description),
                            new XElement("Цена", p.Price)
                            ));
                    }

                    xml.Add(new XElement("Список", root));
                }
                
                //ItemsList collection = ToItemsList(list);
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ItemsList));
                //MemoryStream ms = new MemoryStream();
                //XmlTextWriter xmlWriter = new XmlTextWriter(ms, Encoding.GetEncoding(1251));
                //xmlWriter.Formatting = Formatting.Indented;
                //XmlWriter xw = (XmlWriter)xmlWriter;
                //xmlSerializer.Serialize(xw, collection);
                //xw.Close();
            
                string fileName = sfd.FileName;
                xml.Save(fileName);
                //using (Stream stream = sfd.OpenFile())
                //{
                //    await stream.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                //}
                RadMessageBox.ThemeName = "Material";
                RadMessageBox.Show("Файл успешно сохранен!");
            }
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            RadSaveFileDialog sfd = new RadSaveFileDialog();
            sfd.SaveFileDialogForm.ThemeName = "Material";
            sfd.Filter = "PDF файлы (*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                GridViewPdfExport pdfExporter = new GridViewPdfExport(radGridViewProducts);
                pdfExporter.ShowHeaderAndFooter = true;
                pdfExporter.HeaderHeight = 30;
                pdfExporter.HeaderFont = new Font("Arial", 22);
                pdfExporter.RunExportAsync(fileName, new PdfExportRenderer());
                RadMessageBox.ThemeName = "Material";
                RadMessageBox.Show("Файл успешно сохранен!");
            }
        }

        private void Populate(List<Product> list)
        {
            foreach (Product p in list)
            {
                repository.SaveProduct(p);
            }
        }

        private void FromXML_Click(object sender, EventArgs e)
        {
            RadOpenFileDialog ofd = new RadOpenFileDialog();
            ofd.OpenFileDialogForm.ThemeName = "Material";
            ofd.Filter = "Xml файлы (*.xml)|*.xml";
            string message = "Изменения успешно сохранены.";
            List<string> fix = new List<string>();
            XDocument xDoc = new XDocument();
            RadMessageBox.ThemeName = "Material";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                int err = 0, pIndex = 0;
                string fileName = ofd.FileName, pName = "", pDesc = "", pCat = "";
                decimal pPrice = 0;
                List<Product> list = new List<Product>();

                try
                {
                    xDoc = XDocument.Load(fileName);
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    RadMessageBox.Show(message);
                }

                if (message == "Изменения успешно сохранены." &&
                    xDoc.Element("Список").Elements().First().Name.ToString() == "Категория")
                {
                    try
                    {
                        pCat = xDoc.Element("Список").Elements().First().Attribute("name").Value;
                    }
                    catch (Exception ex)
                    {
                        message = "Проверьте наличие атрибута 'name' тега <Категория>.";
                        RadMessageBox.Show(message);
                    }

                    if (repository.Categories.Select(c => c.CatName).ToList().Contains(pCat))
                    {
                        foreach (XElement product in xDoc.Element("Список").Elements().First().Elements())
                        {
                            pIndex++;
                            try
                            {
                                pName = product.Element("Название").Value;
                                pDesc = product.Element("Описание").Value;
                                pPrice = Decimal.Parse(product.Element("Цена").Value.Replace('.', ','));
                            }
                            catch (Exception ex)
                            {
                                message = "Некорректный документ. Не хватает информации по " + pIndex + "-му продукту.";
                                RadMessageBox.Show(message);
                                break;
                            }

                            Product first = repository.Products.FirstOrDefault(p => p.Name == pName);
                            if (first != null)
                            {
                                first.Name = pName;
                                first.Description = pDesc;
                                first.Price = pPrice;
                                first.CatID = repository.Categories.FirstOrDefault(c => c.CatName == pCat).CatID;
                                first.Category = repository.Categories.FirstOrDefault(c => c.CatName == pCat);
                                list.Add(first);
                            }
                            else
                            {
                                Product newProduct = new Product();
                                newProduct.ProductID = 0;
                                newProduct.Name = pName;
                                newProduct.Description = pDesc;
                                newProduct.Price = pPrice;
                                newProduct.CatID = repository.Categories.FirstOrDefault(c => c.CatName == pCat).CatID;
                                newProduct.Category = repository.Categories.FirstOrDefault(c => c.CatName == pCat);
                                list.Add(newProduct);
                            }
                        }

                        if (message == "Изменения успешно сохранены.")
                        {
                            Populate(list);
                            Read_Products();
                            radTreeViewCategories.SelectedNode = radTreeViewCategories.FindNodes(n => n.Text == pCat)[0];
                            RadMessageBox.Show(message);
                        }
                    }
                    else if (pCat != "")
                    {
                        message = "Такой категории не существует!";
                        RadMessageBox.Show(message);
                    }
                }
                else if (message == "Изменения успешно сохранены." &&
                    xDoc.Element("Список").Elements().First().Name.ToString() == "Продукты")
                {
                    foreach (XElement product in xDoc.Element("Список").Elements().First().Elements())
                    {
                        pIndex++;
                        try
                        {
                            pName = product.Element("Название").Value;
                            pDesc = product.Element("Описание").Value;
                            pPrice = Decimal.Parse(product.Element("Цена").Value.Replace('.', ','));
                            pCat = product.Element("Категория").Value;
                        }
                        catch (Exception ex)
                        {
                            message = "Некорректный документ. Не хватает информации по " + pIndex + "-му продукту." + ex.Message;
                            RadMessageBox.Show(message);
                            break;
                        }

                        Product first = repository.Products.FirstOrDefault(p => p.Name == pName);
                        if (first != null)
                        {
                            first.Name = pName;
                            first.Description = pDesc;
                            first.Price = pPrice;
                            try
                            {
                                first.CatID = repository.Categories.FirstOrDefault(c => c.CatName == pCat).CatID;
                                first.Category = repository.Categories.FirstOrDefault(c => c.CatName == pCat);
                            }
                            catch (Exception ex)
                            {
                                message = "Проверьте название категории для '" + pName + "', такой категории не существует.";
                                RadMessageBox.Show(message);
                                break;
                            }
                            list.Add(first);
                        }
                        else
                        {
                            Product newProduct = new Product();
                            newProduct.ProductID = 0;
                            newProduct.Name = pName;
                            newProduct.Description = pDesc;
                            newProduct.Price = pPrice;
                            try
                            {
                                newProduct.CatID = repository.Categories.FirstOrDefault(c => c.CatName == pCat).CatID;
                                newProduct.Category = repository.Categories.FirstOrDefault(c => c.CatName == pCat);
                            }
                            catch (Exception ex)
                            {
                                message = "Проверьте название категории для '" + pName + "', такой категории не существует.";
                                RadMessageBox.Show(message);
                                break;
                            }
                            list.Add(newProduct);
                        }
                    }

                    if (message == "Изменения успешно сохранены.")
                    {
                        Populate(list);
                        Read_Products();
                        radTreeViewCategories.SelectedNode = radTreeViewCategories.Nodes[0];
                        RadMessageBox.Show(message);
                    }
                }
                else if (message == "Изменения успешно сохранены.")
                {
                    message = "Некорректная структура. Проверьте первый тег внутри списка (должен быть <Категория> или <Продукты>.)";
                    RadMessageBox.Show(message);
                }
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Report form = new Report(repository);
            form.ShowDialog();
        }
    }
}
