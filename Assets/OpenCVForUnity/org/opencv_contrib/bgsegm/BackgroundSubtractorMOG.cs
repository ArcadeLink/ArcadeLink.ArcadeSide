
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorMOG
    /**
     * Gaussian Mixture-based Background/Foreground Segmentation Algorithm.
     *
     * The class implements the algorithm described in CITE: KB2001 .
     */

    public class BackgroundSubtractorMOG : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorMOG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorMOG(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorMOG __fromPtr__(IntPtr addr) { return new BackgroundSubtractorMOG(addr); }

        //
        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getHistory()
        //

        public int getHistory()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getHistory_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setHistory(int nframes)
        //

        public void setHistory(int nframes)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setHistory_10(nativeObj, nframes);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getNMixtures()
        //

        public int getNMixtures()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getNMixtures_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNMixtures(int nmix)
        //

        public void setNMixtures(int nmix)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setNMixtures_10(nativeObj, nmix);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getBackgroundRatio()
        //

        public double getBackgroundRatio()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getBackgroundRatio_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setBackgroundRatio(double backgroundRatio)
        //

        public void setBackgroundRatio(double backgroundRatio)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setBackgroundRatio_10(nativeObj, backgroundRatio);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getNoiseSigma()
        //

        public double getNoiseSigma()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getNoiseSigma_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNoiseSigma(double noiseSigma)
        //

        public void setNoiseSigma(double noiseSigma)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setNoiseSigma_10(nativeObj, noiseSigma);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getHistory()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorMOG_getHistory_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setHistory(int nframes)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setHistory_10(IntPtr nativeObj, int nframes);

        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getNMixtures()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorMOG_getNMixtures_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNMixtures(int nmix)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setNMixtures_10(IntPtr nativeObj, int nmix);

        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getBackgroundRatio()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorMOG_getBackgroundRatio_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setBackgroundRatio(double backgroundRatio)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setBackgroundRatio_10(IntPtr nativeObj, double backgroundRatio);

        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getNoiseSigma()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorMOG_getNoiseSigma_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNoiseSigma(double noiseSigma)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setNoiseSigma_10(IntPtr nativeObj, double noiseSigma);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_delete(IntPtr nativeObj);

    }
}
