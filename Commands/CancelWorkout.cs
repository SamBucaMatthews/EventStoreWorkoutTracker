namespace Commands
{
    using System;

    public record CancelWorkout(
            Guid UserId,
            Guid WorkoutId)
        : Command(UserId);
}
