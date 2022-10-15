namespace Events
{
    using System;

    public record SetRemoved(
            Guid UserId,
            Guid WorkoutId,
            Guid SetId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
