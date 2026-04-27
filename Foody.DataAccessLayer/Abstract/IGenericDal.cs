using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Abstract
{
    //buradaki T harfi aslinda yer tutucu. bu kodun sadece classlar tarafindan kullanilabilecegini soyluyor.
    public interface IGenericDal<T> where T: class
    {
      //bu kodlari da her (product, category gibi) class icin girdaha yazmayalim diye yazdik.
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);

    }
}
