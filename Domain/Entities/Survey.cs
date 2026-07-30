using Domain.Common;

namespace Domain.Entities;

public class Survey : BaseEntity
{
    public int EmployeeId { get; private set; }
    public Employee Employee { get; private set; } = null!;
    
    public int SurveyTypeId { get; private set; }
    public SurveyType SurveyType { get; private set; } = null!;
    
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Password { get; private set; }
    
    public DateTime? StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    
    public bool IsPublished { get; private set; }
    public bool IsActive { get; private set; }

    public ICollection<InviteCode> InviteCodes { get; private set; } = new List<InviteCode>();
    public ICollection<SurveyQuestion> SurveyQuestions { get; private set; } = new List<SurveyQuestion>();
    public ICollection<Response> Responses { get; private set; } = new List<Response>();

    private Survey() {}

    public Survey(
        int employeeId,
        int surveyTypeId,
        string title,
        string description,
        string password)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title is required.");

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description is required.");
        
        EmployeeId = employeeId;
        SurveyTypeId = surveyTypeId;
        Title = title;
        Description = description;
        Password = password;

        IsPublished = false;
        IsActive = false;
    }
}