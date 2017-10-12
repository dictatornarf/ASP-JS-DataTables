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
        // GET api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Movie.AllMovies;
        }

        [Route("search")]
        public JsDataTables.Response<Movie> Search()
        {
            //string json = "";
            //using (var sr = new System.IO.StreamReader(Request.Body))
            //{
            //    json = sr.ReadToEnd();
            //}

            var request = new JsDataTables.Request(Request.Form);
            return new JsDataTables.Response<Movie>(request, Movie.AllMovies);
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        //[HttpPost]
        //public JsDataTables.Request ViewMovies()
        //{
        //    //Request.
        //    return null;
        //}
    }
}
