using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class product
    {
        public string ID { get; set; }

        public string name { get; set; }

        public bool isrecommand { get; set; }

        public string description { get; set; }

        public string category { get; set; }

        public string thumbnail { get; set; }

        public string description1 { get; set; }
    }
}