using HelloWorld.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        private IMessageService messageService;

        public HelloWorldController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return messageService.GetMessage();
        }
    }
}
