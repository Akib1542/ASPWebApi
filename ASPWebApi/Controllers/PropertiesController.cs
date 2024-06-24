using Application.Models;
using Application.Properties.Commands;
using Application.Properties.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

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

        [HttpGet("GetAllAsync")]

        public async Task<IActionResult> GetAllProperty()
        {
            var data = await _midatrSender.Send(new GetAllPropertyRequest());
            if (data != null)
            {
                return Ok(data);
            }
            else return NotFound("You have no data!");
        }

        [HttpGet("GetPropertyByIdAsync")]
        public async Task <IActionResult>GetPropertyById(int id)
        {
            var data = await _midatrSender.Send(new GetPropertyByIdRequest(id));
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpDelete("GetDeleteByIdAsync")]
        public async Task<IActionResult> GetDeleteById(int id)
        {
            var data = await _midatrSender.Send(new DeletePropertyRequest(id));
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

    }
}
