using Microsoft.Extensions.DependencyInjection;
using TresDias.Services;

namespace TresDias;

public static class DependencyInjection
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<TeamMemberService>();
        services.AddScoped<RoleService>();
        services.AddScoped<SpeechService>();
        services.AddScoped<WeekendService>();

        return services;
    }
}