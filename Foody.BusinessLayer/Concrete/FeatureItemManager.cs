using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class FeatureItemManager : IFeatureItemService
    {
        private readonly IFeatureItemDal _featureItemDal;
        public FeatureItemManager(IFeatureItemDal featureItemDal31)
        {
            _featureItemDal = featureItemDal31;
        }
        public void TDelete(int id)
        {
            _featureItemDal.Delete(id);
        }

        public List<FeatureItem> TGetAll()
        {
            return _featureItemDal.GetAll();
        }

        public FeatureItem TGetById(int id)
        {
            return _featureItemDal.GetById(id);
        }

        public void TInsert(FeatureItem varlik)
        {
            _featureItemDal.Insert(varlik);
        }

        public void TUpdate(FeatureItem varlik12)
        {
            _featureItemDal.Update(varlik12);
        }
    }
}
