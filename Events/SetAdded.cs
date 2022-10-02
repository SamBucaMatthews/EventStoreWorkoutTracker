namespace Events
{
    using System;

    public record SetAdded(
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
