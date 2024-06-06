
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class SimpleWB
    /**
     * A simple white balance algorithm that works by independently stretching
     *     each of the input image channels to the specified range. For increased robustness
     *     it ignores the top and bottom \(p\%\) of pixel values.
     */

    public class SimpleWB : WhiteBalancer
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
                        xphoto_SimpleWB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SimpleWB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SimpleWB __fromPtr__(IntPtr addr) { return new SimpleWB(addr); }

        //
        // C++:  float cv::xphoto::SimpleWB::getInputMin()
        //

        /**
         * Input image range minimum value
         * SEE: setInputMin
         * return automatically generated
         */
        public float getInputMin()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getInputMin_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setInputMin(float val)
        //

        /**
         *  getInputMin SEE: getInputMin
         * param val automatically generated
         */
        public void setInputMin(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setInputMin_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getInputMax()
        //

        /**
         * Input image range maximum value
         * SEE: setInputMax
         * return automatically generated
         */
        public float getInputMax()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getInputMax_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setInputMax(float val)
        //

        /**
         *  getInputMax SEE: getInputMax
         * param val automatically generated
         */
        public void setInputMax(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setInputMax_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getOutputMin()
        //

        /**
         * Output image range minimum value
         * SEE: setOutputMin
         * return automatically generated
         */
        public float getOutputMin()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getOutputMin_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setOutputMin(float val)
        //

        /**
         *  getOutputMin SEE: getOutputMin
         * param val automatically generated
         */
        public void setOutputMin(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setOutputMin_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getOutputMax()
        //

        /**
         * Output image range maximum value
         * SEE: setOutputMax
         * return automatically generated
         */
        public float getOutputMax()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getOutputMax_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setOutputMax(float val)
        //

        /**
         *  getOutputMax SEE: getOutputMax
         * param val automatically generated
         */
        public void setOutputMax(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setOutputMax_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getP()
        //

        /**
         * Percent of top/bottom values to ignore
         * SEE: setP
         * return automatically generated
         */
        public float getP()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getP_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setP(float val)
        //

        /**
         *  getP SEE: getP
         * param val automatically generated
         */
        public void setP(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setP_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::xphoto::SimpleWB::getInputMin()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMin_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setInputMin(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMin_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getInputMax()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMax_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setInputMax(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMax_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getOutputMin()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMin_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setOutputMin(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMin_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getOutputMax()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMax_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setOutputMax(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMax_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getP()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getP_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setP(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setP_10(IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_delete(IntPtr nativeObj);

    }
}
