using System;
using MediatR;
using MovieMnagementLibrary.Data;
using MovieMnagementLibrary.Models;
using MovieMnagementLibrary.Query;

namespace MovieMnagementLibrary.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand , MovieModel>
    {       
        private readonly IDataRepository _dataRepository;
        public AddMovieHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<MovieModel> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddMovie(request.model));
        }
    }
}

