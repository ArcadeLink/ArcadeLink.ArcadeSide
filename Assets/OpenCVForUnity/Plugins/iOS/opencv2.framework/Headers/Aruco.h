//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/aruco.hpp"
#import "aruco/charuco.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class Board;
@class CharucoBoard;
@class DetectorParameters;
@class Dictionary;
@class Int4;
@class Mat;
@class Size2i;
@class TermCriteria;


// C++: enum PatternPositionType (cv.aruco.PatternPositionType)
typedef NS_ENUM(int, PatternPositionType) {
    ARUCO_CCW_CENTER = 0,
    ARUCO_CW_TOP_LEFT_CORNER = 1
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Aruco
/**
 * The Aruco module
 *
 * Member classes: `EstimateParameters`
 *
 * Member enums: `PatternPositionType`
 */
CV_EXPORTS @interface Aruco : NSObject

#pragma mark - Methods


//
//  void cv::aruco::detectMarkers(Mat image, Ptr_Dictionary dictionary, vector_Mat& corners, Mat& ids, Ptr_DetectorParameters parameters = makePtr<DetectorParameters>(), vector_Mat& rejectedImgPoints = vector_Mat())
//
/**
 * detect markers
 * @deprecated Use class ArucoDetector::detectMarkers
 */
+ (void)detectMarkers:(Mat*)image dictionary:(Dictionary*)dictionary corners:(NSMutableArray<Mat*>*)corners ids:(Mat*)ids parameters:(DetectorParameters*)parameters rejectedImgPoints:(NSMutableArray<Mat*>*)rejectedImgPoints NS_SWIFT_NAME(detectMarkers(image:dictionary:corners:ids:parameters:rejectedImgPoints:)) DEPRECATED_ATTRIBUTE;

/**
 * detect markers
 * @deprecated Use class ArucoDetector::detectMarkers
 */
+ (void)detectMarkers:(Mat*)image dictionary:(Dictionary*)dictionary corners:(NSMutableArray<Mat*>*)corners ids:(Mat*)ids parameters:(DetectorParameters*)parameters NS_SWIFT_NAME(detectMarkers(image:dictionary:corners:ids:parameters:)) DEPRECATED_ATTRIBUTE;

/**
 * detect markers
 * @deprecated Use class ArucoDetector::detectMarkers
 */
+ (void)detectMarkers:(Mat*)image dictionary:(Dictionary*)dictionary corners:(NSMutableArray<Mat*>*)corners ids:(Mat*)ids NS_SWIFT_NAME(detectMarkers(image:dictionary:corners:ids:)) DEPRECATED_ATTRIBUTE;


//
//  void cv::aruco::refineDetectedMarkers(Mat image, Ptr_Board board, vector_Mat& detectedCorners, Mat& detectedIds, vector_Mat& rejectedCorners, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), float minRepDistance = 10.f, float errorCorrectionRate = 3.f, bool checkAllOrders = true, Mat& recoveredIdxs = Mat(), Ptr_DetectorParameters parameters = makePtr<DetectorParameters>())
//
/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs minRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate checkAllOrders:(BOOL)checkAllOrders recoveredIdxs:(Mat*)recoveredIdxs parameters:(DetectorParameters*)parameters NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:minRepDistance:errorCorrectionRate:checkAllOrders:recoveredIdxs:parameters:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs minRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate checkAllOrders:(BOOL)checkAllOrders recoveredIdxs:(Mat*)recoveredIdxs NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:minRepDistance:errorCorrectionRate:checkAllOrders:recoveredIdxs:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs minRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate checkAllOrders:(BOOL)checkAllOrders NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:minRepDistance:errorCorrectionRate:checkAllOrders:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs minRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:minRepDistance:errorCorrectionRate:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs minRepDistance:(float)minRepDistance NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:minRepDistance:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:distCoeffs:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners cameraMatrix:(Mat*)cameraMatrix NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:cameraMatrix:)) DEPRECATED_ATTRIBUTE;

/**
 * refine detected markers
 * @deprecated Use class ArucoDetector::refineDetectedMarkers
 */
