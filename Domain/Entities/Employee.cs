using Domain.Common;

namespace Domain.Entities;

public class Employee : BaseEntity
{
    public int RoleId { get; private set; }
    public Role Role { get; private set; }
    
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string PhoneNumber { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime? LastLoginAt { get; private set; }
    
    public DateTime? UpdatedAt { get; private set; }


    private Employee() {}

    public Employee(
        int roleId,
        string name,
        string surname,
        string email,
        string passwordHash,
        string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot empty. ");
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot empty. ");
        if (!email.Contains("@"))
            throw new ArgumentException("The email address must contain an @ symbol.");

        RoleId = roleId;
        Name = name;
        Surname = surname;
        Email = email;
        PasswordHash = passwordHash;
        PhoneNumber = phoneNumber;

        IsActive = true;
    }
}