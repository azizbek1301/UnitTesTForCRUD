using Car.Api.Entities;

namespace Car.Api.Services
{
    public interface ICarServices
    {
        public ValueTask<Mashina> AddAsync(Mashina cars);
        public ValueTask<Mashina> UpdateAsync(Mashina cars);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<List<Mashina>> GetCarsAsync();
    }
}
