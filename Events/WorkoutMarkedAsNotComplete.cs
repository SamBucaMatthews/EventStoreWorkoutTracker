namespace Events
{
    using System;

    public record WorkoutMarkedAsNotComplete(
            Guid UserId,
            Guid WorkoutId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}