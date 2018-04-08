using Coypu;
using Coypu.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;
using Zukini;
using Zukini.UI;
using BoDi;
using NUnit.Framework;
using TestProject.Pages;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class QaWorks : UISteps
    {
        private QaWorksContactUsPage _page;
        private QaWorksHomePage _HPage;
        public QaWorks(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }

        [Given(@"I navigate to the web page ""(.*)""")]
        public void GivenINavigateToTheWebPage(string url)
        {
            var browser = new BrowserSession();
            browser.Visit(url);
            Assert.IsTrue(_HPage.HomePageButtons.All(i => i.Exists()), "Home page did not load correctly");
        }

        [Then(@"I click on contact us page")]
        public void ThenIClickOnContactUsPage()
        {
            _page.ContactUsLink.Click();
            Assert.IsTrue(_page.ContactUsPageText.All(i => i.Exists()), "Contact Us Page did not load correctly");
        }

        [Then(@"I submit the get in touch form")]
        public void ThenISubmitTheGetInTouchForm()
        {
            _page.Name.SendKeys("Jhon Doe");
            _page.Email.SendKeys("Jhon.Doe@gmail.com");
            _page.Subject.SendKeys("This is a test");
            _page.Message.SendKeys("Keep up the good work");
            _page.SubmitButton.Click();
        }



    }

}

