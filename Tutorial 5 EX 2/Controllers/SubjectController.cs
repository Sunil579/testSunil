﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial_5_EX_2.Controllers
{
    public class SubjectController : Controller
    {
        // Dummy class to represent subjects
        public class Subject
        {
            public int SubjectID { get; set; }
            public string SubjectName { get; set; }
        }

        // GET: Subject
        public ActionResult Index()
        {
            return View();
        }

        // GET: Subjects
        public ActionResult Subjects()
        {
            
            var subjects = new List<Subject>
            {
                new Subject { SubjectID = 1, SubjectName = "Mathematics" },
                new Subject { SubjectID = 2, SubjectName = "Science" },
                new Subject { SubjectID = 3, SubjectName = "History" }
            };

            return View(subjects); // Pass the list to the view
        }

        // GET: Subject/Detail/5
        public ActionResult Detail(int SubjectID)
        {
           
            var subject = new Subject { SubjectID = SubjectID, SubjectName = "Sample Subject" };
            return View(subject); 
        }

        // GET: Subject/Edit/5
        public ActionResult Edit(int subjectID)
        {
           
            return View(); // Return a view to edit the subject
        }

        // GET: Subject/Deleted/5
        public ActionResult Deleted(int SubjectID)
        {
            
            return RedirectToAction("Index"); // Redirect to the Index view after deletion
        }
    }
}