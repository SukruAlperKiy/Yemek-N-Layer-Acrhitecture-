//Bu kod, yazılım dünyasında "Generic Repository Pattern" (Genel Depo Deseni) olarak bilinen çok önemli bir yapıdır. Özetle; veritabanı işlemlerini (Ekleme, Silme, Güncelleme, Listeleme) her tablo için tek tek yazmak yerine, tek bir merkezden ve her tabloya uyum sağlayacak şekilde yapmanıza olanak tanır.
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Repositories
{
//  Sinif (GenericRepository) isminin yanindaki <T> ifadesi, bu sinifin her turlu tablo (Entity) ile calisabilecegini gosterir.
//  T yerine Product gelirse urunleri, T yerine Category gelirse kategorileri yonetir. 
                                                    // where T : class, kisaltmasi ise bu T parametresinin mutlaka bir "sinif" olmasi gerektigini yapar.
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
//  Burada veritabani baglama islemi (FoodyContext) sinifina dahil ediliyor. Bu sayede veritabanina erisim yetkisi kazaniyor.
        private readonly FoodyContext _context;
        public GenericRepository(FoodyContext context)
        {
            _context = context;
        }

        //  3) Temel CRUD islemleri.
//GetAll	Listeleme	Veritabanındaki tablonun tüm kayıtlarını getirir.
//GetById   Tekil       Getirme Belirtilen ID'ye sahip olan tek bir kaydı bulur.
//Insert    Ekleme      Yeni bir veriyi(entity) tabloya ekler.
//Update    Güncelleme  Mevcut bir veriyi günceller.
//Delete    Silme       Önce ID ile veriyi bulur, sonra veritabanından siler.
        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
