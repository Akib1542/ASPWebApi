using Application.Models;
using AutoMapper;
using Domain;

namespace Application.MappingProfiles
{
    public class Mappings : Profile
    {
        #region Methods
        public Mappings()
        {
            CreateMap<NewProperty, Property>();
            CreateMap<Property, PropertyDto>();
            CreateMap<Property, PropertyDummyDTO>();

            CreateMap<NewImage, Image>();
            CreateMap<Image,ImageDTO>();
            CreateMap<Image, ImageDummyDTO>();
          
        }

        #endregion
    }
}
