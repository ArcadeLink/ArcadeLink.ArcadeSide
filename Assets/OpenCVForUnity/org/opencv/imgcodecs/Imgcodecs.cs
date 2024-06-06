
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgcodecsModule
{
    // C++: class Imgcodecs


    public class Imgcodecs
    {

        // C++: enum cv.ImreadModes
        public const int IMREAD_UNCHANGED = -1;
        public const int IMREAD_GRAYSCALE = 0;
        public const int IMREAD_COLOR = 1;
        public const int IMREAD_ANYDEPTH = 2;
        public const int IMREAD_ANYCOLOR = 4;
        public const int IMREAD_LOAD_GDAL = 8;
        public const int IMREAD_REDUCED_GRAYSCALE_2 = 16;
        public const int IMREAD_REDUCED_COLOR_2 = 17;
        public const int IMREAD_REDUCED_GRAYSCALE_4 = 32;
        public const int IMREAD_REDUCED_COLOR_4 = 33;
        public const int IMREAD_REDUCED_GRAYSCALE_8 = 64;
        public const int IMREAD_REDUCED_COLOR_8 = 65;
        public const int IMREAD_IGNORE_ORIENTATION = 128;
        // C++: enum cv.ImwriteEXRCompressionFlags
        public const int IMWRITE_EXR_COMPRESSION_NO = 0;
        public const int IMWRITE_EXR_COMPRESSION_RLE = 1;
        public const int IMWRITE_EXR_COMPRESSION_ZIPS = 2;
        public const int IMWRITE_EXR_COMPRESSION_ZIP = 3;
        public const int IMWRITE_EXR_COMPRESSION_PIZ = 4;
        public const int IMWRITE_EXR_COMPRESSION_PXR24 = 5;
        public const int IMWRITE_EXR_COMPRESSION_B44 = 6;
        public const int IMWRITE_EXR_COMPRESSION_B44A = 7;
        public const int IMWRITE_EXR_COMPRESSION_DWAA = 8;
        public const int IMWRITE_EXR_COMPRESSION_DWAB = 9;
        // C++: enum cv.ImwriteEXRTypeFlags
        public const int IMWRITE_EXR_TYPE_HALF = 1;
        public const int IMWRITE_EXR_TYPE_FLOAT = 2;
        // C++: enum cv.ImwriteFlags
        public const int IMWRITE_JPEG_QUALITY = 1;
        public const int IMWRITE_JPEG_PROGRESSIVE = 2;
        public const int IMWRITE_JPEG_OPTIMIZE = 3;
        public const int IMWRITE_JPEG_RST_INTERVAL = 4;
        public const int IMWRITE_JPEG_LUMA_QUALITY = 5;
        public const int IMWRITE_JPEG_CHROMA_QUALITY = 6;
        public const int IMWRITE_JPEG_SAMPLING_FACTOR = 7;
        public const int IMWRITE_PNG_COMPRESSION = 16;
        public const int IMWRITE_PNG_STRATEGY = 17;
        public const int IMWRITE_PNG_BILEVEL = 18;
        public const int IMWRITE_PXM_BINARY = 32;
        public const int IMWRITE_EXR_TYPE = (3 << 4) + 0;
        public const int IMWRITE_EXR_COMPRESSION = (3 << 4) + 1;
        public const int IMWRITE_EXR_DWA_COMPRESSION_LEVEL = (3 << 4) + 2;
        public const int IMWRITE_WEBP_QUALITY = 64;
        public const int IMWRITE_HDR_COMPRESSION = (5 << 4) + 0;
        public const int IMWRITE_PAM_TUPLETYPE = 128;
        public const int IMWRITE_TIFF_RESUNIT = 256;
        public const int IMWRITE_TIFF_XDPI = 257;
        public const int IMWRITE_TIFF_YDPI = 258;
        public const int IMWRITE_TIFF_COMPRESSION = 259;
        public const int IMWRITE_JPEG2000_COMPRESSION_X1000 = 272;
        public const int IMWRITE_AVIF_QUALITY = 512;
        public const int IMWRITE_AVIF_DEPTH = 513;
        public const int IMWRITE_AVIF_SPEED = 514;
        // C++: enum cv.ImwriteHDRCompressionFlags
        public const int IMWRITE_HDR_COMPRESSION_NONE = 0;
        public const int IMWRITE_HDR_COMPRESSION_RLE = 1;
        // C++: enum cv.ImwriteJPEGSamplingFactorParams
        public const int IMWRITE_JPEG_SAMPLING_FACTOR_411 = 0x411111;
        public const int IMWRITE_JPEG_SAMPLING_FACTOR_420 = 0x221111;
        public const int IMWRITE_JPEG_SAMPLING_FACTOR_422 = 0x211111;
        public const int IMWRITE_JPEG_SAMPLING_FACTOR_440 = 0x121111;
        public const int IMWRITE_JPEG_SAMPLING_FACTOR_444 = 0x111111;
        // C++: enum cv.ImwritePAMFlags
        public const int IMWRITE_PAM_FORMAT_NULL = 0;
        public const int IMWRITE_PAM_FORMAT_BLACKANDWHITE = 1;
        public const int IMWRITE_PAM_FORMAT_GRAYSCALE = 2;
        public const int IMWRITE_PAM_FORMAT_GRAYSCALE_ALPHA = 3;
        public const int IMWRITE_PAM_FORMAT_RGB = 4;
        public const int IMWRITE_PAM_FORMAT_RGB_ALPHA = 5;
        // C++: enum cv.ImwritePNGFlags
        public const int IMWRITE_PNG_STRATEGY_DEFAULT = 0;
        public const int IMWRITE_PNG_STRATEGY_FILTERED = 1;
        public const int IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY = 2;
        public const int IMWRITE_PNG_STRATEGY_RLE = 3;
        public const int IMWRITE_PNG_STRATEGY_FIXED = 4;
        //
        // C++:  Mat cv::imread(String filename, int flags = IMREAD_COLOR)
        //

        /**
         * Loads an image from a file.
         *
         *  imread
         *
         * The function imread loads an image from the specified file and returns it. If the image cannot be
         * read (because of missing file, improper permissions, unsupported or invalid format), the function
         * returns an empty matrix ( Mat::data==NULL ).
         *
         * Currently, the following file formats are supported:
         *
         * <ul>
         *   <li>
         *    Windows bitmaps - \*.bmp, \*.dib (always supported)
         *   </li>
         *   <li>
         *    JPEG files - \*.jpeg, \*.jpg, \*.jpe (see the *Note* section)
         *   </li>
         *   <li>
         *    JPEG 2000 files - \*.jp2 (see the *Note* section)
         *   </li>
         *   <li>
         *    Portable Network Graphics - \*.png (see the *Note* section)
         *   </li>
         *   <li>
         *    WebP - \*.webp (see the *Note* section)
         *   </li>
         *   <li>
         *    AVIF - \*.avif (see the *Note* section)
         *   </li>
         *   <li>
         *    Portable image format - \*.pbm, \*.pgm, \*.ppm \*.pxm, \*.pnm (always supported)
         *   </li>
         *   <li>
         *    PFM files - \*.pfm (see the *Note* section)
         *   </li>
         *   <li>
         *    Sun rasters - \*.sr, \*.ras (always supported)
         *   </li>
         *   <li>
         *    TIFF files - \*.tiff, \*.tif (see the *Note* section)
         *   </li>
         *   <li>
         *    OpenEXR Image files - \*.exr (see the *Note* section)
         *   </li>
         *   <li>
         *    Radiance HDR - \*.hdr, \*.pic (always supported)
         *   </li>
         *   <li>
         *    Raster and Vector geospatial data supported by GDAL (see the *Note* section)
         *   </li>
         * </ul>
         *
         * <b>Note:</b>
         * <ul>
         *   <li>
         *    The function determines the type of an image by the content, not by the file extension.
         *   </li>
         *   <li>
         *    In the case of color images, the decoded images will have the channels stored in <b>B G R</b> order.
         *   </li>
         *   <li>
         *    When using IMREAD_GRAYSCALE, the codec's internal grayscale conversion will be used, if available.
         *     Results may differ to the output of cvtColor()
         *   </li>
         *   <li>
         *    On Microsoft Windows\* OS and MacOSX\*, the codecs shipped with an OpenCV image (libjpeg,
         *     libpng, libtiff, and libjasper) are used by default. So, OpenCV can always read JPEGs, PNGs,
         *     and TIFFs. On MacOSX, there is also an option to use native MacOSX image readers. But beware
         *     that currently these native image loaders give images with different pixel values because of
         *     the color management embedded into MacOSX.
         *   </li>
         *   <li>
         *    On Linux\*, BSD flavors and other Unix-like open-source operating systems, OpenCV looks for
         *     codecs supplied with an OS image. Install the relevant packages (do not forget the development
         *     files, for example, "libjpeg-dev", in Debian\* and Ubuntu\*) to get the codec support or turn
         *     on the OPENCV_BUILD_3RDPARTY_LIBS flag in CMake.
         *   </li>
         *   <li>
         *    In the case you set *WITH_GDAL* flag to true in CMake and REF: IMREAD_LOAD_GDAL to load the image,
         *     then the [GDAL](http://www.gdal.org) driver will be used in order to decode the image, supporting
         *     the following formats: [Raster](http://www.gdal.org/formats_list.html),
         *     [Vector](http://www.gdal.org/ogr_formats.html).
         *   </li>
         *   <li>
         *    If EXIF information is embedded in the image file, the EXIF orientation will be taken into account
         *     and thus the image will be rotated accordingly except if the flags REF: IMREAD_IGNORE_ORIENTATION
         *     or REF: IMREAD_UNCHANGED are passed.
         *   </li>
         *   <li>
         *    Use the IMREAD_UNCHANGED flag to keep the floating point values from PFM image.
         *   </li>
         *   <li>
         *    By default number of pixels must be less than 2^30. Limit can be set using system
         *     variable OPENCV_IO_MAX_IMAGE_PIXELS
         *   </li>
         * </ul>
         *
         * param filename Name of file to be loaded.
         * param flags Flag that can take values of cv::ImreadModes
         * return automatically generated
         */
        public static Mat imread(string filename, int flags)
        {


            return new Mat(DisposableObject.ThrowIfNullIntPtr(imgcodecs_Imgcodecs_imread_10(filename, flags)));


        }

        /**
         * Loads an image from a file.
         *
         *  imread
         *
         * The function imread loads an image from the specified file and returns it. If the image cannot be
         * read (because of missing file, improper permissions, unsupported or invalid format), the function
         * returns an empty matrix ( Mat::data==NULL ).
         *
         * Currently, the following file formats are supported:
         *
         * <ul>
         *   <li>
         *    Windows bitmaps - \*.bmp, \*.dib (always supported)
         *   </li>
         *   <li>
         *    JPEG files - \*.jpeg, \*.jpg, \*.jpe (see the *Note* section)
         *   </li>
         *   <li>
         *    JPEG 2000 files - \*.jp2 (see the *Note* section)
         *   </li>
         *   <li>
         *    Portable Network Graphics - \*.png (see the *Note* section)
         *   </li>
         *   <li>
         *    WebP - \*.webp (see the *Note* section)
         *   </li>
         *   <li>
         *    AVIF - \*.avif (see the *Note* section)
         *   </li>
         *   <li>
         *    Portable image format - \*.pbm, \*.pgm, \*.ppm \*.pxm, \*.pnm (always supported)
         *   </li>
         *   <li>
         *    PFM files - \*.pfm (see the *Note* section)
         *   </li>
         *   <li>
         *    Sun rasters - \*.sr, \*.ras (always supported)
         *   </li>
         *   <li>
         *    TIFF files - \*.tiff, \*.tif (see the *Note* section)
         *   </li>
         *   <li>
         *    OpenEXR Image files - \*.exr (see the *Note* section)
         *   </li>
         *   <li>
         *    Radiance HDR - \*.hdr, \*.pic (always supported)
         *   </li>
         *   <li>
         *    Raster and Vector geospatial data supported by GDAL (see the *Note* section)
         *   </li>
         * </ul>
         *
         * <b>Note:</b>
         * <ul>
         *   <li>
         *    The function determines the type of an image by the content, not by the file extension.
         *   </li>
         *   <li>
         *    In the case of color images, the decoded images will have the channels stored in <b>B G R</b> order.
         *   </li>
         *   <li>
         *    When using IMREAD_GRAYSCALE, the codec's internal grayscale conversion will be used, if available.
         *     Results may differ to the output of cvtColor()
         *   </li>
         *   <li>
         *    On Microsoft Windows\* OS and MacOSX\*, the codecs shipped with an OpenCV image (libjpeg,
         *     libpng, libtiff, and libjasper) are used by default. So, OpenCV can always read JPEGs, PNGs,
         *     and TIFFs. On MacOSX, there is also an option to use native MacOSX image readers. But beware
         *     that currently these native image loaders give images with different pixel values because of
         *     the color management embedded into MacOSX.
         *   </li>
         *   <li>
         *    On Linux\*, BSD flavors and other Unix-like open-source operating systems, OpenCV looks for
         *     codecs supplied with an OS image. Install the relevant packages (do not forget the development
         *     files, for example, "libjpeg-dev", in Debian\* and Ubuntu\*) to get the codec support or turn
         *     on the OPENCV_BUILD_3RDPARTY_LIBS flag in CMake.
         *   </li>
         *   <li>
         *    In the case you set *WITH_GDAL* flag to true in CMake and REF: IMREAD_LOAD_GDAL to load the image,
         *     then the [GDAL](http://www.gdal.org) driver will be used in order to decode the image, supporting
         *     the following formats: [Raster](http://www.gdal.org/formats_list.html),
         *     [Vector](http://www.gdal.org/ogr_formats.html).
         *   </li>
         *   <li>
         *    If EXIF information is embedded in the image file, the EXIF orientation will be taken into account
         *     and thus the image will be rotated accordingly except if the flags REF: IMREAD_IGNORE_ORIENTATION
         *     or REF: IMREAD_UNCHANGED are passed.
         *   </li>
         *   <li>
         *    Use the IMREAD_UNCHANGED flag to keep the floating point values from PFM image.
         *   </li>
         *   <li>
         *    By default number of pixels must be less than 2^30. Limit can be set using system
         *     variable OPENCV_IO_MAX_IMAGE_PIXELS
         *   </li>
         * </ul>
         *
         * param filename Name of file to be loaded.
         * return automatically generated
         */
        public static Mat imread(string filename)
        {


            return new Mat(DisposableObject.ThrowIfNullIntPtr(imgcodecs_Imgcodecs_imread_11(filename)));


        }


        //
        // C++:  bool cv::imreadmulti(String filename, vector_Mat& mats, int flags = IMREAD_ANYCOLOR)
        //

        /**
         * Loads a multi-page image from a file.
         *
         * The function imreadmulti loads a multi-page image from the specified file into a vector of Mat objects.
         * param filename Name of file to be loaded.
         * param mats A vector of Mat objects holding each page.
         * param flags Flag that can take values of cv::ImreadModes, default with cv::IMREAD_ANYCOLOR.
         * SEE: cv::imread
         * return automatically generated
         */
        public static bool imreadmulti(string filename, List<Mat> mats, int flags)
        {

            Mat mats_mat = new Mat();
            bool retVal = imgcodecs_Imgcodecs_imreadmulti_10(filename, mats_mat.nativeObj, flags);
            Converters.Mat_to_vector_Mat(mats_mat, mats);
            mats_mat.release();
            return retVal;
        }

        /**
         * Loads a multi-page image from a file.
         *
         * The function imreadmulti loads a multi-page image from the specified file into a vector of Mat objects.
         * param filename Name of file to be loaded.
         * param mats A vector of Mat objects holding each page.
         * SEE: cv::imread
         * return automatically generated
         */
        public static bool imreadmulti(string filename, List<Mat> mats)
        {

            Mat mats_mat = new Mat();
            bool retVal = imgcodecs_Imgcodecs_imreadmulti_11(filename, mats_mat.nativeObj);
            Converters.Mat_to_vector_Mat(mats_mat, mats);
            mats_mat.release();
            return retVal;
        }


        //
        // C++:  bool cv::imreadmulti(String filename, vector_Mat& mats, int start, int count, int flags = IMREAD_ANYCOLOR)
        //

        /**
         * Loads a of images of a multi-page image from a file.
         *
         * The function imreadmulti loads a specified range from a multi-page image from the specified file into a vector of Mat objects.
         * param filename Name of file to be loaded.
         * param mats A vector of Mat objects holding each page.
         * param start Start index of the image to load
         * param count Count number of images to load
         * param flags Flag that can take values of cv::ImreadModes, default with cv::IMREAD_ANYCOLOR.
         * SEE: cv::imread
         * return automatically generated
         */
        public static bool imreadmulti(string filename, List<Mat> mats, int start, int count, int flags)
        {

            Mat mats_mat = new Mat();
            bool retVal = imgcodecs_Imgcodecs_imreadmulti_12(filename, mats_mat.nativeObj, start, count, flags);
            Converters.Mat_to_vector_Mat(mats_mat, mats);
            mats_mat.release();
            return retVal;
        }

        /**
         * Loads a of images of a multi-page image from a file.
         *
         * The function imreadmulti loads a specified range from a multi-page image from the specified file into a vector of Mat objects.
         * param filename Name of file to be loaded.
         * param mats A vector of Mat objects holding each page.
         * param start Start index of the image to load
         * param count Count number of images to load
         * SEE: cv::imread
         * return automatically generated
         */
        public static bool imreadmulti(string filename, List<Mat> mats, int start, int count)
        {

            Mat mats_mat = new Mat();
            bool retVal = imgcodecs_Imgcodecs_imreadmulti_13(filename, mats_mat.nativeObj, start, count);
            Converters.Mat_to_vector_Mat(mats_mat, mats);
            mats_mat.release();
            return retVal;
        }


        //
        // C++:  size_t cv::imcount(String filename, int flags = IMREAD_ANYCOLOR)
        //

        /**
         * Returns the number of images inside the give file
         *
         * The function imcount will return the number of pages in a multi-page image, or 1 for single-page images
         * param filename Name of file to be loaded.
         * param flags Flag that can take values of cv::ImreadModes, default with cv::IMREAD_ANYCOLOR.
         * return automatically generated
         */
        public static long imcount(string filename, int flags)
        {


            return imgcodecs_Imgcodecs_imcount_10(filename, flags);


        }

        /**
         * Returns the number of images inside the give file
         *
         * The function imcount will return the number of pages in a multi-page image, or 1 for single-page images
         * param filename Name of file to be loaded.
         * return automatically generated
         */
        public static long imcount(string filename)
        {


            return imgcodecs_Imgcodecs_imcount_11(filename);


        }


        //
        // C++:  bool cv::imwrite(String filename, Mat img, vector_int _params = std::vector<int>())
        //

        /**
         * Saves an image to a specified file.
         *
         * The function imwrite saves the image to the specified file. The image format is chosen based on the
         * filename extension (see cv::imread for the list of extensions). In general, only 8-bit unsigned (CV_8U)
         * single-channel or 3-channel (with 'BGR' channel order) images
         * can be saved using this function, with these exceptions:
         *
         * <ul>
         *   <li>
         *  With OpenEXR encoder, only 32-bit float (CV_32F) images can be saved.
         *   <ul>
         *     <li>
         *    8-bit unsigned (CV_8U) images are not supported.
         *     </li>
         *   </ul>
         *   <li>
         *  With Radiance HDR encoder, non 64-bit float (CV_64F) images can be saved.
         *   <ul>
         *     <li>
         *    All images will be converted to 32-bit float (CV_32F).
         *     </li>
         *   </ul>
         *   <li>
         *  With JPEG 2000 encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   </li>
         *   <li>
         *  With PAM encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   </li>
         *   <li>
         *  With PNG encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   <ul>
         *     <li>
         *    PNG images with an alpha channel can be saved using this function. To do this, create
         *     8-bit (or 16-bit) 4-channel image BGRA, where the alpha channel goes last. Fully transparent pixels
         *     should have alpha set to 0, fully opaque pixels should have alpha set to 255/65535 (see the code sample below).
         *     </li>
         *   </ul>
         *   <li>
         *  With PGM/PPM encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   </li>
         *   <li>
         *  With TIFF encoder, 8-bit unsigned (CV_8U), 16-bit unsigned (CV_16U),
         *                      32-bit float (CV_32F) and 64-bit float (CV_64F) images can be saved.
         *   <ul>
         *     <li>
         *    Multiple images (vector of Mat) can be saved in TIFF format (see the code sample below).
         *     </li>
         *     <li>
         *    32-bit float 3-channel (CV_32FC3) TIFF images will be saved
         *     using the LogLuv high dynamic range encoding (4 bytes per pixel)
         *     </li>
         *   </ul>
         *
         * If the image format is not supported, the image will be converted to 8-bit unsigned (CV_8U) and saved that way.
         *   </li>
         * </ul>
         *
         * If the format, depth or channel order is different, use
         * Mat::convertTo and cv::cvtColor to convert it before saving. Or, use the universal FileStorage I/O
         * functions to save the image to XML or YAML format.
         *
         * The sample below shows how to create a BGRA image, how to set custom compression parameters and save it to a PNG file.
         * It also demonstrates how to save multiple images in a TIFF file:
         * INCLUDE: snippets/imgcodecs_imwrite.cpp
         * param filename Name of the file.
         * param img (Mat or vector of Mat) Image or Images to be saved.
         * param _params automatically generated
         * return automatically generated
         */
        public static bool imwrite(string filename, Mat img, MatOfInt _params)
        {
            if (img != null) img.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return imgcodecs_Imgcodecs_imwrite_10(filename, img.nativeObj, _params_mat.nativeObj);


        }

        /**
         * Saves an image to a specified file.
         *
         * The function imwrite saves the image to the specified file. The image format is chosen based on the
         * filename extension (see cv::imread for the list of extensions). In general, only 8-bit unsigned (CV_8U)
         * single-channel or 3-channel (with 'BGR' channel order) images
         * can be saved using this function, with these exceptions:
         *
         * <ul>
         *   <li>
         *  With OpenEXR encoder, only 32-bit float (CV_32F) images can be saved.
         *   <ul>
         *     <li>
         *    8-bit unsigned (CV_8U) images are not supported.
         *     </li>
         *   </ul>
         *   <li>
         *  With Radiance HDR encoder, non 64-bit float (CV_64F) images can be saved.
         *   <ul>
         *     <li>
         *    All images will be converted to 32-bit float (CV_32F).
         *     </li>
         *   </ul>
         *   <li>
         *  With JPEG 2000 encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   </li>
         *   <li>
         *  With PAM encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   </li>
         *   <li>
         *  With PNG encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   <ul>
         *     <li>
         *    PNG images with an alpha channel can be saved using this function. To do this, create
         *     8-bit (or 16-bit) 4-channel image BGRA, where the alpha channel goes last. Fully transparent pixels
         *     should have alpha set to 0, fully opaque pixels should have alpha set to 255/65535 (see the code sample below).
         *     </li>
         *   </ul>
         *   <li>
         *  With PGM/PPM encoder, 8-bit unsigned (CV_8U) and 16-bit unsigned (CV_16U) images can be saved.
         *   </li>
         *   <li>
         *  With TIFF encoder, 8-bit unsigned (CV_8U), 16-bit unsigned (CV_16U),
         *                      32-bit float (CV_32F) and 64-bit float (CV_64F) images can be saved.
         *   <ul>
         *     <li>
         *    Multiple images (vector of Mat) can be saved in TIFF format (see the code sample below).
         *     </li>
         *     <li>
         *    32-bit float 3-channel (CV_32FC3) TIFF images will be saved
         *     using the LogLuv high dynamic range encoding (4 bytes per pixel)
         *     </li>
         *   </ul>
         *
         * If the image format is not supported, the image will be converted to 8-bit unsigned (CV_8U) and saved that way.
         *   </li>
         * </ul>
         *
         * If the format, depth or channel order is different, use
         * Mat::convertTo and cv::cvtColor to convert it before saving. Or, use the universal FileStorage I/O
         * functions to save the image to XML or YAML format.
         *
         * The sample below shows how to create a BGRA image, how to set custom compression parameters and save it to a PNG file.
         * It also demonstrates how to save multiple images in a TIFF file:
         * INCLUDE: snippets/imgcodecs_imwrite.cpp
         * param filename Name of the file.
         * param img (Mat or vector of Mat) Image or Images to be saved.
         * return automatically generated
         */
        public static bool imwrite(string filename, Mat img)
        {
            if (img != null) img.ThrowIfDisposed();

            return imgcodecs_Imgcodecs_imwrite_11(filename, img.nativeObj);


        }


        //
        // C++:  bool cv::imwritemulti(String filename, vector_Mat img, vector_int _params = std::vector<int>())
        //

        public static bool imwritemulti(string filename, List<Mat> img, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat img_mat = Converters.vector_Mat_to_Mat(img);
            Mat _params_mat = _params;
            return imgcodecs_Imgcodecs_imwritemulti_10(filename, img_mat.nativeObj, _params_mat.nativeObj);


        }

        public static bool imwritemulti(string filename, List<Mat> img)
        {

            Mat img_mat = Converters.vector_Mat_to_Mat(img);
            return imgcodecs_Imgcodecs_imwritemulti_11(filename, img_mat.nativeObj);


        }


        //
        // C++:  Mat cv::imdecode(Mat buf, int flags)
        //

        /**
         * Reads an image from a buffer in memory.
         *
         * The function imdecode reads an image from the specified buffer in the memory. If the buffer is too short or
         * contains invalid data, the function returns an empty matrix ( Mat::data==NULL ).
         *
         * See cv::imread for the list of supported formats and flags description.
         *
         * <b>Note:</b> In the case of color images, the decoded images will have the channels stored in <b>B G R</b> order.
         * param buf Input array or vector of bytes.
         * param flags The same flags as in cv::imread, see cv::ImreadModes.
         * return automatically generated
         */
        public static Mat imdecode(Mat buf, int flags)
        {
            if (buf != null) buf.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(imgcodecs_Imgcodecs_imdecode_10(buf.nativeObj, flags)));


        }


        //
        // C++:  bool cv::imdecodemulti(Mat buf, int flags, vector_Mat& mats)
        //

        /**
         * Reads a multi-page image from a buffer in memory.
         *
         * The function imdecodemulti reads a multi-page image from the specified buffer in the memory. If the buffer is too short or
         * contains invalid data, the function returns false.
         *
         * See cv::imreadmulti for the list of supported formats and flags description.
         *
         * <b>Note:</b> In the case of color images, the decoded images will have the channels stored in <b>B G R</b> order.
         * param buf Input array or vector of bytes.
         * param flags The same flags as in cv::imread, see cv::ImreadModes.
         * param mats A vector of Mat objects holding each page, if more than one.
         * return automatically generated
         */
        public static bool imdecodemulti(Mat buf, int flags, List<Mat> mats)
        {
            if (buf != null) buf.ThrowIfDisposed();
            Mat mats_mat = new Mat();
            bool retVal = imgcodecs_Imgcodecs_imdecodemulti_10(buf.nativeObj, flags, mats_mat.nativeObj);
            Converters.Mat_to_vector_Mat(mats_mat, mats);
            mats_mat.release();
            return retVal;
        }


        //
        // C++:  bool cv::imencode(String ext, Mat img, vector_uchar& buf, vector_int _params = std::vector<int>())
        //

        /**
         * Encodes an image into a memory buffer.
         *
         * The function imencode compresses the image and stores it in the memory buffer that is resized to fit the
         * result. See cv::imwrite for the list of supported formats and flags description.
         *
         * param ext File extension that defines the output format. Must include a leading period.
         * param img Image to be written.
         * param buf Output buffer resized to fit the compressed image.
         * param _params automatically generated
         * return automatically generated
         */
        public static bool imencode(string ext, Mat img, MatOfByte buf, MatOfInt _params)
        {
            if (img != null) img.ThrowIfDisposed();
            if (buf != null) buf.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat buf_mat = buf;
            Mat _params_mat = _params;
            return imgcodecs_Imgcodecs_imencode_10(ext, img.nativeObj, buf_mat.nativeObj, _params_mat.nativeObj);


        }

        /**
         * Encodes an image into a memory buffer.
         *
         * The function imencode compresses the image and stores it in the memory buffer that is resized to fit the
         * result. See cv::imwrite for the list of supported formats and flags description.
         *
         * param ext File extension that defines the output format. Must include a leading period.
         * param img Image to be written.
         * param buf Output buffer resized to fit the compressed image.
         * return automatically generated
         */
        public static bool imencode(string ext, Mat img, MatOfByte buf)
        {
            if (img != null) img.ThrowIfDisposed();
            if (buf != null) buf.ThrowIfDisposed();
            Mat buf_mat = buf;
            return imgcodecs_Imgcodecs_imencode_11(ext, img.nativeObj, buf_mat.nativeObj);


        }


        //
        // C++:  bool cv::haveImageReader(String filename)
        //

        /**
         * Returns true if the specified image can be decoded by OpenCV
         *
         * param filename File name of the image
         * return automatically generated
         */
        public static bool haveImageReader(string filename)
        {


            return imgcodecs_Imgcodecs_haveImageReader_10(filename);


        }


        //
        // C++:  bool cv::haveImageWriter(String filename)
        //

        /**
         * Returns true if an image with the specified filename can be encoded by OpenCV
         *
         *  param filename File name of the image
         * return automatically generated
         */
        public static bool haveImageWriter(string filename)
        {


            return imgcodecs_Imgcodecs_haveImageWriter_10(filename);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Mat cv::imread(String filename, int flags = IMREAD_COLOR)
        [DllImport(LIBNAME)]
        private static extern IntPtr imgcodecs_Imgcodecs_imread_10(string filename, int flags);
        [DllImport(LIBNAME)]
        private static extern IntPtr imgcodecs_Imgcodecs_imread_11(string filename);

        // C++:  bool cv::imreadmulti(String filename, vector_Mat& mats, int flags = IMREAD_ANYCOLOR)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imreadmulti_10(string filename, IntPtr mats_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imreadmulti_11(string filename, IntPtr mats_mat_nativeObj);

        // C++:  bool cv::imreadmulti(String filename, vector_Mat& mats, int start, int count, int flags = IMREAD_ANYCOLOR)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imreadmulti_12(string filename, IntPtr mats_mat_nativeObj, int start, int count, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imreadmulti_13(string filename, IntPtr mats_mat_nativeObj, int start, int count);

        // C++:  size_t cv::imcount(String filename, int flags = IMREAD_ANYCOLOR)
        [DllImport(LIBNAME)]
        private static extern long imgcodecs_Imgcodecs_imcount_10(string filename, int flags);
        [DllImport(LIBNAME)]
        private static extern long imgcodecs_Imgcodecs_imcount_11(string filename);

        // C++:  bool cv::imwrite(String filename, Mat img, vector_int _params = std::vector<int>())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imwrite_10(string filename, IntPtr img_nativeObj, IntPtr _params_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imwrite_11(string filename, IntPtr img_nativeObj);

        // C++:  bool cv::imwritemulti(String filename, vector_Mat img, vector_int _params = std::vector<int>())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imwritemulti_10(string filename, IntPtr img_mat_nativeObj, IntPtr _params_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imwritemulti_11(string filename, IntPtr img_mat_nativeObj);

        // C++:  Mat cv::imdecode(Mat buf, int flags)
        [DllImport(LIBNAME)]
        private static extern IntPtr imgcodecs_Imgcodecs_imdecode_10(IntPtr buf_nativeObj, int flags);

        // C++:  bool cv::imdecodemulti(Mat buf, int flags, vector_Mat& mats)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imdecodemulti_10(IntPtr buf_nativeObj, int flags, IntPtr mats_mat_nativeObj);

        // C++:  bool cv::imencode(String ext, Mat img, vector_uchar& buf, vector_int _params = std::vector<int>())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imencode_10(string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj, IntPtr _params_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_imencode_11(string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj);

        // C++:  bool cv::haveImageReader(String filename)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_haveImageReader_10(string filename);

        // C++:  bool cv::haveImageWriter(String filename)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool imgcodecs_Imgcodecs_haveImageWriter_10(string filename);

    }
}
