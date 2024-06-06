//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/structured_light.hpp"
#import "opencv2/structured_light/graycodepattern.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "StructuredLightPattern.h"

@class Mat;
@class Point2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class GrayCodePattern
/**
 * Class implementing the Gray-code pattern, based on CITE: UNDERWORLD.
 *
 * The generation of the pattern images is performed with Gray encoding using the traditional white and black colors.
 *
 * The information about the two image axes x, y is encoded separately into two different pattern sequences.
 * A projector P with resolution (P_res_x, P_res_y) will result in Ncols = log 2 (P_res_x) encoded pattern images representing the columns, and
 * in Nrows = log 2 (P_res_y) encoded pattern images representing the rows.
 * For example a projector with resolution 1024x768 will result in Ncols = 10 and Nrows = 10.
 *
 * However, the generated pattern sequence consists of both regular color and color-inverted images: inverted pattern images are images
 * with the same structure as the original but with inverted colors.
 * This provides an effective method for easily determining the intensity value of each pixel when it is lit (highest value) and
 * when it is not lit (lowest value). So for a a projector with resolution 1024x768, the number of pattern images will be Ncols * 2 + Nrows * 2 = 40.
 *
 *
 * Member of `Structured_light`
 */
CV_EXPORTS @interface GrayCodePattern : StructuredLightPattern


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::structured_light::GrayCodePattern> nativePtrGrayCodePattern;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::structured_light::GrayCodePattern>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::structured_light::GrayCodePattern>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_GrayCodePattern cv::structured_light::GrayCodePattern::create(int width, int height)
//
/**
 * Constructor
 */
+ (GrayCodePattern*)create:(int)width height:(int)height NS_SWIFT_NAME(create(width:height:));


//
//  size_t cv::structured_light::GrayCodePattern::getNumberOfPatternImages()
//
/**
 * Get the number of pattern images needed for the graycode pattern.
 *
 * @return The number of pattern images needed for the graycode pattern.
 *
 */
- (size_t)getNumberOfPatternImages NS_SWIFT_NAME(getNumberOfPatternImages());


//
//  void cv::structured_light::GrayCodePattern::setWhiteThreshold(size_t value)
//
/**
 * Sets the value for white threshold, needed for decoding.
 *
 * White threshold is a number between 0-255 that represents the minimum brightness difference required for valid pixels, between the graycode pattern and its inverse images; used in getProjPixel method.
 *
 * @param value The desired white threshold value.
 *
 */
- (void)setWhiteThreshold:(size_t)value NS_SWIFT_NAME(setWhiteThreshold(value:));


//
//  void cv::structured_light::GrayCodePattern::setBlackThreshold(size_t value)
//
/**
 * Sets the value for black threshold, needed for decoding (shadowsmasks computation).
 *
 * Black threshold is a number between 0-255 that represents the minimum brightness difference required for valid pixels, between the fully illuminated (white) and the not illuminated images (black); used in computeShadowMasks method.
 *
 * @param value The desired black threshold value.
 *
 */
- (void)setBlackThreshold:(size_t)value NS_SWIFT_NAME(setBlackThreshold(value:));


//
//  void cv::structured_light::GrayCodePattern::getImagesForShadowMasks(Mat& blackImage, Mat& whiteImage)
//
/**
 * Generates the all-black and all-white images needed for shadowMasks computation.
 *
 * To identify shadow regions, the regions of two images where the pixels are not lit by projector's light and thus where there is not coded information,
 * the 3DUNDERWORLD algorithm computes a shadow mask for the two cameras views, starting from a white and a black images captured by each camera.
 * This method generates these two additional images to project.
 *
 * @param blackImage The generated all-black CV_8U image, at projector's resolution.
 * @param whiteImage The generated all-white CV_8U image, at projector's resolution.
 */
- (void)getImagesForShadowMasks:(Mat*)blackImage whiteImage:(Mat*)whiteImage NS_SWIFT_NAME(getImagesForShadowMasks(blackImage:whiteImage:));


//
//  bool cv::structured_light::GrayCodePattern::getProjPixel(vector_Mat patternImages, int x, int y, Point& projPix)
//
/**
 * For a (x,y) pixel of a camera returns the corresponding projector pixel.
 *
 * The function decodes each pixel in the pattern images acquired by a camera into their corresponding decimal numbers representing the projector's column and row,
 * providing a mapping between camera's and projector's pixel.
 *
 * @param patternImages The pattern images acquired by the camera, stored in a grayscale vector < Mat >.
 * @param x x coordinate of the image pixel.
 * @param y y coordinate of the image pixel.
 * @param projPix Projector's pixel corresponding to the camera's pixel: projPix.x and projPix.y are the image coordinates of the projector's pixel corresponding to the pixel being decoded in a camera.
 */
- (BOOL)getProjPixel:(NSArray<Mat*>*)patternImages x:(int)x y:(int)y projPix:(Point2i*)projPix NS_SWIFT_NAME(getProjPixel(patternImages:x:y:projPix:));



@end

NS_ASSUME_NONNULL_END


