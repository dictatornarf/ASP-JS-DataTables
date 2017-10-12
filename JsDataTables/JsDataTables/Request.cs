using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JsDataTables
{
    public class Request
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public string SearchValue { get; set; }
        public bool SearchRegex { get; set; }

        public IList<Column> Columns { get; set; }
        public IList<SortOrder> SortOrders { get; set; }

        public Request(Microsoft.AspNetCore.Http.IFormCollection postValues)
        {
            this.Columns = new List<Column>();
            this.SortOrders = new List<SortOrder>();

            Init(postValues);
        }

        private void Init(Microsoft.AspNetCore.Http.IFormCollection postValues)
        {
            foreach (var keyValue in postValues)
            {
                string key = keyValue.Key;
                string value = keyValue.Value;

                switch (key)
                {
                    case "start":
                        this.Start = Convert.ToInt32(value);
                        break;
                    case "length":
                        this.Length = Convert.ToInt32(value);
                        break;
                    case "search[value]":
                        this.SearchValue = value;
                        break;
                    case "search[regex]":
                        this.SearchRegex = Convert.ToBoolean(value);
                        break;
                    case "draw":
                        this.Draw = Convert.ToInt32(value);
                        break;
                    default:
                        if (key.StartsWith("columns"))
                        {
                            ColumnKey columnKey = new ColumnKey(key);

                            Column column = this.Columns.FirstOrDefault(x => x.Index == columnKey.Index);
                            if (column == null)
                            {
                                column = new Column() { Index = columnKey.Index };
                                this.Columns.Add(column);
                            }

                            switch (columnKey.DataName)
                            {
                                case "data":
                                    column.Data = value;
                                    break;
                                case "name":
                                    column.Name = value;
                                    break;
                                case "searchable":
                                    column.Searchable = Convert.ToBoolean(value);
                                    break;
                                case "orderable":
                                    column.Orderable = Convert.ToBoolean(value);
                                    break;
                                case "search":
                                    switch (columnKey.DataSecondName)
                                    {
                                        case "value":
                                            column.SearchValue = value;
                                            break;
                                        case "regex":
                                            column.SearchRegex = Convert.ToBoolean(value);
                                            break;
                                    }
                                    break;
                            }
                        }
                        else if (key.StartsWith("order"))
                        {
                            ColumnKey columnKey = new ColumnKey(key);

                            SortOrder sortOrder = this.SortOrders.FirstOrDefault(x => x.Index == columnKey.Index);
                            if (sortOrder == null)
                            {
                                sortOrder = new SortOrder() { Index = columnKey.Index, Sort = SortOrderDirection.asc };
                                this.SortOrders.Add(sortOrder);
                            }

                            switch (columnKey.DataName)
                            {
                                case "column":
                                    sortOrder.ColumnIndex = Convert.ToInt32(value);
                                    break;
                                case "dir":
                                    sortOrder.Sort = (value == "desc") ? SortOrderDirection.desc : SortOrderDirection.asc;
                                    break;
                            }
                        }
                        break;
                }
            }
        }

        private class ColumnKey
        {
            public int Index { get; private set; }
            public string DataName { get; private set; }
            public string DataSecondName { get; private set; }

            public ColumnKey(string postKey)
            {
                var findFirst = FindNext(postKey);
                this.Index = Convert.ToInt32(TakeValue(findFirst));
                var findSecond = FindNext(findFirst);
                this.DataName = TakeValue(findSecond);
                var findThird = FindNext(findSecond);
                this.DataSecondName = TakeValue(findThird);
            }

            private IEnumerable<char> FindNext(IEnumerable<char> keyPart)
            {
                return keyPart.SkipWhile(x => x != '[').Skip(1);
            }

            private string TakeValue(IEnumerable<char> keyPart)
            {
                return new string(keyPart.TakeWhile(x => x != ']').ToArray());
            }
        }

    }
}
