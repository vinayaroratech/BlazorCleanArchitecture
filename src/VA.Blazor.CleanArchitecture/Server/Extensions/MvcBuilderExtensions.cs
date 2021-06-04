using VA.Blazor.CleanArchitecture.Application.Configurations;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace VA.Blazor.CleanArchitecture.Server.Extensions
{
    public static class MvcBuilderExtensions
    {
        public static IMvcBuilder AddValidators(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AppConfiguration>());
            return builder;
        }
    }
}