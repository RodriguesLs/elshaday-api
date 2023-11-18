using elshaday_test_api.ModelViews;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace elshaday_test_api.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public ErrorResponse Error()
        {
            var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()!;

            var idError = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            return new ErrorResponse(
                idError,
                HttpContext.TraceIdentifier,
                exceptionHandlerFeature.Error.Message,
                Response.StatusCode
            );
        }
    }
}
