using OpenCVForUnity.CoreModule;
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.UtilsModule
{

    public class MatIndexer
    {

        private readonly Mat parent;

        private readonly long[] steps;

        private readonly long ptrVal;

        public MatIndexer(Mat mat)
        {
            if (mat == null)
                throw new ArgumentNullException("mat");
            if (mat != null)
                mat.ThrowIfDisposed();

            this.parent = mat;

            var dims = parent.dims();
            steps = new long[dims];
            for (var i = 0; i < dims; i++)
            {
                steps[i] = parent.step1(i);
            }

            ptrVal = parent.dataAddr();
        }

        public void get(int row, int col, byte[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(ptr, data, 0, (int)steps[1]);
        }

        public void get(int[] idx, byte[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(ptr, data, 0, (int)steps[idx.Length - 1]);
        }

        public void get(int row, int col, short[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(ptr, data, 0, (int)steps[1]);
        }

        public void get(int[] idx, short[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(ptr, data, 0, (int)steps[idx.Length - 1]);
        }

        public void get(int row, int col, int[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(ptr, data, 0, (int)steps[1]);
        }

        public void get(int[] idx, int[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(ptr, data, 0, (int)steps[idx.Length - 1]);
        }

        public void get(int row, int col, float[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(ptr, data, 0, (int)steps[1]);
        }

        public void get(int[] idx, float[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(ptr, data, 0, (int)steps[idx.Length - 1]);
        }

        public void get(int row, int col, double[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(ptr, data, 0, (int)steps[1]);
        }

        public void get(int[] idx, double[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(ptr, data, 0, (int)steps[idx.Length - 1]);
        }


        public void put(int row, int col, byte[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(data, 0, ptr, (int)steps[1]);
        }

        public void put(int[] idx, byte[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(data, 0, ptr, (int)steps[idx.Length - 1]);
        }

        public void put(int row, int col, short[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(data, 0, ptr, (int)steps[1]);
        }

        public void put(int[] idx, short[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(data, 0, ptr, (int)steps[idx.Length - 1]);
        }

        public void put(int row, int col, int[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(data, 0, ptr, (int)steps[1]);
        }

        public void put(int[] idx, int[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(data, 0, ptr, (int)steps[idx.Length - 1]);
        }

        public void put(int row, int col, float[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(data, 0, ptr, (int)steps[1]);
        }

        public void put(int[] idx, float[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(data, 0, ptr, (int)steps[idx.Length - 1]);
        }

        public void put(int row, int col, double[] data)
        {
            IntPtr ptr = new IntPtr(ptrVal + (steps[0] * row) + (steps[1] * col));
            Marshal.Copy(data, 0, ptr, (int)steps[1]);
        }

        public void put(int[] idx, double[] data)
        {
            long offset = 0;
            for (var i = 0; i < idx.Length; i++)
            {
                offset += steps[i] * idx[i];
            }

            IntPtr ptr = new IntPtr(ptrVal + offset);
            Marshal.Copy(data, 0, ptr, (int)steps[idx.Length - 1]);
        }
    }

}
