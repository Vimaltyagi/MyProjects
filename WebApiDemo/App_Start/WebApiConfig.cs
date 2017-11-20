using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApiDemo
{
    public class CustomeJsonFormatter : JsonMediaTypeFormatter
    {
        //public CustomeJsonFormatter()
        //{
        //    this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        //}
        //public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        //{
        //    base.SetDefaultContentHeaders(type, headers, mediaType);
        //    headers.ContentType = new MediaTypeHeaderValue("application/json");
        //}
    }
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Formatters.Add(new CustomeJsonFormatter());
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Remove(config.Formatters.JsonFormatter);
        }
    }
}
