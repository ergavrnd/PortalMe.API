using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalMe.API.DTOs.Applications;
using PortalMe.API.DTOs.Roles;
using PortalMe.API.DTOs.ViewModels;
using PortalMe.API.Services;
using PortalMe.API.Services.Interfaces;
using System.Net;

namespace PortalMe.API.Controllers;

//[Authorize(Roles = "admin")]
[ApiController]
[Route("application")]
public class ApplicationController : ControllerBase
{
    private readonly IApplicationService _applicationService;

    public ApplicationController(IApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var results = await _applicationService.GetAllAsync();

        if (!results.Any())
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Data Application Not Found")); // Data Not Found
        }

        return Ok(new ListResponseVM<ApplicationResponseDto>(StatusCodes.Status200OK,
                                                      HttpStatusCode.OK.ToString(),
                                                      "Data Application Found",
                                                      results.ToList()));
    }

   
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _applicationService.GetByIdAsync(id);

        if (result is null)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Application Not Found")); // Data Not Found
        }

        return Ok(new SingleResponseVM<ApplicationResponseDto>(StatusCodes.Status200OK,
                                                        HttpStatusCode.OK.ToString(),
                                                        "Data Application Found",
                                                        result));
    }

   // [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> CreateAsync(ApplicationRequestDto applicationRequestDto)
    {
        await _applicationService.CreateAsync(applicationRequestDto);

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Application Created"));
    }

   // [Authorize(Roles = "admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, ApplicationRequestDto applicationRequestDto)
    {
        var result = await _applicationService.UpdateAsync(id, applicationRequestDto);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Application Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Application Updated"));
    }

   // [Authorize(Roles = "admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _applicationService.DeleteAsync(id);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Application Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Application Deleted"));
    }
}

