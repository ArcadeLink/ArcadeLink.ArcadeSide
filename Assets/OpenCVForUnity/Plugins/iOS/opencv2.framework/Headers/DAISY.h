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

@class Mat;


// C++: enum NormalizationType (cv.xfeatures2d.DAISY.NormalizationType)
typedef NS_ENUM(int, NormalizationType) {
    DAISY_NRM_NONE NS_SWIFT_NAME(NRM_NONE) = 100,
    DAISY_NRM_PARTIAL NS_SWIFT_NAME(NRM_PARTIAL) = 101,
    DAISY_NRM_FULL NS_SWIFT_NAME(NRM_FULL) = 102,
    DAISY_NRM_SIFT NS_SWIFT_NAME(NRM_SIFT) = 103
};



NS_ASSUME_NONNULL_BEGIN

// C++: class DAISY
/**
 * Class implementing DAISY descriptor, described in CITE: Tola10
 *
 * radius radius of the descriptor at the initial scale
 * q_radius amount of radial range division quantity
 * q_theta amount of angular range division quantity
 * q_hist amount of gradient orientations range division quantity
 * norm choose descriptors normalization type, where
 * DAISY::NRM_NONE will not do any normalization (default),
 * DAISY::NRM_PARTIAL mean that histograms are normalized independently for L2 norm equal to 1.0,
 * DAISY::NRM_FULL mean that descriptors are normalized for L2 norm equal to 1.0,
 * DAISY::NRM_SIFT mean that descriptors are normalized for L2 norm equal to 1.0 but no individual one is bigger than 0.154 as in SIFT
 * H optional 3x3 homography matrix used to warp the grid of daisy but sampling keypoints remains unwarped on image
 * interpolation switch to disable interpolation for speed improvement at minor quality loss
 * use_orientation sample patterns using keypoints orientation, disabled by default.
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface DAISY : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::DAISY> nativePtrDAISY;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::DAISY>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::DAISY>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, NormalizationType norm = cv::xfeatures2d::DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
//
+ (DAISY*)create:(float)radius q_radius:(int)q_radius q_theta:(int)q_theta q_hist:(int)q_hist norm:(NormalizationType)norm H:(Mat*)H interpolation:(BOOL)interpolation use_orientation:(BOOL)use_orientation NS_SWIFT_NAME(create(radius:q_radius:q_theta:q_hist:norm:H:interpolation:use_orientation:));

+ (DAISY*)create:(float)radius q_radius:(int)q_radius q_theta:(int)q_theta q_hist:(int)q_hist norm:(NormalizationType)norm H:(Mat*)H interpolation:(BOOL)interpolation NS_SWIFT_NAME(create(radius:q_radius:q_theta:q_hist:norm:H:interpolation:));

+ (DAISY*)create:(float)radius q_radius:(int)q_radius q_theta:(int)q_theta q_hist:(int)q_hist norm:(NormalizationType)norm H:(Mat*)H NS_SWIFT_NAME(create(radius:q_radius:q_theta:q_hist:norm:H:));

+ (DAISY*)create:(float)radius q_radius:(int)q_radius q_theta:(int)q_theta q_hist:(int)q_hist norm:(NormalizationType)norm NS_SWIFT_NAME(create(radius:q_radius:q_theta:q_hist:norm:));

+ (DAISY*)create:(float)radius q_radius:(int)q_radius q_theta:(int)q_theta q_hist:(int)q_hist NS_SWIFT_NAME(create(radius:q_radius:q_theta:q_hist:));

+ (DAISY*)create:(float)radius q_radius:(int)q_radius q_theta:(int)q_theta NS_SWIFT_NAME(create(radius:q_radius:q_theta:));

+ (DAISY*)create:(float)radius q_radius:(int)q_radius NS_SWIFT_NAME(create(radius:q_radius:));

+ (DAISY*)create:(float)radius NS_SWIFT_NAME(create(radius:));

+ (DAISY*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::DAISY::setRadius(float radius)
//
- (void)setRadius:(float)radius NS_SWIFT_NAME(setRadius(radius:));


//
//  float cv::xfeatures2d::DAISY::getRadius()
//
- (float)getRadius NS_SWIFT_NAME(getRadius());


//
//  void cv::xfeatures2d::DAISY::setQRadius(int q_radius)
//
- (void)setQRadius:(int)q_radius NS_SWIFT_NAME(setQRadius(q_radius:));


//
//  int cv::xfeatures2d::DAISY::getQRadius()
//
- (int)getQRadius NS_SWIFT_NAME(getQRadius());


//
//  void cv::xfeatures2d::DAISY::setQTheta(int q_theta)
//
- (void)setQTheta:(int)q_theta NS_SWIFT_NAME(setQTheta(q_theta:));


//
//  int cv::xfeatures2d::DAISY::getQTheta()
//
- (int)getQTheta NS_SWIFT_NAME(getQTheta());


//
//  void cv::xfeatures2d::DAISY::setQHist(int q_hist)
//
- (void)setQHist:(int)q_hist NS_SWIFT_NAME(setQHist(q_hist:));


//
//  int cv::xfeatures2d::DAISY::getQHist()
//
- (int)getQHist NS_SWIFT_NAME(getQHist());


//
//  void cv::xfeatures2d::DAISY::setNorm(int norm)
//
- (void)setNorm:(int)norm NS_SWIFT_NAME(setNorm(norm:));


//
//  int cv::xfeatures2d::DAISY::getNorm()
//
- (int)getNorm NS_SWIFT_NAME(getNorm());


//
//  void cv::xfeatures2d::DAISY::setH(Mat H)
//
- (void)setH:(Mat*)H NS_SWIFT_NAME(setH(H:));


//
//  Mat cv::xfeatures2d::DAISY::getH()
//
- (Mat*)getH NS_SWIFT_NAME(getH());


//
//  void cv::xfeatures2d::DAISY::setInterpolation(bool interpolation)
//
- (void)setInterpolation:(BOOL)interpolation NS_SWIFT_NAME(setInterpolation(interpolation:));


//
//  bool cv::xfeatures2d::DAISY::getInterpolation()
//
- (BOOL)getInterpolation NS_SWIFT_NAME(getInterpolation());


//
//  void cv::xfeatures2d::DAISY::setUseOrientation(bool use_orientation)
//
- (void)setUseOrientation:(BOOL)use_orientation NS_SWIFT_NAME(setUseOrientation(use_orientation:));


//
//  bool cv::xfeatures2d::DAISY::getUseOrientation()
//
- (BOOL)getUseOrientation NS_SWIFT_NAME(getUseOrientation());


//
//  String cv::xfeatures2d::DAISY::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


