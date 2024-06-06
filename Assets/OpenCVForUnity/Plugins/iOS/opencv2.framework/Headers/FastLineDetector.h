//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/fast_line_detector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;
@class Scalar;



NS_ASSUME_NONNULL_BEGIN

// C++: class FastLineDetector
/**
 * Class implementing the FLD (Fast Line Detector) algorithm described
 * in CITE: Lee14 .
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface FastLineDetector : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::FastLineDetector> nativePtrFastLineDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::FastLineDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::FastLineDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::FastLineDetector::detect(Mat image, Mat& lines)
//
/**
 * Finds lines in the input image.
 *       This is the output of the default parameters of the algorithm on the above
 *       shown image.
 *
 *       ![image](pics/corridor_fld.jpg)
 *
 * @param image A grayscale (CV_8UC1) input image. If only a roi needs to be
 *       selected, use: `fld_ptr-\>detect(image(roi), lines, ...);
 *       lines += Scalar(roi.x, roi.y, roi.x, roi.y);`
 * @param lines A vector of Vec4f elements specifying the beginning
 *       and ending point of a line.  Where Vec4f is (x1, y1, x2, y2), point
 *       1 is the start, point 2 - end. Returned lines are directed so that the
 *       brighter side is on their left.
 */
- (void)detect:(Mat*)image lines:(Mat*)lines NS_SWIFT_NAME(detect(image:lines:));


//
//  void cv::ximgproc::FastLineDetector::drawSegments(Mat& image, Mat lines, bool draw_arrow = false, Scalar linecolor = Scalar(0, 0, 255), int linethickness = 1)
//
/**
 * Draws the line segments on a given image.
 * @param image The image, where the lines will be drawn. Should be bigger
 *       or equal to the image, where the lines were found.
 * @param lines A vector of the lines that needed to be drawn.
 * @param draw_arrow If true, arrow heads will be drawn.
 * @param linecolor Line color.
 * @param linethickness Line thickness.
 */
- (void)drawSegments:(Mat*)image lines:(Mat*)lines draw_arrow:(BOOL)draw_arrow linecolor:(Scalar*)linecolor linethickness:(int)linethickness NS_SWIFT_NAME(drawSegments(image:lines:draw_arrow:linecolor:linethickness:));

/**
 * Draws the line segments on a given image.
 * @param image The image, where the lines will be drawn. Should be bigger
 *       or equal to the image, where the lines were found.
 * @param lines A vector of the lines that needed to be drawn.
 * @param draw_arrow If true, arrow heads will be drawn.
 * @param linecolor Line color.
 */
- (void)drawSegments:(Mat*)image lines:(Mat*)lines draw_arrow:(BOOL)draw_arrow linecolor:(Scalar*)linecolor NS_SWIFT_NAME(drawSegments(image:lines:draw_arrow:linecolor:));

/**
 * Draws the line segments on a given image.
 * @param image The image, where the lines will be drawn. Should be bigger
 *       or equal to the image, where the lines were found.
 * @param lines A vector of the lines that needed to be drawn.
 * @param draw_arrow If true, arrow heads will be drawn.
 */
- (void)drawSegments:(Mat*)image lines:(Mat*)lines draw_arrow:(BOOL)draw_arrow NS_SWIFT_NAME(drawSegments(image:lines:draw_arrow:));

/**
 * Draws the line segments on a given image.
 * @param image The image, where the lines will be drawn. Should be bigger
 *       or equal to the image, where the lines were found.
 * @param lines A vector of the lines that needed to be drawn.
 */
- (void)drawSegments:(Mat*)image lines:(Mat*)lines NS_SWIFT_NAME(drawSegments(image:lines:));



@end

NS_ASSUME_NONNULL_END


