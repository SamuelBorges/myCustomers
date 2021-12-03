using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCustomers.Controllers;

namespace myCustomersTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void ListAllCustomers()
        {
            CustomerController customerAction = new CustomerController();
            
            IActionResult result = customerAction.CustomerList();
            
        }
    }
}
