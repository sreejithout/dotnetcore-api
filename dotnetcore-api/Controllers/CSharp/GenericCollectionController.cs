using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet5Api.Controllers.CSharp
{
    [ApiController]
    public class GenericCollectionController : BaseCSharpController
    {
        private readonly ILogger<GenericCollectionController> _logger;

        public GenericCollectionController(ILogger<GenericCollectionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Dictionary")]
        public ActionResult Dictionary()
        {
            var dictionary = new Dictionary<int, string>() 
            {
                { 1, "first" },
                { 2, "second" }
            };
            dictionary.Add(3, "three");

            string temp = null;
            if (dictionary.ContainsKey(4))
            {
                temp = dictionary[4];
            }
            else if (dictionary.TryGetValue(3, out var result))
            {
                temp = result;
            }
            else
            {
                temp = "nothing";
            }

            for (int i = 0; i < dictionary.Count; i++)
            {
                // Hashtable in FIFO. While looping, we will get the first one first.
                var item = dictionary.ElementAt(i);
            }

            return Ok(temp);
        }
    }
}
