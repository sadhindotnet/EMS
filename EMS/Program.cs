using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using BaseClass_dll.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUser, UserRepo>();
builder.Services.AddScoped<IAcademyClass, AcademyClassRepo>();
builder.Services.AddScoped<IAdmitCard, AdmitCardRepo>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
//app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); 
app.UseAuthentication(); 
app.UseAuthorization();  

app.MapControllers();

app.Run();
