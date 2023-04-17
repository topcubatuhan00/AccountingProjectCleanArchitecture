﻿using AutoMapper;
using OnlineMuhasebeServer.Application.Features.AppFeauters.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Features.AppFeauters.RoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyCommand, Company>().ReverseMap();
            CreateMap<CreateUCAFCommand, UniformChartOfAccount>().ReverseMap();
            CreateMap<CreateRoleCommand, AppRole>().ReverseMap();
        }
    }
}
