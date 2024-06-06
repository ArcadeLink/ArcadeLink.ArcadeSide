//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/edge_filter.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class AdaptiveManifoldFilter
/**
 * Interface for Adaptive Manifold Filter realizations.
 *
 * For more details about this filter see CITE: Gastal12 and References_.
 *
 * Below listed optional parameters which may be set up with Algorithm::set function.
 * -   member double sigma_s = 16.0
 * Spatial standard deviation.
 * -   member double sigma_r = 0.2
 * Color space standard deviation.
 * -   member int tree_height = -1
 * Height of the manifold tree (default = -1 : automatically computed).
 * -   member int num_pca_iterations = 1
 * Number of iterations to computed the eigenvector.
 * -   member bool adjust_outliers = false
 * Specify adjust outliers using Eq. 9 or not.
 * -   member bool use_RNG = true
 * Specify use random number generator to compute eigenvector or not.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface AdaptiveManifoldFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::AdaptiveManifoldFilter> nativePtrAdaptiveManifoldFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::AdaptiveManifoldFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::AdaptiveManifoldFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::AdaptiveManifoldFilter::filter(Mat src, Mat& dst, Mat joint = Mat())
//
/**
 * Apply high-dimensional filtering using adaptive manifolds.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 * @param joint optional joint (also called as guided) image with any numbers of channels.
 */
- (void)filter:(Mat*)src dst:(Mat*)dst joint:(Mat*)joint NS_SWIFT_NAME(filter(src:dst:joint:));

/**
 * Apply high-dimensional filtering using adaptive manifolds.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 */
- (void)filter:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(filter(src:dst:));


//
//  void cv::ximgproc::AdaptiveManifoldFilter::collectGarbage()
//
- (void)collectGarbage NS_SWIFT_NAME(collectGarbage());


//
// static Ptr_AdaptiveManifoldFilter cv::ximgproc::AdaptiveManifoldFilter::create()
//
+ (AdaptiveManifoldFilter*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


