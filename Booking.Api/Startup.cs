using Booking.Api;
using Booking.Api.services;
using Booking.Api.services.Abstraction;

public class Startup
{
    public IConfiguration configRoot
    {
        get;
    }
    public Startup(IConfiguration configuration)
    {
        configRoot = configuration;
    }
    public void ConfigureServices(IServiceCollection services)
    {
      // this method create dependencies injection container which we can add our services.
        services.AddRazorPages();
        services.AddSingleton<DataSource>();
        services.AddSingleton<MyFirstService>();
        // inject the above in the controller

        // service life time
        services.AddSingleton<ISingletonOperation,SingletonOperation >();
        services.AddTransient<ITransientOperation, TransientOperation>();
        services.AddScoped<IScopedOperation, ScopedOperation>();

    }
    

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.MapRazorPages();
        app.Run();
    }
}