+ (void)refineDetectedMarkers:(Mat*)image board:(Board*)board detectedCorners:(NSMutableArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds rejectedCorners:(NSMutableArray<Mat*>*)rejectedCorners NS_SWIFT_NAME(refineDetectedMarkers(image:board:detectedCorners:detectedIds:rejectedCorners:)) DEPRECATED_ATTRIBUTE;


//
//  void cv::aruco::drawPlanarBoard(Ptr_Board board, Size outSize, Mat& img, int marginSize, int borderBits)
//
/**
 * draw planar board
 * @deprecated Use Board::generateImage
 */
+ (void)drawPlanarBoard:(Board*)board outSize:(Size2i*)outSize img:(Mat*)img marginSize:(int)marginSize borderBits:(int)borderBits NS_SWIFT_NAME(drawPlanarBoard(board:outSize:img:marginSize:borderBits:)) DEPRECATED_ATTRIBUTE;


//
//  void cv::aruco::getBoardObjectAndImagePoints(Ptr_Board board, vector_Mat detectedCorners, Mat detectedIds, Mat& objPoints, Mat& imgPoints)
//
/**
 * get board object and image points
 * @deprecated Use Board::matchImagePoints
 */
+ (void)getBoardObjectAndImagePoints:(Board*)board detectedCorners:(NSArray<Mat*>*)detectedCorners detectedIds:(Mat*)detectedIds objPoints:(Mat*)objPoints imgPoints:(Mat*)imgPoints NS_SWIFT_NAME(getBoardObjectAndImagePoints(board:detectedCorners:detectedIds:objPoints:imgPoints:)) DEPRECATED_ATTRIBUTE;


//
//  int cv::aruco::estimatePoseBoard(vector_Mat corners, Mat ids, Ptr_Board board, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false)
//
/**
 * @deprecated Use cv::solvePnP
 */
+ (int)estimatePoseBoard:(NSArray<Mat*>*)corners ids:(Mat*)ids board:(Board*)board cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvec:(Mat*)rvec tvec:(Mat*)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess NS_SWIFT_NAME(estimatePoseBoard(corners:ids:board:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:)) DEPRECATED_ATTRIBUTE;

/**
 * @deprecated Use cv::solvePnP
 */
+ (int)estimatePoseBoard:(NSArray<Mat*>*)corners ids:(Mat*)ids board:(Board*)board cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvec:(Mat*)rvec tvec:(Mat*)tvec NS_SWIFT_NAME(estimatePoseBoard(corners:ids:board:cameraMatrix:distCoeffs:rvec:tvec:)) DEPRECATED_ATTRIBUTE;


//
//  bool cv::aruco::estimatePoseCharucoBoard(Mat charucoCorners, Mat charucoIds, Ptr_CharucoBoard board, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false)
//
/**
 * Pose estimation for a ChArUco board given some of their corners
 * @param charucoCorners vector of detected charuco corners
 * @param charucoIds list of identifiers for each corner in charucoCorners
 * @param board layout of ChArUco board.
 * @param cameraMatrix input 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * @param distCoeffs vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvec Output vector (e.g. cv::Mat) corresponding to the rotation vector of the board
 * (see cv::Rodrigues).
 * @param tvec Output vector (e.g. cv::Mat) corresponding to the translation vector of the board.
 * @param useExtrinsicGuess defines whether initial guess for \b rvec and \b tvec will be used or not.
 *
 * This function estimates a Charuco board pose from some detected corners.
 * The function checks if the input corners are enough and valid to perform pose estimation.
 * If pose estimation is valid, returns true, else returns false.
 * @see `use cv::drawFrameAxes to get world coordinate system axis for object points`
 */
+ (BOOL)estimatePoseCharucoBoard:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds board:(CharucoBoard*)board cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvec:(Mat*)rvec tvec:(Mat*)tvec useExtrinsicGuess:(BOOL)useExtrinsicGuess NS_SWIFT_NAME(estimatePoseCharucoBoard(charucoCorners:charucoIds:board:cameraMatrix:distCoeffs:rvec:tvec:useExtrinsicGuess:));

/**
 * Pose estimation for a ChArUco board given some of their corners
 * @param charucoCorners vector of detected charuco corners
 * @param charucoIds list of identifiers for each corner in charucoCorners
 * @param board layout of ChArUco board.
 * @param cameraMatrix input 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * @param distCoeffs vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvec Output vector (e.g. cv::Mat) corresponding to the rotation vector of the board
 * (see cv::Rodrigues).
 * @param tvec Output vector (e.g. cv::Mat) corresponding to the translation vector of the board.
 *
 * This function estimates a Charuco board pose from some detected corners.
 * The function checks if the input corners are enough and valid to perform pose estimation.
 * If pose estimation is valid, returns true, else returns false.
 * @see `use cv::drawFrameAxes to get world coordinate system axis for object points`
 */
+ (BOOL)estimatePoseCharucoBoard:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds board:(CharucoBoard*)board cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvec:(Mat*)rvec tvec:(Mat*)tvec NS_SWIFT_NAME(estimatePoseCharucoBoard(charucoCorners:charucoIds:board:cameraMatrix:distCoeffs:rvec:tvec:));


//
//  void cv::aruco::estimatePoseSingleMarkers(vector_Mat corners, float markerLength, Mat cameraMatrix, Mat distCoeffs, Mat& rvecs, Mat& tvecs, Mat& objPoints = Mat(),  _hidden_  estimateParameters = cv::makePtr<cv::aruco::EstimateParameters>())
//
/**
 * @deprecated Use cv::solvePnP
 */
+ (void)estimatePoseSingleMarkers:(NSArray<Mat*>*)corners markerLength:(float)markerLength cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(Mat*)rvecs tvecs:(Mat*)tvecs objPoints:(Mat*)objPoints NS_SWIFT_NAME(estimatePoseSingleMarkers(corners:markerLength:cameraMatrix:distCoeffs:rvecs:tvecs:objPoints:)) DEPRECATED_ATTRIBUTE;

/**
 * @deprecated Use cv::solvePnP
 */
+ (void)estimatePoseSingleMarkers:(NSArray<Mat*>*)corners markerLength:(float)markerLength cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(Mat*)rvecs tvecs:(Mat*)tvecs NS_SWIFT_NAME(estimatePoseSingleMarkers(corners:markerLength:cameraMatrix:distCoeffs:rvecs:tvecs:)) DEPRECATED_ATTRIBUTE;


//
//  bool cv::aruco::testCharucoCornersCollinear(Ptr_CharucoBoard board, Mat charucoIds)
//
/**
 * @deprecated Use CharucoBoard::checkCharucoCornersCollinear
 */
+ (BOOL)testCharucoCornersCollinear:(CharucoBoard*)board charucoIds:(Mat*)charucoIds NS_SWIFT_NAME(testCharucoCornersCollinear(board:charucoIds:)) DEPRECATED_ATTRIBUTE;


//
//  double cv::aruco::calibrateCameraAruco(vector_Mat corners, Mat ids, Mat counter, Ptr_Board board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
//
/**
 * Calibrate a camera using aruco markers
 *
 * @param corners vector of detected marker corners in all frames.
 * The corners should have the same format returned by detectMarkers (see #detectMarkers).
 * @param ids list of identifiers for each marker in corners
 * @param counter number of markers in each frame so that corners and ids can be split
 * @param board Marker Board layout
 * @param imageSize Size of the image used only to initialize the intrinsic camera matrix.
 * @param cameraMatrix Output 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$` . If CV\_CALIB\_USE\_INTRINSIC\_GUESS
 * and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be
 * initialized before calling the function.
 * @param distCoeffs Output vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvecs Output vector of rotation vectors (see Rodrigues ) estimated for each board view
 * (e.g. std::vector<cv::Mat>>). That is, each k-th rotation vector together with the corresponding
 * k-th translation vector (see the next output parameter description) brings the board pattern
 * from the model coordinate space (in which object points are specified) to the world coordinate
 * space, that is, a real position of the board pattern in the k-th pattern view (k=0.. *M* -1).
 * @param tvecs Output vector of translation vectors estimated for each pattern view.
 * @param stdDeviationsIntrinsics Output vector of standard deviations estimated for intrinsic parameters.
 * Order of deviations values:
 * `$$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
 * s_4, \tau_x, \tau_y)$$` If one of parameters is not estimated, it's deviation is equals to zero.
 * @param stdDeviationsExtrinsics Output vector of standard deviations estimated for extrinsic parameters.
 * Order of deviations values: `$$(R_1, T_1, \dotsc , R_M, T_M)$$` where M is number of pattern views,
 * `$$R_i, T_i$$` are concatenated 1x3 vectors.
 * @param perViewErrors Output vector of average re-projection errors estimated for each pattern view.
 * @param flags flags Different flags  for the calibration process (see #calibrateCamera for details).
 * @param criteria Termination criteria for the iterative optimization algorithm.
 *
 * This function calibrates a camera using an Aruco Board. The function receives a list of
 * detected markers from several views of the Board. The process is similar to the chessboard
 * calibration in calibrateCamera(). The function returns the final re-projection error.
 */
+ (double)calibrateCameraArucoExtended:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs stdDeviationsIntrinsics:(Mat*)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat*)stdDeviationsExtrinsics perViewErrors:(Mat*)perViewErrors flags:(int)flags criteria:(TermCriteria*)criteria NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:criteria:));

