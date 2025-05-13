using System;
using ArchiveApi.Dtos;
using ArchiveApi.Models;
using AutoMapper;

namespace ArchiveApi.Profiles;

public class UserProfile : Profile
{

  public UserProfile()
  {
    CreateMap<UserInsertDto, Users>();
  }
}
