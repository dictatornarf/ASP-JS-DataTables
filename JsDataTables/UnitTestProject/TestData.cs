﻿using System;
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
            }
        );


        }
}
