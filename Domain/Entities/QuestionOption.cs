using Domain.Common;

namespace Domain.Entities;

public class QuestionOption : BaseEntity
{
    public int QuestionId { get; private set; }
    public Question Question { get; private set; } = null!;
    
    public string Text { get; private set; }
    public int Value { get; private set; }
    public int Order { get; private set; }

    public ICollection<AnswerOption> AnswerOptions { get; private set; } = new List<AnswerOption>();
    
    private QuestionOption(){}

    public QuestionOption(
        int questionId,
        string text,
        int value,
        int order)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new ArgumentException("Text is required. ");
        QuestionId = questionId;
        Text = text;
        Value = value;
        Order = order;
    }
}