/**
 * Calibrate a camera using aruco markers
 *
 * @param corners vector of detected marker corners in all frames.
 * The corners should have the same format returned by detectMarkers (see #detectMarkers).
 * @param ids list of identifiers for each marker in corners
 * @param counter number of markers in each frame so that corners and ids can be split
 * @param board Marker Board layout
 * @param imageSize Size of the image used only to initialize the intrinsic camera matrix.
 * @param cameraMatrix Output 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$` . If CV\_CALIB\_USE\_INTRINSIC\_GUESS
 * and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be
 * initialized before calling the function.
 * @param distCoeffs Output vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvecs Output vector of rotation vectors (see Rodrigues ) estimated for each board view
 * (e.g. std::vector<cv::Mat>>). That is, each k-th rotation vector together with the corresponding
 * k-th translation vector (see the next output parameter description) brings the board pattern
 * from the model coordinate space (in which object points are specified) to the world coordinate
 * space, that is, a real position of the board pattern in the k-th pattern view (k=0.. *M* -1).
 * @param tvecs Output vector of translation vectors estimated for each pattern view.
 * @param stdDeviationsIntrinsics Output vector of standard deviations estimated for intrinsic parameters.
 * Order of deviations values:
 * `$$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
 * s_4, \tau_x, \tau_y)$$` If one of parameters is not estimated, it's deviation is equals to zero.
 * @param stdDeviationsExtrinsics Output vector of standard deviations estimated for extrinsic parameters.
 * Order of deviations values: `$$(R_1, T_1, \dotsc , R_M, T_M)$$` where M is number of pattern views,
 * `$$R_i, T_i$$` are concatenated 1x3 vectors.
 * @param perViewErrors Output vector of average re-projection errors estimated for each pattern view.
 * @param flags flags Different flags  for the calibration process (see #calibrateCamera for details).
 *
 * This function calibrates a camera using an Aruco Board. The function receives a list of
 * detected markers from several views of the Board. The process is similar to the chessboard
 * calibration in calibrateCamera(). The function returns the final re-projection error.
 */
