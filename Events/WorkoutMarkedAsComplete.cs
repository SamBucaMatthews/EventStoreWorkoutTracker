namespace Events
{
    using System;

    public record WorkoutMarkedAsComplete(
            Guid UserId,
            Guid WorkoutId,
            DateTime WorkoutFinishTime,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
