using System;
using ArchiveApi.Dtos;
using ArchiveApi.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ArchiveApi.Repositories.Interfaces;

public interface IItemRepository
{
  List<ItemDto> GetItems();

  void SaveChanges();

  void AddToDb(InsertDto item);

  ItemDto GetItem(int Id);
  
  void RemoveItem(int Id);

  List<string> GetAllNames();
}
