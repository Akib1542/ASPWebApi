using Application.Features.Properties.Commands;
using Application.Features.Properties.Queries;
using Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ASPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        #region Fields
        private readonly ISender _midatrSender;
        #endregion

        #region CTOR
        public PropertiesController(ISender midatrSender)
        {
            _midatrSender = midatrSender;
        }
        #endregion

        #region Add Property

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

        #endregion

        #region Update

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

        #endregion

        #region Get All Property

        [HttpGet("GetAllProperties")]
        public async Task<IActionResult> GetAllProperty()
        {
            var data = await _midatrSender.Send(new GetAllPropertyRequest());
            if (data != null)
            {
                return Ok(data);
            }
            else return NotFound("You have no data!");
        }

        #endregion

        #region Get Property by Id

        [HttpGet("{id}")]
        public async Task <IActionResult>GetPropertyById(int id)
        {
            var data = await _midatrSender.Send(new GetPropertyByIdRequest(id));
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        #endregion

        #region Delete

        [HttpDelete("{id}")]
        public async Task<IActionResult> GetDeleteById(int id)
        {
            var data = await _midatrSender.Send(new DeletePropertyRequest(id));
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        #endregion

    }
}
