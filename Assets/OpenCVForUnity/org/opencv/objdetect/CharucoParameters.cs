

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class CharucoParameters


    public class CharucoParameters : DisposableOpenCVObject
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
                        objdetect_CharucoParameters_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CharucoParameters(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static CharucoParameters __fromPtr__(IntPtr addr) { return new CharucoParameters(addr); }

        //
        // C++:   cv::aruco::CharucoParameters::CharucoParameters()
        //

        public CharucoParameters()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoParameters_CharucoParameters_10());


        }


        //
        // C++: Mat CharucoParameters::cameraMatrix
        //

        public Mat get_cameraMatrix()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoParameters_get_1cameraMatrix_10(nativeObj)));


        }


        //
        // C++: void CharucoParameters::cameraMatrix
        //

        public void set_cameraMatrix(Mat cameraMatrix)
        {
            ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            objdetect_CharucoParameters_set_1cameraMatrix_10(nativeObj, cameraMatrix.nativeObj);


        }


        //
        // C++: Mat CharucoParameters::distCoeffs
        //

        public Mat get_distCoeffs()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoParameters_get_1distCoeffs_10(nativeObj)));


        }


        //
        // C++: void CharucoParameters::distCoeffs
        //

        public void set_distCoeffs(Mat distCoeffs)
        {
            ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();

            objdetect_CharucoParameters_set_1distCoeffs_10(nativeObj, distCoeffs.nativeObj);


        }


        //
        // C++: int CharucoParameters::minMarkers
        //

        public int get_minMarkers()
        {
            ThrowIfDisposed();

            return objdetect_CharucoParameters_get_1minMarkers_10(nativeObj);


        }


        //
        // C++: void CharucoParameters::minMarkers
        //

        public void set_minMarkers(int minMarkers)
        {
            ThrowIfDisposed();

            objdetect_CharucoParameters_set_1minMarkers_10(nativeObj, minMarkers);


        }


        //
        // C++: bool CharucoParameters::tryRefineMarkers
        //

        public bool get_tryRefineMarkers()
        {
            ThrowIfDisposed();

            return objdetect_CharucoParameters_get_1tryRefineMarkers_10(nativeObj);


        }


        //
        // C++: void CharucoParameters::tryRefineMarkers
        //

        public void set_tryRefineMarkers(bool tryRefineMarkers)
        {
            ThrowIfDisposed();

            objdetect_CharucoParameters_set_1tryRefineMarkers_10(nativeObj, tryRefineMarkers);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::CharucoParameters::CharucoParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoParameters_CharucoParameters_10();

        // C++: Mat CharucoParameters::cameraMatrix
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoParameters_get_1cameraMatrix_10(IntPtr nativeObj);

        // C++: void CharucoParameters::cameraMatrix
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoParameters_set_1cameraMatrix_10(IntPtr nativeObj, IntPtr cameraMatrix_nativeObj);

        // C++: Mat CharucoParameters::distCoeffs
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoParameters_get_1distCoeffs_10(IntPtr nativeObj);

        // C++: void CharucoParameters::distCoeffs
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoParameters_set_1distCoeffs_10(IntPtr nativeObj, IntPtr distCoeffs_nativeObj);

        // C++: int CharucoParameters::minMarkers
        [DllImport(LIBNAME)]
        private static extern int objdetect_CharucoParameters_get_1minMarkers_10(IntPtr nativeObj);

        // C++: void CharucoParameters::minMarkers
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoParameters_set_1minMarkers_10(IntPtr nativeObj, int minMarkers);

        // C++: bool CharucoParameters::tryRefineMarkers
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CharucoParameters_get_1tryRefineMarkers_10(IntPtr nativeObj);

        // C++: void CharucoParameters::tryRefineMarkers
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoParameters_set_1tryRefineMarkers_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool tryRefineMarkers);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoParameters_delete(IntPtr nativeObj);

    }
}
