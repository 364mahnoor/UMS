using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UMS.Models;

namespace UMS.Controllers
{
    public class tbl_student_regController : Controller
    {
        private admissionSystemEntities db = new admissionSystemEntities();

        // GET: tbl_student_reg
        public ActionResult Index()
        {
            var tbl_student_reg = db.tbl_student_reg.Include(t => t.tbl_category).Include(t => t.tbl_depart).Include(t => t.tbl_depart1).Include(t => t.tbl_depart2);
            return View(tbl_student_reg.ToList());
        }

        // GET: tbl_student_reg/Details/5

       
        
    }
}
