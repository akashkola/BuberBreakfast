using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast Not Found"
        );

        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast Name must be at least {Models.Breakfast.MinNameLength} characters" +
             $" and at most {Models.Breakfast.MaxNameLength} characters long."
        );

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast description must be at least {Models.Breakfast.MinDescriptionLength} characters" +
             $" and at most {Models.Breakfast.MaxDescriptionLength} characters long."
        );
    }
}