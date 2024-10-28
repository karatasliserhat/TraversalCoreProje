using AutoMapper;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.UserDto;

namespace TraversalCoreProje.BusinessLayer.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AppUser, CreateUserDto>().ReverseMap();
            CreateMap<AppUser, UserEditDto>().ReverseMap();
            CreateMap<AppUser, ResultUserDto>().ReverseMap();

            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();

            CreateMap<About2, ResultAbout2Dto>().ReverseMap();
            CreateMap<About2, CreateAbout2Dto>().ReverseMap();
            CreateMap<About2, UpdateAbout2Dto>().ReverseMap();

            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();

            CreateMap<ContactUs, ResultContactUsDto>().ReverseMap();
            CreateMap<ContactUs, CreateContactUsDto>().ReverseMap();
            CreateMap<ContactUs, UpdateContactUsDto>().ReverseMap();

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

            CreateMap<Announcement, ResultAnnouncementDto>().ReverseMap();
            CreateMap<Announcement, CreateAnnouncementDto>().ReverseMap();
            CreateMap<Announcement, UpdateAnnouncementDto>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();

            CreateMap<Comment, ResultCommentDto>()
                .ForMember(x => x
                .DestinationCityName, member => member.MapFrom(x => x
                .Destination.City))
                .ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();


            CreateMap<Reservation, ResultReservationDto>()
                .ForMember(x => x
                .DestinationCityName, member => member.MapFrom(x => x
                .Destination.City))
                .ForMember(x =>
                x.PersonName, member => member.MapFrom(x => x
                .AppUser.Name))
                .ForMember(x =>
                x.PersonSurname, member => member.MapFrom(x => x
                .AppUser.Surname))
                .ReverseMap();
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDto>().ReverseMap();

            CreateMap<Visitor, ResultVisitorDto>().ReverseMap();
            CreateMap<Visitor, CreateVisitorDto>().ReverseMap();
            CreateMap<Visitor, UpdateVisitorDto>().ReverseMap();
        }
    }
}
