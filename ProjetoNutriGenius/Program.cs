using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = "Server=localhost;Port=3306;Database=nutrigenius_db;Uid=root;";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Menu",
    pattern: "Menu",
    defaults: new { controller = "Menu", action = "Index" });

app.MapControllerRoute(
    name: "CadastroReceita",
    pattern: "CadastroReceita",
    defaults: new { controller = "CadastroReceita", action = "Index" });

app.MapControllerRoute(
    name: "Relatorio",
    pattern: "Relatorio",
    defaults: new { controller = "Relatorio", action = "Index" });

app.MapControllerRoute(
    name: "Usuario",
    pattern: "Usuario",
    defaults: new { controller = "Usuario", action = "Index" });

app.MapControllerRoute(
    name: "SobreNos",
    pattern: "SobreNos",
    defaults: new { controller = "SobreNos", action = "Index" });

app.MapControllerRoute(
    name: "ItensCadastrados",
    pattern: "ItensCadastrados",
    defaults: new { controller = "ItensCadastrados", action = "Index" });

app.MapControllerRoute(
    name: "Legislacao",
    pattern: "Legislacao",
    defaults: new { controller = "Legislacao", action = "Index" });

app.MapControllerRoute(
    name: "CadastroMP",
    pattern: "CadastroMP",
    defaults: new { controller = "CadastroMP", action = "Index" });

app.Run();
