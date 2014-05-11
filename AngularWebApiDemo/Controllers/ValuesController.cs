using AngularWebApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public MyViewModel Get()
        {
            return new MyViewModel
            {
                SiteName = "Default Site Name",
                Countries = new List<String>
                    {
                        "France",
                        "Germany",
                        "Spain",
                        "United Kingdom"
                    },
                Programs = new List<String> 
                    {
                        "Program 1",
                        "Program 2",
                        "Program 3"
                    }
            };
        }

       
    }
}
