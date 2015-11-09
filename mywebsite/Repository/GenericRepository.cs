using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.Entities;
using mywebsite.Extenders;

namespace mywebsite.Repository
{
    public class GenericRepository<T, Tm>
        where T : Resource, new()
        where Tm : EntityModel, new() 
    {
        public Tm Context { get; private set; }

        public GenericRepository()
        {
            Context = new Tm();
        }
    }
}