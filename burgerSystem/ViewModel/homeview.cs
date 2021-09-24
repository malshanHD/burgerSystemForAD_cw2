using burgerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace burgerSystem.ViewModel
{
    public class homeview
    {
        public IEnumerable<tbl_burger> burgers { get; set; }
        public IEnumerable<burger_type> burgerTypes { get; set; }
        public IEnumerable<burger_type> menu { get; set; }
    }
}