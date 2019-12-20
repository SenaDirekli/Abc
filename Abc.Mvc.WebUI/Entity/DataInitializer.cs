using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Abc.Mvc.WebUI.Entity;

namespace UrunKatalog.Entitiy
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name=@Abc.Mvc.WebUI.Resources.lang.kategori2 ,Description="Kamera Ürünleri"},
                new Category(){Name=@Abc.Mvc.WebUI.Resources.lang.kategori3,Description="Bilgisayar Ürünleri"},
                new Category(){Name=@Abc.Mvc.WebUI.Resources.lang.kategori4,Description="Elektronik Ürünleri"},
                new Category(){Name=@Abc.Mvc.WebUI.Resources.lang.kategori5,Description="Telefon Ürünleri"},
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="NIKON D3500 18-15MM AF-P VR KIT 24.2 MP 3 EKRAN SLR DIJITAL FOTOĞRAF MAKİNESİ",Description="Büyük günlerden alışılageldik zamanlara, gerçek fotoğrafçılığın keyfini yaşayın. Kompakt D3500, üstün ürün kalitesiyle olağanüstü performansı harmanlar. Çaba gerektirmeyen kullanımı, hatırlanmaya değer anları onunla çekip paylaşmayı şaşırtıcı derecede kolay hale getirir", Price= 3299 ,Stock=200,IsApproved=true,CategoryId=1,IsHome=true,Image = "1.jpg"},
                new Product(){Name="NIKON D7200 18-140 VR LENS 24.2 MP DİJİTAL SLR FOTOĞRAF MAKİNESİ",Description="Büyük günlerden alışılageldik zamanlara, gerçek fotoğrafçılığın keyfini yaşayın. Kompakt D3500, üstün ürün kalitesiyle olağanüstü performansı harmanlar. Çaba gerektirmeyen kullanımı, hatırlanmaya değer anları onunla çekip paylaşmayı şaşırtıcı derecede kolay hale getirir", Price= 8599 ,Stock=100,IsApproved=true,CategoryId=1,IsHome=true,Image="2.jpg"},
                new Product(){Name="CANON EOS 4000D 18-55 DC 18 MP 3,0 LCD EKRAN SLR DIJITAL FOTOĞRAF MAKİNESİ",Description="Büyük günlerden alışılageldik zamanlara, gerçek fotoğrafçılığın keyfini yaşayın. Kompakt D3500, üstün ürün kalitesiyle olağanüstü performansı harmanlar. Çaba gerektirmeyen kullanımı, hatırlanmaya değer anları onunla çekip paylaşmayı şaşırtıcı derecede kolay hale getirir", Price= 1899 ,Stock=500,IsApproved=false,CategoryId=1,IsHome=true,Image="3.jpg"},
                new Product(){Name="CANON EOS 4000D 18-55 IS 18 MP 3,0 LCD EKRAN SLR DIJITAL FOTOĞRAF MAKİNESİ",Description="Büyük günlerden alışılageldik zamanlara, gerçek fotoğrafçılığın keyfini yaşayın. Kompakt D3500, üstün ürün kalitesiyle olağanüstü performansı harmanlar. Çaba gerektirmeyen kullanımı, hatırlanmaya değer anları onunla çekip paylaşmayı şaşırtıcı derecede kolay hale getirir", Price= 2099 ,Stock=300,IsApproved=true,CategoryId=1,IsHome=true,Image="4.jpg"},
                new Product(){Name="CANON EOS 77D 18-55 IS STM 24.2 MP 3 LCD EKRAN SLR DIJITAL FOTOĞRAF MAKİNESİ",Description="Büyük günlerden alışılageldik zamanlara, gerçek fotoğrafçılığın keyfini yaşayın. Kompakt D3500, üstün ürün kalitesiyle olağanüstü performansı harmanlar. Çaba gerektirmeyen kullanımı, hatırlanmaya değer anları onunla çekip paylaşmayı şaşırtıcı derecede kolay hale getirir", Price= 4699 ,Stock=500,IsApproved=false,CategoryId=1,Image="5.jpg"},

                new Product(){Name="MACBOOK AIR MREA2TU/A CORE İ5 1.6GHZ-8GB-128GBSSD-RETİNA-13.3-INT-SILVER",Description="En sevilen Mac, sizi kendine yeniden aşık edecek. Yeni MacBook Air daha ince ve daha hafif.", Price= 9199 ,Stock=200,IsApproved=true,CategoryId=2,IsHome=true,Image="1.jpg"},
                new Product(){Name="ASUS X542UR CORE İ5 8250U 1.6GHZ-8GB RAM-1TB HDD-2GB-15.6 W10 NOTEBOOK",Description="ASUS X540 yalnızca 1.9kg ağırlığında sağlam ve hafif bir kasaya sahiptir. Nerede olursanız olun yanınızda taşımayabileceğiniz üstün tasarıma sahip ideal bir dizüstü bilgisayardır.", Price= 4399 ,Stock=0,IsApproved=false,CategoryId=2,IsHome=true,Image="2.jpg"},
                new Product(){Name="LENOVO IDEAPAD 330 CORE İ7 8750H 2.2GHZ-16GB-1TB+128 SSD-17.3''GTX1050 4GB-W10",Description="Bazen sadelik en güzel şeydir. Premium işlemci ve gelişmiş grafik seçenekleriyle Ideapad 330, kullanımının kolay olduğu kadar güçlü bir bilgisayardır", Price= 8799 ,Stock=300,IsApproved=true,CategoryId=2,Image="3.jpg"},
                new Product(){Name="OMEN BY HP 15-DC0009NT CORE İ7 8750H 2.2GHZ-16GB-1TB+128-15.6''GTX1050TI 4GB-W10",Description="Gideceğin yerlerde ve oynayacağın oyunlarda gücünü göster. OMEN by HP 15 Dizüstü Bilgisayar ile performanstan ödün vermeden her yerde en iyi oyun deneyimini yaşayabilirsin. ", Price= 8999 ,Stock=200,IsApproved=true,CategoryId=2,Image="4.jpg"},

                new Product(){Name="LG 32TL420U 32''(81CM) IPS LED TV,DAHİLİ UYDU ALICILI",Description="Gerçek Renkler ve Daha Geniş İzleme Açısı", Price= 2199 ,Stock=250,IsApproved=true,CategoryId=3,Image="1.jpg"},
                new Product(){Name="VESTEL 49FD7400 49'' 124 CM FHD SMART TV,DAHİLİ UYDU ALICILI",Description="Dahili HD dijital uydu alıcı sayesinde uydu yayınlarını ekstra cihaza ihtiyaç duymadan doğrudan alabilirsiniz.", Price= 2689 ,Stock=0,IsApproved=false,CategoryId=3,IsHome=true,Image="2.jpg"},
                new Product(){Name="SAMSUNG UE 40N5300 40'' 101 CM FHD SMART TV,DAHİLİ UYDU ALICI",Description="Gerçek Renkler ve Daha Geniş İzleme Açısı", Price= 2199 ,Stock=300,IsApproved=true,CategoryId=3,IsHome=true,Image="3.jpg"},
                new Product(){Name="PHILIPS 43PFS5503 43'' 108 CM FHD TV,DAHİLİ UYDU ALICI",Description="Gelişmiş sadelik büyük ekranda. Philips 5500; full HD çözünürlük, net ses ve mükemmel görüntüleme deneyimi sunar.", Price= 2998 ,Stock=200,IsApproved=true,CategoryId=3,Image="4.jpg"},

                new Product(){Name="iPHONE XS MAX 512 GB AKILLI TELEFON",Description="Bugüne kadarki en büyük iPhone ekranı dahil iki farklı boyutta Super Retina. Daha da hızlı Face ID.", Price= 13999 ,Stock=250,IsApproved=true,CategoryId=4,Image="1.jpg"},
                new Product(){Name="SAMSUNG GALAXY A9 128 GB AKILLI TELEFON ",Description="Dünyada ilk: 4 arka kamera ile dört dörtlük eğlence.", Price= 4299 ,Stock=0,IsApproved=false,CategoryId=4,Image="2.jpg"},
                new Product(){Name="HUAWEI MATE 20 PRO 128 GB AKILLI TELEFON ",Description="Sınırsız insan hayali, HUAWEI Mate 20 Pro için ilham kaynağı. ", Price= 7999 ,Stock=300,IsApproved=true,CategoryId=4,IsHome=true,Image="3.jpg"},
                new Product(){Name="LG G7 THİNQ 64 GB AKILLI TELEFON ",Description="LG G7 THİNQ 64 GB AKILLI TELEFON ", Price= 4499 ,Stock=150,IsApproved=true,CategoryId=4,IsHome=true,Image="4.jpg"},
                new Product(){Name="VESTEL VENÜS Z20 64 GB AKILLI TELEFON",Description="Kusursuz tasarım ve etkileyici renklerle, teknoloji yepyeni bir görünüme büründü. Zamanın ruhuna uygun 18:9 mükemmel ekran oranı. Telefonu büyütmeden, daha fazla görüntü ve geniş ekran alanı. Şık ve göz alıcı.", Price= 1999 ,Stock=1000,IsApproved=true,CategoryId=4,Image="5.jpg"},

             };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}