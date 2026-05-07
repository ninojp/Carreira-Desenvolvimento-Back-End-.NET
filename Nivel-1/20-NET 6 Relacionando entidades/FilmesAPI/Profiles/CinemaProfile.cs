using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDTO, Cinema>();
        CreateMap<Cinema, ReadCinemaDTO>()
            .ForMember(cinemaDTO => cinemaDTO.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(cinemaDTO => cinemaDTO.Sessoes, opt => opt.MapFrom(cinema => cinema.Sessoes));
        CreateMap<UpdateCinemaDTO, Cinema>();
    }
}