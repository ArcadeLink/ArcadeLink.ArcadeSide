

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{
    // C++: class ParamGrid
    /**
     * The structure represents the logarithmic grid range of statmodel parameters.
     *
     * It is used for optimizing statmodel accuracy by varying model parameters, the accuracy estimate
     * being computed by cross-validation.
     */

    public class ParamGrid : DisposableOpenCVObject
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
                        ml_ParamGrid_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ParamGrid(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static ParamGrid __fromPtr__(IntPtr addr) { return new ParamGrid(addr); }

        //
        // C++: static Ptr_ParamGrid cv::ml::ParamGrid::create(double minVal = 0., double maxVal = 0., double logstep = 1.)
        //

        /**
         * Creates a ParamGrid Ptr that can be given to the %SVM::trainAuto method
         *
         *     param minVal minimum value of the parameter grid
         *     param maxVal maximum value of the parameter grid
         *     param logstep Logarithmic step for iterating the statmodel parameter
         * return automatically generated
         */
        public static ParamGrid create(double minVal, double maxVal, double logstep)
        {


            return ParamGrid.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_ParamGrid_create_10(minVal, maxVal, logstep)));


        }

        /**
         * Creates a ParamGrid Ptr that can be given to the %SVM::trainAuto method
         *
         *     param minVal minimum value of the parameter grid
         *     param maxVal maximum value of the parameter grid
         * return automatically generated
         */
        public static ParamGrid create(double minVal, double maxVal)
        {


            return ParamGrid.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_ParamGrid_create_11(minVal, maxVal)));


        }

        /**
         * Creates a ParamGrid Ptr that can be given to the %SVM::trainAuto method
         *
         *     param minVal minimum value of the parameter grid
         * return automatically generated
         */
        public static ParamGrid create(double minVal)
        {


            return ParamGrid.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_ParamGrid_create_12(minVal)));


        }

        /**
         * Creates a ParamGrid Ptr that can be given to the %SVM::trainAuto method
         *
         * return automatically generated
         */
        public static ParamGrid create()
        {


            return ParamGrid.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_ParamGrid_create_13()));


        }


        //
        // C++: double ParamGrid::minVal
        //

        public double get_minVal()
        {
            ThrowIfDisposed();

            return ml_ParamGrid_get_1minVal_10(nativeObj);


        }


        //
        // C++: void ParamGrid::minVal
        //

        public void set_minVal(double minVal)
        {
            ThrowIfDisposed();

            ml_ParamGrid_set_1minVal_10(nativeObj, minVal);


        }


        //
        // C++: double ParamGrid::maxVal
        //

        public double get_maxVal()
        {
            ThrowIfDisposed();

            return ml_ParamGrid_get_1maxVal_10(nativeObj);


        }


        //
        // C++: void ParamGrid::maxVal
        //

        public void set_maxVal(double maxVal)
        {
            ThrowIfDisposed();

            ml_ParamGrid_set_1maxVal_10(nativeObj, maxVal);


        }


        //
        // C++: double ParamGrid::logStep
        //

        public double get_logStep()
        {
            ThrowIfDisposed();

            return ml_ParamGrid_get_1logStep_10(nativeObj);


        }


        //
        // C++: void ParamGrid::logStep
        //

        public void set_logStep(double logStep)
        {
            ThrowIfDisposed();

            ml_ParamGrid_set_1logStep_10(nativeObj, logStep);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_ParamGrid cv::ml::ParamGrid::create(double minVal = 0., double maxVal = 0., double logstep = 1.)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ParamGrid_create_10(double minVal, double maxVal, double logstep);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ParamGrid_create_11(double minVal, double maxVal);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ParamGrid_create_12(double minVal);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ParamGrid_create_13();

        // C++: double ParamGrid::minVal
        [DllImport(LIBNAME)]
        private static extern double ml_ParamGrid_get_1minVal_10(IntPtr nativeObj);

        // C++: void ParamGrid::minVal
        [DllImport(LIBNAME)]
        private static extern void ml_ParamGrid_set_1minVal_10(IntPtr nativeObj, double minVal);

        // C++: double ParamGrid::maxVal
        [DllImport(LIBNAME)]
        private static extern double ml_ParamGrid_get_1maxVal_10(IntPtr nativeObj);

        // C++: void ParamGrid::maxVal
        [DllImport(LIBNAME)]
        private static extern void ml_ParamGrid_set_1maxVal_10(IntPtr nativeObj, double maxVal);

        // C++: double ParamGrid::logStep
        [DllImport(LIBNAME)]
        private static extern double ml_ParamGrid_get_1logStep_10(IntPtr nativeObj);

        // C++: void ParamGrid::logStep
        [DllImport(LIBNAME)]
        private static extern void ml_ParamGrid_set_1logStep_10(IntPtr nativeObj, double logStep);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_ParamGrid_delete(IntPtr nativeObj);

    }
}
