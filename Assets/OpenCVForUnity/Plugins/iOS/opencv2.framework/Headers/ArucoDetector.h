//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/aruco_detector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Board;
@class DetectorParameters;
@class Dictionary;
@class Mat;
@class RefineParameters;



NS_ASSUME_NONNULL_BEGIN

// C++: class ArucoDetector
/**
 * The main functionality of ArucoDetector class is detection of markers in an image with detectMarkers() method.
 *
 * After detecting some markers in the image, you can try to find undetected markers from this dictionary with
 * refineDetectedMarkers() method.
 *
 * @see DetectorParameters, RefineParameters
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface ArucoDetector : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::ArucoDetector> nativePtrArucoDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::ArucoDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::ArucoDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::ArucoDetector::ArucoDetector( _hidden_  dictionary = getPredefinedDictionary(cv::aruco::DICT_4X4_50), DetectorParameters detectorParams = DetectorParameters(), RefineParameters refineParams = RefineParameters())
//
/**
 * Basic ArucoDetector constructor
 *
 * @param dictionary indicates the type of markers that will be searched
 * @param detectorParams marker detection parameters
 * @param refineParams marker refine detection parameters
 */
- (instancetype)initWithDictionary:(DetectorParameters*)detectorParams refineParams:(RefineParameters*)refineParams;

/**
 * Basic ArucoDetector constructor
 *
 * @param dictionary indicates the type of markers that will be searched
 * @param detectorParams marker detection parameters
 */
- (instancetype)initWithDictionary:(DetectorParameters*)detectorParams;

/**
 * Basic ArucoDetector constructor
 *
 * @param dictionary indicates the type of markers that will be searched
 */
- (instancetype)initWithDictionary;


//
//  void cv::aruco::ArucoDetector::detectMarkers(Mat image, vector_Mat& corners, Mat& ids, vector_Mat& rejectedImgPoints = vector_Mat())
//
/**
 * Basic marker detection
 *
 * @param image input image
 * @param corners vector of detected marker corners. For each marker, its four corners
 * are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers,
 * the dimensions of this array is Nx4. The order of the corners is clockwise.
 * @param ids vector of identifiers of the detected markers. The identifier is of type int
 * (e.g. std::vector<int>). For N detected markers, the size of ids is also N.
 * The identifiers have the same order than the markers in the imgPoints array.
 * @param rejectedImgPoints contains the imgPoints of those squares whose inner code has not a
 * correct codification. Useful for debugging purposes.
 *
 * Performs marker detection in the input image. Only markers included in the specific dictionary
 * are searched. For each detected marker, it returns the 2D position of its corner in the image
 * and its corresponding identifier.
 * Note that this function does not perform pose estimation.
 * NOTE: The function does not correct lens distortion or takes it into account. It's recommended to undistort
 * input image with corresponding camera model, if camera parameters are known
 * @see `undistort`, `estimatePoseSingleMarkers`, `estimatePoseBoard`
 */
- (void)detectMarkers:(Mat*)image corners:(NSMutableArray<Mat*>*)corners ids:(Mat*)ids rejectedImgPoints:(NSMutableArray<Mat*>*)rejectedImgPoints NS_SWIFT_NAME(detectMarkers(image:corners:ids:rejectedImgPoints:));

/**
 * Basic marker detection
 *
 * @param image input image
 * @param corners vector of detected marker corners. For each marker, its four corners
 * are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers,
 * the dimensions of this array is Nx4. The order of the corners is clockwise.
 * @param ids vector of identifiers of the detected markers. The identifier is of type int
 * (e.g. std::vector<int>). For N detected markers, the size of ids is also N.
 * The identifiers have the same order than the markers in the imgPoints array.
 * correct codification. Useful for debugging purposes.
 *
 * Performs marker detection in the input image. Only markers included in the specific dictionary
 * are searched. For each detected marker, it returns the 2D position of its corner in the image
 * and its corresponding identifier.
 * Note that this function does not perform pose estimation.
 * NOTE: The function does not correct lens distortion or takes it into account. It's recommended to undistort
 * input image with corresponding camera model, if camera parameters are known
 * @see `undistort`, `estimatePoseSingleMarkers`, `estimatePoseBoard`
 */
