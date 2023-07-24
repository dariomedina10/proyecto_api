using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ejemplo_webapi2
{
    public static class WebApiConfig




    {


        //public static void Register(HttpConfiguration config)
        //{
        //    //config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new
        //    //{
        //    //    id = RouteParameter.Optional
        //    //});
        //    //To produce JSON format add this line of code  
        //    config.Routes.MapHttpRoute(
        //       name: "DefaultApi",
        //       routeTemplate: "api/{controller}/{id}",
        //       defaults: new { id = RouteParameter.Optional }

        //   config.Formatters.JsonFormatter.SupportedMediaTypes.Add(newMediaTypeHeaderValue("text/html"));
        //}

     
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            // Rutas de Web API
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.MapHttpAttributeRoutes();





            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }

      
    }
}
