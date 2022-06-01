using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class SearchModel
    {
        public string season { get; set; }

        public string q { get; set; }

        public string recommand { get; set; }

        public string BackUrl { get; set; }
    }
}