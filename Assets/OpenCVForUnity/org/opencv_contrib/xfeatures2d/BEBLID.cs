
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class BEBLID
    /**
     * Class implementing BEBLID (Boosted Efficient Binary Local Image Descriptor),
     * described in CITE: Suarez2020BEBLID .
     *
     * BEBLID \cite Suarez2020BEBLID is a efficient binary descriptor learned with boosting.
     * It is able to describe keypoints from any detector just by changing the scale_factor parameter.
     * In several benchmarks it has proved to largely improve other binary descriptors like ORB or
     * BRISK with the same efficiency. BEBLID describes using the difference of mean gray values in
     * different regions of the image around the KeyPoint, the descriptor is specifically optimized for
     * image matching and patch retrieval addressing the asymmetries of these problems.
     *
     * If you find this code useful, please add a reference to the following paper:
     * &lt;BLOCKQUOTE&gt; Iago Suárez, Ghesn Sfeir, José M. Buenaposada, and Luis Baumela.
     * BEBLID: Boosted efficient binary local image descriptor.
     * Pattern Recognition Letters, 133:366–372, 2020. &lt;/BLOCKQUOTE&gt;
     *
     * The descriptor was trained using 1 million of randomly sampled pairs of patches
     * (20% positives and 80% negatives) from the Liberty split of the UBC datasets
     * \cite winder2007learning as described in the paper CITE: Suarez2020BEBLID.
     * You can check in the [AKAZE example](https://raw.githubusercontent.com/opencv/opencv/master/samples/cpp/tutorial_code/features2D/AKAZE_match.cpp)
     * how well BEBLID works. Detecting 10000 keypoints with ORB and describing with BEBLID obtains
     * 561 inliers (75%) whereas describing with ORB obtains only 493 inliers (63%).
     */

    public class BEBLID : Feature2D
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
                        xfeatures2d_BEBLID_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BEBLID(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BEBLID __fromPtr__(IntPtr addr) { return new BEBLID(addr); }

        // C++: enum cv.xfeatures2d.BEBLID.BeblidSize
        public const int SIZE_512_BITS = 100;
        public const int SIZE_256_BITS = 101;
        //
        // C++: static Ptr_BEBLID cv::xfeatures2d::BEBLID::create(float scale_factor, int n_bits = BEBLID::SIZE_512_BITS)
        //

        /**
         * Creates the BEBLID descriptor.
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
         *      BEBLID::SIZE_512_BITS or BEBLID::SIZE_256_BITS.
         * return automatically generated
         */
        public static BEBLID create(float scale_factor, int n_bits)
        {


            return BEBLID.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BEBLID_create_10(scale_factor, n_bits)));


        }

        /**
         * Creates the BEBLID descriptor.
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
         *      BEBLID::SIZE_512_BITS or BEBLID::SIZE_256_BITS.
         * return automatically generated
         */
        public static BEBLID create(float scale_factor)
        {


            return BEBLID.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BEBLID_create_11(scale_factor)));


        }


        //
        // C++:  void cv::xfeatures2d::BEBLID::setScaleFactor(float scale_factor)
        //

        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();

            xfeatures2d_BEBLID_setScaleFactor_10(nativeObj, scale_factor);


        }


        //
        // C++:  float cv::xfeatures2d::BEBLID::getScaleFactor()
        //

        public float getScaleFactor()
        {
            ThrowIfDisposed();

            return xfeatures2d_BEBLID_getScaleFactor_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::BEBLID::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BEBLID_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_BEBLID cv::xfeatures2d::BEBLID::create(float scale_factor, int n_bits = BEBLID::SIZE_512_BITS)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BEBLID_create_10(float scale_factor, int n_bits);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BEBLID_create_11(float scale_factor);

        // C++:  void cv::xfeatures2d::BEBLID::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BEBLID_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  float cv::xfeatures2d::BEBLID::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_BEBLID_getScaleFactor_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::BEBLID::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BEBLID_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BEBLID_delete(IntPtr nativeObj);

    }
}
