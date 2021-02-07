using System.Collections.Generic;
using Catalog.Entities;
using System;
using System.Linq;

namespace Catalog.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items= new()
        {
           new Item(){Id = Guid.NewGuid(),Name = "Lalit Yadav", Price=10.9M,CreatedDate = DateTimeOffset.UtcNow},
           new Item(){Id = Guid.NewGuid(),Name = "Iron Sward", Price=10.9M,CreatedDate = DateTimeOffset.UtcNow},
           new Item(){Id = Guid.NewGuid(),Name = "Bhuwan Bisht", Price=100.1M,CreatedDate = DateTimeOffset.UtcNow},
           new Item(){Id = Guid.NewGuid(),Name = "Rajesh Kumar", Price=50.5M,CreatedDate = DateTimeOffset.UtcNow},
           new Item(){Id = Guid.NewGuid(),Name = "Rajat Rohilla", Price=11.4M,CreatedDate = DateTimeOffset.UtcNow},
           new Item(){Id = Guid.NewGuid(),Name = "Ankit Garg", Price=134.4M,CreatedDate = DateTimeOffset.UtcNow},
        };

        public IEnumerable<Item> GetItem()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item=>item.Id==id).SingleOrDefault();
        }
    } 
}