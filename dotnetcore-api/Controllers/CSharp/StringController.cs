using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_api.Controllers.CSharp
{
    [ApiController]
    public class StringController : BaseCSharpController
    {
        [HttpGet]
        public ActionResult<string> LetsStart()
        {
            string s = "This is a string";
            return Ok(s);
        }

        [HttpGet("LetsStartAgain")]
        public ActionResult<string> LetsStartAgain()
        {
            string s = "This is a string again";
            return Ok(s);
        }
    }
}
