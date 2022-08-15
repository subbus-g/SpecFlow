using TechTalk.SpecFlow.Assist;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine("first number is " + number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            
        }


        [Then(@"the result is ""([^""]*)""")]
        public void ThenTheResultIs(string result)
        {
            Console.WriteLine("the result is: "+result);
        }

        [Given(@"I input following numbers to the calculator")]
        public void GivenIInputFollowingNumbersToTheCalculator(Table table)
        {
            var data = table.CreateInstance<Data>();
            Console.WriteLine("the number in data: "+data.Number); 
        }
        public class Data
        {
            public int Number { get; set; }
        }
    }
}