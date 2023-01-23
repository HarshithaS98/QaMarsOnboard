using MarsUpdated.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsUpdated.StepDefinitions
{
    public class CreateanguageStepDefinitions : CommonDriver
    {
        CreateCertification ASP;

        public CreateanguageStepDefinitions()
        {
            ASP = new CreateCertification();

        }
        [When(@"Added '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void WhenAddedAndAndToTheCertifications(string Certificate, string From, string Year)
        {
            ASP.CreateCertifications(Certificate,From, Year);
        }
        [Then(@"'([^']*)' and '([^']*)' and '([^']*)'  created successfully")]
        public void ThenAndAndCreatedSuccessfully(string Certificate, string From, string Year)
        {
            ASP.CheckCertificationAdded(Certificate, From, Year);
        }

    }
}