using Microsoft.AspNetCore.Mvc;

namespace Api_test_github_action.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ApiTestService _apiTestService;

            public TestController(ApiTestService apiTestService) 
        {
            _apiTestService = apiTestService;
        }

        [HttpGet("get-data")]
        public async Task<IActionResult> GetData()
        {
            var result = await _apiTestService.GetDataAsync<object>("/posts/1");
            return Ok(result);
        }
    }
}
