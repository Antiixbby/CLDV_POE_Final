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
    
    public partial class tbl_bodyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_bodyType()
        {
            this.tbl_modelInfo = new HashSet<tbl_modelInfo>();
        }
    
        public int bodyTypeID { get; set; }
        public string bodyType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_modelInfo> tbl_modelInfo { get; set; }
    }
}
