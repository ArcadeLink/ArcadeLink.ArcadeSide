
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class BackgroundSubtractorKNN
    /**
     * K-nearest neighbours - based Background/Foreground Segmentation Algorithm.
     *
     * The class implements the K-nearest neighbours background subtraction described in CITE: Zivkovic2006 .
     * Very efficient if number of foreground pixels is low.
     */

    public class BackgroundSubtractorKNN : BackgroundSubtractor
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
                        video_BackgroundSubtractorKNN_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorKNN(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorKNN __fromPtr__(IntPtr addr) { return new BackgroundSubtractorKNN(addr); }

        //
        // C++:  int cv::BackgroundSubtractorKNN::getHistory()
        //

        /**
         * Returns the number of last frames that affect the background model
         * return automatically generated
         */
        public int getHistory()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getHistory_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setHistory(int history)
        //

        /**
         * Sets the number of last frames that affect the background model
         * param history automatically generated
         */
        public void setHistory(int history)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setHistory_10(nativeObj, history);


        }


        //
        // C++:  int cv::BackgroundSubtractorKNN::getNSamples()
        //

        /**
         * Returns the number of data samples in the background model
         * return automatically generated
         */
        public int getNSamples()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getNSamples_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setNSamples(int _nN)
        //

        /**
         * Sets the number of data samples in the background model.
         *
         *     The model needs to be reinitalized to reserve memory.
         * param _nN automatically generated
         */
        public void setNSamples(int _nN)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setNSamples_10(nativeObj, _nN);


        }


        //
        // C++:  double cv::BackgroundSubtractorKNN::getDist2Threshold()
        //

        /**
         * Returns the threshold on the squared distance between the pixel and the sample
         *
         *     The threshold on the squared distance between the pixel and the sample to decide whether a pixel is
         *     close to a data sample.
         * return automatically generated
         */
        public double getDist2Threshold()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getDist2Threshold_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setDist2Threshold(double _dist2Threshold)
        //

        /**
         * Sets the threshold on the squared distance
         * param _dist2Threshold automatically generated
         */
        public void setDist2Threshold(double _dist2Threshold)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setDist2Threshold_10(nativeObj, _dist2Threshold);


        }


        //
        // C++:  int cv::BackgroundSubtractorKNN::getkNNSamples()
        //

        /**
         * Returns the number of neighbours, the k in the kNN.
         *
         *     K is the number of samples that need to be within dist2Threshold in order to decide that that
         *     pixel is matching the kNN background model.
         * return automatically generated
         */
        public int getkNNSamples()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getkNNSamples_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setkNNSamples(int _nkNN)
        //

        /**
         * Sets the k in the kNN. How many nearest neighbours need to match.
         * param _nkNN automatically generated
         */
        public void setkNNSamples(int _nkNN)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setkNNSamples_10(nativeObj, _nkNN);


        }


        //
        // C++:  bool cv::BackgroundSubtractorKNN::getDetectShadows()
        //

        /**
         * Returns the shadow detection flag
         *
         *     If true, the algorithm detects shadows and marks them. See createBackgroundSubtractorKNN for
         *     details.
         * return automatically generated
         */
        public bool getDetectShadows()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getDetectShadows_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setDetectShadows(bool detectShadows)
        //

        /**
         * Enables or disables shadow detection
         * param detectShadows automatically generated
         */
        public void setDetectShadows(bool detectShadows)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setDetectShadows_10(nativeObj, detectShadows);


        }


        //
        // C++:  int cv::BackgroundSubtractorKNN::getShadowValue()
        //

        /**
         * Returns the shadow value
         *
         *     Shadow value is the value used to mark shadows in the foreground mask. Default value is 127. Value 0
         *     in the mask always means background, 255 means foreground.
         * return automatically generated
         */
        public int getShadowValue()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getShadowValue_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setShadowValue(int value)
        //

        /**
         * Sets the shadow value
         * param value automatically generated
         */
        public void setShadowValue(int value)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setShadowValue_10(nativeObj, value);


        }


        //
        // C++:  double cv::BackgroundSubtractorKNN::getShadowThreshold()
        //

        /**
         * Returns the shadow threshold
         *
         *     A shadow is detected if pixel is a darker version of the background. The shadow threshold (Tau in
         *     the paper) is a threshold defining how much darker the shadow can be. Tau= 0.5 means that if a pixel
         *     is more than twice darker then it is not shadow. See Prati, Mikic, Trivedi and Cucchiara,
         * Detecting Moving Shadows...*, IEEE PAMI,2003.
         * return automatically generated
         */
        public double getShadowThreshold()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorKNN_getShadowThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorKNN::setShadowThreshold(double threshold)
        //

        /**
         * Sets the shadow threshold
         * param threshold automatically generated
         */
        public void setShadowThreshold(double threshold)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorKNN_setShadowThreshold_10(nativeObj, threshold);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::BackgroundSubtractorKNN::getHistory()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getHistory_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setHistory(int history)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setHistory_10(IntPtr nativeObj, int history);

        // C++:  int cv::BackgroundSubtractorKNN::getNSamples()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getNSamples_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setNSamples(int _nN)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setNSamples_10(IntPtr nativeObj, int _nN);

        // C++:  double cv::BackgroundSubtractorKNN::getDist2Threshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorKNN_getDist2Threshold_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setDist2Threshold(double _dist2Threshold)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setDist2Threshold_10(IntPtr nativeObj, double _dist2Threshold);

        // C++:  int cv::BackgroundSubtractorKNN::getkNNSamples()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getkNNSamples_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setkNNSamples(int _nkNN)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setkNNSamples_10(IntPtr nativeObj, int _nkNN);

        // C++:  bool cv::BackgroundSubtractorKNN::getDetectShadows()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_BackgroundSubtractorKNN_getDetectShadows_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setDetectShadows(bool detectShadows)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setDetectShadows_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool detectShadows);

        // C++:  int cv::BackgroundSubtractorKNN::getShadowValue()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getShadowValue_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setShadowValue(int value)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setShadowValue_10(IntPtr nativeObj, int value);

        // C++:  double cv::BackgroundSubtractorKNN::getShadowThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorKNN_getShadowThreshold_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorKNN::setShadowThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setShadowThreshold_10(IntPtr nativeObj, double threshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_delete(IntPtr nativeObj);

    }
}
