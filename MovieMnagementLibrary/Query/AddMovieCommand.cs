using System;
using MediatR;
using MovieMnagementLibrary.Models;

namespace MovieMnagementLibrary.Query
{
    public record AddMovieCommand(MovieModel model) : IRequest<MovieModel>
    {
      

       
    }
}

