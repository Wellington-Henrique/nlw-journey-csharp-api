using Journey.Exception.ExceptionsBase;
using Journey.Exception;
using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Application.UseCases.Trips.Delete
{
    public class DeleteUseCase
    {
        public void Execute(Guid id)
        {
            var dbContext = new JourneyDbContext();

            var trip = dbContext
                        .Trips
                        .Include(trip => trip.Activities)
                        .FirstOrDefault(trip => trip.Id == id);

            if (trip is null)
                throw new NotFoundException(ResourceErrorMessage.TRIP_NOT_FOUND);

            dbContext.Trips.Remove(trip);
            dbContext.SaveChanges();
        }
    }
}
