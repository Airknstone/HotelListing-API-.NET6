using HotelListingAPI.Models.Country.Hotels;

namespace HotelListingAPI.Models.Country
{
    public class CountryDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ShortName { get; set; }

        //Gets list of hotels
        public List<HotelDto> Hotels { get; set; }
    }
}
