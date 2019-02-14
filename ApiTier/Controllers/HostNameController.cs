using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/hostname")]
    public class HostNameController : Controller
    {
        // GET api/hostname
        [HttpGet]
        public string Get()
        {
            return Environment.MachineName;
        }




    }
}
