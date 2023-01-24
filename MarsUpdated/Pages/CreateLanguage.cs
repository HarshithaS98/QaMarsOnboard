using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MarsUpdated.Pages
{
    public class CreateLanguage : CommonDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        public void CreateLanguages(string Language, string Level)
        {

            // Identify language button and click and using explicit waits to locate elements
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
            IWebElement languagebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagebutton.Click();


            // Identify Add new button and click
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")));
            IWebElement addnewbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();
            // identifying add language tool box and enter values
            IWebElement addlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguage.SendKeys(Language);
            // identifying choose language drop box
            SelectElement chooselanguage = new SelectElement(driver.FindElement(By.Name("level")));
            chooselanguage.SelectByValue(Level);

            // click add button
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")));

            IWebElement addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addbutton.Click();

        }
        //// Profile page
        ////LANGUAGES
        //// Identifying languages button 
        //Thread.Sleep(1000);
        //    IWebElement languagebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        //languagebutton.Click();
        //    Thread.Sleep(1500);
        //    // Identifying add new button
        //    IWebElement addnewbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        //addnewbutton.Click();
        //    Thread.Sleep(1500);
        //    // identifying add language tool box and enter values
        //    IWebElement addlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        //addlanguage.SendKeys(language);
        //    Thread.Sleep(1500);
        //    // identifying choose language drop box
        //    SelectElement chooselanguage = new SelectElement(driver.FindElement(By.Name("level")));
        //chooselanguage.SelectByValue(level);
        //    //IWebElement chooselanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        //    //chooselanguage.Click();     //  //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select   
        //    //Thread.Sleep(1500);
        //    ////identifying fluent in dropbox
        //    //IWebElement fluentdropbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
        //    //fluentdropbox.Click();
        //    Thread.Sleep(1500);
        //    // click add button
        //    IWebElement addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        //addbutton.Click();

        public void CheckLangugaeAdded(string Language, string Level)
        {
            Thread.Sleep(1000);
            //boolean value to check if the skill is added for assertion
            bool LanguageAdded = false;
            //reading all the columns from the table
            ReadOnlyCollection<IWebElement> elements;
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("td")));
            elements = driver.FindElements(By.TagName("td"));
            for (int i = 0; i < elements.Count; i++)
            {
                //checking to see if the value of skill is added to any column in the table
                if (elements[i].Text == Language)
                {
                    //true if language present
                    LanguageAdded = true;
                    break;
                }
            }
            //fluent assertions. True if skill added
            LanguageAdded.Should().BeTrue();
        }


    }


}
