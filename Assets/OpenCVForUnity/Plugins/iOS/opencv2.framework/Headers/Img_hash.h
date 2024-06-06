//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class Mat;


// C++: enum BlockMeanHashMode (cv.img_hash.BlockMeanHashMode)
typedef NS_ENUM(int, BlockMeanHashMode) {
    BLOCK_MEAN_HASH_MODE_0 = 0,
    BLOCK_MEAN_HASH_MODE_1 = 1
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Img_hash
/**
 * The Img_hash module
 *
 * Member classes: `AverageHash`, `ColorMomentHash`, `RadialVarianceHash`, `PHash`, `ImgHashBase`, `MarrHildrethHash`, `BlockMeanHash`
 *
 * Member enums: `BlockMeanHashMode`
 */
CV_EXPORTS @interface Img_hash : NSObject

#pragma mark - Methods


//
//  void cv::img_hash::averageHash(Mat inputArr, Mat& outputArr)
//
/**
 * Calculates img_hash::AverageHash in one call
 * @param inputArr input image want to compute hash value, type should be CV_8UC4, CV_8UC3 or CV_8UC1.
 * @param outputArr Hash value of input, it will contain 16 hex decimal number, return type is CV_8U
 */
+ (void)averageHash:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(averageHash(inputArr:outputArr:));


//
//  void cv::img_hash::colorMomentHash(Mat inputArr, Mat& outputArr)
//
/**
 * Computes color moment hash of the input, the algorithm
 *     is come from the paper "Perceptual  Hashing  for  Color  Images
 *     Using  Invariant Moments"
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3 or CV_8UC1.
 * @param outputArr 42 hash values with type CV_64F(double)
 */
+ (void)colorMomentHash:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(colorMomentHash(inputArr:outputArr:));


//
//  void cv::img_hash::radialVarianceHash(Mat inputArr, Mat& outputArr, double sigma = 1, int numOfAngleLine = 180)
//
/**
 * Computes radial variance hash of the input image
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input
 * @param sigma Gaussian kernel standard deviation
 * @param numOfAngleLine The number of angles to consider
 */
+ (void)radialVarianceHash:(Mat*)inputArr outputArr:(Mat*)outputArr sigma:(double)sigma numOfAngleLine:(int)numOfAngleLine NS_SWIFT_NAME(radialVarianceHash(inputArr:outputArr:sigma:numOfAngleLine:));

/**
 * Computes radial variance hash of the input image
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input
 * @param sigma Gaussian kernel standard deviation
 */
+ (void)radialVarianceHash:(Mat*)inputArr outputArr:(Mat*)outputArr sigma:(double)sigma NS_SWIFT_NAME(radialVarianceHash(inputArr:outputArr:sigma:));

/**
 * Computes radial variance hash of the input image
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input
 */
+ (void)radialVarianceHash:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(radialVarianceHash(inputArr:outputArr:));


//
//  void cv::img_hash::pHash(Mat inputArr, Mat& outputArr)
//
/**
 * Computes pHash value of the input image
 * @param inputArr input image want to compute hash value,
 *      type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input, it will contain 8 uchar value
 */
+ (void)pHash:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(pHash(inputArr:outputArr:));


//
//  void cv::img_hash::marrHildrethHash(Mat inputArr, Mat& outputArr, float alpha = 2.0f, float scale = 1.0f)
//
/**
 * Computes average hash value of the input image
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input, it will contain 16 hex
 *     decimal number, return type is CV_8U
 * @param alpha int scale factor for marr wavelet (default=2).
 * @param scale int level of scale factor (default = 1)
 */
+ (void)marrHildrethHash:(Mat*)inputArr outputArr:(Mat*)outputArr alpha:(float)alpha scale:(float)scale NS_SWIFT_NAME(marrHildrethHash(inputArr:outputArr:alpha:scale:));

/**
 * Computes average hash value of the input image
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input, it will contain 16 hex
 *     decimal number, return type is CV_8U
 * @param alpha int scale factor for marr wavelet (default=2).
 */
+ (void)marrHildrethHash:(Mat*)inputArr outputArr:(Mat*)outputArr alpha:(float)alpha NS_SWIFT_NAME(marrHildrethHash(inputArr:outputArr:alpha:));

/**
 * Computes average hash value of the input image
 * @param inputArr input image want to compute hash value,
 *     type should be CV_8UC4, CV_8UC3, CV_8UC1.
 * @param outputArr Hash value of input, it will contain 16 hex
 *     decimal number, return type is CV_8U
 */
+ (void)marrHildrethHash:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(marrHildrethHash(inputArr:outputArr:));


//
//  void cv::img_hash::blockMeanHash(Mat inputArr, Mat& outputArr, int mode = BLOCK_MEAN_HASH_MODE_0)
//
/**
 * Computes block mean hash of the input image
 * @param inputArr input image want to compute hash value, type should be CV_8UC4, CV_8UC3 or CV_8UC1.
 * @param outputArr Hash value of input, it will contain 16 hex decimal number, return type is CV_8U
 * @param mode the mode
 */
+ (void)blockMeanHash:(Mat*)inputArr outputArr:(Mat*)outputArr mode:(int)mode NS_SWIFT_NAME(blockMeanHash(inputArr:outputArr:mode:));

/**
 * Computes block mean hash of the input image
 * @param inputArr input image want to compute hash value, type should be CV_8UC4, CV_8UC3 or CV_8UC1.
 * @param outputArr Hash value of input, it will contain 16 hex decimal number, return type is CV_8U
 */
+ (void)blockMeanHash:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(blockMeanHash(inputArr:outputArr:));



@end

NS_ASSUME_NONNULL_END


