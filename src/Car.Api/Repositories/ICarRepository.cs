using Car.Api.Entities;

namespace Car.Api.Repositories
{
    public interface ICarRepository
    {
        public ValueTask<Mashina> InsertAsync(Mashina cars);
        public ValueTask<Mashina> RefresheAsync(Mashina cars);
        public ValueTask<bool> RemoveAsync(int id);
        public ValueTask<List<Mashina>> SelectCarsAsync();
    }
}
