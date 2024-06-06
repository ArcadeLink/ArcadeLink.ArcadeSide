using OpenCVForUnity.CoreModule;
using System;
using System.Runtime.InteropServices;

#if OPENCV_USE_UNSAFE_CODE && UNITY_2018_1_OR_NEWER
using Unity.Collections.LowLevel.Unsafe;
using Unity.Collections;
#endif

namespace OpenCVForUnity.UtilsModule
{
    public static class MatUtils
    {
        /**
        * Copies OpenCV Mat data to Pixel Data IntPtr.
        * <p>
        * <br>This method copies the OpenCV Mat data to the pixel data IntPtr.
        * <br>The pixel data must have the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this method doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object.
        * @param intPtr the pixel data must have the same byte size as the Mat data ([total() * elemSize()] byte).
        */
        public static void copyFromMat(Mat mat, IntPtr intPtr)
        {
            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            if (intPtr == IntPtr.Zero)
                throw new ArgumentException("intPtr == IntPtr.Zero");

            OpenCVForUnity_MatDataToByteArray(mat.nativeObj, intPtr);
        }

        /**
        * Copies Pixel Data IntPtr to OpenCV Mat data.
        * <p>
        * <br>This method copy the pixel data IntPtr to the OpenCV Mat data.
        * <br>The Mat object must have the same byte size as the pixel data ([total() * elemSize()] byte).
        * <br>Because this method doesn't check bounds, is faster than Mat.put().
        * 
        * @param intPtr a pixel data IntPtr.
        * @param mat the Mat object must have the same byte size as the pixel data ([total() * elemSize()] byte).
        */
        public static void copyToMat(IntPtr intPtr, Mat mat)
        {
            if (intPtr == IntPtr.Zero)
                throw new ArgumentException("intPtr == IntPtr.Zero");

            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            OpenCVForUnity_ByteArrayToMatData(intPtr, mat.nativeObj);
        }

        /**
        * Copies OpenCV Mat data to Pixel Data Array.
        * <p>
        * <br>This method copies the OpenCV Mat data to the pixel data Array.
        * <br>The pixel data Array must have the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this method doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object.
        * @param array the pixel data Array must have the same byte size as the Mat data ([total() * elemSize()] byte).
        */
        public static void copyFromMat<T>(Mat mat, T[] array) where T : struct
        {
            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            if (array == null)
                throw new ArgumentNullException("array");

            GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            OpenCVForUnity_MatDataToByteArray(mat.nativeObj, arrayHandle.AddrOfPinnedObject());
            arrayHandle.Free();
        }

        /**
        * Copies Pixel Data Array to OpenCV Mat data.
        * <p>
        * <br>This method copies the pixel data Array to the OpenCV Mat data.
        * <br>The Mat object must have the same byte size as the pixel data Array ([total() * elemSize()] byte).
        * <br>Because this method doesn't check bounds, is faster than Mat.put().
        * 
        * @param array a pixel data Array.
        * @param mat the Mat object must have the same byte size as the pixel data Array ([total() * elemSize()] byte).
        */
        public static void copyToMat<T>(T[] array, Mat mat) where T : struct
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            OpenCVForUnity_ByteArrayToMatData(arrayHandle.AddrOfPinnedObject(), mat.nativeObj);
            arrayHandle.Free();
        }

#if OPENCV_USE_UNSAFE_CODE && UNITY_2018_1_OR_NEWER
        /**
        * Copies OpenCV Mat data to Pixel Data NativeArray.
        * <p>
        * <br>This method copies the OpenCV Mat data to the pixel data NativeArray.
        * <br>The pixel data Array must have the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this method doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object.
        * @param array the pixel data Array must have the same byte size as the Mat data ([total() * elemSize()] byte).
        */
        public static void copyFromMat<T>(Mat mat, NativeArray<T> array) where T : struct
        {
            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            unsafe
            {
                OpenCVForUnity_MatDataToByteArray(mat.nativeObj, (IntPtr)NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr(array));
            }
        }

        /**
        * Copies Pixel Data NativeArray to OpenCV Mat data.
        * <p>
        * <br>This method copies the pixel data NativeArray to the OpenCV Mat data.
        * <br>The Mat object must have the same byte size as the pixel data Array ([total() * elemSize()] byte).
        * <br>Because this method doesn't check bounds, is faster than Mat.put().
        * 
        * @param array a pixel data Array.
        * @param mat the Mat object must have the same byte size as the pixel data Array ([total() * elemSize()] byte).
        */
        public static void copyToMat<T>(NativeArray<T> array, Mat mat) where T : struct
        {
            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            unsafe
            {
                OpenCVForUnity_ByteArrayToMatData((IntPtr)NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr(array), mat.nativeObj);
            }
        }
#endif


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_MatDataToByteArray(IntPtr mat, IntPtr byteArray);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_ByteArrayToMatData(IntPtr byteArray, IntPtr Mat);
    }
}