using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using AutoMapper;
using Wareman.Service;
using WaremanWS.Models;

[assembly: OwinStartup(typeof(WaremanWS.Startup))]

namespace WaremanWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            MapInit.MapInitialize();
            //var mapper = config.CreateMapper();
            //POModel dto = mapper.Map<POModel>(order);
            //Mapper.Initialize(config =>
            //{
            //    config.CreateMap<PO_Header, POModel>();
            //});
        }
       
    }

    public class MapInit
    {
        public static MapperConfiguration MapInitialize()
        {
            var config = new MapperConfiguration( cfg =>
                {
                    cfg.CreateMap<PO_Header, POModel>().ReverseMap();
                    cfg.CreateMap<PT_Parts, PartModel>().ReverseMap();
                    cfg.CreateMap<PT_RequisitionHeader, RequisitionModel>().ReverseMap();
                }           
                );
 
            return config;
        }
    }


}
