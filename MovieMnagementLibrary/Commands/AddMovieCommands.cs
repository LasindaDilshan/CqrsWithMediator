using System;
using MediatR;
using MovieMnagementLibrary.Models;

namespace MovieMnagementLibrary.Commands
{
    public record AddMovieCommands( MovieModel movieModel) : IRequest<MovieModel>
    {
        
    }
}

