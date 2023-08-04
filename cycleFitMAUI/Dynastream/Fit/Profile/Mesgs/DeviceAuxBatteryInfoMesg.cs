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
    /// Implements the DeviceAuxBatteryInfo profile message.
    /// </summary>
    public class DeviceAuxBatteryInfoMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="DeviceAuxBatteryInfoMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte DeviceIndex = 0;
            public const byte BatteryVoltage = 1;
            public const byte BatteryStatus = 2;
            public const byte BatteryIdentifier = 3;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public DeviceAuxBatteryInfoMesg() : base(Profile.GetMesg(MesgNum.DeviceAuxBatteryInfo))
        {
        }

        public DeviceAuxBatteryInfoMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the DeviceIndex field</summary>
        /// <returns>Returns nullable byte representing the DeviceIndex field</returns>
        public byte? GetDeviceIndex()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set DeviceIndex field</summary>
        /// <param name="deviceIndex_">Nullable field value to be set</param>
        public void SetDeviceIndex(byte? deviceIndex_)
        {
            SetFieldValue(0, 0, deviceIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BatteryVoltage field
        /// Units: V</summary>
        /// <returns>Returns nullable float representing the BatteryVoltage field</returns>
        public float? GetBatteryVoltage()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BatteryVoltage field
        /// Units: V</summary>
        /// <param name="batteryVoltage_">Nullable field value to be set</param>
        public void SetBatteryVoltage(float? batteryVoltage_)
        {
            SetFieldValue(1, 0, batteryVoltage_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BatteryStatus field</summary>
        /// <returns>Returns nullable byte representing the BatteryStatus field</returns>
        public byte? GetBatteryStatus()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BatteryStatus field</summary>
        /// <param name="batteryStatus_">Nullable field value to be set</param>
        public void SetBatteryStatus(byte? batteryStatus_)
        {
            SetFieldValue(2, 0, batteryStatus_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BatteryIdentifier field</summary>
        /// <returns>Returns nullable byte representing the BatteryIdentifier field</returns>
        public byte? GetBatteryIdentifier()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BatteryIdentifier field</summary>
        /// <param name="batteryIdentifier_">Nullable field value to be set</param>
        public void SetBatteryIdentifier(byte? batteryIdentifier_)
        {
            SetFieldValue(3, 0, batteryIdentifier_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
