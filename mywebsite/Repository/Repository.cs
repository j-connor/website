using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mywebsite.Entities;
using mywebsite.Extenders;

namespace mywebsite.Repository
{
    interface Repository<T, Tm> where T: Resource, new() where Tm: EntityModel, new()
    {
        T GetById(int resourceId);
        IEnumerable<T> GetAll();
    }
}
