//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace burgerSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class tbl_burger
    {
        public HttpPostedFileBase ImageFile { get; set; }
        public int BurgerID { get; set; }
        public string BurgerName { get; set; }
        public Nullable<int> typeID { get; set; }
        public decimal UnitPrice { get; set; }
        public string BurgerWeight { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    
        public virtual burger_type burger_type { get; set; }
    }
}
