//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/ridgefilter.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class RidgeDetectionFilter
/**
 *  Applies Ridge Detection Filter to an input image.
 * Implements Ridge detection similar to the one in [Mathematica](http://reference.wolfram.com/language/ref/RidgeFilter.html)
 * using the eigen values from the Hessian Matrix of the input image using Sobel Derivatives.
 * Additional refinement can be done using Skeletonization and Binarization. Adapted from CITE: segleafvein and CITE: M_RF
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface RidgeDetectionFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::RidgeDetectionFilter> nativePtrRidgeDetectionFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::RidgeDetectionFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::RidgeDetectionFilter>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_RidgeDetectionFilter cv::ximgproc::RidgeDetectionFilter::create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
//
/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 * @param dy  Order of derivative y, default is 1
 * @param ksize Sobel kernel size , default is 3
 * @param out_dtype Converted format for output, default is CV_8UC1
 * @param scale Optional scale value for derivative values, default is 1
 * @param delta  Optional bias added to output, default is 0
 * @param borderType Pixel extrapolation method, default is BORDER_DEFAULT
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize out_dtype:(int)out_dtype scale:(double)scale delta:(double)delta borderType:(int)borderType NS_SWIFT_NAME(create(ddepth:dx:dy:ksize:out_dtype:scale:delta:borderType:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 * @param dy  Order of derivative y, default is 1
 * @param ksize Sobel kernel size , default is 3
 * @param out_dtype Converted format for output, default is CV_8UC1
 * @param scale Optional scale value for derivative values, default is 1
 * @param delta  Optional bias added to output, default is 0
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize out_dtype:(int)out_dtype scale:(double)scale delta:(double)delta NS_SWIFT_NAME(create(ddepth:dx:dy:ksize:out_dtype:scale:delta:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 * @param dy  Order of derivative y, default is 1
 * @param ksize Sobel kernel size , default is 3
 * @param out_dtype Converted format for output, default is CV_8UC1
 * @param scale Optional scale value for derivative values, default is 1
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize out_dtype:(int)out_dtype scale:(double)scale NS_SWIFT_NAME(create(ddepth:dx:dy:ksize:out_dtype:scale:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 * @param dy  Order of derivative y, default is 1
 * @param ksize Sobel kernel size , default is 3
 * @param out_dtype Converted format for output, default is CV_8UC1
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize out_dtype:(int)out_dtype NS_SWIFT_NAME(create(ddepth:dx:dy:ksize:out_dtype:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 * @param dy  Order of derivative y, default is 1
 * @param ksize Sobel kernel size , default is 3
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx dy:(int)dy ksize:(int)ksize NS_SWIFT_NAME(create(ddepth:dx:dy:ksize:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 * @param dy  Order of derivative y, default is 1
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx dy:(int)dy NS_SWIFT_NAME(create(ddepth:dx:dy:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 * @param dx Order of derivative x, default is 1
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth dx:(int)dx NS_SWIFT_NAME(create(ddepth:dx:));

/**
 * Create pointer to the Ridge detection filter.
 * @param ddepth  Specifies output image depth. Defualt is CV_32FC1
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create:(int)ddepth NS_SWIFT_NAME(create(ddepth:));

/**
 * Create pointer to the Ridge detection filter.
 *     @see `Sobel`, `threshold`, `getStructuringElement`, `morphologyEx.( for additional refinement)`
 */
+ (RidgeDetectionFilter*)create NS_SWIFT_NAME(create());


//
//  void cv::ximgproc::RidgeDetectionFilter::getRidgeFilteredImage(Mat _img, Mat& out)
//
/**
 * Apply Ridge detection filter on input image.
 * @param _img InputArray as supported by Sobel. img can be 1-Channel or 3-Channels.
 * @param out OutputAray of structure as RidgeDetectionFilter::ddepth. Output image with ridges.
 */
- (void)getRidgeFilteredImage:(Mat*)_img out:(Mat*)out NS_SWIFT_NAME(getRidgeFilteredImage(_img:out:));



@end

NS_ASSUME_NONNULL_END


