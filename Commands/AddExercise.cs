namespace Commands
{
    using System;

    public record AddExercise(
            Guid WorkoutId,
            string ExerciseName)
        : Command;
}
