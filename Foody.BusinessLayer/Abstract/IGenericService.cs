using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Harika gidiyorsun! İzlediğin bu ders, projenin en kritik katmanı olan Business Layer (İş Katmanı) kurulumunu anlatıyor. DataAccessLayer (DAL) ile veritabanına giden yolu yapmıştın, şimdi bu yolda yürüyecek verilerin "kurallara uyup uymadığını" denetleyecek merkezi kuruyorsun.

İzlediğin videoda yapılanları adım adım, daha basit bir dille özetleyeyim:

1. Business Layer'ın Gerçek Amacı
Videoda da dendiği gibi, DAL sadece "kaydeder". Business ise "Nasıl kaydetmeli?" sorusuna cevap verir.

Örnek: "Ürün ismi 20 karakterden uzun olmasın."

Alet Çantası: Bu katmanda sadece kod yazmayacaksın; Fluent Validation (doğrulama), Logging (günlük tutma) ve Validation Rules (kurallar) gibi araçları kullanacaksın.

2. Klasör Yapısı (Düzen Her Şeydir)
Videoda Business katmanı altında 4 temel klasör oluşturuldu:

Abstract: İş sözleşmelerinin (Interface) duracağı yer. (IServicelar burada).

Concrete: İş yapan sınıfların (Manager) duracağı yer.

ValidationRules: "Ürün fiyatı boş olamaz" gibi kuralların yazılacağı yer (Fluent Validation).

Logging: İşlemler sırasında tutulacak kayıtların (log) yönetimi.

3. IGenericService: Genel Sözleşme
Tıpkı DAL'daki IGenericDal gibi, burada da bir IGenericService<T> oluşturuldu.

Fark: Videodaki eğitmen, metot isimlerinin başına "T" harfi koydu (TInsert, TUpdate gibi).

Neden? DataAccess katmanındaki metotlarla (Insert, Update) karışmasın diye. Yani kodun içinde "Ben şu an DAL'daki metodu mu çağırıyorum yoksa Business'taki metodu mu?" diye ikilemde kalmaman için bir işaret.

4. İsimlendirme Farkı (Dal vs. Service)
Videodaki en önemli kural şu:

DataAccess Layer'da: IProductDal (Interface) ve EfProductDal (Class) kullanmıştın.

Business Layer'da: IProductService (Interface) ve ProductManager (Class) kullanacaksın.

Mutfak Benzetmesi:

DAL: Buzdolabından malzemeyi getiren yardımcı.

Business (Service/Manager): Malzemeyi yıkayan, doğrayan ve tencereye uygun mu diye bakan aşçıbaşı.

UI (Sunum): Garsonun yemeği masaya servis etmesi.

5. Manager Sınıflarına Giriş
Dersin sonunda AboutManager sınıfı oluşturuldu. Bu sınıf:

IAboutService interface'ini uygulayacak (implement).

İçerisinde IAboutDalı çağıracak (Dependency Injection).

Gelen veriyi önce kontrol edecek (Validation), her şey yolundaysa DAL aracılığıyla veritabanına gönderecek.

Özetle: Videoda, projenin kurumsal standartlara uygun, güvenli ve organize bir şekilde büyümesi için gerekli olan "Denetleme Mekanizması"nın iskeleti kuruldu.

Bir sonraki adımda ProductManager yazarken, IProductDalı içine nasıl "enjekte" edeceğini (Dependency Injection) göreceksin. Bu kısım biraz kafa karıştırıcı gelebilir, hazır mısın?
 */
namespace Foody.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
