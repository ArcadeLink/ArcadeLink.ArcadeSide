
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class BasicFaceRecognizer


    public class BasicFaceRecognizer : FaceRecognizer
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
                        face_BasicFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BasicFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BasicFaceRecognizer __fromPtr__(IntPtr addr) { return new BasicFaceRecognizer(addr); }

        //
        // C++:  int cv::face::BasicFaceRecognizer::getNumComponents()
        //

        /**
         * SEE: setNumComponents
         * return automatically generated
         */
        public int getNumComponents()
        {
            ThrowIfDisposed();

            return face_BasicFaceRecognizer_getNumComponents_10(nativeObj);


        }


        //
        // C++:  void cv::face::BasicFaceRecognizer::setNumComponents(int val)
        //

        /**
         *  getNumComponents SEE: getNumComponents
         * param val automatically generated
         */
        public void setNumComponents(int val)
        {
            ThrowIfDisposed();

            face_BasicFaceRecognizer_setNumComponents_10(nativeObj, val);


        }


        //
        // C++:  double cv::face::BasicFaceRecognizer::getThreshold()
        //

        /**
         * SEE: setThreshold
         * return automatically generated
         */
        public double getThreshold()
        {
            ThrowIfDisposed();

            return face_BasicFaceRecognizer_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::face::BasicFaceRecognizer::setThreshold(double val)
        //

        /**
         *  getThreshold SEE: getThreshold
         * param val automatically generated
         */
        public void setThreshold(double val)
        {
            ThrowIfDisposed();

            face_BasicFaceRecognizer_setThreshold_10(nativeObj, val);


        }


        //
        // C++:  vector_Mat cv::face::BasicFaceRecognizer::getProjections()
        //

        public List<Mat> getProjections()
        {
            ThrowIfDisposed();
            List<Mat> retVal = new List<Mat>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(face_BasicFaceRecognizer_getProjections_10(nativeObj)));
            Converters.Mat_to_vector_Mat(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getLabels()
        //

        public Mat getLabels()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(face_BasicFaceRecognizer_getLabels_10(nativeObj)));


        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenValues()
        //

        public Mat getEigenValues()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(face_BasicFaceRecognizer_getEigenValues_10(nativeObj)));


        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenVectors()
        //

        public Mat getEigenVectors()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(face_BasicFaceRecognizer_getEigenVectors_10(nativeObj)));


        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getMean()
        //

        public Mat getMean()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(face_BasicFaceRecognizer_getMean_10(nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::face::BasicFaceRecognizer::getNumComponents()
        [DllImport(LIBNAME)]
        private static extern int face_BasicFaceRecognizer_getNumComponents_10(IntPtr nativeObj);

        // C++:  void cv::face::BasicFaceRecognizer::setNumComponents(int val)
        [DllImport(LIBNAME)]
        private static extern void face_BasicFaceRecognizer_setNumComponents_10(IntPtr nativeObj, int val);

        // C++:  double cv::face::BasicFaceRecognizer::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double face_BasicFaceRecognizer_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::face::BasicFaceRecognizer::setThreshold(double val)
        [DllImport(LIBNAME)]
        private static extern void face_BasicFaceRecognizer_setThreshold_10(IntPtr nativeObj, double val);

        // C++:  vector_Mat cv::face::BasicFaceRecognizer::getProjections()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getProjections_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getLabels()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getLabels_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenValues()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getEigenValues_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenVectors()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getEigenVectors_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getMean()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getMean_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_BasicFaceRecognizer_delete(IntPtr nativeObj);

    }
}
