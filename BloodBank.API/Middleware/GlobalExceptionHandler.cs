using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace BloodBank.API.Middleware;

public class GlobalExceptionHandler : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message);

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            ProblemDetails problem = new()
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Type = "Server error",
                Title = "Server error",
                Detail = "An internal server has occurred"
            };

            var json = JsonSerializer.Serialize(problem);
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(json);
        }
    }
}