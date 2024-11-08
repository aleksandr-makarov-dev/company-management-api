namespace CompanyManagement.API.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetConnectionStringOrThrow(this IConfiguration configuration, string key)
        {
            return configuration.GetConnectionString(key) ??
                   throw new ArgumentNullException($"Connection string '{key}' not found");
        }
    }
}
