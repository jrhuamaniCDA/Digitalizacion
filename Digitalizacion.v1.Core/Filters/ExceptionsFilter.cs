using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using static Digitalizacion.v1.Core.Exceptions.BasicExceptions;

namespace Digitalizacion.v1.Core.Filters
{
    public static class ExceptionsFilter
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        if (contextFeature.Error is BadRequestException)
                        {
                            var exception = (BadRequestException)contextFeature.Error;
                            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                            var response = new
                            {
                                context.Response.StatusCode,
                                exception.Message
                            };
                            await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
                            return;
                        }
                        if (contextFeature.Error is NotFoundException)
                        {
                            var exception = (NotFoundException)contextFeature.Error;
                            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                            var response = new
                            {
                                context.Response.StatusCode,
                                exception.Message
                            };
                            await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
                            return;
                        }

                        ConflictException serverError = new ConflictException("INTERNAL ERROR");
                        context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(serverError));
                    }
                });
            });
        }
    }
}
