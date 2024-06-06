//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/aruco_board.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Board.h"

@class Dictionary;
@class Mat;
@class Size2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class GridBoard
/**
 * Planar board with grid arrangement of markers
 *
 * More common type of board. All markers are placed in the same plane in a grid arrangement.
 * The board image can be drawn using generateImage() method.
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface GridBoard : Board


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::GridBoard> nativePtrGridBoard;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::GridBoard>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::GridBoard>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::GridBoard::GridBoard(Size size, float markerLength, float markerSeparation, Dictionary dictionary, Mat ids = Mat())
//
/**
 * GridBoard constructor
 *
 * @param size number of markers in x and y directions
 * @param markerLength marker side length (normally in meters)
 * @param markerSeparation separation between two markers (same unit as markerLength)
 * @param dictionary dictionary of markers indicating the type of markers
 * @param ids set of marker ids in dictionary to use on board.
 */
- (instancetype)initWithSize:(Size2i*)size markerLength:(float)markerLength markerSeparation:(float)markerSeparation dictionary:(Dictionary*)dictionary ids:(Mat*)ids;

/**
 * GridBoard constructor
 *
 * @param size number of markers in x and y directions
 * @param markerLength marker side length (normally in meters)
 * @param markerSeparation separation between two markers (same unit as markerLength)
 * @param dictionary dictionary of markers indicating the type of markers
 */
- (instancetype)initWithSize:(Size2i*)size markerLength:(float)markerLength markerSeparation:(float)markerSeparation dictionary:(Dictionary*)dictionary;


//
//  Size cv::aruco::GridBoard::getGridSize()
//
- (Size2i*)getGridSize NS_SWIFT_NAME(getGridSize());


//
//  float cv::aruco::GridBoard::getMarkerLength()
//
- (float)getMarkerLength NS_SWIFT_NAME(getMarkerLength());


//
//  float cv::aruco::GridBoard::getMarkerSeparation()
//
- (float)getMarkerSeparation NS_SWIFT_NAME(getMarkerSeparation());



@end

NS_ASSUME_NONNULL_END