+ (double)calibrateCameraArucoExtended:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs stdDeviationsIntrinsics:(Mat*)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat*)stdDeviationsExtrinsics perViewErrors:(Mat*)perViewErrors flags:(int)flags NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:));

/**
 * Calibrate a camera using aruco markers
 *
 * @param corners vector of detected marker corners in all frames.
 * The corners should have the same format returned by detectMarkers (see #detectMarkers).
 * @param ids list of identifiers for each marker in corners
 * @param counter number of markers in each frame so that corners and ids can be split
 * @param board Marker Board layout
 * @param imageSize Size of the image used only to initialize the intrinsic camera matrix.
 * @param cameraMatrix Output 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$` . If CV\_CALIB\_USE\_INTRINSIC\_GUESS
 * and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be
 * initialized before calling the function.
 * @param distCoeffs Output vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvecs Output vector of rotation vectors (see Rodrigues ) estimated for each board view
 * (e.g. std::vector<cv::Mat>>). That is, each k-th rotation vector together with the corresponding
 * k-th translation vector (see the next output parameter description) brings the board pattern
 * from the model coordinate space (in which object points are specified) to the world coordinate
 * space, that is, a real position of the board pattern in the k-th pattern view (k=0.. *M* -1).
 * @param tvecs Output vector of translation vectors estimated for each pattern view.
 * @param stdDeviationsIntrinsics Output vector of standard deviations estimated for intrinsic parameters.
 * Order of deviations values:
 * `$$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
 * s_4, \tau_x, \tau_y)$$` If one of parameters is not estimated, it's deviation is equals to zero.
 * @param stdDeviationsExtrinsics Output vector of standard deviations estimated for extrinsic parameters.
 * Order of deviations values: `$$(R_1, T_1, \dotsc , R_M, T_M)$$` where M is number of pattern views,
 * `$$R_i, T_i$$` are concatenated 1x3 vectors.
 * @param perViewErrors Output vector of average re-projection errors estimated for each pattern view.
 *
 * This function calibrates a camera using an Aruco Board. The function receives a list of
 * detected markers from several views of the Board. The process is similar to the chessboard
 * calibration in calibrateCamera(). The function returns the final re-projection error.
 */
+ (double)calibrateCameraArucoExtended:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs stdDeviationsIntrinsics:(Mat*)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat*)stdDeviationsExtrinsics perViewErrors:(Mat*)perViewErrors NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:));


//
//  double cv::aruco::calibrateCameraAruco(vector_Mat corners, Mat ids, Mat counter, Ptr_Board board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs = vector_Mat(), vector_Mat& tvecs = vector_Mat(), int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
//
/**
 *
 * It's the same function as #calibrateCameraAruco but without calibration error estimation.
 */
+ (double)calibrateCameraAruco:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs flags:(int)flags criteria:(TermCriteria*)criteria NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:criteria:));

/**
 *
 * It's the same function as #calibrateCameraAruco but without calibration error estimation.
 */
+ (double)calibrateCameraAruco:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs flags:(int)flags NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:));

/**
 *
 * It's the same function as #calibrateCameraAruco but without calibration error estimation.
 */
+ (double)calibrateCameraAruco:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:));

/**
 *
 * It's the same function as #calibrateCameraAruco but without calibration error estimation.
 */
+ (double)calibrateCameraAruco:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:rvecs:));

/**
 *
 * It's the same function as #calibrateCameraAruco but without calibration error estimation.
 */
+ (double)calibrateCameraAruco:(NSArray<Mat*>*)corners ids:(Mat*)ids counter:(Mat*)counter board:(Board*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs NS_SWIFT_NAME(calibrateCameraAruco(corners:ids:counter:board:imageSize:cameraMatrix:distCoeffs:));


//
//  double cv::aruco::calibrateCameraCharuco(vector_Mat charucoCorners, vector_Mat charucoIds, Ptr_CharucoBoard board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
//
/**
 * Calibrate a camera using Charuco corners
 *
 * @param charucoCorners vector of detected charuco corners per frame
 * @param charucoIds list of identifiers for each corner in charucoCorners per frame
 * @param board Marker Board layout
 * @param imageSize input image size
 * @param cameraMatrix Output 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$` . If CV\_CALIB\_USE\_INTRINSIC\_GUESS
 * and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be
 * initialized before calling the function.
 * @param distCoeffs Output vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvecs Output vector of rotation vectors (see Rodrigues ) estimated for each board view
 * (e.g. std::vector<cv::Mat>>). That is, each k-th rotation vector together with the corresponding
 * k-th translation vector (see the next output parameter description) brings the board pattern
 * from the model coordinate space (in which object points are specified) to the world coordinate
 * space, that is, a real position of the board pattern in the k-th pattern view (k=0.. *M* -1).
 * @param tvecs Output vector of translation vectors estimated for each pattern view.
 * @param stdDeviationsIntrinsics Output vector of standard deviations estimated for intrinsic parameters.
 * Order of deviations values:
 * `$$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
 * s_4, \tau_x, \tau_y)$$` If one of parameters is not estimated, it's deviation is equals to zero.
 * @param stdDeviationsExtrinsics Output vector of standard deviations estimated for extrinsic parameters.
 * Order of deviations values: `$$(R_1, T_1, \dotsc , R_M, T_M)$$` where M is number of pattern views,
 * `$$R_i, T_i$$` are concatenated 1x3 vectors.
 * @param perViewErrors Output vector of average re-projection errors estimated for each pattern view.
 * @param flags flags Different flags  for the calibration process (see #calibrateCamera for details).
 * @param criteria Termination criteria for the iterative optimization algorithm.
 *
 * This function calibrates a camera using a set of corners of a  Charuco Board. The function
 * receives a list of detected corners and its identifiers from several views of the Board.
 * The function returns the final re-projection error.
 */
+ (double)calibrateCameraCharucoExtended:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs stdDeviationsIntrinsics:(Mat*)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat*)stdDeviationsExtrinsics perViewErrors:(Mat*)perViewErrors flags:(int)flags criteria:(TermCriteria*)criteria NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:criteria:));

