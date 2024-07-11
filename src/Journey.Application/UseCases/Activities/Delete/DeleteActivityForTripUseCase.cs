﻿using Journey.Exception.ExceptionsBase;
using Journey.Exception;
using Journey.Infrastructure.Entities;

namespace Journey.Application.UseCases.Activities.Delete
{
    public  class DeleteActivityForTripUseCase
    {
        public void Execute(Guid tripId, Guid activityId)
        {
            var dbContext = new JourneyDbContext();

            var activity = dbContext
                .Activities
                .FirstOrDefault(activity => activity.Id == activityId && activity.TripId == tripId);

            if (activity is null)
                throw new NotFoundException(ResourceErrorMessage.ACTIVITY_NOT_FOUND);

            dbContext.Activities.Remove(activity);
            dbContext.SaveChanges();
        }
    }
}
