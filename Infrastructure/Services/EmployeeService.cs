using Application.DTOs.Employee;
using Application.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    private readonly AppDbContext _context;

    public EmployeeService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<EmployeeResponse>> GetAll()
    {
        var employees = await _context.Employees.ToListAsync();

        var response = employees.Select(employee => new EmployeeResponse
        {
            Id = employee.Id,
            Name = employee.Name,
            Surname = employee.Surname,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            IsActive = employee.IsActive
        }).ToList();

        return response;
    }

    public async Task<EmployeeResponse?> GetById(int id)
    {
        var employee = await _context.Employees
            .FirstOrDefaultAsync(employee => employee.Id == id);
        
        if (employee is null)
            return null;

        return new EmployeeResponse
        {
            Id = employee.Id,
            Name = employee.Name,
            Surname = employee.Surname,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            IsActive = employee.IsActive
        }; 
    }

    public async Task<CreateEmployeeRequest> Create(CreateEmployeeRequest request)
    {
        
        var employee = new Employee(
            request.RoleId,
            request.Name,
            request.Surname,
            request.Email,
            request.Password,
            request.PhoneNumber
            );

        _context.Employees.Add(employee);
        
        await _context.SaveChangesAsync();
        
        return request;
    }

    public async Task<EmployeeResponse?> Update(
        int id,
        UpdateEmployeeRequest request)
    {
        var employee = await _context.Employees
            .FirstOrDefaultAsync(employee => employee.Id == id);
        if (employee is null)
            return null;
        
        employee.Update(
            request.Name,
            request.Surname,
            request.Email,
            request.PhoneNumber);
        
        await _context.SaveChangesAsync();

        return new EmployeeResponse
        {
            Id = employee.Id,
            Name = employee.Name,
            Surname = employee.Surname,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            IsActive = employee.IsActive
        };
    }

    public async Task<bool> Delete(int id)
    {
        var employee = await _context.Employees
            .FirstOrDefaultAsync(employee => employee.Id == id);
        if (employee is null)
            return false;
        
        _context.Employees.Remove(employee);
        
        await _context.SaveChangesAsync();
        
        return true;
    }
}