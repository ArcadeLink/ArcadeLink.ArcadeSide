
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class StandardCollector
    /**
     * Default predict collector
     *
     * Trace minimal distance with treshhold checking (that is default behavior for most predict logic)
     */

    public class StandardCollector : PredictCollector
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
                        face_StandardCollector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StandardCollector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StandardCollector __fromPtr__(IntPtr addr) { return new StandardCollector(addr); }

        //
        // C++:  int cv::face::StandardCollector::getMinLabel()
        //

        /**
         * Returns label with minimal distance
         * return automatically generated
         */
        public int getMinLabel()
        {
            ThrowIfDisposed();

            return face_StandardCollector_getMinLabel_10(nativeObj);


        }


        //
        // C++:  double cv::face::StandardCollector::getMinDist()
        //

        /**
         * Returns minimal distance value
         * return automatically generated
         */
        public double getMinDist()
        {
            ThrowIfDisposed();

            return face_StandardCollector_getMinDist_10(nativeObj);


        }


        //
        // C++:  vector_pair_int_and_double cv::face::StandardCollector::getResults(bool sorted = false)
        //

        // Return type 'vector_pair_int_and_double' is not supported, skipping the function


        //
        // C++: static Ptr_StandardCollector cv::face::StandardCollector::create(double threshold = DBL_MAX)
        //

        /**
         * Static constructor
         *     param threshold set threshold
         * return automatically generated
         */
        public static StandardCollector create(double threshold)
        {


            return StandardCollector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_StandardCollector_create_10(threshold)));


        }

        /**
         * Static constructor
         * return automatically generated
         */
        public static StandardCollector create()
        {


            return StandardCollector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_StandardCollector_create_11()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::face::StandardCollector::getMinLabel()
        [DllImport(LIBNAME)]
        private static extern int face_StandardCollector_getMinLabel_10(IntPtr nativeObj);

        // C++:  double cv::face::StandardCollector::getMinDist()
        [DllImport(LIBNAME)]
        private static extern double face_StandardCollector_getMinDist_10(IntPtr nativeObj);

        // C++: static Ptr_StandardCollector cv::face::StandardCollector::create(double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_StandardCollector_create_10(double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_StandardCollector_create_11();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_StandardCollector_delete(IntPtr nativeObj);

    }
}
