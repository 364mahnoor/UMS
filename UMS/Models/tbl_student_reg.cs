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
    
    public partial class tbl_student_reg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_reg()
        {
            this.tbl_merit = new HashSet<tbl_merit>();
        }
    
        public int r_id { get; set; }
        public string r_cnic { get; set; }
        public string r_password { get; set; }
        public string r_fullname { get; set; }
        public string r_father_name { get; set; }
        public string r_mobile { get; set; }
        public string r_phone { get; set; }
        public Nullable<int> r_intermarks { get; set; }
        public Nullable<int> r_matric { get; set; }
        public Nullable<int> r_status { get; set; }
        public Nullable<System.DateTime> r_date { get; set; }
        public string r_image { get; set; }
        public Nullable<int> r_p1 { get; set; }
        public Nullable<int> r_p2 { get; set; }
        public Nullable<int> r_p3 { get; set; }
        public Nullable<int> r_cat { get; set; }
        public string r_hsc_marksheet { get; set; }
        public string r_ssc_marksheet { get; set; }
    
        public virtual tbl_category tbl_category { get; set; }
        public virtual tbl_depart tbl_depart { get; set; }
        public virtual tbl_depart tbl_depart1 { get; set; }
        public virtual tbl_depart tbl_depart2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_merit> tbl_merit { get; set; }
    }
}
