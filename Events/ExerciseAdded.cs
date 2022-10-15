namespace Events
{
    using System;

    public record ExerciseAdded(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            string ExerciseName,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
