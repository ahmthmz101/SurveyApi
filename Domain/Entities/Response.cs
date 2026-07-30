using Domain.Common;

namespace Domain.Entities;

public class Response : BaseEntity
{
    public int SurveyId { get; private set; }
    public Survey Survey { get; private set; } = null!;
    
    public int? CustomerId { get; private set; }
    public Customer? Customer { get; private set; } 
    
    public int? InviteCodeId { get; private set; }
    public InviteCode? InviteCode { get; private set; } 
    
    public bool IsCompleted { get; private set; }
    
    public DateTime StartedAt { get; private set; }
    public DateTime? SubmittedAt { get; private set; }

    public ICollection<Answer> Answers { get; private set; } = new List<Answer>();
    
    private Response(){}

    public Response(
        int surveyId,
        int? customerId,
        int? inviteCodeId)
    {
        SurveyId = surveyId;
        CustomerId = customerId;
        InviteCodeId = inviteCodeId;

        StartedAt = DateTime.UtcNow;
    }
        
}