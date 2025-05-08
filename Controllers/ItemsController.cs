using System.Runtime.CompilerServices;
using ArchiveApi.Models;
using ArchiveApi.Repositories.Implementations;
using ArchiveApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArchiveApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        //Get all items
        [HttpGet]
        public List<Item> GetItems()
        {
            var items = _itemRepository.GetItems().ToList();

            return items;
        }

        //Get item by Id
        [HttpGet("{Id}")]
        public Item GetItem(int Id)
        {
            Item item = _itemRepository.GetItem(Id);

            return item;
        }

        //Delete item by Id
        [HttpDelete("{Id}")]
        public void RemoveItem(int Id)
        {
            _itemRepository.RemoveItem(Id);
        }

        //Add new item
        [HttpPost]
        public void AddToDb([FromBody]Item item)
        {
            _itemRepository.AddToDb(item);
        }

        //Get all item names
        [HttpGet("names")]
        public List<string> GetAllNames()
        {
            return _itemRepository.GetAllNames();
        }
    }
}
