
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class AgastFeatureDetector
    /**
     * Wrapping class for feature detection using the AGAST method. :
     */

    public class AgastFeatureDetector : Feature2D
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
                        features2d_AgastFeatureDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AgastFeatureDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AgastFeatureDetector __fromPtr__(IntPtr addr) { return new AgastFeatureDetector(addr); }

        // C++: enum <unnamed>
        public const int THRESHOLD = 10000;
        public const int NONMAX_SUPPRESSION = 10001;
        // C++: enum cv.AgastFeatureDetector.DetectorType
        public const int AGAST_5_8 = 0;
        public const int AGAST_7_12d = 1;
        public const int AGAST_7_12s = 2;
        public const int OAST_9_16 = 3;
        //
        // C++: static Ptr_AgastFeatureDetector cv::AgastFeatureDetector::create(int threshold = 10, bool nonmaxSuppression = true, AgastFeatureDetector_DetectorType type = AgastFeatureDetector::OAST_9_16)
        //

        public static AgastFeatureDetector create(int threshold, bool nonmaxSuppression, int type)
        {


            return AgastFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AgastFeatureDetector_create_10(threshold, nonmaxSuppression, type)));


        }

        public static AgastFeatureDetector create(int threshold, bool nonmaxSuppression)
        {


            return AgastFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AgastFeatureDetector_create_11(threshold, nonmaxSuppression)));


        }

        public static AgastFeatureDetector create(int threshold)
        {


            return AgastFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AgastFeatureDetector_create_12(threshold)));


        }

        public static AgastFeatureDetector create()
        {


            return AgastFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AgastFeatureDetector_create_13()));


        }


        //
        // C++:  void cv::AgastFeatureDetector::setThreshold(int threshold)
        //

        public void setThreshold(int threshold)
        {
            ThrowIfDisposed();

            features2d_AgastFeatureDetector_setThreshold_10(nativeObj, threshold);


        }


        //
        // C++:  int cv::AgastFeatureDetector::getThreshold()
        //

        public int getThreshold()
        {
            ThrowIfDisposed();

            return features2d_AgastFeatureDetector_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::AgastFeatureDetector::setNonmaxSuppression(bool f)
        //

        public void setNonmaxSuppression(bool f)
        {
            ThrowIfDisposed();

            features2d_AgastFeatureDetector_setNonmaxSuppression_10(nativeObj, f);


        }


        //
        // C++:  bool cv::AgastFeatureDetector::getNonmaxSuppression()
        //

        public bool getNonmaxSuppression()
        {
            ThrowIfDisposed();

            return features2d_AgastFeatureDetector_getNonmaxSuppression_10(nativeObj);


        }


        //
        // C++:  void cv::AgastFeatureDetector::setType(AgastFeatureDetector_DetectorType type)
        //

        public void setType(int type)
        {
            ThrowIfDisposed();

            features2d_AgastFeatureDetector_setType_10(nativeObj, type);


        }


        //
        // C++:  AgastFeatureDetector_DetectorType cv::AgastFeatureDetector::getType()
        //

        public int getType()
        {
            ThrowIfDisposed();

            return features2d_AgastFeatureDetector_getType_10(nativeObj);


        }


        //
        // C++:  String cv::AgastFeatureDetector::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_AgastFeatureDetector_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_AgastFeatureDetector cv::AgastFeatureDetector::create(int threshold = 10, bool nonmaxSuppression = true, AgastFeatureDetector_DetectorType type = AgastFeatureDetector::OAST_9_16)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_10(int threshold, [MarshalAs(UnmanagedType.U1)] bool nonmaxSuppression, int type);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_11(int threshold, [MarshalAs(UnmanagedType.U1)] bool nonmaxSuppression);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_12(int threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_13();

        // C++:  void cv::AgastFeatureDetector::setThreshold(int threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_setThreshold_10(IntPtr nativeObj, int threshold);

        // C++:  int cv::AgastFeatureDetector::getThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_AgastFeatureDetector_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::AgastFeatureDetector::setNonmaxSuppression(bool f)
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_setNonmaxSuppression_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool f);

        // C++:  bool cv::AgastFeatureDetector::getNonmaxSuppression()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_AgastFeatureDetector_getNonmaxSuppression_10(IntPtr nativeObj);

        // C++:  void cv::AgastFeatureDetector::setType(AgastFeatureDetector_DetectorType type)
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_setType_10(IntPtr nativeObj, int type);

        // C++:  AgastFeatureDetector_DetectorType cv::AgastFeatureDetector::getType()
        [DllImport(LIBNAME)]
        private static extern int features2d_AgastFeatureDetector_getType_10(IntPtr nativeObj);

        // C++:  String cv::AgastFeatureDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_delete(IntPtr nativeObj);

    }
}
