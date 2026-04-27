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
