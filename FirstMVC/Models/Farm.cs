using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Farm
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string pay { get; set; }

        public string category { get; set; }

        public string season { get; set; }

        public string belong { get; set; }

        public bool recommand { get; set; }

        public string k { get; set; }

        public string Thumbnail { get; set; }
    }
}