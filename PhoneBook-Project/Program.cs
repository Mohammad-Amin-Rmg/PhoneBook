using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Contrasts.People;
using PhoneBook.Domain.Contrasts.Phones;
using PhoneBook.Infrastructures.DataAccess.Common;
using PhoneBook.Infrastructures.DataAccess.Phones;
using PhoneBook.Infrastructures.DataAccess.People;
using PhoneBook.Infrastructures.DataAccess.Tags;
using PhoneBook.Domain.Contrasts.Tags;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IPhoneRepository, PhoneRepository>();
builder.Services.AddScoped<IPersonRespository, PersonRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();


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

app.Run();
