
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class StarDetector
    /**
     * The class implements the keypoint detector introduced by CITE: Agrawal08, synonym of StarDetector. :
     */

    public class StarDetector : Feature2D
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
                        xfeatures2d_StarDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StarDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StarDetector __fromPtr__(IntPtr addr) { return new StarDetector(addr); }

        //
        // C++: static Ptr_StarDetector cv::xfeatures2d::StarDetector::create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        //

        public static StarDetector create(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize)
        {


            return StarDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_create_10(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize)));


        }

        public static StarDetector create(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized)
        {


            return StarDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_create_11(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized)));


        }

        public static StarDetector create(int maxSize, int responseThreshold, int lineThresholdProjected)
        {


            return StarDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_create_12(maxSize, responseThreshold, lineThresholdProjected)));


        }

        public static StarDetector create(int maxSize, int responseThreshold)
        {


            return StarDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_create_13(maxSize, responseThreshold)));


        }

        public static StarDetector create(int maxSize)
        {


            return StarDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_create_14(maxSize)));


        }

        public static StarDetector create()
        {


            return StarDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_create_15()));


        }


        //
        // C++:  void cv::xfeatures2d::StarDetector::setMaxSize(int _maxSize)
        //

        public void setMaxSize(int _maxSize)
        {
            ThrowIfDisposed();

            xfeatures2d_StarDetector_setMaxSize_10(nativeObj, _maxSize);


        }


        //
        // C++:  int cv::xfeatures2d::StarDetector::getMaxSize()
        //

        public int getMaxSize()
        {
            ThrowIfDisposed();

            return xfeatures2d_StarDetector_getMaxSize_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::StarDetector::setResponseThreshold(int _responseThreshold)
        //

        public void setResponseThreshold(int _responseThreshold)
        {
            ThrowIfDisposed();

            xfeatures2d_StarDetector_setResponseThreshold_10(nativeObj, _responseThreshold);


        }


        //
        // C++:  int cv::xfeatures2d::StarDetector::getResponseThreshold()
        //

        public int getResponseThreshold()
        {
            ThrowIfDisposed();

            return xfeatures2d_StarDetector_getResponseThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::StarDetector::setLineThresholdProjected(int _lineThresholdProjected)
        //

        public void setLineThresholdProjected(int _lineThresholdProjected)
        {
            ThrowIfDisposed();

            xfeatures2d_StarDetector_setLineThresholdProjected_10(nativeObj, _lineThresholdProjected);


        }


        //
        // C++:  int cv::xfeatures2d::StarDetector::getLineThresholdProjected()
        //

        public int getLineThresholdProjected()
        {
            ThrowIfDisposed();

            return xfeatures2d_StarDetector_getLineThresholdProjected_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::StarDetector::setLineThresholdBinarized(int _lineThresholdBinarized)
        //

        public void setLineThresholdBinarized(int _lineThresholdBinarized)
        {
            ThrowIfDisposed();

            xfeatures2d_StarDetector_setLineThresholdBinarized_10(nativeObj, _lineThresholdBinarized);


        }


        //
        // C++:  int cv::xfeatures2d::StarDetector::getLineThresholdBinarized()
        //

        public int getLineThresholdBinarized()
        {
            ThrowIfDisposed();

            return xfeatures2d_StarDetector_getLineThresholdBinarized_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::StarDetector::setSuppressNonmaxSize(int _suppressNonmaxSize)
        //

        public void setSuppressNonmaxSize(int _suppressNonmaxSize)
        {
            ThrowIfDisposed();

            xfeatures2d_StarDetector_setSuppressNonmaxSize_10(nativeObj, _suppressNonmaxSize);


        }


        //
        // C++:  int cv::xfeatures2d::StarDetector::getSuppressNonmaxSize()
        //

        public int getSuppressNonmaxSize()
        {
            ThrowIfDisposed();

            return xfeatures2d_StarDetector_getSuppressNonmaxSize_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::StarDetector::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_StarDetector_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_StarDetector cv::xfeatures2d::StarDetector::create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_10(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_11(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_12(int maxSize, int responseThreshold, int lineThresholdProjected);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_13(int maxSize, int responseThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_14(int maxSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_15();

        // C++:  void cv::xfeatures2d::StarDetector::setMaxSize(int _maxSize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_setMaxSize_10(IntPtr nativeObj, int _maxSize);

        // C++:  int cv::xfeatures2d::StarDetector::getMaxSize()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_StarDetector_getMaxSize_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::StarDetector::setResponseThreshold(int _responseThreshold)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_setResponseThreshold_10(IntPtr nativeObj, int _responseThreshold);

        // C++:  int cv::xfeatures2d::StarDetector::getResponseThreshold()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_StarDetector_getResponseThreshold_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::StarDetector::setLineThresholdProjected(int _lineThresholdProjected)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_setLineThresholdProjected_10(IntPtr nativeObj, int _lineThresholdProjected);

        // C++:  int cv::xfeatures2d::StarDetector::getLineThresholdProjected()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_StarDetector_getLineThresholdProjected_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::StarDetector::setLineThresholdBinarized(int _lineThresholdBinarized)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_setLineThresholdBinarized_10(IntPtr nativeObj, int _lineThresholdBinarized);

        // C++:  int cv::xfeatures2d::StarDetector::getLineThresholdBinarized()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_StarDetector_getLineThresholdBinarized_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::StarDetector::setSuppressNonmaxSize(int _suppressNonmaxSize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_setSuppressNonmaxSize_10(IntPtr nativeObj, int _suppressNonmaxSize);

        // C++:  int cv::xfeatures2d::StarDetector::getSuppressNonmaxSize()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_StarDetector_getSuppressNonmaxSize_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::StarDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_delete(IntPtr nativeObj);

    }
}
