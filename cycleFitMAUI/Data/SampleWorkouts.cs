using Dynastream.Fit;

namespace cycleFitMAUI.Data;

public class SampleWorkouts
{
    public static void FourEightMinute(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 10000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });
 
        WorkoutService.CreateBikeWorkout("4x8mins", steps);
    }
}