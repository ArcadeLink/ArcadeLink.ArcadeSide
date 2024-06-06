//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xphoto.hpp"
#import "opencv2/xphoto/white_balance.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class WhiteBalancer
/**
 * The base class for auto white balance algorithms.
 *
 * Member of `Xphoto`
 */
CV_EXPORTS @interface WhiteBalancer : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xphoto::WhiteBalancer> nativePtrWhiteBalancer;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xphoto::WhiteBalancer>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xphoto::WhiteBalancer>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::xphoto::WhiteBalancer::balanceWhite(Mat src, Mat& dst)
//
/**
 * Applies white balancing to the input image
 *
 * @param src Input image
 * @param dst White balancing result
 *     @see `cvtColor`, `equalizeHist`
 */
- (void)balanceWhite:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(balanceWhite(src:dst:));



@end

NS_ASSUME_NONNULL_END


