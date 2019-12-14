using System;

using Microsoft.Extensions.Configuration;

using R5T.Suebia.Extensions;


namespace R5T.Polidea.Suebia
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGitHubAuthenticationConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddJsonSecretsFilePath(configurationServiceProvider, FileNames.GitHubAuthenticationJsonFileName);

            return configurationBuilder;
        }
    }
}
