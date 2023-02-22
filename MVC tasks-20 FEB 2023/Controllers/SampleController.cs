using coremvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace coremvc.Controllers
{
    public class SampleController : Controller
    {
        public string hello(string name, int nos) //int nos =100 also can be done
        {
            return "Happy birthday" + name + "You are " + nos + "years old";  // /sample/hello?name=ram
        }

        //1

        //public IActionResult Index()
        //{
        //    return View(); 
        //}

        //2
        public IActionResult Index(string name, int nos = 0)  //for one
        {
            ViewData["name"] = name;   //go to index.cshtml page after this
            ViewData["nos"] = nos;
            return View();
        }
        public IActionResult GetCustomer()
        {
            Customer cust = new Customer()
            {
                Customerid = 1,
                Customername = "RAM",
                Contactno = "1234567890",
                Gender = "male",
                Address = "chennai"
            };
            return View("index2", cust);
        }
        public IActionResult Newcustomer()
        {
            return View();
        }

        //public IActionResult Samplecustomer()
        //{
        //    return RedirectToAction("getcustomer");  // /sample/newcustomer will display predefined values
        //}

        public IActionResult Samplecustomer(Customer customer)
        {
            return View("index2", customer);                  // /sample/newcustomer (put values) then we get sample customer with those values
        }
    }
}