using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.Entities;
using mywebsite.Repository;
using mywebsite.Extenders;

namespace mywebsite.Repository
{
    public class NavbarRepository : GenericRepository<NavbarResource, Entities.Entities>
    {
        public NavbarRepository() : base()
        {

        }

        public NavbarResource GetById(int resourceId)
        {
            return Context.NavbarResources.FirstOrDefault(r => r.ID.Equals(resourceId));
        }

        public IEnumerable<NavbarResource> GetAll()
        {
            return Context.NavbarResources;
        }
    }
}