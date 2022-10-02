namespace Events
{
    using System;

    public record WorkoutMarkedAsComplete(
            Guid WorkoutId,
            DateTime WorkoutFinishTime,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
