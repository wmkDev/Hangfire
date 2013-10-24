﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class JobFetcherFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JobFetcher.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "JobFetcher", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "JobFetcher")))
            {
                HangFire.Tests.JobFetcherFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Fetcher returns the job payload when it dequeues a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobFetcher")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void FetcherReturnsTheJobPayloadWhenItDequeuesAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher returns the job payload when it dequeues a job", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
     testRunner.Then("the fetcher returns the payload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Fetcher removes the dequeued job from the queue and adds it to the dequeued list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobFetcher")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void FetcherRemovesTheDequeuedJobFromTheQueueAndAddsItToTheDequeuedList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher removes the dequeued job from the queue and adds it to the dequeued list", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
     testRunner.Then("the queue does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
      testRunner.But("the dequeued jobs list contains it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Fetcher returns null when it tries to dequeue a job from an empty queue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobFetcher")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void FetcherReturnsNullWhenItTriesToDequeueAJobFromAnEmptyQueue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher returns null when it tries to dequeue a job from an empty queue", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("an empty queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
     testRunner.Then("the fetcher does not return any job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Fetcher dequeues jobs in the FIFO order")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobFetcher")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void FetcherDequeuesJobsInTheFIFOOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher dequeues jobs in the FIFO order", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
    testRunner.Given("the \'first\' job in the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
      testRunner.And("the \'second\' job in the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
     testRunner.When("it dequeues a job for the first time", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
     testRunner.Then("the fetcher returns the \'first\' job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
     testRunner.When("it dequeues a job for the second time", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
     testRunner.Then("the fetcher returns the \'second\' job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Fetcher listens only specified queue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobFetcher")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void FetcherListensOnlySpecifiedQueue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher listens only specified queue", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
    testRunner.Given("a job in the \'another\' queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
     testRunner.And("the fetcher listening the \'default\' queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
     testRunner.Then("the fetcher does not return any job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Fetcher sets the \'fetched\' flag when it dequeues a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobFetcher")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void FetcherSetsTheFetchedFlagWhenItDequeuesAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher sets the \'fetched\' flag when it dequeues a job", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
     testRunner.Then("the job has the \'fetched\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
