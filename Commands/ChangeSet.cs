namespace Commands
{
    using System;

    public record ChangeSet(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            int? WeightInKg,
            int? Reps)
        : Command(UserId);
}
