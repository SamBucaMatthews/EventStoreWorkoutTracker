namespace Commands
{
    using System;

    public record AddSet(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId)
        : Command(UserId);
}
