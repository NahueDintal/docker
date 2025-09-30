using Microsoft.Extensions.Configuration;

namespace SistemaFact.Clases
{
    public static class cConexion
    {
        private static IConfiguration? _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string GetConexion()
        {
            if (_configuration == null)
                throw new InvalidOperationException("Configuration not initialized. Call Initialize first.");
                
            return _configuration.GetConnectionString("DefaultConnection") 
                   ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }
    }
}
