using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    public static class TestData
    {
        public static Microsoft.AspNetCore.Http.FormCollection PostValuesInitialState = new Microsoft.AspNetCore.Http.FormCollection(
            new System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>()
            {
                ["draw"] = "1",
                ["columns[0] [data]"] = "name",
                ["columns[0] [name]"] = "",
                ["columns[0] [searchable]"] = "true",
                ["columns[0] [orderable]"] = "true",
                ["columns[0] [search] [value]"] = "",
                ["columns[0] [search] [regex]"] = "false",
                ["columns[1] [data]"] = "grade",
                ["columns[1] [name]"] = "",
                ["columns[1] [searchable]"] = "true",
                ["columns[1] [orderable]"] = "true",
                ["columns[1] [search] [value]"] = "",
                ["columns[1] [search] [regex]"] = "false",
                ["columns[2] [data]"] = "birthDate",
                ["columns[2] [name]"] = "",
                ["columns[2] [searchable]"] = "true",
                ["columns[2] [orderable]"] = "true",
                ["columns[2] [search] [value]"] = "",
                ["columns[2] [search] [regex]"] = "false",
                ["order[0] [column]"] = "2",
                ["order[0] [dir]"] = "asc",
                ["start"] = "0",
                ["length"] = "10",
                ["search[value]"] = "",
                ["search[regex]"] = "false"
            }
        );

        public static Microsoft.AspNetCore.Http.FormCollection PostValuesSearchString = new Microsoft.AspNetCore.Http.FormCollection(
            new System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>()
            {
                ["draw"] = "1",
                ["columns[0] [data]"] = "name",
                ["columns[0] [name]"] = "",
                ["columns[0] [searchable]"] = "true",
                ["columns[0] [orderable]"] = "true",
                ["columns[0] [search] [value]"] = "",
                ["columns[0] [search] [regex]"] = "false",
                ["columns[1] [data]"] = "grade",
                ["columns[1] [name]"] = "",
                ["columns[1] [searchable]"] = "true",
                ["columns[1] [orderable]"] = "true",
                ["columns[1] [search] [value]"] = "",
                ["columns[1] [search] [regex]"] = "false",
                ["columns[2] [data]"] = "birthDate",
                ["columns[2] [name]"] = "",
                ["columns[2] [searchable]"] = "true",
                ["columns[2] [orderable]"] = "true",
                ["columns[2] [search] [value]"] = "",
                ["columns[2] [search] [regex]"] = "false",
                ["order[0] [column]"] = "1",
                ["order[0] [dir]"] = "asc",
                ["start"] = "0",
                ["length"] = "10",
                ["search[value]"] = "Bill",
                ["search[regex]"] = "false"
            }
        );

        public static Microsoft.AspNetCore.Http.FormCollection PostValuesSearchRegex = new Microsoft.AspNetCore.Http.FormCollection(
            new System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>()
            {
                ["draw"] = "1",
                ["columns[0] [data]"] = "name",
                ["columns[0] [name]"] = "",
                ["columns[0] [searchable]"] = "true",
                ["columns[0] [orderable]"] = "true",
                ["columns[0] [search] [value]"] = "",
                ["columns[0] [search] [regex]"] = "false",
                ["columns[1] [data]"] = "grade",
                ["columns[1] [name]"] = "",
                ["columns[1] [searchable]"] = "true",
                ["columns[1] [orderable]"] = "true",
                ["columns[1] [search] [value]"] = "",
                ["columns[1] [search] [regex]"] = "false",
                ["columns[2] [data]"] = "birthDate",
                ["columns[2] [name]"] = "",
                ["columns[2] [searchable]"] = "true",
                ["columns[2] [orderable]"] = "true",
                ["columns[2] [search] [value]"] = "",
                ["columns[2] [search] [regex]"] = "false",
                ["order[0] [column]"] = "0",
                ["order[0] [dir]"] = "asc",
                ["start"] = "0",
                ["length"] = "10",
                ["search[value]"] = "l Jr.$",
                ["search[regex]"] = "true"
            }
        );

        public static Microsoft.AspNetCore.Http.FormCollection PostValuesSearchDate = new Microsoft.AspNetCore.Http.FormCollection(
            new System.Collections.Generic.Dictionary<string, Microsoft.Extensions.Primitives.StringValues>()
            {
                ["draw"] = "1",
                ["columns[0] [data]"] = "name",
                ["columns[0] [name]"] = "",
                ["columns[0] [searchable]"] = "true",
                ["columns[0] [orderable]"] = "true",
                ["columns[0] [search] [value]"] = "",
                ["columns[0] [search] [regex]"] = "false",
                ["columns[1] [data]"] = "grade",
                ["columns[1] [name]"] = "",
                ["columns[1] [searchable]"] = "true",
                ["columns[1] [orderable]"] = "true",
                ["columns[1] [search] [value]"] = "",
                ["columns[1] [search] [regex]"] = "false",
                ["columns[2] [data]"] = "birthDate",
                ["columns[2] [name]"] = "",
                ["columns[2] [searchable]"] = "true",
                ["columns[2] [orderable]"] = "true",
                ["columns[2] [search] [value]"] = "",
                ["columns[2] [search] [regex]"] = "false",
                ["order[0] [column]"] = "1",
                ["order[0] [dir]"] = "desc",
                ["start"] = "0",
                ["length"] = "10",
                ["search[value]"] = "2007",
                ["search[regex]"] = "false"
            }
        );

        public static IList<TestObject> TestObjects = new List<TestObject>()
        {
            new TestObject() { Name = "Bill", Grade = 10, BirthDate = new DateTime(2003, 04, 01)},
            new TestObject() { Name = "Sara", Grade = 9, BirthDate = new DateTime(2001, 04, 01)},
            new TestObject() { Name = "Phil", Grade = 11, BirthDate = new DateTime(1993, 04, 01)},
            new TestObject() { Name = "Carl", Grade = 15, BirthDate = new DateTime(1987, 04, 01)},
            new TestObject() { Name = "Suzy", Grade = 4, BirthDate = new DateTime(2013, 07, 01)},
            new TestObject() { Name = "Jane", Grade = 6, BirthDate = new DateTime(2007, 07, 01)},
            new TestObject() { Name = "Boop", Grade = 8, BirthDate = new DateTime(2009, 07, 01)},
            new TestObject() { Name = "Bill Jr.", Grade = 10-2, BirthDate = new DateTime(2003, 01, 01)},
            new TestObject() { Name = "Sara Jr.", Grade = 9-2, BirthDate = new DateTime(2001, 01, 01)},
            new TestObject() { Name = "Phil Jr.", Grade = 11-2, BirthDate = new DateTime(1993, 01, 01)},
            new TestObject() { Name = "Carl Jr.", Grade = 15-2, BirthDate = new DateTime(1987, 01, 01)},
            new TestObject() { Name = "Suzy Jr.", Grade = 4-2, BirthDate = new DateTime(2013, 10, 01)},
            new TestObject() { Name = "Jane Jr.", Grade = 6-2, BirthDate = new DateTime(2007, 10, 01)},
            new TestObject() { Name = "Boop Jr.", Grade = 8-2, BirthDate = new DateTime(2009, 10, 01)}
        };

        }
}
