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
    /// Implements the Hrv profile message.
    /// </summary>
    public class HrvMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="HrvMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Time = 0;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public HrvMesg() : base(Profile.GetMesg(MesgNum.Hrv))
        {
        }

        public HrvMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Time</returns>
        public int GetNumTime()
        {
            return GetNumFieldValues(0, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Time field
        /// Units: s
        /// Comment: Time between beats</summary>
        /// <param name="index">0 based index of Time element to retrieve</param>
        /// <returns>Returns nullable float representing the Time field</returns>
        public float? GetTime(int index)
        {
            Object val = GetFieldValue(0, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Time field
        /// Units: s
        /// Comment: Time between beats</summary>
        /// <param name="index">0 based index of time</param>
        /// <param name="time_">Nullable field value to be set</param>
        public void SetTime(int index, float? time_)
        {
            SetFieldValue(0, index, time_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
