using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestRequest
    {
        [TestInitialize]
        public void Init()
        {

        }

        [TestMethod]
        public void DecodeForm()
        {
            JsDataTables.Request request = new JsDataTables.Request(TestData.PostValuesInitialState);

            Assert.AreEqual(request.Draw, 1);

            Assert.AreEqual(request.Columns.Count, 3);

            Assert.AreEqual(request.Columns[0].Data, "name");
            Assert.AreEqual(request.Columns[0].Name, "");
            Assert.AreEqual(request.Columns[0].Searchable, true);
            Assert.AreEqual(request.Columns[0].Orderable, true);
            Assert.AreEqual(request.Columns[0].SearchValue, "");
            Assert.AreEqual(request.Columns[0].SearchRegex, false);

            Assert.AreEqual(request.Columns[1].Data, "grade");
            Assert.AreEqual(request.Columns[1].Name, "");
            Assert.AreEqual(request.Columns[1].Searchable, true);
            Assert.AreEqual(request.Columns[1].Orderable, true);
            Assert.AreEqual(request.Columns[1].SearchValue, "");
            Assert.AreEqual(request.Columns[1].SearchRegex, false);

            Assert.AreEqual(request.Columns[2].Data, "birthDate");
            Assert.AreEqual(request.Columns[2].Name, "");
            Assert.AreEqual(request.Columns[2].Searchable, true);
            Assert.AreEqual(request.Columns[2].Orderable, true);
            Assert.AreEqual(request.Columns[2].SearchValue, "");
            Assert.AreEqual(request.Columns[2].SearchRegex, false);

            Assert.AreEqual(request.SortOrders.Count, 1);
            Assert.AreEqual(request.SortOrders[0].ColumnIndex, 2);
            Assert.AreEqual(request.SortOrders[0].Sort, JsDataTables.SortOrderDirection.asc);

            Assert.AreEqual(request.Start, 0);
            Assert.AreEqual(request.Length, 10);
            Assert.AreEqual(request.SearchValue, "");
            Assert.AreEqual(request.SearchRegex, false);
        }
    }
}
