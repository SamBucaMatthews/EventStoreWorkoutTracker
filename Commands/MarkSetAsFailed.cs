namespace Commands
{
    using System;

    public record MarkSetAsFailed(
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId)
        : Command;
}
