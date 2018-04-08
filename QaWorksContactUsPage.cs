using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    class QaWorksContactUsPage
    {
        protected virtual DriverScope _ { get; }

        public IEnumerable<ElementScope> ContactUsPageText => _.FindAllCss(".fusion-text");
        public ElementScope ContactUsLink => _.FindXPath("//*[@id='enu - main - menu - 1']/li[5]/a/span");
        public ElementScope Name => _.FindCss(".your-name");
        public ElementScope Email => _.FindCss(".your-email");
        public ElementScope Subject => _.FindCss(".your-company");
        public ElementScope Message => _.FindCss(".your-message");
        public ElementScope SubmitButton => _.FindXPath("//*[@id='contact-us-send']");
    }
}
