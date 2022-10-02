namespace Events
{
    using System;

    public record SetMarkedAsFailed(
            Guid WorkoutId,
            Guid SetId,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
