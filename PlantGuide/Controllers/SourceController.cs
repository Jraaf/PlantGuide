using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Exceptions;
using PlantGuide.Business.Services.Interfaces;

namespace PlantGuide.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SourceController : ControllerBase
{
    private readonly ISourceService _service;

    public SourceController(ISourceService service)
    {
        _service = service;
    }
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var data = await _service.GetAllAsync();
            if (data != null)
            {
                return Ok(data);
            }
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        return NoContent();
    }
    [HttpGet("GetById")]

    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var data = await _service.GetAsync(id);
            if (data != null)
            {
                return Ok(data);
            }
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception)
        {
            throw;
        }

        return NoContent();
    }
    [HttpPost("add")]
    public async Task<IActionResult> Post(CreateSourceDTO model)
    {
        var data = await _service.AddAsync(model);
        return Ok(data);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update(int id, CreateSourceDTO DTO)
    {
        var data = await _service.UpdateByIdAsync(id, DTO);
        return Ok(data);
    }
}
