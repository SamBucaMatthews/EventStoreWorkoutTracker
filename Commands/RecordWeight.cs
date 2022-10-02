namespace Commands
{
    using System;

    public record RecordWeight(
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            int WeightInKg)
        : Command;
}
