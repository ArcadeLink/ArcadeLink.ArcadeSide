//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/structured_edge_detection.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class StructuredEdgeDetection
/**
 * Class implementing edge detection algorithm from CITE: Dollar2013 :
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface StructuredEdgeDetection : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::StructuredEdgeDetection> nativePtrStructuredEdgeDetection;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::StructuredEdgeDetection>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::StructuredEdgeDetection>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::StructuredEdgeDetection::detectEdges(Mat src, Mat& dst)
//
/**
 * The function detects edges in src and draw them to dst.
 *
 *     The algorithm underlies this function is much more robust to texture presence, than common
 *     approaches, e.g. Sobel
 * @param src source image (RGB, float, in [0;1]) to detect edges
 * @param dst destination image (grayscale, float, in [0;1]) where edges are drawn
 *     @see `Sobel`, `Canny`
 */
- (void)detectEdges:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(detectEdges(src:dst:));


//
//  void cv::ximgproc::StructuredEdgeDetection::computeOrientation(Mat src, Mat& dst)
//
/**
 * The function computes orientation from edge image.
 *
 * @param src edge image.
 * @param dst orientation image.
 */
- (void)computeOrientation:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(computeOrientation(src:dst:));


//
//  void cv::ximgproc::StructuredEdgeDetection::edgesNms(Mat edge_image, Mat orientation_image, Mat& dst, int r = 2, int s = 0, float m = 1, bool isParallel = true)
//
/**
 * The function edgenms in edge image and suppress edges where edge is stronger in orthogonal direction.
 *
 * @param edge_image edge image from detectEdges function.
 * @param orientation_image orientation image from computeOrientation function.
 * @param dst suppressed image (grayscale, float, in [0;1])
 * @param r radius for NMS suppression.
 * @param s radius for boundary suppression.
 * @param m multiplier for conservative suppression.
 * @param isParallel enables/disables parallel computing.
 */
- (void)edgesNms:(Mat*)edge_image orientation_image:(Mat*)orientation_image dst:(Mat*)dst r:(int)r s:(int)s m:(float)m isParallel:(BOOL)isParallel NS_SWIFT_NAME(edgesNms(edge_image:orientation_image:dst:r:s:m:isParallel:));

/**
 * The function edgenms in edge image and suppress edges where edge is stronger in orthogonal direction.
 *
 * @param edge_image edge image from detectEdges function.
 * @param orientation_image orientation image from computeOrientation function.
 * @param dst suppressed image (grayscale, float, in [0;1])
 * @param r radius for NMS suppression.
 * @param s radius for boundary suppression.
 * @param m multiplier for conservative suppression.
 */
- (void)edgesNms:(Mat*)edge_image orientation_image:(Mat*)orientation_image dst:(Mat*)dst r:(int)r s:(int)s m:(float)m NS_SWIFT_NAME(edgesNms(edge_image:orientation_image:dst:r:s:m:));

/**
 * The function edgenms in edge image and suppress edges where edge is stronger in orthogonal direction.
 *
 * @param edge_image edge image from detectEdges function.
 * @param orientation_image orientation image from computeOrientation function.
 * @param dst suppressed image (grayscale, float, in [0;1])
 * @param r radius for NMS suppression.
 * @param s radius for boundary suppression.
 */
- (void)edgesNms:(Mat*)edge_image orientation_image:(Mat*)orientation_image dst:(Mat*)dst r:(int)r s:(int)s NS_SWIFT_NAME(edgesNms(edge_image:orientation_image:dst:r:s:));

/**
 * The function edgenms in edge image and suppress edges where edge is stronger in orthogonal direction.
 *
 * @param edge_image edge image from detectEdges function.
 * @param orientation_image orientation image from computeOrientation function.
 * @param dst suppressed image (grayscale, float, in [0;1])
 * @param r radius for NMS suppression.
 */
- (void)edgesNms:(Mat*)edge_image orientation_image:(Mat*)orientation_image dst:(Mat*)dst r:(int)r NS_SWIFT_NAME(edgesNms(edge_image:orientation_image:dst:r:));

/**
 * The function edgenms in edge image and suppress edges where edge is stronger in orthogonal direction.
 *
 * @param edge_image edge image from detectEdges function.
 * @param orientation_image orientation image from computeOrientation function.
 * @param dst suppressed image (grayscale, float, in [0;1])
 */
- (void)edgesNms:(Mat*)edge_image orientation_image:(Mat*)orientation_image dst:(Mat*)dst NS_SWIFT_NAME(edgesNms(edge_image:orientation_image:dst:));



@end

NS_ASSUME_NONNULL_END


