using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AIFactoryAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/welcome")]
    public class WelcomeController : ApiController
    {
       

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetWelcomeData")]
        public IHttpActionResult GetWelcomeData()
        {
            return Ok(new
            {
                Status = "Success",
                Application = "My AI Factory API"
            });
        }
    }
}