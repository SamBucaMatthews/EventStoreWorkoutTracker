namespace Events
{
    using System;

    public record SetRepsChanged(
            Guid UserId,
            Guid WorkoutId,
            Guid SetId,
            int Reps,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
