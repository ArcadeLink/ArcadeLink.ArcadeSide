//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/edge_drawing.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class EdgeDrawingParams;
@class IntVector;
@class Mat;
@class Point2i;


// C++: enum GradientOperator (cv.ximgproc.EdgeDrawing.GradientOperator)
typedef NS_ENUM(int, GradientOperator) {
    EdgeDrawing_PREWITT NS_SWIFT_NAME(PREWITT) = 0,
    EdgeDrawing_SOBEL NS_SWIFT_NAME(SOBEL) = 1,
    EdgeDrawing_SCHARR NS_SWIFT_NAME(SCHARR) = 2,
    EdgeDrawing_LSD NS_SWIFT_NAME(LSD) = 3
};



NS_ASSUME_NONNULL_BEGIN

// C++: class EdgeDrawing
/**
 * Class implementing the ED (EdgeDrawing) CITE: topal2012edge, EDLines CITE: akinlar2011edlines, EDPF CITE: akinlar2012edpf and EDCircles CITE: akinlar2013edcircles algorithms
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface EdgeDrawing : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::EdgeDrawing> nativePtrEdgeDrawing;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::EdgeDrawing>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::EdgeDrawing>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::EdgeDrawing::detectEdges(Mat src)
//
/**
 * Detects edges in a grayscale image and prepares them to detect lines and ellipses.
 *
 * @param src 8-bit, single-channel, grayscale input image.
 */
- (void)detectEdges:(Mat*)src NS_SWIFT_NAME(detectEdges(src:));


//
//  void cv::ximgproc::EdgeDrawing::getEdgeImage(Mat& dst)
//
/**
 * returns Edge Image prepared by detectEdges() function.
 *
 * @param dst returns 8-bit, single-channel output image.
 */
- (void)getEdgeImage:(Mat*)dst NS_SWIFT_NAME(getEdgeImage(dst:));


//
//  void cv::ximgproc::EdgeDrawing::getGradientImage(Mat& dst)
//
/**
 * returns Gradient Image prepared by detectEdges() function.
 *
 * @param dst returns 16-bit, single-channel output image.
 */
- (void)getGradientImage:(Mat*)dst NS_SWIFT_NAME(getGradientImage(dst:));


//
//  vector_vector_Point cv::ximgproc::EdgeDrawing::getSegments()
//
/**
 * Returns std::vector<std::vector<Point>> of detected edge segments, see detectEdges()
 */
- (NSArray<NSArray<Point2i*>*>*)getSegments NS_SWIFT_NAME(getSegments());


//
//  vector_int cv::ximgproc::EdgeDrawing::getSegmentIndicesOfLines()
//
/**
 * Returns for each line found in detectLines() its edge segment index in getSegments()
 */
- (IntVector*)getSegmentIndicesOfLines NS_SWIFT_NAME(getSegmentIndicesOfLines());


//
//  void cv::ximgproc::EdgeDrawing::detectLines(Mat& lines)
//
/**
 * Detects lines.
 *
 * @param lines  output Vec<4f> contains the start point and the end point of detected lines.
 *     NOTE: you should call detectEdges() before calling this function.
 */
- (void)detectLines:(Mat*)lines NS_SWIFT_NAME(detectLines(lines:));


//
//  void cv::ximgproc::EdgeDrawing::detectEllipses(Mat& ellipses)
//
/**
 * Detects circles and ellipses.
 *
 * @param ellipses  output Vec<6d> contains center point and perimeter for circles, center point, axes and angle for ellipses.
 *     NOTE: you should call detectEdges() before calling this function.
 */
- (void)detectEllipses:(Mat*)ellipses NS_SWIFT_NAME(detectEllipses(ellipses:));


//
//  void cv::ximgproc::EdgeDrawing::setParams(EdgeDrawing_Params parameters)
//
/**
 * sets parameters.
 *
 *     this function is meant to be used for parameter setting in other languages than c++ like python.
 * @param parameters Parameters of the algorithm
 */
- (void)setParams:(EdgeDrawingParams*)parameters NS_SWIFT_NAME(setParams(parameters:));



@end

NS_ASSUME_NONNULL_END


