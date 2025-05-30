using System;
using ArchiveApi.Dtos;
using ArchiveApi.Models;
using AutoMapper;

namespace ArchiveApi.Profiles;

public class ItemProfile : Profile
{
  public ItemProfile()
  {
    CreateMap<Item, ItemDto>();
    CreateMap<InsertDto, Item>();
  }
}
