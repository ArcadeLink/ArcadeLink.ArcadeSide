//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/radial_variance_hash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "ImgHashBase.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class RadialVarianceHash
/**
 * Image hash based on Radon transform.
 *
 * See CITE: tang2012perceptual for details.
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface RadialVarianceHash : ImgHashBase


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::RadialVarianceHash> nativePtrRadialVarianceHash;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::RadialVarianceHash>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::RadialVarianceHash>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_RadialVarianceHash cv::img_hash::RadialVarianceHash::create(double sigma = 1, int numOfAngleLine = 180)
//
+ (RadialVarianceHash*)create:(double)sigma numOfAngleLine:(int)numOfAngleLine NS_SWIFT_NAME(create(sigma:numOfAngleLine:));

+ (RadialVarianceHash*)create:(double)sigma NS_SWIFT_NAME(create(sigma:));

+ (RadialVarianceHash*)create NS_SWIFT_NAME(create());


//
//  int cv::img_hash::RadialVarianceHash::getNumOfAngleLine()
//
- (int)getNumOfAngleLine NS_SWIFT_NAME(getNumOfAngleLine());


//
//  double cv::img_hash::RadialVarianceHash::getSigma()
//
- (double)getSigma NS_SWIFT_NAME(getSigma());


//
//  void cv::img_hash::RadialVarianceHash::setNumOfAngleLine(int value)
//
- (void)setNumOfAngleLine:(int)value NS_SWIFT_NAME(setNumOfAngleLine(value:));


//
//  void cv::img_hash::RadialVarianceHash::setSigma(double value)
//
- (void)setSigma:(double)value NS_SWIFT_NAME(setSigma(value:));



@end

NS_ASSUME_NONNULL_END


