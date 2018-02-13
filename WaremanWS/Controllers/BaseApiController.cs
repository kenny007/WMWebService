using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wareman.Service;
using WaremanWS.Models;

namespace WaremanWS.Controllers
{
    public class BaseApiController : ApiController
    {
        private IServiceRepository _repo;

        public BaseApiController(IServiceRepository repo)
        {
            _repo = repo;
        }

        protected IServiceRepository TheRepository
        {
            get
            {
                return _repo;
            }
        }
        private ModelFactory _modelFactory;

        protected ModelFactory TheModelFactory
        {
            get
            {
                if (_modelFactory == null)
                {
                    _modelFactory = new ModelFactory(Request);
                }
                return _modelFactory;
            }
        }
    }
}
