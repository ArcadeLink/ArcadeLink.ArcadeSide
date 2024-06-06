
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class GeneralizedHoughGuil
    /**
     * finds arbitrary template in the grayscale image using Generalized Hough Transform
     *
     * Detects position, translation and rotation CITE: Guil1999 .
     */

    public class GeneralizedHoughGuil : GeneralizedHough
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
                        imgproc_GeneralizedHoughGuil_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GeneralizedHoughGuil(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GeneralizedHoughGuil __fromPtr__(IntPtr addr) { return new GeneralizedHoughGuil(addr); }

        //
        // C++:  void cv::GeneralizedHoughGuil::setXi(double xi)
        //

        public void setXi(double xi)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setXi_10(nativeObj, xi);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getXi()
        //

        public double getXi()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getXi_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setLevels(int levels)
        //

        public void setLevels(int levels)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setLevels_10(nativeObj, levels);


        }


        //
        // C++:  int cv::GeneralizedHoughGuil::getLevels()
        //

        public int getLevels()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getLevels_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setAngleEpsilon(double angleEpsilon)
        //

        public void setAngleEpsilon(double angleEpsilon)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setAngleEpsilon_10(nativeObj, angleEpsilon);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getAngleEpsilon()
        //

        public double getAngleEpsilon()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getAngleEpsilon_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setMinAngle(double minAngle)
        //

        public void setMinAngle(double minAngle)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setMinAngle_10(nativeObj, minAngle);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getMinAngle()
        //

        public double getMinAngle()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getMinAngle_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setMaxAngle(double maxAngle)
        //

        public void setMaxAngle(double maxAngle)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setMaxAngle_10(nativeObj, maxAngle);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getMaxAngle()
        //

        public double getMaxAngle()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getMaxAngle_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setAngleStep(double angleStep)
        //

        public void setAngleStep(double angleStep)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setAngleStep_10(nativeObj, angleStep);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getAngleStep()
        //

        public double getAngleStep()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getAngleStep_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setAngleThresh(int angleThresh)
        //

        public void setAngleThresh(int angleThresh)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setAngleThresh_10(nativeObj, angleThresh);


        }


        //
        // C++:  int cv::GeneralizedHoughGuil::getAngleThresh()
        //

        public int getAngleThresh()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getAngleThresh_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setMinScale(double minScale)
        //

        public void setMinScale(double minScale)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setMinScale_10(nativeObj, minScale);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getMinScale()
        //

        public double getMinScale()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getMinScale_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setMaxScale(double maxScale)
        //

        public void setMaxScale(double maxScale)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setMaxScale_10(nativeObj, maxScale);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getMaxScale()
        //

        public double getMaxScale()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getMaxScale_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setScaleStep(double scaleStep)
        //

        public void setScaleStep(double scaleStep)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setScaleStep_10(nativeObj, scaleStep);


        }


        //
        // C++:  double cv::GeneralizedHoughGuil::getScaleStep()
        //

        public double getScaleStep()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getScaleStep_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setScaleThresh(int scaleThresh)
        //

        public void setScaleThresh(int scaleThresh)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setScaleThresh_10(nativeObj, scaleThresh);


        }


        //
        // C++:  int cv::GeneralizedHoughGuil::getScaleThresh()
        //

        public int getScaleThresh()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getScaleThresh_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHoughGuil::setPosThresh(int posThresh)
        //

        public void setPosThresh(int posThresh)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHoughGuil_setPosThresh_10(nativeObj, posThresh);


        }


        //
        // C++:  int cv::GeneralizedHoughGuil::getPosThresh()
        //

        public int getPosThresh()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHoughGuil_getPosThresh_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::GeneralizedHoughGuil::setXi(double xi)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setXi_10(IntPtr nativeObj, double xi);

        // C++:  double cv::GeneralizedHoughGuil::getXi()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getXi_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setLevels(int levels)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setLevels_10(IntPtr nativeObj, int levels);

        // C++:  int cv::GeneralizedHoughGuil::getLevels()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughGuil_getLevels_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setAngleEpsilon(double angleEpsilon)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setAngleEpsilon_10(IntPtr nativeObj, double angleEpsilon);

        // C++:  double cv::GeneralizedHoughGuil::getAngleEpsilon()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getAngleEpsilon_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setMinAngle(double minAngle)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setMinAngle_10(IntPtr nativeObj, double minAngle);

        // C++:  double cv::GeneralizedHoughGuil::getMinAngle()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getMinAngle_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setMaxAngle(double maxAngle)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setMaxAngle_10(IntPtr nativeObj, double maxAngle);

        // C++:  double cv::GeneralizedHoughGuil::getMaxAngle()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getMaxAngle_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setAngleStep(double angleStep)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setAngleStep_10(IntPtr nativeObj, double angleStep);

        // C++:  double cv::GeneralizedHoughGuil::getAngleStep()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getAngleStep_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setAngleThresh(int angleThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setAngleThresh_10(IntPtr nativeObj, int angleThresh);

        // C++:  int cv::GeneralizedHoughGuil::getAngleThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughGuil_getAngleThresh_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setMinScale(double minScale)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setMinScale_10(IntPtr nativeObj, double minScale);

        // C++:  double cv::GeneralizedHoughGuil::getMinScale()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getMinScale_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setMaxScale(double maxScale)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setMaxScale_10(IntPtr nativeObj, double maxScale);

        // C++:  double cv::GeneralizedHoughGuil::getMaxScale()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getMaxScale_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setScaleStep(double scaleStep)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setScaleStep_10(IntPtr nativeObj, double scaleStep);

        // C++:  double cv::GeneralizedHoughGuil::getScaleStep()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHoughGuil_getScaleStep_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setScaleThresh(int scaleThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setScaleThresh_10(IntPtr nativeObj, int scaleThresh);

        // C++:  int cv::GeneralizedHoughGuil::getScaleThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughGuil_getScaleThresh_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughGuil::setPosThresh(int posThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_setPosThresh_10(IntPtr nativeObj, int posThresh);

        // C++:  int cv::GeneralizedHoughGuil::getPosThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughGuil_getPosThresh_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughGuil_delete(IntPtr nativeObj);

    }
}
