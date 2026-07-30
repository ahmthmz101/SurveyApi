using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Employee;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateEmployeeRequest request)
    {
        return Ok(request);
    }
}
