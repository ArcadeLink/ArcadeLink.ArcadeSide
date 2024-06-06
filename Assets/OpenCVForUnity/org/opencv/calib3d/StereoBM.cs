
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{

    // C++: class StereoBM
    /**
     * Class for computing stereo correspondence using the block matching algorithm, introduced and
     * contributed to OpenCV by K. Konolige.
     */

    public class StereoBM : StereoMatcher
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
                        calib3d_StereoBM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StereoBM(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StereoBM __fromPtr__(IntPtr addr) { return new StereoBM(addr); }

        // C++: enum <unnamed>
        public const int PREFILTER_NORMALIZED_RESPONSE = 0;
        public const int PREFILTER_XSOBEL = 1;
        //
        // C++:  int cv::StereoBM::getPreFilterType()
        //

        public int getPreFilterType()
        {
            ThrowIfDisposed();

            return calib3d_StereoBM_getPreFilterType_10(nativeObj);


        }


        //
        // C++:  void cv::StereoBM::setPreFilterType(int preFilterType)
        //

        public void setPreFilterType(int preFilterType)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setPreFilterType_10(nativeObj, preFilterType);


        }


        //
        // C++:  int cv::StereoBM::getPreFilterSize()
        //

        public int getPreFilterSize()
        {
            ThrowIfDisposed();

            return calib3d_StereoBM_getPreFilterSize_10(nativeObj);


        }


        //
        // C++:  void cv::StereoBM::setPreFilterSize(int preFilterSize)
        //

        public void setPreFilterSize(int preFilterSize)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setPreFilterSize_10(nativeObj, preFilterSize);


        }


        //
        // C++:  int cv::StereoBM::getPreFilterCap()
        //

        public int getPreFilterCap()
        {
            ThrowIfDisposed();

            return calib3d_StereoBM_getPreFilterCap_10(nativeObj);


        }


        //
        // C++:  void cv::StereoBM::setPreFilterCap(int preFilterCap)
        //

        public void setPreFilterCap(int preFilterCap)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setPreFilterCap_10(nativeObj, preFilterCap);


        }


        //
        // C++:  int cv::StereoBM::getTextureThreshold()
        //

        public int getTextureThreshold()
        {
            ThrowIfDisposed();

            return calib3d_StereoBM_getTextureThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::StereoBM::setTextureThreshold(int textureThreshold)
        //

        public void setTextureThreshold(int textureThreshold)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setTextureThreshold_10(nativeObj, textureThreshold);


        }


        //
        // C++:  int cv::StereoBM::getUniquenessRatio()
        //

        public int getUniquenessRatio()
        {
            ThrowIfDisposed();

            return calib3d_StereoBM_getUniquenessRatio_10(nativeObj);


        }


        //
        // C++:  void cv::StereoBM::setUniquenessRatio(int uniquenessRatio)
        //

        public void setUniquenessRatio(int uniquenessRatio)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setUniquenessRatio_10(nativeObj, uniquenessRatio);


        }


        //
        // C++:  int cv::StereoBM::getSmallerBlockSize()
        //

        public int getSmallerBlockSize()
        {
            ThrowIfDisposed();

            return calib3d_StereoBM_getSmallerBlockSize_10(nativeObj);


        }


        //
        // C++:  void cv::StereoBM::setSmallerBlockSize(int blockSize)
        //

        public void setSmallerBlockSize(int blockSize)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setSmallerBlockSize_10(nativeObj, blockSize);


        }


        //
        // C++:  Rect cv::StereoBM::getROI1()
        //

        public Rect getROI1()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[4];
            calib3d_StereoBM_getROI1_10(nativeObj, tmpArray);
            Rect retVal = new Rect(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::StereoBM::setROI1(Rect roi1)
        //

        public void setROI1(Rect roi1)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setROI1_10(nativeObj, roi1.x, roi1.y, roi1.width, roi1.height);


        }


        //
        // C++:  Rect cv::StereoBM::getROI2()
        //

        public Rect getROI2()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[4];
            calib3d_StereoBM_getROI2_10(nativeObj, tmpArray);
            Rect retVal = new Rect(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::StereoBM::setROI2(Rect roi2)
        //

        public void setROI2(Rect roi2)
        {
            ThrowIfDisposed();

            calib3d_StereoBM_setROI2_10(nativeObj, roi2.x, roi2.y, roi2.width, roi2.height);


        }


        //
        // C++: static Ptr_StereoBM cv::StereoBM::create(int numDisparities = 0, int blockSize = 21)
        //

        /**
         * Creates StereoBM object
         *
         *     param numDisparities the disparity search range. For each pixel algorithm will find the best
         *     disparity from 0 (default minimum disparity) to numDisparities. The search range can then be
         *     shifted by changing the minimum disparity.
         *     param blockSize the linear size of the blocks compared by the algorithm. The size should be odd
         *     (as the block is centered at the current pixel). Larger block size implies smoother, though less
         *     accurate disparity map. Smaller block size gives more detailed disparity map, but there is higher
         *     chance for algorithm to find a wrong correspondence.
         *
         *     The function create StereoBM object. You can then call StereoBM::compute() to compute disparity for
         *     a specific stereo pair.
         * return automatically generated
         */
        public static StereoBM create(int numDisparities, int blockSize)
        {


            return StereoBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoBM_create_10(numDisparities, blockSize)));


        }

        /**
         * Creates StereoBM object
         *
         *     param numDisparities the disparity search range. For each pixel algorithm will find the best
         *     disparity from 0 (default minimum disparity) to numDisparities. The search range can then be
         *     shifted by changing the minimum disparity.
         *     (as the block is centered at the current pixel). Larger block size implies smoother, though less
         *     accurate disparity map. Smaller block size gives more detailed disparity map, but there is higher
         *     chance for algorithm to find a wrong correspondence.
         *
         *     The function create StereoBM object. You can then call StereoBM::compute() to compute disparity for
         *     a specific stereo pair.
         * return automatically generated
         */
        public static StereoBM create(int numDisparities)
        {


            return StereoBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoBM_create_11(numDisparities)));


        }

        /**
         * Creates StereoBM object
         *
         *     disparity from 0 (default minimum disparity) to numDisparities. The search range can then be
         *     shifted by changing the minimum disparity.
         *     (as the block is centered at the current pixel). Larger block size implies smoother, though less
         *     accurate disparity map. Smaller block size gives more detailed disparity map, but there is higher
         *     chance for algorithm to find a wrong correspondence.
         *
         *     The function create StereoBM object. You can then call StereoBM::compute() to compute disparity for
         *     a specific stereo pair.
         * return automatically generated
         */
        public static StereoBM create()
        {


            return StereoBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoBM_create_12()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::StereoBM::getPreFilterType()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoBM_getPreFilterType_10(IntPtr nativeObj);

        // C++:  void cv::StereoBM::setPreFilterType(int preFilterType)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setPreFilterType_10(IntPtr nativeObj, int preFilterType);

        // C++:  int cv::StereoBM::getPreFilterSize()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoBM_getPreFilterSize_10(IntPtr nativeObj);

        // C++:  void cv::StereoBM::setPreFilterSize(int preFilterSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setPreFilterSize_10(IntPtr nativeObj, int preFilterSize);

        // C++:  int cv::StereoBM::getPreFilterCap()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoBM_getPreFilterCap_10(IntPtr nativeObj);

        // C++:  void cv::StereoBM::setPreFilterCap(int preFilterCap)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setPreFilterCap_10(IntPtr nativeObj, int preFilterCap);

        // C++:  int cv::StereoBM::getTextureThreshold()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoBM_getTextureThreshold_10(IntPtr nativeObj);

        // C++:  void cv::StereoBM::setTextureThreshold(int textureThreshold)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setTextureThreshold_10(IntPtr nativeObj, int textureThreshold);

        // C++:  int cv::StereoBM::getUniquenessRatio()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoBM_getUniquenessRatio_10(IntPtr nativeObj);

        // C++:  void cv::StereoBM::setUniquenessRatio(int uniquenessRatio)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setUniquenessRatio_10(IntPtr nativeObj, int uniquenessRatio);

        // C++:  int cv::StereoBM::getSmallerBlockSize()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoBM_getSmallerBlockSize_10(IntPtr nativeObj);

        // C++:  void cv::StereoBM::setSmallerBlockSize(int blockSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setSmallerBlockSize_10(IntPtr nativeObj, int blockSize);

        // C++:  Rect cv::StereoBM::getROI1()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_getROI1_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::StereoBM::setROI1(Rect roi1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setROI1_10(IntPtr nativeObj, int roi1_x, int roi1_y, int roi1_width, int roi1_height);

        // C++:  Rect cv::StereoBM::getROI2()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_getROI2_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::StereoBM::setROI2(Rect roi2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_setROI2_10(IntPtr nativeObj, int roi2_x, int roi2_y, int roi2_width, int roi2_height);

        // C++: static Ptr_StereoBM cv::StereoBM::create(int numDisparities = 0, int blockSize = 21)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoBM_create_10(int numDisparities, int blockSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoBM_create_11(int numDisparities);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoBM_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoBM_delete(IntPtr nativeObj);

    }
}
