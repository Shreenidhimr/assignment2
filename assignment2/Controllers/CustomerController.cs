using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using assignment2.Entities;
using assignment2.Repositories;
namespace assignment2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRespository _repo_ = new CustomerRespository();

        
        // GET: HomeController1
        public ActionResult Index()
        {
           List<Customer> list=_repo_.GetCustomers();
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(string id)
        {
            Customer c = _repo_.GetCustomerById(id);
            return View(c);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            { 
            if (ModelState.IsValid)
            {

                    _repo_.Add(c);
                return RedirectToAction(nameof(Index));
            }
            else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(string id)
        {
           Customer c= _repo_.GetCustomerById(id);
            return View(c);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)
        {
            try
            {
                _repo_.Update(c);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(string id)
        {
            Customer c = _repo_.GetCustomerById(id);
            return View(c);
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer c)
        {
            try
            {
                
                _repo_.Delete(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
