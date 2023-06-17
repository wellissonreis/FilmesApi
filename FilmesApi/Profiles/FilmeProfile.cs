using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreatedFilmesDtos, Filme>();
        CreateMap<UpdateFilmeDtos, Filme>();
        CreateMap<Filme, UpdateFilmeDtos>();
        CreateMap<Filme, ReadFilmesDtos>();
    }
}
