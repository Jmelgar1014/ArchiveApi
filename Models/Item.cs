using System;
using System.ComponentModel.DataAnnotations;

namespace ArchiveApi.Models;

public class Item
{
  [Key]
  public int ItemId { get; set; }

  public required string ItemName { get; set; }

  public DateTime DateCreated { get; set; }

  public required string ItemPath { get; set; }

  public DateTime DateMonitored { get; set; }
}
