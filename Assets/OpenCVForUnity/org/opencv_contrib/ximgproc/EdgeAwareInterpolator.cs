
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class EdgeAwareInterpolator
    /**
     * Sparse match interpolation algorithm based on modified locally-weighted affine
     * estimator from CITE: Revaud2015 and Fast Global Smoother as post-processing filter.
     */

    public class EdgeAwareInterpolator : SparseMatchInterpolator
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
                        ximgproc_EdgeAwareInterpolator_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EdgeAwareInterpolator(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EdgeAwareInterpolator __fromPtr__(IntPtr addr) { return new EdgeAwareInterpolator(addr); }

        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setCostMap(Mat _costMap)
        //

        /**
         * Interface to provide a more elaborated cost map, i.e. edge map, for the edge-aware term.
         * This implementation is based on a rather simple gradient-based edge map estimation.
         * To used more complex edge map estimator (e.g. StructuredEdgeDetection that has been
         * used in the original publication) that may lead to improved accuracies, the internal
         * edge map estimation can be bypassed here.
         * param _costMap a type CV_32FC1 Mat is required.
         * SEE: cv::ximgproc::createSuperpixelSLIC
         */
        public void setCostMap(Mat _costMap)
        {
            ThrowIfDisposed();
            if (_costMap != null) _costMap.ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setCostMap_10(nativeObj, _costMap.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setK(int _k)
        //

        /**
         * K is a number of nearest-neighbor matches considered, when fitting a locally affine
         *     model. Usually it should be around 128. However, lower values would make the interpolation
         *     noticeably faster.
         * param _k automatically generated
         */
        public void setK(int _k)
        {
            ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setK_10(nativeObj, _k);


        }


        //
        // C++:  int cv::ximgproc::EdgeAwareInterpolator::getK()
        //

        /**
         * SEE: setK
         * return automatically generated
         */
        public int getK()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeAwareInterpolator_getK_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setSigma(float _sigma)
        //

        /**
         * Sigma is a parameter defining how fast the weights decrease in the locally-weighted affine
         *     fitting. Higher values can help preserve fine details, lower values can help to get rid of noise in the
         *     output flow.
         * param _sigma automatically generated
         */
        public void setSigma(float _sigma)
        {
            ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setSigma_10(nativeObj, _sigma);


        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getSigma()
        //

        /**
         * SEE: setSigma
         * return automatically generated
         */
        public float getSigma()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeAwareInterpolator_getSigma_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setLambda(float _lambda)
        //

        /**
         * Lambda is a parameter defining the weight of the edge-aware term in geodesic distance,
         *     should be in the range of 0 to 1000.
         * param _lambda automatically generated
         */
        public void setLambda(float _lambda)
        {
            ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setLambda_10(nativeObj, _lambda);


        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getLambda()
        //

        /**
         * SEE: setLambda
         * return automatically generated
         */
        public float getLambda()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeAwareInterpolator_getLambda_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setUsePostProcessing(bool _use_post_proc)
        //

        /**
         * Sets whether the fastGlobalSmootherFilter() post-processing is employed. It is turned on by
         *     default.
         * param _use_post_proc automatically generated
         */
        public void setUsePostProcessing(bool _use_post_proc)
        {
            ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setUsePostProcessing_10(nativeObj, _use_post_proc);


        }


        //
        // C++:  bool cv::ximgproc::EdgeAwareInterpolator::getUsePostProcessing()
        //

        /**
         * SEE: setUsePostProcessing
         * return automatically generated
         */
        public bool getUsePostProcessing()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeAwareInterpolator_getUsePostProcessing_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSLambda(float _lambda)
        //

        /**
         * Sets the respective fastGlobalSmootherFilter() parameter.
         * param _lambda automatically generated
         */
        public void setFGSLambda(float _lambda)
        {
            ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setFGSLambda_10(nativeObj, _lambda);


        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSLambda()
        //

        /**
         * SEE: setFGSLambda
         * return automatically generated
         */
        public float getFGSLambda()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeAwareInterpolator_getFGSLambda_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSSigma(float _sigma)
        //

        /**
         * SEE: setFGSLambda
         * param _sigma automatically generated
         */
        public void setFGSSigma(float _sigma)
        {
            ThrowIfDisposed();

            ximgproc_EdgeAwareInterpolator_setFGSSigma_10(nativeObj, _sigma);


        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSSigma()
        //

        /**
         * SEE: setFGSLambda
         * return automatically generated
         */
        public float getFGSSigma()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeAwareInterpolator_getFGSSigma_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setCostMap(Mat _costMap)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setCostMap_10(IntPtr nativeObj, IntPtr _costMap_nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setK(int _k)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setK_10(IntPtr nativeObj, int _k);

        // C++:  int cv::ximgproc::EdgeAwareInterpolator::getK()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeAwareInterpolator_getK_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setSigma(float _sigma)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setSigma_10(IntPtr nativeObj, float _sigma);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getSigma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getSigma_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setLambda(float _lambda)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setLambda_10(IntPtr nativeObj, float _lambda);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getLambda()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getLambda_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setUsePostProcessing(bool _use_post_proc)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setUsePostProcessing_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool _use_post_proc);

        // C++:  bool cv::ximgproc::EdgeAwareInterpolator::getUsePostProcessing()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_EdgeAwareInterpolator_getUsePostProcessing_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSLambda(float _lambda)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setFGSLambda_10(IntPtr nativeObj, float _lambda);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSLambda()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getFGSLambda_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSSigma(float _sigma)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setFGSSigma_10(IntPtr nativeObj, float _sigma);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSSigma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getFGSSigma_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_delete(IntPtr nativeObj);

    }
}
