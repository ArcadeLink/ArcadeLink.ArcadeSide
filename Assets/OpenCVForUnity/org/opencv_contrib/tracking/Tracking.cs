
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{
    // C++: class Tracking


    public class Tracking
    {

        // C++: enum <unnamed>
        public const int TrackerContribSamplerCSC_MODE_INIT_POS = 1;
        public const int TrackerContribSamplerCSC_MODE_INIT_NEG = 2;
        public const int TrackerContribSamplerCSC_MODE_TRACK_POS = 3;
        public const int TrackerContribSamplerCSC_MODE_TRACK_NEG = 4;
        public const int TrackerContribSamplerCSC_MODE_DETECT = 5;
        public const int TrackerSamplerCS_MODE_POSITIVE = 1;
        public const int TrackerSamplerCS_MODE_NEGATIVE = 2;
        public const int TrackerSamplerCS_MODE_CLASSIFY = 3;
        // C++: enum cv.detail.CvFeatureParams.FeatureType
        public const int CvFeatureParams_HAAR = 0;
        public const int CvFeatureParams_LBP = 1;
        public const int CvFeatureParams_HOG = 2;
        //
        // C++:  Ptr_Tracker cv::legacy::upgradeTrackingAPI(Ptr_legacy_Tracker legacy_tracker)
        //

        public static Tracker legacy_upgradeTrackingAPI(legacy_Tracker legacy_tracker)
        {
            if (legacy_tracker != null) legacy_tracker.ThrowIfDisposed();

            return Tracker.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_Tracking_legacy_1upgradeTrackingAPI_10(legacy_tracker.getNativeObjAddr())));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Ptr_Tracker cv::legacy::upgradeTrackingAPI(Ptr_legacy_Tracker legacy_tracker)
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_Tracking_legacy_1upgradeTrackingAPI_10(IntPtr legacy_tracker_nativeObj);

    }
}
