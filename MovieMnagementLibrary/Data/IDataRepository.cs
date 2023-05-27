using System;
using MovieMnagementLibrary.Models;

namespace MovieMnagementLibrary.Data
{
    public interface IDataRepository
    {
        List<MovieModel> GetMovies();
        MovieModel AddMovie(MovieModel movie);
    }
}

