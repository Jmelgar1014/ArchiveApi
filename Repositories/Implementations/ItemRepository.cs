using System;
using ArchiveApi.Dtos;
using ArchiveApi.Models;
using ArchiveApi.Repositories.Interfaces;
using AutoMapper;

namespace ArchiveApi.Repositories.Implementations;

public class ItemRepository(AppDbContext dbContext, IMapper mapper) : IItemRepository
{
  private readonly IMapper _mapper = mapper;
  private readonly AppDbContext _dbContext = dbContext;
  public List<ItemDto> GetItems()
  {
    try{

      var items = _dbContext.Items.ToList();

      var itemDto = _mapper.Map<List<ItemDto>>(items);

      return itemDto;

    }
    catch(Exception e)
    {
      Console.WriteLine(e);

      return new List<ItemDto>();
    }
  }

  public void SaveChanges()
  {
    _dbContext.SaveChanges();
  }

  public void AddToDb(InsertDto item)
  {
    Item insert = _mapper.Map<Item>(item);
    _dbContext.Items.Add(insert);
    _dbContext.SaveChanges();
  }

  public ItemDto GetItem(int Id)
  {
    try
    {

      Item item = _dbContext.Items.Where(a=> a.ItemId == Id).First();

      ItemDto itemId = _mapper.Map<ItemDto>(item);

      return itemId;
    }
    catch(Exception e)
    {
      Console.WriteLine(e);

      return new ItemDto { ItemName = "Error", ItemPath = "Unavailable" };
    }
  }

  public void RemoveItem(int Id)
  {

    Item removeItem = _dbContext.Items.Where(a=> a.ItemId == Id).First();

    _dbContext.Items.Remove(removeItem);

    _dbContext.SaveChanges();

  }

  public List<string> GetAllNames()
  {
    return _dbContext.Items.Select(a=> a.ItemName).ToList();
  }
}
