using elshaday_test_api.Data;
using elshaday_test_api.Data.Map;
using elshaday_test_api.Data.Repository;
using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace elshaday_test_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // builder.Services.AddTransient<TokenService>();
            // Add services to the container.

            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            
            builder.Services.AddCors();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHealthChecks();
            builder.Services.AddMvc()
               .AddNewtonsoftJson(options => {
                   options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });

            builder.Services.AddAutoMapper(
                typeof(NewPersonMap),
                typeof(NewDepartmentMap),
                typeof(NewUserMap),
                typeof(NewDepartmentMap)
            );
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<ITokenService, TokenService>();


            var app = builder.Build();

            app.MapHealthChecks("/healthz");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(x => x
            .AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod());

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}