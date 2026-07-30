using Domain.Common;

namespace Domain.Entities;

public class Question : BaseEntity
{
    public int QuestionTypeId { get; private set; }
    public QuestionType QuestionType { get; private set; } = null!;
    
    public string Title { get; private set; }
    public string Description { get; private set; }
    
    public bool IsRequired { get; private set; }
    
    public int? MinLength { get; private set; }
    public int? MaxLength { get; private set; }

    public int? MinValue { get; private set; }
    public int? MaxValue { get; private set; }

    public string? Placeholder { get; private set; }

    public ICollection<QuestionOption> QuestionOptions { get; private set; } = new List<QuestionOption>();
    public ICollection<SurveyQuestion> SurveyQuestions { get; private set; } = new List<SurveyQuestion>();
    
    private Question(){}

    public Question(
        int questionTypeId,
        string title,
        string description)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title is required.");

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description is required.");

        QuestionTypeId = questionTypeId;
        Title = title;
        Description = description;
        IsRequired = false;
    }
}