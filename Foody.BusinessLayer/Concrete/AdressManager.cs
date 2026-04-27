using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AdressManager : IAdressService
    {
        private readonly IAdressDal _adressDal;
        public AdressManager(IAdressDal adressDal123)
        {
            _adressDal = adressDal123;
        }
        public void TDelete(int id)
        {
            _adressDal.Delete(id);
        }
        public List<Adress> TGetAll()
        {
            return _adressDal.GetAll();
        }
        public Adress TGetById(int id)
        {
            return _adressDal.GetById(id);
        }
        public void TInsert(Adress varlik)
        {
            _adressDal.Insert(varlik);
        }
        public void TUpdate(Adress varlik)
        {
            _adressDal.Update(varlik);
        }
    }
}
