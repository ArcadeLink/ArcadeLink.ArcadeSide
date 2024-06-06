
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class LATCH
    /**
     * latch Class for computing the LATCH descriptor.
     * If you find this code useful, please add a reference to the following paper in your work:
     * Gil Levi and Tal Hassner, "LATCH: Learned Arrangements of Three Patch Codes", arXiv preprint arXiv:1501.03719, 15 Jan. 2015
     *
     * LATCH is a binary descriptor based on learned comparisons of triplets of image patches.
     *
     * bytes is the size of the descriptor - can be 64, 32, 16, 8, 4, 2 or 1
     * rotationInvariance - whether or not the descriptor should compansate for orientation changes.
     * half_ssd_size - the size of half of the mini-patches size. For example, if we would like to compare triplets of patches of size 7x7x
     *     then the half_ssd_size should be (7-1)/2 = 3.
     * sigma - sigma value for GaussianBlur smoothing of the source image. Source image will be used without smoothing in case sigma value is 0.
     *
     * Note: the descriptor can be coupled with any keypoint extractor. The only demand is that if you use set rotationInvariance = True then
     *     you will have to use an extractor which estimates the patch orientation (in degrees). Examples for such extractors are ORB and SIFT.
     *
     * Note: a complete example can be found under /samples/cpp/tutorial_code/xfeatures2D/latch_match.cpp
     */

    public class LATCH : Feature2D
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
                        xfeatures2d_LATCH_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LATCH(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LATCH __fromPtr__(IntPtr addr) { return new LATCH(addr); }

        //
        // C++: static Ptr_LATCH cv::xfeatures2d::LATCH::create(int bytes = 32, bool rotationInvariance = true, int half_ssd_size = 3, double sigma = 2.0)
        //

        public static LATCH create(int bytes, bool rotationInvariance, int half_ssd_size, double sigma)
        {


            return LATCH.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_LATCH_create_10(bytes, rotationInvariance, half_ssd_size, sigma)));


        }

        public static LATCH create(int bytes, bool rotationInvariance, int half_ssd_size)
        {


            return LATCH.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_LATCH_create_11(bytes, rotationInvariance, half_ssd_size)));


        }

        public static LATCH create(int bytes, bool rotationInvariance)
        {


            return LATCH.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_LATCH_create_12(bytes, rotationInvariance)));


        }

        public static LATCH create(int bytes)
        {


            return LATCH.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_LATCH_create_13(bytes)));


        }

        public static LATCH create()
        {


            return LATCH.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_LATCH_create_14()));


        }


        //
        // C++:  void cv::xfeatures2d::LATCH::setBytes(int bytes)
        //

        public void setBytes(int bytes)
        {
            ThrowIfDisposed();

            xfeatures2d_LATCH_setBytes_10(nativeObj, bytes);


        }


        //
        // C++:  int cv::xfeatures2d::LATCH::getBytes()
        //

        public int getBytes()
        {
            ThrowIfDisposed();

            return xfeatures2d_LATCH_getBytes_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::LATCH::setRotationInvariance(bool rotationInvariance)
        //

        public void setRotationInvariance(bool rotationInvariance)
        {
            ThrowIfDisposed();

            xfeatures2d_LATCH_setRotationInvariance_10(nativeObj, rotationInvariance);


        }


        //
        // C++:  bool cv::xfeatures2d::LATCH::getRotationInvariance()
        //

        public bool getRotationInvariance()
        {
            ThrowIfDisposed();

            return xfeatures2d_LATCH_getRotationInvariance_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::LATCH::setHalfSSDsize(int half_ssd_size)
        //

        public void setHalfSSDsize(int half_ssd_size)
        {
            ThrowIfDisposed();

            xfeatures2d_LATCH_setHalfSSDsize_10(nativeObj, half_ssd_size);


        }


        //
        // C++:  int cv::xfeatures2d::LATCH::getHalfSSDsize()
        //

        public int getHalfSSDsize()
        {
            ThrowIfDisposed();

            return xfeatures2d_LATCH_getHalfSSDsize_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::LATCH::setSigma(double sigma)
        //

        public void setSigma(double sigma)
        {
            ThrowIfDisposed();

            xfeatures2d_LATCH_setSigma_10(nativeObj, sigma);


        }


        //
        // C++:  double cv::xfeatures2d::LATCH::getSigma()
        //

        public double getSigma()
        {
            ThrowIfDisposed();

            return xfeatures2d_LATCH_getSigma_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::LATCH::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_LATCH_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_LATCH cv::xfeatures2d::LATCH::create(int bytes = 32, bool rotationInvariance = true, int half_ssd_size = 3, double sigma = 2.0)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_10(int bytes, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance, int half_ssd_size, double sigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_11(int bytes, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance, int half_ssd_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_12(int bytes, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_13(int bytes);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_14();

        // C++:  void cv::xfeatures2d::LATCH::setBytes(int bytes)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_setBytes_10(IntPtr nativeObj, int bytes);

        // C++:  int cv::xfeatures2d::LATCH::getBytes()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_LATCH_getBytes_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::LATCH::setRotationInvariance(bool rotationInvariance)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_setRotationInvariance_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance);

        // C++:  bool cv::xfeatures2d::LATCH::getRotationInvariance()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_LATCH_getRotationInvariance_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::LATCH::setHalfSSDsize(int half_ssd_size)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_setHalfSSDsize_10(IntPtr nativeObj, int half_ssd_size);

        // C++:  int cv::xfeatures2d::LATCH::getHalfSSDsize()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_LATCH_getHalfSSDsize_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::LATCH::setSigma(double sigma)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_setSigma_10(IntPtr nativeObj, double sigma);

        // C++:  double cv::xfeatures2d::LATCH::getSigma()
        [DllImport(LIBNAME)]
        private static extern double xfeatures2d_LATCH_getSigma_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::LATCH::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_delete(IntPtr nativeObj);

    }
}
