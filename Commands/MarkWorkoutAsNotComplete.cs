namespace Commands
{
    using System;

    public record MarkWorkoutAsNotComplete(Guid WorkoutId)
        : Command;
}
