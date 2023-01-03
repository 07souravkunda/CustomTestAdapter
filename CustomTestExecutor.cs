using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;

namespace Custom.VisualStudio.TestAdapter
{
    [ExtensionUri("executor://NUnit3TestExecutor")]
    public class BStackTestExecutor : ITestExecutor
    {
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void RunTests(IEnumerable<TestCase>? tests, IRunContext? runContext, IFrameworkHandle? frameworkHandle)
        {
            var shouldRun = Environment.GetEnvironmentVariable("RUN_CUSTOM_EXECUTOR");
            if (shouldRun == "true")
            {
                // Do some custom execution
            }
            else
            {
                // Skip to default nunit3 executor
            }
        }
     
        void ITestExecutor.RunTests(IEnumerable<string>? sources, IRunContext? runContext, IFrameworkHandle? frameworkHandle)
        {
            // 
        }
    }
}
