
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Img_hashModule
{

    // C++: class AverageHash
    /**
     * Computes average hash value of the input image
     *
     * This is a fast image hashing algorithm, but only work on simple case. For more details, please
     * refer to CITE: lookslikeit
     */

    public class AverageHash : ImgHashBase
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
                        img_1hash_AverageHash_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AverageHash(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AverageHash __fromPtr__(IntPtr addr) { return new AverageHash(addr); }

        //
        // C++: static Ptr_AverageHash cv::img_hash::AverageHash::create()
        //

        public static AverageHash create()
        {


            return AverageHash.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(img_1hash_AverageHash_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_AverageHash cv::img_hash::AverageHash::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_AverageHash_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void img_1hash_AverageHash_delete(IntPtr nativeObj);

    }
}
