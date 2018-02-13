using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace WaremanWS.FIlters
{
    public class WaremanWSControllerSelector : DefaultHttpControllerSelector
    {
        private HttpConfiguration _config;
        public WaremanWSControllerSelector(HttpConfiguration config)
            : base(config)
        {
            _config = config;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var controllers = GetControllerMapping(); //Will ignore any controls in same name even if they are in different namepsace

            var routeData = request.GetRouteData();

            var controllerName = routeData.Values["controller"].ToString();

            HttpControllerDescriptor controllerDescriptor;

            if (controllers.TryGetValue(controllerName, out controllerDescriptor))
            {

                var version = "2";

                var versionedControllerName = string.Concat(controllerName, "V", version);

                HttpControllerDescriptor versionedControllerDescriptor;
                if (controllers.TryGetValue(versionedControllerName, out versionedControllerDescriptor))
                {
                    return versionedControllerDescriptor;
                }

                return controllerDescriptor;
            }

            return null;

        }

        //This is to be used when versioning with QueryString even though it doesn't follow REST standard
        private string GetVersionFromQueryString(HttpRequestMessage request)
        {
            var query = HttpUtility.ParseQueryString(request.RequestUri.Query);

            var version = query["v"];

            if (version != null)
            {
                return version;
            }

            return "1";

        }

        //This is versioning done using Custom Header
        private string GetVersionFromHeader(HttpRequestMessage request)
        {
            const string HEADER_NAME = "X-WaremanWS-Version";

            if (request.Headers.Contains(HEADER_NAME))
            {
                var versionHeader = request.Headers.GetValues(HEADER_NAME).FirstOrDefault();
                if (versionHeader != null)
                {
                    return versionHeader;
                }
            }

            return "1";
        }

        //GetVersionFromAcceptHeaderVersion if supplied by client
        private string GetVersionFromAcceptHeaderVersion(HttpRequestMessage request)
        {
            var acceptHeader = request.Headers.Accept;

            foreach (var mime in acceptHeader)
            {
                if (mime.MediaType == "application/json")
                {
                    var version = mime.Parameters
                    .Where(v => v.Name.Equals("version", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

                    if (version != null)
                    {
                        return version.Value;
                    }
                    return "1";
                }
            }
            return "1";
        }
    }
}