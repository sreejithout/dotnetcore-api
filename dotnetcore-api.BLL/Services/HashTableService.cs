using System;
using System.Collections;
using dotnet5Api.BLL.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace dotnet5Api.BLL.Services
{
    public class HashTableService : IHashTableService
    {
        private readonly ILogger<HashTableService> _logger;

        public HashTableService(ILogger<HashTableService> logger)
        {
            _logger = logger;
        }

        public void AddNewItem(int key, string value, Hashtable hashTable)
        {
            try
            {
                hashTable.Add(key, value);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void RemoveItem(int key, Hashtable hashTable)
        {
            hashTable.Remove(key);
        }

        public void LoopTheList(Hashtable hashTable)
        {
            foreach (DictionaryEntry item in hashTable)
            {
                // Hashtable in LIFO. While looping, we will get the last one first.
                var temp = (string)item.Value;
                _logger.LogDebug(temp);
            }
        }
    }
}
