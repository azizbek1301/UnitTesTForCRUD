using Car.Api.Entities;
using Car.Api.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Car.Api.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _context;

        public CarRepository(AppDbContext context)
        {
            _context = context;
        }

        public async ValueTask<Mashina> InsertAsync(Mashina cars)
        {
            var storageProduct = await _context.Cars.FirstOrDefaultAsync(x => x.Id == cars.Id);

            if (storageProduct != null)
                throw new DublicateKeyException();

            var entry = await _context.Cars.AddAsync(cars);
            await _context.SaveChangesAsync();

            return entry.Entity;

        }

        public async ValueTask<Mashina> RefresheAsync(Mashina cars)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<bool> RemoveAsync(int id)
        {
            var storageCar = await _context.Cars.FirstOrDefaultAsync(x => x.Id == id);

            if (storageCar == null)
                throw new NotFoundCarException();

            var entry = _context.Cars.Remove(storageCar);
            await _context.SaveChangesAsync();

            return true;
        }

        public async ValueTask<List<Mashina>> SelectCarsAsync()
        {
            var result= await _context.Cars.ToListAsync();
            return result;
        }
    }
}
