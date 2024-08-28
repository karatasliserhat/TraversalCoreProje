﻿using AutoMapper;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Mappings
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();

            CreateMap<About2, ResultAbout2Dto>().ReverseMap();
            CreateMap<About2, CreateAbout2Dto>().ReverseMap();
            CreateMap<About2, UpdateAbout2Dto>().ReverseMap();

            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();

            CreateMap<Destination, ResultDestinationDto>().ReverseMap();
            CreateMap<Destination, CreateDestinationDto>().ReverseMap();
            CreateMap<Destination, UpdateDestinationDto>().ReverseMap();

            CreateMap<Feature2, ResultFeature2Dto>().ReverseMap();
            CreateMap<Feature2, CreateFeature2Dto>().ReverseMap();
            CreateMap<Feature2, UpdateFeature2Dto>().ReverseMap();

            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();

            CreateMap<Guide, ResultGuideDto>().ReverseMap();
            CreateMap<Guide, CreateGuideDto>().ReverseMap();
            CreateMap<Guide, UpdateGuideDto>().ReverseMap();

            CreateMap<NewsLetter, ResultNewsLetterDto>().ReverseMap();
            CreateMap<NewsLetter, CreateNewsLetterDto>().ReverseMap();
            CreateMap<NewsLetter, UpdateNewsLetterDto>().ReverseMap();

            CreateMap<SubAbout, ResultSubAboutDto>().ReverseMap();
            CreateMap<SubAbout, CreateSubAboutDto>().ReverseMap();
            CreateMap<SubAbout, UpdateSubAboutDto>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
