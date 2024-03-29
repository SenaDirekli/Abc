﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soy Adınız")]
        public string SurName{ get; set; }

        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName{ get; set; }

        [Required]
        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage ="e posta adresinizi düzgün giriniz")]
        public string Email{ get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Şifre tekrar")]
        [Compare("Password", ErrorMessage ="şifreler aynı değil")]
        public string RePassword { get; set; }
    }
}