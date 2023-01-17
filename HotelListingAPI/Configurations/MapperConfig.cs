using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;
using HotelListingAPI.Models.Country.Hotels;

namespace HotelListingAPI.Configurations
{
    //This class is ment to create a map between two objects to avoid writing extra code
    //we created a Configurations folder then a MapperConfig class using Automapper Library
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            //Creates a link between two object, country and CreateCountryDTo . reversemap means two way binding
            //Then register this configuration inside of program.cs
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDetailDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
                
        }
    }
}
