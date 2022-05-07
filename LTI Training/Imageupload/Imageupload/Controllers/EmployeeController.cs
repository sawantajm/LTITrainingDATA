using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using uploadImage.Models;

namespace Imageupload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]





    public class EmployeeController : ControllerBase
    {


        private readonly pracrticeContext db;

        public EmployeeController(pracrticeContext context)
        {
            db = context;
        }

        [HttpPut]
        public IActionResult update(int? id, [FromBody]Employee category)
        {
            try
            {

                if (id != category.Id)
                {
                    return BadRequest("Record Not Found");
                }
                else
                {
                    db.Entry(category).State = EntityState.Modified;
                    db.SaveChanges();
                    return Ok("record Updated!!");


                }
            }
            catch (Exception e)
            {
                return BadRequest("Something Went Wrong");
            }
        }

    }
}
