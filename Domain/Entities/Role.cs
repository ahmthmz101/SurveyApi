using Domain.Common;

namespace Domain.Entities;

public class Role : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public ICollection<Employee> Employees { get; private set; } = new List<Employee>();
    
    private Role(){}
    
    public Role(string name, string description)
    {
        Name = name;
        Description = description;
    }
}