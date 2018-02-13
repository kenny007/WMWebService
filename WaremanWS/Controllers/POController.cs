using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Wareman.Service;
using WaremanWS.FIlters;
using WaremanWS.Models;

namespace WaremanWS.Controllers
{
       // [WaremanWS.FIlters.ForceHttps]
    public class POController : BaseApiController
    {
        public POController(IServiceRepository repo)
            : base(repo)
        {
        }

        //[WaremanWS.FIlters.ForceHttps]
         //[WSAuthorizeAttribute]
        public IEnumerable<POModel> Get(int page = 0, int pageSize = 10)
        {
            IQueryable<PO_Header> query;

            query = TheRepository.GetAllPOs().OrderBy(c => c.PONumber);
            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var urlHelper = new UrlHelper(Request);
            var prevLink = page > 0 ? urlHelper.Link("PO", new { page = page - 1 }) : "";
            var nextLink = page < totalPages - 1 ? urlHelper.Link("PO", new { page = page + 1 }) : "";

            var paginationHeader = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                PrevPageLink = prevLink,
                NextPageLink = nextLink
            };

            System.Web.HttpContext.Current.Response.Headers.Add("X-Pagination",
            Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));

            var results = query
            .Skip(pageSize * page)
            .Take(pageSize)
            .ToList()
            .Select(s => TheModelFactory.Create(s));

            return results;
        }


        public IEnumerable<POModel> GetPaged(string id, bool includeDetails, int page = 0, int pageSize = 10)
        {
            IQueryable<PO_Header> query;

            if (includeDetails == false)
            {
               query = TheRepository.GetPOByNumber(id).OrderBy(s => s.PONumber); //GetEnrolledStudentsInCourse(courseId).OrderBy(s => s.LastName);

                var totalCount = query.Count();

                System.Web.HttpContext.Current.Response.Headers.Add("X-InlineCount", totalCount.ToString());

                var results = query
                .Skip(pageSize * page)
                .Take(pageSize)
                .ToList()
                .Select(s => TheModelFactory.Create(s));

                return results;
            }
            
            query = TheRepository.GetPOWithDetails(id).OrderBy(s=>s.PONumber); //GetEnrolledStudentsInCourse(courseId).OrderBy(s => s.LastName);

            var totCount = query.Count();

            System.Web.HttpContext.Current.Response.Headers.Add("X-InlineCount", totCount.ToString());

            var resultz = query
            .Skip(pageSize * page)
            .Take(pageSize)
            .ToList()
            .Select(s => TheModelFactory.Create(s));

            return resultz;

        }


        //public HttpResponseMessage GetPO(string id)
        //{
        //    try
        //    {
        //        var po = TheRepository.GetPO("ENIKKOM",id);
        //        if (po != null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, TheModelFactory.Create(po));
        //        }
        //        else
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NotFound);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

    }
}
