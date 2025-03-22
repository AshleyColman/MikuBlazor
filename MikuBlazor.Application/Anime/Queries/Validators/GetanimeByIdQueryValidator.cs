using FluentValidation;

namespace MikuBlazor.Application.Anime.Queries.Validators;

public class GetAnimeByIdQueryValidator : AbstractValidator<GetAnimeByIdQuery>
{
    public GetAnimeByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();
    }
}