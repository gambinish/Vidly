using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET REQUESTS
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("customer/all")]
        public ActionResult CustomerList()
        {
            var customerList = new List<Customer>
            {
                new Customer() {Name = "Adam", Last = "Smith"},
                new Customer() {Name = "Thomas", Last = "Jefferson"}

            };
            var viewModel = new CustomerViewModel
            {
                Customer = customerList
            };
            return View(viewModel);
            //return Content("Testing Page");
        }
    }
}