using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStoreWFA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SportsStoreWFA
{
    public partial class CreateForm : RadForm
    {
        private IProductRepository repository;
        private List<string> categories;
        private Product product;
        private RadGridView grid;
        private RadTreeView tree;
        private GridViewRowInfo selectedRow;
        private bool isUpdated;

        public CreateForm(IProductRepository repository, RadGridView grid, RadTreeView tree, string category)
        {
            this.repository = repository;
            this.grid = grid;
            this.tree = tree;
            isUpdated = false;
            product = new Product();
            product.ProductID = 0;
            InitializeComponent();
            categories = repository.Categories.Select(c => c.CatName).ToList();
            CategoryBox.DataSource = categories;
            if (category != null)
            {
                if (category != "Все категории")
                {
                    CategoryBox.SelectedIndex = categories.IndexOf(category);
                }
                else
                {
                    CategoryBox.SelectedIndex = -1;
                    CategoryBox.Text = "Не выбрано";
                }
            }
        }

        public CreateForm(IProductRepository repository, RadGridView grid, RadTreeView tree, GridViewSelectedRowsCollection collection)
        {
            this.repository = repository;
            this.grid = grid;
            this.tree = tree;
            isUpdated = true;
            selectedRow = collection.First();
            int id = (int)selectedRow.Cells["ProductID"].Value;
            byte[] img = (byte[])selectedRow.Cells["ImageData"].Value;
            categories = repository.Categories.Select(c => c.CatName).ToList();
            product = repository.Products.FirstOrDefault(p => p.ProductID == id);
            InitializeComponent();
            CategoryBox.DataSource = categories;
            if (img != null)
            {
                ImageBox.BackgroundImage = ConvertToImage(img);
            }
            NameBox.Text = (string)selectedRow.Cells["Name"].Value;
            DescriptionBox.Text = (string)selectedRow.Cells["Description"].Value;
            PriceBox.Value = (decimal)selectedRow.Cells["Price"].Value;
            CategoryBox.SelectedIndex = categories.IndexOf((string)selectedRow.Cells["CategoryName"].Value);
        }

        public Image ConvertToImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            RadOpenFileDialog ofd = new RadOpenFileDialog();
            ofd.Filter = "Изображения|*.jpg;*.png;*.bmp";
            ofd.OpenFileDialogForm.ThemeName = "Material";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                product.ImageData = File.ReadAllBytes(ofd.FileName);
                ImageBox.BackgroundImage = ConvertToImage(product.ImageData);
            }
        }

        private void SaveProduct_Click(object sender, EventArgs e)
        {
            Product first = repository.Products.FirstOrDefault(p => p.Name == NameBox.Text);

            if (NameBox.Text == "")
            {
                errorProvider1.SetError(NameBox, "Название не может быть пустым!");
            }
            else if (first != null && isUpdated == false)
            {
                errorProvider1.SetError(NameBox, "Такой продукт уже существует!");
            }

            if (DescriptionBox.Text == "")
            {
                errorProvider1.SetError(DescriptionBox, "Описание не может быть пустым!");
            }

            if (CategoryBox.SelectedIndex < 0)
            {
                errorProvider1.SetError(CategoryBox, "Выберите категорию!");
            }

            if (PriceBox.Value == 0)
            {
                errorProvider1.SetError(PriceBox, "Укажите цену!");
            }

            if (isUpdated == true)
            {
                first = null;
            }

            if (NameBox.Text != "" &&
                first == null &&
                DescriptionBox.Text != "" &&
                CategoryBox.SelectedIndex >= 0 &&
                PriceBox.Value > 0)
            {
                product.Name = NameBox.Text;
                product.Description = DescriptionBox.Text;
                product.Price = PriceBox.Value;
                product.CatID = repository.Categories.FirstOrDefault(c => c.CatName == (string)CategoryBox.SelectedValue).CatID;
                product.Category = repository.Categories.FirstOrDefault(c => c.CatName == (string)CategoryBox.SelectedValue);
                repository.SaveProduct(product);
                RadMessageBox.SetThemeName("Material");
                RadMessageBox.Show("Продукт успешно сохранен!");
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

                grid.DataSource = result;
                tree.SelectedNode = tree.Nodes[0].Nodes.ElementAt(categories.IndexOf(product.Category.CatName));

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if ((string)grid.Rows[i].Cells["CategoryName"].Value != product.Category.CatName)
                    {
                        grid.Rows[i].IsVisible = false;
                        grid.Rows[i].IsSelected = false;
                    }
                    else
                    {
                        grid.Rows[i].IsVisible = true;
                        if ((string)grid.Rows[i].Cells["Name"].Value == product.Name)
                        {
                            grid.Rows[i].IsSelected = true;
                        }
                        else
                        {
                            grid.Rows[i].IsSelected = false;
                        }
                    }
                }
                
                GridViewRowInfo selectedRow = grid.Rows.FirstOrDefault(r => r.Cells["Name"].Value.ToString() == product.Name);
                if (selectedRow != null)
                {
                    grid.Rows[0].IsSelected = false;
                    grid.Rows[grid.Rows.IndexOf(selectedRow)].IsSelected = true;
                }
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //----------------------ВАЛИДАЦИЯ ФОРМЫ-------------------------------------------
        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if (NameBox.Text == "")
            {
                errorProvider1.SetError(NameBox, "Название не может быть пустым!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void DescriptionBox_Validating(object sender, CancelEventArgs e)
        {
            if (DescriptionBox.Text == "")
            {
                errorProvider1.SetError(DescriptionBox, "Описание не может быть пустым!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void PriceBox_Validating(object sender, CancelEventArgs e)
        {
            if (PriceBox.Value == 0)
            {
                errorProvider1.SetError(PriceBox, "Укажите цену!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void CategoryBox_Validating(object sender, CancelEventArgs e)
        {
            if (CategoryBox.SelectedIndex < 0)
            {
                errorProvider1.SetError(CategoryBox, "Выберите категорию!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
