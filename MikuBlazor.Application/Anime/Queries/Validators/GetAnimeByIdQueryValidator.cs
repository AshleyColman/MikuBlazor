using FluentValidation;
using MikuBlazor.Domain.Validation;

namespace MikuBlazor.Application.Anime.Queries.Validators;

public class GetAnimeByIdQueryValidator : AbstractValidator<GetAnimeByIdQuery>
{
    public GetAnimeByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(x => MessageCodes.NotEmpty(nameof(x.Id)));
    }
}