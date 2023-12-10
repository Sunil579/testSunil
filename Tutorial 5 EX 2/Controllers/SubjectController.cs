using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial_5_EX_2.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public String Index()
        {
            return "this page is to show subject home page";
        }
        public String subjects()
        {
            return "This page is to show subjects that the student is enrolled in ";
        }
        public string Detail(string SubjectID)
        {

            return HttpUtility.HtmlEncode("Subjectcode ;" + SubjectID);

        }
        public ActionResult Edit(int subjectID)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Deleted(int SubjectID)
        {
            return RedirectToAction("Index");
        }

    }
}