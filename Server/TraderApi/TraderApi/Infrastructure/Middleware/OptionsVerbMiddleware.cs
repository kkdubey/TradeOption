﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace TraderApi.Infrastructure.Middleware
{
    /// <summary>
    /// OPTIONS HTTP-method handler
    /// </summary>
    public class OptionsVerbMiddleware
    {
        RequestDelegate Next { get; }

        public OptionsVerbMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Method == "OPTIONS")
            {
                context.Response.StatusCode = StatusCodes.Status200OK;
                context.Response.Headers.Add("Access-Control-Allow-Methods", "*");
                return Task.CompletedTask;
            }
            return Next.Invoke(context);
        }
    }
}
