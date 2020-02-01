using GradesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;

namespace GradesManager.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var data = StudentProcessor.LoadStudents();

            List<StudentModel> students = new List<StudentModel>();

            foreach (var row in data)
            {
                students.Add(new StudentModel
                {
                    id = row.id,
                    DNI = row.DNI,
                    FirstName = row.FirstName,
                    SecondName = row.SecondName,
                    FirstLastName = row.FirstLastName,
                    SecondLastName = row.SecondLastName
                });
            }

            return View(students);
        }

        public ActionResult CreateStudent()
        {
            ViewBag.Message = "Student Create Module";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStudent(StudentModel model)
        {
            if (ModelState.IsValid) 
            {
                int recordsCreated = StudentProcessor.CreateStudent(model.FirstName, 
                                        model.SecondName, model.FirstLastName,
                                        model.SecondLastName, model.DNI);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}