namespace Commands
{
    using System;

    public record AddSet(
            Guid WorkoutId,
            Guid ExerciseId)
        : Command;
}
