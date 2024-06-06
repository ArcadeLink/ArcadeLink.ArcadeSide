//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xphoto.hpp"
#import "opencv2/xphoto/white_balance.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "WhiteBalancer.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class SimpleWB
/**
 * A simple white balance algorithm that works by independently stretching
 *     each of the input image channels to the specified range. For increased robustness
 *     it ignores the top and bottom `$$p\%$$` of pixel values.
 *
 * Member of `Xphoto`
 */
CV_EXPORTS @interface SimpleWB : WhiteBalancer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xphoto::SimpleWB> nativePtrSimpleWB;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xphoto::SimpleWB>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xphoto::SimpleWB>)nativePtr;
#endif


#pragma mark - Methods


//
//  float cv::xphoto::SimpleWB::getInputMin()
//
/**
 * Input image range minimum value
 * @see `-setInputMin:`
 */
- (float)getInputMin NS_SWIFT_NAME(getInputMin());


//
//  void cv::xphoto::SimpleWB::setInputMin(float val)
//
/**
 *  getInputMin @see `-getInputMin:`
 */
- (void)setInputMin:(float)val NS_SWIFT_NAME(setInputMin(val:));


//
//  float cv::xphoto::SimpleWB::getInputMax()
//
/**
 * Input image range maximum value
 * @see `-setInputMax:`
 */
- (float)getInputMax NS_SWIFT_NAME(getInputMax());


//
//  void cv::xphoto::SimpleWB::setInputMax(float val)
//
/**
 *  getInputMax @see `-getInputMax:`
 */
- (void)setInputMax:(float)val NS_SWIFT_NAME(setInputMax(val:));


//
//  float cv::xphoto::SimpleWB::getOutputMin()
//
/**
 * Output image range minimum value
 * @see `-setOutputMin:`
 */
- (float)getOutputMin NS_SWIFT_NAME(getOutputMin());


//
//  void cv::xphoto::SimpleWB::setOutputMin(float val)
//
/**
 *  getOutputMin @see `-getOutputMin:`
 */
- (void)setOutputMin:(float)val NS_SWIFT_NAME(setOutputMin(val:));


//
//  float cv::xphoto::SimpleWB::getOutputMax()
//
/**
 * Output image range maximum value
 * @see `-setOutputMax:`
 */
- (float)getOutputMax NS_SWIFT_NAME(getOutputMax());


//
//  void cv::xphoto::SimpleWB::setOutputMax(float val)
//
/**
 *  getOutputMax @see `-getOutputMax:`
 */
- (void)setOutputMax:(float)val NS_SWIFT_NAME(setOutputMax(val:));


//
//  float cv::xphoto::SimpleWB::getP()
//
/**
 * Percent of top/bottom values to ignore
 * @see `-setP:`
 */
- (float)getP NS_SWIFT_NAME(getP());


//
//  void cv::xphoto::SimpleWB::setP(float val)
//
/**
 *  getP @see `-getP:`
 */
- (void)setP:(float)val NS_SWIFT_NAME(setP(val:));



@end

NS_ASSUME_NONNULL_END


