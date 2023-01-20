
namespace MarsUpdated;
[Binding]
public class CreateSkillStepDefinition
{
    CreateSkill ASP;

    public CreateSkillStepDefinition()
    {
        ASP= new CreateSkill();    
    }

    [When(@"User adds a '([^']*)' and a '([^']*)'")]
    public void WhenUserAddsANewSkillAndSkillLevel(string skill, string skillLevel)
    {
        ASP.CreateSkills(skill,skillLevel);
    }

    [Then(@"'([^']*)' and '([^']*)' should be added successfully")]
    public void ThenNewSkillShouldBeAddedSuccessfully(string skill, string skillLevel)
    {
        ASP.CheckSkillAdded(skill,skillLevel);
    }

}
