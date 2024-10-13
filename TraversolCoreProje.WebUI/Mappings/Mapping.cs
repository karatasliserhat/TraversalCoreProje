using AutoMapper;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Mappings
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<UpdateDestinationViewModel, CreateDestinationViewModel>().ReverseMap();
        }
    }
}
