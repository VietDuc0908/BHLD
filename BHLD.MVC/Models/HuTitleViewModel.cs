using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHLD.MVC.Models
{
    public class HuTitleViewModel
    {
        public int id { get; set; }
        public string code { get; set; }

        public string title_name { get; set; }

        public string remark { get; set; }

        public string actflg { get; set; }
        public string created_by { get; set; }

        public DateTime? created_date { get; set; }

        public string created_log { get; set; }

        public DateTime? modified_date { get; set; }
        public bool status { set; get; }
    }
}