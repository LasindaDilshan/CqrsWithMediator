using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieMnagementLibrary.Models;
using MovieMnagementLibrary.Query;

namespace cqrs.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;


    public WeatherForecastController(ILogger<WeatherForecastController> logger , IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;

    }

  

    [HttpGet]
    public async Task<List<MovieModel>> getmovies()
    {
        return await _mediator.Send(new GetMovieListQuery());
    }

    [HttpGet("{id}")]
    public async Task<MovieModel> getmoviesbyid(int id)
    {
        return await _mediator.Send(new GetMovieByQueryId(id));
    }

    [HttpPost]
    public async Task<MovieModel> Post(MovieModel movies)
    {
        return await _mediator.Send(new AddMovieCommand(movies));
    }

}

