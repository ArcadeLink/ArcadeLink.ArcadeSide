

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{
    // C++: class Params


    public class SimpleBlobDetector_Params : DisposableOpenCVObject
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
                        features2d_SimpleBlobDetector_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SimpleBlobDetector_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static SimpleBlobDetector_Params __fromPtr__(IntPtr addr) { return new SimpleBlobDetector_Params(addr); }

        //
        // C++:   cv::SimpleBlobDetector::Params::Params()
        //

        public SimpleBlobDetector_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(features2d_SimpleBlobDetector_1Params_SimpleBlobDetector_1Params_10());


        }


        //
        // C++: float SimpleBlobDetector_Params::thresholdStep
        //

        public float get_thresholdStep()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1thresholdStep_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::thresholdStep
        //

        public void set_thresholdStep(float thresholdStep)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1thresholdStep_10(nativeObj, thresholdStep);


        }


        //
        // C++: float SimpleBlobDetector_Params::minThreshold
        //

        public float get_minThreshold()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minThreshold_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minThreshold
        //

        public void set_minThreshold(float minThreshold)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minThreshold_10(nativeObj, minThreshold);


        }


        //
        // C++: float SimpleBlobDetector_Params::maxThreshold
        //

        public float get_maxThreshold()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1maxThreshold_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::maxThreshold
        //

        public void set_maxThreshold(float maxThreshold)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1maxThreshold_10(nativeObj, maxThreshold);


        }


        //
        // C++: size_t SimpleBlobDetector_Params::minRepeatability
        //

        public long get_minRepeatability()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minRepeatability_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minRepeatability
        //

        public void set_minRepeatability(long minRepeatability)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minRepeatability_10(nativeObj, minRepeatability);


        }


        //
        // C++: float SimpleBlobDetector_Params::minDistBetweenBlobs
        //

        public float get_minDistBetweenBlobs()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minDistBetweenBlobs_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minDistBetweenBlobs
        //

        public void set_minDistBetweenBlobs(float minDistBetweenBlobs)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minDistBetweenBlobs_10(nativeObj, minDistBetweenBlobs);


        }


        //
        // C++: bool SimpleBlobDetector_Params::filterByColor
        //

        public bool get_filterByColor()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1filterByColor_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::filterByColor
        //

        public void set_filterByColor(bool filterByColor)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1filterByColor_10(nativeObj, filterByColor);


        }


        //
        // C++: uchar SimpleBlobDetector_Params::blobColor
        //

        // Return type 'uchar' is not supported, skipping the function


        //
        // C++: void SimpleBlobDetector_Params::blobColor
        //

        // Unknown type 'uchar' (I), skipping the function


        //
        // C++: bool SimpleBlobDetector_Params::filterByArea
        //

        public bool get_filterByArea()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1filterByArea_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::filterByArea
        //

        public void set_filterByArea(bool filterByArea)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1filterByArea_10(nativeObj, filterByArea);


        }


        //
        // C++: float SimpleBlobDetector_Params::minArea
        //

        public float get_minArea()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minArea_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minArea
        //

        public void set_minArea(float minArea)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minArea_10(nativeObj, minArea);


        }


        //
        // C++: float SimpleBlobDetector_Params::maxArea
        //

        public float get_maxArea()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1maxArea_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::maxArea
        //

        public void set_maxArea(float maxArea)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1maxArea_10(nativeObj, maxArea);


        }


        //
        // C++: bool SimpleBlobDetector_Params::filterByCircularity
        //

        public bool get_filterByCircularity()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1filterByCircularity_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::filterByCircularity
        //

        public void set_filterByCircularity(bool filterByCircularity)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1filterByCircularity_10(nativeObj, filterByCircularity);


        }


        //
        // C++: float SimpleBlobDetector_Params::minCircularity
        //

        public float get_minCircularity()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minCircularity_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minCircularity
        //

        public void set_minCircularity(float minCircularity)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minCircularity_10(nativeObj, minCircularity);


        }


        //
        // C++: float SimpleBlobDetector_Params::maxCircularity
        //

        public float get_maxCircularity()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1maxCircularity_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::maxCircularity
        //

        public void set_maxCircularity(float maxCircularity)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1maxCircularity_10(nativeObj, maxCircularity);


        }


        //
        // C++: bool SimpleBlobDetector_Params::filterByInertia
        //

        public bool get_filterByInertia()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1filterByInertia_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::filterByInertia
        //

        public void set_filterByInertia(bool filterByInertia)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1filterByInertia_10(nativeObj, filterByInertia);


        }


        //
        // C++: float SimpleBlobDetector_Params::minInertiaRatio
        //

        public float get_minInertiaRatio()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minInertiaRatio_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minInertiaRatio
        //

        public void set_minInertiaRatio(float minInertiaRatio)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minInertiaRatio_10(nativeObj, minInertiaRatio);


        }


        //
        // C++: float SimpleBlobDetector_Params::maxInertiaRatio
        //

        public float get_maxInertiaRatio()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1maxInertiaRatio_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::maxInertiaRatio
        //

        public void set_maxInertiaRatio(float maxInertiaRatio)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1maxInertiaRatio_10(nativeObj, maxInertiaRatio);


        }


        //
        // C++: bool SimpleBlobDetector_Params::filterByConvexity
        //

        public bool get_filterByConvexity()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1filterByConvexity_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::filterByConvexity
        //

        public void set_filterByConvexity(bool filterByConvexity)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1filterByConvexity_10(nativeObj, filterByConvexity);


        }


        //
        // C++: float SimpleBlobDetector_Params::minConvexity
        //

        public float get_minConvexity()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1minConvexity_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::minConvexity
        //

        public void set_minConvexity(float minConvexity)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1minConvexity_10(nativeObj, minConvexity);


        }


        //
        // C++: float SimpleBlobDetector_Params::maxConvexity
        //

        public float get_maxConvexity()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1maxConvexity_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::maxConvexity
        //

        public void set_maxConvexity(float maxConvexity)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1maxConvexity_10(nativeObj, maxConvexity);


        }


        //
        // C++: bool SimpleBlobDetector_Params::collectContours
        //

        public bool get_collectContours()
        {
            ThrowIfDisposed();

            return features2d_SimpleBlobDetector_1Params_get_1collectContours_10(nativeObj);


        }


        //
        // C++: void SimpleBlobDetector_Params::collectContours
        //

        public void set_collectContours(bool collectContours)
        {
            ThrowIfDisposed();

            features2d_SimpleBlobDetector_1Params_set_1collectContours_10(nativeObj, collectContours);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::SimpleBlobDetector::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_1Params_SimpleBlobDetector_1Params_10();

        // C++: float SimpleBlobDetector_Params::thresholdStep
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1thresholdStep_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::thresholdStep
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1thresholdStep_10(IntPtr nativeObj, float thresholdStep);

        // C++: float SimpleBlobDetector_Params::minThreshold
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1minThreshold_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minThreshold
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minThreshold_10(IntPtr nativeObj, float minThreshold);

        // C++: float SimpleBlobDetector_Params::maxThreshold
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1maxThreshold_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::maxThreshold
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1maxThreshold_10(IntPtr nativeObj, float maxThreshold);

        // C++: size_t SimpleBlobDetector_Params::minRepeatability
        [DllImport(LIBNAME)]
        private static extern long features2d_SimpleBlobDetector_1Params_get_1minRepeatability_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minRepeatability
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minRepeatability_10(IntPtr nativeObj, long minRepeatability);

        // C++: float SimpleBlobDetector_Params::minDistBetweenBlobs
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1minDistBetweenBlobs_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minDistBetweenBlobs
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minDistBetweenBlobs_10(IntPtr nativeObj, float minDistBetweenBlobs);

        // C++: bool SimpleBlobDetector_Params::filterByColor
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_SimpleBlobDetector_1Params_get_1filterByColor_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::filterByColor
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1filterByColor_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByColor);

        // C++: bool SimpleBlobDetector_Params::filterByArea
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_SimpleBlobDetector_1Params_get_1filterByArea_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::filterByArea
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1filterByArea_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByArea);

        // C++: float SimpleBlobDetector_Params::minArea
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1minArea_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minArea
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minArea_10(IntPtr nativeObj, float minArea);

        // C++: float SimpleBlobDetector_Params::maxArea
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1maxArea_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::maxArea
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1maxArea_10(IntPtr nativeObj, float maxArea);

        // C++: bool SimpleBlobDetector_Params::filterByCircularity
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_SimpleBlobDetector_1Params_get_1filterByCircularity_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::filterByCircularity
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1filterByCircularity_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByCircularity);

        // C++: float SimpleBlobDetector_Params::minCircularity
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1minCircularity_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minCircularity
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minCircularity_10(IntPtr nativeObj, float minCircularity);

        // C++: float SimpleBlobDetector_Params::maxCircularity
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1maxCircularity_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::maxCircularity
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1maxCircularity_10(IntPtr nativeObj, float maxCircularity);

        // C++: bool SimpleBlobDetector_Params::filterByInertia
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_SimpleBlobDetector_1Params_get_1filterByInertia_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::filterByInertia
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1filterByInertia_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByInertia);

        // C++: float SimpleBlobDetector_Params::minInertiaRatio
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1minInertiaRatio_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minInertiaRatio
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minInertiaRatio_10(IntPtr nativeObj, float minInertiaRatio);

        // C++: float SimpleBlobDetector_Params::maxInertiaRatio
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1maxInertiaRatio_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::maxInertiaRatio
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1maxInertiaRatio_10(IntPtr nativeObj, float maxInertiaRatio);

        // C++: bool SimpleBlobDetector_Params::filterByConvexity
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_SimpleBlobDetector_1Params_get_1filterByConvexity_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::filterByConvexity
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1filterByConvexity_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByConvexity);

        // C++: float SimpleBlobDetector_Params::minConvexity
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1minConvexity_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::minConvexity
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1minConvexity_10(IntPtr nativeObj, float minConvexity);

        // C++: float SimpleBlobDetector_Params::maxConvexity
        [DllImport(LIBNAME)]
        private static extern float features2d_SimpleBlobDetector_1Params_get_1maxConvexity_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::maxConvexity
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1maxConvexity_10(IntPtr nativeObj, float maxConvexity);

        // C++: bool SimpleBlobDetector_Params::collectContours
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_SimpleBlobDetector_1Params_get_1collectContours_10(IntPtr nativeObj);

        // C++: void SimpleBlobDetector_Params::collectContours
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_set_1collectContours_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool collectContours);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_1Params_delete(IntPtr nativeObj);

    }
}
