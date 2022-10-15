namespace Events
{
    using System;

    public record SetMarkedAsFailed(
            Guid UserId,
            Guid WorkoutId,
            Guid SetId,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
