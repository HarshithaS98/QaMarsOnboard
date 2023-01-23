using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsUpdated.Pages
{
    public class CreateCertification : CommonDriver

    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        public void CreateCertifications(string Certificate, string From, string Year)
        {

            // Identify Certification button and click and using explicit waits to locate elements
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")));
            IWebElement cerbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            cerbutton.Click();

            //    // identify add new button
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")));
            IWebElement addCer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addCer.Click();

            // Add certifications to certification tab
            IWebElement certab = driver.FindElement(By.Name("certificationName"));
            certab.SendKeys(Certificate);

            // Add certified 'From" toolbox
            IWebElement fromtab = driver.FindElement(By.Name("certificationFrom"));
            fromtab.SendKeys(From);


            // select certified "Year" dropdown
            SelectElement yeartab = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            yeartab.SelectByValue(Year);

            // Identify Add button and click
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")));
            IWebElement Addcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            Addcer.Click();
        }

         public void CheckCertificationAdded(string Certificate, string From, string Year)
            
         {
                //boolean value to check if the skill is added for assertion
                bool CertificationAdded = false;
                //reading all the columns from the table
                ReadOnlyCollection<IWebElement> elements;
                wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("td")));
                elements = driver.FindElements(By.TagName("td"));
                for (int i = 0; i < elements.Count; i++)
                {
                    //checking to see if the value of skill is added to any column in the table
                    if (elements[i].Text == Certificate)
                    {
                    //true if skill present
                     CertificationAdded = true;
                        break;
                    }
                }



         }
    } 
}



           
