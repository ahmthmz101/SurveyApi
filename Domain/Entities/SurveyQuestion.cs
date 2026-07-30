using Domain.Common;

namespace Domain.Entities;

public class SurveyQuestion : BaseEntity
{
    public int SurveyId { get; private set; }
    public Survey Survey { get; private set; } = null!;
    
    public int QuestionId { get; private set; }
    public Question Question { get; private set; } = null!;
    
    public int Order { get; private set; }
    
    private SurveyQuestion(){}

    public SurveyQuestion(
        int surveyId,
        int questionId,
        int order)
    {
        if (order < 1)
            throw new ArgumentException("Order must be greater than 0. ");
        SurveyId = surveyId;
        QuestionId = questionId;
        Order = order;
    }
}