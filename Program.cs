namespace CRUD_Kart_App;

public class Program
{
    public static void Main(string[] args)
    {
        //==============SERVER SETUP=============//
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddRazorPages();
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseDefaultFiles();
        app.UseStaticFiles();
        
        //app.UseHttpsRedirection(); <-- Gives warning for now. Needed?
        //app.UseRouting(); Dunno?
        //app.UseAuthorization(); Dunno?
        //app.MapRazorPages(); Dunno?
        app.Run();

        //====================END POINTS===================//
        app.MapGet("/health", () => "Server status: OK");

        //When a user inputs a search 
        app.MapGet("/maps/search/", () => "");

        //When a user clicks on a saved pin
        app.MapGet("/pin/", () => "");

        //When a user shows detailed info on pin
        app.MapGet("/pinDetailed/", () => "");

        //When a user creates a new pin
        app.MapPost("/newPin", () => "");

        //When a user deletes an old pin
        app.MapDelete("/deletePin", ()=> "");
    }
}
