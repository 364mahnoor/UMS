//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_depart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_depart()
        {
            this.tbl_merit = new HashSet<tbl_merit>();
            this.tbl_student_reg = new HashSet<tbl_student_reg>();
            this.tbl_student_reg1 = new HashSet<tbl_student_reg>();
            this.tbl_student_reg2 = new HashSet<tbl_student_reg>();
        }
    
        public int dep_id { get; set; }
        public string dep_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_merit> tbl_merit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reg> tbl_student_reg { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reg> tbl_student_reg1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reg> tbl_student_reg2 { get; set; }
    }
}
