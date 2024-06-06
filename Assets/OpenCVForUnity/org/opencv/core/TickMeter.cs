

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.CoreModule
{
    // C++: class TickMeter
    /**
     * a Class to measure passing time.
     *
     * The class computes passing time by counting the number of ticks per second. That is, the following code computes the
     * execution time in seconds:
     * SNIPPET: snippets/core_various.cpp TickMeter_total
     *
     * It is also possible to compute the average time over multiple runs:
     * SNIPPET: snippets/core_various.cpp TickMeter_average
     *
     * SEE: getTickCount, getTickFrequency
     */

    public class TickMeter : DisposableOpenCVObject
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
                        core_TickMeter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TickMeter(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TickMeter __fromPtr__(IntPtr addr) { return new TickMeter(addr); }

        //
        // C++:   cv::TickMeter::TickMeter()
        //

        public TickMeter()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(core_TickMeter_TickMeter_10());


        }


        //
        // C++:  void cv::TickMeter::start()
        //

        public void start()
        {
            ThrowIfDisposed();

            core_TickMeter_start_10(nativeObj);


        }


        //
        // C++:  void cv::TickMeter::stop()
        //

        public void stop()
        {
            ThrowIfDisposed();

            core_TickMeter_stop_10(nativeObj);


        }


        //
        // C++:  int64 cv::TickMeter::getTimeTicks()
        //

        public long getTimeTicks()
        {
            ThrowIfDisposed();

            return core_TickMeter_getTimeTicks_10(nativeObj);


        }


        //
        // C++:  double cv::TickMeter::getTimeMicro()
        //

        public double getTimeMicro()
        {
            ThrowIfDisposed();

            return core_TickMeter_getTimeMicro_10(nativeObj);


        }


        //
        // C++:  double cv::TickMeter::getTimeMilli()
        //

        public double getTimeMilli()
        {
            ThrowIfDisposed();

            return core_TickMeter_getTimeMilli_10(nativeObj);


        }


        //
        // C++:  double cv::TickMeter::getTimeSec()
        //

        public double getTimeSec()
        {
            ThrowIfDisposed();

            return core_TickMeter_getTimeSec_10(nativeObj);


        }


        //
        // C++:  int64 cv::TickMeter::getCounter()
        //

        public long getCounter()
        {
            ThrowIfDisposed();

            return core_TickMeter_getCounter_10(nativeObj);


        }


        //
        // C++:  double cv::TickMeter::getFPS()
        //

        public double getFPS()
        {
            ThrowIfDisposed();

            return core_TickMeter_getFPS_10(nativeObj);


        }


        //
        // C++:  double cv::TickMeter::getAvgTimeSec()
        //

        public double getAvgTimeSec()
        {
            ThrowIfDisposed();

            return core_TickMeter_getAvgTimeSec_10(nativeObj);


        }


        //
        // C++:  double cv::TickMeter::getAvgTimeMilli()
        //

        public double getAvgTimeMilli()
        {
            ThrowIfDisposed();

            return core_TickMeter_getAvgTimeMilli_10(nativeObj);


        }


        //
        // C++:  void cv::TickMeter::reset()
        //

        public void reset()
        {
            ThrowIfDisposed();

            core_TickMeter_reset_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TickMeter::TickMeter()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_TickMeter_TickMeter_10();

        // C++:  void cv::TickMeter::start()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_start_10(IntPtr nativeObj);

        // C++:  void cv::TickMeter::stop()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_stop_10(IntPtr nativeObj);

        // C++:  int64 cv::TickMeter::getTimeTicks()
        [DllImport(LIBNAME)]
        private static extern long core_TickMeter_getTimeTicks_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getTimeMicro()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getTimeMicro_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getTimeMilli()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getTimeMilli_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getTimeSec()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getTimeSec_10(IntPtr nativeObj);

        // C++:  int64 cv::TickMeter::getCounter()
        [DllImport(LIBNAME)]
        private static extern long core_TickMeter_getCounter_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getFPS()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getFPS_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getAvgTimeSec()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getAvgTimeSec_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getAvgTimeMilli()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getAvgTimeMilli_10(IntPtr nativeObj);

        // C++:  void cv::TickMeter::reset()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_reset_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_delete(IntPtr nativeObj);

    }
}
