using Localization.Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<HomeController> _stringLocalizer;
        

        public HomeController(IStringLocalizer<HomeController> homeControllerLocalizer)
                               
        {
            _stringLocalizer = homeControllerLocalizer;
           
        }

        [HttpGet]
        [Route("HomeControllerResource")]

       public string Get() 
        {
            return _stringLocalizer["Article"];
        }

    }
}
