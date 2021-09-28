using Microsoft.EntityFrameworkCore;
using System.Linq;
using GenericsDemo.Models;
using System;
using System.Collections.Generic;
namespace GenericsDemo
{
    public class SqlRepository<T> where T : BaseData
    {
       public readonly List<T> _items = new();

       public SqlRepository(DbContext dbContext)
       {
           
       }

        // public T GetById(int id)
        // {
        //     return _items.Single(item => item.Id == id);
        // }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}