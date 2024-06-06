
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{

    // C++: class StereoSGBM
    /**
     * The class implements the modified H. Hirschmuller algorithm CITE: HH08 that differs from the original
     * one as follows:
     *
     * <ul>
     *   <li>
     *    By default, the algorithm is single-pass, which means that you consider only 5 directions
     * instead of 8. Set mode=StereoSGBM::MODE_HH in createStereoSGBM to run the full variant of the
     * algorithm but beware that it may consume a lot of memory.
     *   </li>
     *   <li>
     *    The algorithm matches blocks, not individual pixels. Though, setting blockSize=1 reduces the
     * blocks to single pixels.
     *   </li>
     *   <li>
     *    Mutual information cost function is not implemented. Instead, a simpler Birchfield-Tomasi
     * sub-pixel metric from CITE: BT98 is used. Though, the color images are supported as well.
     *   </li>
     *   <li>
     *    Some pre- and post- processing steps from K. Konolige algorithm StereoBM are included, for
     * example: pre-filtering (StereoBM::PREFILTER_XSOBEL type) and post-filtering (uniqueness
     * check, quadratic interpolation and speckle filtering).
     *   </li>
     * </ul>
     *
     * <b>Note:</b>
     * <ul>
     *   <li>
     *       (Python) An example illustrating the use of the StereoSGBM matching algorithm can be found
     *         at opencv_source_code/samples/python/stereo_match.py
     *   </li>
     * </ul>
     */

    public class StereoSGBM : StereoMatcher
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
                        calib3d_StereoSGBM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StereoSGBM(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StereoSGBM __fromPtr__(IntPtr addr) { return new StereoSGBM(addr); }

        // C++: enum <unnamed>
        public const int MODE_SGBM = 0;
        public const int MODE_HH = 1;
        public const int MODE_SGBM_3WAY = 2;
        public const int MODE_HH4 = 3;
        //
        // C++:  int cv::StereoSGBM::getPreFilterCap()
        //

        public int getPreFilterCap()
        {
            ThrowIfDisposed();

            return calib3d_StereoSGBM_getPreFilterCap_10(nativeObj);


        }


        //
        // C++:  void cv::StereoSGBM::setPreFilterCap(int preFilterCap)
        //

        public void setPreFilterCap(int preFilterCap)
        {
            ThrowIfDisposed();

            calib3d_StereoSGBM_setPreFilterCap_10(nativeObj, preFilterCap);


        }


        //
        // C++:  int cv::StereoSGBM::getUniquenessRatio()
        //

        public int getUniquenessRatio()
        {
            ThrowIfDisposed();

            return calib3d_StereoSGBM_getUniquenessRatio_10(nativeObj);


        }


        //
        // C++:  void cv::StereoSGBM::setUniquenessRatio(int uniquenessRatio)
        //

        public void setUniquenessRatio(int uniquenessRatio)
        {
            ThrowIfDisposed();

            calib3d_StereoSGBM_setUniquenessRatio_10(nativeObj, uniquenessRatio);


        }


        //
        // C++:  int cv::StereoSGBM::getP1()
        //

        public int getP1()
        {
            ThrowIfDisposed();

            return calib3d_StereoSGBM_getP1_10(nativeObj);


        }


        //
        // C++:  void cv::StereoSGBM::setP1(int P1)
        //

        public void setP1(int P1)
        {
            ThrowIfDisposed();

            calib3d_StereoSGBM_setP1_10(nativeObj, P1);


        }


        //
        // C++:  int cv::StereoSGBM::getP2()
        //

        public int getP2()
        {
            ThrowIfDisposed();

            return calib3d_StereoSGBM_getP2_10(nativeObj);


        }


        //
        // C++:  void cv::StereoSGBM::setP2(int P2)
        //

        public void setP2(int P2)
        {
            ThrowIfDisposed();

            calib3d_StereoSGBM_setP2_10(nativeObj, P2);


        }


        //
        // C++:  int cv::StereoSGBM::getMode()
        //

        public int getMode()
        {
            ThrowIfDisposed();

            return calib3d_StereoSGBM_getMode_10(nativeObj);


        }


        //
        // C++:  void cv::StereoSGBM::setMode(int mode)
        //

        public void setMode(int mode)
        {
            ThrowIfDisposed();

            calib3d_StereoSGBM_setMode_10(nativeObj, mode);


        }


        //
        // C++: static Ptr_StereoSGBM cv::StereoSGBM::create(int minDisparity = 0, int numDisparities = 16, int blockSize = 3, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, int mode = StereoSGBM::MODE_SGBM)
        //

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     param disp12MaxDiff Maximum allowed difference (in integer pixel units) in the left-right
         *     disparity check. Set it to a non-positive value to disable the check.
         *     param preFilterCap Truncation value for the prefiltered image pixels. The algorithm first
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     param uniquenessRatio Margin in percentage by which the best (minimum) computed cost function
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     param speckleWindowSize Maximum size of smooth disparity regions to consider their noise speckles
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     param speckleRange Maximum disparity variation within each connected component. If you do speckle
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     param mode Set it to StereoSGBM::MODE_HH to run the full-scale two-pass dynamic programming
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_10(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, mode)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     param disp12MaxDiff Maximum allowed difference (in integer pixel units) in the left-right
         *     disparity check. Set it to a non-positive value to disable the check.
         *     param preFilterCap Truncation value for the prefiltered image pixels. The algorithm first
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     param uniquenessRatio Margin in percentage by which the best (minimum) computed cost function
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     param speckleWindowSize Maximum size of smooth disparity regions to consider their noise speckles
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     param speckleRange Maximum disparity variation within each connected component. If you do speckle
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_11(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     param disp12MaxDiff Maximum allowed difference (in integer pixel units) in the left-right
         *     disparity check. Set it to a non-positive value to disable the check.
         *     param preFilterCap Truncation value for the prefiltered image pixels. The algorithm first
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     param uniquenessRatio Margin in percentage by which the best (minimum) computed cost function
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     param speckleWindowSize Maximum size of smooth disparity regions to consider their noise speckles
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_12(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     param disp12MaxDiff Maximum allowed difference (in integer pixel units) in the left-right
         *     disparity check. Set it to a non-positive value to disable the check.
         *     param preFilterCap Truncation value for the prefiltered image pixels. The algorithm first
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     param uniquenessRatio Margin in percentage by which the best (minimum) computed cost function
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_13(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     param disp12MaxDiff Maximum allowed difference (in integer pixel units) in the left-right
         *     disparity check. Set it to a non-positive value to disable the check.
         *     param preFilterCap Truncation value for the prefiltered image pixels. The algorithm first
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_14(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     param disp12MaxDiff Maximum allowed difference (in integer pixel units) in the left-right
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_15(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     param P2 The second parameter controlling the disparity smoothness. The larger the values are,
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_16(minDisparity, numDisparities, blockSize, P1, P2)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     param P1 The first parameter controlling the disparity smoothness. See below.
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_17(minDisparity, numDisparities, blockSize, P1)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     param blockSize Matched block size. It must be an odd number &gt;=1 . Normally, it should be
         *     somewhere in the 3..11 range.
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_18(minDisparity, numDisparities, blockSize)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     param numDisparities Maximum disparity minus minimum disparity. The value is always greater than
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     somewhere in the 3..11 range.
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity, int numDisparities)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_19(minDisparity, numDisparities)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     param minDisparity Minimum possible disparity value. Normally, it is zero but sometimes
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     somewhere in the 3..11 range.
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create(int minDisparity)
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_110(minDisparity)));


        }

        /**
         * Creates StereoSGBM object
         *
         *     rectification algorithms can shift images, so this parameter needs to be adjusted accordingly.
         *     zero. In the current implementation, this parameter must be divisible by 16.
         *     somewhere in the 3..11 range.
         *     the smoother the disparity is. P1 is the penalty on the disparity change by plus or minus 1
         *     between neighbor pixels. P2 is the penalty on the disparity change by more than 1 between neighbor
         *     pixels. The algorithm requires P2 &gt; P1 . See stereo_match.cpp sample where some reasonably good
         *     P1 and P2 values are shown (like 8\*number_of_image_channels\*blockSize\*blockSize and
         *     32\*number_of_image_channels\*blockSize\*blockSize , respectively).
         *     disparity check. Set it to a non-positive value to disable the check.
         *     computes x-derivative at each pixel and clips its value by [-preFilterCap, preFilterCap] interval.
         *     The result values are passed to the Birchfield-Tomasi pixel cost function.
         *     value should "win" the second best value to consider the found match correct. Normally, a value
         *     within the 5-15 range is good enough.
         *     and invalidate. Set it to 0 to disable speckle filtering. Otherwise, set it somewhere in the
         *     50-200 range.
         *     filtering, set the parameter to a positive value, it will be implicitly multiplied by 16.
         *     Normally, 1 or 2 is good enough.
         *     algorithm. It will consume O(W\*H\*numDisparities) bytes, which is large for 640x480 stereo and
         *     huge for HD-size pictures. By default, it is set to false .
         *
         *     The first constructor initializes StereoSGBM with all the default parameters. So, you only have to
         *     set StereoSGBM::numDisparities at minimum. The second constructor enables you to set each parameter
         *     to a custom value.
         * return automatically generated
         */
        public static StereoSGBM create()
        {


            return StereoSGBM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(calib3d_StereoSGBM_create_111()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::StereoSGBM::getPreFilterCap()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getPreFilterCap_10(IntPtr nativeObj);

        // C++:  void cv::StereoSGBM::setPreFilterCap(int preFilterCap)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setPreFilterCap_10(IntPtr nativeObj, int preFilterCap);

        // C++:  int cv::StereoSGBM::getUniquenessRatio()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getUniquenessRatio_10(IntPtr nativeObj);

        // C++:  void cv::StereoSGBM::setUniquenessRatio(int uniquenessRatio)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setUniquenessRatio_10(IntPtr nativeObj, int uniquenessRatio);

        // C++:  int cv::StereoSGBM::getP1()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getP1_10(IntPtr nativeObj);

        // C++:  void cv::StereoSGBM::setP1(int P1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setP1_10(IntPtr nativeObj, int P1);

        // C++:  int cv::StereoSGBM::getP2()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getP2_10(IntPtr nativeObj);

        // C++:  void cv::StereoSGBM::setP2(int P2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setP2_10(IntPtr nativeObj, int P2);

        // C++:  int cv::StereoSGBM::getMode()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getMode_10(IntPtr nativeObj);

        // C++:  void cv::StereoSGBM::setMode(int mode)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setMode_10(IntPtr nativeObj, int mode);

        // C++: static Ptr_StereoSGBM cv::StereoSGBM::create(int minDisparity = 0, int numDisparities = 16, int blockSize = 3, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, int mode = StereoSGBM::MODE_SGBM)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_10(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_11(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_12(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_13(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_14(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_15(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_16(int minDisparity, int numDisparities, int blockSize, int P1, int P2);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_17(int minDisparity, int numDisparities, int blockSize, int P1);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_18(int minDisparity, int numDisparities, int blockSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_19(int minDisparity, int numDisparities);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_110(int minDisparity);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_111();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_delete(IntPtr nativeObj);

    }
}
