using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AbelAndCole.Utilities
{
    [Binding]
    public class Hooks1
    {

        public static IWebDriver Driver;
       

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Driver.Quit();
        }
    }
}
