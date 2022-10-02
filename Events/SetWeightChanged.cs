namespace Events
{
    using System;

    public record SetWeightChanged(
            Guid WorkoutId,
            Guid SetId,
            int Weight,
            DateTime EventDateTime)
        : Event(EventDateTime);
}
