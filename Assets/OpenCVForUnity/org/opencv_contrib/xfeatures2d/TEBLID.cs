
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class TEBLID
    /**
     * Class implementing TEBLID (Triplet-based Efficient Binary Local Image Descriptor),
     * described in CITE: Suarez2021TEBLID.
     *
     * TEBLID stands for Triplet-based Efficient Binary Local Image Descriptor, although originally it was called BAD
     * \cite Suarez2021TEBLID. It is an improvement over BEBLID \cite Suarez2020BEBLID, that uses triplet loss,
     * hard negative mining, and anchor swap to improve the image matching results.
     * It is able to describe keypoints from any detector just by changing the scale_factor parameter.
     * TEBLID is as efficient as ORB, BEBLID or BRISK, but the triplet-based training objective selected more
     * discriminative features that explain the accuracy gain. It is also more compact than BEBLID,
     * when running the [AKAZE example](https://github.com/opencv/opencv/blob/4.x/samples/cpp/tutorial_code/features2D/AKAZE_match.cpp)
     * with 10000 keypoints detected by ORB, BEBLID obtains 561 inliers (75%) with 512 bits, whereas
     * TEBLID obtains 621 (75.2%) with 256 bits. ORB obtains only 493 inliers (63%).
     *
     * If you find this code useful, please add a reference to the following paper:
     * &lt;BLOCKQUOTE&gt; Iago Suárez, José M. Buenaposada, and Luis Baumela.
     * Revisiting Binary Local Image Description for Resource Limited Devices.
     * IEEE Robotics and Automation Letters, vol. 6, no. 4, pp. 8317-8324, Oct. 2021. &lt;/BLOCKQUOTE&gt;
     *
     * The descriptor was trained in Liberty split of the UBC datasets \cite winder2007learning .
     */

    public class TEBLID : Feature2D
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
                        xfeatures2d_TEBLID_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TEBLID(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TEBLID __fromPtr__(IntPtr addr) { return new TEBLID(addr); }

        // C++: enum cv.xfeatures2d.TEBLID.TeblidSize
        public const int SIZE_256_BITS = 102;
        public const int SIZE_512_BITS = 103;
        //
        // C++: static Ptr_TEBLID cv::xfeatures2d::TEBLID::create(float scale_factor, int n_bits = TEBLID::SIZE_256_BITS)
        //

        /**
         * Creates the TEBLID descriptor.
         *     param scale_factor Adjust the sampling window around detected keypoints:
         * <ul>
         *   <li>
         *      &lt;b&gt; 1.00f &lt;/b&gt; should be the scale for ORB keypoints
         *   </li>
         *   <li>
         *      &lt;b&gt; 6.75f &lt;/b&gt; should be the scale for SIFT detected keypoints
         *   </li>
         *   <li>
         *      &lt;b&gt; 6.25f &lt;/b&gt; is default and fits for KAZE, SURF detected keypoints
         *   </li>
         *   <li>
         *      &lt;b&gt; 5.00f &lt;/b&gt; should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints
         *   </li>
         * </ul>
         *     param n_bits Determine the number of bits in the descriptor. Should be either
         *      TEBLID::SIZE_256_BITS or TEBLID::SIZE_512_BITS.
         * return automatically generated
         */
        public static TEBLID create(float scale_factor, int n_bits)
        {


            return TEBLID.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TEBLID_create_10(scale_factor, n_bits)));


        }

        /**
         * Creates the TEBLID descriptor.
         *     param scale_factor Adjust the sampling window around detected keypoints:
         * <ul>
         *   <li>
         *      &lt;b&gt; 1.00f &lt;/b&gt; should be the scale for ORB keypoints
         *   </li>
         *   <li>
         *      &lt;b&gt; 6.75f &lt;/b&gt; should be the scale for SIFT detected keypoints
         *   </li>
         *   <li>
         *      &lt;b&gt; 6.25f &lt;/b&gt; is default and fits for KAZE, SURF detected keypoints
         *   </li>
         *   <li>
         *      &lt;b&gt; 5.00f &lt;/b&gt; should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints
         *   </li>
         * </ul>
         *      TEBLID::SIZE_256_BITS or TEBLID::SIZE_512_BITS.
         * return automatically generated
         */
        public static TEBLID create(float scale_factor)
        {


            return TEBLID.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TEBLID_create_11(scale_factor)));


        }


        //
        // C++:  String cv::xfeatures2d::TEBLID::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TEBLID_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TEBLID cv::xfeatures2d::TEBLID::create(float scale_factor, int n_bits = TEBLID::SIZE_256_BITS)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TEBLID_create_10(float scale_factor, int n_bits);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TEBLID_create_11(float scale_factor);

        // C++:  String cv::xfeatures2d::TEBLID::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TEBLID_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_TEBLID_delete(IntPtr nativeObj);

    }
}
