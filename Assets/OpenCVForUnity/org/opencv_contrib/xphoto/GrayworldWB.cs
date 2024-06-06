
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class GrayworldWB
    /**
     * Gray-world white balance algorithm
     *
     * This algorithm scales the values of pixels based on a
     * gray-world assumption which states that the average of all channels
     * should result in a gray image.
     *
     * It adds a modification which thresholds pixels based on their
     * saturation value and only uses pixels below the provided threshold in
     * finding average pixel values.
     *
     * Saturation is calculated using the following for a 3-channel RGB image per
     * pixel I and is in the range [0, 1]:
     *
     * \( \texttt{Saturation} [I] = \frac{\textrm{max}(R,G,B) - \textrm{min}(R,G,B)
     * }{\textrm{max}(R,G,B)} \)
     *
     * A threshold of 1 means that all pixels are used to white-balance, while a
     * threshold of 0 means no pixels are used. Lower thresholds are useful in
     * white-balancing saturated images.
     *
     * Currently supports images of type REF: CV_8UC3 and REF: CV_16UC3.
     */

    public class GrayworldWB : WhiteBalancer
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
                        xphoto_GrayworldWB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GrayworldWB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GrayworldWB __fromPtr__(IntPtr addr) { return new GrayworldWB(addr); }

        //
        // C++:  float cv::xphoto::GrayworldWB::getSaturationThreshold()
        //

        /**
         * Maximum saturation for a pixel to be included in the
         *         gray-world assumption
         * SEE: setSaturationThreshold
         * return automatically generated
         */
        public float getSaturationThreshold()
        {
            ThrowIfDisposed();

            return xphoto_GrayworldWB_getSaturationThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::GrayworldWB::setSaturationThreshold(float val)
        //

        /**
         *  getSaturationThreshold SEE: getSaturationThreshold
         * param val automatically generated
         */
        public void setSaturationThreshold(float val)
        {
            ThrowIfDisposed();

            xphoto_GrayworldWB_setSaturationThreshold_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::xphoto::GrayworldWB::getSaturationThreshold()
        [DllImport(LIBNAME)]
        private static extern float xphoto_GrayworldWB_getSaturationThreshold_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::GrayworldWB::setSaturationThreshold(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_GrayworldWB_setSaturationThreshold_10(IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_GrayworldWB_delete(IntPtr nativeObj);

    }
}
