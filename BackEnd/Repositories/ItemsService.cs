using AcademyTest.Context;
using Microsoft.EntityFrameworkCore;

namespace AcademyTest.Repositories
{
    public class ItemService : IItemsRepository
    {
        private readonly List<InventoryItem> items = new()    
        {
            new InventoryItem{Id = Guid.NewGuid(),Name = "Potion", Description = "tall", Quantity = 9},
            new InventoryItem{Id = Guid.NewGuid(),Name = "Iron Sword", Description = "short", Quantity = 50},
            new InventoryItem{Id = Guid.NewGuid(),Name = "Bronze Shield", Description = "medium", Quantity = 10}
        };
        public DataContext repository;

        public ItemService(DataContext repository)
        {
            this.repository = repository;
        }
        public Task<InventoryItem> CreateItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<InventoryItem> GetItemAsync(Guid id)
        {
            var item = items.Where(item => item.Id == id).SingleOrDefault();
            return await Task.FromResult(item);
        }

        public async Task<IEnumerable<InventoryItem>> GetItemsAsync()
        {
             return await repository.Items.ToListAsync();
        }

        public Task<InventoryItem> GetItemsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task ReadItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}