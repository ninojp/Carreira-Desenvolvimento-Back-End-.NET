using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<Cinema, ReadCinemaDTO>().ForMember(cinemaDTO => cinemaDTO.Endereco,
            opt => opt.MapFrom(cinema => cinema.Endereco));
        CreateMap<CreateCinemaDTO, Cinema>();
        CreateMap<UpdateCinemaDTO, Cinema>();
    }
}