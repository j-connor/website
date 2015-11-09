using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.Entities;

namespace mywebsite.Repository
{
    public class CarouselRepository : GenericRepository<CarouselResource, Entities.Entities>
    {
        public CarouselRepository() : base()
        {

        }
        
        public CarouselResource GetById(int resourceId)
        {
            return Context.CarouselResources.FirstOrDefault(r => r.ID.Equals(resourceId));
        }

        public IEnumerable<CarouselResource> GetAll()
        {
            return Context.CarouselResources;
            // only take first three elements
        }
    }
}