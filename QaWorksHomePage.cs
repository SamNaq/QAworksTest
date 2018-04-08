using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Pages
{
    class QaWorksHomePage
    {
        protected virtual DriverScope _ { get; }

        public IEnumerable<ElementScope> HomePageButtons => _.FindAllCss(".fusion-button-wrappercenter");
    }
}
