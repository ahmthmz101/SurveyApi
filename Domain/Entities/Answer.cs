using Domain.Common;

namespace Domain.Entities;

public class Answer : BaseEntity
{
    public int ResponseId { get; private set; }
    public Response Response { get; private set; } = null!;
    
    public int SurveyQuestionId { get; private set; }
    public SurveyQuestion SurveyQuestion { get; private set; } = null!;
    
    public string? Text { get; private set; }
    
    public decimal? NumberValue { get; private set; }
    
    public DateTime? DateValue { get; private set; }

    public ICollection<AnswerOption> AnswerOptions { get; private set; } = new List<AnswerOption>();
    
    private Answer(){}

    public Answer(
        int responseId,
        int surveyQuestionId,
        string? text,
        decimal? numberValue,
        DateTime? dateValue)
    {
        ResponseId = responseId;
        SurveyQuestionId = surveyQuestionId;
        Text = text;
        NumberValue = numberValue;
        DateValue = dateValue;
    }
}