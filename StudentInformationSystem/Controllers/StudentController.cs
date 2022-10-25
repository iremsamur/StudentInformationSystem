using StudentInformationSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformationSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentInformationSystemDatabaseEntities1 db = new StudentInformationSystemDatabaseEntities1();
        // GET: Student
        public ActionResult Index()
        {
            var studentNumber = Session["StudentNumber"].ToString();
            var values = db.Student.Where(x => x.StudentNumber == studentNumber).FirstOrDefault();
            ViewBag.studentNameSurname = values.Individual.Name + " " + values.Individual.Surname;
            return View();
        }
    }
}