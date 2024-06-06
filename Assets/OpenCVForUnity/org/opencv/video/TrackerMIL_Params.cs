

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Params


    public class TrackerMIL_Params : DisposableOpenCVObject
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        video_TrackerMIL_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerMIL_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerMIL_Params __fromPtr__(IntPtr addr) { return new TrackerMIL_Params(addr); }

        //
        // C++:   cv::TrackerMIL::Params::Params()
        //

        public TrackerMIL_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_TrackerMIL_1Params_TrackerMIL_1Params_10());


        }


        //
        // C++: float TrackerMIL_Params::samplerInitInRadius
        //

        public float get_samplerInitInRadius()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1samplerInitInRadius_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::samplerInitInRadius
        //

        public void set_samplerInitInRadius(float samplerInitInRadius)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1samplerInitInRadius_10(nativeObj, samplerInitInRadius);


        }


        //
        // C++: int TrackerMIL_Params::samplerInitMaxNegNum
        //

        public int get_samplerInitMaxNegNum()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1samplerInitMaxNegNum_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::samplerInitMaxNegNum
        //

        public void set_samplerInitMaxNegNum(int samplerInitMaxNegNum)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1samplerInitMaxNegNum_10(nativeObj, samplerInitMaxNegNum);


        }


        //
        // C++: float TrackerMIL_Params::samplerSearchWinSize
        //

        public float get_samplerSearchWinSize()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1samplerSearchWinSize_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::samplerSearchWinSize
        //

        public void set_samplerSearchWinSize(float samplerSearchWinSize)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1samplerSearchWinSize_10(nativeObj, samplerSearchWinSize);


        }


        //
        // C++: float TrackerMIL_Params::samplerTrackInRadius
        //

        public float get_samplerTrackInRadius()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1samplerTrackInRadius_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::samplerTrackInRadius
        //

        public void set_samplerTrackInRadius(float samplerTrackInRadius)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1samplerTrackInRadius_10(nativeObj, samplerTrackInRadius);


        }


        //
        // C++: int TrackerMIL_Params::samplerTrackMaxPosNum
        //

        public int get_samplerTrackMaxPosNum()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1samplerTrackMaxPosNum_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::samplerTrackMaxPosNum
        //

        public void set_samplerTrackMaxPosNum(int samplerTrackMaxPosNum)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1samplerTrackMaxPosNum_10(nativeObj, samplerTrackMaxPosNum);


        }


        //
        // C++: int TrackerMIL_Params::samplerTrackMaxNegNum
        //

        public int get_samplerTrackMaxNegNum()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1samplerTrackMaxNegNum_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::samplerTrackMaxNegNum
        //

        public void set_samplerTrackMaxNegNum(int samplerTrackMaxNegNum)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1samplerTrackMaxNegNum_10(nativeObj, samplerTrackMaxNegNum);


        }


        //
        // C++: int TrackerMIL_Params::featureSetNumFeatures
        //

        public int get_featureSetNumFeatures()
        {
            ThrowIfDisposed();

            return video_TrackerMIL_1Params_get_1featureSetNumFeatures_10(nativeObj);


        }


        //
        // C++: void TrackerMIL_Params::featureSetNumFeatures
        //

        public void set_featureSetNumFeatures(int featureSetNumFeatures)
        {
            ThrowIfDisposed();

            video_TrackerMIL_1Params_set_1featureSetNumFeatures_10(nativeObj, featureSetNumFeatures);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerMIL::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerMIL_1Params_TrackerMIL_1Params_10();

        // C++: float TrackerMIL_Params::samplerInitInRadius
        [DllImport(LIBNAME)]
        private static extern float video_TrackerMIL_1Params_get_1samplerInitInRadius_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::samplerInitInRadius
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1samplerInitInRadius_10(IntPtr nativeObj, float samplerInitInRadius);

        // C++: int TrackerMIL_Params::samplerInitMaxNegNum
        [DllImport(LIBNAME)]
        private static extern int video_TrackerMIL_1Params_get_1samplerInitMaxNegNum_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::samplerInitMaxNegNum
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1samplerInitMaxNegNum_10(IntPtr nativeObj, int samplerInitMaxNegNum);

        // C++: float TrackerMIL_Params::samplerSearchWinSize
        [DllImport(LIBNAME)]
        private static extern float video_TrackerMIL_1Params_get_1samplerSearchWinSize_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::samplerSearchWinSize
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1samplerSearchWinSize_10(IntPtr nativeObj, float samplerSearchWinSize);

        // C++: float TrackerMIL_Params::samplerTrackInRadius
        [DllImport(LIBNAME)]
        private static extern float video_TrackerMIL_1Params_get_1samplerTrackInRadius_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::samplerTrackInRadius
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1samplerTrackInRadius_10(IntPtr nativeObj, float samplerTrackInRadius);

        // C++: int TrackerMIL_Params::samplerTrackMaxPosNum
        [DllImport(LIBNAME)]
        private static extern int video_TrackerMIL_1Params_get_1samplerTrackMaxPosNum_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::samplerTrackMaxPosNum
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1samplerTrackMaxPosNum_10(IntPtr nativeObj, int samplerTrackMaxPosNum);

        // C++: int TrackerMIL_Params::samplerTrackMaxNegNum
        [DllImport(LIBNAME)]
        private static extern int video_TrackerMIL_1Params_get_1samplerTrackMaxNegNum_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::samplerTrackMaxNegNum
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1samplerTrackMaxNegNum_10(IntPtr nativeObj, int samplerTrackMaxNegNum);

        // C++: int TrackerMIL_Params::featureSetNumFeatures
        [DllImport(LIBNAME)]
        private static extern int video_TrackerMIL_1Params_get_1featureSetNumFeatures_10(IntPtr nativeObj);

        // C++: void TrackerMIL_Params::featureSetNumFeatures
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_set_1featureSetNumFeatures_10(IntPtr nativeObj, int featureSetNumFeatures);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerMIL_1Params_delete(IntPtr nativeObj);

    }
}
