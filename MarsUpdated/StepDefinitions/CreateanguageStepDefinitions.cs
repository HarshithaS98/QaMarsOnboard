using MarsUpdated.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsUpdated;
[Binding]

    public class CreateanguageStepDefinitions : CommonDriver
    {
         CreateLanguage ASP;

        public CreateanguageStepDefinitions()
        {
            ASP = new CreateLanguage();
        }

    [When(@"User adds a '([^']*)' and  '([^']*)'")]
    public void WhenUserAddsAAnd(string Language, string Level)
    {
        throw new PendingStepException();
    }

    [Then(@"'([^']*)' and '([^']*)'   language created sucessfully")]
    public void ThenAndLanguageCreatedSucessfully(string Language, string Level)
    {
        throw new PendingStepException();
    }

}

