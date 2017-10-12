using System;
using System.Collections.Generic;
using System.Text;

namespace JsDataTables
{
    public class Column
    {
        public int Index { get; set; }
        public string Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public string SearchValue { get; set; }
        public bool SearchRegex { get; set; }
    }
}
