using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace TheWeatherman.Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update update)
        {
            var a = 3;
            return Ok();
        }
    }
}