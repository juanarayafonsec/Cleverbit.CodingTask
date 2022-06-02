using Cleverbit.CodingTask.Host.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.Host.Controllers
{
    public class GamePlayerController : BaseApiController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<UserGameesDto>> GetGamees([FromQuery] int id)
        {

            return Ok();
        }
    }
}
