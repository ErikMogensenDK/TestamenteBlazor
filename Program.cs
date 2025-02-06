using Microsoft.FluentUI.AspNetCore.Components;
using FluentTestamente.Components;
using FluentTestamente.Services;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        // Add services to the container.
        services.AddRazorComponents()
            .AddInteractiveServerComponents();
        services.AddFluentUIComponents();
        services.AddHttpClient("TestamenteApiClient");
        builder.Services.AddTransient<TestamenteApiClient>(provider =>
        {
            var httpClientFactory = provider.GetService<IHttpClientFactory>();
            var httpClient = httpClientFactory.CreateClient("TestamenteApi");
            var baseUrl = "http://localhost:5201"; 

            return new TestamenteApiClient(baseUrl, httpClient);
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseAntiforgery();

        //app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}