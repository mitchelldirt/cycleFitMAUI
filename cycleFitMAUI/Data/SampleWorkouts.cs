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

    public static void Tabata(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        // Warmup
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 900000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        // Repeats start here
        for (var sets = 0; sets < 3; sets++)
        {
            for (var i = 0; i < 8; i++)
            {
                steps.Add(new WorkoutStep
                {
                    DurationType = WktStepDuration.Time,
                    DurationValue = 20000,
                    Intensity = Intensity.Active,
                    TargetType = WktStepTarget.HeartRate,
                    Zone = hrZones.Zone4
                });
                steps.Add(new WorkoutStep
                {
                    DurationType = WktStepDuration.Time,
                    DurationValue = 10000,
                    Intensity = Intensity.Rest,
                    TargetType = WktStepTarget.HeartRate,
                    Zone = hrZones.Zone2
                });
            }

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 600000,
                Intensity = Intensity.Rest,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone1
            });
        }

        // Cooldown
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 900000,
            Intensity = Intensity.Cooldown,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        WorkoutService.CreateBikeWorkout("tabata", steps);
    }

    public static void PowerPyramid(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        // Warmup
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 600_000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        for (var sets = 0; sets < 3; sets++)
        {
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 60_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone3
            });
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 30_000,
                Intensity = Intensity.Rest,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone1
            });
        }

        WorkoutStep thirtySecondRest = new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 10000,
            Intensity = Intensity.Rest,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        };
        // Repeats start here
        for (var sets = 0; sets < 2; sets++)
        {
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 20000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone5
            });

            steps.Add(thirtySecondRest);

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 120_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone4
            });

            steps.Add(thirtySecondRest);

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 150_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone4
            });

            steps.Add(thirtySecondRest);

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 180_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone4
            });

            steps.Add(thirtySecondRest);

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 180_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone4
            });

            steps.Add(thirtySecondRest);
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 150_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone4
            });

            steps.Add(thirtySecondRest);

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 120_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone5
            });

            steps.Add(thirtySecondRest);
            
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 300_000,
                Intensity = Intensity.Cooldown,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone1
            });
        }

        // Cooldown
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 900_000,
            Intensity = Intensity.Cooldown,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        WorkoutService.CreateBikeWorkout("Power Pyramid", steps);
    }

    public static void EnduranceReps(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        // Warmup
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 1_500_000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 180_000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone3
        });

        // Repeats start here
        for (var sets = 0; sets < 3; sets++)
        {
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 900_000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone4
            });
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 600_000,
                Intensity = Intensity.Rest,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone1
            });
        }

        // Cooldown
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 600_000,
            Intensity = Intensity.Cooldown,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });

        WorkoutService.CreateBikeWorkout("Endurance Reps", steps);
    }

    public static void V02MaxPush(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        // Warmup
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 240000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 180000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 120000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone3
        });

        // Repeats start here
        for (var sets = 0; sets < 3; sets++)
        {
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 30000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone5
            });
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 210000,
                Intensity = Intensity.Rest,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone5
            });

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 180000,
                Intensity = Intensity.Rest,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone1
            });
        }

        // Cooldown
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 600000,
            Intensity = Intensity.Cooldown,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });

        WorkoutService.CreateBikeWorkout("V02MaxPush", steps);
    }

    public static void AnaerobicAttack(HeartRateZones hrZones)
    {
        List<WorkoutStep> steps = new List<WorkoutStep>();

        // Warmup
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 240000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 180000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone2
        });

        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 120000,
            Intensity = Intensity.Warmup,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone3
        });

        // Repeats start here
        for (var sets = 0; sets < 6; sets++)
        {
            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 60000,
                Intensity = Intensity.Active,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone5
            });

            steps.Add(new WorkoutStep
            {
                DurationType = WktStepDuration.Time,
                DurationValue = 120000,
                Intensity = Intensity.Rest,
                TargetType = WktStepTarget.HeartRate,
                Zone = hrZones.Zone1
            });
        }

        // Cooldown
        steps.Add(new WorkoutStep
        {
            DurationType = WktStepDuration.Time,
            DurationValue = 900000,
            Intensity = Intensity.Cooldown,
            TargetType = WktStepTarget.HeartRate,
            Zone = hrZones.Zone1
        });

        WorkoutService.CreateBikeWorkout("Anaerobic Attack", steps);
    }
}