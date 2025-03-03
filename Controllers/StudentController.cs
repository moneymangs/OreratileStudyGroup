using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OreratileStudyGroup.Models;

namespace OreratileStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<StudentTable> Student = new List<StudentTable>
            {
            new StudentTable
            {
            StudentNo = "u2387192",
            StudentName = "John",
            StudentSurname = "Doe",
            StudentEmail = "johndoe123@gmail.com"
            },

            new StudentTable
            {
            StudentNo = "u2417298",
            StudentName = "Rea",
            StudentSurname = "Thusi",
            StudentEmail = "thusirea123@gmail.com"
            },

            new StudentTable
            {
            StudentNo = "u2329088",
            StudentName = "Jack",
            StudentSurname = "Grealish",
            StudentEmail = "jackgr22@gmail.com"
            },

            new StudentTable
            {
            StudentNo = "u2277664",
            StudentName = "Pep",
            StudentSurname = "Team",
            StudentEmail = "pepteam123@gmail.com"
            },

            new StudentTable
            {
            StudentNo = "u2987654",
            StudentName = "Cho",
            StudentSurname = "Odi",
            StudentEmail = "odicho123@gmail.com"
            },


            };
            return View(Student);
        }
    }
}