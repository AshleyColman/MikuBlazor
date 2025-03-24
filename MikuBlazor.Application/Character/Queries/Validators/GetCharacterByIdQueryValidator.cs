using FluentValidation;

namespace MikuBlazor.Application.Character.Queries.Validators;

public class GetCharacterByIdQueryValidator : AbstractValidator<GetCharacterByIdQuery>
{
    public GetCharacterByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();
    }
}