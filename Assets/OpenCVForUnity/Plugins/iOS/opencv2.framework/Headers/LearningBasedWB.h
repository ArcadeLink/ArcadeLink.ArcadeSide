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

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class LearningBasedWB
/**
 * More sophisticated learning-based automatic white balance algorithm.
 *
 * As REF: GrayworldWB, this algorithm works by applying different gains to the input
 * image channels, but their computation is a bit more involved compared to the
 * simple gray-world assumption. More details about the algorithm can be found in
 * CITE: Cheng2015 .
 *
 * To mask out saturated pixels this function uses only pixels that satisfy the
 * following condition:
 *
 * `$$ \frac{\textrm{max}(R,G,B)}{\texttt{range\_max\_val}} < \texttt{saturation\_thresh} $$`
 *
 * Currently supports images of type REF: CV_8UC3 and REF: CV_16UC3.
 *
 * Member of `Xphoto`
 */
CV_EXPORTS @interface LearningBasedWB : WhiteBalancer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xphoto::LearningBasedWB> nativePtrLearningBasedWB;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xphoto::LearningBasedWB>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xphoto::LearningBasedWB>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::xphoto::LearningBasedWB::extractSimpleFeatures(Mat src, Mat& dst)
//
/**
 * Implements the feature extraction part of the algorithm.
 *
 *     In accordance with CITE: Cheng2015 , computes the following features for the input image:
 *     1. Chromaticity of an average (R,G,B) tuple
 *     2. Chromaticity of the brightest (R,G,B) tuple (while ignoring saturated pixels)
 *     3. Chromaticity of the dominant (R,G,B) tuple (the one that has the highest value in the RGB histogram)
 *     4. Mode of the chromaticity palette, that is constructed by taking 300 most common colors according to
 *        the RGB histogram and projecting them on the chromaticity plane. Mode is the most high-density point
 *        of the palette, which is computed by a straightforward fixed-bandwidth kernel density estimator with
 *        a Epanechnikov kernel function.
 *
 * @param src Input three-channel image (BGR color space is assumed).
 * @param dst An array of four (r,g) chromaticity tuples corresponding to the features listed above.
 */
- (void)extractSimpleFeatures:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(extractSimpleFeatures(src:dst:));


//
//  int cv::xphoto::LearningBasedWB::getRangeMaxVal()
//
/**
 * Maximum possible value of the input image (e.g. 255 for 8 bit images,
 *                4095 for 12 bit images)
 * @see `-setRangeMaxVal:`
 */
- (int)getRangeMaxVal NS_SWIFT_NAME(getRangeMaxVal());


//
//  void cv::xphoto::LearningBasedWB::setRangeMaxVal(int val)
//
/**
 *  getRangeMaxVal @see `-getRangeMaxVal:`
 */
- (void)setRangeMaxVal:(int)val NS_SWIFT_NAME(setRangeMaxVal(val:));


//
//  float cv::xphoto::LearningBasedWB::getSaturationThreshold()
//
/**
 * Threshold that is used to determine saturated pixels, i.e. pixels where at least one of the
 *         channels exceeds `$$\texttt{saturation\_threshold}\times\texttt{range\_max\_val}$$` are ignored.
 * @see `-setSaturationThreshold:`
 */
- (float)getSaturationThreshold NS_SWIFT_NAME(getSaturationThreshold());


//
//  void cv::xphoto::LearningBasedWB::setSaturationThreshold(float val)
//
/**
 *  getSaturationThreshold @see `-getSaturationThreshold:`
 */
- (void)setSaturationThreshold:(float)val NS_SWIFT_NAME(setSaturationThreshold(val:));


//
//  int cv::xphoto::LearningBasedWB::getHistBinNum()
//
/**
 * Defines the size of one dimension of a three-dimensional RGB histogram that is used internally
 *         by the algorithm. It often makes sense to increase the number of bins for images with higher bit depth
 *         (e.g. 256 bins for a 12 bit image).
 * @see `-setHistBinNum:`
 */
- (int)getHistBinNum NS_SWIFT_NAME(getHistBinNum());


//
//  void cv::xphoto::LearningBasedWB::setHistBinNum(int val)
//
/**
 *  getHistBinNum @see `-getHistBinNum:`
 */
- (void)setHistBinNum:(int)val NS_SWIFT_NAME(setHistBinNum(val:));



@end

NS_ASSUME_NONNULL_END


