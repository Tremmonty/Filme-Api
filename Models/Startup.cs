using Filme_Api.Data;
using System.Configuration;

namespace Filme_Api.Models
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => configuration = configuration;

    }

        public Iconfiguration Configuration { get; } 
    
        public void ConfigureService(IServiceCollection services)
        {
        services.AddDbContext<FilmeContext
        services.AddControllers();
        services.AddSwaggerGen(
            }
    
}
