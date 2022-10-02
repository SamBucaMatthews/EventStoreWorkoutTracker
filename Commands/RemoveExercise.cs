namespace Commands
{
    using System;

    public record RemoveExercise(
            Guid WorkoutId,
            Guid ExerciseId)
        : Command;
}
