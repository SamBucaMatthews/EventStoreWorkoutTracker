namespace Commands
{
    using System;

    public record RemoveSet(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId)
        : Command(UserId);
}
