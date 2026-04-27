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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal123)
        {
            _categoryDal = categoryDal123;
        }
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public void TInsert(Category varlik)
        {
            _categoryDal.Insert(varlik);
        }
        public void TUpdate(Category varlik)
        {
            _categoryDal.Update(varlik);
        }

    }
}
