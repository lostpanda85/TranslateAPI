using Microsoft.AspNetCore.Mvc;
using Model.Request;
using Model.Response;
using TranslateAPI.Services;

namespace TranslateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly ITranslate _service;

        public TranslateController(ITranslate service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<TranslateResponse>> Translate([FromBody] TranslateRequest request)
        {
            var output = await _service.TranslateText(request.TextToTranslate);

            TranslateResponse response = new TranslateResponse()
            {
                TranslatedText = output
            };

            return Ok(response);
        }
    }
}
