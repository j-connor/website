using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.Entities;
using mywebsite.Repository;
using mywebsite.ViewModels.Shared;

namespace mywebsite.ViewModels.Home
{
    public class IndexViewModel : ViewModel
    {
        public IEnumerable<CarouselResource> CarouselResources { get; set; }

        public IndexViewModel() : base()
        {

        }
    }
}