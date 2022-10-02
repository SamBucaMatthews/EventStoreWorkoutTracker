namespace Events
{
    using System;

    public record WorkoutStarted(
            Guid WorkoutId,
            DateTime WorkoutStartTime,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