/**
 * Calibrate a camera using Charuco corners
 *
 * @param charucoCorners vector of detected charuco corners per frame
 * @param charucoIds list of identifiers for each corner in charucoCorners per frame
 * @param board Marker Board layout
 * @param imageSize input image size
 * @param cameraMatrix Output 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$` . If CV\_CALIB\_USE\_INTRINSIC\_GUESS
 * and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be
 * initialized before calling the function.
 * @param distCoeffs Output vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvecs Output vector of rotation vectors (see Rodrigues ) estimated for each board view
 * (e.g. std::vector<cv::Mat>>). That is, each k-th rotation vector together with the corresponding
 * k-th translation vector (see the next output parameter description) brings the board pattern
 * from the model coordinate space (in which object points are specified) to the world coordinate
 * space, that is, a real position of the board pattern in the k-th pattern view (k=0.. *M* -1).
 * @param tvecs Output vector of translation vectors estimated for each pattern view.
 * @param stdDeviationsIntrinsics Output vector of standard deviations estimated for intrinsic parameters.
 * Order of deviations values:
 * `$$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
 * s_4, \tau_x, \tau_y)$$` If one of parameters is not estimated, it's deviation is equals to zero.
 * @param stdDeviationsExtrinsics Output vector of standard deviations estimated for extrinsic parameters.
 * Order of deviations values: `$$(R_1, T_1, \dotsc , R_M, T_M)$$` where M is number of pattern views,
 * `$$R_i, T_i$$` are concatenated 1x3 vectors.
 * @param perViewErrors Output vector of average re-projection errors estimated for each pattern view.
 * @param flags flags Different flags  for the calibration process (see #calibrateCamera for details).
 *
 * This function calibrates a camera using a set of corners of a  Charuco Board. The function
 * receives a list of detected corners and its identifiers from several views of the Board.
 * The function returns the final re-projection error.
 */
+ (double)calibrateCameraCharucoExtended:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs stdDeviationsIntrinsics:(Mat*)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat*)stdDeviationsExtrinsics perViewErrors:(Mat*)perViewErrors flags:(int)flags NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:flags:));

/**
 * Calibrate a camera using Charuco corners
 *
 * @param charucoCorners vector of detected charuco corners per frame
 * @param charucoIds list of identifiers for each corner in charucoCorners per frame
 * @param board Marker Board layout
 * @param imageSize input image size
 * @param cameraMatrix Output 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$` . If CV\_CALIB\_USE\_INTRINSIC\_GUESS
 * and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be
 * initialized before calling the function.
 * @param distCoeffs Output vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param rvecs Output vector of rotation vectors (see Rodrigues ) estimated for each board view
 * (e.g. std::vector<cv::Mat>>). That is, each k-th rotation vector together with the corresponding
 * k-th translation vector (see the next output parameter description) brings the board pattern
 * from the model coordinate space (in which object points are specified) to the world coordinate
 * space, that is, a real position of the board pattern in the k-th pattern view (k=0.. *M* -1).
 * @param tvecs Output vector of translation vectors estimated for each pattern view.
 * @param stdDeviationsIntrinsics Output vector of standard deviations estimated for intrinsic parameters.
 * Order of deviations values:
 * `$$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
 * s_4, \tau_x, \tau_y)$$` If one of parameters is not estimated, it's deviation is equals to zero.
 * @param stdDeviationsExtrinsics Output vector of standard deviations estimated for extrinsic parameters.
 * Order of deviations values: `$$(R_1, T_1, \dotsc , R_M, T_M)$$` where M is number of pattern views,
 * `$$R_i, T_i$$` are concatenated 1x3 vectors.
 * @param perViewErrors Output vector of average re-projection errors estimated for each pattern view.
 *
 * This function calibrates a camera using a set of corners of a  Charuco Board. The function
 * receives a list of detected corners and its identifiers from several views of the Board.
 * The function returns the final re-projection error.
 */
+ (double)calibrateCameraCharucoExtended:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs stdDeviationsIntrinsics:(Mat*)stdDeviationsIntrinsics stdDeviationsExtrinsics:(Mat*)stdDeviationsExtrinsics perViewErrors:(Mat*)perViewErrors NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:stdDeviationsIntrinsics:stdDeviationsExtrinsics:perViewErrors:));


