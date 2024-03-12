using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalMe.API.DTOs.LogAdmins;
using PortalMe.API.DTOs.ViewModels;
using PortalMe.API.Services;
using PortalMe.API.Services.Interfaces;
using System.Net;

namespace PortalMe.API.Controllers;

//[Authorize(Roles = "admin")]
[ApiController]
[Route("logAdmin")]
public class LogAdminController : ControllerBase
{
    private readonly ILogAdminService _logAdminService;

    public LogAdminController(ILogAdminService logAdminService)
    {
        _logAdminService = logAdminService;
    }

   // [Authorize(Roles = "admin")]
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var results = await _logAdminService.GetAllAsync();

        if (!results.Any())
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Data LogAdmin Not Found")); // Data Not Found
        }

        return Ok(new ListResponseVM<LogAdminResponseDto>(StatusCodes.Status200OK,
                                                          HttpStatusCode.OK.ToString(),
                                                          "Data LogAdmin",
                                                          results.ToList()));


    }

   // [Authorize(Roles = "admin")]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _logAdminService.GetByIdAsync(id);

        if (result is null)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id LogAdmin Not Found")); // Data Not Found
        }

        return Ok(new SingleResponseVM<LogAdminResponseDto>(StatusCodes.Status200OK,
                                                            HttpStatusCode.OK.ToString(),
                                                            "Data LogAdmin Found",
                                                            result));
    }

   // [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> CreateAsync(LogAdminRequestDto logAdminRequestDto)
    {
        await _logAdminService.CreateAsync(logAdminRequestDto);

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "LogAdmin Created"));
    }

   // [Authorize(Roles = "admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, LogAdminRequestDto logAdminRequestDto)
    {
        var result = await _logAdminService.UpdateAsync(id, logAdminRequestDto);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id LogAdmin Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Employee LogAdmin Updated"));
    }

    //[Authorize(Roles = "admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _logAdminService.DeleteAsync(id);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id LogAdmin Not Found"
                                                 )); // Data Not Found

        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "LogAdmin Deleted"));
    }







}

