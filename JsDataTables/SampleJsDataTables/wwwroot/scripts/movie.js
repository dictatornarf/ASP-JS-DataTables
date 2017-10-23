$(document).ready(function () {
    $('#movieTable').DataTable({
        //"search": {
        //    "regex": true
        //},
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