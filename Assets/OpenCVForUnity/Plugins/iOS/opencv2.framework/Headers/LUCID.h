//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xfeatures2d.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Feature2D.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class LUCID
/**
 * Class implementing the locally uniform comparison image descriptor, described in CITE: LUCID
 *
 * An image descriptor that can be computed very fast, while being
 * about as robust as, for example, SURF or BRIEF.
 *
 * NOTE: It requires a color image as input.
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface LUCID : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::LUCID> nativePtrLUCID;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::LUCID>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::LUCID>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_LUCID cv::xfeatures2d::LUCID::create(int lucid_kernel = 1, int blur_kernel = 2)
//
/**
 * @param lucid_kernel kernel for descriptor construction, where 1=3x3, 2=5x5, 3=7x7 and so forth
 * @param blur_kernel kernel for blurring image prior to descriptor construction, where 1=3x3, 2=5x5, 3=7x7 and so forth
 */
+ (LUCID*)create:(int)lucid_kernel blur_kernel:(int)blur_kernel NS_SWIFT_NAME(create(lucid_kernel:blur_kernel:));

/**
 * @param lucid_kernel kernel for descriptor construction, where 1=3x3, 2=5x5, 3=7x7 and so forth
 */
+ (LUCID*)create:(int)lucid_kernel NS_SWIFT_NAME(create(lucid_kernel:));

/**
 */
+ (LUCID*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::LUCID::setLucidKernel(int lucid_kernel)
//
- (void)setLucidKernel:(int)lucid_kernel NS_SWIFT_NAME(setLucidKernel(lucid_kernel:));


//
//  int cv::xfeatures2d::LUCID::getLucidKernel()
//
- (int)getLucidKernel NS_SWIFT_NAME(getLucidKernel());


//
//  void cv::xfeatures2d::LUCID::setBlurKernel(int blur_kernel)
//
- (void)setBlurKernel:(int)blur_kernel NS_SWIFT_NAME(setBlurKernel(blur_kernel:));


//
//  int cv::xfeatures2d::LUCID::getBlurKernel()
//
- (int)getBlurKernel NS_SWIFT_NAME(getBlurKernel());


//
//  String cv::xfeatures2d::LUCID::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


