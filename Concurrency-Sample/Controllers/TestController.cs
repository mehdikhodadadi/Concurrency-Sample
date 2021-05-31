using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Abstraction;
using System.Threading.Tasks;

namespace Concurrency_Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IClient _client;
        private readonly IRequestMessage _requestMessage;

        public TestController(IClient client, IRequestMessage requestMessage)
        {
            _client = client;
            _requestMessage = requestMessage;
        }

        [HttpGet]
        public async Task<IActionResult> SenMessage(string message)
        {
            try
            {
                _requestMessage.Message = message;
                var response = await _client.SendAsync(_requestMessage);
                return Ok(response.Message);
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}