using Domain.Common;

namespace Domain.Entities;

public class InviteCode : BaseEntity
{
    public int SurveyId { get; private set; }
    public Survey Survey { get; private set; } = null!;
    
    public int CustomerId { get; private set; }
    public Customer Customer { get; private set; } = null!;
    
    public string Code { get; private set; } 
    
    public bool IsUsed { get; private set; } 
    
    public DateTime ExpireDate { get; private set; } 
    public DateTime? UsedAt { get; private set; }
    
    private InviteCode(){}

    public InviteCode(
        int surveyId,
        int customerId,
        string code,
        DateTime expireDate)
    {
        if (expireDate <= DateTime.UtcNow)
            throw new ArgumentException("Expire date must be in the future. ");
        
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("Code is required. ");
        
        SurveyId = surveyId;
        CustomerId = customerId;
        Code = code;
        ExpireDate = expireDate;
    }
}