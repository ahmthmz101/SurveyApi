using Application.DTOs.Role;
using Application.Services.Interfaces;
using Infrastructure.Context;

namespace Infrastructure.Services;

public class RoleService : IRoleService
{
    private readonly AppDbContext _context;

    public RoleService(AppDbContext context)
    {
        _context = context;
    }
    
    
    
    public Task<CreateRoleRequest> Create(CreateRoleRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<List<RoleResponse>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<RoleResponse?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<RoleResponse?> Update(int id, UpdateRoleRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }
}