using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.BusinessLayer.Mappings;
using TraversalCoreProje.BusinessLayer.Services;
using TraversalCoreProje.BusinessLayer.Validations;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
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
            });


            Services.AddFluentValidationAutoValidation();
            Services.AddFluentValidationClientsideAdapters();
            Services.AddValidatorsFromAssemblyContaining<UpdateAboutValidator>();

            Services.AddAutoMapper(Assembly.GetAssembly(typeof(Mapping)));

            Services.AddScoped(typeof(IGenericCommandRepository<>), typeof(GenericCommandRepository<>));
            Services.AddScoped(typeof(IGenericReadRepository<>), typeof(GenericReadRepository<>));

            Services.AddScoped<IAboutCommandRepository, AboutCommandRepository>();
            Services.AddScoped<IAboutReadRepository, AboutReadRepository>();

            Services.AddScoped<IAbout2ReadRepository, About2ReadRepository>();
            Services.AddScoped<IAbout2CommandRepository, About2CommandRepository>();

            Services.AddScoped<IContactCommandRepository, ContactCommandRepository>();
            Services.AddScoped<IContactReadRepository, ContactReadRepository>();

            Services.AddScoped<IDestinationCommandRepository, DestinationCommandRepository>();
            Services.AddScoped<IDestinationReadRepository, DestinationReadRepository>();

            Services.AddScoped<IFeature2CommandRepository, Feature2CommandRepository>();
            Services.AddScoped<IFeature2ReadRepository, Feature2ReadRepository>();

            Services.AddScoped<IFeatureCommandRepository, FeatureCommandRepository>();
            Services.AddScoped<IFeatureReadRepository, FeatureReadRepository>();

            Services.AddScoped<IGuideCommandRepository, GuideCommandRepository>();
            Services.AddScoped<IGuideReadRepository, GuideReadRepository>();

            Services.AddScoped<INewsLetterCommandRepository, NewsLetterCommandRepository>();
            Services.AddScoped<INewsLetterReadRepository, NewsLetterReadRepository>();

            Services.AddScoped<ISubAboutCommandRepository, SubAboutCommandRepository>();
            Services.AddScoped<ISubAboutReadRepository, SubAboutReadRepository>();

            Services.AddScoped<ITestimonialCommandRepository, TestimonialCommandRepository>();
            Services.AddScoped<ITestimonialReadRepository, TestimonialReadRepository>();

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


            Services.AddScoped<IStatisticsRepository, StatisticsRepository>();
            Services.AddScoped<IStatisticsService, StatisticsService>();
        }
    }
}
