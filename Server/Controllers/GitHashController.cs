using Microsoft.AspNetCore.Mvc;

namespace gamebox.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHashController : ControllerBase
    {
        [HttpGet]
        public string Get() => Environment.GetEnvironmentVariable("githash").Substring(0, 8);
    }
}