namespace Events
{
    using System;

    public record SetRepsChanged(
            Guid WorkoutId,
            Guid SetId,
            int Reps,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
