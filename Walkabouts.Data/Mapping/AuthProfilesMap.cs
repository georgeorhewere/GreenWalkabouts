using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Data.DTO;

namespace Walkabouts.Data.Mapping
{
    public class AuthProfilesMap : Profile
    {
        public AuthProfilesMap()
        {
            CreateMap<RegisterDTO, AppUser>().ForMember(dto => dto.Email, map => map.MapFrom(source => source.Email))
                                             .ForMember(dto => dto.FirstName, map => map.MapFrom(source => source.FirstName))
                                             .ForMember(dto => dto.LastName, map => map.MapFrom(source => source.LastName))
                                             .ForMember(dto => dto.UserName, map => map.MapFrom(source => source.Email))
                                             .ForPath(dto => dto.UserProfile.Address, map => map.MapFrom(source => source.Address))
                                             .ForPath(dto => dto.UserProfile.PhoneNumber, map => map.MapFrom(source => source.PhoneNumber))
                                             ;
            CreateMap<AppUser, RegisterDTO>().ForMember(dto => dto.Email, map => map.MapFrom(source => source.Email))
                                            .ForMember(dto => dto.FirstName, map => map.MapFrom(source => source.FirstName))
                                            .ForMember(dto => dto.LastName, map => map.MapFrom(source => source.LastName))                                            
                                            .ForPath(dto => dto.Id, map => map.MapFrom(source => source.Id));
        }
    }
}
