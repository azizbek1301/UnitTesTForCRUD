using Car.Api.Entities;
using Car.Api.Exceptions;
using Car.Api.Repositories;

namespace Car.Api.Services
{
    public class CarServices : ICarServices
    {
        private readonly ICarRepository _carRepository;

        public CarServices(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async ValueTask<Mashina> AddAsync(Mashina cars)
        {
            if (cars == null)
            {
                throw new InputNullExceptions();
            }
            var newproduct = await _carRepository.InsertAsync(cars);

            return newproduct;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
           var result= await _carRepository.RemoveAsync(id);
            return result;
        }

        public async ValueTask<List<Mashina>> GetCarsAsync()
        {
            var result = await _carRepository.SelectCarsAsync();
            return result;
        }

        public ValueTask<Mashina> UpdateAsync(Mashina cars)
        {
            throw new NotImplementedException();
        }
    }
}