//
//  double cv::aruco::calibrateCameraCharuco(vector_Mat charucoCorners, vector_Mat charucoIds, Ptr_CharucoBoard board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs = vector_Mat(), vector_Mat& tvecs = vector_Mat(), int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
//
/**
 * It's the same function as #calibrateCameraCharuco but without calibration error estimation.
 */
+ (double)calibrateCameraCharuco:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs flags:(int)flags criteria:(TermCriteria*)criteria NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:criteria:));

/**
 * It's the same function as #calibrateCameraCharuco but without calibration error estimation.
 */
+ (double)calibrateCameraCharuco:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs flags:(int)flags NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:flags:));

/**
 * It's the same function as #calibrateCameraCharuco but without calibration error estimation.
 */
+ (double)calibrateCameraCharuco:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs tvecs:(NSMutableArray<Mat*>*)tvecs NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:tvecs:));

/**
 * It's the same function as #calibrateCameraCharuco but without calibration error estimation.
 */
+ (double)calibrateCameraCharuco:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs rvecs:(NSMutableArray<Mat*>*)rvecs NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:rvecs:));

/**
 * It's the same function as #calibrateCameraCharuco but without calibration error estimation.
 */
+ (double)calibrateCameraCharuco:(NSArray<Mat*>*)charucoCorners charucoIds:(NSArray<Mat*>*)charucoIds board:(CharucoBoard*)board imageSize:(Size2i*)imageSize cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs NS_SWIFT_NAME(calibrateCameraCharuco(charucoCorners:charucoIds:board:imageSize:cameraMatrix:distCoeffs:));


//
//  int cv::aruco::interpolateCornersCharuco(vector_Mat markerCorners, Mat markerIds, Mat image, Ptr_CharucoBoard board, Mat& charucoCorners, Mat& charucoIds, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), int minMarkers = 2)
//
/**
 * Interpolate position of ChArUco board corners
 * @param markerCorners vector of already detected markers corners. For each marker, its four
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
 * dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * @param markerIds list of identifiers for each marker in corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param board layout of ChArUco board.
 * @param charucoCorners interpolated chessboard corners
 * @param charucoIds interpolated chessboard corners identifiers
 * @param cameraMatrix optional 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * @param distCoeffs optional vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 * @param minMarkers number of adjacent markers that must be detected to return a charuco corner
 *
 * This function receives the detected markers and returns the 2D position of the chessboard corners
 * from a ChArUco board using the detected Aruco markers. If camera parameters are provided,
 * the process is based in an approximated pose estimation, else it is based on local homography.
 * Only visible corners are returned. For each corner, its corresponding identifier is
 * also returned in charucoIds.
 * The function returns the number of interpolated corners.
 *
 * @deprecated Use CharucoDetector::detectBoard
 */
+ (int)interpolateCornersCharuco:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds image:(Mat*)image board:(CharucoBoard*)board charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs minMarkers:(int)minMarkers NS_SWIFT_NAME(interpolateCornersCharuco(markerCorners:markerIds:image:board:charucoCorners:charucoIds:cameraMatrix:distCoeffs:minMarkers:)) DEPRECATED_ATTRIBUTE;

/**
 * Interpolate position of ChArUco board corners
 * @param markerCorners vector of already detected markers corners. For each marker, its four
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
 * dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * @param markerIds list of identifiers for each marker in corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param board layout of ChArUco board.
 * @param charucoCorners interpolated chessboard corners
 * @param charucoIds interpolated chessboard corners identifiers
 * @param cameraMatrix optional 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * @param distCoeffs optional vector of distortion coefficients
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 *
 * This function receives the detected markers and returns the 2D position of the chessboard corners
 * from a ChArUco board using the detected Aruco markers. If camera parameters are provided,
 * the process is based in an approximated pose estimation, else it is based on local homography.
 * Only visible corners are returned. For each corner, its corresponding identifier is
 * also returned in charucoIds.
 * The function returns the number of interpolated corners.
 *
 * @deprecated Use CharucoDetector::detectBoard
 */
+ (int)interpolateCornersCharuco:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds image:(Mat*)image board:(CharucoBoard*)board charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs NS_SWIFT_NAME(interpolateCornersCharuco(markerCorners:markerIds:image:board:charucoCorners:charucoIds:cameraMatrix:distCoeffs:)) DEPRECATED_ATTRIBUTE;

/**
 * Interpolate position of ChArUco board corners
 * @param markerCorners vector of already detected markers corners. For each marker, its four
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
 * dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * @param markerIds list of identifiers for each marker in corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param board layout of ChArUco board.
 * @param charucoCorners interpolated chessboard corners
 * @param charucoIds interpolated chessboard corners identifiers
 * @param cameraMatrix optional 3x3 floating-point camera matrix
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 *
 * This function receives the detected markers and returns the 2D position of the chessboard corners
 * from a ChArUco board using the detected Aruco markers. If camera parameters are provided,
 * the process is based in an approximated pose estimation, else it is based on local homography.
 * Only visible corners are returned. For each corner, its corresponding identifier is
 * also returned in charucoIds.
 * The function returns the number of interpolated corners.
 *
 * @deprecated Use CharucoDetector::detectBoard
 */
