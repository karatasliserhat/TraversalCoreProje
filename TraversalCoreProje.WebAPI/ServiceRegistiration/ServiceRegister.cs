using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Reflection;
using System.Text;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.BusinessLayer.Interfaces.IUserServices;
using TraversalCoreProje.BusinessLayer.Mappings;
using TraversalCoreProje.BusinessLayer.Services;
using TraversalCoreProje.BusinessLayer.Tools;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversalCoreProje.ValidationLayer.Validations;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.EfCore.Repositories;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.DataAccessLayer.Repository;
using TraversolCoreProje.DataAccessLayer.UnitOfWorks;

namespace TraversalCoreProje.WebAPI.ServiceRegistiration
{
    public static class ServiceRegister
    {
        public static void AddService(this IServiceCollection Services, IConfiguration configuration)
        {

            Services.AddControllers();

            Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
            }
            ).AddIdentity<AppUser, AppRole>()
            .AddErrorDescriber<CustomIdentityErrorDescriber>()
            .AddEntityFrameworkStores<AppDbContext>();


            var scope = Services.BuildServiceProvider();

            var jwtModel = scope.GetRequiredService<IOptions<JwtTokenModel>>().Value;

            Services.Configure<JwtTokenModel>(configuration.GetSection(nameof(JwtTokenModel)));

            Services.AddScoped<IJwtTokenModel>(sp =>
            {
                return sp.GetRequiredService<IOptions<JwtTokenModel>>().Value;
            });

            Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opts =>
            {

                opts.RequireHttpsMetadata = false;
                opts.TokenValidationParameters = new TokenValidationParameters
                {

                    ValidAudience = jwtModel.Audience,
                    ValidIssuer = jwtModel.Issuer,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtModel.Key)),
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidateLifetime = true
                };
            });



            Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

            Services.AddScoped<IUserService, UserService>();
            Services.AddScoped<IAccountService, AccountService>();

            Services.AddFluentValidationAutoValidation();
            Services.AddFluentValidationClientsideAdapters();
            Services.AddValidatorsFromAssemblyContaining<UpdateAboutValidator>();

            Services.AddAutoMapper(Assembly.GetAssembly(typeof(Mapping)));

            Services.AddScoped(typeof(IGenericCommandRepository<>), typeof(GenericCommandRepository<>));
            Services.AddScoped(typeof(IGenericReadRepository<>), typeof(GenericReadRepository<>));

            Services.AddScoped<IReservationReadRepository, ReservationReadRepository>();

            Services.AddScoped<ICommentReadRepository, CommentReadRepository>();

            Services.AddScoped<IUnitOfWork, UnitOfWork>();

            Services.AddScoped(typeof(IGenericCommandService<,,>), typeof(GenericCommandService<,,>));
            Services.AddScoped(typeof(IGenericReadService<,>), typeof(GenericReadService<,>));


            Services.AddScoped<IAboutCommandService, AboutCommandService>();
            Services.AddScoped<IAboutReadService, AboutReadService>();

            Services.AddScoped<IAbout2ReadService, About2ReadService>();
            Services.AddScoped<IAbout2CommandService, About2CommandService>();

            Services.AddScoped<IContactCommandService, ContactCommandService>();
            Services.AddScoped<IContactReadService, ContactReadService>();

            Services.AddScoped<IDestinationCommandService, DestinationCommandService>();
            Services.AddScoped<IDestinationReadService, DestinationReadService>();

            Services.AddScoped<IFeature2CommandService, Feature2CommandService>();
            Services.AddScoped<IFeature2ReadService, Feature2ReadService>();

            Services.AddScoped<IFeatureCommandService, FeatureCommandService>();
            Services.AddScoped<IFeatureReadService, FeatureReadService>();

            Services.AddScoped<IGuideCommandService, GuideCommandService>();
            Services.AddScoped<IGuideReadService, GuideReadService>();

            Services.AddScoped<INewsLetterCommandService, NewsLetterCommandService>();
            Services.AddScoped<INewsLetterReadService, NewsLetterReadService>();

            Services.AddScoped<ISubAboutCommandService, SubAboutCommandService>();
            Services.AddScoped<ISubAboutReadService, SubAboutReadService>();

            Services.AddScoped<ITestimonialCommandService, TestimonialCommandService>();
            Services.AddScoped<ITestimonialReadService, TestimonialReadService>();


            Services.AddScoped<IReservationCommandService, ReservationCommandService>();
            Services.AddScoped<IReservationReadService, ReservationReadService>();

            Services.AddScoped<IStatisticsService, StatisticsService>();
            Services.AddScoped<IStatisticsRepository, StatisticsRepository>();

            Services.AddScoped<ICommentCommandService, CommentCommandService>();
            Services.AddScoped<ICommentReadService, CommentReadService>();
        }
    }
}
