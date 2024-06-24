using Application.Models;
using Application.Properties.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly ISender _midatrSender;

        public PropertiesController(ISender midatrSender)
        {
            _midatrSender = midatrSender;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddNewProperty([FromBody] NewProperty newPropertyRequest)
        {
            bool isSuccess = await _midatrSender.Send(new CreatePropertyRequest (newPropertyRequest) );
            if(isSuccess)
            {
                return Ok("Property Created Successfully.");
            }
            return BadRequest("Failed to Create property");
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateProperty([FromBody]UpdateProperty updateProperty)
        {
            bool isSuccessful = await _midatrSender.Send(new UpdatePropertyRequest(updateProperty));
            if(isSuccessful)
            {
                return Ok("Successfully Property Updated!");
            }
            return NotFound("Property Does not EXIST!");
        }
    }
}
