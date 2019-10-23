using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.Middlewares
{
    public class AuthenticationMiddlewares
    {
        private readonly RequestDelegate _next;
        public AuthenticationMiddlewares(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;

            if (path.HasValue && path.Value.ToLower().StartsWith("/Admin/index"))
            {

                if (httpContext.Session.GetString("UserName") == null)
                {
                    httpContext.Response.Redirect("/Account/Login");
                }
            }
            return _next(httpContext);
        }
    }
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddlewares>();
        }
    }
}

