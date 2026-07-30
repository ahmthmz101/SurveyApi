using Domain.Common;

namespace Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    
    public int Age { get; private set; }
    public int Gender { get; private set; }

    public ICollection<InviteCode> InviteCodes { get; private set; } = new List<InviteCode>();
    public ICollection<Response> Responses { get; private set; } = new List<Response>();
    
    private Customer(){}

    public Customer(
        string name,
        string surname,
        string email,
        string phoneNumber,
        int age,
        int gender)
    {

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required. ");
        if (string.IsNullOrWhiteSpace(surname))
            throw new ArgumentException("Surname is required. ");
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email is required. ");
        
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
        Age = age;
        Gender = gender;
    }
}