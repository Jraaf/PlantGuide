﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Exceptions;
using PlantGuide.Business.Services.Interfaces;

namespace PlantGuide.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CountryController : ControllerBase
{
    private readonly ICountryService _service;

    public CountryController(ICountryService service)
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
    [HttpGet("GetByPlantId")]
    public async Task<IActionResult> GetByPlantId(int plantId)
    {
        var data = await _service.GetByPlantId(plantId);
        return Ok(data);
    }
    [HttpPost("add")]
    public async Task<IActionResult> Post(CreateCountryDTO model)
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
    public async Task<IActionResult> Update(int id, CreateCountryDTO DTO)
    {
        var data = await _service.UpdateByIdAsync(id, DTO);
        return Ok(data);
    }
}
