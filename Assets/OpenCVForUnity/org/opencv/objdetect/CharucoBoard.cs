
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{

    // C++: class CharucoBoard
    /**
     * ChArUco board is a planar chessboard where the markers are placed inside the white squares of a chessboard.
     *
     * The benefits of ChArUco boards is that they provide both, ArUco markers versatility and chessboard corner precision,
     * which is important for calibration and pose estimation. The board image can be drawn using generateImage() method.
     */

    public class CharucoBoard : Board
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
                        objdetect_CharucoBoard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CharucoBoard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CharucoBoard __fromPtr__(IntPtr addr) { return new CharucoBoard(addr); }

        //
        // C++:   cv::aruco::CharucoBoard::CharucoBoard(Size size, float squareLength, float markerLength, Dictionary dictionary, Mat ids = Mat())
        //

        /**
         * CharucoBoard constructor
         *
         * param size number of chessboard squares in x and y directions
         * param squareLength squareLength chessboard square side length (normally in meters)
         * param markerLength marker side length (same unit than squareLength)
         * param dictionary dictionary of markers indicating the type of markers
         * param ids array of id used markers
         * The first markers in the dictionary are used to fill the white chessboard squares.
         */
        public CharucoBoard(Size size, float squareLength, float markerLength, Dictionary dictionary, Mat ids) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoBoard_CharucoBoard_10(size.width, size.height, squareLength, markerLength, dictionary.nativeObj, ids.nativeObj)))
        {



        }

        /**
         * CharucoBoard constructor
         *
         * param size number of chessboard squares in x and y directions
         * param squareLength squareLength chessboard square side length (normally in meters)
         * param markerLength marker side length (same unit than squareLength)
         * param dictionary dictionary of markers indicating the type of markers
         * The first markers in the dictionary are used to fill the white chessboard squares.
         */
        public CharucoBoard(Size size, float squareLength, float markerLength, Dictionary dictionary) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoBoard_CharucoBoard_11(size.width, size.height, squareLength, markerLength, dictionary.nativeObj)))
        {



        }


        //
        // C++:  void cv::aruco::CharucoBoard::setLegacyPattern(bool legacyPattern)
        //

        /**
         * set legacy chessboard pattern.
         *
         * Legacy setting creates chessboard patterns starting with a white box in the upper left corner
         * if there is an even row count of chessboard boxes, otherwise it starts with a black box.
         * This setting ensures compatibility to patterns created with OpenCV versions prior OpenCV 4.6.0.
         * See https://github.com/opencv/opencv/issues/23152.
         *
         * Default value: false.
         * param legacyPattern automatically generated
         */
        public void setLegacyPattern(bool legacyPattern)
        {
            ThrowIfDisposed();

            objdetect_CharucoBoard_setLegacyPattern_10(nativeObj, legacyPattern);


        }


        //
        // C++:  bool cv::aruco::CharucoBoard::getLegacyPattern()
        //

        public bool getLegacyPattern()
        {
            ThrowIfDisposed();

            return objdetect_CharucoBoard_getLegacyPattern_10(nativeObj);


        }


        //
        // C++:  Size cv::aruco::CharucoBoard::getChessboardSize()
        //

        public Size getChessboardSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_CharucoBoard_getChessboardSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  float cv::aruco::CharucoBoard::getSquareLength()
        //

        public float getSquareLength()
        {
            ThrowIfDisposed();

            return objdetect_CharucoBoard_getSquareLength_10(nativeObj);


        }


        //
        // C++:  float cv::aruco::CharucoBoard::getMarkerLength()
        //

        public float getMarkerLength()
        {
            ThrowIfDisposed();

            return objdetect_CharucoBoard_getMarkerLength_10(nativeObj);


        }


        //
        // C++:  vector_Point3f cv::aruco::CharucoBoard::getChessboardCorners()
        //

        /**
         * get CharucoBoard::chessboardCorners
         * return automatically generated
         */
        public MatOfPoint3f getChessboardCorners()
        {
            ThrowIfDisposed();

            return MatOfPoint3f.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoBoard_getChessboardCorners_10(nativeObj)));


        }


        //
        // C++:  bool cv::aruco::CharucoBoard::checkCharucoCornersCollinear(Mat charucoIds)
        //

        /**
         * check whether the ChArUco markers are collinear
         *
         * param charucoIds list of identifiers for each corner in charucoCorners per frame.
         * return bool value, 1 (true) if detected corners form a line, 0 (false) if they do not.
         * solvePnP, calibration functions will fail if the corners are collinear (true).
         *
         * The number of ids in charucoIDs should be &lt;= the number of chessboard corners in the board.
         * This functions checks whether the charuco corners are on a straight line (returns true, if so), or not (false).
         * Axis parallel, as well as diagonal and other straight lines detected.  Degenerate cases:
         * for number of charucoIDs &lt;= 2,the function returns true.
         */
        public bool checkCharucoCornersCollinear(Mat charucoIds)
        {
            ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();

            return objdetect_CharucoBoard_checkCharucoCornersCollinear_10(nativeObj, charucoIds.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::CharucoBoard::CharucoBoard(Size size, float squareLength, float markerLength, Dictionary dictionary, Mat ids = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoBoard_CharucoBoard_10(double size_width, double size_height, float squareLength, float markerLength, IntPtr dictionary_nativeObj, IntPtr ids_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoBoard_CharucoBoard_11(double size_width, double size_height, float squareLength, float markerLength, IntPtr dictionary_nativeObj);

        // C++:  void cv::aruco::CharucoBoard::setLegacyPattern(bool legacyPattern)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoBoard_setLegacyPattern_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool legacyPattern);

        // C++:  bool cv::aruco::CharucoBoard::getLegacyPattern()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CharucoBoard_getLegacyPattern_10(IntPtr nativeObj);

        // C++:  Size cv::aruco::CharucoBoard::getChessboardSize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoBoard_getChessboardSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  float cv::aruco::CharucoBoard::getSquareLength()
        [DllImport(LIBNAME)]
        private static extern float objdetect_CharucoBoard_getSquareLength_10(IntPtr nativeObj);

        // C++:  float cv::aruco::CharucoBoard::getMarkerLength()
        [DllImport(LIBNAME)]
        private static extern float objdetect_CharucoBoard_getMarkerLength_10(IntPtr nativeObj);

        // C++:  vector_Point3f cv::aruco::CharucoBoard::getChessboardCorners()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoBoard_getChessboardCorners_10(IntPtr nativeObj);

        // C++:  bool cv::aruco::CharucoBoard::checkCharucoCornersCollinear(Mat charucoIds)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CharucoBoard_checkCharucoCornersCollinear_10(IntPtr nativeObj, IntPtr charucoIds_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoBoard_delete(IntPtr nativeObj);

    }
}
