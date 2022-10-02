namespace Events
{
    using System;

    public record ExerciseRemoved(
            Guid WorkoutId,
            Guid ExerciseId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
