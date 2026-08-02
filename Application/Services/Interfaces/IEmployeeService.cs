using Application.DTOs.Employee;

namespace Application.Services.Interfaces;

public interface IEmployeeService
{
    Task<CreateEmployeeRequest> Create(CreateEmployeeRequest request);
    Task<List<EmployeeResponse>> GetAll(); //bütün listeyi ver 
    Task<EmployeeResponse?> GetById(int id);
    Task<EmployeeResponse?> Update(
        int id,
        UpdateEmployeeRequest request);
    Task<bool> Delete(int id);
}