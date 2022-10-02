namespace Commands
{
    using System;

    public record RecordReps(
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            int Reps)
        : Command;
}
