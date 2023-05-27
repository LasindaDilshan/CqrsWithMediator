using System;
using MediatR;
using MovieMnagementLibrary.Models;

namespace MovieMnagementLibrary.Query
{
    public record GetMovieListQuery : IRequest<List<MovieModel>>
    {
        

    }
}

