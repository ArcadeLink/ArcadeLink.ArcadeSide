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




// C++: enum BeblidSize (cv.xfeatures2d.BEBLID.BeblidSize)
typedef NS_ENUM(int, BeblidSize) {
    BEBLID_SIZE_512_BITS NS_SWIFT_NAME(SIZE_512_BITS) = 100,
    BEBLID_SIZE_256_BITS NS_SWIFT_NAME(SIZE_256_BITS) = 101
};



NS_ASSUME_NONNULL_BEGIN

// C++: class BEBLID
/**
 * Class implementing BEBLID (Boosted Efficient Binary Local Image Descriptor),
 * described in CITE: Suarez2020BEBLID .
 *
 * BEBLID \cite Suarez2020BEBLID is a efficient binary descriptor learned with boosting.
 * It is able to describe keypoints from any detector just by changing the scale_factor parameter.
 * In several benchmarks it has proved to largely improve other binary descriptors like ORB or
 * BRISK with the same efficiency. BEBLID describes using the difference of mean gray values in
 * different regions of the image around the KeyPoint, the descriptor is specifically optimized for
 * image matching and patch retrieval addressing the asymmetries of these problems.
 *
 * If you find this code useful, please add a reference to the following paper:
 * <BLOCKQUOTE> Iago Suárez, Ghesn Sfeir, José M. Buenaposada, and Luis Baumela.
 * BEBLID: Boosted efficient binary local image descriptor.
 * Pattern Recognition Letters, 133:366–372, 2020. </BLOCKQUOTE>
 *
 * The descriptor was trained using 1 million of randomly sampled pairs of patches
 * (20% positives and 80% negatives) from the Liberty split of the UBC datasets
 * \cite winder2007learning as described in the paper CITE: Suarez2020BEBLID.
 * You can check in the [AKAZE example](https://raw.githubusercontent.com/opencv/opencv/master/samples/cpp/tutorial_code/features2D/AKAZE_match.cpp)
 * how well BEBLID works. Detecting 10000 keypoints with ORB and describing with BEBLID obtains
 * 561 inliers (75%) whereas describing with ORB obtains only 493 inliers (63%).
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface BEBLID : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::BEBLID> nativePtrBEBLID;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::BEBLID>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::BEBLID>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_BEBLID cv::xfeatures2d::BEBLID::create(float scale_factor, int n_bits = BEBLID::SIZE_512_BITS)
//
/**
 * Creates the BEBLID descriptor.
 * @param scale_factor Adjust the sampling window around detected keypoints:
 *     - <b> 1.00f </b> should be the scale for ORB keypoints
 *     - <b> 6.75f </b> should be the scale for SIFT detected keypoints
 *     - <b> 6.25f </b> is default and fits for KAZE, SURF detected keypoints
 *     - <b> 5.00f </b> should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints
 * @param n_bits Determine the number of bits in the descriptor. Should be either
 *      BEBLID::SIZE_512_BITS or BEBLID::SIZE_256_BITS.
 */
+ (BEBLID*)create:(float)scale_factor n_bits:(int)n_bits NS_SWIFT_NAME(create(scale_factor:n_bits:));

/**
 * Creates the BEBLID descriptor.
 * @param scale_factor Adjust the sampling window around detected keypoints:
 *     - <b> 1.00f </b> should be the scale for ORB keypoints
 *     - <b> 6.75f </b> should be the scale for SIFT detected keypoints
 *     - <b> 6.25f </b> is default and fits for KAZE, SURF detected keypoints
 *     - <b> 5.00f </b> should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints
 *      BEBLID::SIZE_512_BITS or BEBLID::SIZE_256_BITS.
 */
+ (BEBLID*)create:(float)scale_factor NS_SWIFT_NAME(create(scale_factor:));


//
//  void cv::xfeatures2d::BEBLID::setScaleFactor(float scale_factor)
//
- (void)setScaleFactor:(float)scale_factor NS_SWIFT_NAME(setScaleFactor(scale_factor:));


//
//  float cv::xfeatures2d::BEBLID::getScaleFactor()
//
- (float)getScaleFactor NS_SWIFT_NAME(getScaleFactor());


//
//  String cv::xfeatures2d::BEBLID::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


