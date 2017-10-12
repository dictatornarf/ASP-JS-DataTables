using System;
using System.Collections.Generic;
using System.Text;

namespace JsDataTables
{
    public class SortOrder
    {
        public int Index { get; set; }
        public int ColumnIndex { get; set; }
        public SortOrderDirection Sort { get; set; }
    }
}
