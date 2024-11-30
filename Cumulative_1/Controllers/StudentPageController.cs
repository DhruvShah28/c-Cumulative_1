﻿using Microsoft.AspNetCore.Mvc;
using Cumulative_1.Models;

namespace Cumulative_1.Controllers
{
    public class StudentPageController : Controller
    {

        // API handles gathering all the data from
        // the Database and MVC is responsible for creating an HTTP response
        // and showing it on a web page that displays the data from database
        // to the View.

        private readonly StudentAPIController _api;

        public StudentPageController(StudentAPIController api)
        {
            _api = api;
        }

        public IActionResult SList()
        {
            List<Student> students = _api.LStudents();

            return View(students);
        }

        public IActionResult SShow(int id)
        {
            Student SelStudents = _api.StudentInfo(id);
            return View(SelStudents);
        }

        // GET : StudentPage/S_New
        [HttpGet]
        public IActionResult S_New(int id)
        {
            return View();
        }



        // POST: StudentPage/CreateStudent
        [HttpPost]
        public IActionResult CreateStudent(Student S_New)
        {
            int StudentId = _api.AddStudent(S_New);

            // redirects to "Show" action on "Student" cotroller with id parameter supplied
            return RedirectToAction("SShow", new { id = StudentId });
        }




        // GET : StudentPage/S_DeleteConfirm/{id}
        [HttpGet]
        public IActionResult S_DeleteConfirm(int id)
        {
            Student SelectedStudent = _api.StudentInfo(id);
            return View(SelectedStudent);
        }


        // POST: StudentPage/DeleteStudent/{id}
        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            int StudentId = _api.DeleteStudent(id);
            // redirects to list action
            return RedirectToAction("SList");
        }
    }
}
