using System;
using MediatR;
using MovieMnagementLibrary.Data;
using MovieMnagementLibrary.Models;
using MovieMnagementLibrary.Query;

namespace MovieMnagementLibrary.Handlers
{
    public class MovieHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepository _dataRepository;
        public MovieHandler( IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetMovies());
        }
    }
}

