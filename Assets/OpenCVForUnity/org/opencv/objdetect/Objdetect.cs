
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class Objdetect


    public class Objdetect
    {

        // C++: enum <unnamed>
        public const int CASCADE_DO_CANNY_PRUNING = 1;
        public const int CASCADE_SCALE_IMAGE = 2;
        public const int CASCADE_FIND_BIGGEST_OBJECT = 4;
        public const int CASCADE_DO_ROUGH_SEARCH = 8;
        // C++: enum cv.DetectionBasedTracker.ObjectStatus
        public const int DetectionBasedTracker_DETECTED_NOT_SHOWN_YET = 0;
        public const int DetectionBasedTracker_DETECTED = 1;
        public const int DetectionBasedTracker_DETECTED_TEMPORARY_LOST = 2;
        public const int DetectionBasedTracker_WRONG_OBJECT = 3;
        // C++: enum cv.aruco.CornerRefineMethod
        public const int CORNER_REFINE_NONE = 0;
        public const int CORNER_REFINE_SUBPIX = 1;
        public const int CORNER_REFINE_CONTOUR = 2;
        public const int CORNER_REFINE_APRILTAG = 3;
        // C++: enum cv.aruco.PredefinedDictionaryType
        public const int DICT_4X4_50 = 0;
        public const int DICT_4X4_100 = 0 + 1;
        public const int DICT_4X4_250 = 0 + 2;
        public const int DICT_4X4_1000 = 0 + 3;
        public const int DICT_5X5_50 = 0 + 4;
        public const int DICT_5X5_100 = 0 + 5;
        public const int DICT_5X5_250 = 0 + 6;
        public const int DICT_5X5_1000 = 0 + 7;
        public const int DICT_6X6_50 = 0 + 8;
        public const int DICT_6X6_100 = 0 + 9;
        public const int DICT_6X6_250 = 0 + 10;
        public const int DICT_6X6_1000 = 0 + 11;
        public const int DICT_7X7_50 = 0 + 12;
        public const int DICT_7X7_100 = 0 + 13;
        public const int DICT_7X7_250 = 0 + 14;
        public const int DICT_7X7_1000 = 0 + 15;
        public const int DICT_ARUCO_ORIGINAL = 0 + 16;
        public const int DICT_APRILTAG_16h5 = 0 + 17;
        public const int DICT_APRILTAG_25h9 = 0 + 18;
        public const int DICT_APRILTAG_36h10 = 0 + 19;
        public const int DICT_APRILTAG_36h11 = 0 + 20;
        public const int DICT_ARUCO_MIP_36h12 = 0 + 21;
        //
        // C++:  void cv::groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        //

        public static void groupRectangles(MatOfRect rectList, MatOfInt weights, int groupThreshold, double eps)
        {
            if (rectList != null) rectList.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat rectList_mat = rectList;
            Mat weights_mat = weights;
            objdetect_Objdetect_groupRectangles_10(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold, eps);


        }

        public static void groupRectangles(MatOfRect rectList, MatOfInt weights, int groupThreshold)
        {
            if (rectList != null) rectList.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat rectList_mat = rectList;
            Mat weights_mat = weights;
            objdetect_Objdetect_groupRectangles_11(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold);


        }


        //
        // C++:  void cv::aruco::drawDetectedMarkers(Mat& image, vector_Mat corners, Mat ids = Mat(), Scalar borderColor = Scalar(0, 255, 0))
        //

        /**
         * Draw detected markers in image
         *
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not altered.
         * param corners positions of marker corners on input image.
         * (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the dimensions of
         * this array should be Nx4. The order of the corners should be clockwise.
         * param ids vector of identifiers for markers in markersCorners .
         * Optional, if not provided, ids are not painted.
         * param borderColor color of marker borders. Rest of colors (text color and first corner color)
         * are calculated based on this one to improve visualization.
         *
         * Given an array of detected marker corners and its corresponding ids, this functions draws
         * the markers in the image. The marker borders are painted and the markers identifiers if provided.
         * Useful for debugging purposes.
         */
        public static void drawDetectedMarkers(Mat image, List<Mat> corners, Mat ids, Scalar borderColor)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
            objdetect_Objdetect_drawDetectedMarkers_10(image.nativeObj, corners_mat.nativeObj, ids.nativeObj, borderColor.val[0], borderColor.val[1], borderColor.val[2], borderColor.val[3]);


        }

        /**
         * Draw detected markers in image
         *
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not altered.
         * param corners positions of marker corners on input image.
         * (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the dimensions of
         * this array should be Nx4. The order of the corners should be clockwise.
         * param ids vector of identifiers for markers in markersCorners .
         * Optional, if not provided, ids are not painted.
         * are calculated based on this one to improve visualization.
         *
         * Given an array of detected marker corners and its corresponding ids, this functions draws
         * the markers in the image. The marker borders are painted and the markers identifiers if provided.
         * Useful for debugging purposes.
         */
        public static void drawDetectedMarkers(Mat image, List<Mat> corners, Mat ids)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
            objdetect_Objdetect_drawDetectedMarkers_11(image.nativeObj, corners_mat.nativeObj, ids.nativeObj);


        }

        /**
         * Draw detected markers in image
         *
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not altered.
         * param corners positions of marker corners on input image.
         * (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the dimensions of
         * this array should be Nx4. The order of the corners should be clockwise.
         * Optional, if not provided, ids are not painted.
         * are calculated based on this one to improve visualization.
         *
         * Given an array of detected marker corners and its corresponding ids, this functions draws
         * the markers in the image. The marker borders are painted and the markers identifiers if provided.
         * Useful for debugging purposes.
         */
        public static void drawDetectedMarkers(Mat image, List<Mat> corners)
        {
            if (image != null) image.ThrowIfDisposed();
            Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
            objdetect_Objdetect_drawDetectedMarkers_12(image.nativeObj, corners_mat.nativeObj);


        }


        //
        // C++:  void cv::aruco::generateImageMarker(Dictionary dictionary, int id, int sidePixels, Mat& img, int borderBits = 1)
        //

        /**
         * Generate a canonical marker image
         *
         * param dictionary dictionary of markers indicating the type of markers
         * param id identifier of the marker that will be returned. It has to be a valid id in the specified dictionary.
         * param sidePixels size of the image in pixels
         * param img output image with the marker
         * param borderBits width of the marker border.
         *
         * This function returns a marker image in its canonical form (i.e. ready to be printed)
         */
        public static void generateImageMarker(Dictionary dictionary, int id, int sidePixels, Mat img, int borderBits)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            objdetect_Objdetect_generateImageMarker_10(dictionary.nativeObj, id, sidePixels, img.nativeObj, borderBits);


        }

        /**
         * Generate a canonical marker image
         *
         * param dictionary dictionary of markers indicating the type of markers
         * param id identifier of the marker that will be returned. It has to be a valid id in the specified dictionary.
         * param sidePixels size of the image in pixels
         * param img output image with the marker
         *
         * This function returns a marker image in its canonical form (i.e. ready to be printed)
         */
        public static void generateImageMarker(Dictionary dictionary, int id, int sidePixels, Mat img)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            objdetect_Objdetect_generateImageMarker_11(dictionary.nativeObj, id, sidePixels, img.nativeObj);


        }


        //
        // C++:  Dictionary cv::aruco::getPredefinedDictionary(int dict)
        //

        /**
         * Returns one of the predefined dictionaries referenced by DICT_*.
         * param dict automatically generated
         * return automatically generated
         */
        public static Dictionary getPredefinedDictionary(int dict)
        {


            return new Dictionary(DisposableObject.ThrowIfNullIntPtr(objdetect_Objdetect_getPredefinedDictionary_10(dict)));


        }


        //
        // C++:  Dictionary cv::aruco::extendDictionary(int nMarkers, int markerSize, Dictionary baseDictionary = Dictionary(), int randomSeed = 0)
        //

        /**
         * Extend base dictionary by new nMarkers
         *
         * param nMarkers number of markers in the dictionary
         * param markerSize number of bits per dimension of each markers
         * param baseDictionary Include the markers in this dictionary at the beginning (optional)
         * param randomSeed a user supplied seed for theRNG()
         *
         * This function creates a new dictionary composed by nMarkers markers and each markers composed
         * by markerSize x markerSize bits. If baseDictionary is provided, its markers are directly
         * included and the rest are generated based on them. If the size of baseDictionary is higher
         * than nMarkers, only the first nMarkers in baseDictionary are taken and no new marker is added.
         * return automatically generated
         */
        public static Dictionary extendDictionary(int nMarkers, int markerSize, Dictionary baseDictionary, int randomSeed)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();

            return new Dictionary(DisposableObject.ThrowIfNullIntPtr(objdetect_Objdetect_extendDictionary_10(nMarkers, markerSize, baseDictionary.nativeObj, randomSeed)));


        }

        /**
         * Extend base dictionary by new nMarkers
         *
         * param nMarkers number of markers in the dictionary
         * param markerSize number of bits per dimension of each markers
         * param baseDictionary Include the markers in this dictionary at the beginning (optional)
         *
         * This function creates a new dictionary composed by nMarkers markers and each markers composed
         * by markerSize x markerSize bits. If baseDictionary is provided, its markers are directly
         * included and the rest are generated based on them. If the size of baseDictionary is higher
         * than nMarkers, only the first nMarkers in baseDictionary are taken and no new marker is added.
         * return automatically generated
         */
        public static Dictionary extendDictionary(int nMarkers, int markerSize, Dictionary baseDictionary)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();

            return new Dictionary(DisposableObject.ThrowIfNullIntPtr(objdetect_Objdetect_extendDictionary_11(nMarkers, markerSize, baseDictionary.nativeObj)));


        }

        /**
         * Extend base dictionary by new nMarkers
         *
         * param nMarkers number of markers in the dictionary
         * param markerSize number of bits per dimension of each markers
         *
         * This function creates a new dictionary composed by nMarkers markers and each markers composed
         * by markerSize x markerSize bits. If baseDictionary is provided, its markers are directly
         * included and the rest are generated based on them. If the size of baseDictionary is higher
         * than nMarkers, only the first nMarkers in baseDictionary are taken and no new marker is added.
         * return automatically generated
         */
        public static Dictionary extendDictionary(int nMarkers, int markerSize)
        {


            return new Dictionary(DisposableObject.ThrowIfNullIntPtr(objdetect_Objdetect_extendDictionary_12(nMarkers, markerSize)));


        }


        //
        // C++:  void cv::aruco::drawDetectedCornersCharuco(Mat& image, Mat charucoCorners, Mat charucoIds = Mat(), Scalar cornerColor = Scalar(255, 0, 0))
        //

        /**
         * Draws a set of Charuco corners
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not
         * altered.
         * param charucoCorners vector of detected charuco corners
         * param charucoIds list of identifiers for each corner in charucoCorners
         * param cornerColor color of the square surrounding each corner
         *
         * This function draws a set of detected Charuco corners. If identifiers vector is provided, it also
         * draws the id of each corner.
         */
        public static void drawDetectedCornersCharuco(Mat image, Mat charucoCorners, Mat charucoIds, Scalar cornerColor)
        {
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();

            objdetect_Objdetect_drawDetectedCornersCharuco_10(image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj, cornerColor.val[0], cornerColor.val[1], cornerColor.val[2], cornerColor.val[3]);


        }

        /**
         * Draws a set of Charuco corners
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not
         * altered.
         * param charucoCorners vector of detected charuco corners
         * param charucoIds list of identifiers for each corner in charucoCorners
         *
         * This function draws a set of detected Charuco corners. If identifiers vector is provided, it also
         * draws the id of each corner.
         */
        public static void drawDetectedCornersCharuco(Mat image, Mat charucoCorners, Mat charucoIds)
        {
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();

            objdetect_Objdetect_drawDetectedCornersCharuco_11(image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj);


        }

        /**
         * Draws a set of Charuco corners
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not
         * altered.
         * param charucoCorners vector of detected charuco corners
         *
         * This function draws a set of detected Charuco corners. If identifiers vector is provided, it also
         * draws the id of each corner.
         */
        public static void drawDetectedCornersCharuco(Mat image, Mat charucoCorners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();

            objdetect_Objdetect_drawDetectedCornersCharuco_12(image.nativeObj, charucoCorners.nativeObj);


        }


        //
        // C++:  void cv::aruco::drawDetectedDiamonds(Mat& image, vector_Mat diamondCorners, Mat diamondIds = Mat(), Scalar borderColor = Scalar(0, 0, 255))
        //

        /**
         * Draw a set of detected ChArUco Diamond markers
         *
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not
         * altered.
         * param diamondCorners positions of diamond corners in the same format returned by
         * detectCharucoDiamond(). (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers,
         * the dimensions of this array should be Nx4. The order of the corners should be clockwise.
         * param diamondIds vector of identifiers for diamonds in diamondCorners, in the same format
         * returned by detectCharucoDiamond() (e.g. std::vector&lt;Vec4i&gt;).
         * Optional, if not provided, ids are not painted.
         * param borderColor color of marker borders. Rest of colors (text color and first corner color)
         * are calculated based on this one.
         *
         * Given an array of detected diamonds, this functions draws them in the image. The marker borders
         * are painted and the markers identifiers if provided.
         * Useful for debugging purposes.
         */
        public static void drawDetectedDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds, Scalar borderColor)
        {
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            Mat diamondCorners_mat = Converters.vector_Mat_to_Mat(diamondCorners);
            objdetect_Objdetect_drawDetectedDiamonds_10(image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj, borderColor.val[0], borderColor.val[1], borderColor.val[2], borderColor.val[3]);


        }

        /**
         * Draw a set of detected ChArUco Diamond markers
         *
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not
         * altered.
         * param diamondCorners positions of diamond corners in the same format returned by
         * detectCharucoDiamond(). (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers,
         * the dimensions of this array should be Nx4. The order of the corners should be clockwise.
         * param diamondIds vector of identifiers for diamonds in diamondCorners, in the same format
         * returned by detectCharucoDiamond() (e.g. std::vector&lt;Vec4i&gt;).
         * Optional, if not provided, ids are not painted.
         * are calculated based on this one.
         *
         * Given an array of detected diamonds, this functions draws them in the image. The marker borders
         * are painted and the markers identifiers if provided.
         * Useful for debugging purposes.
         */
        public static void drawDetectedDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds)
        {
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            Mat diamondCorners_mat = Converters.vector_Mat_to_Mat(diamondCorners);
            objdetect_Objdetect_drawDetectedDiamonds_11(image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj);


        }

        /**
         * Draw a set of detected ChArUco Diamond markers
         *
         * param image input/output image. It must have 1 or 3 channels. The number of channels is not
         * altered.
         * param diamondCorners positions of diamond corners in the same format returned by
         * detectCharucoDiamond(). (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers,
         * the dimensions of this array should be Nx4. The order of the corners should be clockwise.
         * returned by detectCharucoDiamond() (e.g. std::vector&lt;Vec4i&gt;).
         * Optional, if not provided, ids are not painted.
         * are calculated based on this one.
         *
         * Given an array of detected diamonds, this functions draws them in the image. The marker borders
         * are painted and the markers identifiers if provided.
         * Useful for debugging purposes.
         */
        public static void drawDetectedDiamonds(Mat image, List<Mat> diamondCorners)
        {
            if (image != null) image.ThrowIfDisposed();
            Mat diamondCorners_mat = Converters.vector_Mat_to_Mat(diamondCorners);
            objdetect_Objdetect_drawDetectedDiamonds_12(image.nativeObj, diamondCorners_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_groupRectangles_10(IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold, double eps);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_groupRectangles_11(IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold);

        // C++:  void cv::aruco::drawDetectedMarkers(Mat& image, vector_Mat corners, Mat ids = Mat(), Scalar borderColor = Scalar(0, 255, 0))
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedMarkers_10(IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, double borderColor_val0, double borderColor_val1, double borderColor_val2, double borderColor_val3);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedMarkers_11(IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedMarkers_12(IntPtr image_nativeObj, IntPtr corners_mat_nativeObj);

        // C++:  void cv::aruco::generateImageMarker(Dictionary dictionary, int id, int sidePixels, Mat& img, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_generateImageMarker_10(IntPtr dictionary_nativeObj, int id, int sidePixels, IntPtr img_nativeObj, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_generateImageMarker_11(IntPtr dictionary_nativeObj, int id, int sidePixels, IntPtr img_nativeObj);

        // C++:  Dictionary cv::aruco::getPredefinedDictionary(int dict)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Objdetect_getPredefinedDictionary_10(int dict);

        // C++:  Dictionary cv::aruco::extendDictionary(int nMarkers, int markerSize, Dictionary baseDictionary = Dictionary(), int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Objdetect_extendDictionary_10(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Objdetect_extendDictionary_11(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Objdetect_extendDictionary_12(int nMarkers, int markerSize);

        // C++:  void cv::aruco::drawDetectedCornersCharuco(Mat& image, Mat charucoCorners, Mat charucoIds = Mat(), Scalar cornerColor = Scalar(255, 0, 0))
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedCornersCharuco_10(IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, double cornerColor_val0, double cornerColor_val1, double cornerColor_val2, double cornerColor_val3);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedCornersCharuco_11(IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedCornersCharuco_12(IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj);

        // C++:  void cv::aruco::drawDetectedDiamonds(Mat& image, vector_Mat diamondCorners, Mat diamondIds = Mat(), Scalar borderColor = Scalar(0, 0, 255))
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedDiamonds_10(IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj, double borderColor_val0, double borderColor_val1, double borderColor_val2, double borderColor_val3);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedDiamonds_11(IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_drawDetectedDiamonds_12(IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj);

    }
}
