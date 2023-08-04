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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the HrvStatusSummary profile message.
    /// </summary>
    public class HrvStatusSummaryMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="HrvStatusSummaryMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte WeeklyAverage = 0;
            public const byte LastNightAverage = 1;
            public const byte LastNight5MinHigh = 2;
            public const byte BaselineLowUpper = 3;
            public const byte BaselineBalancedLower = 4;
            public const byte BaselineBalancedUpper = 5;
            public const byte Status = 6;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public HrvStatusSummaryMesg() : base(Profile.GetMesg(MesgNum.HrvStatusSummary))
        {
        }

        public HrvStatusSummaryMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WeeklyAverage field
        /// Units: ms
        /// Comment: 7 day RMSSD average over sleep</summary>
        /// <returns>Returns nullable float representing the WeeklyAverage field</returns>
        public float? GetWeeklyAverage()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set WeeklyAverage field
        /// Units: ms
        /// Comment: 7 day RMSSD average over sleep</summary>
        /// <param name="weeklyAverage_">Nullable field value to be set</param>
        public void SetWeeklyAverage(float? weeklyAverage_)
        {
            SetFieldValue(0, 0, weeklyAverage_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LastNightAverage field
        /// Units: ms
        /// Comment: Last night RMSSD average over sleep</summary>
        /// <returns>Returns nullable float representing the LastNightAverage field</returns>
        public float? GetLastNightAverage()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set LastNightAverage field
        /// Units: ms
        /// Comment: Last night RMSSD average over sleep</summary>
        /// <param name="lastNightAverage_">Nullable field value to be set</param>
        public void SetLastNightAverage(float? lastNightAverage_)
        {
            SetFieldValue(1, 0, lastNightAverage_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LastNight5MinHigh field
        /// Units: ms
        /// Comment: 5 minute high RMSSD value over sleep</summary>
        /// <returns>Returns nullable float representing the LastNight5MinHigh field</returns>
        public float? GetLastNight5MinHigh()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set LastNight5MinHigh field
        /// Units: ms
        /// Comment: 5 minute high RMSSD value over sleep</summary>
        /// <param name="lastNight5MinHigh_">Nullable field value to be set</param>
        public void SetLastNight5MinHigh(float? lastNight5MinHigh_)
        {
            SetFieldValue(2, 0, lastNight5MinHigh_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BaselineLowUpper field
        /// Units: ms
        /// Comment: 3 week baseline, upper boundary of low HRV status</summary>
        /// <returns>Returns nullable float representing the BaselineLowUpper field</returns>
        public float? GetBaselineLowUpper()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BaselineLowUpper field
        /// Units: ms
        /// Comment: 3 week baseline, upper boundary of low HRV status</summary>
        /// <param name="baselineLowUpper_">Nullable field value to be set</param>
        public void SetBaselineLowUpper(float? baselineLowUpper_)
        {
            SetFieldValue(3, 0, baselineLowUpper_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BaselineBalancedLower field
        /// Units: ms
        /// Comment: 3 week baseline, lower boundary of balanced HRV status</summary>
        /// <returns>Returns nullable float representing the BaselineBalancedLower field</returns>
        public float? GetBaselineBalancedLower()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BaselineBalancedLower field
        /// Units: ms
        /// Comment: 3 week baseline, lower boundary of balanced HRV status</summary>
        /// <param name="baselineBalancedLower_">Nullable field value to be set</param>
        public void SetBaselineBalancedLower(float? baselineBalancedLower_)
        {
            SetFieldValue(4, 0, baselineBalancedLower_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BaselineBalancedUpper field
        /// Units: ms
        /// Comment: 3 week baseline, upper boundary of balanced HRV status</summary>
        /// <returns>Returns nullable float representing the BaselineBalancedUpper field</returns>
        public float? GetBaselineBalancedUpper()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BaselineBalancedUpper field
        /// Units: ms
        /// Comment: 3 week baseline, upper boundary of balanced HRV status</summary>
        /// <param name="baselineBalancedUpper_">Nullable field value to be set</param>
        public void SetBaselineBalancedUpper(float? baselineBalancedUpper_)
        {
            SetFieldValue(5, 0, baselineBalancedUpper_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Status field</summary>
        /// <returns>Returns nullable HrvStatus enum representing the Status field</returns>
        public HrvStatus? GetStatus()
        {
            object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            HrvStatus? value = obj == null ? (HrvStatus?)null : (HrvStatus)obj;
            return value;
        }

        /// <summary>
        /// Set Status field</summary>
        /// <param name="status_">Nullable field value to be set</param>
        public void SetStatus(HrvStatus? status_)
        {
            SetFieldValue(6, 0, status_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
