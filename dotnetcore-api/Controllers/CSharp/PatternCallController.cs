using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet5Api.BLL.Patterns;

namespace dotnet5Api.Controllers.CSharp
{
    [ApiController]
    public class PatternCallController : BaseCSharpController
    {
        private readonly ILogger<PatternCallController> _logger;

        public PatternCallController(ILogger<PatternCallController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> GetSingleton()
        {
            var s1 = Singleton.GetInstance;
            var s2 = Singleton.GetInstance;
            
            var s = "";
            if(s1 == s2)
            {
                s = "yes";
                s += s1.TryMe("1");
                s += s2.TryMe("2");
            }
            else
            {
                s = "no";
            }
            return Ok(s);
        }
    }
}
