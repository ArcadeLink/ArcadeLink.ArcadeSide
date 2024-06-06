
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Img_hashModule
{

    // C++: class BlockMeanHash
    /**
     * Image hash based on block mean.
     *
     * See CITE: zauner2010implementation for details.
     */

    public class BlockMeanHash : ImgHashBase
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
                        img_1hash_BlockMeanHash_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BlockMeanHash(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BlockMeanHash __fromPtr__(IntPtr addr) { return new BlockMeanHash(addr); }

        //
        // C++:  void cv::img_hash::BlockMeanHash::setMode(int mode)
        //

        /**
         * Create BlockMeanHash object
         *         param mode the mode
         */
        public void setMode(int mode)
        {
            ThrowIfDisposed();

            img_1hash_BlockMeanHash_setMode_10(nativeObj, mode);


        }


        //
        // C++:  vector_double cv::img_hash::BlockMeanHash::getMean()
        //

        public MatOfDouble getMean()
        {
            ThrowIfDisposed();

            return MatOfDouble.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(img_1hash_BlockMeanHash_getMean_10(nativeObj)));


        }


        //
        // C++: static Ptr_BlockMeanHash cv::img_hash::BlockMeanHash::create(int mode = BLOCK_MEAN_HASH_MODE_0)
        //

        public static BlockMeanHash create(int mode)
        {


            return BlockMeanHash.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(img_1hash_BlockMeanHash_create_10(mode)));


        }

        public static BlockMeanHash create()
        {


            return BlockMeanHash.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(img_1hash_BlockMeanHash_create_11()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::img_hash::BlockMeanHash::setMode(int mode)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_BlockMeanHash_setMode_10(IntPtr nativeObj, int mode);

        // C++:  vector_double cv::img_hash::BlockMeanHash::getMean()
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_BlockMeanHash_getMean_10(IntPtr nativeObj);

        // C++: static Ptr_BlockMeanHash cv::img_hash::BlockMeanHash::create(int mode = BLOCK_MEAN_HASH_MODE_0)
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_BlockMeanHash_create_10(int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_BlockMeanHash_create_11();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void img_1hash_BlockMeanHash_delete(IntPtr nativeObj);

    }
}
