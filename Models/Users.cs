using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArchiveApi.Models;

public class Users
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  public required string UserName { get; set; }

  public required string OperatingSystem { get; set; }

  public required string Email { get; set; }

  public int ExternalId { get; set; }

}
