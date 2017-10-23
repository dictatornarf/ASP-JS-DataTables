using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestRequest
    {
        public Microsoft.AspNetCore.Http.FormCollection PostValues { get; private set; }

        [TestInitialize]
        public void Init()
        {
            System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues> values = new System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>()
            {
                ["draw"] = "1",
                ["columns[0] [data]"] = "phase",
                ["columns[0] [name]"] = "",
                ["columns[0] [searchable]"] = "true",
                ["columns[0] [orderable]"] = "true",
                ["columns[0] [search] [value]"] = "",
                ["columns[0] [search] [regex]"] = "false",
                ["columns[1] [data]"] = "name",
                ["columns[1] [name]"] = "",
                ["columns[1] [searchable]"] = "true",
                ["columns[1] [orderable]"] = "true",
                ["columns[1] [search] [value]"] = "",
                ["columns[1] [search] [regex]"] = "false",
                ["columns[2] [data]"] = "releaseDate",
                ["columns[2] [name]"] = "",
                ["columns[2] [searchable]"] = "true",
                ["columns[2] [orderable]"] = "true",
                ["columns[2] [search] [value]"] = "",
                ["columns[2] [search] [regex]"] = "false",
                ["columns[3] [data]"] = "director",
                ["columns[3] [name]"] = "",
                ["columns[3] [searchable]"] = "true",
                ["columns[3] [orderable]"] = "true",
                ["columns[3] [search] [value]"] = "",
                ["columns[3] [search] [regex]"] = "false",
                ["columns[4] [data]"] = "screenwriter",
                ["columns[4] [name]"] = "",
                ["columns[4] [searchable]"] = "true",
                ["columns[4] [orderable]"] = "true",
                ["columns[4] [search] [value]"] = "",
                ["columns[4] [search] [regex]"] = "false",
                ["columns[5] [data]"] = "producer",
                ["columns[5] [name]"] = "",
                ["columns[5] [searchable]"] = "true",
                ["columns[5] [orderable]"] = "true",
                ["columns[5] [search] [value]"] = "",
                ["columns[5] [search] [regex]"] = "false",
                ["order[0] [column]"] = "2",
                ["order[0] [dir]"] = "asc",
                ["start"] = "0",
                ["length"] = "10",
                ["search[value]"] = "",
                ["search[regex]"] = "false"
            };

            PostValues = new Microsoft.AspNetCore.Http.FormCollection(values);
        }

        [TestMethod]
        public void DecodeForm()
        {
            JsDataTables.Request request = new JsDataTables.Request(PostValues);

            Assert.AreEqual(request.Draw, 1);

            Assert.AreEqual(request.Columns.Count, 6);

            Assert.AreEqual(request.Columns[0].Data, "phase");
            Assert.AreEqual(request.Columns[0].Name, "");
            Assert.AreEqual(request.Columns[0].Searchable, true);
            Assert.AreEqual(request.Columns[0].Orderable, true);
            Assert.AreEqual(request.Columns[0].SearchValue, "");
            Assert.AreEqual(request.Columns[0].SearchRegex, false);

            Assert.AreEqual(request.Columns[1].Data, "name");
            Assert.AreEqual(request.Columns[1].Name, "");
            Assert.AreEqual(request.Columns[1].Searchable, true);
            Assert.AreEqual(request.Columns[1].Orderable, true);
            Assert.AreEqual(request.Columns[1].SearchValue, "");
            Assert.AreEqual(request.Columns[1].SearchRegex, false);

            Assert.AreEqual(request.Columns[2].Data, "releaseDate");
            Assert.AreEqual(request.Columns[2].Name, "");
            Assert.AreEqual(request.Columns[2].Searchable, true);
            Assert.AreEqual(request.Columns[2].Orderable, true);
            Assert.AreEqual(request.Columns[2].SearchValue, "");
            Assert.AreEqual(request.Columns[2].SearchRegex, false);

            Assert.AreEqual(request.Columns[3].Data, "director");
            Assert.AreEqual(request.Columns[3].Name, "");
            Assert.AreEqual(request.Columns[3].Searchable, true);
            Assert.AreEqual(request.Columns[3].Orderable, true);
            Assert.AreEqual(request.Columns[3].SearchValue, "");
            Assert.AreEqual(request.Columns[3].SearchRegex, false);

            Assert.AreEqual(request.Columns[4].Data, "screenwriter");
            Assert.AreEqual(request.Columns[4].Name, "");
            Assert.AreEqual(request.Columns[4].Searchable, true);
            Assert.AreEqual(request.Columns[4].Orderable, true);
            Assert.AreEqual(request.Columns[4].SearchValue, "");
            Assert.AreEqual(request.Columns[4].SearchRegex, false);

            Assert.AreEqual(request.Columns[5].Data, "producer");
            Assert.AreEqual(request.Columns[5].Name, "");
            Assert.AreEqual(request.Columns[5].Searchable, true);
            Assert.AreEqual(request.Columns[5].Orderable, true);
            Assert.AreEqual(request.Columns[5].SearchValue, "");
            Assert.AreEqual(request.Columns[5].SearchRegex, false);

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
