using AutoMapper;

namespace MikuBlazor.Application.AutoMapper;

public class AppProfile : Profile
{
    public AppProfile()
    {
        CreateMap<Domain.Anime.Entity.Anime, DTO.Requests.AnimeResponse>();
    }
}