using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.ViewModels.Shared;
using mywebsite.Entities;

namespace mywebsite.ViewModels.About
{
    public class IndexViewModel : ViewModel
    {
        public IEnumerable<CarouselResource> CarouselResources { get; set; }
        public IndexViewModel() : base()
        {

        }
    }
}