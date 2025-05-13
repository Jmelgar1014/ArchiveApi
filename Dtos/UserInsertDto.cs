using System;

namespace ArchiveApi.Dtos;

public class UserInsertDto
{
  public required string UserName { get; set; }

  public required string OperatingSystem { get; set; }

  public required string Email { get; set; }

  public int ExternalId { get; set; }
}