- (void)detectMarkers:(Mat*)image corners:(NSMutableArray<Mat*>*)corners ids:(Mat*)ids NS_SWIFT_NAME(detectMarkers(image:corners:ids:));


//
//  void cv::aruco::ArucoDetector::refineDetectedMarkers(Mat image, Board board, vector_Mat& detectedCorners, Mat& detectedIds, vector_Mat& rejectedCorners, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), Mat& recoveredIdxs = Mat())
//
/**
 * Refine not detected markers based on the already detected and the board layout
 *
 * @param image input image
 * @param board layout of markers in the board.
 * @param detectedCorners vector of already detected marker corners.
 * @param detectedIds vector of already detected marker identifiers.
 * @param rejectedCorners vector of rejected candidates during the marker detection process.
 * @param cameraMatrix optional input 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * @param distCoeffs optional vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param recoveredIdxs Optional array to returns the indexes of the recovered candidates in the
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
- (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs recoveredIdxs:(Mat*)recoveredIdxs NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:recoveredIdxs:));

/**
 * Refine not detected markers based on the already detected and the board layout
 *
 * @param image input image
 * @param board layout of markers in the board.
 * @param detectedCorners vector of already detected marker corners.
 * @param detectedIds vector of already detected marker identifiers.
 * @param rejectedCorners vector of rejected candidates during the marker detection process.
 * @param cameraMatrix optional input 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * @param distCoeffs optional vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
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
- (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:));

/**
 * Refine not detected markers based on the already detected and the board layout
 *
 * @param image input image
 * @param board layout of markers in the board.
 * @param detectedCorners vector of already detected marker corners.
 * @param detectedIds vector of already detected marker identifiers.
 * @param rejectedCorners vector of rejected candidates during the marker detection process.
 * @param cameraMatrix optional input 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
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
- (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:));

/**
 * Refine not detected markers based on the already detected and the board layout
 *
 * @param image input image
 * @param board layout of markers in the board.
 * @param detectedCorners vector of already detected marker corners.
 * @param detectedIds vector of already detected marker identifiers.
 * @param rejectedCorners vector of rejected candidates during the marker detection process.
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
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
- (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:));


//
//  Dictionary cv::aruco::ArucoDetector::getDictionary()
//
- (Dictionary*)getDictionary NS_SWIFT_NAME(getDictionary());


//
//  void cv::aruco::ArucoDetector::setDictionary(Dictionary dictionary)
//
- (void)setDictionary:(Dictionary*)dictionary NS_SWIFT_NAME(setDictionary(dictionary:));


//
//  DetectorParameters cv::aruco::ArucoDetector::getDetectorParameters()
//
- (DetectorParameters*)getDetectorParameters NS_SWIFT_NAME(getDetectorParameters());


//
//  void cv::aruco::ArucoDetector::setDetectorParameters(DetectorParameters detectorParameters)
//
- (void)setDetectorParameters:(DetectorParameters*)detectorParameters NS_SWIFT_NAME(setDetectorParameters(detectorParameters:));


//
//  RefineParameters cv::aruco::ArucoDetector::getRefineParameters()
//
- (RefineParameters*)getRefineParameters NS_SWIFT_NAME(getRefineParameters());


//
//  void cv::aruco::ArucoDetector::setRefineParameters(RefineParameters refineParameters)
//
- (void)setRefineParameters:(RefineParameters*)refineParameters NS_SWIFT_NAME(setRefineParameters(refineParameters:));


//
//  void cv::aruco::ArucoDetector::write(FileStorage fs, String name)
//
// Unknown type 'FileStorage' (I), skipping the function


//
//  void cv::aruco::ArucoDetector::read(FileNode fn)
//
// Unknown type 'FileNode' (I), skipping the function



@end

NS_ASSUME_NONNULL_END


