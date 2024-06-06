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

// C++: class BriefDescriptorExtractor
/**
 * Class for computing BRIEF descriptors described in CITE: calon2010 .
 *
 * bytes legth of the descriptor in bytes, valid values are: 16, 32 (default) or 64 .
 * use_orientation sample patterns using keypoints orientation, disabled by default.
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface BriefDescriptorExtractor : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::BriefDescriptorExtractor> nativePtrBriefDescriptorExtractor;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::BriefDescriptorExtractor>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::BriefDescriptorExtractor>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
//
+ (BriefDescriptorExtractor*)create:(int)bytes use_orientation:(BOOL)use_orientation NS_SWIFT_NAME(create(bytes:use_orientation:));

+ (BriefDescriptorExtractor*)create:(int)bytes NS_SWIFT_NAME(create(bytes:));

+ (BriefDescriptorExtractor*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::BriefDescriptorExtractor::setDescriptorSize(int bytes)
//
- (void)setDescriptorSize:(int)bytes NS_SWIFT_NAME(setDescriptorSize(bytes:));


//
//  int cv::xfeatures2d::BriefDescriptorExtractor::getDescriptorSize()
//
- (int)getDescriptorSize NS_SWIFT_NAME(getDescriptorSize());


//
//  void cv::xfeatures2d::BriefDescriptorExtractor::setUseOrientation(bool use_orientation)
//
- (void)setUseOrientation:(BOOL)use_orientation NS_SWIFT_NAME(setUseOrientation(use_orientation:));


//
//  bool cv::xfeatures2d::BriefDescriptorExtractor::getUseOrientation()
//
- (BOOL)getUseOrientation NS_SWIFT_NAME(getUseOrientation());


//
//  String cv::xfeatures2d::BriefDescriptorExtractor::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


