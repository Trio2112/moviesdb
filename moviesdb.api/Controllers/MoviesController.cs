using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesdb.api.Entities;
using moviesdb.api.Repositories.Interfaces;
using moviesdb.models.transport;
using moviesdb.models;

namespace moviesdb.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MoviesController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _movieRepository.GetAllAsync();
            var movies = _mapper.Map<IEnumerable<Movie>>(entities);
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var entity = await _movieRepository.GetByIdAsync(id);
            if (entity == null)
                return Ok(null);

            var movie = _mapper.Map<Movie>(entity);
            return Ok(movie);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovie createMovie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var movieEntity = _mapper.Map<MovieEntity>(createMovie);

            await _movieRepository.AddAsync(movieEntity);
            await _movieRepository.SaveChangesAsync();

            var movieModel = _mapper.Map<Movie>(movieEntity);
            return CreatedAtAction(nameof(GetById), new { id = movieEntity.Id }, movieModel);
        }
    }
}
