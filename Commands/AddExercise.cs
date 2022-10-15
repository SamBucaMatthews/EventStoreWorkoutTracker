namespace Commands
{
    using System;

    public record AddExercise(
            Guid UserId,
            Guid WorkoutId,
            string ExerciseName)
        : Command(UserId);
}
