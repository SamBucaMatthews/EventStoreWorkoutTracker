namespace Events
{
    using System;

    public record WorkoutRemoved(
            Guid WorkoutId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
