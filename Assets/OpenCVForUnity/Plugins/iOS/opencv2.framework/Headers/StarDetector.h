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

// C++: class StarDetector
/**
 * The class implements the keypoint detector introduced by CITE: Agrawal08, synonym of StarDetector. :
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface StarDetector : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::StarDetector> nativePtrStarDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::StarDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::StarDetector>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_StarDetector cv::xfeatures2d::StarDetector::create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
//
+ (StarDetector*)create:(int)maxSize responseThreshold:(int)responseThreshold lineThresholdProjected:(int)lineThresholdProjected lineThresholdBinarized:(int)lineThresholdBinarized suppressNonmaxSize:(int)suppressNonmaxSize NS_SWIFT_NAME(create(maxSize:responseThreshold:lineThresholdProjected:lineThresholdBinarized:suppressNonmaxSize:));

+ (StarDetector*)create:(int)maxSize responseThreshold:(int)responseThreshold lineThresholdProjected:(int)lineThresholdProjected lineThresholdBinarized:(int)lineThresholdBinarized NS_SWIFT_NAME(create(maxSize:responseThreshold:lineThresholdProjected:lineThresholdBinarized:));

+ (StarDetector*)create:(int)maxSize responseThreshold:(int)responseThreshold lineThresholdProjected:(int)lineThresholdProjected NS_SWIFT_NAME(create(maxSize:responseThreshold:lineThresholdProjected:));

+ (StarDetector*)create:(int)maxSize responseThreshold:(int)responseThreshold NS_SWIFT_NAME(create(maxSize:responseThreshold:));

+ (StarDetector*)create:(int)maxSize NS_SWIFT_NAME(create(maxSize:));

+ (StarDetector*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::StarDetector::setMaxSize(int _maxSize)
//
- (void)setMaxSize:(int)_maxSize NS_SWIFT_NAME(setMaxSize(_maxSize:));


//
//  int cv::xfeatures2d::StarDetector::getMaxSize()
//
- (int)getMaxSize NS_SWIFT_NAME(getMaxSize());


//
//  void cv::xfeatures2d::StarDetector::setResponseThreshold(int _responseThreshold)
//
- (void)setResponseThreshold:(int)_responseThreshold NS_SWIFT_NAME(setResponseThreshold(_responseThreshold:));


//
//  int cv::xfeatures2d::StarDetector::getResponseThreshold()
//
- (int)getResponseThreshold NS_SWIFT_NAME(getResponseThreshold());


//
//  void cv::xfeatures2d::StarDetector::setLineThresholdProjected(int _lineThresholdProjected)
//
- (void)setLineThresholdProjected:(int)_lineThresholdProjected NS_SWIFT_NAME(setLineThresholdProjected(_lineThresholdProjected:));


//
//  int cv::xfeatures2d::StarDetector::getLineThresholdProjected()
//
- (int)getLineThresholdProjected NS_SWIFT_NAME(getLineThresholdProjected());


//
//  void cv::xfeatures2d::StarDetector::setLineThresholdBinarized(int _lineThresholdBinarized)
//
- (void)setLineThresholdBinarized:(int)_lineThresholdBinarized NS_SWIFT_NAME(setLineThresholdBinarized(_lineThresholdBinarized:));


//
//  int cv::xfeatures2d::StarDetector::getLineThresholdBinarized()
//
- (int)getLineThresholdBinarized NS_SWIFT_NAME(getLineThresholdBinarized());


//
//  void cv::xfeatures2d::StarDetector::setSuppressNonmaxSize(int _suppressNonmaxSize)
//
- (void)setSuppressNonmaxSize:(int)_suppressNonmaxSize NS_SWIFT_NAME(setSuppressNonmaxSize(_suppressNonmaxSize:));


//
//  int cv::xfeatures2d::StarDetector::getSuppressNonmaxSize()
//
- (int)getSuppressNonmaxSize NS_SWIFT_NAME(getSuppressNonmaxSize());


//
//  String cv::xfeatures2d::StarDetector::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


