﻿using Microsoft.Extensions.Options;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.Shared.Services;
using TraversalCoreProje.Shared.Services.UserServices;

namespace TraversolCoreProje.WebUI.Extensions
{
    public static class ServiceExtension
    {
        public static void AddService(this IServiceCollection Services, IConfiguration Configuration)
        {
            Services.AddHttpContextAccessor();

            Services.Configure<ApiSetting>(Configuration.GetSection("ApiSetting"));

            Services.AddScoped<IApiSetting>(opt =>
            {
                return opt.GetRequiredService<IOptions<ApiSetting>>().Value;
            });

            var scope = Services.BuildServiceProvider();
            var apiurl = scope.GetRequiredService<IOptions<ApiSetting>>().Value;


            Services.AddScoped<IUserService, UserService>();

            Services.AddScoped(typeof(IBaseApiReadService<>), (typeof(BaseReadApiService<>)));
            Services.AddScoped(typeof(IBaseCommandApiService<,>), (typeof(BaseCommandApiService<,>)));

            Services.AddHttpClient<IDestinationReadApiService, DestinationReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.DestinationControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IDestinationCommandApiService, DestinationCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.DestinationControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IStatisticsApiService, StatisticsApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.StatisticsControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IFeature2ReadApiService, Feature2ReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.Feature2ControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IFeature2CommandApiService, Feature2CommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.Feature2ControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IFeatureReadApiService, FeatureReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.FeatureControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<IFeatureCommandApiService, FeatureCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.FeatureControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IAbout2ApiReadService, About2ReadApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.About2ControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<IAbout2ApiCommandService, About2CommandApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.About2ControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IAboutApiCommandService, AboutCommandApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.AboutControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<IAboutApiReadService, AboutReadApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.AboutControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IContacCommandApiService, ContactCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.ContactControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<IContacReadApiService, ContactReadApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.ContactControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<INewsLetterCommandApiServices, NewsLetterCommandApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.NewsLetterControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<INewsLetterReadApiServices, NewsLetterReadApiServices>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.NewsLetterControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<ITestimonialCommandApiServices, TestimonialCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.TestimonialControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<ITestimonialReadApiServices, TestimonialReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.TestimonialControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<ISubAboutCommandApiServices, SubAboutCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.SubAboutControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<ISubAboutReadApiServices, SubAboutReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.SubAboutControllerBaseUrl.ToString());
            });

            Services.AddHttpClient<IGuideCommandApiService, GuideCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.GuideControllerBaseUrl.ToString());
            });
            Services.AddHttpClient<IGuideReadApiService, GuideReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiurl.GuideControllerBaseUrl.ToString());
            });
        }
    }
}