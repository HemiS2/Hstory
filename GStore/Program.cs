using GStore.Data;
using GStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string conexao = builder.Configuration.GetConnectionString("GStoreCore");
builder.Services.AddDbContext<AppDbContext>(
        Options => Options.UseMySQL(conexao)
);

// Serviço de Identidade do Usuario
builder.Services.AddIdentity<Usuario, IdentityRole>(
    options=> Options.SignIn.RequiredConfirmedEmail = false
)
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
