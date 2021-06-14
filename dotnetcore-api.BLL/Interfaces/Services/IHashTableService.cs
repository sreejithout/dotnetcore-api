using System;
using System.Collections;

namespace dotnet5Api.BLL.Interfaces.Services
{
    public interface IHashTableService
    {
        void AddNewItem(int key, string value, Hashtable hashTable);
        void LoopTheList(Hashtable hashTable);
        void RemoveItem(int key, Hashtable hashTable);
    }
}