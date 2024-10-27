namespace Bookify.Application.Abstractions.Behaviors;

public record class ValidationError(string PropertyName, string ErrorMessage);
