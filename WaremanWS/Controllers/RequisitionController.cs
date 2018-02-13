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
    public class RequisitionController : BaseApiController
    {
        public RequisitionController(IServiceRepository repo)
            : base(repo)
        {

        }

        public IEnumerable<RequisitionModel> Get(int page = 0, int pageSize = 10)
        {
            IQueryable<PT_RequisitionHeader> query;

            query = TheRepository.GetAllRequisitions().OrderBy(c => c.RequisitionNumber);
            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var urlHelper = new UrlHelper(Request);
            var prevLink = page > 0 ? urlHelper.Link("Requisition", new { page = page - 1 }) : "";
            var nextLink = page < totalPages - 1 ? urlHelper.Link("Requisition", new { page = page + 1 }) : "";

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


        public IEnumerable<RequisitionModel> GetPaged(string id, bool includeDetails, int page = 0, int pageSize = 10)
        {
            IQueryable<PT_RequisitionHeader> query;

            if (includeDetails == false)
            {
                query = TheRepository.GetAllRequisitions().OrderBy(s => s.RequisitionNumber); //GetEnrolledStudentsInCourse(courseId).OrderBy(s => s.LastName);

                var totalCount = query.Count();

                System.Web.HttpContext.Current.Response.Headers.Add("X-InlineCount", totalCount.ToString());

                var results = query
                .Skip(pageSize * page)
                .Take(pageSize)
                .ToList()
                .Select(s => TheModelFactory.Create(s));

                return results;
            }

            query = TheRepository.GetRequisitionWithDetails(id).OrderBy(s => s.RequisitionNumber); //GetEnrolledStudentsInCourse(courseId).OrderBy(s => s.LastName);

            var totCount = query.Count();

            System.Web.HttpContext.Current.Response.Headers.Add("X-InlineCount", totCount.ToString());

            var resultz = query
            .Skip(pageSize * page)
            .Take(pageSize)
            .ToList()
            .Select(s => TheModelFactory.Create(s));

            return resultz;

        }
    }
}
