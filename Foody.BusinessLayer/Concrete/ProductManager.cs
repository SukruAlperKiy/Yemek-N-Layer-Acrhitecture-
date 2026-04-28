using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Bu video, projenin en "akıllı" kısmını, yani Manager (Yönetici) 
sınıflarını nasıl inşa edeceğini anlatıyor. 
Önceki derste "sözleşmeleri" (Interface) yapmıştın, 
şimdi bu sözleşmelere göre gerçekten iş yapacak olan sınıfları oluşturuyorsun.
Videoda olanları senin için parçalara ayırdım:
1. Dependency Injection (Bağımlılık Enjeksiyonu) Nedir?
Videoda eğitmenin üzerinde en çok durduğu konu bu. 
Bir sınıfın içinde başka bir sınıfa ihtiyaç duyduğunda, o
nu new anahtar kelimesiyle oluşturmak yerine (yani ona sıkı sıkıya bağlanmak yerine),
dışarıdan "enjekte" ediyorsun.Neden? Çünkü AboutManager sınıfı, 
veritabanına nasıl bağlanılacağını bilmek zorunda değil; 
o sadece iş kurallarını bilir. Veri işini yapacak olan IAboutDalı ona dışarıdan veririz. 
Bu da kodu esnek ve test edilebilir yapar (Loosely Coupled).
2. Bir Manager Sınıfı Nasıl İnşa Edilir? (Adım Adım)Eğitmen AboutManager üzerinden şu yolu izledi:
Miras Alma: AboutManager sınıfı, IAboutService arayüzünü miras aldı. 
Bu, "Ben bir About servisiyim" demektir.
DAL Enjeksiyonu: Sınıfın içine private readonly IAboutDal _aboutDal; 
şeklinde bir değişken tanımladı.
Constructor (Yapıcı Metot): Veritabanı işlerini yapacak olan DAL nesnesini, 
constructor üzerinden içeriye aldı.
İpucu: Control + . kısayolunu kullanarak Visual Studio'ya constructor'ı otomatik oluşturttu.
3. Metotların İçini Doldurma (Paslaşma)Burada çok önemli bir kural var: 
Business Layer metotları, Data Access Layer metotlarını çağırır.
Business Metodu (Service)Yaptığı İşÇağırdığı DAL MetoduTInsertEkleme emri verir.
_aboutDal.Insert(entity)TDeleteSilme emri verir._aboutDal.Delete(id)TGetListAllListeleme emri verir.
_aboutDal.GetAll()Neden metotların başında "T" var?Eğitmenin de dediği gibi; 
Business katmanındaki metotlar ile DAL katmanındaki metotlar karışmasın diye Business tarafındakilere "T" (Transaction/Task gibi düşünülebilir) ön eki getirildi.
 */
namespace Foody.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal123)
        {
            _productDal = productDal123;
        }
        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }
        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }
        public void TInsert(Product varlik)
        {
            _productDal.Insert(varlik);
        }
        public void TUpdate(Product varlik)
        {
            _productDal.Update(varlik);
        }
    }
}
