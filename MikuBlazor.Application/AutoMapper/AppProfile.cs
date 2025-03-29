
namespace MikuBlazor.Application.AutoMapper;

public class AppProfile : global::AutoMapper.Profile
{
    public AppProfile()
    {
        CreateMap<Domain.Anime.Entity.Anime, DTO.Requests.GetAnime.AnimeResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.JapaneseTitle, opt => opt.MapFrom(y => y.JapaneseTitle))
            .ForMember(x => x.Rating, opt => opt.MapFrom(y => y.Rating))
            .ForMember(x => x.Rank, opt => opt.MapFrom(y => y.Rank))
            .ForMember(x => x.Status, opt => opt.MapFrom(y => y.Status))
            .ForMember(x => x.Type, opt => opt.MapFrom(y => y.Type))
            .ForMember(x => x.StartDate, opt => opt.MapFrom(y => y.StartDate))
            .ForMember(x => x.EndDate, opt => opt.MapFrom(y => y.EndDate))
            .ForMember(x => x.Season, opt => opt.MapFrom(y => y.Season))
            .ForMember(x => x.ViewerRating, opt => opt.MapFrom(y => y.ViewerRating))
            .ForMember(x => x.Episodes, opt => opt.MapFrom(y => y.Episodes))
            .ForMember(x => x.Producers, opt => opt.MapFrom(y => y.Producers))
            .ForMember(x => x.Tags, opt => opt.MapFrom(y => y.Tags))
            .ForMember(x => x.Studio, opt => opt.MapFrom(y => y.Studios))
            .ForMember(x => x.Season, opt => opt.MapFrom(y => y.Season))
            .ForMember(x => x.Genres, opt => opt.MapFrom(y => y.Genres));

        CreateMap<Domain.Anime.Entity.AnimeStatus, DTO.Requests.GetAnime.AnimeStatusResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
        
        CreateMap<Domain.Anime.Entity.AnimeType, DTO.Requests.GetAnime.AnimeTypeResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
       
        CreateMap<Domain.Anime.Entity.Season, DTO.Requests.GetAnime.SeasonResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.ViewerRating, DTO.Requests.GetAnime.ViewerRatingResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Episode, DTO.Requests.GetAnime.EpisodeResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Title, opt => opt.MapFrom(y => y.Title))
            .ForMember(x => x.Description, opt => opt.MapFrom(y => y.Description))
            .ForMember(x => x.Number, opt => opt.MapFrom(y => y.Number));

        CreateMap<Domain.Anime.Entity.Producer, DTO.Requests.GetAnime.ProducerResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
       
        CreateMap<Domain.Anime.Entity.Tag, DTO.Requests.GetAnime.TagResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Studio, DTO.Requests.GetAnime.StudioResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Season, DTO.Requests.GetAnime.SeasonResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Genre, DTO.Requests.GetAnime.GenreResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
    }
}