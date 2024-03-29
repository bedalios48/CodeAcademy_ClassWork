using App1121.Data;
using App1121.Interfaces;
using App1121.Repositories;
using App1121.Repositories.Interfaces;
using App1121.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IBookWrapper, BookWrapper>();
builder.Services.AddTransient<IUserWrapper, UserWrapper>();
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IBookReturnService, BookReturnService>();
builder.Services.AddTransient<IBookBorrowService, BookBorrowService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBookBorrowRepository, BookBorrowRepository>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddDbContext<ClassContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection"))
    );
builder.Services.AddHttpClient("OpenRoute", client => {
    client.BaseAddress = new Uri(builder.Configuration["ExternalServices:OpenRouteUri"]);
    client.Timeout = TimeSpan.FromSeconds(10);
    client.DefaultRequestHeaders.Clear();
});
builder.Services.AddTransient<IOpenRouteProxyService, OpenRouteProxyService>();

var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    option.IncludeXmlComments(xmlPath);

    // This is added to show JWT UI part in Swagger
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Description =
            "JWT Authorization header is using Bearer scheme. \r\n\r\n" +
            "Enter 'Bearer' and token separated by a space. \r\n\r\n" +
            "Example: \"Bearer d5f41g85d1f52a\"",
        Name = "Authorization", // Header key name
        In = ParameterLocation.Header,
        Scheme = "Bearer",
        BearerFormat = "JWT"
    });

    option.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // Order matters
app.UseAuthorization();

app.MapControllers();

app.Run();
