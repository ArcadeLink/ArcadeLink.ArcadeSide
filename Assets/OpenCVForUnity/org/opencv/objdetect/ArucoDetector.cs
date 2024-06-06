
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{

    // C++: class ArucoDetector
    /**
     * The main functionality of ArucoDetector class is detection of markers in an image with detectMarkers() method.
     *
     * After detecting some markers in the image, you can try to find undetected markers from this dictionary with
     * refineDetectedMarkers() method.
     *
     * SEE: DetectorParameters, RefineParameters
     */

    public class ArucoDetector : Algorithm
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
                        objdetect_ArucoDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ArucoDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ArucoDetector __fromPtr__(IntPtr addr) { return new ArucoDetector(addr); }

        //
        // C++:   cv::aruco::ArucoDetector::ArucoDetector(Dictionary dictionary = getPredefinedDictionary(cv::aruco::DICT_4X4_50), DetectorParameters detectorParams = DetectorParameters(), RefineParameters refineParams = RefineParameters())
        //

        /**
         * Basic ArucoDetector constructor
         *
         * param dictionary indicates the type of markers that will be searched
         * param detectorParams marker detection parameters
         * param refineParams marker refine detection parameters
         */
        public ArucoDetector(Dictionary dictionary, DetectorParameters detectorParams, RefineParameters refineParams) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_ArucoDetector_10(dictionary.nativeObj, detectorParams.nativeObj, refineParams.nativeObj)))
        {



        }

        /**
         * Basic ArucoDetector constructor
         *
         * param dictionary indicates the type of markers that will be searched
         * param detectorParams marker detection parameters
         */
        public ArucoDetector(Dictionary dictionary, DetectorParameters detectorParams) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_ArucoDetector_11(dictionary.nativeObj, detectorParams.nativeObj)))
        {



        }

        /**
         * Basic ArucoDetector constructor
         *
         * param dictionary indicates the type of markers that will be searched
         */
        public ArucoDetector(Dictionary dictionary) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_ArucoDetector_12(dictionary.nativeObj)))
        {



        }

        /**
         * Basic ArucoDetector constructor
         *
         */
        public ArucoDetector() :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_ArucoDetector_13()))
        {



        }


        //
        // C++:  void cv::aruco::ArucoDetector::detectMarkers(Mat image, vector_Mat& corners, Mat& ids, vector_Mat& rejectedImgPoints = vector_Mat())
        //

        /**
         * Basic marker detection
         *
         * param image input image
         * param corners vector of detected marker corners. For each marker, its four corners
         * are provided, (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers,
         * the dimensions of this array is Nx4. The order of the corners is clockwise.
         * param ids vector of identifiers of the detected markers. The identifier is of type int
         * (e.g. std::vector&lt;int&gt;). For N detected markers, the size of ids is also N.
         * The identifiers have the same order than the markers in the imgPoints array.
         * param rejectedImgPoints contains the imgPoints of those squares whose inner code has not a
         * correct codification. Useful for debugging purposes.
         *
         * Performs marker detection in the input image. Only markers included in the specific dictionary
         * are searched. For each detected marker, it returns the 2D position of its corner in the image
         * and its corresponding identifier.
         * Note that this function does not perform pose estimation.
         * <b>Note:</b> The function does not correct lens distortion or takes it into account. It's recommended to undistort
         * input image with corresponding camera model, if camera parameters are known
         * SEE: undistort, estimatePoseSingleMarkers,  estimatePoseBoard
         */
        public void detectMarkers(Mat image, List<Mat> corners, Mat ids, List<Mat> rejectedImgPoints)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            Mat corners_mat = new Mat();
            Mat rejectedImgPoints_mat = new Mat();
            objdetect_ArucoDetector_detectMarkers_10(nativeObj, image.nativeObj, corners_mat.nativeObj, ids.nativeObj, rejectedImgPoints_mat.nativeObj);
            Converters.Mat_to_vector_Mat(corners_mat, corners);
            corners_mat.release();
            Converters.Mat_to_vector_Mat(rejectedImgPoints_mat, rejectedImgPoints);
            rejectedImgPoints_mat.release();

        }

        /**
         * Basic marker detection
         *
         * param image input image
         * param corners vector of detected marker corners. For each marker, its four corners
         * are provided, (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers,
         * the dimensions of this array is Nx4. The order of the corners is clockwise.
         * param ids vector of identifiers of the detected markers. The identifier is of type int
         * (e.g. std::vector&lt;int&gt;). For N detected markers, the size of ids is also N.
         * The identifiers have the same order than the markers in the imgPoints array.
         * correct codification. Useful for debugging purposes.
         *
         * Performs marker detection in the input image. Only markers included in the specific dictionary
         * are searched. For each detected marker, it returns the 2D position of its corner in the image
         * and its corresponding identifier.
         * Note that this function does not perform pose estimation.
         * <b>Note:</b> The function does not correct lens distortion or takes it into account. It's recommended to undistort
         * input image with corresponding camera model, if camera parameters are known
         * SEE: undistort, estimatePoseSingleMarkers,  estimatePoseBoard
         */
        public void detectMarkers(Mat image, List<Mat> corners, Mat ids)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            Mat corners_mat = new Mat();
            objdetect_ArucoDetector_detectMarkers_11(nativeObj, image.nativeObj, corners_mat.nativeObj, ids.nativeObj);
            Converters.Mat_to_vector_Mat(corners_mat, corners);
            corners_mat.release();

        }


        //
        // C++:  void cv::aruco::ArucoDetector::refineDetectedMarkers(Mat image, Board board, vector_Mat& detectedCorners, Mat& detectedIds, vector_Mat& rejectedCorners, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), Mat& recoveredIdxs = Mat())
        //

        /**
         * Refine not detected markers based on the already detected and the board layout
         *
         * param image input image
         * param board layout of markers in the board.
         * param detectedCorners vector of already detected marker corners.
         * param detectedIds vector of already detected marker identifiers.
         * param rejectedCorners vector of rejected candidates during the marker detection process.
         * param cameraMatrix optional input 3x3 floating-point camera matrix
         * \(A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\)
         * param distCoeffs optional vector of distortion coefficients
         * \((k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])\) of 4, 5, 8 or 12 elements
         * param recoveredIdxs Optional array to returns the indexes of the recovered candidates in the
         * original rejectedCorners array.
         *
         * This function tries to find markers that were not detected in the basic detecMarkers function.
         * First, based on the current detected marker and the board layout, the function interpolates
         * the position of the missing markers. Then it tries to find correspondence between the reprojected
         * markers and the rejected candidates based on the minRepDistance and errorCorrectionRate parameters.
         * If camera parameters and distortion coefficients are provided, missing markers are reprojected
         * using projectPoint function. If not, missing marker projections are interpolated using global
         * homography, and all the marker corners in the board must have the same Z coordinate.
         */
        public void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, Mat recoveredIdxs)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (recoveredIdxs != null) recoveredIdxs.ThrowIfDisposed();
            Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
            Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
            objdetect_ArucoDetector_refineDetectedMarkers_10(nativeObj, image.nativeObj, board.nativeObj, detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, recoveredIdxs.nativeObj);
            Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
            detectedCorners_mat.release();
            Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
            rejectedCorners_mat.release();

        }

        /**
         * Refine not detected markers based on the already detected and the board layout
         *
         * param image input image
         * param board layout of markers in the board.
         * param detectedCorners vector of already detected marker corners.
         * param detectedIds vector of already detected marker identifiers.
         * param rejectedCorners vector of rejected candidates during the marker detection process.
         * param cameraMatrix optional input 3x3 floating-point camera matrix
         * \(A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\)
         * param distCoeffs optional vector of distortion coefficients
         * \((k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])\) of 4, 5, 8 or 12 elements
         * original rejectedCorners array.
         *
         * This function tries to find markers that were not detected in the basic detecMarkers function.
         * First, based on the current detected marker and the board layout, the function interpolates
         * the position of the missing markers. Then it tries to find correspondence between the reprojected
         * markers and the rejected candidates based on the minRepDistance and errorCorrectionRate parameters.
         * If camera parameters and distortion coefficients are provided, missing markers are reprojected
         * using projectPoint function. If not, missing marker projections are interpolated using global
         * homography, and all the marker corners in the board must have the same Z coordinate.
         */
        public void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
            Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
            objdetect_ArucoDetector_refineDetectedMarkers_11(nativeObj, image.nativeObj, board.nativeObj, detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
            Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
            detectedCorners_mat.release();
            Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
            rejectedCorners_mat.release();

        }

        /**
         * Refine not detected markers based on the already detected and the board layout
         *
         * param image input image
         * param board layout of markers in the board.
         * param detectedCorners vector of already detected marker corners.
         * param detectedIds vector of already detected marker identifiers.
         * param rejectedCorners vector of rejected candidates during the marker detection process.
         * param cameraMatrix optional input 3x3 floating-point camera matrix
         * \(A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\)
         * \((k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])\) of 4, 5, 8 or 12 elements
         * original rejectedCorners array.
         *
         * This function tries to find markers that were not detected in the basic detecMarkers function.
         * First, based on the current detected marker and the board layout, the function interpolates
         * the position of the missing markers. Then it tries to find correspondence between the reprojected
         * markers and the rejected candidates based on the minRepDistance and errorCorrectionRate parameters.
         * If camera parameters and distortion coefficients are provided, missing markers are reprojected
         * using projectPoint function. If not, missing marker projections are interpolated using global
         * homography, and all the marker corners in the board must have the same Z coordinate.
         */
        public void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
            Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
            objdetect_ArucoDetector_refineDetectedMarkers_12(nativeObj, image.nativeObj, board.nativeObj, detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj);
            Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
            detectedCorners_mat.release();
            Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
            rejectedCorners_mat.release();

        }

        /**
         * Refine not detected markers based on the already detected and the board layout
         *
         * param image input image
         * param board layout of markers in the board.
         * param detectedCorners vector of already detected marker corners.
         * param detectedIds vector of already detected marker identifiers.
         * param rejectedCorners vector of rejected candidates during the marker detection process.
         * \(A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\)
         * \((k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])\) of 4, 5, 8 or 12 elements
         * original rejectedCorners array.
         *
         * This function tries to find markers that were not detected in the basic detecMarkers function.
         * First, based on the current detected marker and the board layout, the function interpolates
         * the position of the missing markers. Then it tries to find correspondence between the reprojected
         * markers and the rejected candidates based on the minRepDistance and errorCorrectionRate parameters.
         * If camera parameters and distortion coefficients are provided, missing markers are reprojected
         * using projectPoint function. If not, missing marker projections are interpolated using global
         * homography, and all the marker corners in the board must have the same Z coordinate.
         */
        public void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
            Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
            objdetect_ArucoDetector_refineDetectedMarkers_13(nativeObj, image.nativeObj, board.nativeObj, detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj);
            Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
            detectedCorners_mat.release();
            Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
            rejectedCorners_mat.release();

        }


        //
        // C++:  Dictionary cv::aruco::ArucoDetector::getDictionary()
        //

        public Dictionary getDictionary()
        {
            ThrowIfDisposed();

            return new Dictionary(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_getDictionary_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::ArucoDetector::setDictionary(Dictionary dictionary)
        //

        public void setDictionary(Dictionary dictionary)
        {
            ThrowIfDisposed();
            if (dictionary != null) dictionary.ThrowIfDisposed();

            objdetect_ArucoDetector_setDictionary_10(nativeObj, dictionary.nativeObj);


        }


        //
        // C++:  DetectorParameters cv::aruco::ArucoDetector::getDetectorParameters()
        //

        public DetectorParameters getDetectorParameters()
        {
            ThrowIfDisposed();

            return new DetectorParameters(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_getDetectorParameters_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::ArucoDetector::setDetectorParameters(DetectorParameters detectorParameters)
        //

        public void setDetectorParameters(DetectorParameters detectorParameters)
        {
            ThrowIfDisposed();
            if (detectorParameters != null) detectorParameters.ThrowIfDisposed();

            objdetect_ArucoDetector_setDetectorParameters_10(nativeObj, detectorParameters.nativeObj);


        }


        //
        // C++:  RefineParameters cv::aruco::ArucoDetector::getRefineParameters()
        //

        public RefineParameters getRefineParameters()
        {
            ThrowIfDisposed();

            return new RefineParameters(DisposableObject.ThrowIfNullIntPtr(objdetect_ArucoDetector_getRefineParameters_10(nativeObj)));


        }


        //
        // C++:  void cv::aruco::ArucoDetector::setRefineParameters(RefineParameters refineParameters)
        //

        public void setRefineParameters(RefineParameters refineParameters)
        {
            ThrowIfDisposed();
            if (refineParameters != null) refineParameters.ThrowIfDisposed();

            objdetect_ArucoDetector_setRefineParameters_10(nativeObj, refineParameters.nativeObj);


        }


        //
        // C++:  void cv::aruco::ArucoDetector::write(FileStorage fs, String name)
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++:  void cv::aruco::ArucoDetector::read(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::ArucoDetector::ArucoDetector(Dictionary dictionary = getPredefinedDictionary(cv::aruco::DICT_4X4_50), DetectorParameters detectorParams = DetectorParameters(), RefineParameters refineParams = RefineParameters())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_ArucoDetector_10(IntPtr dictionary_nativeObj, IntPtr detectorParams_nativeObj, IntPtr refineParams_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_ArucoDetector_11(IntPtr dictionary_nativeObj, IntPtr detectorParams_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_ArucoDetector_12(IntPtr dictionary_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_ArucoDetector_13();

        // C++:  void cv::aruco::ArucoDetector::detectMarkers(Mat image, vector_Mat& corners, Mat& ids, vector_Mat& rejectedImgPoints = vector_Mat())
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_detectMarkers_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr rejectedImgPoints_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_detectMarkers_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj);

        // C++:  void cv::aruco::ArucoDetector::refineDetectedMarkers(Mat image, Board board, vector_Mat& detectedCorners, Mat& detectedIds, vector_Mat& rejectedCorners, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), Mat& recoveredIdxs = Mat())
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_refineDetectedMarkers_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr recoveredIdxs_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_refineDetectedMarkers_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_refineDetectedMarkers_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_refineDetectedMarkers_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj);

        // C++:  Dictionary cv::aruco::ArucoDetector::getDictionary()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_getDictionary_10(IntPtr nativeObj);

        // C++:  void cv::aruco::ArucoDetector::setDictionary(Dictionary dictionary)
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_setDictionary_10(IntPtr nativeObj, IntPtr dictionary_nativeObj);

        // C++:  DetectorParameters cv::aruco::ArucoDetector::getDetectorParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_getDetectorParameters_10(IntPtr nativeObj);

        // C++:  void cv::aruco::ArucoDetector::setDetectorParameters(DetectorParameters detectorParameters)
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_setDetectorParameters_10(IntPtr nativeObj, IntPtr detectorParameters_nativeObj);

        // C++:  RefineParameters cv::aruco::ArucoDetector::getRefineParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_ArucoDetector_getRefineParameters_10(IntPtr nativeObj);

        // C++:  void cv::aruco::ArucoDetector::setRefineParameters(RefineParameters refineParameters)
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_setRefineParameters_10(IntPtr nativeObj, IntPtr refineParameters_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_ArucoDetector_delete(IntPtr nativeObj);

    }
}
