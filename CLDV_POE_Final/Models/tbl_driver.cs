//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLDV_POE_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_driver()
        {
            this.tbl_carInspectorDriver = new HashSet<tbl_carInspectorDriver>();
        }
    
        public int driverID { get; set; }
        public Nullable<int> personID { get; set; }
        public string driverAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_carInspectorDriver> tbl_carInspectorDriver { get; set; }
        public virtual tbl_person tbl_person { get; set; }
    }
}