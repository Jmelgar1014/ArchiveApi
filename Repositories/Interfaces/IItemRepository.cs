using System;
using ArchiveApi.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ArchiveApi.Repositories.Interfaces;

public interface IItemRepository
{
  List<Item> GetItems();

  void SaveChanges();

  void AddToDb(Item item);

  Item GetItem(int Id);
  
  void RemoveItem(int Id);

  List<string> GetAllNames();
}
