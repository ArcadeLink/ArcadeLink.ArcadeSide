
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{

    // C++: class CharucoDetector


    public class CharucoDetector : Algorithm
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
                        objdetect_CharucoDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CharucoDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CharucoDetector __fromPtr__(IntPtr addr) { return new CharucoDetector(addr); }

        //
        // C++:   cv::aruco::CharucoDetector::CharucoDetector(CharucoBoard board, CharucoParameters charucoParams = CharucoParameters(), DetectorParameters detectorParams = DetectorParameters(), RefineParameters refineParams = RefineParameters())
        //

        /**
         * Basic CharucoDetector constructor
         *
         * param board ChAruco board
         * param charucoParams charuco detection parameters
         * param detectorParams marker detection parameters
         * param refineParams marker refine detection parameters
         */
        public CharucoDetector(CharucoBoard board, CharucoParameters charucoParams, DetectorParameters detectorParams, RefineParameters refineParams) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_CharucoDetector_10(board.nativeObj, charucoParams.nativeObj, detectorParams.nativeObj, refineParams.nativeObj)))
        {



        }

        /**
         * Basic CharucoDetector constructor
         *
         * param board ChAruco board
         * param charucoParams charuco detection parameters
         * param detectorParams marker detection parameters
         */
        public CharucoDetector(CharucoBoard board, CharucoParameters charucoParams, DetectorParameters detectorParams) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_CharucoDetector_11(board.nativeObj, charucoParams.nativeObj, detectorParams.nativeObj)))
        {



        }

        /**
         * Basic CharucoDetector constructor
         *
         * param board ChAruco board
         * param charucoParams charuco detection parameters
         */
        public CharucoDetector(CharucoBoard board, CharucoParameters charucoParams) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_CharucoDetector_12(board.nativeObj, charucoParams.nativeObj)))
        {



        }

        /**
         * Basic CharucoDetector constructor
         *
         * param board ChAruco board
         */
        public CharucoDetector(CharucoBoard board) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_CharucoDetector_13(board.nativeObj)))
        {



        }


        //
        // C++:  CharucoBoard cv::aruco::CharucoDetector::getBoard()
        //

        public CharucoBoard getBoard()
        {
            ThrowIfDisposed();

            return new CharucoBoard(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_getBoard_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::CharucoDetector::setBoard(CharucoBoard board)
        //

        public void setBoard(CharucoBoard board)
        {
            ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();

            objdetect_CharucoDetector_setBoard_10(nativeObj, board.nativeObj);


        }


        //
        // C++:  CharucoParameters cv::aruco::CharucoDetector::getCharucoParameters()
        //

        public CharucoParameters getCharucoParameters()
        {
            ThrowIfDisposed();

            return new CharucoParameters(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_getCharucoParameters_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::CharucoDetector::setCharucoParameters(CharucoParameters charucoParameters)
        //

        public void setCharucoParameters(CharucoParameters charucoParameters)
        {
            ThrowIfDisposed();
            if (charucoParameters != null) charucoParameters.ThrowIfDisposed();

            objdetect_CharucoDetector_setCharucoParameters_10(nativeObj, charucoParameters.nativeObj);


        }


        //
        // C++:  DetectorParameters cv::aruco::CharucoDetector::getDetectorParameters()
        //

        public DetectorParameters getDetectorParameters()
        {
            ThrowIfDisposed();

            return new DetectorParameters(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_getDetectorParameters_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::CharucoDetector::setDetectorParameters(DetectorParameters detectorParameters)
        //

        public void setDetectorParameters(DetectorParameters detectorParameters)
        {
            ThrowIfDisposed();
            if (detectorParameters != null) detectorParameters.ThrowIfDisposed();

            objdetect_CharucoDetector_setDetectorParameters_10(nativeObj, detectorParameters.nativeObj);


        }


        //
        // C++:  RefineParameters cv::aruco::CharucoDetector::getRefineParameters()
        //

        public RefineParameters getRefineParameters()
        {
            ThrowIfDisposed();

            return new RefineParameters(DisposableObject.ThrowIfNullIntPtr(objdetect_CharucoDetector_getRefineParameters_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::CharucoDetector::setRefineParameters(RefineParameters refineParameters)
        //

        public void setRefineParameters(RefineParameters refineParameters)
        {
            ThrowIfDisposed();
            if (refineParameters != null) refineParameters.ThrowIfDisposed();

            objdetect_CharucoDetector_setRefineParameters_10(nativeObj, refineParameters.nativeObj);


        }


        //
        // C++:  void cv::aruco::CharucoDetector::detectBoard(Mat image, Mat& charucoCorners, Mat& charucoIds, vector_Mat& markerCorners = vector_Mat(), Mat& markerIds = Mat())
        //

        /**
         * detect aruco markers and interpolate position of ChArUco board corners
         * param image input image necesary for corner refinement. Note that markers are not detected and
         * should be sent in corners and ids parameters.
         * param charucoCorners interpolated chessboard corners.
         * param charucoIds interpolated chessboard corners identifiers.
         * param markerCorners vector of already detected markers corners. For each marker, its four
         * corners are provided, (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the
         * dimensions of this array should be Nx4. The order of the corners should be clockwise.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         * param markerIds list of identifiers for each marker in corners.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         *
         * This function receives the detected markers and returns the 2D position of the chessboard corners
         * from a ChArUco board using the detected Aruco markers.
         *
         * If markerCorners and markerCorners are empty, the detectMarkers() will run and detect aruco markers and ids.
         *
         * If camera parameters are provided, the process is based in an approximated pose estimation, else it is based on local homography.
         * Only visible corners are returned. For each corner, its corresponding identifier is also returned in charucoIds.
         * SEE: findChessboardCorners
         */
        public void detectBoard(Mat image, Mat charucoCorners, Mat charucoIds, List<Mat> markerCorners, Mat markerIds)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            if (markerIds != null) markerIds.ThrowIfDisposed();
            Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
            objdetect_CharucoDetector_detectBoard_10(nativeObj, image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj, markerCorners_mat.nativeObj, markerIds.nativeObj);
            Converters.Mat_to_vector_Mat(markerCorners_mat, markerCorners);
            markerCorners_mat.release();

        }

        /**
         * detect aruco markers and interpolate position of ChArUco board corners
         * param image input image necesary for corner refinement. Note that markers are not detected and
         * should be sent in corners and ids parameters.
         * param charucoCorners interpolated chessboard corners.
         * param charucoIds interpolated chessboard corners identifiers.
         * param markerCorners vector of already detected markers corners. For each marker, its four
         * corners are provided, (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the
         * dimensions of this array should be Nx4. The order of the corners should be clockwise.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         *
         * This function receives the detected markers and returns the 2D position of the chessboard corners
         * from a ChArUco board using the detected Aruco markers.
         *
         * If markerCorners and markerCorners are empty, the detectMarkers() will run and detect aruco markers and ids.
         *
         * If camera parameters are provided, the process is based in an approximated pose estimation, else it is based on local homography.
         * Only visible corners are returned. For each corner, its corresponding identifier is also returned in charucoIds.
         * SEE: findChessboardCorners
         */
        public void detectBoard(Mat image, Mat charucoCorners, Mat charucoIds, List<Mat> markerCorners)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
            objdetect_CharucoDetector_detectBoard_11(nativeObj, image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj, markerCorners_mat.nativeObj);
            Converters.Mat_to_vector_Mat(markerCorners_mat, markerCorners);
            markerCorners_mat.release();

        }

        /**
         * detect aruco markers and interpolate position of ChArUco board corners
         * param image input image necesary for corner refinement. Note that markers are not detected and
         * should be sent in corners and ids parameters.
         * param charucoCorners interpolated chessboard corners.
         * param charucoIds interpolated chessboard corners identifiers.
         * corners are provided, (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the
         * dimensions of this array should be Nx4. The order of the corners should be clockwise.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         *
         * This function receives the detected markers and returns the 2D position of the chessboard corners
         * from a ChArUco board using the detected Aruco markers.
         *
         * If markerCorners and markerCorners are empty, the detectMarkers() will run and detect aruco markers and ids.
         *
         * If camera parameters are provided, the process is based in an approximated pose estimation, else it is based on local homography.
         * Only visible corners are returned. For each corner, its corresponding identifier is also returned in charucoIds.
         * SEE: findChessboardCorners
         */
        public void detectBoard(Mat image, Mat charucoCorners, Mat charucoIds)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();

            objdetect_CharucoDetector_detectBoard_12(nativeObj, image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj);


        }


        //
        // C++:  void cv::aruco::CharucoDetector::detectDiamonds(Mat image, vector_Mat& diamondCorners, Mat& diamondIds, vector_Mat& markerCorners = vector_Mat(), Mat& markerIds = Mat())
        //

        /**
         * Detect ChArUco Diamond markers
         *
         * param image input image necessary for corner subpixel.
         * param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
         * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
         * format than the corners returned by detectMarkers (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ).
         * param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
         * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
         * diamond.
         * param markerCorners list of detected marker corners from detectMarkers function.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         * param markerIds list of marker ids in markerCorners.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         *
         * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
         * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
         * are provided, the diamond search is based on reprojection. If not, diamond search is based on
         * homography. Homography is faster than reprojection, but less accurate.
         */
        public void detectDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds, List<Mat> markerCorners, Mat markerIds)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            if (markerIds != null) markerIds.ThrowIfDisposed();
            Mat diamondCorners_mat = new Mat();
            Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
            objdetect_CharucoDetector_detectDiamonds_10(nativeObj, image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj, markerCorners_mat.nativeObj, markerIds.nativeObj);
            Converters.Mat_to_vector_Mat(diamondCorners_mat, diamondCorners);
            diamondCorners_mat.release();
            Converters.Mat_to_vector_Mat(markerCorners_mat, markerCorners);
            markerCorners_mat.release();

        }

        /**
         * Detect ChArUco Diamond markers
         *
         * param image input image necessary for corner subpixel.
         * param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
         * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
         * format than the corners returned by detectMarkers (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ).
         * param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
         * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
         * diamond.
         * param markerCorners list of detected marker corners from detectMarkers function.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         *
         * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
         * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
         * are provided, the diamond search is based on reprojection. If not, diamond search is based on
         * homography. Homography is faster than reprojection, but less accurate.
         */
        public void detectDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds, List<Mat> markerCorners)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            Mat diamondCorners_mat = new Mat();
            Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
            objdetect_CharucoDetector_detectDiamonds_11(nativeObj, image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj, markerCorners_mat.nativeObj);
            Converters.Mat_to_vector_Mat(diamondCorners_mat, diamondCorners);
            diamondCorners_mat.release();
            Converters.Mat_to_vector_Mat(markerCorners_mat, markerCorners);
            markerCorners_mat.release();

        }

        /**
         * Detect ChArUco Diamond markers
         *
         * param image input image necessary for corner subpixel.
         * param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
         * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
         * format than the corners returned by detectMarkers (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ).
         * param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
         * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
         * diamond.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
         *
         * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
         * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
         * are provided, the diamond search is based on reprojection. If not, diamond search is based on
         * homography. Homography is faster than reprojection, but less accurate.
         */
        public void detectDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            Mat diamondCorners_mat = new Mat();
            objdetect_CharucoDetector_detectDiamonds_12(nativeObj, image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj);
            Converters.Mat_to_vector_Mat(diamondCorners_mat, diamondCorners);
            diamondCorners_mat.release();

        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::CharucoDetector::CharucoDetector(CharucoBoard board, CharucoParameters charucoParams = CharucoParameters(), DetectorParameters detectorParams = DetectorParameters(), RefineParameters refineParams = RefineParameters())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_CharucoDetector_10(IntPtr board_nativeObj, IntPtr charucoParams_nativeObj, IntPtr detectorParams_nativeObj, IntPtr refineParams_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_CharucoDetector_11(IntPtr board_nativeObj, IntPtr charucoParams_nativeObj, IntPtr detectorParams_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_CharucoDetector_12(IntPtr board_nativeObj, IntPtr charucoParams_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_CharucoDetector_13(IntPtr board_nativeObj);

        // C++:  CharucoBoard cv::aruco::CharucoDetector::getBoard()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_getBoard_10(IntPtr nativeObj);

        // C++:  void cv::aruco::CharucoDetector::setBoard(CharucoBoard board)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_setBoard_10(IntPtr nativeObj, IntPtr board_nativeObj);

        // C++:  CharucoParameters cv::aruco::CharucoDetector::getCharucoParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_getCharucoParameters_10(IntPtr nativeObj);

        // C++:  void cv::aruco::CharucoDetector::setCharucoParameters(CharucoParameters charucoParameters)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_setCharucoParameters_10(IntPtr nativeObj, IntPtr charucoParameters_nativeObj);

        // C++:  DetectorParameters cv::aruco::CharucoDetector::getDetectorParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_getDetectorParameters_10(IntPtr nativeObj);

        // C++:  void cv::aruco::CharucoDetector::setDetectorParameters(DetectorParameters detectorParameters)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_setDetectorParameters_10(IntPtr nativeObj, IntPtr detectorParameters_nativeObj);

        // C++:  RefineParameters cv::aruco::CharucoDetector::getRefineParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CharucoDetector_getRefineParameters_10(IntPtr nativeObj);

        // C++:  void cv::aruco::CharucoDetector::setRefineParameters(RefineParameters refineParameters)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_setRefineParameters_10(IntPtr nativeObj, IntPtr refineParameters_nativeObj);

        // C++:  void cv::aruco::CharucoDetector::detectBoard(Mat image, Mat& charucoCorners, Mat& charucoIds, vector_Mat& markerCorners = vector_Mat(), Mat& markerIds = Mat())
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_detectBoard_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_detectBoard_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr markerCorners_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_detectBoard_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj);

        // C++:  void cv::aruco::CharucoDetector::detectDiamonds(Mat image, vector_Mat& diamondCorners, Mat& diamondIds, vector_Mat& markerCorners = vector_Mat(), Mat& markerIds = Mat())
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_detectDiamonds_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj, IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_detectDiamonds_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj, IntPtr markerCorners_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_detectDiamonds_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CharucoDetector_delete(IntPtr nativeObj);

    }
}
