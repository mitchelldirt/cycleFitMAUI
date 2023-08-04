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
    /// Implements the profile BleDeviceType type as a class
    /// </summary>
    public static class BleDeviceType 
    {
        public const byte ConnectedGps = 0; // GPS that is provided over a proprietary bluetooth service
        public const byte HeartRate = 1;
        public const byte BikePower = 2;
        public const byte BikeSpeedCadence = 3;
        public const byte BikeSpeed = 4;
        public const byte BikeCadence = 5;
        public const byte Footpod = 6;
        public const byte BikeTrainer = 7; // Indoor-Bike FTMS protocol
        public const byte Invalid = (byte)0xFF;


    }
}

