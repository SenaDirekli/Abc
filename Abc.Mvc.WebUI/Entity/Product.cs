using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.Mvc.WebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }

        [DisplayName("Ürün Stok Adedi")]
        public int Stock { get; set; }

        [DisplayName("Ürün Görselleri")]
        public string Image { get; set; }

        [DisplayName("Ürün Anasayfada")]
        public bool IsHome { get; set; }

        [DisplayName("Ürün Stokta")]
        public bool IsApproved { get; set; }

        [DisplayName("Ürün Adı")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}