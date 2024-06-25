using Application.Features.Images.Commands;
using Application.Features.Images.Queries;
using Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ASPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ISender _midatrSender;

        public ImagesController(ISender midatrSender)
        {
            _midatrSender = midatrSender;
        }

        [HttpPost("AddImage")]
        public async Task<IActionResult> AddNewImage([FromBody] NewImage newImage)
        {
            bool isSuccessful = await _midatrSender.Send(new CreateImageRequest(newImage));
            if (isSuccessful)
            {
                return Ok("Image created successfully!");
            }
            return BadRequest("Faild to create Image");
        }

        [HttpPut("UpdateImage")]
        public async Task<IActionResult>UpdateImage(UpdateImage updateImage)
        {
            bool isSuccessfull = await _midatrSender.Send(new UpdateImageRequest(updateImage));
            if (isSuccessfull)
            {
                return Ok("Updated successfully!");
            }
            return NotFound("Image does not exist!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            bool isSuccessfull = await _midatrSender.Send(new DeleteImageRequest(id));  
            if(isSuccessfull)
            {
                return Ok("Deleted successfully!");
            }
            return NotFound("Image does not exist!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetImage(int id)
        {
            ImageDTO image = await _midatrSender.Send(new GetImageByIdRequest(id));   
            if(image != null)
            {
                return Ok(image);
            }
            return NotFound("Image does not exist!");
        }

        [HttpGet("All")]
        public async Task<IActionResult>GetImages()
        {
            List<ImageDTO>images = await _midatrSender.Send(new GetImagesRequest());
            if(images != null)
            {
                return Ok(images);
            }
            return NotFound("No Images were found!");
        }
    }
}
