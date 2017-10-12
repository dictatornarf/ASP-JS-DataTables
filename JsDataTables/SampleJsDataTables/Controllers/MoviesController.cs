using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JsDataTables;
using SampleJsDataTables.Models;

namespace SampleJsDataTables.Controllers
{
    [Route("api/v1/[controller]")]
    public class MoviesController : Controller
    {
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Movie.AllMovies;
        }

        [Route("search")]
        public JsDataTables.Response<Movie> Search()
        {
            var request = new JsDataTables.Request(Request.Form);
            return new JsDataTables.Response<Movie>(request, Movie.AllMovies);
        }
    }
}
