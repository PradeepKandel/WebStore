using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStoreNew.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int Users { get; set; }
        public int Categories { get; set; }
        public int Products { get; set; }
        public float Sales { get; set; }
    }
}