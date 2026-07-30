using Application.DTOs.Employee;
using Application.Services.Interfaces;

namespace Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    public CreateEmployeeRequest Create(CreateEmployeeRequest request)
    {
        return request;
    }
}