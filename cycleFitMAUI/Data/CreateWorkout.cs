////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2020 Garmin International, Inc.
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using Dynastream.Fit;
using System.Text.Json;

namespace cycleFitMAUI.Data
{
    public class WorkoutService
    {
        public void Main()
        {
            CreateBikeTempoWorkout();
        }

/*
 * CREATE BIKE WORKOUT (this should be more flexible)
 * Heart Rate Zones (provide a default in case of failure that just uses 190 as the max HR... hard code this)
 * Title
 * Workout Steps... Provide an array of WorkoutStepMesg objects
 * {
 *  durationType,
 *  durationValue,
 *  targetType,
 *  targetLow,
 *  targetHigh
 *  intensity
 * }
 *
 * 1. create the workoutSteps List
 * 2. Add each workout step message to the workout steps
 * 3. make new workout message
 * 4. set the other pieces of information
 * 5. run CreateWorkout
 */
        public static void CreateBikeWorkout(string title, List<WorkoutStep> steps)
        {
            var workoutSteps = new List<WorkoutStepMesg>();

            foreach (var step in steps)
            {
                workoutSteps.Add(CreateWorkoutStep(
                    messageIndex: workoutSteps.Count,
                    durationType: step.DurationType,
                    durationValue: step.DurationValue,
                    targetType: step.TargetType,
                    customTargetValueLow: Convert.ToUInt32(Math.Ceiling(step.Zone.Low)),
                    customTargetValueHigh: Convert.ToUInt32(Math.Ceiling(step.Zone.High)),
                    intensity: step.Intensity
                ));
            }

            var workoutMesg = new WorkoutMesg();
            workoutMesg.SetWktName(title);
            workoutMesg.SetSport(Sport.Cycling);
            workoutMesg.SetSubSport(SubSport.Invalid);
            workoutMesg.SetNumValidSteps((ushort)workoutSteps.Count);

            CreateWorkout(workoutMesg, workoutSteps);
        }

        private static void CreateBikeTempoWorkout()
        {
            var workoutSteps = new List<WorkoutStepMesg>();

            workoutSteps.Add(CreateWorkoutStep(messageIndex: workoutSteps.Count,
                durationType: WktStepDuration.Time,
                durationValue: 900_000, // milliseconds = 15 minutes
                targetType: WktStepTarget.HeartRate,
                customTargetValueLow: 120,
                customTargetValueHigh: 150,
                intensity: Intensity.Warmup));

            workoutSteps.Add(CreateWorkoutStep(messageIndex: workoutSteps.Count,
                durationType: WktStepDuration.Time,
                durationValue: 3_600_000, // milliseconds = 60 minutes
                targetType: WktStepTarget.HeartRate,
                customTargetValueLow: 150,
                customTargetValueHigh: 170,
                intensity: Intensity.Active));

            workoutSteps.Add(CreateWorkoutStep(messageIndex: workoutSteps.Count,
                durationType: WktStepDuration.Time,
                durationValue: 900_000, // milliseconds = 15 minutes
                targetType: WktStepTarget.HeartRate,
                customTargetValueLow: 120,
                customTargetValueHigh: 150,
                intensity: Intensity.Cooldown
            ));

            var workoutMesg = new WorkoutMesg();
            workoutMesg.SetWktName("60MinutesTempo");
            workoutMesg.SetSport(Sport.Cycling);
            workoutMesg.SetSubSport(SubSport.Invalid);
            workoutMesg.SetNumValidSteps((ushort)workoutSteps.Count);

            CreateWorkout(workoutMesg, workoutSteps);
        }

