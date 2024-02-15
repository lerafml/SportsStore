using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SportsStore.KendoUI.Models
{
    [XmlRoot("Список")]
    [XmlType("NewTypeName")]
    public class ItemsList
    {
        [XmlArray("Продукты"), XmlArrayItem("Продукт")]
        public List<Item> Items { get; set; } = new List<Item>();
    }

    public class Item
    {
        [XmlElement("Название")]
        public string Name { get; set; }

        [XmlElement("Категория")]
        public string Category { get; set; }

        [XmlElement("Описание")]
        public string Description { get; set; }
    
        [XmlElement("Цена")]
        public decimal Price { get; set; }
    }
}