
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class DISOpticalFlow
    /**
     * DIS optical flow algorithm.
     *
     * This class implements the Dense Inverse Search (DIS) optical flow algorithm. More
     * details about the algorithm can be found at CITE: Kroeger2016 . Includes three presets with preselected
     * parameters to provide reasonable trade-off between speed and quality. However, even the slowest preset is
     * still relatively fast, use DeepFlow if you need better quality and don't care about speed.
     *
     * This implementation includes several additional features compared to the algorithm described in the paper,
     * including spatial propagation of flow vectors (REF: getUseSpatialPropagation), as well as an option to
     * utilize an initial flow approximation passed to REF: calc (which is, essentially, temporal propagation,
     * if the previous frame's flow field is passed).
     */

    public class DISOpticalFlow : DenseOpticalFlow
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
                        video_DISOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DISOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DISOpticalFlow __fromPtr__(IntPtr addr) { return new DISOpticalFlow(addr); }

        // C++: enum <unnamed>
        public const int PRESET_ULTRAFAST = 0;
        public const int PRESET_FAST = 1;
        public const int PRESET_MEDIUM = 2;
        //
        // C++:  int cv::DISOpticalFlow::getFinestScale()
        //

        /**
         * Finest level of the Gaussian pyramid on which the flow is computed (zero level
         *         corresponds to the original image resolution). The final flow is obtained by bilinear upscaling.
         * SEE: setFinestScale
         * return automatically generated
         */
        public int getFinestScale()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getFinestScale_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setFinestScale(int val)
        //

        /**
         *  getFinestScale SEE: getFinestScale
         * param val automatically generated
         */
        public void setFinestScale(int val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setFinestScale_10(nativeObj, val);


        }


        //
        // C++:  int cv::DISOpticalFlow::getPatchSize()
        //

        /**
         * Size of an image patch for matching (in pixels). Normally, default 8x8 patches work well
         *         enough in most cases.
         * SEE: setPatchSize
         * return automatically generated
         */
        public int getPatchSize()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getPatchSize_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setPatchSize(int val)
        //

        /**
         *  getPatchSize SEE: getPatchSize
         * param val automatically generated
         */
        public void setPatchSize(int val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setPatchSize_10(nativeObj, val);


        }


        //
        // C++:  int cv::DISOpticalFlow::getPatchStride()
        //

        /**
         * Stride between neighbor patches. Must be less than patch size. Lower values correspond
         *         to higher flow quality.
         * SEE: setPatchStride
         * return automatically generated
         */
        public int getPatchStride()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getPatchStride_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setPatchStride(int val)
        //

        /**
         *  getPatchStride SEE: getPatchStride
         * param val automatically generated
         */
        public void setPatchStride(int val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setPatchStride_10(nativeObj, val);


        }


        //
        // C++:  int cv::DISOpticalFlow::getGradientDescentIterations()
        //

        /**
         * Maximum number of gradient descent iterations in the patch inverse search stage. Higher values
         *         may improve quality in some cases.
         * SEE: setGradientDescentIterations
         * return automatically generated
         */
        public int getGradientDescentIterations()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getGradientDescentIterations_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setGradientDescentIterations(int val)
        //

        /**
         *  getGradientDescentIterations SEE: getGradientDescentIterations
         * param val automatically generated
         */
        public void setGradientDescentIterations(int val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setGradientDescentIterations_10(nativeObj, val);


        }


        //
        // C++:  int cv::DISOpticalFlow::getVariationalRefinementIterations()
        //

        /**
         * Number of fixed point iterations of variational refinement per scale. Set to zero to
         *         disable variational refinement completely. Higher values will typically result in more smooth and
         *         high-quality flow.
         * SEE: setGradientDescentIterations
         * return automatically generated
         */
        public int getVariationalRefinementIterations()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getVariationalRefinementIterations_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementIterations(int val)
        //

        /**
         *  getGradientDescentIterations SEE: getGradientDescentIterations
         * param val automatically generated
         */
        public void setVariationalRefinementIterations(int val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setVariationalRefinementIterations_10(nativeObj, val);


        }


        //
        // C++:  float cv::DISOpticalFlow::getVariationalRefinementAlpha()
        //

        /**
         * Weight of the smoothness term
         * SEE: setVariationalRefinementAlpha
         * return automatically generated
         */
        public float getVariationalRefinementAlpha()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getVariationalRefinementAlpha_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementAlpha(float val)
        //

        /**
         *  getVariationalRefinementAlpha SEE: getVariationalRefinementAlpha
         * param val automatically generated
         */
        public void setVariationalRefinementAlpha(float val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setVariationalRefinementAlpha_10(nativeObj, val);


        }


        //
        // C++:  float cv::DISOpticalFlow::getVariationalRefinementDelta()
        //

        /**
         * Weight of the color constancy term
         * SEE: setVariationalRefinementDelta
         * return automatically generated
         */
        public float getVariationalRefinementDelta()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getVariationalRefinementDelta_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementDelta(float val)
        //

        /**
         *  getVariationalRefinementDelta SEE: getVariationalRefinementDelta
         * param val automatically generated
         */
        public void setVariationalRefinementDelta(float val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setVariationalRefinementDelta_10(nativeObj, val);


        }


        //
        // C++:  float cv::DISOpticalFlow::getVariationalRefinementGamma()
        //

        /**
         * Weight of the gradient constancy term
         * SEE: setVariationalRefinementGamma
         * return automatically generated
         */
        public float getVariationalRefinementGamma()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getVariationalRefinementGamma_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementGamma(float val)
        //

        /**
         *  getVariationalRefinementGamma SEE: getVariationalRefinementGamma
         * param val automatically generated
         */
        public void setVariationalRefinementGamma(float val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setVariationalRefinementGamma_10(nativeObj, val);


        }


        //
        // C++:  bool cv::DISOpticalFlow::getUseMeanNormalization()
        //

        /**
         * Whether to use mean-normalization of patches when computing patch distance. It is turned on
         *         by default as it typically provides a noticeable quality boost because of increased robustness to
         *         illumination variations. Turn it off if you are certain that your sequence doesn't contain any changes
         *         in illumination.
         * SEE: setUseMeanNormalization
         * return automatically generated
         */
        public bool getUseMeanNormalization()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getUseMeanNormalization_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setUseMeanNormalization(bool val)
        //

        /**
         *  getUseMeanNormalization SEE: getUseMeanNormalization
         * param val automatically generated
         */
        public void setUseMeanNormalization(bool val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setUseMeanNormalization_10(nativeObj, val);


        }


        //
        // C++:  bool cv::DISOpticalFlow::getUseSpatialPropagation()
        //

        /**
         * Whether to use spatial propagation of good optical flow vectors. This option is turned on by
         *         default, as it tends to work better on average and can sometimes help recover from major errors
         *         introduced by the coarse-to-fine scheme employed by the DIS optical flow algorithm. Turning this
         *         option off can make the output flow field a bit smoother, however.
         * SEE: setUseSpatialPropagation
         * return automatically generated
         */
        public bool getUseSpatialPropagation()
        {
            ThrowIfDisposed();

            return video_DISOpticalFlow_getUseSpatialPropagation_10(nativeObj);


        }


        //
        // C++:  void cv::DISOpticalFlow::setUseSpatialPropagation(bool val)
        //

        /**
         *  getUseSpatialPropagation SEE: getUseSpatialPropagation
         * param val automatically generated
         */
        public void setUseSpatialPropagation(bool val)
        {
            ThrowIfDisposed();

            video_DISOpticalFlow_setUseSpatialPropagation_10(nativeObj, val);


        }


        //
        // C++: static Ptr_DISOpticalFlow cv::DISOpticalFlow::create(int preset = DISOpticalFlow::PRESET_FAST)
        //

        /**
         * Creates an instance of DISOpticalFlow
         *
         *     param preset one of PRESET_ULTRAFAST, PRESET_FAST and PRESET_MEDIUM
         * return automatically generated
         */
        public static DISOpticalFlow create(int preset)
        {


            return DISOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_DISOpticalFlow_create_10(preset)));


        }

        /**
         * Creates an instance of DISOpticalFlow
         *
         * return automatically generated
         */
        public static DISOpticalFlow create()
        {


            return DISOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_DISOpticalFlow_create_11()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::DISOpticalFlow::getFinestScale()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getFinestScale_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setFinestScale(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setFinestScale_10(IntPtr nativeObj, int val);

        // C++:  int cv::DISOpticalFlow::getPatchSize()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getPatchSize_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setPatchSize(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setPatchSize_10(IntPtr nativeObj, int val);

        // C++:  int cv::DISOpticalFlow::getPatchStride()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getPatchStride_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setPatchStride(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setPatchStride_10(IntPtr nativeObj, int val);

        // C++:  int cv::DISOpticalFlow::getGradientDescentIterations()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getGradientDescentIterations_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setGradientDescentIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setGradientDescentIterations_10(IntPtr nativeObj, int val);

        // C++:  int cv::DISOpticalFlow::getVariationalRefinementIterations()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getVariationalRefinementIterations_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementIterations_10(IntPtr nativeObj, int val);

        // C++:  float cv::DISOpticalFlow::getVariationalRefinementAlpha()
        [DllImport(LIBNAME)]
        private static extern float video_DISOpticalFlow_getVariationalRefinementAlpha_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementAlpha(float val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementAlpha_10(IntPtr nativeObj, float val);

        // C++:  float cv::DISOpticalFlow::getVariationalRefinementDelta()
        [DllImport(LIBNAME)]
        private static extern float video_DISOpticalFlow_getVariationalRefinementDelta_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementDelta(float val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementDelta_10(IntPtr nativeObj, float val);

        // C++:  float cv::DISOpticalFlow::getVariationalRefinementGamma()
        [DllImport(LIBNAME)]
        private static extern float video_DISOpticalFlow_getVariationalRefinementGamma_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementGamma(float val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementGamma_10(IntPtr nativeObj, float val);

        // C++:  bool cv::DISOpticalFlow::getUseMeanNormalization()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_DISOpticalFlow_getUseMeanNormalization_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setUseMeanNormalization(bool val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setUseMeanNormalization_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  bool cv::DISOpticalFlow::getUseSpatialPropagation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_DISOpticalFlow_getUseSpatialPropagation_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setUseSpatialPropagation(bool val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setUseSpatialPropagation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++: static Ptr_DISOpticalFlow cv::DISOpticalFlow::create(int preset = DISOpticalFlow::PRESET_FAST)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_DISOpticalFlow_create_10(int preset);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_DISOpticalFlow_create_11();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_delete(IntPtr nativeObj);

    }
}
