using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Models;

namespace UMS.Controllers
{
    public class StudentController : Controller
    {

        admissionSystemEntities db = new admissionSystemEntities();
        // GET: Student
        public ActionResult Index()
        {

            List<tbl_depart> li = db.tbl_depart.ToList();
            ViewBag.dep_list = new SelectList(li, "dep_id", "dep_name");

            List<tbl_category> li2 = db.tbl_category.ToList();
            ViewBag.cat_list = new SelectList(li2, "cat_id", "cat_name");


            return View();
        }

        [HttpPost]
        public ActionResult Index(student_view_model svm, HttpPostedFileBase imgfile, HttpPostedFileBase SSCfile, HttpPostedFileBase  HSCfile  )
        {

            List<tbl_depart> li = db.tbl_depart.ToList();
            ViewBag.dep_list = new SelectList(li, "dep_id", "dep_name");

            List<tbl_category> li2 = db.tbl_category.ToList();
            ViewBag.cat_list = new SelectList(li2, "cat_id", "cat_name");
            string imgpath = uploadimage(imgfile);
            string sscpath = uploadimage(SSCfile);
            string hscpath = uploadimage(HSCfile);

            if (imgpath.Equals("-1") || sscpath.Equals("-1") || hscpath.Equals("-1"))
            {
                Response.Write("Some error");

                return View("Index");
            }
            else
            {
                tbl_student_reg reg = new tbl_student_reg();
                reg.r_cnic = svm.r_cnic;
                reg.r_password = svm.r_password;
                reg.r_fullname = svm.r_fullname;
                reg.r_father_name = svm.r_father_name;
                reg.r_mobile = svm.r_mobile;
                reg.r_phone = svm.r_phone;
                reg.r_matric = svm.r_matric;
                reg.r_intermarks = svm.r_intermarks;
                reg.r_cat = svm.r_cat;
                reg.r_image = imgpath;
                reg.r_ssc_marksheet = sscpath;
                reg.r_hsc_marksheet = hscpath;
                reg.r_p1 = svm.r_p1;
                reg.r_p2 = svm.r_p2;
                reg.r_p3 = svm.r_p3;
                reg.r_status = 0;
                reg.r_date = System.DateTime.Now;
                db.tbl_student_reg.Add(reg);
                db.SaveChanges();
                return RedirectToAction("StudentProfile");

            }
            return View("");

        }

        public ActionResult Student_Profile()
        {

            List<tbl_student_reg> re = db.tbl_student_reg.ToList();
            List<student_view_model> svmlist = re.Select(x => new student_view_model

            {
                r_id = x.r_id,
                r_cnic = x.r_cnic,
                r_password = x.r_password,
                r_fullname = x.r_fullname,
                r_father_name = x.r_father_name,
                r_mobile = x.r_mobile,
                r_phone = x.r_phone,
                r_intermarks = x.r_intermarks,
                r_matric = x.r_matric,
                r_status = x.r_status,
                r_date = x.r_date,
                
                r_image = x.r_image,
   
                r_cat = x.r_cat,
                r_hsc_marksheet = x.r_hsc_marksheet,
                r_ssc_marksheet =x.r_ssc_marksheet



            }).ToList();





            return View(svmlist);
        }


      




            public string uploadimage(HttpPostedFileBase file)
        {
            Random r = new Random();

            string path = "-1";

            int random = r.Next();

            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);

                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {

                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload/"), random + Path.GetFileName(file.FileName));

                        file.SaveAs(path);

                        path = "~/Content/upload/" + random + Path.GetFileName(file.FileName);
                    }

                    catch (Exception ex)
                    {
                        path = "-1";

                    }

                }
                else
                {
                    Response.Write("<script>alert('ONLY JPG,JPEG AND PNG  Formats are Acceptable'); </script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Select a File'); </script>");

                path = "-1";
            }
            return path;

        }


    }
}