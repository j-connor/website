using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.Entities;
using mywebsite.Repository;

namespace mywebsite.ViewModels.Shared
{
    public class ViewModel
    {
        public IEnumerable<NavbarResource> NavbarItems { get; set; }

        public ViewModel()
        {
            var repo = new NavbarRepository();
            NavbarItems = repo.GetAll().OrderBy(r => r.Ordinal);
        }
    }
}