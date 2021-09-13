using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myCustomers.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        public IActionResult CustomerList()
        {
            using (myclientsContext entity = new myclientsContext())
            {
                List<Customer> lista = entity.Customer.ToList();
                lista = lista.OrderByDescending(u => u.CdCustomer).ToList();
                ViewBag.Customer = lista.Take(10).ToList();
            }

            return View();
        }

        public IList<Customer> ListarClientes()
        {
            return null;
        }

    }
}
