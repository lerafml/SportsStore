using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SportsStore.Domain.Entities;

namespace SportsStoreWFA.Models
{
    public class ProductViewModel
    {
        [Required]
        [Display(Name = "Название продукта")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        //[UIHint("Price")]
        [Required]
        [Display(Name = "Цена")]
        [Range(typeof(decimal), "1", "1000000000000", ErrorMessage = "{0} должна быть больше {1}.00 руб.")]
        public decimal Price { get; set; }

        public Category Category { get; set; }

        [Required]
        [UIHint("GridForeignKey")]
        [Display(Name = "Категория")]
        public int CatID { get; set; }

        public byte[] ImageData { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }

        public string FileName { get; set; }

        //[UIHint("ImageModel")]
        [Display(Name = "Изображение")]
        public int ProductID { get; set; }
    }
}
