using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxTry.Models;

namespace AjaxTry.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Table emp)
        {
            if(ModelState.IsValid==true) {
                string empname= emp.EMPLOYEE_NAME;
                string saveEmpname = char.ToUpper(empname[0]) + empname.Substring(1);
                emp.EMPLOYEE_NAME = saveEmpname;
                db.Tables.Add(emp);
                var a = db.SaveChanges();
                if (a > 0)
                {
                    return JavaScript("alert('Data Inserted')");
                }
                
            }
            else
            {
                return JavaScript("alert('Invalid')");
            }
            return View();
        }

        public ActionResult Index() {
            try
            {
                return View(db.Tables.ToList());
            }
            catch(Exception ex)
            {
                return View();
            }  
            
        }
        [HttpPost]
        public ActionResult Index(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                List<Table> emp = db.Tables.Where(e => e.EMPLOYEE_NAME.StartsWith(search)).ToList();
                return PartialView("_SearchData",emp);
            }
            else
            {
                List<Table> emp = db.Tables.ToList();
                return PartialView("_SearchData", emp);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}