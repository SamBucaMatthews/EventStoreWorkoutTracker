namespace Events
{
    using System;

    public record SetRemoved(
            Guid WorkoutId,
            Guid SetId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
