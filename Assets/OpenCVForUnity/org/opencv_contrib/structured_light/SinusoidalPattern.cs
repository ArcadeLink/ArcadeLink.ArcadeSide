#if !UNITY_WEBGL

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Structured_lightModule
{

    // C++: class SinusoidalPattern
    /**
     * Class implementing Fourier transform profilometry (FTP) , phase-shifting profilometry (PSP)
     * and Fourier-assisted phase-shifting profilometry (FAPS) based on CITE: faps.
     *
     * This class generates sinusoidal patterns that can be used with FTP, PSP and FAPS.
     */

    public class SinusoidalPattern : StructuredLightPattern
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
                        structured_1light_SinusoidalPattern_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SinusoidalPattern(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SinusoidalPattern __fromPtr__(IntPtr addr) { return new SinusoidalPattern(addr); }

        //
        // C++: static Ptr_SinusoidalPattern cv::structured_light::SinusoidalPattern::create(Ptr_SinusoidalPattern_Params parameters = makePtr<SinusoidalPattern::Params>())
        //

        /**
         * Constructor.
         * param parameters SinusoidalPattern parameters SinusoidalPattern::Params: width, height of the projector and patterns parameters.
         *
         * return automatically generated
         */
        public static SinusoidalPattern create(SinusoidalPattern_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return SinusoidalPattern.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(structured_1light_SinusoidalPattern_create_10(parameters.getNativeObjAddr())));


        }

        /**
         * Constructor.
         *
         * return automatically generated
         */
        public static SinusoidalPattern create()
        {


            return SinusoidalPattern.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(structured_1light_SinusoidalPattern_create_11()));


        }


        //
        // C++:  void cv::structured_light::SinusoidalPattern::computePhaseMap(vector_Mat patternImages, Mat& wrappedPhaseMap, Mat& shadowMask = Mat(), Mat fundamental = Mat())
        //

        /**
         * Compute a wrapped phase map from sinusoidal patterns.
         * param patternImages Input data to compute the wrapped phase map.
         * param wrappedPhaseMap Wrapped phase map obtained through one of the three methods.
         * param shadowMask Mask used to discard shadow regions.
         * param fundamental Fundamental matrix used to compute epipolar lines and ease the matching step.
         */
        public void computePhaseMap(List<Mat> patternImages, Mat wrappedPhaseMap, Mat shadowMask, Mat fundamental)
        {
            ThrowIfDisposed();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed();
            if (shadowMask != null) shadowMask.ThrowIfDisposed();
            if (fundamental != null) fundamental.ThrowIfDisposed();
            Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
            structured_1light_SinusoidalPattern_computePhaseMap_10(nativeObj, patternImages_mat.nativeObj, wrappedPhaseMap.nativeObj, shadowMask.nativeObj, fundamental.nativeObj);


        }

        /**
         * Compute a wrapped phase map from sinusoidal patterns.
         * param patternImages Input data to compute the wrapped phase map.
         * param wrappedPhaseMap Wrapped phase map obtained through one of the three methods.
         * param shadowMask Mask used to discard shadow regions.
         */
        public void computePhaseMap(List<Mat> patternImages, Mat wrappedPhaseMap, Mat shadowMask)
        {
            ThrowIfDisposed();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed();
            if (shadowMask != null) shadowMask.ThrowIfDisposed();
            Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
            structured_1light_SinusoidalPattern_computePhaseMap_11(nativeObj, patternImages_mat.nativeObj, wrappedPhaseMap.nativeObj, shadowMask.nativeObj);


        }

        /**
         * Compute a wrapped phase map from sinusoidal patterns.
         * param patternImages Input data to compute the wrapped phase map.
         * param wrappedPhaseMap Wrapped phase map obtained through one of the three methods.
         */
        public void computePhaseMap(List<Mat> patternImages, Mat wrappedPhaseMap)
        {
            ThrowIfDisposed();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed();
            Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
            structured_1light_SinusoidalPattern_computePhaseMap_12(nativeObj, patternImages_mat.nativeObj, wrappedPhaseMap.nativeObj);


        }


        //
        // C++:  void cv::structured_light::SinusoidalPattern::unwrapPhaseMap(Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Size camSize, Mat shadowMask = Mat())
        //

        /**
         * Unwrap the wrapped phase map to remove phase ambiguities.
         * param wrappedPhaseMap The wrapped phase map computed from the pattern.
         * param unwrappedPhaseMap The unwrapped phase map used to find correspondences between the two devices.
         * param camSize Resolution of the camera.
         * param shadowMask Mask used to discard shadow regions.
         */
        public void unwrapPhaseMap(Mat wrappedPhaseMap, Mat unwrappedPhaseMap, Size camSize, Mat shadowMask)
        {
            ThrowIfDisposed();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed();
            if (unwrappedPhaseMap != null) unwrappedPhaseMap.ThrowIfDisposed();
            if (shadowMask != null) shadowMask.ThrowIfDisposed();

            structured_1light_SinusoidalPattern_unwrapPhaseMap_10(nativeObj, wrappedPhaseMap.nativeObj, unwrappedPhaseMap.nativeObj, camSize.width, camSize.height, shadowMask.nativeObj);


        }

        /**
         * Unwrap the wrapped phase map to remove phase ambiguities.
         * param wrappedPhaseMap The wrapped phase map computed from the pattern.
         * param unwrappedPhaseMap The unwrapped phase map used to find correspondences between the two devices.
         * param camSize Resolution of the camera.
         */
        public void unwrapPhaseMap(Mat wrappedPhaseMap, Mat unwrappedPhaseMap, Size camSize)
        {
            ThrowIfDisposed();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed();
            if (unwrappedPhaseMap != null) unwrappedPhaseMap.ThrowIfDisposed();

            structured_1light_SinusoidalPattern_unwrapPhaseMap_11(nativeObj, wrappedPhaseMap.nativeObj, unwrappedPhaseMap.nativeObj, camSize.width, camSize.height);


        }


        //
        // C++:  void cv::structured_light::SinusoidalPattern::findProCamMatches(Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, vector_Mat& matches)
        //

        /**
         * Find correspondences between the two devices thanks to unwrapped phase maps.
         * param projUnwrappedPhaseMap Projector's unwrapped phase map.
         * param camUnwrappedPhaseMap Camera's unwrapped phase map.
         * param matches Images used to display correspondences map.
         */
        public void findProCamMatches(Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, List<Mat> matches)
        {
            ThrowIfDisposed();
            if (projUnwrappedPhaseMap != null) projUnwrappedPhaseMap.ThrowIfDisposed();
            if (camUnwrappedPhaseMap != null) camUnwrappedPhaseMap.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            structured_1light_SinusoidalPattern_findProCamMatches_10(nativeObj, projUnwrappedPhaseMap.nativeObj, camUnwrappedPhaseMap.nativeObj, matches_mat.nativeObj);
            Converters.Mat_to_vector_Mat(matches_mat, matches);
            matches_mat.release();

        }


        //
        // C++:  void cv::structured_light::SinusoidalPattern::computeDataModulationTerm(vector_Mat patternImages, Mat& dataModulationTerm, Mat shadowMask)
        //

        /**
         * compute the data modulation term.
         * param patternImages captured images with projected patterns.
         * param dataModulationTerm Mat where the data modulation term is saved.
         * param shadowMask Mask used to discard shadow regions.
         */
        public void computeDataModulationTerm(List<Mat> patternImages, Mat dataModulationTerm, Mat shadowMask)
        {
            ThrowIfDisposed();
            if (dataModulationTerm != null) dataModulationTerm.ThrowIfDisposed();
            if (shadowMask != null) shadowMask.ThrowIfDisposed();
            Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
            structured_1light_SinusoidalPattern_computeDataModulationTerm_10(nativeObj, patternImages_mat.nativeObj, dataModulationTerm.nativeObj, shadowMask.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_SinusoidalPattern cv::structured_light::SinusoidalPattern::create(Ptr_SinusoidalPattern_Params parameters = makePtr<SinusoidalPattern::Params>())
        [DllImport(LIBNAME)]
        private static extern IntPtr structured_1light_SinusoidalPattern_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr structured_1light_SinusoidalPattern_create_11();

        // C++:  void cv::structured_light::SinusoidalPattern::computePhaseMap(vector_Mat patternImages, Mat& wrappedPhaseMap, Mat& shadowMask = Mat(), Mat fundamental = Mat())
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computePhaseMap_10(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr shadowMask_nativeObj, IntPtr fundamental_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computePhaseMap_11(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr shadowMask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computePhaseMap_12(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr wrappedPhaseMap_nativeObj);

        // C++:  void cv::structured_light::SinusoidalPattern::unwrapPhaseMap(Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Size camSize, Mat shadowMask = Mat())
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_unwrapPhaseMap_10(IntPtr nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr unwrappedPhaseMap_nativeObj, double camSize_width, double camSize_height, IntPtr shadowMask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_unwrapPhaseMap_11(IntPtr nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr unwrappedPhaseMap_nativeObj, double camSize_width, double camSize_height);

        // C++:  void cv::structured_light::SinusoidalPattern::findProCamMatches(Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, vector_Mat& matches)
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_findProCamMatches_10(IntPtr nativeObj, IntPtr projUnwrappedPhaseMap_nativeObj, IntPtr camUnwrappedPhaseMap_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void cv::structured_light::SinusoidalPattern::computeDataModulationTerm(vector_Mat patternImages, Mat& dataModulationTerm, Mat shadowMask)
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computeDataModulationTerm_10(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr dataModulationTerm_nativeObj, IntPtr shadowMask_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_delete(IntPtr nativeObj);

    }
}

#endif