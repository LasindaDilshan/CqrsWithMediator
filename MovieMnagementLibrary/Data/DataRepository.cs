using System;
using MovieMnagementLibrary.Models;

namespace MovieMnagementLibrary.Data
{
    public class DataRepository : IDataRepository
    {
        private static List<MovieModel> _movie = new()
        {
            new MovieModel { Id = 1 , Name = "Test Movie 1" , Cost = 5},
            new MovieModel { Id = 2 , Name = "Test Movie 2" , Cost = 9}
        };
        public DataRepository()
        {
        }

        public MovieModel AddMovie(MovieModel movie)
        {
            _movie.Add(movie);
            return movie;
        }

        public List<MovieModel> GetMovies()
        {
            return _movie;
        }
    }
}

