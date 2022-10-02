namespace Events
{
    using System;

    public record WorkoutMarkedAsNotComplete(
            Guid WorkoutId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}