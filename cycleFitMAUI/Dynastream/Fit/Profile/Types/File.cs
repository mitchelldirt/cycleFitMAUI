#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.115Release
// Tag = production/release/21.115.00-0-gfe0a7f8
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile File type as an enum
    /// </summary>
    public enum File : byte
    {
        Device = 1,
        Settings = 2,
        Sport = 3,
        Activity = 4,
        Workout = 5,
        Course = 6,
        Schedules = 7,
        Weight = 9,
        Totals = 10,
        Goals = 11,
        BloodPressure = 14,
        MonitoringA = 15,
        ActivitySummary = 20,
        MonitoringDaily = 28,
        MonitoringB = 32,
        Segment = 34,
        SegmentList = 35,
        ExdConfiguration = 40,
        MfgRangeMin = 0xF7,
        MfgRangeMax = 0xFE,
        Invalid = 0xFF


    }
}
