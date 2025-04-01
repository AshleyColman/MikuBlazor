
namespace MikuBlazor.Application.AutoMapper;

public class AppAutoMapperProfile : global::AutoMapper.Profile
{
    public AppAutoMapperProfile()
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

        CreateMap<Domain.Anime.Entity.User, DTO.Requests.GetProfile.ProfileResponse>()
            .ForMember(x => x.Username, opt => opt.MapFrom(y => y.Username))
            .ForMember(x => x.Forename, opt => opt.MapFrom(y => y.Forename))
            .ForMember(x => x.Surname, opt => opt.MapFrom(y => y.Surname))
            .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(y => y.DateOfBirth))
            .ForMember(x => x.Gender, opt => opt.MapFrom(y => y.Gender))
            .ForMember(x => x.AnimeFavourites, opt => opt.MapFrom(y => y.AnimeFavourites))
            .ForMember(x => x.AnimeRatings, opt => opt.MapFrom(y => y.AnimeRatings));

        CreateMap<Domain.Anime.JoinEntity.UserCharacterFavourites, DTO.Requests.GetProfile.CharacterFavouriteResponse>()
            .ForMember(x => x.CharacterId, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Character, opt => opt.MapFrom(y => y.Character));

        CreateMap<Domain.Anime.JoinEntity.UserAnimeFavourites, DTO.Requests.GetProfile.AnimeFavouriteResponse>()
            .ForMember(x => x.AnimeId, opt => opt.MapFrom(y => y.AnimeId))
            .ForMember(x => x.Anime, opt => opt.MapFrom(y => y.Anime));

        CreateMap<Domain.Anime.JoinEntity.UserAnimeRatings, DTO.Requests.GetProfile.AnimeRatingResponse>()
            .ForMember(x => x.Anime, opt => opt.MapFrom(y => y.Anime))
            .ForMember(x => x.AnimeId, opt => opt.MapFrom(y => y.AnimeId))
            .ForMember(x => x.Rating, opt => opt.MapFrom(y => y.Rating));
    }
}