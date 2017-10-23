using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace JsDataTables
{
    public class Response<T>
    {
        public int Draw { get; set; }
        public int RecordsFiltered { get; set; }
        public int RecordsTotal { get; set; }
        public IEnumerable<T> Data { get; set; }

        public Response(Request request, IList<T> allData)
        {
            this.Draw = request.Draw;
            this.RecordsTotal = allData.Count;
            var filteredData = FilterData(request, allData);
            this.RecordsFiltered = filteredData.Count();
            this.Data = filteredData.Skip(request.Start).Take(request.Length).ToList();            
        }

        protected IEnumerable<T> FilterData(Request request, IList<T> allData)
        {
            IEnumerable<T> processedData = allData;

            //Search allowed
            if (!string.IsNullOrEmpty(request.SearchValue))
            {
                IList<Column> searchableColumns = request.Columns.Where(x => x.Searchable).ToList();
                processedData = processedData.Where(x => searchableColumns.Any(c => IsDataMatch(x, c.Data, request.SearchValue, request.SearchRegex)));
            }

            //Search for individual columns
            IList<Column> customSearchColumns = request.Columns.Where(x => !string.IsNullOrEmpty(x.SearchValue)).ToList();
            if (customSearchColumns.Count > 0)
            {
                processedData = processedData.Where(x => customSearchColumns.All(c => IsDataMatch(x, c.Data, c.SearchValue, c.SearchRegex)));
            }

            //Order by
            IOrderedEnumerable<T> orderedData = null;
            for (int i = 0; i < request.SortOrders.Count; i++)
            {
                SortOrder order = request.SortOrders.FirstOrDefault(x => x.Index == i);
                if (orderedData == null)
                {
                    if (order.Sort == SortOrderDirection.asc)
                        orderedData = processedData.OrderBy(x => GetData(x, request.Columns.First(c => c.Index == order.ColumnIndex).Data));
                    else
                        orderedData = processedData.OrderByDescending(x => GetData(x, request.Columns.First(c => c.Index == order.ColumnIndex).Data));
                }
                else
                {
                    if (order.Sort == SortOrderDirection.asc)
                        orderedData = orderedData.ThenBy(x => GetData(x, request.Columns.First(c => c.Index == order.ColumnIndex).Data));
                    else
                        orderedData = orderedData.ThenByDescending(x => GetData(x, request.Columns.First(c => c.Index == order.ColumnIndex).Data));
                }
            }

            if (orderedData == null)
                return processedData; //No Sorting specified
            else
                return orderedData;
        }

        protected bool IsDataMatch(T data, string dataName, string searchValue, bool searchRegex)
        {
            object value = GetData(data, dataName);
            if (value != null)
            {
                if (value is DateTime dtValue)
                {
                    //Handle Julian
                    var julianParts = searchValue.Split('-');
                    if (julianParts.Length > 0)
                    {
                        if (julianParts.Length == 2) //Year and Month
                        {
                            if (int.TryParse(julianParts[0], out int year) && int.TryParse(julianParts[1], out int month))
                            {
                                return dtValue.Year == year && dtValue.Month == month;
                            }
                        }
                        else if (julianParts.Length == 3) //Year Month Day
                        {
                            if (int.TryParse(julianParts[0], out int year) && int.TryParse(julianParts[1], out int month) && int.TryParse(julianParts[2], out int day))
                            {
                                return dtValue.Year == year && dtValue.Month == month && dtValue.Day == day;
                            }
                        }
                    }

                    //Handle Gregorian
                    var gregorianParts = searchValue.Split('/');
                    if (gregorianParts.Length > 0)
                    {
                        if (gregorianParts.Length == 2) //Month and day
                        {
                            if (int.TryParse(gregorianParts[0], out int month) && int.TryParse(gregorianParts[1], out int day))
                            {
                                return dtValue.Month == month && dtValue.Day == day;
                            }
                        }
                        else if (gregorianParts.Length == 3) //Month Day Year
                        {
                            if (int.TryParse(gregorianParts[0], out int month) && int.TryParse(gregorianParts[1], out int day) && int.TryParse(gregorianParts[2], out int year))
                            {
                                return dtValue.Month == month && dtValue.Day == day && dtValue.Year == year;
                            }
                        }
                    }

                    //Handle Unknown
                    if (int.TryParse(searchValue, out int dateNumber))
                    {
                        return dtValue.Year == dateNumber || dtValue.Month == dateNumber || dtValue.Day == dateNumber;
                    }
                }
                else if (value is short && short.TryParse(searchValue, out short sSearch))
                {
                    return sSearch == (short)value;
                }
                else if (value is int && int.TryParse(searchValue, out int iSearch))
                {
                    return iSearch == (int)value;
                }
                else if (value is long && long.TryParse(searchValue, out long lSearch))
                {
                    return lSearch == (long)value;
                }
                else if (value is float && float.TryParse(searchValue, out float fSearch))
                {
                    return fSearch == (float)value;
                }
                else if (value is double && double.TryParse(searchValue, out double dSearch))
                {
                    return dSearch == (double)value;
                }
                else if (value is decimal && decimal.TryParse(searchValue, out decimal mSearch))
                {
                    return mSearch == (decimal)value;
                }
                else //Treat as string
                {
                    if (searchRegex)
                    {
                        return System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), searchValue, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    }
                    else
                    {
                        return (value.ToString().IndexOf(searchValue, StringComparison.CurrentCultureIgnoreCase) != -1); //Search partial string
                    }
                }
            }

            return false;
        }

        protected object GetData(T data, string dataName)
        {
            var prop = typeof(T).GetProperty(dataName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            return prop?.GetValue(data);
        }
    }
}
