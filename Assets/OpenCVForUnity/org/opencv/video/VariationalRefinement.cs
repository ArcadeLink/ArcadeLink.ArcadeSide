
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class VariationalRefinement
    /**
     * Variational optical flow refinement
     *
     * This class implements variational refinement of the input flow field, i.e.
     * it uses input flow to initialize the minimization of the following functional:
     * \(E(U) = \int_{\Omega} \delta \Psi(E_I) + \gamma \Psi(E_G) + \alpha \Psi(E_S) \),
     * where \(E_I,E_G,E_S\) are color constancy, gradient constancy and smoothness terms
     * respectively. \(\Psi(s^2)=\sqrt{s^2+\epsilon^2}\) is a robust penalizer to limit the
     * influence of outliers. A complete formulation and a description of the minimization
     * procedure can be found in CITE: Brox2004
     */

    public class VariationalRefinement : DenseOpticalFlow
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
                        video_VariationalRefinement_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VariationalRefinement(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new VariationalRefinement __fromPtr__(IntPtr addr) { return new VariationalRefinement(addr); }

        //
        // C++:  void cv::VariationalRefinement::calcUV(Mat I0, Mat I1, Mat& flow_u, Mat& flow_v)
        //

        /**
         * REF: calc function overload to handle separate horizontal (u) and vertical (v) flow components
         * (to avoid extra splits/merges)
         * param I0 automatically generated
         * param I1 automatically generated
         * param flow_u automatically generated
         * param flow_v automatically generated
         */
        public void calcUV(Mat I0, Mat I1, Mat flow_u, Mat flow_v)
        {
            ThrowIfDisposed();
            if (I0 != null) I0.ThrowIfDisposed();
            if (I1 != null) I1.ThrowIfDisposed();
            if (flow_u != null) flow_u.ThrowIfDisposed();
            if (flow_v != null) flow_v.ThrowIfDisposed();

            video_VariationalRefinement_calcUV_10(nativeObj, I0.nativeObj, I1.nativeObj, flow_u.nativeObj, flow_v.nativeObj);


        }


        //
        // C++:  int cv::VariationalRefinement::getFixedPointIterations()
        //

        /**
         * Number of outer (fixed-point) iterations in the minimization procedure.
         * SEE: setFixedPointIterations
         * return automatically generated
         */
        public int getFixedPointIterations()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getFixedPointIterations_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setFixedPointIterations(int val)
        //

        /**
         *  getFixedPointIterations SEE: getFixedPointIterations
         * param val automatically generated
         */
        public void setFixedPointIterations(int val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setFixedPointIterations_10(nativeObj, val);


        }


        //
        // C++:  int cv::VariationalRefinement::getSorIterations()
        //

        /**
         * Number of inner successive over-relaxation (SOR) iterations
         *         in the minimization procedure to solve the respective linear system.
         * SEE: setSorIterations
         * return automatically generated
         */
        public int getSorIterations()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getSorIterations_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setSorIterations(int val)
        //

        /**
         *  getSorIterations SEE: getSorIterations
         * param val automatically generated
         */
        public void setSorIterations(int val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setSorIterations_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getOmega()
        //

        /**
         * Relaxation factor in SOR
         * SEE: setOmega
         * return automatically generated
         */
        public float getOmega()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getOmega_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setOmega(float val)
        //

        /**
         *  getOmega SEE: getOmega
         * param val automatically generated
         */
        public void setOmega(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setOmega_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getAlpha()
        //

        /**
         * Weight of the smoothness term
         * SEE: setAlpha
         * return automatically generated
         */
        public float getAlpha()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getAlpha_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setAlpha(float val)
        //

        /**
         *  getAlpha SEE: getAlpha
         * param val automatically generated
         */
        public void setAlpha(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setAlpha_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getDelta()
        //

        /**
         * Weight of the color constancy term
         * SEE: setDelta
         * return automatically generated
         */
        public float getDelta()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getDelta_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setDelta(float val)
        //

        /**
         *  getDelta SEE: getDelta
         * param val automatically generated
         */
        public void setDelta(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setDelta_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getGamma()
        //

        /**
         * Weight of the gradient constancy term
         * SEE: setGamma
         * return automatically generated
         */
        public float getGamma()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getGamma_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setGamma(float val)
        //

        /**
         *  getGamma SEE: getGamma
         * param val automatically generated
         */
        public void setGamma(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setGamma_10(nativeObj, val);


        }


        //
        // C++: static Ptr_VariationalRefinement cv::VariationalRefinement::create()
        //

        /**
         * Creates an instance of VariationalRefinement
         * return automatically generated
         */
        public static VariationalRefinement create()
        {


            return VariationalRefinement.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_VariationalRefinement_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::VariationalRefinement::calcUV(Mat I0, Mat I1, Mat& flow_u, Mat& flow_v)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_calcUV_10(IntPtr nativeObj, IntPtr I0_nativeObj, IntPtr I1_nativeObj, IntPtr flow_u_nativeObj, IntPtr flow_v_nativeObj);

        // C++:  int cv::VariationalRefinement::getFixedPointIterations()
        [DllImport(LIBNAME)]
        private static extern int video_VariationalRefinement_getFixedPointIterations_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setFixedPointIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setFixedPointIterations_10(IntPtr nativeObj, int val);

        // C++:  int cv::VariationalRefinement::getSorIterations()
        [DllImport(LIBNAME)]
        private static extern int video_VariationalRefinement_getSorIterations_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setSorIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setSorIterations_10(IntPtr nativeObj, int val);

        // C++:  float cv::VariationalRefinement::getOmega()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getOmega_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setOmega(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setOmega_10(IntPtr nativeObj, float val);

        // C++:  float cv::VariationalRefinement::getAlpha()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getAlpha_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setAlpha(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setAlpha_10(IntPtr nativeObj, float val);

        // C++:  float cv::VariationalRefinement::getDelta()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getDelta_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setDelta(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setDelta_10(IntPtr nativeObj, float val);

        // C++:  float cv::VariationalRefinement::getGamma()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getGamma_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setGamma(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setGamma_10(IntPtr nativeObj, float val);

        // C++: static Ptr_VariationalRefinement cv::VariationalRefinement::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_VariationalRefinement_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_delete(IntPtr nativeObj);

    }
}
