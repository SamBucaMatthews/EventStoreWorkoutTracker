namespace Events
{
    using System;

    public record WorkoutCancelled(
            Guid UserId,
            Guid WorkoutId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
