using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Hours
    {
        public int ID { get; set; }
        public int dayofweek { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
    }
}