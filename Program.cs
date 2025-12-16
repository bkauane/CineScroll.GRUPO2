Program.cs

var builder = WebApplication.CreateBuilder(args);
using CS.grupo2.Servicos;

builder.Services.AddRazorPages();
builder.Services.AddSingleton<ServicosFilmes>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
