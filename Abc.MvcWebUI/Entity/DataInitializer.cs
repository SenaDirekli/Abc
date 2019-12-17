using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kahve",Description="Kahve Ürünleri"},
                new Category(){Name="SoğukKahve",Description="Soğuk Kahve Çeşitleri"},
                new Category(){Name="Sıcak Kahve",Description="Sıcak Kahve Çeşitleri"},
                new Category(){Name="Geleneksel Kahve",Description="Geleneksel Kahve Çeşitleri"},
                new Category(){Name="Kahve",Description="Kahve Ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=1, IsHome=true, Image="1.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=1,IsHome=true, Image="2.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=1,IsHome=true, Image="3.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=1,IsHome=true, Image="4.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=1, Image="5.JPG"},

                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=2,IsHome=true, Image="1.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=2,IsHome=true, Image="2.JPG"},
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=2, Image="3.JPG"},
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=2, Image="4.JPG"},
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=2, Image="5.JPG"},

                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=3,IsHome=true, Image="1.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=3,IsHome=true, Image="2.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500, IsApproved=true,CategoryId=3,IsHome=true, Image="3.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=3, Image="4.JPG"},
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=3, Image="5.JPG"},

                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=4,IsHome=true, Image="1.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500 ,IsApproved=true,CategoryId=4,IsHome=true, Image="2.JPG"},
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500, IsApproved=true,CategoryId=4,IsHome=true, Image="3.JPG" },
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=4, Image="4.JPG"},
                new Product(){Name="mocha",Description="Espresso’nun süt ve çikolata ile buluşmuş hali Mocha ya da Caffè mocha olarak adlandırılır. Yapımında çikolatanın şurup, toz ya da sos hali kullanılır. Damak tadına göre beyaz çikolatalı ve bitter çikolatalı versiyonları da mevcuttur.",Price=24,Stock=2500,IsApproved=true,CategoryId=4, Image="5.JPG"},
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