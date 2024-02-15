using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.KendoUI.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Drawing;

namespace SportsStore.KendoUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [Authorize]
        public ViewResult Index()
        {
            PopulateCategories();
            PopulateImages();
            return View();
        }

        public ActionResult ReadCategories([DataSourceRequest] DataSourceRequest request)
        {
            var result = repository.Categories.ToList();
            return Json(result.ToDataSourceResult(request));
        }

        public IList<ProductViewModel> GetProducts()
        {
            var result = repository.Products.Select(product => new ProductViewModel
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
            return result;
        }

        public FileContentResult GetImage(int ProductID)
        {
            Product prod = repository.Products.FirstOrDefault(p => p.ProductID == ProductID);
            if (prod != null)
            {
                if (prod.ImageData != null)
                {
                    return File(prod.ImageData, prod.ImageMimeType);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public ActionResult ReadProducts([DataSourceRequest] DataSourceRequest request)
        {
            var result = GetProducts();
            JsonResult jr = Json(result.ToDataSourceResult(request));
            jr.MaxJsonLength = int.MaxValue;
            return jr;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditCategory([DataSourceRequest] DataSourceRequest request, Category category)
        {
            var cat = repository.Categories.FirstOrDefault(c => c.CatName == category.CatName);
            if (category != null && ModelState.IsValid && cat == null)
            {
                var target = repository.Categories.FirstOrDefault(e => e.CatID == category.CatID);
                target.CatID = category.CatID;
                target.CatName = category.CatName;
                repository.SaveCategory(target);
            }
            else if (cat != null)
            {
                ModelState.AddModelError("error", "Такая категория уже существует!");
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditProduct([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                var target = repository.Products.FirstOrDefault(e => e.ProductID == product.ProductID);
                string path;
                target.Name = product.Name;
                target.Description = product.Description;
                target.Price = product.Price;
                target.CatID = product.CatID;
                if (product.FileName != null)
                {
                    path = Path.Combine(Server.MapPath("~/App_Data/Images"), product.FileName);
                    target.ImageData = System.IO.File.ReadAllBytes(path);
                    target.ImageMimeType = product.ImageMimeType;
                }
                repository.SaveProduct(target);
            }
            System.IO.DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/App_Data/Images"));
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateCategory([DataSourceRequest] DataSourceRequest request, Category category)
        {
            var cat = repository.Categories.FirstOrDefault(c => c.CatName == category.CatName);
            if (category != null && ModelState.IsValid && cat == null)
            {
                var entity = new Category {
                    CatID = category.CatID,
                    CatName = category.CatName
                };
                repository.SaveCategory(entity);
                category.CatID = entity.CatID;
            }
            else if (cat != null)
            {
                ModelState.AddModelError("error", "Такая категория уже существует!");
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        public Category GetCategory(string catName)
        {
            var result = repository.Categories.FirstOrDefault(e => e.CatName == catName);
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateProduct([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                string path;
                var entity = new Product();
                entity.ProductID = product.ProductID;
                entity.Name = product.Name;
                entity.Description = product.Description;
                entity.Price = product.Price;
                entity.CatID = product.CatID;
                if (entity.CatID == 0)
                {
                    entity.CatID = 1;
                }

                if (product.Category != null)
                {
                    entity.CatID = product.Category.CatID;
                }
                if (product.FileName != null)
                {
                    path = Path.Combine(Server.MapPath("~/App_Data/Images"), product.FileName);
                    entity.ImageData = System.IO.File.ReadAllBytes(path);
                    entity.ImageMimeType = product.ImageMimeType;
                }
                repository.SaveProduct(entity);
                product.ProductID = entity.ProductID;
            }
            System.IO.DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/App_Data/Images"));
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DeleteCategory([DataSourceRequest] DataSourceRequest request, Category category)
        {
            if (category != null)
            {
                repository.DeleteCategory(category.CatID);
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DeleteProduct([DataSourceRequest] DataSourceRequest request, Product product)
        {
            if (product != null)
            {
                repository.DeleteProduct(product.ProductID);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        public void PopulateCategories()
        {
            var categories = repository.Categories.ToList().OrderBy(e => e.CatName);
            ViewData["categories"] = categories;
        }

        public void PopulateImages()
        {
            var imgs = repository.Products.Select(i => new
            {
                ProductID = i.ProductID,
                ImageData = i.ImageData,
                ImageMimeType = i.ImageMimeType
            }).ToList();
            ViewData["imgs"] = imgs;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SaveImage(HttpPostedFileBase image)
        {
            if (image != null)
            {
                var fileName = Path.GetFileName(image.FileName);
                var physicalPath = Path.Combine(Server.MapPath("~/App_Data/Images"), fileName);

                image.SaveAs(physicalPath);
                ViewData["img"] = fileName;
            }
            return Content("");
        }

        [HttpPost]
        public ActionResult Export(string contentType, string base64, string fileName)
        {
            Console.WriteLine(contentType);
            var fileContents = Convert.FromBase64String(base64);
            return File(fileContents, contentType, fileName);
        }

        public List<XElement> ToChildsList(XElement elem)
        {
            List<XElement> list = new List<XElement>();
            IEnumerable<XNode> dnas =
                from node in elem.DescendantNodesAndSelf()
                select node;
            foreach (XNode node in dnas)
            {
                if (node is XElement)
                    list.Add(node as XElement);
                else
                    Console.WriteLine("Node is not XElement");
            }
            return list;
        }

        public string GetColumnName(Product p, string col_name)
        {
            string column = "";
            string[] input =
            {
                "Name",
                "Description",
                "Price",
                "Category"
            };
            List<string> columns = new List<string>(input);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == col_name)
                {
                    column = input[i];
                }
            }
            return column;
        }

        public void AddElement(Product p, List<XElement> list, string col_name)
        {
            var column = GetColumnName(p, col_name);
            if (col_name == "Category")
            {
                Category cat = repository.Categories.FirstOrDefault(c => c.CatID == p.CatID) as Category;
                XElement el = new XElement(col_name, cat.CatName);
                list.Add(el);
            }
            else if (col_name == "Name")
            {
                list.Add(new XElement(col_name, p.Name));
            }
            else if (col_name == "Description")
            {
                list.Add(new XElement(col_name, p.Description));
            }
            else if (col_name == "Price")
            {
                list.Add(new XElement(col_name, p.Price));
            }
            else
            {
                Console.WriteLine("There's no such column!");
            }
        }
        
        public XDocument GetXML(List<Product> list)
        {
            XElement root = new XElement("ItemsList");
            XElement items = new XElement("Items");
            root.Add(items);
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            List<Product> prods = repository.Products.ToList();
            List<XElement> name = new List<XElement>();
            List<XElement> description = new List<XElement>();
            List<XElement> price = new List<XElement>();
            List<XElement> category = new List<XElement>();
            foreach (Product p in prods)
            {
                AddElement(p, name, "Name");
                AddElement(p, description, "Description");
                AddElement(p, category, "Category");
                AddElement(p, price, "Price");
                items.Add(new XElement ("Item",
                            name.Last() as XElement,
                            category.Last() as XElement,
                            description.Last() as XElement,
                            price.Last() as XElement
                        ));
            }
            return doc;
        }

        public ItemsList ToItemsList(IEnumerable<Product> list)
        {

            ItemsList il = new ItemsList();
            List<Item> li = new List<Item>();
            foreach (Product p in list)
            {
                li.Add(new Item {
                    Name = p.Name,
                    Category = repository.Categories.FirstOrDefault(c => c.CatID == p.CatID).CatName,
                    Description = p.Description,
                    Price = p.Price
                });
            }
            il.Items = li;
            return il;
        }

        public ActionResult ExportXML()
        {
            //var doc = GetXML(repository.Products.ToList());
            //doc.Save("Продукты.xml");
            //var xml_string = doc.ToString();
            //byte[] xml_array = System.Text.Encoding.GetEncoding(1251).GetBytes(xml_string);
            //return File(xml_array, "application/xml", "Продукты.xml");

            ItemsList collection = ToItemsList(repository.Products.ToList());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ItemsList));
            MemoryStream ms = new MemoryStream();
            XmlTextWriter xmlWriter = new XmlTextWriter(ms, Encoding.GetEncoding(1251));
            xmlWriter.Formatting = Formatting.Indented;
            XmlWriter xw = (XmlWriter)xmlWriter;
            xmlSerializer.Serialize(xw, collection);
            xw.Close();
            return File(ms.ToArray(), "application/xml", "Продукты.xml");
            
            //xmlSerializer.Serialize(stringWriter, collection);
            //byte[] xml_array = System.Text.Encoding.GetEncoding(1251).GetBytes(stringWriter.ToString());
            //MemoryStream ms = new MemoryStream();

            //return File(xml_array, "application/xml", "Продукты.xml");

           
        }

        public ActionResult SaveAsync(HttpPostedFileBase file)
        {
            if (file != null)
            {
                //foreach (var file in files)
               // {
                    // Some browsers send file names with full path.
                    // We are only interested in the file name.
                    var fileName = Path.GetFileName(file.FileName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    // The files are not actually saved in this demo
                    // file.SaveAs(physicalPath);
              //  }
            }

            // Return an empty string to signify success
            return Content("");
        }

        public ActionResult Remove(string fullName)
        {
            // The parameter of the Remove action must be called "fileNames"

            if (fullName != null)
            {
                //foreach (var fullName in fileNames)
                //{
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    // TODO: Verify user permissions

                    if (System.IO.File.Exists(physicalPath))
                    {
                        // The files are not actually removed in this demo
                        System.IO.File.Delete(physicalPath);
                    }
                //}
            }

            // Return an empty string to signify success
            return Content("");
        }

        public ItemsList GetItemsList(HttpPostedFileBase file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ItemsList));
            string fileName = Path.GetFileName(file.FileName);
            string path = Path.Combine(Server.MapPath("~/App_Data/Uploads"), fileName);
            file.SaveAs(path);
            StreamReader sr = new StreamReader(path,Encoding.GetEncoding(1251), false);
            try
            {
                var obj = (ItemsList)serializer.Deserialize(sr);
                sr.Close();
                return obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                sr.Close();
                return new ItemsList();
            }
        }

        public ActionResult ImportFromXML(IEnumerable<HttpPostedFileBase> files)
        {
            
            string status = "success";
            string message = "Изменения успешно сохранены.";
            List<string> fix = new List<string>();
            if (files != null)
            {
                var err = 0;
                var xml = GetItemsList(files.First());
                if (xml.Items != null)
                {
                    foreach (Item product in xml.Items)
                    {
                        Product first = repository.Products.FirstOrDefault(p => p.Name == product.Name);
                        if (first == null)
                        {
                            var entity = new Product();
                            entity.ProductID = 0;
                            entity.Name = product.Name;
                            entity.Description = product.Description;
                            entity.Price = product.Price;
                            var category = repository.Categories.FirstOrDefault(c => c.CatName == product.Category);
                            if (category == null)
                            {
                                if (err == 0)
                                {
                                    err++;
                                    message = "Проверьте название категории для: ";
                                    status = "error";
                                }

                                fix.Add(product.Name);
                            }
                            else
                            {
                                entity.CatID = category.CatID;
                                entity.Category = category;
                                repository.SaveProduct(entity);
                            }
                        }
                        else
                        {
                            first.Name = product.Name;
                            first.Description = product.Description;
                            first.Price = product.Price;
                            var category = repository.Categories.FirstOrDefault(c => c.CatName == product.Category);
                            if (category == null)
                            {
                                if (err == 0)
                                {
                                    err++;
                                    message = "Проверьте название категории для: ";
                                    status = "error";
                                }

                                fix.Add(product.Name);
                            }
                            else
                            {
                                first.CatID = category.CatID;
                                first.Category = category;
                                repository.SaveProduct(first);
                            }
                        }
                    }
                }
            }
            else
            {
                message = "XML файл не загружен!";
                status = "error";
            }
            foreach (string name in fix)
            {
                message += name;
                message += ", ";
            }
            return Json(new { status = status, message = message });
        }
    }
}