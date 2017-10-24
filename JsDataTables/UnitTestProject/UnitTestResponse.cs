using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Process()
        {
            JsDataTables.Request request = new JsDataTables.Request(TestData.PostValuesInitialState);
        }
    }
}
