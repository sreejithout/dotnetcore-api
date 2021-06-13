using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetcore_api.Controllers.CSharp
{
    [ApiController]
    public class StringController : BaseCSharpController
    {
        private readonly ILogger<StringController> _logger;

        public StringController(ILogger<StringController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> LetsStart()
        {
            string s = "This is a string";
            _logger.LogInformation("Log info check");
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
