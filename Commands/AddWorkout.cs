namespace Commands
{
    using System;

    public record AddWorkout(Guid UserId)
        : Command(UserId);
}
