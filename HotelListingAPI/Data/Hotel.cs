using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data
{//hotel can have one county but one country can have many hotels
    public class Hotel //This is an entity used to model a table
    {
        //Hotel Table
        public int Id { get; set; } //Creates an auto incrementing Id
        public string Name { get; set; }
        public string Address { get; set; }
        public double  Rating { get; set; }

        [ForeignKey(nameof(CountryId))] //Foregin Key Annotation with a strongly typed specified CountryID
        public int CountryId { get; set; }
        public Country Country { get; set; } // Right click and generate an new type of Country in a new file
    }
}
