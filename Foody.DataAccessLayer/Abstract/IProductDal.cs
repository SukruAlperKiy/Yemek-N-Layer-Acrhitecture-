using Foody_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Abstract
{
//  public interface IProductDal : IGenericDal<Product> yazarak,
//  IProductDal, sen IGenericDal icerisindeki tum EKLE/SIL/GUNCELLE, kodlarini miras al,
//  Ama bunlari Product sinifina gore uyarla.
    public interface IProductDal : IGenericDal<Product>
    {
        //Örnek: Tüm ürünleri listelemek (GetAll) standarttır.
        //Ama "Kategorisi 'Meyve' olan ve fiyatı 100 TL'den düşük ürünleri getir" gibi sadece Product tablosuna özel bir sorgu yazman gerekirse,
        //bu metodu IGenericDal içine koyamazsın (çünkü o zaman Category tablosu da bu metodu zorla almak zorunda kalır).
   
        //Iste bu yuzden IProductDal acariz boylece sadece bu tabloya ozel SELECT'leri yazabiliriz.
    }
}
//Kisaca,
//Dosya               Görevi                                              Benzetme
//IGenericDal         Genel kuralları belirler.                           Anayasa

//IProductDal         Ürünlere özel kuralları belirler.               Ürün Yönetmeliği

//Abstract Klasörü    Tüm bu kural kitapçıklarının (Interface) durduğu yer.         Kütüphane Arşivi