+ (int)interpolateCornersCharuco:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds image:(Mat*)image board:(CharucoBoard*)board charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds cameraMatrix:(Mat*)cameraMatrix NS_SWIFT_NAME(interpolateCornersCharuco(markerCorners:markerIds:image:board:charucoCorners:charucoIds:cameraMatrix:)) DEPRECATED_ATTRIBUTE;

/**
 * Interpolate position of ChArUco board corners
 * @param markerCorners vector of already detected markers corners. For each marker, its four
 * corners are provided, (e.g std::vector<std::vector<cv::Point2f> > ). For N detected markers, the
 * dimensions of this array should be Nx4. The order of the corners should be clockwise.
 * @param markerIds list of identifiers for each marker in corners
 * @param image input image necesary for corner refinement. Note that markers are not detected and
 * should be sent in corners and ids parameters.
 * @param board layout of ChArUco board.
 * @param charucoCorners interpolated chessboard corners
 * @param charucoIds interpolated chessboard corners identifiers
 * `$$\newcommand{\vecthreethree}[9]{ \begin{bmatrix} #1 & #2 & #3\\\\ #4 & #5 & #6\\\\ #7 & #8 & #9 \end{bmatrix} } A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}$$`
 * `$$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6],[s_1, s_2, s_3, s_4]])$$` of 4, 5, 8 or 12 elements
 *
 * This function receives the detected markers and returns the 2D position of the chessboard corners
 * from a ChArUco board using the detected Aruco markers. If camera parameters are provided,
 * the process is based in an approximated pose estimation, else it is based on local homography.
 * Only visible corners are returned. For each corner, its corresponding identifier is
 * also returned in charucoIds.
 * The function returns the number of interpolated corners.
 *
 * @deprecated Use CharucoDetector::detectBoard
 */
+ (int)interpolateCornersCharuco:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds image:(Mat*)image board:(CharucoBoard*)board charucoCorners:(Mat*)charucoCorners charucoIds:(Mat*)charucoIds NS_SWIFT_NAME(interpolateCornersCharuco(markerCorners:markerIds:image:board:charucoCorners:charucoIds:)) DEPRECATED_ATTRIBUTE;


//
//  void cv::aruco::detectCharucoDiamond(Mat image, vector_Mat markerCorners, Mat markerIds, float squareMarkerLengthRate, vector_Mat& diamondCorners, Mat& diamondIds, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), Ptr_Dictionary dictionary = makePtr<Dictionary> (getPredefinedDictionary(PredefinedDictionaryType::DICT_4X4_50)))
//
/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param markerCorners list of detected marker corners from detectMarkers function.
 * @param markerIds list of marker ids in markerCorners.
 * @param squareMarkerLengthRate rate between square and marker length:
 * squareMarkerLengthRate = squareLength/markerLength. The real units are not necessary.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
 * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
 * diamond.
 * @param cameraMatrix Optional camera calibration matrix.
 * @param distCoeffs Optional camera distortion coefficients.
 * @param dictionary dictionary of markers indicating the type of markers.
 *
 * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
 * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
 * are provided, the diamond search is based on reprojection. If not, diamond search is based on
 * homography. Homography is faster than reprojection, but less accurate.
 *
 * @deprecated Use CharucoDetector::detectDiamonds
 */
+ (void)detectCharucoDiamond:(Mat*)image markerCorners:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds squareMarkerLengthRate:(float)squareMarkerLengthRate diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs dictionary:(Dictionary*)dictionary NS_SWIFT_NAME(detectCharucoDiamond(image:markerCorners:markerIds:squareMarkerLengthRate:diamondCorners:diamondIds:cameraMatrix:distCoeffs:dictionary:)) DEPRECATED_ATTRIBUTE;

/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param markerCorners list of detected marker corners from detectMarkers function.
 * @param markerIds list of marker ids in markerCorners.
 * @param squareMarkerLengthRate rate between square and marker length:
 * squareMarkerLengthRate = squareLength/markerLength. The real units are not necessary.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
 * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
 * diamond.
 * @param cameraMatrix Optional camera calibration matrix.
 * @param distCoeffs Optional camera distortion coefficients.
 *
 * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
 * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
 * are provided, the diamond search is based on reprojection. If not, diamond search is based on
 * homography. Homography is faster than reprojection, but less accurate.
 *
 * @deprecated Use CharucoDetector::detectDiamonds
 */
+ (void)detectCharucoDiamond:(Mat*)image markerCorners:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds squareMarkerLengthRate:(float)squareMarkerLengthRate diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds cameraMatrix:(Mat*)cameraMatrix distCoeffs:(Mat*)distCoeffs NS_SWIFT_NAME(detectCharucoDiamond(image:markerCorners:markerIds:squareMarkerLengthRate:diamondCorners:diamondIds:cameraMatrix:distCoeffs:)) DEPRECATED_ATTRIBUTE;

/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param markerCorners list of detected marker corners from detectMarkers function.
 * @param markerIds list of marker ids in markerCorners.
 * @param squareMarkerLengthRate rate between square and marker length:
 * squareMarkerLengthRate = squareLength/markerLength. The real units are not necessary.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
 * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
 * diamond.
 * @param cameraMatrix Optional camera calibration matrix.
 *
 * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
 * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
 * are provided, the diamond search is based on reprojection. If not, diamond search is based on
 * homography. Homography is faster than reprojection, but less accurate.
 *
 * @deprecated Use CharucoDetector::detectDiamonds
 */
