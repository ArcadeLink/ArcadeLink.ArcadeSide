

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.CoreModule
{
    // C++: class Algorithm
    /**
     * This is a base class for all more or less complex algorithms in OpenCV
     *
     * especially for classes of algorithms, for which there can be multiple implementations. The examples
     * are stereo correspondence (for which there are algorithms like block matching, semi-global block
     * matching, graph-cut etc.), background subtraction (which can be done using mixture-of-gaussians
     * models, codebook-based algorithm etc.), optical flow (block matching, Lucas-Kanade, Horn-Schunck
     * etc.).
     *
     * Here is example of SimpleBlobDetector use in your application via Algorithm interface:
     * SNIPPET: snippets/core_various.cpp Algorithm
     */

    public class Algorithm : DisposableOpenCVObject
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
                        core_Algorithm_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Algorithm(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Algorithm __fromPtr__(IntPtr addr) { return new Algorithm(addr); }

        //
        // C++:  void cv::Algorithm::clear()
        //

        /**
         * Clears the algorithm state
         */
        public virtual void clear()
        {
            ThrowIfDisposed();

            core_Algorithm_clear_10(nativeObj);


        }


        //
        // C++:  void cv::Algorithm::write(FileStorage fs)
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++:  void cv::Algorithm::write(FileStorage fs, String name)
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++:  void cv::Algorithm::read(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  bool cv::Algorithm::empty()
        //

        /**
         * Returns true if the Algorithm is empty (e.g. in the very beginning or after unsuccessful read
         * return automatically generated
         */
        public virtual bool empty()
        {
            ThrowIfDisposed();

            return core_Algorithm_empty_10(nativeObj);


        }


        //
        // C++:  void cv::Algorithm::save(String filename)
        //

        /**
         * Saves the algorithm to a file.
         * In order to make this method work, the derived class must implement Algorithm::write(FileStorage&amp; fs).
         * param filename automatically generated
         */
        public void save(string filename)
        {
            ThrowIfDisposed();

            core_Algorithm_save_10(nativeObj, filename);


        }


        //
        // C++:  String cv::Algorithm::getDefaultName()
        //

        /**
         * Returns the algorithm string identifier.
         * This string is used as top level xml/yml node tag when the object is saved to a file or string.
         * return automatically generated
         */
        public virtual string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Algorithm_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::Algorithm::clear()
        [DllImport(LIBNAME)]
        private static extern void core_Algorithm_clear_10(IntPtr nativeObj);

        // C++:  bool cv::Algorithm::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Algorithm_empty_10(IntPtr nativeObj);

        // C++:  void cv::Algorithm::save(String filename)
        [DllImport(LIBNAME)]
        private static extern void core_Algorithm_save_10(IntPtr nativeObj, string filename);

        // C++:  String cv::Algorithm::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Algorithm_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void core_Algorithm_delete(IntPtr nativeObj);

    }
}
