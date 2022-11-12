using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyTest.Dtos;
using AcademyTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AcademyTest.Controllers
{
    [ApiController]
    [Route("items")]
    public class InventoryController: ControllerBase
    {
         public IItemsRepository repository;
        public InventoryController(IItemsRepository repository)
        {
            this.repository = repository;            
        }

         [HttpGet("GetAll")]
        public async Task <IEnumerable<ItemDto>> GetItemsAsync()
        {
            var items =(await repository.GetItemsAsync()).Select(item => item.AsDto());
            return items;
        }

        [HttpGet("{id}")] 
        public async Task <ActionResult<ItemDto>> GetUserAsync(Guid id)
        {
           var item = await repository.GetItemAsync(id);

           if(item is null)
           {
            return NotFound();
           }
           return item.AsDto();
            
        }

        [HttpPost]
        public async Task <ActionResult<ItemDto>> CreateItem(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task <ActionResult<ItemDto>> UpdateItem(Guid id)
        {
            throw  new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task <ActionResult<ItemDto>> DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}