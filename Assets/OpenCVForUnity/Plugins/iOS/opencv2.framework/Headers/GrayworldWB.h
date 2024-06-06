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

// C++: class GrayworldWB
/**
 * Gray-world white balance algorithm
 *
 * This algorithm scales the values of pixels based on a
 * gray-world assumption which states that the average of all channels
 * should result in a gray image.
 *
 * It adds a modification which thresholds pixels based on their
 * saturation value and only uses pixels below the provided threshold in
 * finding average pixel values.
 *
 * Saturation is calculated using the following for a 3-channel RGB image per
 * pixel I and is in the range [0, 1]:
 *
 * `$$ \texttt{Saturation} [I] = \frac{\textrm{max}(R,G,B) - \textrm{min}(R,G,B)
 * }{\textrm{max}(R,G,B)} $$`
 *
 * A threshold of 1 means that all pixels are used to white-balance, while a
 * threshold of 0 means no pixels are used. Lower thresholds are useful in
 * white-balancing saturated images.
 *
 * Currently supports images of type REF: CV_8UC3 and REF: CV_16UC3.
 *
 * Member of `Xphoto`
 */
CV_EXPORTS @interface GrayworldWB : WhiteBalancer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xphoto::GrayworldWB> nativePtrGrayworldWB;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xphoto::GrayworldWB>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xphoto::GrayworldWB>)nativePtr;
#endif


#pragma mark - Methods


//
//  float cv::xphoto::GrayworldWB::getSaturationThreshold()
//
/**
 * Maximum saturation for a pixel to be included in the
 *         gray-world assumption
 * @see `-setSaturationThreshold:`
 */
- (float)getSaturationThreshold NS_SWIFT_NAME(getSaturationThreshold());


//
//  void cv::xphoto::GrayworldWB::setSaturationThreshold(float val)
//
/**
 *  getSaturationThreshold @see `-getSaturationThreshold:`
 */
- (void)setSaturationThreshold:(float)val NS_SWIFT_NAME(setSaturationThreshold(val:));



@end

NS_ASSUME_NONNULL_END


