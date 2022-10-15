namespace Events
{
    using System;

    public record ExerciseRemoved(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
