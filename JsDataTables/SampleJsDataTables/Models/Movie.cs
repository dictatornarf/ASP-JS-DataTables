using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleJsDataTables.Models
{
    public class Movie
    {
        public string Phase { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Screenwriter { get; set; }
        public string Producer { get; set; }
        public static IList<Movie> AllMovies { get => allMovies; set => allMovies = value; }
        public static IList<Movie> AllMovies1 { get => allMovies; set => allMovies = value; }

        public Movie(string phase, string name, DateTime releaseDate, string director, string screenwriter, string producer)
        {
            this.Phase = phase;
            this.Name = name;
            this.ReleaseDate = releaseDate;
            this.Director = director;
            this.Screenwriter = screenwriter;
            this.Producer = producer;
        }

        private static IList<Movie> allMovies = new List<Movie>()
        {
            new Movie("I", "Iron Man", new DateTime(2008, 5, 2), "Jon Favreau", "Mark Fergus & Hawk Ostby and Art Marcum & Matt Holloway", "Avi Arad and Kevin Feige"),
            new Movie("I", "The Incredible Hulk", new DateTime(2008, 6, 13), "Louis Leterrier", "Zak Penn", "Avi Arad, Gale Anne Hurd and Kevin Feige"),
            new Movie("I", "Iron Man 2", new DateTime(2010, 5, 7), "Jon Favreau", "Justin Theroux", "Kevin Feige"),
            new Movie("I", "Thor", new DateTime(2011, 5, 6), "Kenneth Branagh", "Ashley Edward Miller & Zack Stentz and Don Payne", "Kevin Feige"),
            new Movie("I", "Captain America: The First Avenger", new DateTime(2011, 7, 22), "Joe Johnston", "Christopher Markus & Stephen McFeely", "Kevin Feige"),
            new Movie("I", "Marvel's The Avengers", new DateTime(2012, 5, 4), "Joss Whedon", "Joss Whedon", "Kevin Feige"),

            new Movie("II", "Iron Man 3", new DateTime(2013, 5, 3), "Shane Black", "Drew Pearce and Shane Black", "Kevin Feige"),
            new Movie("II", "Thor: The Dark World", new DateTime(2013, 11, 8), "Alan Taylor", "Christopher Yost and Christopher Markus & Stephen McFeely", "Kevin Feige"),
            new Movie("II", "Captain America: The Winter Soldier", new DateTime(2014, 4, 4), "Anthony and Joe Russo", "Christopher Markus & Stephen McFeely", "Kevin Feige"),
            new Movie("II", "Guardians of the Galaxy", new DateTime(2014, 8, 1), "James Gunn", "James Gunn and Nicole Perlman", "Kevin Feige"),
            new Movie("II", "Avengers: Age of Ultron", new DateTime(2015, 5, 1), "Joss Whedon", "Joss Whedon", "Kevin Feige"),
            new Movie("II", "Ant-Man", new DateTime(2015, 7, 17), "Peyton Reed", "Edgar Wright & Joe Cornish and Adam McKay & Paul Rudd", "Kevin Feige"),

            new Movie("III", "Captain America: Civil War", new DateTime(2016, 5, 6), "Anthony and Joe Russo", "Christopher Markus & Stephen McFeely", "Kevin Feige"),
            new Movie("III", "Doctor Strange", new DateTime(2016, 11, 4), "Scott Derrickson", "Jon Spaihts and Scott Derrickson & C. Robert Cargill", "Kevin Feige"),
            new Movie("III", "Guardians of the Galaxy Vol. 2", new DateTime(2017, 5, 5), "James Gunn", "James Gunn", "Kevin Feige"),
            new Movie("III", "Spider-Man: Homecoming", new DateTime(2017, 7, 7), "Jon Watts", "Jonathan Goldstein & John Francis Daley and Jon Watts & Christopher Ford and Chris McKenna & Erik Sommers", "Kevin Feige and Amy Pascal"),
            new Movie("III", "Thor: Ragnarok", new DateTime(2017, 11, 3), "Taika Waititi", "Eric Pearson and Craig Kyle & Christopher Yost", "Kevin Feige"),
        };
    }
}
