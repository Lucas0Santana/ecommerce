using System.Reflection;
using ecommerce.Data;
using ecommerce.Repository.IRepository;
using ecommerce.Repository.Repository.ModelsRepository;
using ecommerce.Services;
using ecommerce.Services.IServices;
using ecommerce.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
                    .AddJsonOptions(options =>
                        options.JsonSerializerOptions
                            .ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        // c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
        // {
        //     Name = "Authorization",
        //     Type = SecuritySchemeType.ApiKey,
        //     Scheme = "Bearer",
        //     BearerFormat = "JWT",
        //     In = ParameterLocation.Header,
        //     Description = "Header de autorização JWT usando esquema Bearer. \r\n\r\n Informe 'Bearer' [espaço] e o seu token. \r\n\r\n Exemplo \'Bearer 12345678 \'",

        // });

        // c.AddSecurityRequirement(new OpenApiSecurityRequirement{
        // {
        //     new OpenApiSecurityScheme{
        //         Reference = new OpenApiReference{
        //             Type = ReferenceType.SecurityScheme,
        //             Id = "Bearer"
        //         }
        //     },
        //     new string[] {}
        // }});

        c.MapType<DateOnly>(() => new OpenApiSchema
        {
            Type = "string",
            Format = "date",
            Example = new OpenApiString("2022-01-01")
        });

        // var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        // var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        // c.IncludeXmlComments(xmlPath);
    });

// IdentityDbContext
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<Context>()
                        .AddDefaultTokenProviders();

// builder.Services.AddAuthentication(x =>
// {
//     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
// })
//     .AddJwtBearer(x =>
//     {
//         x.RequireHttpsMetadata = false;
//         x.SaveToken = true;
//         x.TokenValidationParameters = new TokenValidationParameters
//         {

//             ValidateIssuerSigningKey = true,
//             IssuerSigningKey = new SymmetricSecurityKey(key),
//             ValidateIssuer = false,
//             ValidateAudience = false

//         };
//     });

// DbContext
builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICredenciaisServices, CredenciaisServices>();
builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddScoped<IEnderecoServices, EnderecoServices>();
builder.Services.AddScoped<IAdministradorServices, AdministradorServices>();
builder.Services.AddScoped<IProdutoServices, ProdutoServices>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();

});

app.UseHttpsRedirection();

app.MapControllers();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(@"C:/UFS/ecommerce/Images/"),
    RequestPath = "/images"
});

await app.RunAsync();