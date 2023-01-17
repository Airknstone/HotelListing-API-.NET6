namespace HotelListingAPI.Contracts
{
    //Contracts are used to specify the interface of the type of data you want to extract. DRY Principle
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);

        Task<List<T>> GetAllAsync();

    }
}
