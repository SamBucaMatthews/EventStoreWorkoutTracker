namespace Commands
{
    using System;

    public record MarkSetAsFailed(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId)
        : Command(UserId);
}
