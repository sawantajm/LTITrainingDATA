using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Controllers;

using FinalProject.VModel;

namespace FinalProject.Controllers
{
    [Route("Report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
       /* private readonly OnlineExamContext db;
        public int count;
        public ReportController(OnlineExamContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Result(int userid)

        {
            try
            {

                MarksObtained marks = new MarksObtained();
                var val = marks.MarksObtain(count);
                var report = db.ReportDetails.FirstOrDefault(x => x.UserId == userid);


                if (report != null)
                {
                    report.MarksObtained = count;
                    db.SaveChanges();
                    return Ok("marks save");

                }
                else
                {
                    return Ok("not save");
                }



            }
            catch (Exception e)
            {
                return Ok("Try Again");

            }







        }
       */
    }
}
