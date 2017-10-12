# ASP-JS-DataTables
A library for processing server side requests for JS-DataTables in ASP.NET.

## Overview
1. Each of the following examples need to be modified for you needs. All are needed for processing server side requests to work properly.
2. These samples at taken from the SampleJsDataTables project in this Repository.

## C# Model Example
1. This object will be serialized to JSON. Follow the rules of your preferred JSON serializer. In this case, I set the properties to serialize to public.

```cs
public class Movie
{
    public string Phase { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Director { get; set; }
    public string Screenwriter { get; set; }
    public string Producer { get; set; }
}
```

## Core Web API Example
1. Process a search request from JQuery DataTables by submitting the search with a POST and pass Request.Form to the constructor of JsDataTables.Request.
2. To automatically process the results with an in memory data set, use the JsDataTables.Response class. The JSON serialized instance with "camelCasing" (default in Web.API) of this class is the JQuery Datatables expected result.

```cs
[Route("search")]
public JsDataTables.Response<Movie> Search()
{
    var request = new JsDataTables.Request(Request.Form);
    return new JsDataTables.Response<Movie>(request, Movie.AllMovies);
}
```

## HTML Example
1. Declare both the thead and tbody for the JQuery DataTables library.
2. Specified the desired header names
3. Include the appropriate javascript and css files

```html
<link rel="stylesheet" href="//cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css">

...

<table id="movieTable">
    <thead>
        <tr>
            <th>Phase</th>
            <th>Name</th>
            <th>Release Date</th>
            <th>Director</th>
            <th>Screenwriter</th>
            <th>Producer</th>
        </tr>
    </thead>
    <tbody></tbody>
</table>

...

<script src="//code.jquery.com/jquery-2.2.4.min.js"></script>
<script src="//cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script src="scripts/movie.js"></script>
```

## Javascript Example
1. Set processing and serverSide flags to true
2. Set ajax type to POST
3. Set columns and make each columns data field match the name of the c# model property (case will be ingnored for matching names)

```js
$(document).ready(function () {
    $('#movieTable').DataTable({
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "/api/v1/movies/search",
            "type": "POST"
        },
        "order": [[2, "asc"]],
        "columns": [
            {
                "data": "phase"
            },
            {
                "data": "name"
            },
            {
                "data": "releaseDate",
                "render": function (data, type, row) {
                    if (type === "display" || type === "filter")
                    {
                        return moment(data).format("M/D/YYYY");
                    }
                    return data;
                }
            },
            {
                "data": "director"
            },
            {
                "data": "screenwriter"
            },
            {
                "data": "producer"
            }
        ]
    });
});
```