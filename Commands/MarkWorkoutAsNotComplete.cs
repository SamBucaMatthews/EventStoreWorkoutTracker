namespace Commands
{
    using System;

    public record MarkWorkoutAsNotComplete(
            Guid UserId,
            Guid WorkoutId)
        : Command(UserId);
}
