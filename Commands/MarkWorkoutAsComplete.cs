namespace Commands
{
    using System;

    public record MarkWorkoutAsComplete(
        Guid UserId,
        Guid WorkoutId)
        : Command(UserId);
}
