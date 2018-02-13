using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;
using WaremanWS.FIlters;

namespace WaremanWS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
             name: "PO",
             routeTemplate: "api/po/{id}",
             defaults: new { controller = "po", id = RouteParameter.Optional }
             );

            config.Routes.MapHttpRoute(
            name: "Requisition",
            routeTemplate: "api/requisition/{id}",
            defaults: new { controller = "requisition", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "Part",
            routeTemplate: "api/part/{id}",
            defaults: new { controller = "part", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "POUser",
            routeTemplate: "api/po/{poNumber}/User/{userName}",
            defaults: new { controller = "po", reqNumber = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "PO2",
            routeTemplate: "api/po/{id}",
            defaults: new { controller = "po", id = RouteParameter.Optional }
            );

            //To be used if filtering is global
            //config.Filters.Add(new ForceHttpsAttribute());
            //Versioning with URI
            //config.Services.Replace(typeof(IHttpControllerSelector), new LearningControllerSelector((config)));

            //Configure HTTP Caching using Entity Tags (ETags)
            //var connString = System.Configuration.ConfigurationManager.ConnectionStrings["WMDBDEMOEntities"].ConnectionString;
            //var eTagStore = new CacheCow.Server.EntityTagStore.SqlServer.SqlServerEntityTagStore(connString);
            //var cacheCowCacheHandler = new CacheCow.Server.CachingHandler(eTagStore);
            //cacheCowCacheHandler.AddLastModifiedHeader = false;
            //config.MessageHandlers.Add(cacheCowCacheHandler);

            //Configure HTTP Caching using Entity Tags (ETags)
            var cacheCowCacheHandler = new CacheCow.Server.CachingHandler();
            config.MessageHandlers.Add(cacheCowCacheHandler);

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.Objects;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // force return objects to camel case
            var jsonStyleFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault();
            jsonStyleFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
