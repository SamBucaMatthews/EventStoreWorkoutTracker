namespace Commands
{
    using System;

    public record RecordReps(
            Guid UserId,
            Guid WorkoutId,
            Guid ExerciseId,
            Guid SetId,
            int Reps)
        : Command(UserId);
}
