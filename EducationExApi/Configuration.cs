using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
namespace EducationExApi
{
    public static class Configuration
    {
        public static void AddProfilesCollection(this IServiceCollection services)
        {
            var mapConfig = new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile(new AuthorProfile());
                c.AddProfile(new MaterialProfile());
                c.AddProfile(new MaterialTypeProfile());
                c.AddProfile(new ReviewProfile());
            });
            var mapper = mapConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddScopedConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IMaterialTypeRepository, MaterialTypeRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IMaterialTypeService, MaterialTypeService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IReviewService, ReviewService>();
        }
        public static void AddNewtonsoftJson(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(s => {
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
        }

        public static void AddCorsPolicy(this IServiceCollection service)
        {
            service.AddCors(p => p.AddPolicy("default", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
        }
    }
}
