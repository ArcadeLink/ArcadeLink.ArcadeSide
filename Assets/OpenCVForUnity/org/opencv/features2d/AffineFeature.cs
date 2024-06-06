
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class AffineFeature
    /**
     * Class for implementing the wrapper which makes detectors and extractors to be affine invariant,
     * described as ASIFT in CITE: YM11 .
     */

    public class AffineFeature : Feature2D
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
                        features2d_AffineFeature_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AffineFeature(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AffineFeature __fromPtr__(IntPtr addr) { return new AffineFeature(addr); }

        //
        // C++: static Ptr_AffineFeature cv::AffineFeature::create(Ptr_Feature2D backend, int maxTilt = 5, int minTilt = 0, float tiltStep = 1.4142135623730951f, float rotateStepBase = 72)
        //

        /**
         * param backend The detector/extractor you want to use as backend.
         *     param maxTilt The highest power index of tilt factor. 5 is used in the paper as tilt sampling range n.
         *     param minTilt The lowest power index of tilt factor. 0 is used in the paper.
         *     param tiltStep Tilt sampling step \(\delta_t\) in Algorithm 1 in the paper.
         *     param rotateStepBase Rotation sampling step factor b in Algorithm 1 in the paper.
         * return automatically generated
         */
        public static AffineFeature create(Feature2D backend, int maxTilt, int minTilt, float tiltStep, float rotateStepBase)
        {
            if (backend != null) backend.ThrowIfDisposed();

            return AffineFeature.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AffineFeature_create_10(backend.getNativeObjAddr(), maxTilt, minTilt, tiltStep, rotateStepBase)));


        }

        /**
         * param backend The detector/extractor you want to use as backend.
         *     param maxTilt The highest power index of tilt factor. 5 is used in the paper as tilt sampling range n.
         *     param minTilt The lowest power index of tilt factor. 0 is used in the paper.
         *     param tiltStep Tilt sampling step \(\delta_t\) in Algorithm 1 in the paper.
         * return automatically generated
         */
        public static AffineFeature create(Feature2D backend, int maxTilt, int minTilt, float tiltStep)
        {
            if (backend != null) backend.ThrowIfDisposed();

            return AffineFeature.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AffineFeature_create_11(backend.getNativeObjAddr(), maxTilt, minTilt, tiltStep)));


        }

        /**
         * param backend The detector/extractor you want to use as backend.
         *     param maxTilt The highest power index of tilt factor. 5 is used in the paper as tilt sampling range n.
         *     param minTilt The lowest power index of tilt factor. 0 is used in the paper.
         * return automatically generated
         */
        public static AffineFeature create(Feature2D backend, int maxTilt, int minTilt)
        {
            if (backend != null) backend.ThrowIfDisposed();

            return AffineFeature.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AffineFeature_create_12(backend.getNativeObjAddr(), maxTilt, minTilt)));


        }

        /**
         * param backend The detector/extractor you want to use as backend.
         *     param maxTilt The highest power index of tilt factor. 5 is used in the paper as tilt sampling range n.
         * return automatically generated
         */
        public static AffineFeature create(Feature2D backend, int maxTilt)
        {
            if (backend != null) backend.ThrowIfDisposed();

            return AffineFeature.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AffineFeature_create_13(backend.getNativeObjAddr(), maxTilt)));


        }

        /**
         * param backend The detector/extractor you want to use as backend.
         * return automatically generated
         */
        public static AffineFeature create(Feature2D backend)
        {
            if (backend != null) backend.ThrowIfDisposed();

            return AffineFeature.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AffineFeature_create_14(backend.getNativeObjAddr())));


        }


        //
        // C++:  void cv::AffineFeature::setViewParams(vector_float tilts, vector_float rolls)
        //

        public void setViewParams(MatOfFloat tilts, MatOfFloat rolls)
        {
            ThrowIfDisposed();
            if (tilts != null) tilts.ThrowIfDisposed();
            if (rolls != null) rolls.ThrowIfDisposed();
            Mat tilts_mat = tilts;
            Mat rolls_mat = rolls;
            features2d_AffineFeature_setViewParams_10(nativeObj, tilts_mat.nativeObj, rolls_mat.nativeObj);


        }


        //
        // C++:  void cv::AffineFeature::getViewParams(vector_float tilts, vector_float rolls)
        //

        public void getViewParams(MatOfFloat tilts, MatOfFloat rolls)
        {
            ThrowIfDisposed();
            if (tilts != null) tilts.ThrowIfDisposed();
            if (rolls != null) rolls.ThrowIfDisposed();
            Mat tilts_mat = tilts;
            Mat rolls_mat = rolls;
            features2d_AffineFeature_getViewParams_10(nativeObj, tilts_mat.nativeObj, rolls_mat.nativeObj);


        }


        //
        // C++:  String cv::AffineFeature::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_AffineFeature_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_AffineFeature cv::AffineFeature::create(Ptr_Feature2D backend, int maxTilt = 5, int minTilt = 0, float tiltStep = 1.4142135623730951f, float rotateStepBase = 72)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AffineFeature_create_10(IntPtr backend_nativeObj, int maxTilt, int minTilt, float tiltStep, float rotateStepBase);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AffineFeature_create_11(IntPtr backend_nativeObj, int maxTilt, int minTilt, float tiltStep);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AffineFeature_create_12(IntPtr backend_nativeObj, int maxTilt, int minTilt);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AffineFeature_create_13(IntPtr backend_nativeObj, int maxTilt);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AffineFeature_create_14(IntPtr backend_nativeObj);

        // C++:  void cv::AffineFeature::setViewParams(vector_float tilts, vector_float rolls)
        [DllImport(LIBNAME)]
        private static extern void features2d_AffineFeature_setViewParams_10(IntPtr nativeObj, IntPtr tilts_mat_nativeObj, IntPtr rolls_mat_nativeObj);

        // C++:  void cv::AffineFeature::getViewParams(vector_float tilts, vector_float rolls)
        [DllImport(LIBNAME)]
        private static extern void features2d_AffineFeature_getViewParams_10(IntPtr nativeObj, IntPtr tilts_mat_nativeObj, IntPtr rolls_mat_nativeObj);

        // C++:  String cv::AffineFeature::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AffineFeature_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_AffineFeature_delete(IntPtr nativeObj);

    }
}
