
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{

    // C++: class GridBoard
    /**
     * Planar board with grid arrangement of markers
     *
     * More common type of board. All markers are placed in the same plane in a grid arrangement.
     * The board image can be drawn using generateImage() method.
     */

    public class GridBoard : Board
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
                        objdetect_GridBoard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GridBoard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GridBoard __fromPtr__(IntPtr addr) { return new GridBoard(addr); }

        //
        // C++:   cv::aruco::GridBoard::GridBoard(Size size, float markerLength, float markerSeparation, Dictionary dictionary, Mat ids = Mat())
        //

        /**
         * GridBoard constructor
         *
         * param size number of markers in x and y directions
         * param markerLength marker side length (normally in meters)
         * param markerSeparation separation between two markers (same unit as markerLength)
         * param dictionary dictionary of markers indicating the type of markers
         * param ids set of marker ids in dictionary to use on board.
         */
        public GridBoard(Size size, float markerLength, float markerSeparation, Dictionary dictionary, Mat ids) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_GridBoard_GridBoard_10(size.width, size.height, markerLength, markerSeparation, dictionary.nativeObj, ids.nativeObj)))
        {



        }

        /**
         * GridBoard constructor
         *
         * param size number of markers in x and y directions
         * param markerLength marker side length (normally in meters)
         * param markerSeparation separation between two markers (same unit as markerLength)
         * param dictionary dictionary of markers indicating the type of markers
         */
        public GridBoard(Size size, float markerLength, float markerSeparation, Dictionary dictionary) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_GridBoard_GridBoard_11(size.width, size.height, markerLength, markerSeparation, dictionary.nativeObj)))
        {



        }


        //
        // C++:  Size cv::aruco::GridBoard::getGridSize()
        //

        public Size getGridSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_GridBoard_getGridSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  float cv::aruco::GridBoard::getMarkerLength()
        //

        public float getMarkerLength()
        {
            ThrowIfDisposed();

            return objdetect_GridBoard_getMarkerLength_10(nativeObj);


        }


        //
        // C++:  float cv::aruco::GridBoard::getMarkerSeparation()
        //

        public float getMarkerSeparation()
        {
            ThrowIfDisposed();

            return objdetect_GridBoard_getMarkerSeparation_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::GridBoard::GridBoard(Size size, float markerLength, float markerSeparation, Dictionary dictionary, Mat ids = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GridBoard_GridBoard_10(double size_width, double size_height, float markerLength, float markerSeparation, IntPtr dictionary_nativeObj, IntPtr ids_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GridBoard_GridBoard_11(double size_width, double size_height, float markerLength, float markerSeparation, IntPtr dictionary_nativeObj);

        // C++:  Size cv::aruco::GridBoard::getGridSize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_GridBoard_getGridSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  float cv::aruco::GridBoard::getMarkerLength()
        [DllImport(LIBNAME)]
        private static extern float objdetect_GridBoard_getMarkerLength_10(IntPtr nativeObj);

        // C++:  float cv::aruco::GridBoard::getMarkerSeparation()
        [DllImport(LIBNAME)]
        private static extern float objdetect_GridBoard_getMarkerSeparation_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_GridBoard_delete(IntPtr nativeObj);

    }
}
