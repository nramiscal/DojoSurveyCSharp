using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey {

    public class DojoController : Controller {

        [HttpGet("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comment){
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View();
        }


    }
}