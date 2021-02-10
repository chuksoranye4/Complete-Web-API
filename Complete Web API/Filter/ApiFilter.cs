using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Complete_Web_API.Filter
{
    public class ApiFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
           string apiKey =  context.HttpContext.Request.Headers["APIKey"].ToString();
            if(apiKey == "12345")
            {
                var controller = context.Controller as Controller;
            }

            context.HttpContext.Response.StatusCode = 400;
        }
    }
}
