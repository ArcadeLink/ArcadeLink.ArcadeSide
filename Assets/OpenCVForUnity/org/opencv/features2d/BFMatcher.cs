
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class BFMatcher
    /**
     * Brute-force descriptor matcher.
     *
     * For each descriptor in the first set, this matcher finds the closest descriptor in the second set
     * by trying each one. This descriptor matcher supports masking permissible matches of descriptor
     * sets.
     */

    public class BFMatcher : DescriptorMatcher
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
                        features2d_BFMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BFMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BFMatcher __fromPtr__(IntPtr addr) { return new BFMatcher(addr); }

        //
        // C++:   cv::BFMatcher::BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        //

        /**
         * Brute-force matcher constructor (obsolete). Please use BFMatcher.create()
         *
         *
         * param normType automatically generated
         * param crossCheck automatically generated
         */
        public BFMatcher(int normType, bool crossCheck) :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BFMatcher_BFMatcher_10(normType, crossCheck)))
        {



        }

        /**
         * Brute-force matcher constructor (obsolete). Please use BFMatcher.create()
         *
         *
         * param normType automatically generated
         */
        public BFMatcher(int normType) :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BFMatcher_BFMatcher_11(normType)))
        {



        }

        /**
         * Brute-force matcher constructor (obsolete). Please use BFMatcher.create()
         *
         *
         */
        public BFMatcher() :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BFMatcher_BFMatcher_12()))
        {



        }


        //
        // C++: static Ptr_BFMatcher cv::BFMatcher::create(int normType = NORM_L2, bool crossCheck = false)
        //

        /**
         * Brute-force matcher create method.
         *     param normType One of NORM_L1, NORM_L2, NORM_HAMMING, NORM_HAMMING2. L1 and L2 norms are
         *     preferable choices for SIFT and SURF descriptors, NORM_HAMMING should be used with ORB, BRISK and
         *     BRIEF, NORM_HAMMING2 should be used with ORB when WTA_K==3 or 4 (see ORB::ORB constructor
         *     description).
         *     param crossCheck If it is false, this is will be default BFMatcher behaviour when it finds the k
         *     nearest neighbors for each query descriptor. If crossCheck==true, then the knnMatch() method with
         *     k=1 will only return pairs (i,j) such that for i-th query descriptor the j-th descriptor in the
         *     matcher's collection is the nearest and vice versa, i.e. the BFMatcher will only return consistent
         *     pairs. Such technique usually produces best results with minimal number of outliers when there are
         *     enough matches. This is alternative to the ratio test, used by D. Lowe in SIFT paper.
         * return automatically generated
         */
        public static BFMatcher create(int normType, bool crossCheck)
        {


            return BFMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BFMatcher_create_10(normType, crossCheck)));


        }

        /**
         * Brute-force matcher create method.
         *     param normType One of NORM_L1, NORM_L2, NORM_HAMMING, NORM_HAMMING2. L1 and L2 norms are
         *     preferable choices for SIFT and SURF descriptors, NORM_HAMMING should be used with ORB, BRISK and
         *     BRIEF, NORM_HAMMING2 should be used with ORB when WTA_K==3 or 4 (see ORB::ORB constructor
         *     description).
         *     nearest neighbors for each query descriptor. If crossCheck==true, then the knnMatch() method with
         *     k=1 will only return pairs (i,j) such that for i-th query descriptor the j-th descriptor in the
         *     matcher's collection is the nearest and vice versa, i.e. the BFMatcher will only return consistent
         *     pairs. Such technique usually produces best results with minimal number of outliers when there are
         *     enough matches. This is alternative to the ratio test, used by D. Lowe in SIFT paper.
         * return automatically generated
         */
        public static new BFMatcher create(int normType)
        {


            return BFMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BFMatcher_create_11(normType)));


        }

        /**
         * Brute-force matcher create method.
         *     preferable choices for SIFT and SURF descriptors, NORM_HAMMING should be used with ORB, BRISK and
         *     BRIEF, NORM_HAMMING2 should be used with ORB when WTA_K==3 or 4 (see ORB::ORB constructor
         *     description).
         *     nearest neighbors for each query descriptor. If crossCheck==true, then the knnMatch() method with
         *     k=1 will only return pairs (i,j) such that for i-th query descriptor the j-th descriptor in the
         *     matcher's collection is the nearest and vice versa, i.e. the BFMatcher will only return consistent
         *     pairs. Such technique usually produces best results with minimal number of outliers when there are
         *     enough matches. This is alternative to the ratio test, used by D. Lowe in SIFT paper.
         * return automatically generated
         */
        public static BFMatcher create()
        {


            return BFMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BFMatcher_create_12()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::BFMatcher::BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_10(int normType, [MarshalAs(UnmanagedType.U1)] bool crossCheck);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_11(int normType);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_12();

        // C++: static Ptr_BFMatcher cv::BFMatcher::create(int normType = NORM_L2, bool crossCheck = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_10(int normType, [MarshalAs(UnmanagedType.U1)] bool crossCheck);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_11(int normType);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BFMatcher_delete(IntPtr nativeObj);

    }
}
