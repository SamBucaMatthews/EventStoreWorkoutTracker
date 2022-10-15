namespace Events
{
    using System;

    public record SetWeightChanged(
            Guid UserId,
            Guid WorkoutId,
            Guid SetId,
            int Weight,
            DateTime EventDateTime)
        : Event(UserId, EventDateTime);
}