        static void CreateWorkout(WorkoutMesg workoutMesg, List<WorkoutStepMesg> workoutSteps)
        {
            // The combination of file type, manufacturer id, product id, and serial number should be unique.
            // When available, a non-random serial number should be used.
            Dynastream.Fit.File fileType = Dynastream.Fit.File.Workout;
            ushort manufacturerId = Manufacturer.Development;
            ushort productId = 0;
            Random random = new Random();
            uint serialNumber = (uint)random.Next();

            // Every FIT file MUST contain a File ID message
            var fileIdMesg = new FileIdMesg();
            fileIdMesg.SetType(fileType);
            fileIdMesg.SetManufacturer(manufacturerId);
            fileIdMesg.SetProduct(productId);
            fileIdMesg.SetTimeCreated(new Dynastream.Fit.DateTime(System.DateTime.UtcNow));
            fileIdMesg.SetSerialNumber(serialNumber);

            try
            {
                var downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                var filePath = $"{workoutMesg.GetWktNameAsString().Replace(' ', '_')}.fit";

                var destinationFilePath = Path.Combine(downloadsFolder, "Downloads", filePath);
                

                // Check if the file name already exists in the current location
                if (System.IO.File.Exists(destinationFilePath) == true)
                {
                    string fileName = $"{filePath.Substring(0, filePath.IndexOf(".fit"))}";
                    string baseFileName = fileName;
                    int copyNumber = 0;
                    
                    // Check if the base file name contains "(number)"
                    int openParenIndex = baseFileName.LastIndexOf("(");
                    int closeParenIndex = baseFileName.LastIndexOf(")");
                    
                   
                    if (openParenIndex >= 0 && closeParenIndex > openParenIndex)
                    {
                        string copyNumberStr = baseFileName.Substring(openParenIndex + 1, closeParenIndex - openParenIndex - 1);
                        if (int.TryParse(copyNumberStr, out int existingCopyNumber))
                        {
                            copyNumber = existingCopyNumber + 1;
                            baseFileName = baseFileName.Substring(0, openParenIndex);
                        }
                    }

                    string newFileName;
    
                    do
                    {

                        newFileName = copyNumber == 0 ? $"{baseFileName}.fit" : $"{baseFileName}({copyNumber}).fit";
                        copyNumber++;
                    } while (System.IO.File.Exists(Path.Combine(downloadsFolder, "Downloads", newFileName)));

                    destinationFilePath = Path.Combine(downloadsFolder, "Downloads", $"{newFileName}");
                }

                // Create the output stream, this can be any type of stream, including a file or memory stream. Must have read/write access
                FileStream fitDest = new FileStream(destinationFilePath, FileMode.CreateNew, FileAccess.ReadWrite,
                    FileShare.Read);

                // Create a FIT Encode object
                Encode encoder = new Encode(ProtocolVersion.V10);

                // Write the FIT header to the output stream
                encoder.Open(fitDest);

                // Write the messages to the file, in the proper sequence
                encoder.Write(fileIdMesg);
                encoder.Write(workoutMesg);

                foreach (WorkoutStepMesg workoutStep in workoutSteps)
                {
                    encoder.Write(workoutStep);
                }

                // Update the data size in the header and calculate the CRC
                encoder.Close();

                // Close the output stream
                fitDest.Close();

                Console.WriteLine($"Encoded FIT file {fitDest.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occured with the message: {ex.Message}");
            }
        }

        private static WorkoutStepMesg CreateWorkoutStep(int messageIndex, String name = null, String notes = null,
            Intensity intensity = Intensity.Active, WktStepDuration durationType = WktStepDuration.Open,
            uint? durationValue = null, WktStepTarget targetType = WktStepTarget.Open, uint targetValue = 0,
            uint? customTargetValueLow = null, uint? customTargetValueHigh = null)
        {
            if (durationType == WktStepDuration.Invalid)
            {
                return null;
            }

            var workoutStepMesg = new WorkoutStepMesg();
            workoutStepMesg.SetMessageIndex((ushort)messageIndex);

            if (name != null)
            {
                workoutStepMesg.SetWktStepName(name);
            }

            if (notes != null)
            {
                workoutStepMesg.SetNotes(notes);
            }

            workoutStepMesg.SetIntensity(intensity);
            workoutStepMesg.SetDurationType(durationType);

            if (durationValue.HasValue)
            {
                workoutStepMesg.SetDurationValue(durationValue);
            }

            if (targetType != WktStepTarget.Invalid && customTargetValueLow.HasValue && customTargetValueHigh.HasValue)
            {
                workoutStepMesg.SetTargetType(targetType);
                workoutStepMesg.SetTargetValue(0);
                workoutStepMesg.SetCustomTargetValueLow(customTargetValueLow);
                workoutStepMesg.SetCustomTargetValueHigh(customTargetValueHigh);
            }
            else if (targetType != WktStepTarget.Invalid)
            {
                workoutStepMesg.SetTargetType(targetType);
                workoutStepMesg.SetTargetValue(targetValue);
                workoutStepMesg.SetCustomTargetValueLow(0);
                workoutStepMesg.SetCustomTargetValueHigh(0);
            }

            return workoutStepMesg;
        }

        private static WorkoutStepMesg CreateWorkoutStepRepeat(int messageIndex, uint repeatFrom, uint repetitions)
        {
            var workoutStepMesg = new WorkoutStepMesg();
            workoutStepMesg.SetMessageIndex((ushort)messageIndex);

            workoutStepMesg.SetDurationType(WktStepDuration.RepeatUntilStepsCmplt);
            workoutStepMesg.SetDurationValue(repeatFrom);

            workoutStepMesg.SetTargetType(WktStepTarget.Open);
            workoutStepMesg.SetTargetValue(repetitions);

            return workoutStepMesg;
        }

        public static (int, HeartRateZones) RetrieveUserHrZones()
        {
            var hasHrZones = Preferences.Default.ContainsKey("HRData");

            if (hasHrZones == false) return (400, new HeartRateZones());

            var hrData = Preferences.Default.Get("HRData", "");

            if (hrData == "") return (400, new HeartRateZones());

            var userHrZones = JsonSerializer.Deserialize<HeartRateZones>(hrData);

            return (200, userHrZones);
        }
    }

    public class HeartRateZones
    {
        public Zone Zone1 { get; set; }
        public Zone Zone2 { get; set; }
        public Zone Zone3 { get; set; }
        public Zone Zone4 { get; set; }
        public Zone Zone5 { get; set; }
    }

    public class Zone
    {
        public double Low { get; set; }
        public double High { get; set; }
    }

    public class WorkoutStep
    {
        public WktStepDuration DurationType { get; set; }
        public uint DurationValue { get; set; }
        public WktStepTarget TargetType { get; set; }
        public Zone Zone { get; set; }
        public Intensity Intensity { get; set; }
    }
}