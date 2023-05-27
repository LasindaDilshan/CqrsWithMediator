using System;
using MediatR;
using MovieMnagementLibrary.Models;
using MovieMnagementLibrary.Query;

namespace MovieMnagementLibrary.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByQueryId, MovieModel>
    {
        private readonly IMediator _mediator;

        public GetMovieByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

     

        public async Task<MovieModel> Handle(GetMovieByQueryId request, CancellationToken cancellationToken)
        {
            var movies = await _mediator.Send(new GetMovieListQuery());
            var movie = movies.FirstOrDefault(u => u.Id == request.id);
            return movie;
        }
    }
}

