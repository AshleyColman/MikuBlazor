using AutoMapper;

namespace MikuBlazor.Application.AutoMapper;

public class AppProfile : global::AutoMapper.Profile
{
    public AppProfile()
    {
        CreateMap<Domain.Anime.Entity.Anime, DTO.Requests.AnimeResponse>();
    }
}