using System;
using MediatR;
using MovieMnagementLibrary.Models;

namespace MovieMnagementLibrary.Query
{
    public record GetMovieByQueryId(int id) : IRequest<MovieModel>
    {
        
    }
}

