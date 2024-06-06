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




// C++: enum TeblidSize (cv.xfeatures2d.TEBLID.TeblidSize)
typedef NS_ENUM(int, TeblidSize) {
    TEBLID_SIZE_256_BITS NS_SWIFT_NAME(SIZE_256_BITS) = 102,
    TEBLID_SIZE_512_BITS NS_SWIFT_NAME(SIZE_512_BITS) = 103
};



NS_ASSUME_NONNULL_BEGIN

// C++: class TEBLID
/**
 * Class implementing TEBLID (Triplet-based Efficient Binary Local Image Descriptor),
 * described in CITE: Suarez2021TEBLID.
 *
 * TEBLID stands for Triplet-based Efficient Binary Local Image Descriptor, although originally it was called BAD
 * \cite Suarez2021TEBLID. It is an improvement over BEBLID \cite Suarez2020BEBLID, that uses triplet loss,
 * hard negative mining, and anchor swap to improve the image matching results.
 * It is able to describe keypoints from any detector just by changing the scale_factor parameter.
 * TEBLID is as efficient as ORB, BEBLID or BRISK, but the triplet-based training objective selected more
 * discriminative features that explain the accuracy gain. It is also more compact than BEBLID,
 * when running the [AKAZE example](https://github.com/opencv/opencv/blob/4.x/samples/cpp/tutorial_code/features2D/AKAZE_match.cpp)
 * with 10000 keypoints detected by ORB, BEBLID obtains 561 inliers (75%) with 512 bits, whereas
 * TEBLID obtains 621 (75.2%) with 256 bits. ORB obtains only 493 inliers (63%).
 *
 * If you find this code useful, please add a reference to the following paper:
 * <BLOCKQUOTE> Iago Suárez, José M. Buenaposada, and Luis Baumela.
 * Revisiting Binary Local Image Description for Resource Limited Devices.
 * IEEE Robotics and Automation Letters, vol. 6, no. 4, pp. 8317-8324, Oct. 2021. </BLOCKQUOTE>
 *
 * The descriptor was trained in Liberty split of the UBC datasets \cite winder2007learning .
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface TEBLID : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::TEBLID> nativePtrTEBLID;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::TEBLID>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::TEBLID>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_TEBLID cv::xfeatures2d::TEBLID::create(float scale_factor, int n_bits = TEBLID::SIZE_256_BITS)
//
/**
 * Creates the TEBLID descriptor.
 * @param scale_factor Adjust the sampling window around detected keypoints:
 *     - <b> 1.00f </b> should be the scale for ORB keypoints
 *     - <b> 6.75f </b> should be the scale for SIFT detected keypoints
 *     - <b> 6.25f </b> is default and fits for KAZE, SURF detected keypoints
 *     - <b> 5.00f </b> should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints
 * @param n_bits Determine the number of bits in the descriptor. Should be either
 *      TEBLID::SIZE_256_BITS or TEBLID::SIZE_512_BITS.
 */
+ (TEBLID*)create:(float)scale_factor n_bits:(int)n_bits NS_SWIFT_NAME(create(scale_factor:n_bits:));

/**
 * Creates the TEBLID descriptor.
 * @param scale_factor Adjust the sampling window around detected keypoints:
 *     - <b> 1.00f </b> should be the scale for ORB keypoints
 *     - <b> 6.75f </b> should be the scale for SIFT detected keypoints
 *     - <b> 6.25f </b> is default and fits for KAZE, SURF detected keypoints
 *     - <b> 5.00f </b> should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints
 *      TEBLID::SIZE_256_BITS or TEBLID::SIZE_512_BITS.
 */
+ (TEBLID*)create:(float)scale_factor NS_SWIFT_NAME(create(scale_factor:));


//
//  String cv::xfeatures2d::TEBLID::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


