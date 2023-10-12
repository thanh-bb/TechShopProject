using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System.Text;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.API.Repositories;
using TechShop.API.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TechShopDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TechShopConnection")));

builder.Services.AddScoped<ILoaiRepository, LoaiRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ITinhTrangRepository,TinhTrangRepository>(); 

// add token

builder.Services.AddIdentity<KhachHang, Quyen>()
    .AddEntityFrameworkStores<TechShopDbContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JwtIssuer"],
            ValidAudience = builder.Configuration["JwtAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSecurityKey"]))

        };

    }
    );


//
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .SetIsOriginAllowed((host) => true)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


/*app.UseCors(policy =>
    policy.WithOrigins("http://localhost:7103", "https://localhost:7103")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
);
*/

app.UseCors("CorsPolicy");
app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
