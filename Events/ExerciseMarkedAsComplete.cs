namespace Events
{
    using System;

    public record ExerciseMarkedAsComplete(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
