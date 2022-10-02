namespace Events
{
    using System;

    public record ExerciseMarkedAsComplete(
            Guid WorkoutId,
            Guid ExerciseId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
