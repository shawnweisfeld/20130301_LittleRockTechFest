using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class CustomerController : ApiController
    {
        public List<Customer> Get()
        { 
            return Customer.GetList();
        }
    }
}
