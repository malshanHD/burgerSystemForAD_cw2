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

    public partial class burger_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public burger_type()
        {
            this.tbl_burger = new HashSet<tbl_burger>();
        }

        public HttpPostedFileBase ImageFile { get; set; }
        public int typeID { get; set; }
        public string typeName { get; set; }
        public string typeImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_burger> tbl_burger { get; set; }
    }
}
