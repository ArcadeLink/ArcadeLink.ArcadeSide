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
#import "AffineFeature2D.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class TBMR
/**
 * Class implementing the Tree Based Morse Regions (TBMR) as described in
 * CITE: Najman2014 extended with scaled extraction ability.
 *
 * min_area prune areas smaller than minArea
 * max_area_relative prune areas bigger than maxArea = max_area_relative *
 * input_image_size
 * scale_factor scale factor for scaled extraction.
 * n_scales number of applications of the scale factor (octaves).
 *
 * NOTE: This algorithm is based on Component Tree (Min/Max) as well as MSER but
 * uses a Morse-theory approach to extract features.
 *
 * Features are ellipses (similar to MSER, however a MSER feature can never be a
 * TBMR feature and vice versa).
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface TBMR : AffineFeature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::TBMR> nativePtrTBMR;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::TBMR>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::TBMR>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_TBMR cv::xfeatures2d::TBMR::create(int min_area = 60, float max_area_relative = 0.01f, float scale_factor = 1.25f, int n_scales = -1)
//
+ (TBMR*)create:(int)min_area max_area_relative:(float)max_area_relative scale_factor:(float)scale_factor n_scales:(int)n_scales NS_SWIFT_NAME(create(min_area:max_area_relative:scale_factor:n_scales:));

+ (TBMR*)create:(int)min_area max_area_relative:(float)max_area_relative scale_factor:(float)scale_factor NS_SWIFT_NAME(create(min_area:max_area_relative:scale_factor:));

+ (TBMR*)create:(int)min_area max_area_relative:(float)max_area_relative NS_SWIFT_NAME(create(min_area:max_area_relative:));

+ (TBMR*)create:(int)min_area NS_SWIFT_NAME(create(min_area:));

+ (TBMR*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::TBMR::setMinArea(int minArea)
//
- (void)setMinArea:(int)minArea NS_SWIFT_NAME(setMinArea(minArea:));


//
//  int cv::xfeatures2d::TBMR::getMinArea()
//
- (int)getMinArea NS_SWIFT_NAME(getMinArea());


//
//  void cv::xfeatures2d::TBMR::setMaxAreaRelative(float maxArea)
//
- (void)setMaxAreaRelative:(float)maxArea NS_SWIFT_NAME(setMaxAreaRelative(maxArea:));


//
//  float cv::xfeatures2d::TBMR::getMaxAreaRelative()
//
- (float)getMaxAreaRelative NS_SWIFT_NAME(getMaxAreaRelative());


//
//  void cv::xfeatures2d::TBMR::setScaleFactor(float scale_factor)
//
- (void)setScaleFactor:(float)scale_factor NS_SWIFT_NAME(setScaleFactor(scale_factor:));


//
//  float cv::xfeatures2d::TBMR::getScaleFactor()
//
- (float)getScaleFactor NS_SWIFT_NAME(getScaleFactor());


//
//  void cv::xfeatures2d::TBMR::setNScales(int n_scales)
//
- (void)setNScales:(int)n_scales NS_SWIFT_NAME(setNScales(n_scales:));


//
//  int cv::xfeatures2d::TBMR::getNScales()
//
- (int)getNScales NS_SWIFT_NAME(getNScales());



@end

NS_ASSUME_NONNULL_END


