using Application.DTOs.Employee;

namespace Application.Services.Interfaces;

public interface IEmployeeService
{
    CreateEmployeeRequest Create(CreateEmployeeRequest request);
}