//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "face/bif.hpp"
#import "opencv2/face/bif.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class BIF
/**
 * Implementation of bio-inspired features (BIF) from the paper:
 * Guo, Guodong, et al. "Human age estimation using bio-inspired features."
 * Computer Vision and Pattern Recognition, 2009. CVPR 2009.
 *
 * Member of `Face`
 */
CV_EXPORTS @interface BIF : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::BIF> nativePtrBIF;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::BIF>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::BIF>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::face::BIF::getNumBands()
//
/**
 * @return The number of filter bands used for computing BIF.
 */
- (int)getNumBands NS_SWIFT_NAME(getNumBands());


//
//  int cv::face::BIF::getNumRotations()
//
/**
 * @return The number of image rotations.
 */
- (int)getNumRotations NS_SWIFT_NAME(getNumRotations());


//
//  void cv::face::BIF::compute(Mat image, Mat& features)
//
/**
 * Computes features sby input image.
 * @param image Input image (CV_32FC1).
 * @param features Feature vector (CV_32FC1).
 */
- (void)compute:(Mat*)image features:(Mat*)features NS_SWIFT_NAME(compute(image:features:));


//
// static Ptr_BIF cv::face::BIF::create(int num_bands = 8, int num_rotations = 12)
//
/**
 * @param num_bands The number of filter bands (<=8) used for computing BIF.
 * @param num_rotations The number of image rotations for computing BIF.
 * @return Object for computing BIF.
 */
+ (BIF*)create:(int)num_bands num_rotations:(int)num_rotations NS_SWIFT_NAME(create(num_bands:num_rotations:));

/**
 * @param num_bands The number of filter bands (<=8) used for computing BIF.
 * @return Object for computing BIF.
 */
+ (BIF*)create:(int)num_bands NS_SWIFT_NAME(create(num_bands:));

/**
 * @return Object for computing BIF.
 */
+ (BIF*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


