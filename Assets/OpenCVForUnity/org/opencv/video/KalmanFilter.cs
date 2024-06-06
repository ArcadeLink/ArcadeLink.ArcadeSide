

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class KalmanFilter
    /**
     * Kalman filter class.
     *
     * The class implements a standard Kalman filter &lt;http://en.wikipedia.org/wiki/Kalman_filter&gt;,
     * CITE: Welch95 . However, you can modify transitionMatrix, controlMatrix, and measurementMatrix to get
     * an extended Kalman filter functionality.
     * <b>Note:</b> In C API when CvKalman\* kalmanFilter structure is not needed anymore, it should be released
     * with cvReleaseKalman(&amp;kalmanFilter)
     */

    public class KalmanFilter : DisposableOpenCVObject
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
                        video_KalmanFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal KalmanFilter(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static KalmanFilter __fromPtr__(IntPtr addr) { return new KalmanFilter(addr); }

        //
        // C++:   cv::KalmanFilter::KalmanFilter()
        //

        public KalmanFilter()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_KalmanFilter_10());


        }


        //
        // C++:   cv::KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
        //

        /**
         *
         *     param dynamParams Dimensionality of the state.
         *     param measureParams Dimensionality of the measurement.
         *     param controlParams Dimensionality of the control vector.
         *     param type Type of the created matrices that should be CV_32F or CV_64F.
         */
        public KalmanFilter(int dynamParams, int measureParams, int controlParams, int type)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_KalmanFilter_11(dynamParams, measureParams, controlParams, type));


        }

        /**
         *
         *     param dynamParams Dimensionality of the state.
         *     param measureParams Dimensionality of the measurement.
         *     param controlParams Dimensionality of the control vector.
         */
        public KalmanFilter(int dynamParams, int measureParams, int controlParams)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_KalmanFilter_12(dynamParams, measureParams, controlParams));


        }

        /**
         *
         *     param dynamParams Dimensionality of the state.
         *     param measureParams Dimensionality of the measurement.
         */
        public KalmanFilter(int dynamParams, int measureParams)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_KalmanFilter_13(dynamParams, measureParams));


        }


        //
        // C++:  Mat cv::KalmanFilter::predict(Mat control = Mat())
        //

        /**
         * Computes a predicted state.
         *
         *     param control The optional input control
         * return automatically generated
         */
        public Mat predict(Mat control)
        {
            ThrowIfDisposed();
            if (control != null) control.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_predict_10(nativeObj, control.nativeObj)));


        }

        /**
         * Computes a predicted state.
         *
         * return automatically generated
         */
        public Mat predict()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_predict_11(nativeObj)));


        }


        //
        // C++:  Mat cv::KalmanFilter::correct(Mat measurement)
        //

        /**
         * Updates the predicted state from the measurement.
         *
         *     param measurement The measured system parameters
         * return automatically generated
         */
        public Mat correct(Mat measurement)
        {
            ThrowIfDisposed();
            if (measurement != null) measurement.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_correct_10(nativeObj, measurement.nativeObj)));


        }


        //
        // C++: Mat KalmanFilter::statePre
        //

        public Mat get_statePre()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1statePre_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::statePre
        //

        public void set_statePre(Mat statePre)
        {
            ThrowIfDisposed();
            if (statePre != null) statePre.ThrowIfDisposed();

            video_KalmanFilter_set_1statePre_10(nativeObj, statePre.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::statePost
        //

        public Mat get_statePost()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1statePost_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::statePost
        //

        public void set_statePost(Mat statePost)
        {
            ThrowIfDisposed();
            if (statePost != null) statePost.ThrowIfDisposed();

            video_KalmanFilter_set_1statePost_10(nativeObj, statePost.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::transitionMatrix
        //

        public Mat get_transitionMatrix()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1transitionMatrix_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::transitionMatrix
        //

        public void set_transitionMatrix(Mat transitionMatrix)
        {
            ThrowIfDisposed();
            if (transitionMatrix != null) transitionMatrix.ThrowIfDisposed();

            video_KalmanFilter_set_1transitionMatrix_10(nativeObj, transitionMatrix.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::controlMatrix
        //

        public Mat get_controlMatrix()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1controlMatrix_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::controlMatrix
        //

        public void set_controlMatrix(Mat controlMatrix)
        {
            ThrowIfDisposed();
            if (controlMatrix != null) controlMatrix.ThrowIfDisposed();

            video_KalmanFilter_set_1controlMatrix_10(nativeObj, controlMatrix.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::measurementMatrix
        //

        public Mat get_measurementMatrix()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1measurementMatrix_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::measurementMatrix
        //

        public void set_measurementMatrix(Mat measurementMatrix)
        {
            ThrowIfDisposed();
            if (measurementMatrix != null) measurementMatrix.ThrowIfDisposed();

            video_KalmanFilter_set_1measurementMatrix_10(nativeObj, measurementMatrix.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::processNoiseCov
        //

        public Mat get_processNoiseCov()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1processNoiseCov_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::processNoiseCov
        //

        public void set_processNoiseCov(Mat processNoiseCov)
        {
            ThrowIfDisposed();
            if (processNoiseCov != null) processNoiseCov.ThrowIfDisposed();

            video_KalmanFilter_set_1processNoiseCov_10(nativeObj, processNoiseCov.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::measurementNoiseCov
        //

        public Mat get_measurementNoiseCov()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1measurementNoiseCov_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::measurementNoiseCov
        //

        public void set_measurementNoiseCov(Mat measurementNoiseCov)
        {
            ThrowIfDisposed();
            if (measurementNoiseCov != null) measurementNoiseCov.ThrowIfDisposed();

            video_KalmanFilter_set_1measurementNoiseCov_10(nativeObj, measurementNoiseCov.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::errorCovPre
        //

        public Mat get_errorCovPre()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1errorCovPre_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::errorCovPre
        //

        public void set_errorCovPre(Mat errorCovPre)
        {
            ThrowIfDisposed();
            if (errorCovPre != null) errorCovPre.ThrowIfDisposed();

            video_KalmanFilter_set_1errorCovPre_10(nativeObj, errorCovPre.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::gain
        //

        public Mat get_gain()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1gain_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::gain
        //

        public void set_gain(Mat gain)
        {
            ThrowIfDisposed();
            if (gain != null) gain.ThrowIfDisposed();

            video_KalmanFilter_set_1gain_10(nativeObj, gain.nativeObj);


        }


        //
        // C++: Mat KalmanFilter::errorCovPost
        //

        public Mat get_errorCovPost()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_KalmanFilter_get_1errorCovPost_10(nativeObj)));


        }


        //
        // C++: void KalmanFilter::errorCovPost
        //

        public void set_errorCovPost(Mat errorCovPost)
        {
            ThrowIfDisposed();
            if (errorCovPost != null) errorCovPost.ThrowIfDisposed();

            video_KalmanFilter_set_1errorCovPost_10(nativeObj, errorCovPost.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::KalmanFilter::KalmanFilter()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_10();

        // C++:   cv::KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_11(int dynamParams, int measureParams, int controlParams, int type);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_12(int dynamParams, int measureParams, int controlParams);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_13(int dynamParams, int measureParams);

        // C++:  Mat cv::KalmanFilter::predict(Mat control = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_predict_10(IntPtr nativeObj, IntPtr control_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_predict_11(IntPtr nativeObj);

        // C++:  Mat cv::KalmanFilter::correct(Mat measurement)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_correct_10(IntPtr nativeObj, IntPtr measurement_nativeObj);

        // C++: Mat KalmanFilter::statePre
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1statePre_10(IntPtr nativeObj);

        // C++: void KalmanFilter::statePre
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1statePre_10(IntPtr nativeObj, IntPtr statePre_nativeObj);

        // C++: Mat KalmanFilter::statePost
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1statePost_10(IntPtr nativeObj);

        // C++: void KalmanFilter::statePost
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1statePost_10(IntPtr nativeObj, IntPtr statePost_nativeObj);

        // C++: Mat KalmanFilter::transitionMatrix
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1transitionMatrix_10(IntPtr nativeObj);

        // C++: void KalmanFilter::transitionMatrix
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1transitionMatrix_10(IntPtr nativeObj, IntPtr transitionMatrix_nativeObj);

        // C++: Mat KalmanFilter::controlMatrix
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1controlMatrix_10(IntPtr nativeObj);

        // C++: void KalmanFilter::controlMatrix
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1controlMatrix_10(IntPtr nativeObj, IntPtr controlMatrix_nativeObj);

        // C++: Mat KalmanFilter::measurementMatrix
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1measurementMatrix_10(IntPtr nativeObj);

        // C++: void KalmanFilter::measurementMatrix
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1measurementMatrix_10(IntPtr nativeObj, IntPtr measurementMatrix_nativeObj);

        // C++: Mat KalmanFilter::processNoiseCov
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1processNoiseCov_10(IntPtr nativeObj);

        // C++: void KalmanFilter::processNoiseCov
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1processNoiseCov_10(IntPtr nativeObj, IntPtr processNoiseCov_nativeObj);

        // C++: Mat KalmanFilter::measurementNoiseCov
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1measurementNoiseCov_10(IntPtr nativeObj);

        // C++: void KalmanFilter::measurementNoiseCov
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1measurementNoiseCov_10(IntPtr nativeObj, IntPtr measurementNoiseCov_nativeObj);

        // C++: Mat KalmanFilter::errorCovPre
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1errorCovPre_10(IntPtr nativeObj);

        // C++: void KalmanFilter::errorCovPre
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1errorCovPre_10(IntPtr nativeObj, IntPtr errorCovPre_nativeObj);

        // C++: Mat KalmanFilter::gain
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1gain_10(IntPtr nativeObj);

        // C++: void KalmanFilter::gain
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1gain_10(IntPtr nativeObj, IntPtr gain_nativeObj);

        // C++: Mat KalmanFilter::errorCovPost
        [DllImport(LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1errorCovPost_10(IntPtr nativeObj);

        // C++: void KalmanFilter::errorCovPost
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_set_1errorCovPost_10(IntPtr nativeObj, IntPtr errorCovPost_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_KalmanFilter_delete(IntPtr nativeObj);

    }
}
