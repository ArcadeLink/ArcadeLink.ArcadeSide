//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class Dictionary;
@class IntVector;
@class Mat;
@class Rect2i;
@class Scalar;


// C++: enum ObjectStatus (cv.DetectionBasedTracker.ObjectStatus)
typedef NS_ENUM(int, ObjectStatus) {
    DetectionBasedTracker_DETECTED_NOT_SHOWN_YET NS_SWIFT_NAME(DETECTED_NOT_SHOWN_YET) = 0,
    DetectionBasedTracker_DETECTED NS_SWIFT_NAME(DETECTED) = 1,
    DetectionBasedTracker_DETECTED_TEMPORARY_LOST NS_SWIFT_NAME(DETECTED_TEMPORARY_LOST) = 2,
    DetectionBasedTracker_WRONG_OBJECT NS_SWIFT_NAME(WRONG_OBJECT) = 3
};


// C++: enum CornerRefineMethod (cv.aruco.CornerRefineMethod)
typedef NS_ENUM(int, CornerRefineMethod) {
    CORNER_REFINE_NONE = 0,
    CORNER_REFINE_SUBPIX = 1,
    CORNER_REFINE_CONTOUR = 2,
    CORNER_REFINE_APRILTAG = 3
};


// C++: enum PredefinedDictionaryType (cv.aruco.PredefinedDictionaryType)
typedef NS_ENUM(int, PredefinedDictionaryType) {
    DICT_4X4_50 = 0,
    DICT_4X4_100 = 0+1,
    DICT_4X4_250 = 0+2,
    DICT_4X4_1000 = 0+3,
    DICT_5X5_50 = 0+4,
    DICT_5X5_100 = 0+5,
    DICT_5X5_250 = 0+6,
    DICT_5X5_1000 = 0+7,
    DICT_6X6_50 = 0+8,
    DICT_6X6_100 = 0+9,
    DICT_6X6_250 = 0+10,
    DICT_6X6_1000 = 0+11,
    DICT_7X7_50 = 0+12,
    DICT_7X7_100 = 0+13,
    DICT_7X7_250 = 0+14,
    DICT_7X7_1000 = 0+15,
    DICT_ARUCO_ORIGINAL = 0+16,
    DICT_APRILTAG_16h5 = 0+17,
    DICT_APRILTAG_25h9 = 0+18,
    DICT_APRILTAG_36h10 = 0+19,
    DICT_APRILTAG_36h11 = 0+20,
    DICT_ARUCO_MIP_36h12 = 0+21
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Objdetect
/**
 * The Objdetect module
 *
 * Member classes: `BaseCascadeClassifier`, `CascadeClassifier`, `HOGDescriptor`, `QRCodeEncoder`, `QRCodeEncoderParams`, `QRCodeDetector`, `QRCodeDetectorAruco`, `QRCodeDetectorArucoParams`, `Board`, `GridBoard`, `CharucoBoard`, `DetectorParameters`, `RefineParameters`, `ArucoDetector`, `Dictionary`, `GraphicalCodeDetector`, `FaceDetectorYN`, `FaceRecognizerSF`, `CharucoParameters`, `CharucoDetector`, `BarcodeDetector`
 *
 * Member enums: `HistogramNormType`, `DescriptorStorageFormat`, `EncodeMode`, `CorrectionLevel`, `ECIEncodings`, `CornerRefineMethod`, `PredefinedDictionaryType`, `ObjectStatus`, `DisType`
 */
CV_EXPORTS @interface Objdetect : NSObject

#pragma mark - Class Constants


@property (class, readonly) int CASCADE_DO_CANNY_PRUNING NS_SWIFT_NAME(CASCADE_DO_CANNY_PRUNING);
@property (class, readonly) int CASCADE_SCALE_IMAGE NS_SWIFT_NAME(CASCADE_SCALE_IMAGE);
@property (class, readonly) int CASCADE_FIND_BIGGEST_OBJECT NS_SWIFT_NAME(CASCADE_FIND_BIGGEST_OBJECT);
@property (class, readonly) int CASCADE_DO_ROUGH_SEARCH NS_SWIFT_NAME(CASCADE_DO_ROUGH_SEARCH);

#pragma mark - Methods


//
//  void cv::groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
//
+ (void)groupRectangles:(NSMutableArray<Rect2i*>*)rectList weights:(IntVector*)weights groupThreshold:(int)groupThreshold eps:(double)eps NS_SWIFT_NAME(groupRectangles(rectList:weights:groupThreshold:eps:));

+ (void)groupRectangles:(NSMutableArray<Rect2i*>*)rectList weights:(IntVector*)weights groupThreshold:(int)groupThreshold NS_SWIFT_NAME(groupRectangles(rectList:weights:groupThreshold:));


//
//  void cv::aruco::drawDetectedMarkers(Mat& image, vector_Mat corners, Mat ids = Mat(), Scalar borderColor = Scalar(0, 255, 0))
//
/**
 * Draw detected markers in image
 *
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not altered.
 * @param corners positions of marker corners on input image.
 * (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the dimensions of
 * this array should be Nx4. The order of the corners should be clockwise.
 * @param ids vector of identifiers for markers in markersCorners .
 * Optional, if not provided, ids are not painted.
 * @param borderColor color of marker borders. Rest of colors (text color and first corner color)
 * are calculated based on this one to improve visualization.
 *
 * Given an array of detected marker corners and its corresponding ids, this functions draws
 * the markers in the image. The marker borders are painted and the markers identifiers if provided.
 * Useful for debugging purposes.
 */
+ (void)drawDetectedMarkers:(Mat*)image corners:(NSArray<Mat*>*)corners ids:(Mat*)ids borderColor:(Scalar*)borderColor NS_SWIFT_NAME(drawDetectedMarkers(image:corners:ids:borderColor:));

/**
 * Draw detected markers in image
 *
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not altered.
 * @param corners positions of marker corners on input image.
 * (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the dimensions of
 * this array should be Nx4. The order of the corners should be clockwise.
 * @param ids vector of identifiers for markers in markersCorners .
 * Optional, if not provided, ids are not painted.
 * are calculated based on this one to improve visualization.
 *
 * Given an array of detected marker corners and its corresponding ids, this functions draws
 * the markers in the image. The marker borders are painted and the markers identifiers if provided.
 * Useful for debugging purposes.
 */
+ (void)drawDetectedMarkers:(Mat*)image corners:(NSArray<Mat*>*)corners ids:(Mat*)ids NS_SWIFT_NAME(drawDetectedMarkers(image:corners:ids:));

/**
 * Draw detected markers in image
 *
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not altered.
 * @param corners positions of marker corners on input image.
 * (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the dimensions of
 * this array should be Nx4. The order of the corners should be clockwise.
 * Optional, if not provided, ids are not painted.
 * are calculated based on this one to improve visualization.
 *
 * Given an array of detected marker corners and its corresponding ids, this functions draws
 * the markers in the image. The marker borders are painted and the markers identifiers if provided.
 * Useful for debugging purposes.
 */
+ (void)drawDetectedMarkers:(Mat*)image corners:(NSArray<Mat*>*)corners NS_SWIFT_NAME(drawDetectedMarkers(image:corners:));


//
//  void cv::aruco::generateImageMarker(Dictionary dictionary, int id, int sidePixels, Mat& img, int borderBits = 1)
//
/**
 * Generate a canonical marker image
 *
 * @param dictionary dictionary of markers indicating the type of markers
 * @param id identifier of the marker that will be returned. It has to be a valid id in the specified dictionary.
 * @param sidePixels size of the image in pixels
 * @param img output image with the marker
 * @param borderBits width of the marker border.
 *
 * This function returns a marker image in its canonical form (i.e. ready to be printed)
 */
+ (void)generateImageMarker:(Dictionary*)dictionary id:(int)id sidePixels:(int)sidePixels img:(Mat*)img borderBits:(int)borderBits NS_SWIFT_NAME(generateImageMarker(dictionary:id:sidePixels:img:borderBits:));

/**
 * Generate a canonical marker image
 *
 * @param dictionary dictionary of markers indicating the type of markers
 * @param id identifier of the marker that will be returned. It has to be a valid id in the specified dictionary.
 * @param sidePixels size of the image in pixels
 * @param img output image with the marker
 *
 * This function returns a marker image in its canonical form (i.e. ready to be printed)
 */
+ (void)generateImageMarker:(Dictionary*)dictionary id:(int)id sidePixels:(int)sidePixels img:(Mat*)img NS_SWIFT_NAME(generateImageMarker(dictionary:id:sidePixels:img:));


//
//  Dictionary cv::aruco::getPredefinedDictionary(int dict)
//
/**
 * Returns one of the predefined dictionaries referenced by DICT_*.
 */
+ (Dictionary*)getPredefinedDictionary:(int)dict NS_SWIFT_NAME(getPredefinedDictionary(dict:));


//
//  Dictionary cv::aruco::extendDictionary(int nMarkers, int markerSize, Dictionary baseDictionary = Dictionary(), int randomSeed = 0)
//
/**
 * Extend base dictionary by new nMarkers
 *
 * @param nMarkers number of markers in the dictionary
 * @param markerSize number of bits per dimension of each markers
 * @param baseDictionary Include the markers in this dictionary at the beginning (optional)
 * @param randomSeed a user supplied seed for theRNG()
 *
 * This function creates a new dictionary composed by nMarkers markers and each markers composed
 * by markerSize x markerSize bits. If baseDictionary is provided, its markers are directly
 * included and the rest are generated based on them. If the size of baseDictionary is higher
 * than nMarkers, only the first nMarkers in baseDictionary are taken and no new marker is added.
 */
+ (Dictionary*)extendDictionary:(int)nMarkers markerSize:(int)markerSize baseDictionary:(Dictionary*)baseDictionary randomSeed:(int)randomSeed NS_SWIFT_NAME(extendDictionary(nMarkers:markerSize:baseDictionary:randomSeed:));

/**
 * Extend base dictionary by new nMarkers
 *
 * @param nMarkers number of markers in the dictionary
 * @param markerSize number of bits per dimension of each markers
 * @param baseDictionary Include the markers in this dictionary at the beginning (optional)
 *
 * This function creates a new dictionary composed by nMarkers markers and each markers composed
 * by markerSize x markerSize bits. If baseDictionary is provided, its markers are directly
 * included and the rest are generated based on them. If the size of baseDictionary is higher
 * than nMarkers, only the first nMarkers in baseDictionary are taken and no new marker is added.
 */
+ (Dictionary*)extendDictionary:(int)nMarkers markerSize:(int)markerSize baseDictionary:(Dictionary*)baseDictionary NS_SWIFT_NAME(extendDictionary(nMarkers:markerSize:baseDictionary:));

/**
 * Extend base dictionary by new nMarkers
 *
 * @param nMarkers number of markers in the dictionary
 * @param markerSize number of bits per dimension of each markers
 *
 * This function creates a new dictionary composed by nMarkers markers and each markers composed
 * by markerSize x markerSize bits. If baseDictionary is provided, its markers are directly
 * included and the rest are generated based on them. If the size of baseDictionary is higher
 * than nMarkers, only the first nMarkers in baseDictionary are taken and no new marker is added.
 */
+ (Dictionary*)extendDictionary:(int)nMarkers markerSize:(int)markerSize NS_SWIFT_NAME(extendDictionary(nMarkers:markerSize:));


//
//  void cv::aruco::drawDetectedCornersCharuco(Mat& image, Mat charucoCorners, Mat charucoIds = Mat(), Scalar cornerColor = Scalar(255, 0, 0))
//
/**
 * Draws a set of Charuco corners
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not
 * altered.
 * @param charucoCorners vector of detected charuco corners
 * @param charucoIds list of identifiers for each corner in charucoCorners
 * @param cornerColor color of the square surrounding each corner
 *
 * This function draws a set of detected Charuco corners. If identifiers vector is provided, it also
 * draws the id of each corner.
 */
+ (void)drawDetectedCornersCharuco:(Mat*)image charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds cornerColor:(Scalar*)cornerColor NS_SWIFT_NAME(drawDetectedCornersCharuco(image:charucoCorners:charucoIds:cornerColor:));

/**
 * Draws a set of Charuco corners
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not
 * altered.
 * @param charucoCorners vector of detected charuco corners
 * @param charucoIds list of identifiers for each corner in charucoCorners
 *
 * This function draws a set of detected Charuco corners. If identifiers vector is provided, it also
 * draws the id of each corner.
 */
+ (void)drawDetectedCornersCharuco:(Mat*)image charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds NS_SWIFT_NAME(drawDetectedCornersCharuco(image:charucoCorners:charucoIds:));

/**
 * Draws a set of Charuco corners
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not
 * altered.
 * @param charucoCorners vector of detected charuco corners
 *
 * This function draws a set of detected Charuco corners. If identifiers vector is provided, it also
 * draws the id of each corner.
 */
+ (void)drawDetectedCornersCharuco:(Mat*)image charucoCorners:(Mat*)charucoCorners NS_SWIFT_NAME(drawDetectedCornersCharuco(image:charucoCorners:));


//
//  void cv::aruco::drawDetectedDiamonds(Mat& image, vector_Mat diamondCorners, Mat diamondIds = Mat(), Scalar borderColor = Scalar(0, 0, 255))
//
/**
 * Draw a set of detected ChArUco Diamond markers
 *
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not
 * altered.
 * @param diamondCorners positions of diamond corners in the same format returned by
 * detectCharucoDiamond(). (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers,
 * the dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * @param diamondIds vector of identifiers for diamonds in diamondCorners, in the same format
 * returned by detectCharucoDiamond() (e.g. std::vector<Vec4i>).
 * Optional, if not provided, ids are not painted.
 * @param borderColor color of marker borders. Rest of colors (text color and first corner color)
 * are calculated based on this one.
 *
 * Given an array of detected diamonds, this functions draws them in the image. The marker borders
 * are painted and the markers identifiers if provided.
 * Useful for debugging purposes.
 */
+ (void)drawDetectedDiamonds:(Mat*)image diamondCorners:(NSArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds borderColor:(Scalar*)borderColor NS_SWIFT_NAME(drawDetectedDiamonds(image:diamondCorners:diamondIds:borderColor:));

/**
 * Draw a set of detected ChArUco Diamond markers
 *
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not
 * altered.
 * @param diamondCorners positions of diamond corners in the same format returned by
 * detectCharucoDiamond(). (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers,
 * the dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * @param diamondIds vector of identifiers for diamonds in diamondCorners, in the same format
 * returned by detectCharucoDiamond() (e.g. std::vector<Vec4i>).
 * Optional, if not provided, ids are not painted.
 * are calculated based on this one.
 *
 * Given an array of detected diamonds, this functions draws them in the image. The marker borders
 * are painted and the markers identifiers if provided.
 * Useful for debugging purposes.
 */
+ (void)drawDetectedDiamonds:(Mat*)image diamondCorners:(NSArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds NS_SWIFT_NAME(drawDetectedDiamonds(image:diamondCorners:diamondIds:));

/**
 * Draw a set of detected ChArUco Diamond markers
 *
 * @param image input/output image. It must have 1 or 3 channels. The number of channels is not
 * altered.
 * @param diamondCorners positions of diamond corners in the same format returned by
 * detectCharucoDiamond(). (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers,
 * the dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * returned by detectCharucoDiamond() (e.g. std::vector<Vec4i>).
 * Optional, if not provided, ids are not painted.
 * are calculated based on this one.
 *
 * Given an array of detected diamonds, this functions draws them in the image. The marker borders
 * are painted and the markers identifiers if provided.
 * Useful for debugging purposes.
 */
+ (void)drawDetectedDiamonds:(Mat*)image diamondCorners:(NSArray<Mat*>*)diamondCorners NS_SWIFT_NAME(drawDetectedDiamonds(image:diamondCorners:));



@end

NS_ASSUME_NONNULL_END


