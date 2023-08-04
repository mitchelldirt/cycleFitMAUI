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
    /// Implements the profile CameraEventType type as an enum
    /// </summary>
    public enum CameraEventType : byte
    {
        VideoStart = 0,
        VideoSplit = 1,
        VideoEnd = 2,
        PhotoTaken = 3,
        VideoSecondStreamStart = 4,
        VideoSecondStreamSplit = 5,
        VideoSecondStreamEnd = 6,
        VideoSplitStart = 7,
        VideoSecondStreamSplitStart = 8,
        VideoPause = 11,
        VideoSecondStreamPause = 12,
        VideoResume = 13,
        VideoSecondStreamResume = 14,
        Invalid = 0xFF


    }
}

