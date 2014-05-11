using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularWebApiDemo.Models
{
    public class MyViewModel
    {
        public String SiteName { get; set; }
        public List<String> Countries { get; set; }
        public List<String> Programs { get; set; }
    }

}