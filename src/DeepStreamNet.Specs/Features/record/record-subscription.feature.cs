﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DeepStreamNet.Specs.Features.Record
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class RecordSubscriptionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "record-subscription.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Record Subscription", @"	Record subscriptions is done purely on the client side. Whenever 
	an update is recieved for a record, you should find out if anyone 
	is interested and then notify them. When implementing, please keep
	in mind the difference between an update and a patch.

	Updates mean you should fully discard the data that you had, and 
	replace it with the data recieved. 

	Patch means you should apply the diff onto the data you currently 
	have.

	From the clients callback perspective there isn't really a 
	difference when recieving updates or patches, since the 
	new data is compared against the old and only the differences 
	are provided to the callback", ProgrammingLanguage.CSharp, new string[] {
                        "records"});
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
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Record Subscription")))
            {
                DeepStreamNet.Specs.Features.Record.RecordSubscriptionFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client is connected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientIsConnected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client is connected", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("the test server is ready", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
  testRunner.And("the client is initialised", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
  testRunner.And("the client logs in with username \"XXX\" and password \"YYY\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.And("the server sends the message A|A+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client creates a record")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientCreatesARecord()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client creates a record", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.When("the client creates a record named \"subscribeRecord\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("the last message the server recieved is R|CR|subscribeRecord+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The server responds with an ack and the initial read")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheServerRespondsWithAnAckAndTheInitialRead()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The server responds with an ack and the initial read", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.When("the server sends the message R|A|S|subscribeRecord+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
  testRunner.And("the server sends the message R|R|subscribeRecord|124|{\"name\":\"Smith\",\"pets\":[{\"na" +
                    "me\":\"Ruffus\",\"type\":\"dog\",\"age\":0}]}+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client subscribes to subscribeRecord")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientSubscribesToSubscribeRecord()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client subscribes to subscribeRecord", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.When("the client subscribes to the entire record \"subscribeRecord\" changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("the client will not be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client record subscribeRecord receives updated data it will notify subscriber" +
            "s")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientRecordSubscribeRecordReceivesUpdatedDataItWillNotifySubscribers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client record subscribeRecord receives updated data it will notify subscriber" +
                    "s", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
 testRunner.When("the server sends the message R|U|subscribeRecord|125|{\"name\":\"Smith\",\"pets\":[{\"na" +
                    "me\":\"Ruffus\",\"type\":\"dog\",\"age\":1}]}+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the client will be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client record subscribeRecord receives partial data it will notify subscriber" +
            "s")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientRecordSubscribeRecordReceivesPartialDataItWillNotifySubscribers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client record subscribeRecord receives partial data it will notify subscriber" +
                    "s", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.When("the server sends the message R|P|subscribeRecord|126|pets.0.name|SRuffusTheSecond" +
                    "+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the client will be notified of the partial record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client will no longer get notified after it unsubscribes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientWillNoLongerGetNotifiedAfterItUnsubscribes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client will no longer get notified after it unsubscribes", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("the client unsubscribes to the entire record \"subscribeRecord\" changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When("the server sends the message R|U|subscribeRecord|127|{\"name\":\"Smith\",\"pets\":[{\"na" +
                    "me\":\"Ruffus\",\"type\":\"dog\",\"age\":1}]}+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("the client will not be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client subscribes subscribeRecord to the path pets.0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientSubscribesSubscribeRecordToThePathPets_0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client subscribes subscribeRecord to the path pets.0", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.When("the client subscribes to \"pets.0.age\" for the record \"subscribeRecord\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("the client will not be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client receives an partial update unrelated to the path subscribed to")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientReceivesAnPartialUpdateUnrelatedToThePathSubscribedTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client receives an partial update unrelated to the path subscribed to", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
 testRunner.When("the server sends the message R|P|subscribeRecord|128|name|SJohn Smith+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("the client will not be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client receives an full update where the pets age hasn\'t changed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientReceivesAnFullUpdateWhereThePetsAgeHasnTChanged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client receives an full update where the pets age hasn\'t changed", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.When("the server sends the message R|U|subscribeRecord|129|{\"name\":\"John Smith\", \"age\":" +
                    " 21, \"pets\": [{\"name\":\"Ruffus\", \"type\":\"dog\",\"age\":1}]}+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the client will not be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client receives an partial update related to the path subscribed to")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientReceivesAnPartialUpdateRelatedToThePathSubscribedTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client receives an partial update related to the path subscribed to", ((string[])(null)));
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.When("the server sends the message R|P|subscribeRecord|130|pets.0.age|N4+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("the client will be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client receives an full update where the pets has changed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientReceivesAnFullUpdateWhereThePetsHasChanged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client receives an full update where the pets has changed", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 71
 testRunner.When("the server sends the message R|U|subscribeRecord|131|{\"name\":\"John Smith\", \"age\":" +
                    " 21, \"pets\": [{\"name\":\"Ruffus\", \"type\":\"dog\",\"age\":5}]}+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("the client will be notified of the second record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client will no longer get notified after it unsubscribes to the path")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Record Subscription")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("records")]
        public virtual void TheClientWillNoLongerGetNotifiedAfterItUnsubscribesToThePath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client will no longer get notified after it unsubscribes to the path", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
 testRunner.Given("the client unsubscribes to \"pets.0.age\" for the record \"subscribeRecord\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
 testRunner.When("the server sends the message R|P|subscribeRecord|132|pets.0.age|N6+", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("the client will not be notified of the record change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion