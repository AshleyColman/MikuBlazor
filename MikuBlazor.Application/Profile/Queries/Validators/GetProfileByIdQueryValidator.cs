using FluentValidation;
using MikuBlazor.Domain.Validation;

namespace MikuBlazor.Application.Profile.Queries.Validators;

public sealed class GetProfileByIdQueryValidator : AbstractValidator<GetProfileByIdQuery>
{
    public GetProfileByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(x => MessageCodes.NotEmpty(nameof(x.Id)));
    }
}