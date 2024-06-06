#if !UNITY_WEBGL

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Structured_lightModule
{

    // C++: class GrayCodePattern
    /**
     * Class implementing the Gray-code pattern, based on CITE: UNDERWORLD.
     *
     * The generation of the pattern images is performed with Gray encoding using the traditional white and black colors.
     *
     * The information about the two image axes x, y is encoded separately into two different pattern sequences.
     * A projector P with resolution (P_res_x, P_res_y) will result in Ncols = log 2 (P_res_x) encoded pattern images representing the columns, and
     * in Nrows = log 2 (P_res_y) encoded pattern images representing the rows.
     * For example a projector with resolution 1024x768 will result in Ncols = 10 and Nrows = 10.
     *
     * However, the generated pattern sequence consists of both regular color and color-inverted images: inverted pattern images are images
     * with the same structure as the original but with inverted colors.
     * This provides an effective method for easily determining the intensity value of each pixel when it is lit (highest value) and
     * when it is not lit (lowest value). So for a a projector with resolution 1024x768, the number of pattern images will be Ncols * 2 + Nrows * 2 = 40.
     *
     */

    public class GrayCodePattern : StructuredLightPattern
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
                        structured_1light_GrayCodePattern_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GrayCodePattern(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GrayCodePattern __fromPtr__(IntPtr addr) { return new GrayCodePattern(addr); }

        //
        // C++: static Ptr_GrayCodePattern cv::structured_light::GrayCodePattern::create(int width, int height)
        //

        /**
         * Constructor
         * param width automatically generated
         * param height automatically generated
         * return automatically generated
         */
        public static GrayCodePattern create(int width, int height)
        {


            return GrayCodePattern.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(structured_1light_GrayCodePattern_create_10(width, height)));


        }


        //
        // C++:  size_t cv::structured_light::GrayCodePattern::getNumberOfPatternImages()
        //

        /**
         * Get the number of pattern images needed for the graycode pattern.
         *
         * return The number of pattern images needed for the graycode pattern.
         *
         */
        public long getNumberOfPatternImages()
        {
            ThrowIfDisposed();

            return structured_1light_GrayCodePattern_getNumberOfPatternImages_10(nativeObj);


        }


        //
        // C++:  void cv::structured_light::GrayCodePattern::setWhiteThreshold(size_t value)
        //

        /**
         * Sets the value for white threshold, needed for decoding.
         *
         * White threshold is a number between 0-255 that represents the minimum brightness difference required for valid pixels, between the graycode pattern and its inverse images; used in getProjPixel method.
         *
         * param value The desired white threshold value.
         *
         */
        public void setWhiteThreshold(long value)
        {
            ThrowIfDisposed();

            structured_1light_GrayCodePattern_setWhiteThreshold_10(nativeObj, value);


        }


        //
        // C++:  void cv::structured_light::GrayCodePattern::setBlackThreshold(size_t value)
        //

        /**
         * Sets the value for black threshold, needed for decoding (shadowsmasks computation).
         *
         * Black threshold is a number between 0-255 that represents the minimum brightness difference required for valid pixels, between the fully illuminated (white) and the not illuminated images (black); used in computeShadowMasks method.
         *
         * param value The desired black threshold value.
         *
         */
        public void setBlackThreshold(long value)
        {
            ThrowIfDisposed();

            structured_1light_GrayCodePattern_setBlackThreshold_10(nativeObj, value);


        }


        //
        // C++:  void cv::structured_light::GrayCodePattern::getImagesForShadowMasks(Mat& blackImage, Mat& whiteImage)
        //

        /**
         * Generates the all-black and all-white images needed for shadowMasks computation.
         *
         * To identify shadow regions, the regions of two images where the pixels are not lit by projector's light and thus where there is not coded information,
         * the 3DUNDERWORLD algorithm computes a shadow mask for the two cameras views, starting from a white and a black images captured by each camera.
         * This method generates these two additional images to project.
         *
         * param blackImage The generated all-black CV_8U image, at projector's resolution.
         * param whiteImage The generated all-white CV_8U image, at projector's resolution.
         */
        public void getImagesForShadowMasks(Mat blackImage, Mat whiteImage)
        {
            ThrowIfDisposed();
            if (blackImage != null) blackImage.ThrowIfDisposed();
            if (whiteImage != null) whiteImage.ThrowIfDisposed();

            structured_1light_GrayCodePattern_getImagesForShadowMasks_10(nativeObj, blackImage.nativeObj, whiteImage.nativeObj);


        }


        //
        // C++:  bool cv::structured_light::GrayCodePattern::getProjPixel(vector_Mat patternImages, int x, int y, Point& projPix)
        //

        /**
         * For a (x,y) pixel of a camera returns the corresponding projector pixel.
         *
         * The function decodes each pixel in the pattern images acquired by a camera into their corresponding decimal numbers representing the projector's column and row,
         * providing a mapping between camera's and projector's pixel.
         *
         * param patternImages The pattern images acquired by the camera, stored in a grayscale vector &lt; Mat &gt;.
         * param x x coordinate of the image pixel.
         * param y y coordinate of the image pixel.
         * param projPix Projector's pixel corresponding to the camera's pixel: projPix.x and projPix.y are the image coordinates of the projector's pixel corresponding to the pixel being decoded in a camera.
         * return automatically generated
         */
        public bool getProjPixel(List<Mat> patternImages, int x, int y, Point projPix)
        {
            ThrowIfDisposed();
            Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
            double[] projPix_out = new double[2];
            bool retVal = structured_1light_GrayCodePattern_getProjPixel_10(nativeObj, patternImages_mat.nativeObj, x, y, projPix_out);
            if (projPix != null) { projPix.x = projPix_out[0]; projPix.y = projPix_out[1]; }
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_GrayCodePattern cv::structured_light::GrayCodePattern::create(int width, int height)
        [DllImport(LIBNAME)]
        private static extern IntPtr structured_1light_GrayCodePattern_create_10(int width, int height);

        // C++:  size_t cv::structured_light::GrayCodePattern::getNumberOfPatternImages()
        [DllImport(LIBNAME)]
        private static extern long structured_1light_GrayCodePattern_getNumberOfPatternImages_10(IntPtr nativeObj);

        // C++:  void cv::structured_light::GrayCodePattern::setWhiteThreshold(size_t value)
        [DllImport(LIBNAME)]
        private static extern void structured_1light_GrayCodePattern_setWhiteThreshold_10(IntPtr nativeObj, long value);

        // C++:  void cv::structured_light::GrayCodePattern::setBlackThreshold(size_t value)
        [DllImport(LIBNAME)]
        private static extern void structured_1light_GrayCodePattern_setBlackThreshold_10(IntPtr nativeObj, long value);

        // C++:  void cv::structured_light::GrayCodePattern::getImagesForShadowMasks(Mat& blackImage, Mat& whiteImage)
        [DllImport(LIBNAME)]
        private static extern void structured_1light_GrayCodePattern_getImagesForShadowMasks_10(IntPtr nativeObj, IntPtr blackImage_nativeObj, IntPtr whiteImage_nativeObj);

        // C++:  bool cv::structured_light::GrayCodePattern::getProjPixel(vector_Mat patternImages, int x, int y, Point& projPix)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_GrayCodePattern_getProjPixel_10(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, int x, int y, double[] projPix_out);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void structured_1light_GrayCodePattern_delete(IntPtr nativeObj);

    }
}

#endif