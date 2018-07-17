using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DataModel;
using BusinessEntities;

namespace Indus_RestFull_API.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Project, EndClientEntity>();
                cfg.CreateMap<EndClient, EndClientEntity>();
                cfg.CreateMap<PrimeVendor, PrimeVendorEntity>();
                cfg.CreateMap<SiteEvent, SiteEventEntity>();
                //cfg.CreateMap<EventType, EventTypeEntity>();
                cfg.CreateMap<Site, SiteEntity>();
                cfg.CreateMap<Address, AddressEntity>();
                cfg.CreateMap<District, DistrictEntity>();
                cfg.CreateMap<State, StateEntity>();
                cfg.CreateMap<Country, CountryEntity>();
                cfg.CreateMap<SiteStatu, SiteStatusEntity>();
                cfg.CreateMap<Division, DivisionEntity>();
                cfg.CreateMap<Region, RegionEntity>();
                cfg.CreateMap<Circle, CircleEntity>();

                cfg.CreateMap<LatestSiteEvent, LatestSiteEventEntity>()
                    .ForPath(d => d.SiteEventEntity, opt => opt.MapFrom(s => s.SiteEvent))
                    .ForPath(d => d.SiteEventEntity.SiteEntity, opt => opt.MapFrom(s => s.SiteEvent.Site))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.AddressEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Address))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.AddressEntity.DistrictEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Address.District))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.AddressEntity.DistrictEntity.StateEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Address.District.State))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.AddressEntity.DistrictEntity.StateEntity.CountryEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Address.District.State.Country))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.SiteStatusEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.SiteStatu))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.DivisionEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Division))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.DivisionEntity.RegionEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Division.Region))
                    .ForPath(d => d.SiteEventEntity.SiteEntity.DivisionEntity.RegionEntity.CircleEntity, opt => opt.MapFrom(s => s.SiteEvent.Site.Division.Region.Circle));

                cfg.CreateMap<Project, ProjectEntity>()
                    .ForMember(d => d.EndClientEntity, opt => opt.MapFrom(s => s.EndClient))
                    .ForPath(d => d.EndClientEntity.PrimeVendorEntity, opt => opt.MapFrom(s => s.EndClient.PrimeVendor1));

                //cfg.CreateMap<Site, SiteEntity>();
                //.ForMember(d => d.AddressEntity, opt => opt.MapFrom(s => s.Address))
                //.ForPath(d => d.DivisionEntity, opt => opt.MapFrom(s => s.Division))
                //.ForPath(d => d.SiteStatusEntity, opt => opt.MapFrom(s => s.SiteStatu));
            });
        }
    }
}