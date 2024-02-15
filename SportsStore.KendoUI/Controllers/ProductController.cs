using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.KendoUI.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace SportsStore.KendoUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List()
        {
            return View();
        }

        public JsonResult DataBinding(int? CatId)
        {

            if (CatId.HasValue)
            {
                var categories = from c in repository.Categories
                                 select new
                                 {
                                     CatId = c.CatID,
                                     CatName = c.CatName,
                                     hasChildren = false
                                 };
                return Json(categories, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var categories = 
                                 new {
                                     CatId = 0,
                                     CatName = "All categories",
                                     hasChildren = true
                                 };
                return Json(new[] { categories }, JsonRequestBehavior.AllowGet);
            }
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

        public ActionResult ReadProducts([DataSourceRequest] DataSourceRequest request)
        {
            var result = GetProducts();
            return Json(result.ToDataSourceResult(request));
        }

        public FileContentResult GetImage(int productId)
        {
            Product prod = repository.Products.FirstOrDefault(p => p.ProductID == productId);
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
    }
}