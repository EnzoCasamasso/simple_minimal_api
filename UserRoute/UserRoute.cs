using Microsoft.AspNetCore.Mvc;
using MinimalApi.Data;
using MinimalApi.UserRoute;

namespace MinimalApi.Routes;

public static class UserRoute
{
    public static void AddUserRoute(this WebApplication app)
    {
        var routes = app.MapGroup("user");
        routes.MapPost("", async ([FromBody] UserPayload payload, DataContext context) =>
        {
            var newUser = new User(payload.Name, payload.Email);
            return newUser;
        });
    }
}
