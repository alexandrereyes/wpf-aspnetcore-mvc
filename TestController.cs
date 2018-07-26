using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WpfTest
{
    [AllowAnonymous]
    [Route("api")]
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("/myview")]
        public IActionResult MyView()
        {
            var v = View("myview.cshtml");
            return v;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("Good!");
        }
    }
}