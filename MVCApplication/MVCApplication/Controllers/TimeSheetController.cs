using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using System.Reflection;

namespace MVCApplication.Controllers
{
    public class TimeSheetController : Controller
    {

        private static List<TimeSheet> formDataList = new List<TimeSheet>();
        // GET: TimeSheetController
        public ActionResult Index()
        {
            return View(formDataList);
        }

        // GET: TimeSheetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeSheetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeSheetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TimeSheet timeSheet)
        {
            if (timeSheet.EndTime <= timeSheet.StartTime)
            {
                ModelState.AddModelError("endtime", "end time must be greater than start date.");
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("endtime", "end time must be greater than start date.");
                return View(timeSheet);
            }

            formDataList.Add(timeSheet);
             

            return RedirectToAction("Index",formDataList);
        }

        // GET: TimeSheetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeSheetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeSheetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeSheetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
