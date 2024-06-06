
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class FlannBasedMatcher
    /**
     * Flann-based descriptor matcher.
     *
     * This matcher trains cv::flann::Index on a train descriptor collection and calls its nearest search
     * methods to find the best matches. So, this matcher may be faster when matching a large train
     * collection than the brute force matcher. FlannBasedMatcher does not support masking permissible
     * matches of descriptor sets because flann::Index does not support this. :
     */

    public class FlannBasedMatcher : DescriptorMatcher
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
                        features2d_FlannBasedMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FlannBasedMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FlannBasedMatcher __fromPtr__(IntPtr addr) { return new FlannBasedMatcher(addr); }

        //
        // C++:   cv::FlannBasedMatcher::FlannBasedMatcher(Ptr_flann_IndexParams indexParams = makePtr<flann::KDTreeIndexParams>(), Ptr_flann_SearchParams searchParams = makePtr<flann::SearchParams>())
        //

        public FlannBasedMatcher() :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_FlannBasedMatcher_FlannBasedMatcher_10()))
        {



        }


        //
        // C++: static Ptr_FlannBasedMatcher cv::FlannBasedMatcher::create()
        //

        public static FlannBasedMatcher create()
        {


            return FlannBasedMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_FlannBasedMatcher_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::FlannBasedMatcher::FlannBasedMatcher(Ptr_flann_IndexParams indexParams = makePtr<flann::KDTreeIndexParams>(), Ptr_flann_SearchParams searchParams = makePtr<flann::SearchParams>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FlannBasedMatcher_FlannBasedMatcher_10();

        // C++: static Ptr_FlannBasedMatcher cv::FlannBasedMatcher::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FlannBasedMatcher_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_FlannBasedMatcher_delete(IntPtr nativeObj);

    }
}
