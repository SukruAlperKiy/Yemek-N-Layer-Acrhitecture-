//Bu kod, bir .NET projesinde Entity Framework Core (EF Core) kullanılarak veritabanı ile uygulama arasındaki bağlantıyı sağlayan Context (Bağlam) sınıfıdır. Özetle, uygulamanızın veritabanındaki tabloları tanımasını ve onlarla iletişim kurmasını sağlar.
using Foody_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Context
{
//  1) DBCONTEXT mirasi.
//  burada FoodyContext'in DBContext'ten turedigi anlamina gelir. Bu sayede veritabaninda (Ekleme, Silme, listeleme, guncelleme) yapabilme ozelligi kazanir.
    public class FoodyContext:DbContext 
    {
//  2) OnConfiguring, uygulamanin hangi veritabanina nasil baglanacaginin belirlendigi yerdir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//  3) UseSqlServer, kullanilarak bir SQL Server veritabani kullanilacagi belirtilmis.
            optionsBuilder.UseSqlServer("Server = MSI\\SQLEXPRESS; initial catalog=FoodyDb; integrated security=true; TrustServerCertificate=True;");
        }
//  4) public DbSet<EntityName> TableName { get; set; } yapisi, projemizdeki siniflarin(class) veritabaninda birer tabloya karsilik gelmesini saglar.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<FeatureItem> FeatureItems { get; set; }

//  Kisaca bu kod:
//  1) C# kodlari ile SQL Server'i birlestirir (arasinda kopru kurar)
//  2) Tablolari eslestirir, Foody_EntityLayer icindeki siniflari (product, category, socialmedia vs.) alip bunlari sql server tablosuna donusturur.
//  3) Kod tarafinda bir "product" (urun) ekledigimizde bu Context sayesidnde veri otomatik olarak FoodyDb icerisindeki Products tablosuna yazilir.


        //  Eğer bu tablo yapılarını veritabanına yansıtmak istiyorsanız, Visual Studio'da Package Manager Console üzerinden add-migration ve ardından update-database komutlarını çalıştırmanız gerekecektir.
    }
}
