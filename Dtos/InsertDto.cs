using System;

namespace ArchiveApi.Dtos;

public class InsertDto
{

  public int ItemId { get; set; }

  public required string ItemName { get; set; }

  public DateTime DateCreated { get; set; }

  public required string ItemPath { get; set; }

  public DateTime DateMonitored { get; set; }

}
