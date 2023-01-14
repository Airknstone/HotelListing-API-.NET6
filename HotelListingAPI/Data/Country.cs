namespace HotelListingAPI.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //Created an association with hotels
        public virtual IList<Hotel> Hotels { get; set; } //hotel can have one county but one country can have many hotels
       
    }
}