using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APiCrudEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        [HttpGet]
        //[ProducesResponseType()]
        public string Get()
        {
            return "Test Done";

        }




    }
}
