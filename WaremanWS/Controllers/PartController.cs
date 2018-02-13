using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Wareman.Service;
using WaremanWS.Models;

namespace WaremanWS.Controllers
{
    public class PartController : BaseApiController
    {
        public PartController(IServiceRepository repo)
            : base(repo)
        {

        }

        //[WaremanWS.FIlters.ForceHttps]
         //[WSAuthorizeAttribute]
        public IEnumerable<PartModel> Get(int page = 0, int pageSize = 10)
        {
            IQueryable<PT_Parts> query;

            query = TheRepository.GetAllParts().OrderBy(c => c.PartCategoryID);
            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var urlHelper = new UrlHelper(Request);
            var prevLink = page > 0 ? urlHelper.Link("Part", new { page = page - 1 }) : "";
            var nextLink = page < totalPages - 1 ? urlHelper.Link("Part", new { page = page + 1 }) : "";

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


        public IEnumerable<PartModel> GetByCategory(string id, int page = 0, int pageSize = 10)
        {
                IQueryable<PT_Parts> query;

                query = TheRepository.GetAllParts().Where(c=>c.PartCategoryID==id).OrderBy(s => s.PartNumber); //GetEnrolledStudentsInCourse(courseId).OrderBy(s => s.LastName);

                var totalCount = query.Count();

                System.Web.HttpContext.Current.Response.Headers.Add("X-InlineCount", totalCount.ToString());

                var results = query
                .Skip(pageSize * page)
                .Take(pageSize)
                .ToList()
                .Select(s => TheModelFactory.Create(s));

                return results;
   
        }
    }
}
