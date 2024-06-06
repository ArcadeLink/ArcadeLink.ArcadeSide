//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/charuco_detector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class CharucoBoard;
@class CharucoParameters;
@class DetectorParameters;
@class Mat;
@class RefineParameters;



NS_ASSUME_NONNULL_BEGIN

// C++: class CharucoDetector
/**
 * The CharucoDetector module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface CharucoDetector : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::CharucoDetector> nativePtrCharucoDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::CharucoDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::CharucoDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::CharucoDetector::CharucoDetector(CharucoBoard board, CharucoParameters charucoParams = CharucoParameters(), DetectorParameters detectorParams = DetectorParameters(), RefineParameters refineParams = RefineParameters())
//
/**
 * Basic CharucoDetector constructor
 *
 * @param board ChAruco board
 * @param charucoParams charuco detection parameters
 * @param detectorParams marker detection parameters
 * @param refineParams marker refine detection parameters
 */
- (instancetype)initWithBoard:(CharucoBoard*)board charucoParams:(CharucoParameters*)charucoParams detectorParams:(DetectorParameters*)detectorParams refineParams:(RefineParameters*)refineParams;

/**
 * Basic CharucoDetector constructor
 *
 * @param board ChAruco board
 * @param charucoParams charuco detection parameters
 * @param detectorParams marker detection parameters
 */
- (instancetype)initWithBoard:(CharucoBoard*)board charucoParams:(CharucoParameters*)charucoParams detectorParams:(DetectorParameters*)detectorParams;

/**
 * Basic CharucoDetector constructor
 *
 * @param board ChAruco board
 * @param charucoParams charuco detection parameters
 */
- (instancetype)initWithBoard:(CharucoBoard*)board charucoParams:(CharucoParameters*)charucoParams;

/**
 * Basic CharucoDetector constructor
 *
 * @param board ChAruco board
 */
- (instancetype)initWithBoard:(CharucoBoard*)board;


//
//  CharucoBoard cv::aruco::CharucoDetector::getBoard()
//
- (CharucoBoard*)getBoard NS_SWIFT_NAME(getBoard());


//
//  void cv::aruco::CharucoDetector::setBoard(CharucoBoard board)
//
- (void)setBoard:(CharucoBoard*)board NS_SWIFT_NAME(setBoard(board:));


//
//  CharucoParameters cv::aruco::CharucoDetector::getCharucoParameters()
//
- (CharucoParameters*)getCharucoParameters NS_SWIFT_NAME(getCharucoParameters());


//
//  void cv::aruco::CharucoDetector::setCharucoParameters(CharucoParameters charucoParameters)
//
- (void)setCharucoParameters:(CharucoParameters*)charucoParameters NS_SWIFT_NAME(setCharucoParameters(charucoParameters:));


//
//  DetectorParameters cv::aruco::CharucoDetector::getDetectorParameters()
//
- (DetectorParameters*)getDetectorParameters NS_SWIFT_NAME(getDetectorParameters());


//
//  void cv::aruco::CharucoDetector::setDetectorParameters(DetectorParameters detectorParameters)
//
- (void)setDetectorParameters:(DetectorParameters*)detectorParameters NS_SWIFT_NAME(setDetectorParameters(detectorParameters:));


//
//  RefineParameters cv::aruco::CharucoDetector::getRefineParameters()
//
- (RefineParameters*)getRefineParameters NS_SWIFT_NAME(getRefineParameters());


//
//  void cv::aruco::CharucoDetector::setRefineParameters(RefineParameters refineParameters)
//
- (void)setRefineParameters:(RefineParameters*)refineParameters NS_SWIFT_NAME(setRefineParameters(refineParameters:));


//
//  void cv::aruco::CharucoDetector::detectBoard(Mat image, Mat& charucoCorners, Mat& charucoIds, vector_Mat& markerCorners = vector_Mat(), Mat& markerIds = Mat())
//
/**
 * detect aruco markers and interpolate position of ChArUco board corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param charucoCorners interpolated chessboard corners.
 * @param charucoIds interpolated chessboard corners identifiers.
 * @param markerCorners vector of already detected markers corners. For each marker, its four
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
 * dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
 * @param markerIds list of identifiers for each marker in corners.
 * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
 *
 * This function receives the detected markers and returns the 2D position of the chessboard corners
 * from a ChArUco board using the detected Aruco markers.
 *
 * If markerCorners and markerCorners are empty, the detectMarkers() will run and detect aruco markers and ids.
 *
 * If camera parameters are provided, the process is based in an approximated pose estimation, else it is based on local homography.
 * Only visible corners are returned. For each corner, its corresponding identifier is also returned in charucoIds.
 * @see `findChessboardCorners`
 */
- (void)detectBoard:(Mat*)image charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds markerCorners:(NSMutableArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds NS_SWIFT_NAME(detectBoard(image:charucoCorners:charucoIds:markerCorners:markerIds:));

/**
 * detect aruco markers and interpolate position of ChArUco board corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param charucoCorners interpolated chessboard corners.
 * @param charucoIds interpolated chessboard corners identifiers.
 * @param markerCorners vector of already detected markers corners. For each marker, its four
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
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
 * @see `findChessboardCorners`
 */
- (void)detectBoard:(Mat*)image charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds markerCorners:(NSMutableArray<Mat*>*)markerCorners NS_SWIFT_NAME(detectBoard(image:charucoCorners:charucoIds:markerCorners:));

/**
 * detect aruco markers and interpolate position of ChArUco board corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param charucoCorners interpolated chessboard corners.
 * @param charucoIds interpolated chessboard corners identifiers.
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
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
 * @see `findChessboardCorners`
 */
- (void)detectBoard:(Mat*)image charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds NS_SWIFT_NAME(detectBoard(image:charucoCorners:charucoIds:));


//
//  void cv::aruco::CharucoDetector::detectDiamonds(Mat image, vector_Mat& diamondCorners, Mat& diamondIds, vector_Mat& markerCorners = vector_Mat(), Mat& markerIds = Mat())
//
/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
 * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
 * diamond.
 * @param markerCorners list of detected marker corners from detectMarkers function.
 * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
 * @param markerIds list of marker ids in markerCorners.
 * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
 *
 * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
 * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
 * are provided, the diamond search is based on reprojection. If not, diamond search is based on
 * homography. Homography is faster than reprojection, but less accurate.
 */
- (void)detectDiamonds:(Mat*)image diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds markerCorners:(NSMutableArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds NS_SWIFT_NAME(detectDiamonds(image:diamondCorners:diamondIds:markerCorners:markerIds:));

/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
 * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
 * diamond.
 * @param markerCorners list of detected marker corners from detectMarkers function.
 * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
 * If markerCorners and markerCorners are empty, the function detect aruco markers and ids.
 *
 * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
 * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
 * are provided, the diamond search is based on reprojection. If not, diamond search is based on
 * homography. Homography is faster than reprojection, but less accurate.
 */
- (void)detectDiamonds:(Mat*)image diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds markerCorners:(NSMutableArray<Mat*>*)markerCorners NS_SWIFT_NAME(detectDiamonds(image:diamondCorners:diamondIds:markerCorners:));

/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
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
- (void)detectDiamonds:(Mat*)image diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds NS_SWIFT_NAME(detectDiamonds(image:diamondCorners:diamondIds:));



@end

NS_ASSUME_NONNULL_END


