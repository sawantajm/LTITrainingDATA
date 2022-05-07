
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uploadImage.Models;

namespace uploadImage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageuploadsController : ControllerBase
    {
        private readonly pracrticeContext db;




        public ImageuploadsController(pracrticeContext context)
        {

            db = context;
        }


        [HttpPost]


        public IActionResult Iuploads(IFormFile file )
        {
            

            return Ok();
            
            
        }

    }
}
