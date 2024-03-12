using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalMe.API.DTOs.Companys;
using PortalMe.API.DTOs.Roles;
using PortalMe.API.DTOs.ViewModels;
using PortalMe.API.Services;
using PortalMe.API.Services.Interfaces;
using System.Net;

namespace PortalMe.API.Controllers;

//[Authorize(Roles = "admin")]
[ApiController]
[Route("company")]
public class CompanyController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    //[Authorize(Roles = "admin")]
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var results = await _companyService.GetAllAsync();

        if (!results.Any())
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Data Company Not Found")); // Data Not Found
        }

        return Ok(new ListResponseVM<CompanyResponseDto>(StatusCodes.Status200OK,
                                                      HttpStatusCode.OK.ToString(),
                                                      "Data Company Found",
                                                      results.ToList()));
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _companyService.GetByIdAsync(id);

        if (result is null)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Company Not Found")); // Data Not Found
        }

        return Ok(new SingleResponseVM<CompanyResponseDto>(StatusCodes.Status200OK,
                                                        HttpStatusCode.OK.ToString(),
                                                        "Data  Found",
                                                        result));
    }

   // [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CompanyRequestDto companyRequestDto)
    {
        await _companyService.CreateAsync(companyRequestDto);

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Company Created"));
    }

    //[Authorize(Roles = "admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, CompanyRequestDto companyRequestDto)
    {
        var result = await _companyService.UpdateAsync(id, companyRequestDto);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Company Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Company Updated"));
    }

   // [Authorize(Roles = "admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _companyService.DeleteAsync(id);

        if (result == 0)
        {
            return NotFound(new MessageResponseVM(StatusCodes.Status404NotFound,
                                                  HttpStatusCode.NotFound.ToString(),
                                                  "Id Company Not Found"
                                                 )); // Data Not Found
        }

        return Ok(new MessageResponseVM(StatusCodes.Status200OK,
                                        HttpStatusCode.OK.ToString(),
                                        "Company Deleted"));
    }
}

