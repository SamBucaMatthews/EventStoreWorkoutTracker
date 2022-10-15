namespace Events
{
    using System;

    public record SetAdded(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
