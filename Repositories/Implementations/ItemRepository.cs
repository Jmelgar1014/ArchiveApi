using System;
using ArchiveApi.Models;
using ArchiveApi.Repositories.Interfaces;

namespace ArchiveApi.Repositories.Implementations;

public class ItemRepository(AppDbContext dbContext) : IItemRepository
{
  private readonly AppDbContext _dbContext = dbContext;
  public List<Item> GetItems()
  {
    return _dbContext.Items.ToList();
  }

  public void SaveChanges()
  {
    _dbContext.SaveChanges();
  }

  public void AddToDb(Item item)
  {
    _dbContext.Items.Add(item);
    _dbContext.SaveChanges();
  }

  public Item GetItem(int Id)
  {
    Item item = _dbContext.Items.Where(a=> a.ItemId == Id).First();

    return item;
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
