using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using StudentInformationSystem.DTO;
using StudentInformationSystem.Models.Entities;


namespace StudentInformationSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        StudentInformationSystemDatabaseEntities1 db = new StudentInformationSystemDatabaseEntities1();

        [HttpGet]
        public ActionResult StudentSignInPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentSignInPage(Student student)
        {
            var values = db.Student.FirstOrDefault(x => x.Individual.Password == student.Individual.Password &&
            x.StudentNumber == student.StudentNumber);
            //ilişkili tablodan gelen değerler
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.StudentNumber, false);
                Session["StudentNumber"] = student.StudentNumber;
                return RedirectToAction("Index", "Student");

            }
            else
            {
                return RedirectToAction("StudentSignInPage");
            }
        }
       

    }
}