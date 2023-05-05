using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonCrud_Data;
using PersonCrud_Model.Models;

namespace PersonCrud_Model.Controllers
{
    public class PersonController : Controller
    {
        // GET: PersonController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowView()
        {
            return View();
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person p)
        {

            DBList.Add(p);

            Console.WriteLine(DBList.Instance()[DBList.Instance().Count - 1].ToString());


            return RedirectToAction("Create");
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person p)
        {
            try
            {
                foreach (var item in DBList.Instance())
                {
                    if (item.Id == p.Id)
                    {
                        item.Document = p.Document;
                        item.FirstName = p.FirstName;
                        item.LastName = p.LastName;
                        item.Birthdate = p.Birthdate;
                        item.Married = p.Married;
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        //// POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                DBList.Delete(id);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
