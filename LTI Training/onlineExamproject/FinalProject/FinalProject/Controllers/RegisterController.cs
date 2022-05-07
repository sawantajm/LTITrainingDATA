using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {/*
        private readonly OnlineExamContext db;

        public RegisterController(OnlineExamContext context)
        {
            db = context;
        }

        [HttpGet]

        public IActionResult Result()
        {
            var reg = db.Registrations.ToList();
            try
            {

                if (reg != null)
                {
                    return Ok(reg);
                }
                else
                {
                    return BadRequest("Record Not Found");
                }
            }
            catch (Exception e)
            {
                return Ok("Try Again");
            }
        }



        [HttpPost]

        public IActionResult Result(Registration registration)
        {
            if(registration==null)
            {
                return BadRequest("Data Not Inserted");


            }
            else
            {
                db.Registrations.Add(registration);
                db.SaveChanges();

                return Ok("Data Inserted");
            }
        }
        */
    }
}
