﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori adı")]
        [StringLength(maximumLength:20,ErrorMessage="en fazla 20 karakter giriniz")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklama")]

        public string Description { get; set; }
        public List<Product> Products { get; set; }


    }
}