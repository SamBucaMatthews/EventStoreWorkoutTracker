namespace Commands
{
    using System;

    public record MarkWorkoutAsComplete(Guid WorkoutId) : Command;
}
