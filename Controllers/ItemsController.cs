using System.Runtime.CompilerServices;
using ArchiveApi.Dtos;
using ArchiveApi.Models;
using ArchiveApi.Repositories.Implementations;
using ArchiveApi.Repositories.Interfaces;
using AutoMapper;
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

        private readonly IMapper _mapper;
        public ItemsController(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;

            _mapper = mapper;
        }

        //Get all items
        [HttpGet]
        public ActionResult<ItemDto> GetItems()
        {
            var items = _itemRepository.GetItems();

            return Ok(items);
        }

        //Get item by Id
        [HttpGet("{Id}")]
        public ItemDto GetItem(int Id)
        {
            ItemDto item = _itemRepository.GetItem(Id);

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
        public void AddToDb([FromBody]InsertDto item)
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
