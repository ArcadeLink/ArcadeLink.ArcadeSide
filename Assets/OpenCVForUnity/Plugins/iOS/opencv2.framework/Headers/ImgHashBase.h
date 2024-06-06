//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/img_hash_base.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class ImgHashBase
/**
 * The base class for image hash algorithms
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface ImgHashBase : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::ImgHashBase> nativePtrImgHashBase;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::ImgHashBase>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::ImgHashBase>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::img_hash::ImgHashBase::compute(Mat inputArr, Mat& outputArr)
//
/**
 * Computes hash of the input image
 * @param inputArr input image want to compute hash value
 * @param outputArr hash of the image
 */
- (void)compute:(Mat*)inputArr outputArr:(Mat*)outputArr NS_SWIFT_NAME(compute(inputArr:outputArr:));


//
//  double cv::img_hash::ImgHashBase::compare(Mat hashOne, Mat hashTwo)
//
/**
 * Compare the hash value between inOne and inTwo
 * @param hashOne Hash value one
 * @param hashTwo Hash value two
 *         @return value indicate similarity between inOne and inTwo, the meaning
 *         of the value vary from algorithms to algorithms
 */
- (double)compare:(Mat*)hashOne hashTwo:(Mat*)hashTwo NS_SWIFT_NAME(compare(hashOne:hashTwo:));



@end

NS_ASSUME_NONNULL_END


