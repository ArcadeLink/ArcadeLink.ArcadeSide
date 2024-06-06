
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class GeneralizedHoughBallard
    /**
     * finds arbitrary template in the grayscale image using Generalized Hough Transform
     *
     * Detects position only without translation and rotation CITE: Ballard1981 .
     */

    public class GeneralizedHoughBallard : GeneralizedHough
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
                        imgproc_GeneralizedHoughBallard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GeneralizedHoughBallard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GeneralizedHoughBallard __fromPtr__(IntPtr addr) { return new GeneralizedHoughBallard(addr); }

        //
        // C++:  void cv::GeneralizedHoughBallard::setLevels(int levels)
        //

        public void setLevels(int levels)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughBallard_setLevels_10(nativeObj, levels);


        }


        //
        // C++:  int cv::GeneralizedHoughBallard::getLevels()
        //

        public int getLevels()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughBallard_getLevels_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughBallard::setVotesThreshold(int votesThreshold)
        //

        public void setVotesThreshold(int votesThreshold)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughBallard_setVotesThreshold_10(nativeObj, votesThreshold);


        }


        //
        // C++:  int cv::GeneralizedHoughBallard::getVotesThreshold()
        //

        public int getVotesThreshold()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughBallard_getVotesThreshold_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::GeneralizedHoughBallard::setLevels(int levels)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughBallard_setLevels_10(IntPtr nativeObj, int levels);

        // C++:  int cv::GeneralizedHoughBallard::getLevels()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughBallard_getLevels_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughBallard::setVotesThreshold(int votesThreshold)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughBallard_setVotesThreshold_10(IntPtr nativeObj, int votesThreshold);

        // C++:  int cv::GeneralizedHoughBallard::getVotesThreshold()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughBallard_getVotesThreshold_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughBallard_delete(IntPtr nativeObj);

    }
}
