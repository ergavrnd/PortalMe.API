using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalMe.API.DTOs.Roles;
using PortalMe.API.DTOs.ViewModels;
using PortalMe.API.Services.Interfaces;
using System.Net;

namespace PortalMe.API.Controllers;

//[Authorize(Roles = "admin")]
[ApiController]
[Route("role")]
public class RoleController : ControllerBase
{
    private readonly IRoleService _roleService;

    public RoleController(IRoleService roleService)
    {
        _roleService = roleService;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var results = await _roleService.GetAllAsync();

        if (!results.Any())
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Data Role Not Found")); // Data Not Found
        }

        return Ok(new ListResponseVM<RoleResponseDto>(StatusCodes.Status200OK,
                                                      HttpStatusCode.OK.ToString(),
                                                      "Data Role Found",
                                                      results.ToList()));
    }

    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _roleService.GetByIdAsync(id);

        if (result is null)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Role Not Found")); // Data Not Found
        }

        return Ok(new SingleResponseVM<RoleResponseDto>(StatusCodes.Status200OK,
                                                        HttpStatusCode.OK.ToString(),
                                                        "Data Role Found",
                                                        result));
    }

   // [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> CreateAsync(RoleRequestDto roleRequestDto)
    {
        await _roleService.CreateAsync(roleRequestDto);

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Role Created"));
    }

    //[Authorize(Roles = "admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, RoleRequestDto roleRequestDto)
    {
        var result = await _roleService.UpdateAsync(id, roleRequestDto);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Role Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Role Updated"));
    }

    //[Authorize(Roles = "admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _roleService.DeleteAsync(id);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Role Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Role Deleted"));
    }
}

