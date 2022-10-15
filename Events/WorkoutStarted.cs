namespace Events
{
    using System;

    public record WorkoutStarted(
            Guid UserId,
            Guid WorkoutId,
            DateTime WorkoutStartTime,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
