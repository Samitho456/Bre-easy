namespace Bre_easy
{
    public class DBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Hent connection string fra config (ENV eller appsettings)
            var connectionString = _configuration.GetConnectionString("Default") 
                                   ?? Environment.GetEnvironmentVariable("CONNECTION_STRING");

            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Window> Windows { get; set; }
        public DbSet<Location> Location { get; set; }
    }
}

