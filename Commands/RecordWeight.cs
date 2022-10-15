namespace Commands
{
    using System;

    public record RecordWeight(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            int WeightInKg)
        : Command(UserId);
}