+ (void)detectCharucoDiamond:(Mat*)image markerCorners:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds squareMarkerLengthRate:(float)squareMarkerLengthRate diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds cameraMatrix:(Mat*)cameraMatrix NS_SWIFT_NAME(detectCharucoDiamond(image:markerCorners:markerIds:squareMarkerLengthRate:diamondCorners:diamondIds:cameraMatrix:)) DEPRECATED_ATTRIBUTE;

/**
 * Detect ChArUco Diamond markers
 *
 * @param image input image necessary for corner subpixel.
 * @param markerCorners list of detected marker corners from detectMarkers function.
 * @param markerIds list of marker ids in markerCorners.
 * @param squareMarkerLengthRate rate between square and marker length:
 * squareMarkerLengthRate = squareLength/markerLength. The real units are not necessary.
 * @param diamondCorners output list of detected diamond corners (4 corners per diamond). The order
 * is the same than in marker corners: top left, top right, bottom right and bottom left. Similar
 * format than the corners returned by detectMarkers (e.g std::vector<std::vector<cv::Point2f> > ).
 * @param diamondIds ids of the diamonds in diamondCorners. The id of each diamond is in fact of
 * type Vec4i, so each diamond has 4 ids, which are the ids of the aruco markers composing the
 * diamond.
 *
 * This function detects Diamond markers from the previous detected ArUco markers. The diamonds
 * are returned in the diamondCorners and diamondIds parameters. If camera calibration parameters
 * are provided, the diamond search is based on reprojection. If not, diamond search is based on
 * homography. Homography is faster than reprojection, but less accurate.
 *
 * @deprecated Use CharucoDetector::detectDiamonds
 */
+ (void)detectCharucoDiamond:(Mat*)image markerCorners:(NSArray<Mat*>*)markerCorners markerIds:(Mat*)markerIds squareMarkerLengthRate:(float)squareMarkerLengthRate diamondCorners:(NSMutableArray<Mat*>*)diamondCorners diamondIds:(Mat*)diamondIds NS_SWIFT_NAME(detectCharucoDiamond(image:markerCorners:markerIds:squareMarkerLengthRate:diamondCorners:diamondIds:)) DEPRECATED_ATTRIBUTE;


//
//  void cv::aruco::drawCharucoDiamond(Ptr_Dictionary dictionary, Vec4i ids, int squareLength, int markerLength, Mat& img, int marginSize = 0, int borderBits = 1)
//
/**
 * Draw a ChArUco Diamond marker
 *
 * @param dictionary dictionary of markers indicating the type of markers.
 * @param ids list of 4 ids for each ArUco marker in the ChArUco marker.
 * @param squareLength size of the chessboard squares in pixels.
 * @param markerLength size of the markers in pixels.
 * @param img output image with the marker. The size of this image will be
 * 3*squareLength + 2*marginSize,.
 * @param marginSize minimum margins (in pixels) of the marker in the output image
 * @param borderBits width of the marker borders.
 *
 * This function return the image of a ChArUco marker, ready to be printed.
 */
+ (void)drawCharucoDiamond:(Dictionary*)dictionary ids:(Int4*)ids squareLength:(int)squareLength markerLength:(int)markerLength img:(Mat*)img marginSize:(int)marginSize borderBits:(int)borderBits NS_SWIFT_NAME(drawCharucoDiamond(dictionary:ids:squareLength:markerLength:img:marginSize:borderBits:));

/**
 * Draw a ChArUco Diamond marker
 *
 * @param dictionary dictionary of markers indicating the type of markers.
 * @param ids list of 4 ids for each ArUco marker in the ChArUco marker.
 * @param squareLength size of the chessboard squares in pixels.
 * @param markerLength size of the markers in pixels.
 * @param img output image with the marker. The size of this image will be
 * 3*squareLength + 2*marginSize,.
 * @param marginSize minimum margins (in pixels) of the marker in the output image
 *
 * This function return the image of a ChArUco marker, ready to be printed.
 */
+ (void)drawCharucoDiamond:(Dictionary*)dictionary ids:(Int4*)ids squareLength:(int)squareLength markerLength:(int)markerLength img:(Mat*)img marginSize:(int)marginSize NS_SWIFT_NAME(drawCharucoDiamond(dictionary:ids:squareLength:markerLength:img:marginSize:));

/**
 * Draw a ChArUco Diamond marker
 *
 * @param dictionary dictionary of markers indicating the type of markers.
 * @param ids list of 4 ids for each ArUco marker in the ChArUco marker.
 * @param squareLength size of the chessboard squares in pixels.
 * @param markerLength size of the markers in pixels.
 * @param img output image with the marker. The size of this image will be
 * 3*squareLength + 2*marginSize,.
 *
 * This function return the image of a ChArUco marker, ready to be printed.
 */
+ (void)drawCharucoDiamond:(Dictionary*)dictionary ids:(Int4*)ids squareLength:(int)squareLength markerLength:(int)markerLength img:(Mat*)img NS_SWIFT_NAME(drawCharucoDiamond(dictionary:ids:squareLength:markerLength:img:));



@end

NS_ASSUME_NONNULL_END


