using TaskTracker.Components;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        InjectServices(builder.Services);
       
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();


        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }

    private static void InjectServices(IServiceCollection theServiceCollection)
    {
        const string LOG_ID = "Program::InjectServices -> ";

        try
        {
            // Add services to the container.
            theServiceCollection.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Add Boostrap container.
            theServiceCollection.AddBlazorBootstrap();
        }
        catch (Exception ex)
        {
            //UI logs should come...
            Console.WriteLine(LOG_ID + ex.Message);
        }
    }


    private static void InjectMiddlewares(WebApplication? theApplicationInstance)
    {
        const string LOG_ID = "Program::InjectMiddlewares -> ";

        try
        {

        }
        catch (Exception ex)
        {
            //UI logs should come...
            Console.WriteLine(LOG_ID + ex.Message);
        }
    }
}