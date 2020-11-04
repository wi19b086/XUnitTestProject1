using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, x;
        [Given(@"the first number is PI")]
        public void GivenTheFirstNumberIsPI()
        {
            number = Math.PI;
        }
        
        [When(@"sinus is taken")]
        public void WhenSinusIsTaken()
        {
            x = Math.Sin(number);
        }
        
        [When(@"cosinus is taken")]
        public void WhenCosinusIsTaken()
        {
            x = Math.Cos(number);
        }
        
        [When(@"tangens is taken")]
        public void WhenTangensIsTaken()
        {
            x = Math.Tan(number);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, x, 5);
        }
    }
}
