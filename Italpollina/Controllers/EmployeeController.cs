using Italpollina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Italpollina.Controllers
{
    public class EmployeeController : ApiController
    {

        public IHttpActionResult Post(EmployeeCreate employee)
        {
            if (employee == null)
                return BadRequest("Received model was null.");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return Ok("Hello " + employee.Name);

        }
    }
}
