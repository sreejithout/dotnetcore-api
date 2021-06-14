using System;
using System.Collections;
using dotnet5Api.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet5Api.Controllers.CSharp
{
    [ApiController]
    public class CollectionController : BaseCSharpController
    {
        private readonly ILogger<CollectionController> _logger;

        public IHashTableService HashTableService { get; }

        public CollectionController(ILogger<CollectionController> logger, IHashTableService hashTableService)
        {
            _logger = logger;
            HashTableService = hashTableService;
        }

        [HttpGet("ArrayList")]
        public ActionResult<ArrayList> ArrayList()
        {
            var a = new ArrayList();
            _logger.LogInformation("array list");
            return Ok(a);
        }

        [HttpGet("HashTable")]
        public ActionResult<Hashtable> HashTable()
        {
            try
            {
                var hashTable = new Hashtable()
                {
                    { 1, "first" }
                };

                HashTableService.AddNewItem(2, "second", hashTable);
                HashTableService.AddNewItem(3, "third", hashTable);
                HashTableService.RemoveItem(2, hashTable);
                HashTableService.LoopTheList(hashTable);

                var first = hashTable[1];
                _logger.LogDebug((string)first);
                return Ok(hashTable);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpGet("Stack")]
        public ActionResult<Stack> Stack()
        {
            var s = new Stack();
            s.Push(1);
            s.Push("hi");
            s.Pop();
            return Ok(s);
        }

        [HttpGet("SortedList")]
        public ActionResult<SortedList> SortedList()
        {
            var s = new SortedList();
            return Ok(s);
        }

        [HttpGet("Queue")]
        public ActionResult<Queue> Queue()
        {
            var q = new Queue();
            q.Enqueue(1);
            q.Enqueue("sdf");
            q.Dequeue();

            return Ok(q.Peek());
        }

        [HttpGet("BitArray")]
        public ActionResult<BitArray> BitArray()
        {
            var b = new BitArray(1);
            return Ok(b);
        }
    }
}
