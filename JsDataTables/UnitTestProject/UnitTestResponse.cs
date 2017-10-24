using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestResponse
    {
        [TestInitialize]
        public void Init()
        {
            
        }

        [TestMethod]
        public void ProcessInitialState()
        {
            JsDataTables.Request request = new JsDataTables.Request(TestData.PostValuesInitialState);
            JsDataTables.Response<TestObject> response = new JsDataTables.Response<TestObject>(request, TestData.TestObjects);

            Assert.AreEqual(response.Draw, 1);
            Assert.AreEqual(response.RecordsTotal, 14);
            Assert.AreEqual(response.RecordsFiltered, 14);
            Assert.AreEqual(response.Data.Count(), 10);
            Assert.AreEqual(response.Data.First().Name, "Carl Jr.");
        }

        [TestMethod]
        public void ProcessSearchString()
        {
            JsDataTables.Request request = new JsDataTables.Request(TestData.PostValuesSearchString);
            JsDataTables.Response<TestObject> response = new JsDataTables.Response<TestObject>(request, TestData.TestObjects);

            Assert.AreEqual(response.Draw, 1);
            Assert.AreEqual(response.RecordsTotal, 14);
            Assert.AreEqual(response.RecordsFiltered, 2);
            Assert.AreEqual(response.Data.Count(), 2);
            Assert.AreEqual(response.Data.First().Name, "Bill Jr.");
        }

        [TestMethod]
        public void ProcessSearchRegex()
        {
            JsDataTables.Request request = new JsDataTables.Request(TestData.PostValuesSearchRegex);
            JsDataTables.Response<TestObject> response = new JsDataTables.Response<TestObject>(request, TestData.TestObjects);

            Assert.AreEqual(response.Draw, 1);
            Assert.AreEqual(response.RecordsTotal, 14);
            Assert.AreEqual(response.RecordsFiltered, 3);
            Assert.AreEqual(response.Data.Count(), 3);
            Assert.AreEqual(response.Data.First().Name, "Bill Jr.");
        }

        [TestMethod]
        public void ProcessSearchDate()
        {
            JsDataTables.Request request = new JsDataTables.Request(TestData.PostValuesSearchDate);
            JsDataTables.Response<TestObject> response = new JsDataTables.Response<TestObject>(request, TestData.TestObjects);

            Assert.AreEqual(response.Draw, 1);
            Assert.AreEqual(response.RecordsTotal, 14);
            Assert.AreEqual(response.RecordsFiltered, 2);
            Assert.AreEqual(response.Data.Count(), 2);
            Assert.AreEqual(response.Data.First().Name, "Jane");
        }
    }
}
