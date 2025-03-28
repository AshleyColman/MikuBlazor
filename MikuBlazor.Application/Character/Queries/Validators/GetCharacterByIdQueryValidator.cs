using FluentValidation;
using MikuBlazor.Domain.Validation;

namespace MikuBlazor.Application.Character.Queries.Validators;

public class GetCharacterByIdQueryValidator : AbstractValidator<GetCharacterByIdQuery>
{
    public GetCharacterByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(x => MessageCodes.NotEmpty(nameof(x.Id)));
    }
}