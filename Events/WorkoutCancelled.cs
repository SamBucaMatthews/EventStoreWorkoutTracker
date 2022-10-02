namespace Events
{
    using System;

    public record WorkoutCancelled(
            Guid WorkoutId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
