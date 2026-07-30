using Domain.Common;

namespace Domain.Entities;

public class QuestionType : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public ICollection<Question> Questions { get; private set; } = new List<Question>();
    
    private QuestionType(){}

    public QuestionType(
        string name,
        string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required. ");
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description is required. ");
                        
        Name = name;
        Description = description;
    }
}