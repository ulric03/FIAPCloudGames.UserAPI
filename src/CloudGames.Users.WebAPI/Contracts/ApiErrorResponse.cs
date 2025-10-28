
using CloudGames.Users.Domain.Core;

namespace CloudGames.Users.WebAPI.Contracts;

public class ApiErrorResponse
{
    public ApiErrorResponse(IReadOnlyCollection<Error> errors) 
        => Errors = errors;

    public IReadOnlyCollection<Error> Errors { get; }
}