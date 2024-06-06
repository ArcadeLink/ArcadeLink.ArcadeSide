//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/structured_light.hpp"
#import "opencv2/structured_light/structured_light.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class StructuredLightPattern
/**
 * Abstract base class for generating and decoding structured light patterns.
 *
 * Member of `Structured_light`
 */
CV_EXPORTS @interface StructuredLightPattern : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::structured_light::StructuredLightPattern> nativePtrStructuredLightPattern;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::structured_light::StructuredLightPattern>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::structured_light::StructuredLightPattern>)nativePtr;
#endif


#pragma mark - Methods


//
//  bool cv::structured_light::StructuredLightPattern::generate(vector_Mat& patternImages)
//
/**
 * Generates the structured light pattern to project.
 *
 * @param patternImages The generated pattern: a vector<Mat>, in which each image is a CV_8U Mat at projector's resolution.
 */
- (BOOL)generate:(NSMutableArray<Mat*>*)patternImages NS_SWIFT_NAME(generate(patternImages:));


//
//  bool cv::structured_light::StructuredLightPattern::decode(vector_vector_Mat patternImages, Mat& disparityMap, vector_Mat blackImages = vector_Mat(), vector_Mat whiteImages = vector_Mat(), int flags = DECODE_3D_UNDERWORLD)
//
/**
 * Decodes the structured light pattern, generating a disparity map
 *
 * @param patternImages The acquired pattern images to decode (vector<vector<Mat>>), loaded as grayscale and previously rectified.
 * @param disparityMap The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
 * @param blackImages The all-black images needed for shadowMasks computation.
 * @param whiteImages The all-white images needed for shadowMasks computation.
 * @param flags Flags setting decoding algorithms. Default: DECODE_3D_UNDERWORLD.
 *    NOTE: All the images must be at the same resolution.
 */
- (BOOL)decode:(NSArray<NSArray<Mat*>*>*)patternImages disparityMap:(Mat*)disparityMap blackImages:(NSArray<Mat*>*)blackImages whiteImages:(NSArray<Mat*>*)whiteImages flags:(int)flags NS_SWIFT_NAME(decode(patternImages:disparityMap:blackImages:whiteImages:flags:));

/**
 * Decodes the structured light pattern, generating a disparity map
 *
 * @param patternImages The acquired pattern images to decode (vector<vector<Mat>>), loaded as grayscale and previously rectified.
 * @param disparityMap The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
 * @param blackImages The all-black images needed for shadowMasks computation.
 * @param whiteImages The all-white images needed for shadowMasks computation.
 *    NOTE: All the images must be at the same resolution.
 */
- (BOOL)decode:(NSArray<NSArray<Mat*>*>*)patternImages disparityMap:(Mat*)disparityMap blackImages:(NSArray<Mat*>*)blackImages whiteImages:(NSArray<Mat*>*)whiteImages NS_SWIFT_NAME(decode(patternImages:disparityMap:blackImages:whiteImages:));

/**
 * Decodes the structured light pattern, generating a disparity map
 *
 * @param patternImages The acquired pattern images to decode (vector<vector<Mat>>), loaded as grayscale and previously rectified.
 * @param disparityMap The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
 * @param blackImages The all-black images needed for shadowMasks computation.
 *    NOTE: All the images must be at the same resolution.
 */
- (BOOL)decode:(NSArray<NSArray<Mat*>*>*)patternImages disparityMap:(Mat*)disparityMap blackImages:(NSArray<Mat*>*)blackImages NS_SWIFT_NAME(decode(patternImages:disparityMap:blackImages:));

/**
 * Decodes the structured light pattern, generating a disparity map
 *
 * @param patternImages The acquired pattern images to decode (vector<vector<Mat>>), loaded as grayscale and previously rectified.
 * @param disparityMap The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
 *    NOTE: All the images must be at the same resolution.
 */
- (BOOL)decode:(NSArray<NSArray<Mat*>*>*)patternImages disparityMap:(Mat*)disparityMap NS_SWIFT_NAME(decode(patternImages:disparityMap:));



@end

NS_ASSUME_NONNULL_END


