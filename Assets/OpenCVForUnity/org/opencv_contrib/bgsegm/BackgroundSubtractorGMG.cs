
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorGMG
    /**
     * Background Subtractor module based on the algorithm given in CITE: Gold2012 .
     *
     *  Takes a series of images and returns a sequence of mask (8UC1)
     *  images of the same size, where 255 indicates Foreground and 0 represents Background.
     *  This class implements an algorithm described in "Visual Tracking of Human Visitors under
     *  Variable-Lighting Conditions for a Responsive Audio Art Installation," A. Godbehere,
     *  A. Matsukawa, K. Goldberg, American Control Conference, Montreal, June 2012.
     */

    public class BackgroundSubtractorGMG : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorGMG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorGMG(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorGMG __fromPtr__(IntPtr addr) { return new BackgroundSubtractorGMG(addr); }

        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getMaxFeatures()
        //

        /**
         * Returns total number of distinct colors to maintain in histogram.
         * return automatically generated
         */
        public int getMaxFeatures()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getMaxFeatures_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxFeatures(int maxFeatures)
        //

        /**
         * Sets total number of distinct colors to maintain in histogram.
         * param maxFeatures automatically generated
         */
        public void setMaxFeatures(int maxFeatures)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setMaxFeatures_10(nativeObj, maxFeatures);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDefaultLearningRate()
        //

        /**
         * Returns the learning rate of the algorithm.
         *
         *     It lies between 0.0 and 1.0. It determines how quickly features are "forgotten" from
         *     histograms.
         * return automatically generated
         */
        public double getDefaultLearningRate()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getDefaultLearningRate_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDefaultLearningRate(double lr)
        //

        /**
         * Sets the learning rate of the algorithm.
         * param lr automatically generated
         */
        public void setDefaultLearningRate(double lr)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setDefaultLearningRate_10(nativeObj, lr);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getNumFrames()
        //

        /**
         * Returns the number of frames used to initialize background model.
         * return automatically generated
         */
        public int getNumFrames()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getNumFrames_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setNumFrames(int nframes)
        //

        /**
         * Sets the number of frames used to initialize background model.
         * param nframes automatically generated
         */
        public void setNumFrames(int nframes)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setNumFrames_10(nativeObj, nframes);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getQuantizationLevels()
        //

        /**
         * Returns the parameter used for quantization of color-space.
         *
         *     It is the number of discrete levels in each channel to be used in histograms.
         * return automatically generated
         */
        public int getQuantizationLevels()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getQuantizationLevels_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setQuantizationLevels(int nlevels)
        //

        /**
         * Sets the parameter used for quantization of color-space
         * param nlevels automatically generated
         */
        public void setQuantizationLevels(int nlevels)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setQuantizationLevels_10(nativeObj, nlevels);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getBackgroundPrior()
        //

        /**
         * Returns the prior probability that each individual pixel is a background pixel.
         * return automatically generated
         */
        public double getBackgroundPrior()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getBackgroundPrior_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setBackgroundPrior(double bgprior)
        //

        /**
         * Sets the prior probability that each individual pixel is a background pixel.
         * param bgprior automatically generated
         */
        public void setBackgroundPrior(double bgprior)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setBackgroundPrior_10(nativeObj, bgprior);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getSmoothingRadius()
        //

        /**
         * Returns the kernel radius used for morphological operations
         * return automatically generated
         */
        public int getSmoothingRadius()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getSmoothingRadius_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setSmoothingRadius(int radius)
        //

        /**
         * Sets the kernel radius used for morphological operations
         * param radius automatically generated
         */
        public void setSmoothingRadius(int radius)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setSmoothingRadius_10(nativeObj, radius);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDecisionThreshold()
        //

        /**
         * Returns the value of decision threshold.
         *
         *     Decision value is the value above which pixel is determined to be FG.
         * return automatically generated
         */
        public double getDecisionThreshold()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getDecisionThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDecisionThreshold(double thresh)
        //

        /**
         * Sets the value of decision threshold.
         * param thresh automatically generated
         */
        public void setDecisionThreshold(double thresh)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setDecisionThreshold_10(nativeObj, thresh);


        }


        //
        // C++:  bool cv::bgsegm::BackgroundSubtractorGMG::getUpdateBackgroundModel()
        //

        /**
         * Returns the status of background model update
         * return automatically generated
         */
        public bool getUpdateBackgroundModel()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModel_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setUpdateBackgroundModel(bool update)
        //

        /**
         * Sets the status of background model update
         * param update automatically generated
         */
        public void setUpdateBackgroundModel(bool update)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModel_10(nativeObj, update);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMinVal()
        //

        /**
         * Returns the minimum value taken on by pixels in image sequence. Usually 0.
         * return automatically generated
         */
        public double getMinVal()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getMinVal_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMinVal(double val)
        //

        /**
         * Sets the minimum value taken on by pixels in image sequence.
         * param val automatically generated
         */
        public void setMinVal(double val)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setMinVal_10(nativeObj, val);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMaxVal()
        //

        /**
         * Returns the maximum value taken on by pixels in image sequence. e.g. 1.0 or 255.
         * return automatically generated
         */
        public double getMaxVal()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorGMG_getMaxVal_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxVal(double val)
        //

        /**
         * Sets the maximum value taken on by pixels in image sequence.
         * param val automatically generated
         */
        public void setMaxVal(double val)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorGMG_setMaxVal_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getMaxFeatures()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getMaxFeatures_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxFeatures(int maxFeatures)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setMaxFeatures_10(IntPtr nativeObj, int maxFeatures);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDefaultLearningRate()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getDefaultLearningRate_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDefaultLearningRate(double lr)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setDefaultLearningRate_10(IntPtr nativeObj, double lr);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getNumFrames()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getNumFrames_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setNumFrames(int nframes)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setNumFrames_10(IntPtr nativeObj, int nframes);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getQuantizationLevels()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getQuantizationLevels_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setQuantizationLevels(int nlevels)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setQuantizationLevels_10(IntPtr nativeObj, int nlevels);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getBackgroundPrior()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getBackgroundPrior_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setBackgroundPrior(double bgprior)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setBackgroundPrior_10(IntPtr nativeObj, double bgprior);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getSmoothingRadius()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getSmoothingRadius_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setSmoothingRadius(int radius)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setSmoothingRadius_10(IntPtr nativeObj, int radius);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDecisionThreshold()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getDecisionThreshold_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDecisionThreshold(double thresh)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setDecisionThreshold_10(IntPtr nativeObj, double thresh);

        // C++:  bool cv::bgsegm::BackgroundSubtractorGMG::getUpdateBackgroundModel()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModel_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setUpdateBackgroundModel(bool update)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool update);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMinVal()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getMinVal_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMinVal(double val)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setMinVal_10(IntPtr nativeObj, double val);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMaxVal()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getMaxVal_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxVal(double val)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setMaxVal_10(IntPtr nativeObj, double val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_delete(IntPtr nativeObj);

    }
}
