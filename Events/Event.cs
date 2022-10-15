namespace Events
{
    using System;

    public abstract record Event(
        Guid UserId,
        DateTime EventDateTime);
}
