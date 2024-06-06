using UnityEngine;

using System;

namespace OpenCVForUnity
{
    abstract public class DisposableObject : IDisposable
    {

        public bool IsDisposed { get; protected set; }

        public bool IsEnabledDispose { get; set; }

        protected DisposableObject()
            : this(true)
        {
        }

        protected DisposableObject(bool isEnabledDispose)
        {
            IsEnabledDispose = isEnabledDispose;
            IsDisposed = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {

                if (disposing)
                {
                }

                IsDisposed = true;
            }
        }

        ~DisposableObject()
        {
            Dispose(false);
        }

        public void ThrowIfDisposed()
        {
            if (IsDisposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        public static IntPtr ThrowIfNullIntPtr(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                throw new CoreModule.CvException("An error occurred on the C++ side, causing the class initialization to fail.Enclose the point where the error occurs in Utils.setDebugMode() method, and the error on the C++ side will be displayed on the console.");

            return ptr;
        }

    }
}
