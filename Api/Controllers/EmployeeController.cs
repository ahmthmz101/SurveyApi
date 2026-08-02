using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Employee;
using Application.Services.Interfaces;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateEmployeeRequest request)
    {
        var result = await _employeeService.Create(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _employeeService.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _employeeService.GetById(id);
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> Update(
        int id,
        UpdateEmployeeRequest request)
    {
        var result = await _employeeService.Update(id, request);

        if (result is null)
            return NotFound();

        return Ok(result);
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _employeeService.Delete(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
