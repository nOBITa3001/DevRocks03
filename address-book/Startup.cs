namespace AddressBook
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            // Set default file - index.html
            // app.UseDefaultFiles();
            // app.UseStaticFiles();

            // There is another middleware does both of above.
            // app.UseFileServer();
        }
    }
}   