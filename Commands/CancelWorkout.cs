namespace Commands
{
    using System;

    public record CancelWorkout(Guid WorkoutId)
        : Command;
}
