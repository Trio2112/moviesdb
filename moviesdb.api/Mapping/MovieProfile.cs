using AutoMapper;
using moviesdb.models.transport;
using moviesdb.api.Entities;
using moviesdb.models;

namespace moviesdb.api.Mapping
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovie, MovieEntity>();
            CreateMap<MovieEntity, Movie>();
        }
    }
}
