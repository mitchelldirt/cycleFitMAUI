using Dynastream.Fit;

namespace cycleFitMAUI.Data;

public class SampleWorkouts
{
    // Do not use Intensity.Recovery
    public static void FourEightMinute(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 900000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });
        // Repeats start here
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 480000,
            Intensity = Intensity.Active,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone4
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 240000,
            Intensity = Intensity.Rest,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 480000,
            Intensity = Intensity.Active,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone4
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 240000,
            Intensity = Intensity.Rest,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 480000,
            Intensity = Intensity.Active,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone4
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 240000,
            Intensity = Intensity.Rest,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 480000,
            Intensity = Intensity.Active,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone4
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 240000,
            Intensity = Intensity.Rest,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 900000,
            Intensity = Intensity.Cooldown,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });
 
        WorkoutService.CreateBikeWorkout("4x8mins", steps);
    }
}