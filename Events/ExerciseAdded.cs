namespace Events
{
    using System;

    public record ExerciseAdded(
            Guid WorkoutId,
            Guid ExerciseId,
            string ExerciseName,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
