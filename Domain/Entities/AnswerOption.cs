using Domain.Common;

namespace Domain.Entities;

public class AnswerOption : BaseEntity
{
    public int AnswerId { get; private set; }
    public Answer Answer { get; private set; } = null!;
    
    public int QuestionOptionId { get; private set; }
    public QuestionOption QuestionOption { get; private set; } = null!;
    
    private AnswerOption(){}

    public AnswerOption(
        int answerId,
        int questionOptionId)
    {
        AnswerId = answerId;
        QuestionOptionId = questionOptionId;
    }
}