namespace Commands
{
    using System;

    public record RemoveExercise(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId)
        : Command(UserId);
}
