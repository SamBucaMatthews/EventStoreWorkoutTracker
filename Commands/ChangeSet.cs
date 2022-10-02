namespace Commands
{
    using System;

    public record ChangeSet(
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            int? WeightInKg,
            int? Reps)
        : Command;
}
