using TechTalk.SpecFlow;

namespace SpecFlowBasics.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks



        [BeforeTestRun]
        public static void ExecuteBeforeTestRun()
        {
            Console.WriteLine("I am executing before test run is started");
        }



        [BeforeScenario("@table")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("I should come for table scenario only");
        }



        [AfterScenario]
        public void AfterScenario() => Console.WriteLine("this scenarios is ended");
        
    }
}