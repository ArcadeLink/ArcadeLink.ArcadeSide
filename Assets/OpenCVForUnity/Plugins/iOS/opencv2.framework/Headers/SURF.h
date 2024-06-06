//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xfeatures2d.hpp"
#import "opencv2/xfeatures2d/nonfree.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Feature2D.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class SURF
/**
 * Class for extracting Speeded Up Robust Features from an image CITE: Bay06 .
 *
 * The algorithm parameters:
 * -   member int extended
 *     -   0 means that the basic descriptors (64 elements each) shall be computed
 *     -   1 means that the extended descriptors (128 elements each) shall be computed
 * -   member int upright
 *     -   0 means that detector computes orientation of each feature.
 *     -   1 means that the orientation is not computed (which is much, much faster). For example,
 * if you match images from a stereo pair, or do image stitching, the matched features
 * likely have very similar angles, and you can speed up feature extraction by setting
 * upright=1.
 * -   member double hessianThreshold
 * Threshold for the keypoint detector. Only features, whose hessian is larger than
 * hessianThreshold are retained by the detector. Therefore, the larger the value, the less
 * keypoints you will get. A good default value could be from 300 to 500, depending from the
 * image contrast.
 * -   member int nOctaves
 * The number of a gaussian pyramid octaves that the detector uses. It is set to 4 by default.
 * If you want to get very large features, use the larger value. If you want just small
 * features, decrease it.
 * -   member int nOctaveLayers
 * The number of images within each octave of a gaussian pyramid. It is set to 2 by default.
 * NOTE:
 *    -   An example using the SURF feature detector can be found at
 *         opencv_source_code/samples/cpp/generic_descriptor_match.cpp
 *     -   Another example using the SURF feature detector, extractor and matcher can be found at
 *         opencv_source_code/samples/cpp/matcher_simple.cpp
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface SURF : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::SURF> nativePtrSURF;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::SURF>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::SURF>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_SURF cv::xfeatures2d::SURF::create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
//
/**
 * @param hessianThreshold Threshold for hessian keypoint detector used in SURF.
 * @param nOctaves Number of pyramid octaves the keypoint detector will use.
 * @param nOctaveLayers Number of octave layers within each octave.
 * @param extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
 *     64-element descriptors).
 * @param upright Up-right or rotated features flag (true - do not compute orientation of features;
 *     false - compute orientation).
 */
+ (SURF*)create:(double)hessianThreshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers extended:(BOOL)extended upright:(BOOL)upright NS_SWIFT_NAME(create(hessianThreshold:nOctaves:nOctaveLayers:extended:upright:));

/**
 * @param hessianThreshold Threshold for hessian keypoint detector used in SURF.
 * @param nOctaves Number of pyramid octaves the keypoint detector will use.
 * @param nOctaveLayers Number of octave layers within each octave.
 * @param extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
 *     64-element descriptors).
 *     false - compute orientation).
 */
+ (SURF*)create:(double)hessianThreshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers extended:(BOOL)extended NS_SWIFT_NAME(create(hessianThreshold:nOctaves:nOctaveLayers:extended:));

/**
 * @param hessianThreshold Threshold for hessian keypoint detector used in SURF.
 * @param nOctaves Number of pyramid octaves the keypoint detector will use.
 * @param nOctaveLayers Number of octave layers within each octave.
 *     64-element descriptors).
 *     false - compute orientation).
 */
+ (SURF*)create:(double)hessianThreshold nOctaves:(int)nOctaves nOctaveLayers:(int)nOctaveLayers NS_SWIFT_NAME(create(hessianThreshold:nOctaves:nOctaveLayers:));

/**
 * @param hessianThreshold Threshold for hessian keypoint detector used in SURF.
 * @param nOctaves Number of pyramid octaves the keypoint detector will use.
 *     64-element descriptors).
 *     false - compute orientation).
 */
+ (SURF*)create:(double)hessianThreshold nOctaves:(int)nOctaves NS_SWIFT_NAME(create(hessianThreshold:nOctaves:));

/**
 * @param hessianThreshold Threshold for hessian keypoint detector used in SURF.
 *     64-element descriptors).
 *     false - compute orientation).
 */
+ (SURF*)create:(double)hessianThreshold NS_SWIFT_NAME(create(hessianThreshold:));

/**
 *     64-element descriptors).
 *     false - compute orientation).
 */
+ (SURF*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::SURF::setHessianThreshold(double hessianThreshold)
//
- (void)setHessianThreshold:(double)hessianThreshold NS_SWIFT_NAME(setHessianThreshold(hessianThreshold:));


//
//  double cv::xfeatures2d::SURF::getHessianThreshold()
//
- (double)getHessianThreshold NS_SWIFT_NAME(getHessianThreshold());


//
//  void cv::xfeatures2d::SURF::setNOctaves(int nOctaves)
//
- (void)setNOctaves:(int)nOctaves NS_SWIFT_NAME(setNOctaves(nOctaves:));


//
//  int cv::xfeatures2d::SURF::getNOctaves()
//
- (int)getNOctaves NS_SWIFT_NAME(getNOctaves());


//
//  void cv::xfeatures2d::SURF::setNOctaveLayers(int nOctaveLayers)
//
- (void)setNOctaveLayers:(int)nOctaveLayers NS_SWIFT_NAME(setNOctaveLayers(nOctaveLayers:));


//
//  int cv::xfeatures2d::SURF::getNOctaveLayers()
//
- (int)getNOctaveLayers NS_SWIFT_NAME(getNOctaveLayers());


//
//  void cv::xfeatures2d::SURF::setExtended(bool extended)
//
- (void)setExtended:(BOOL)extended NS_SWIFT_NAME(setExtended(extended:));


//
//  bool cv::xfeatures2d::SURF::getExtended()
//
- (BOOL)getExtended NS_SWIFT_NAME(getExtended());


//
//  void cv::xfeatures2d::SURF::setUpright(bool upright)
//
- (void)setUpright:(BOOL)upright NS_SWIFT_NAME(setUpright(upright:));


//
//  bool cv::xfeatures2d::SURF::getUpright()
//
- (BOOL)getUpright NS_SWIFT_NAME(getUpright());


//
//  String cv::xfeatures2d::SURF::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


