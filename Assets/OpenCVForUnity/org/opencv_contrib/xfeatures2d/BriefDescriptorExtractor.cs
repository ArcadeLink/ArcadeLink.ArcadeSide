
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class BriefDescriptorExtractor
    /**
     * Class for computing BRIEF descriptors described in CITE: calon2010 .
     *
     * bytes legth of the descriptor in bytes, valid values are: 16, 32 (default) or 64 .
     * use_orientation sample patterns using keypoints orientation, disabled by default.
     */

    public class BriefDescriptorExtractor : Feature2D
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
                        xfeatures2d_BriefDescriptorExtractor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BriefDescriptorExtractor(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BriefDescriptorExtractor __fromPtr__(IntPtr addr) { return new BriefDescriptorExtractor(addr); }

        //
        // C++: static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
        //

        public static BriefDescriptorExtractor create(int bytes, bool use_orientation)
        {


            return BriefDescriptorExtractor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_create_10(bytes, use_orientation)));


        }

        public static BriefDescriptorExtractor create(int bytes)
        {


            return BriefDescriptorExtractor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_create_11(bytes)));


        }

        public static BriefDescriptorExtractor create()
        {


            return BriefDescriptorExtractor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_create_12()));


        }


        //
        // C++:  void cv::xfeatures2d::BriefDescriptorExtractor::setDescriptorSize(int bytes)
        //

        public void setDescriptorSize(int bytes)
        {
            ThrowIfDisposed();

            xfeatures2d_BriefDescriptorExtractor_setDescriptorSize_10(nativeObj, bytes);


        }


        //
        // C++:  int cv::xfeatures2d::BriefDescriptorExtractor::getDescriptorSize()
        //

        public int getDescriptorSize()
        {
            ThrowIfDisposed();

            return xfeatures2d_BriefDescriptorExtractor_getDescriptorSize_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::BriefDescriptorExtractor::setUseOrientation(bool use_orientation)
        //

        public void setUseOrientation(bool use_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_BriefDescriptorExtractor_setUseOrientation_10(nativeObj, use_orientation);


        }


        //
        // C++:  bool cv::xfeatures2d::BriefDescriptorExtractor::getUseOrientation()
        //

        public bool getUseOrientation()
        {
            ThrowIfDisposed();

            return xfeatures2d_BriefDescriptorExtractor_getUseOrientation_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::BriefDescriptorExtractor::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_10(int bytes, [MarshalAs(UnmanagedType.U1)] bool use_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_11(int bytes);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_12();

        // C++:  void cv::xfeatures2d::BriefDescriptorExtractor::setDescriptorSize(int bytes)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BriefDescriptorExtractor_setDescriptorSize_10(IntPtr nativeObj, int bytes);

        // C++:  int cv::xfeatures2d::BriefDescriptorExtractor::getDescriptorSize()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_BriefDescriptorExtractor_getDescriptorSize_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::BriefDescriptorExtractor::setUseOrientation(bool use_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BriefDescriptorExtractor_setUseOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_orientation);

        // C++:  bool cv::xfeatures2d::BriefDescriptorExtractor::getUseOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_BriefDescriptorExtractor_getUseOrientation_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::BriefDescriptorExtractor::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BriefDescriptorExtractor_delete(IntPtr nativeObj);

    }
}
