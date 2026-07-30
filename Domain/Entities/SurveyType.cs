using Domain.Common;

namespace Domain.Entities;

public class SurveyType : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public ICollection<Survey> Surveys { get; private set; } = new List<Survey>();

    private SurveyType(){}

    public SurveyType(
        string name,
        string description)
    {
        Name = name;
        Description = description;
    }
}