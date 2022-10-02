namespace Commands
{
    using System;

    public record RemoveSet(
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId)
        : Command;
}
