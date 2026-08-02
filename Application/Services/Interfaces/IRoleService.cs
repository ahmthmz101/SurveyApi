using Application.DTOs.Role;

namespace Application.Services.Interfaces;

public interface IRoleService
{
    Task<CreateRoleRequest> Create(CreateRoleRequest request);
    Task<List<RoleResponse>> GetAll();
    Task<RoleResponse?> GetById(int id);

    Task<RoleResponse?> Update(
        int id,
        UpdateRoleRequest request);
    Task<bool> Delete(int id);
}