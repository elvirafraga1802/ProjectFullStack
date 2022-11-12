 namespace AcademyTest.Repositories
 {
 public interface IItemsRepository
    {
        Task <InventoryItem>CreateItemAsync(Guid id);
        Task <IEnumerable<InventoryItem>> GetItemsAsync();
        Task <InventoryItem> GetItemAsync(Guid id);
        Task ReadItemAsync(Guid id);
        Task UpdateItemAsync(Guid id);
        Task DeleteItemAsync(Guid id);
    }
 }