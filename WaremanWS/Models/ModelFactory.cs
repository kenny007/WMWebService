using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Wareman.Service;

namespace WaremanWS.Models
{
    public class ModelFactory
    {
        private System.Web.Http.Routing.UrlHelper _UrlHelper;

        public ModelFactory(HttpRequestMessage request)
        {
            _UrlHelper = new System.Web.Http.Routing.UrlHelper(request);
        }

        public POModel Create(PO_Header po)
        {
            var mapper = MapInit.MapInitialize().CreateMapper();
            POModel dto = mapper.Map<POModel>(po);
            dto.Url = _UrlHelper.Link("PO", new { id = po.PONumber });
            return dto;
        }

        public RequisitionModel Create(PT_RequisitionHeader req)
        {
            var mapper = MapInit.MapInitialize().CreateMapper();
            RequisitionModel dto = mapper.Map<RequisitionModel>(req);
            dto.Url = _UrlHelper.Link("Requisition", new { id = req.PONumber });
            return dto;
        }

        public PartModel Create(PT_Parts part)
        {
            var mapper = MapInit.MapInitialize().CreateMapper();
            PartModel dto = mapper.Map<PartModel>(part);
            dto.Url = _UrlHelper.Link("Part", new { id = part.PartNumber });
            return dto;
        }
    }
}