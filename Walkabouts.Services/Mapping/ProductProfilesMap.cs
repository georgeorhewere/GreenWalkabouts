using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Services.DTO;

namespace Walkabouts.Services.Mapping
{
    public class ProductProfilesMap: Profile
    {
        public ProductProfilesMap()
        {
            CreateMap<CatalogItemDTO, Product>().ForMember(dto => dto.ProductName, map => map.MapFrom(source => source.ProductName))
                                            .ForMember(dto => dto.Description, map => map.MapFrom(source => source.Description))
                                            .ForMember(dto => dto.StockLevel, map => map.MapFrom(source => source.StockLevel))
                                            .ForMember(dto => dto.UnitPrice, map => map.MapFrom(source => source.UnitPrice))
                                            .ForMember(dto => dto.Featured, map => map.MapFrom(source => source.Featured))
                                            .ForMember(dto => dto.Id, map => map.MapFrom(source => source.Id))
                                        ;
            CreateMap<Product, CatalogItemDTO> ().ForMember(dto => dto.Id, map => map.MapFrom(source => source.Id))
                                            .ForMember(dto => dto.ProductName, map => map.MapFrom(source => source.ProductName))
                                            .ForMember(dto => dto.Description, map => map.MapFrom(source => source.Description))
                                            .ForMember(dto => dto.StockLevel, map => map.MapFrom(source => source.StockLevel))
                                            .ForMember(dto => dto.UnitPrice, map => map.MapFrom(source => source.UnitPrice))
                                            .ForMember(dto => dto.Featured, map => map.MapFrom(source => source.Featured))
                                            .ForMember(dto => dto.RefId, map => map.MapFrom(source => source.RefId));
        }
    }
}
