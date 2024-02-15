using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.KendoUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Kendo.Mvc;

namespace SportsStore.KendoUI.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private IOrderProcessor orderProcessor;

        public CartController(IProductRepository repo, IOrderProcessor proc)
        {
            repository = repo;
            orderProcessor = proc;
        }

        public ViewResult Index()
        {
            return View();
        }

        public ActionResult ReadCart(Cart cart, [DataSourceRequest] DataSourceRequest request)
        {
            var result = cart.Lines.Select(l =>ConvertToViewModel(l)).ToList();

        
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult UpdateCart(Cart cart, [DataSourceRequest] DataSourceRequest request, CartItemsViewModel item)
        {
            if (item != null)
            {
                    Product product = repository.Products.FirstOrDefault(p => p.ProductID == item.id);
                    cart.UpdateLine(product, item.number);
                
            }
            CartLine line = cart.Lines.FirstOrDefault(l => l.Product.ProductID == item.id);
            var result = ConvertToViewModel(line);

            return Json(new[] { result }.ToDataSourceResult(request, ModelState));
        }

        private CartItemsViewModel ConvertToViewModel(CartLine l)
        {
            return new CartItemsViewModel
            {
                id = l.Product.ProductID,
                name = l.Product.Name,
                category = repository.Categories.FirstOrDefault(c => c.CatID == l.Product.CatID).CatName,
                description = l.Product.Description,
                number = l.Quantity,
                price = l.Product.Price,
                summary = l.Quantity * l.Product.Price
            };
        }

        public ActionResult AddToCartBox(Cart cart, int ProductId)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == ProductId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            var cartbox = new CartBoxView { Quantity = cart.Lines.Sum(x => x.Quantity), Summery = cart.ComputeTotalValue().ToString("c") };
            return Json ( new { message = "OK", result = cartbox });
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult RemoveFromCart(Cart cart, [DataSourceRequest] DataSourceRequest request, int id)
        {
            var line = cart.Lines.FirstOrDefault(x => x.Product.ProductID == id);

            if (line != null)
            {
                cart.RemoveLine(line.Product);
            }

            request.Aggregates.Add(new AggregateDescriptor { Member = "summary", Aggregates = { new SumFunction() { SourceField = "summary" } } });
            //var result = ReadCart(cart, request);
            return Json( new[] { ConvertToViewModel(line) }.ToDataSourceResult(request,ModelState));
        }
        
        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        public JsonResult GetCountry()
        {
            List<string> countries = new List<string>(new string[] { "Россия", "США", "Китай", "Италия", "Германия" });
            return Json(countries, JsonRequestBehavior.AllowGet);
        }
    }
}