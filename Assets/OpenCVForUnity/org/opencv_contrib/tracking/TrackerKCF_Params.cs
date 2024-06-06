

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{
    // C++: class Params


    public class TrackerKCF_Params : DisposableOpenCVObject
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
                        tracking_TrackerKCF_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerKCF_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerKCF_Params __fromPtr__(IntPtr addr) { return new TrackerKCF_Params(addr); }

        //
        // C++:   cv::TrackerKCF::Params::Params()
        //

        public TrackerKCF_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(tracking_TrackerKCF_1Params_TrackerKCF_1Params_10());


        }


        //
        // C++: float TrackerKCF_Params::detect_thresh
        //

        public float get_detect_thresh()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1detect_1thresh_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::detect_thresh
        //

        public void set_detect_thresh(float detect_thresh)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1detect_1thresh_10(nativeObj, detect_thresh);


        }


        //
        // C++: float TrackerKCF_Params::sigma
        //

        public float get_sigma()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1sigma_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::sigma
        //

        public void set_sigma(float sigma)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1sigma_10(nativeObj, sigma);


        }


        //
        // C++: float TrackerKCF_Params::lambda
        //

        public float get_lambda()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1lambda_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::lambda
        //

        public void set_lambda(float lambda)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1lambda_10(nativeObj, lambda);


        }


        //
        // C++: float TrackerKCF_Params::interp_factor
        //

        public float get_interp_factor()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1interp_1factor_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::interp_factor
        //

        public void set_interp_factor(float interp_factor)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1interp_1factor_10(nativeObj, interp_factor);


        }


        //
        // C++: float TrackerKCF_Params::output_sigma_factor
        //

        public float get_output_sigma_factor()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1output_1sigma_1factor_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::output_sigma_factor
        //

        public void set_output_sigma_factor(float output_sigma_factor)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1output_1sigma_1factor_10(nativeObj, output_sigma_factor);


        }


        //
        // C++: float TrackerKCF_Params::pca_learning_rate
        //

        public float get_pca_learning_rate()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1pca_1learning_1rate_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::pca_learning_rate
        //

        public void set_pca_learning_rate(float pca_learning_rate)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1pca_1learning_1rate_10(nativeObj, pca_learning_rate);


        }


        //
        // C++: bool TrackerKCF_Params::resize
        //

        public bool get_resize()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1resize_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::resize
        //

        public void set_resize(bool resize)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1resize_10(nativeObj, resize);


        }


        //
        // C++: bool TrackerKCF_Params::split_coeff
        //

        public bool get_split_coeff()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1split_1coeff_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::split_coeff
        //

        public void set_split_coeff(bool split_coeff)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1split_1coeff_10(nativeObj, split_coeff);


        }


        //
        // C++: bool TrackerKCF_Params::wrap_kernel
        //

        public bool get_wrap_kernel()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1wrap_1kernel_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::wrap_kernel
        //

        public void set_wrap_kernel(bool wrap_kernel)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1wrap_1kernel_10(nativeObj, wrap_kernel);


        }


        //
        // C++: bool TrackerKCF_Params::compress_feature
        //

        public bool get_compress_feature()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1compress_1feature_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::compress_feature
        //

        public void set_compress_feature(bool compress_feature)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1compress_1feature_10(nativeObj, compress_feature);


        }


        //
        // C++: int TrackerKCF_Params::max_patch_size
        //

        public int get_max_patch_size()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1max_1patch_1size_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::max_patch_size
        //

        public void set_max_patch_size(int max_patch_size)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1max_1patch_1size_10(nativeObj, max_patch_size);


        }


        //
        // C++: int TrackerKCF_Params::compressed_size
        //

        public int get_compressed_size()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1compressed_1size_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::compressed_size
        //

        public void set_compressed_size(int compressed_size)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1compressed_1size_10(nativeObj, compressed_size);


        }


        //
        // C++: int TrackerKCF_Params::desc_pca
        //

        public int get_desc_pca()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1desc_1pca_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::desc_pca
        //

        public void set_desc_pca(int desc_pca)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1desc_1pca_10(nativeObj, desc_pca);


        }


        //
        // C++: int TrackerKCF_Params::desc_npca
        //

        public int get_desc_npca()
        {
            ThrowIfDisposed();

            return tracking_TrackerKCF_1Params_get_1desc_1npca_10(nativeObj);


        }


        //
        // C++: void TrackerKCF_Params::desc_npca
        //

        public void set_desc_npca(int desc_npca)
        {
            ThrowIfDisposed();

            tracking_TrackerKCF_1Params_set_1desc_1npca_10(nativeObj, desc_npca);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerKCF::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerKCF_1Params_TrackerKCF_1Params_10();

        // C++: float TrackerKCF_Params::detect_thresh
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerKCF_1Params_get_1detect_1thresh_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::detect_thresh
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1detect_1thresh_10(IntPtr nativeObj, float detect_thresh);

        // C++: float TrackerKCF_Params::sigma
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerKCF_1Params_get_1sigma_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::sigma
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1sigma_10(IntPtr nativeObj, float sigma);

        // C++: float TrackerKCF_Params::lambda
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerKCF_1Params_get_1lambda_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::lambda
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1lambda_10(IntPtr nativeObj, float lambda);

        // C++: float TrackerKCF_Params::interp_factor
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerKCF_1Params_get_1interp_1factor_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::interp_factor
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1interp_1factor_10(IntPtr nativeObj, float interp_factor);

        // C++: float TrackerKCF_Params::output_sigma_factor
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerKCF_1Params_get_1output_1sigma_1factor_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::output_sigma_factor
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1output_1sigma_1factor_10(IntPtr nativeObj, float output_sigma_factor);

        // C++: float TrackerKCF_Params::pca_learning_rate
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerKCF_1Params_get_1pca_1learning_1rate_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::pca_learning_rate
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1pca_1learning_1rate_10(IntPtr nativeObj, float pca_learning_rate);

        // C++: bool TrackerKCF_Params::resize
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerKCF_1Params_get_1resize_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::resize
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1resize_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool resize);

        // C++: bool TrackerKCF_Params::split_coeff
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerKCF_1Params_get_1split_1coeff_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::split_coeff
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1split_1coeff_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool split_coeff);

        // C++: bool TrackerKCF_Params::wrap_kernel
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerKCF_1Params_get_1wrap_1kernel_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::wrap_kernel
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1wrap_1kernel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool wrap_kernel);

        // C++: bool TrackerKCF_Params::compress_feature
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerKCF_1Params_get_1compress_1feature_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::compress_feature
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1compress_1feature_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool compress_feature);

        // C++: int TrackerKCF_Params::max_patch_size
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerKCF_1Params_get_1max_1patch_1size_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::max_patch_size
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1max_1patch_1size_10(IntPtr nativeObj, int max_patch_size);

        // C++: int TrackerKCF_Params::compressed_size
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerKCF_1Params_get_1compressed_1size_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::compressed_size
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1compressed_1size_10(IntPtr nativeObj, int compressed_size);

        // C++: int TrackerKCF_Params::desc_pca
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerKCF_1Params_get_1desc_1pca_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::desc_pca
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1desc_1pca_10(IntPtr nativeObj, int desc_pca);

        // C++: int TrackerKCF_Params::desc_npca
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerKCF_1Params_get_1desc_1npca_10(IntPtr nativeObj);

        // C++: void TrackerKCF_Params::desc_npca
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_set_1desc_1npca_10(IntPtr nativeObj, int desc_npca);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_1Params_delete(IntPtr nativeObj);

    }
}
