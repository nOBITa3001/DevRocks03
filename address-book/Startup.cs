namespace AddressBook
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Services;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IContactRepository, InMemoryContactRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            // Set default file - index.html
            // app.UseDefaultFiles();
            // app.UseStaticFiles();

            // There is another middleware does both of above.
            // app.UseFileServer();

            app.UseMvcWithDefaultRoute();
            // app.UseMvc
            // (
            //     route => route.MapRoute
            //     (
            //         name: "default"
            //         , template: "{controller=Home}/{action=Index}/{id?}"
            //     )
            // );
        }
    }
}   