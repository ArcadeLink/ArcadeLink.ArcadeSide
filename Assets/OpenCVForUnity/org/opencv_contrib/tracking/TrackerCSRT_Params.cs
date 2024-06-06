

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{
    // C++: class Params


    public class TrackerCSRT_Params : DisposableOpenCVObject
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
                        tracking_TrackerCSRT_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerCSRT_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerCSRT_Params __fromPtr__(IntPtr addr) { return new TrackerCSRT_Params(addr); }

        //
        // C++:   cv::TrackerCSRT::Params::Params()
        //

        public TrackerCSRT_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(tracking_TrackerCSRT_1Params_TrackerCSRT_1Params_10());


        }


        //
        // C++: bool TrackerCSRT_Params::use_hog
        //

        public bool get_use_hog()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1use_1hog_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::use_hog
        //

        public void set_use_hog(bool use_hog)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1use_1hog_10(nativeObj, use_hog);


        }


        //
        // C++: bool TrackerCSRT_Params::use_color_names
        //

        public bool get_use_color_names()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1use_1color_1names_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::use_color_names
        //

        public void set_use_color_names(bool use_color_names)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1use_1color_1names_10(nativeObj, use_color_names);


        }


        //
        // C++: bool TrackerCSRT_Params::use_gray
        //

        public bool get_use_gray()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1use_1gray_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::use_gray
        //

        public void set_use_gray(bool use_gray)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1use_1gray_10(nativeObj, use_gray);


        }


        //
        // C++: bool TrackerCSRT_Params::use_rgb
        //

        public bool get_use_rgb()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1use_1rgb_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::use_rgb
        //

        public void set_use_rgb(bool use_rgb)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1use_1rgb_10(nativeObj, use_rgb);


        }


        //
        // C++: bool TrackerCSRT_Params::use_channel_weights
        //

        public bool get_use_channel_weights()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1use_1channel_1weights_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::use_channel_weights
        //

        public void set_use_channel_weights(bool use_channel_weights)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1use_1channel_1weights_10(nativeObj, use_channel_weights);


        }


        //
        // C++: bool TrackerCSRT_Params::use_segmentation
        //

        public bool get_use_segmentation()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1use_1segmentation_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::use_segmentation
        //

        public void set_use_segmentation(bool use_segmentation)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1use_1segmentation_10(nativeObj, use_segmentation);


        }


        //
        // C++: string TrackerCSRT_Params::window_function
        //

        public string get_window_function()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(tracking_TrackerCSRT_1Params_get_1window_1function_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerCSRT_Params::window_function
        //

        public void set_window_function(string window_function)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1window_1function_10(nativeObj, window_function);


        }


        //
        // C++: float TrackerCSRT_Params::kaiser_alpha
        //

        public float get_kaiser_alpha()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1kaiser_1alpha_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::kaiser_alpha
        //

        public void set_kaiser_alpha(float kaiser_alpha)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1kaiser_1alpha_10(nativeObj, kaiser_alpha);


        }


        //
        // C++: float TrackerCSRT_Params::cheb_attenuation
        //

        public float get_cheb_attenuation()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1cheb_1attenuation_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::cheb_attenuation
        //

        public void set_cheb_attenuation(float cheb_attenuation)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1cheb_1attenuation_10(nativeObj, cheb_attenuation);


        }


        //
        // C++: float TrackerCSRT_Params::template_size
        //

        public float get_template_size()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1template_1size_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::template_size
        //

        public void set_template_size(float template_size)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1template_1size_10(nativeObj, template_size);


        }


        //
        // C++: float TrackerCSRT_Params::gsl_sigma
        //

        public float get_gsl_sigma()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1gsl_1sigma_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::gsl_sigma
        //

        public void set_gsl_sigma(float gsl_sigma)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1gsl_1sigma_10(nativeObj, gsl_sigma);


        }


        //
        // C++: float TrackerCSRT_Params::hog_orientations
        //

        public float get_hog_orientations()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1hog_1orientations_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::hog_orientations
        //

        public void set_hog_orientations(float hog_orientations)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1hog_1orientations_10(nativeObj, hog_orientations);


        }


        //
        // C++: float TrackerCSRT_Params::hog_clip
        //

        public float get_hog_clip()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1hog_1clip_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::hog_clip
        //

        public void set_hog_clip(float hog_clip)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1hog_1clip_10(nativeObj, hog_clip);


        }


        //
        // C++: float TrackerCSRT_Params::padding
        //

        public float get_padding()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1padding_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::padding
        //

        public void set_padding(float padding)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1padding_10(nativeObj, padding);


        }


        //
        // C++: float TrackerCSRT_Params::filter_lr
        //

        public float get_filter_lr()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1filter_1lr_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::filter_lr
        //

        public void set_filter_lr(float filter_lr)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1filter_1lr_10(nativeObj, filter_lr);


        }


        //
        // C++: float TrackerCSRT_Params::weights_lr
        //

        public float get_weights_lr()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1weights_1lr_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::weights_lr
        //

        public void set_weights_lr(float weights_lr)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1weights_1lr_10(nativeObj, weights_lr);


        }


        //
        // C++: int TrackerCSRT_Params::num_hog_channels_used
        //

        public int get_num_hog_channels_used()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1num_1hog_1channels_1used_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::num_hog_channels_used
        //

        public void set_num_hog_channels_used(int num_hog_channels_used)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1num_1hog_1channels_1used_10(nativeObj, num_hog_channels_used);


        }


        //
        // C++: int TrackerCSRT_Params::admm_iterations
        //

        public int get_admm_iterations()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1admm_1iterations_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::admm_iterations
        //

        public void set_admm_iterations(int admm_iterations)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1admm_1iterations_10(nativeObj, admm_iterations);


        }


        //
        // C++: int TrackerCSRT_Params::histogram_bins
        //

        public int get_histogram_bins()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1histogram_1bins_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::histogram_bins
        //

        public void set_histogram_bins(int histogram_bins)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1histogram_1bins_10(nativeObj, histogram_bins);


        }


        //
        // C++: float TrackerCSRT_Params::histogram_lr
        //

        public float get_histogram_lr()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1histogram_1lr_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::histogram_lr
        //

        public void set_histogram_lr(float histogram_lr)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1histogram_1lr_10(nativeObj, histogram_lr);


        }


        //
        // C++: int TrackerCSRT_Params::background_ratio
        //

        public int get_background_ratio()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1background_1ratio_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::background_ratio
        //

        public void set_background_ratio(int background_ratio)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1background_1ratio_10(nativeObj, background_ratio);


        }


        //
        // C++: int TrackerCSRT_Params::number_of_scales
        //

        public int get_number_of_scales()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1number_1of_1scales_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::number_of_scales
        //

        public void set_number_of_scales(int number_of_scales)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1number_1of_1scales_10(nativeObj, number_of_scales);


        }


        //
        // C++: float TrackerCSRT_Params::scale_sigma_factor
        //

        public float get_scale_sigma_factor()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1scale_1sigma_1factor_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::scale_sigma_factor
        //

        public void set_scale_sigma_factor(float scale_sigma_factor)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1scale_1sigma_1factor_10(nativeObj, scale_sigma_factor);


        }


        //
        // C++: float TrackerCSRT_Params::scale_model_max_area
        //

        public float get_scale_model_max_area()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1scale_1model_1max_1area_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::scale_model_max_area
        //

        public void set_scale_model_max_area(float scale_model_max_area)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1scale_1model_1max_1area_10(nativeObj, scale_model_max_area);


        }


        //
        // C++: float TrackerCSRT_Params::scale_lr
        //

        public float get_scale_lr()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1scale_1lr_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::scale_lr
        //

        public void set_scale_lr(float scale_lr)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1scale_1lr_10(nativeObj, scale_lr);


        }


        //
        // C++: float TrackerCSRT_Params::scale_step
        //

        public float get_scale_step()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1scale_1step_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::scale_step
        //

        public void set_scale_step(float scale_step)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1scale_1step_10(nativeObj, scale_step);


        }


        //
        // C++: float TrackerCSRT_Params::psr_threshold
        //

        public float get_psr_threshold()
        {
            ThrowIfDisposed();

            return tracking_TrackerCSRT_1Params_get_1psr_1threshold_10(nativeObj);


        }


        //
        // C++: void TrackerCSRT_Params::psr_threshold
        //

        public void set_psr_threshold(float psr_threshold)
        {
            ThrowIfDisposed();

            tracking_TrackerCSRT_1Params_set_1psr_1threshold_10(nativeObj, psr_threshold);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerCSRT::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerCSRT_1Params_TrackerCSRT_1Params_10();

        // C++: bool TrackerCSRT_Params::use_hog
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerCSRT_1Params_get_1use_1hog_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::use_hog
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1use_1hog_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_hog);

        // C++: bool TrackerCSRT_Params::use_color_names
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerCSRT_1Params_get_1use_1color_1names_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::use_color_names
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1use_1color_1names_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_color_names);

        // C++: bool TrackerCSRT_Params::use_gray
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerCSRT_1Params_get_1use_1gray_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::use_gray
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1use_1gray_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_gray);

        // C++: bool TrackerCSRT_Params::use_rgb
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerCSRT_1Params_get_1use_1rgb_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::use_rgb
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1use_1rgb_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_rgb);

        // C++: bool TrackerCSRT_Params::use_channel_weights
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerCSRT_1Params_get_1use_1channel_1weights_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::use_channel_weights
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1use_1channel_1weights_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_channel_weights);

        // C++: bool TrackerCSRT_Params::use_segmentation
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_TrackerCSRT_1Params_get_1use_1segmentation_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::use_segmentation
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1use_1segmentation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_segmentation);

        // C++: string TrackerCSRT_Params::window_function
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerCSRT_1Params_get_1window_1function_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::window_function
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1window_1function_10(IntPtr nativeObj, string window_function);

        // C++: float TrackerCSRT_Params::kaiser_alpha
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1kaiser_1alpha_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::kaiser_alpha
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1kaiser_1alpha_10(IntPtr nativeObj, float kaiser_alpha);

        // C++: float TrackerCSRT_Params::cheb_attenuation
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1cheb_1attenuation_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::cheb_attenuation
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1cheb_1attenuation_10(IntPtr nativeObj, float cheb_attenuation);

        // C++: float TrackerCSRT_Params::template_size
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1template_1size_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::template_size
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1template_1size_10(IntPtr nativeObj, float template_size);

        // C++: float TrackerCSRT_Params::gsl_sigma
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1gsl_1sigma_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::gsl_sigma
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1gsl_1sigma_10(IntPtr nativeObj, float gsl_sigma);

        // C++: float TrackerCSRT_Params::hog_orientations
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1hog_1orientations_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::hog_orientations
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1hog_1orientations_10(IntPtr nativeObj, float hog_orientations);

        // C++: float TrackerCSRT_Params::hog_clip
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1hog_1clip_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::hog_clip
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1hog_1clip_10(IntPtr nativeObj, float hog_clip);

        // C++: float TrackerCSRT_Params::padding
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1padding_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::padding
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1padding_10(IntPtr nativeObj, float padding);

        // C++: float TrackerCSRT_Params::filter_lr
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1filter_1lr_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::filter_lr
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1filter_1lr_10(IntPtr nativeObj, float filter_lr);

        // C++: float TrackerCSRT_Params::weights_lr
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1weights_1lr_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::weights_lr
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1weights_1lr_10(IntPtr nativeObj, float weights_lr);

        // C++: int TrackerCSRT_Params::num_hog_channels_used
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerCSRT_1Params_get_1num_1hog_1channels_1used_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::num_hog_channels_used
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1num_1hog_1channels_1used_10(IntPtr nativeObj, int num_hog_channels_used);

        // C++: int TrackerCSRT_Params::admm_iterations
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerCSRT_1Params_get_1admm_1iterations_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::admm_iterations
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1admm_1iterations_10(IntPtr nativeObj, int admm_iterations);

        // C++: int TrackerCSRT_Params::histogram_bins
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerCSRT_1Params_get_1histogram_1bins_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::histogram_bins
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1histogram_1bins_10(IntPtr nativeObj, int histogram_bins);

        // C++: float TrackerCSRT_Params::histogram_lr
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1histogram_1lr_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::histogram_lr
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1histogram_1lr_10(IntPtr nativeObj, float histogram_lr);

        // C++: int TrackerCSRT_Params::background_ratio
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerCSRT_1Params_get_1background_1ratio_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::background_ratio
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1background_1ratio_10(IntPtr nativeObj, int background_ratio);

        // C++: int TrackerCSRT_Params::number_of_scales
        [DllImport(LIBNAME)]
        private static extern int tracking_TrackerCSRT_1Params_get_1number_1of_1scales_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::number_of_scales
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1number_1of_1scales_10(IntPtr nativeObj, int number_of_scales);

        // C++: float TrackerCSRT_Params::scale_sigma_factor
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1scale_1sigma_1factor_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::scale_sigma_factor
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1scale_1sigma_1factor_10(IntPtr nativeObj, float scale_sigma_factor);

        // C++: float TrackerCSRT_Params::scale_model_max_area
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1scale_1model_1max_1area_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::scale_model_max_area
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1scale_1model_1max_1area_10(IntPtr nativeObj, float scale_model_max_area);

        // C++: float TrackerCSRT_Params::scale_lr
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1scale_1lr_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::scale_lr
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1scale_1lr_10(IntPtr nativeObj, float scale_lr);

        // C++: float TrackerCSRT_Params::scale_step
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1scale_1step_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::scale_step
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1scale_1step_10(IntPtr nativeObj, float scale_step);

        // C++: float TrackerCSRT_Params::psr_threshold
        [DllImport(LIBNAME)]
        private static extern float tracking_TrackerCSRT_1Params_get_1psr_1threshold_10(IntPtr nativeObj);

        // C++: void TrackerCSRT_Params::psr_threshold
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_set_1psr_1threshold_10(IntPtr nativeObj, float psr_threshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_1Params_delete(IntPtr nativeObj);

    }
}
