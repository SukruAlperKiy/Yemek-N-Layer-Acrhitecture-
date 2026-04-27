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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal FeatureDal123)
        {
            _featureDal = FeatureDal123;
        }
        public void TDelete(int id)
        {
            _featureDal.Delete(id);
        }
        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }
        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }
        public void TInsert(Feature varlik)
        {
            _featureDal.Insert(varlik);
        }
        public void TUpdate(Feature varlik)
        {
            _featureDal.Update(varlik);
        }

    }
}
