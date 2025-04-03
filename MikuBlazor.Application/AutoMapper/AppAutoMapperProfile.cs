
using MikuBlazor.DTO.Responses.GetAnime;
using MikuBlazor.DTO.Responses.GetProfile;
using AnimeResponse = MikuBlazor.DTO.Responses.GetAnime.AnimeResponse;

namespace MikuBlazor.Application.AutoMapper;

public class AppAutoMapperProfile : global::AutoMapper.Profile
{
    public AppAutoMapperProfile()
    {
        CreateMap<Domain.Anime.Entity.Anime, AnimeResponse>()
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

        CreateMap<Domain.Anime.Entity.AnimeStatus, AnimeStatusResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
        
        CreateMap<Domain.Anime.Entity.AnimeType, AnimeTypeResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
       
        CreateMap<Domain.Anime.Entity.Season, SeasonResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.ViewerRating, ViewerRatingResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Episode, EpisodeResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Title, opt => opt.MapFrom(y => y.Title))
            .ForMember(x => x.Description, opt => opt.MapFrom(y => y.Description))
            .ForMember(x => x.Number, opt => opt.MapFrom(y => y.Number));

        CreateMap<Domain.Anime.Entity.Producer, ProducerResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));
       
        CreateMap<Domain.Anime.Entity.Tag, TagResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Studio, StudioResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Season, SeasonResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.Genre, GenreResponse>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name));

        CreateMap<Domain.Anime.Entity.User, ProfileResponse>()
            .ForMember(x => x.Username, opt => opt.MapFrom(y => y.Username))
            .ForMember(x => x.Forename, opt => opt.MapFrom(y => y.Forename))
            .ForMember(x => x.Surname, opt => opt.MapFrom(y => y.Surname))
            .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(y => y.DateOfBirth))
            .ForMember(x => x.Gender, opt => opt.MapFrom(y => y.Gender.Name))
            .ForMember(x => x.AnimeFavourites, opt => opt.MapFrom(y => y.AnimeFavourites))
            .ForMember(x => x.AnimeRatings, opt => opt.MapFrom(y => y.AnimeRatings));

        CreateMap<Domain.Anime.JoinEntity.UserAnimeRatings, AnimeRatingResponse>()
            .ForMember(x => x.AnimeId, opt => opt.MapFrom(y => y.Anime.Id))
            .ForMember(x => x.ImageUri, opt => opt.MapFrom(y => y.Anime.ImageUri))
            .ForMember(x => x.Rating, opt => opt.MapFrom(y => y.Rating));

        CreateMap<Domain.Anime.JoinEntity.UserAnimeFavourites, AnimeFavouriteResponse>()
            .ForMember(x => x.AnimeId, opt => opt.MapFrom(y => y.Anime.Id))
            .ForMember(x => x.ImageUri, opt => opt.MapFrom(y => y.Anime.ImageUri));
        
        CreateMap<Domain.Anime.JoinEntity.UserCharacterFavourites, DTO.Responses.GetProfile.CharacterFavouriteResponse>()
            .ForMember(x => x.CharacterId, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.FirstName, opt => opt.MapFrom(y => y.Character.FirstName))
            .ForMember(x => x.LastName, opt => opt.MapFrom(y => y.Character.LastName))
            .ForMember(x => x.NickName, opt => opt.MapFrom(y => y.Character.NickName))
            .ForMember(x => x.ImageUri, opt => opt.MapFrom(y => y.Character.ImageUri))
            .ForMember(x => x.ImageUri, opt => opt.MapFrom(y => y.Character.ImageUri));
    }
}