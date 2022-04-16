using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class student_view_model
    {
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
        
        public int dep_id { get; set; }
        public string dep_name { get; set; }

    }
}