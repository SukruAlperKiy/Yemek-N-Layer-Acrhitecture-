//Daha teknik bir ifadeyle: Bu sınıf, Entity Framework Core kullanarak Product (Ürün) tablosu için veritabanı işlemlerini gerçekleştiren sınıftır.
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
//  1)
//                              GenericRepository<Product>, Daha onceden yazdigimiz (Ekle, Sil, Guncelle) kismini miras alir.
//     Bu sayede EfProductDal, icine tek satir kod yazilmasa dahi bu sinif zaten urun eklemeyi, silmeyi, duzenlemeyi bilir.
//                                                          IProductDal,  
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
//  Disaridan bir FoodyContext (veritabani baglantisi) istenir. 
//  base(context), bu baglantiyi alip, miras aldigi ust sinifa (GenericRepository) gonderir.
//  Cunku veritabani islemlerini asil yapacak olan GenericRepository'dir ve onun calismak icin bu "context" nesnesine ihtiyaci vardir.
        public EfProductDal(FoodyContext context) : base(context)
        {
        }
    }
}

/*
3. Neden Böyle Bir Sınıfa İhtiyaç Var?
"Zaten GenericRepository her şeyi yapıyordu, neden her tablo için böyle boş sınıflar açıyoruz?" diyebilirsin. İşte sebepleri:

Özelleştirme Alanı: Yarın öbür gün "Ürünleri kategorileriyle birlikte getir" gibi sadece Product tablosuna özel bir SQL sorgusu yazman gerekirse, o kodu yazacağın yer tam olarak bu sınıfın içidir.

Katmanlı Mimari Kuralları: Mimari gereği, Business katmanı doğrudan GenericRepository ile değil, o tabloya özel olan EfProductDal (veya interface haliyle IProductDal) ile konuşur.


Özetle Bu Dosya:
GenericRepository'nin genel yeteneklerini Ürünler (Product) için özelleştirir.

Veritabanı teknolojisi olarak Entity Framework (Ef) kullandığını tesciller (Sınıf ismindeki Ef ön eki buradan gelir).

Boş görünse de aslında arkada devasa bir CRUD (Ekle-Oku-Güncelle-Sil) gücü taşır.
*/

