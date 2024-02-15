using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsStore.KendoUI.Models
{
    public class CartItemsViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }

        [Range(1, 100, ErrorMessage = "Недопустимое количество")]
        public int number { get; set; }
        public decimal price { get; set; }
        public decimal summary { get; set; }
    }
}