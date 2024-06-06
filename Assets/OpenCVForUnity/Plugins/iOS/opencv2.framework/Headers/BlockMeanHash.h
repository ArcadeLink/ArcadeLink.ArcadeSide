//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/block_mean_hash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "ImgHashBase.h"

#import "Img_hash.h"
@class DoubleVector;



NS_ASSUME_NONNULL_BEGIN

// C++: class BlockMeanHash
/**
 * Image hash based on block mean.
 *
 * See CITE: zauner2010implementation for details.
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface BlockMeanHash : ImgHashBase


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::BlockMeanHash> nativePtrBlockMeanHash;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::BlockMeanHash>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::BlockMeanHash>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::img_hash::BlockMeanHash::setMode(BlockMeanHashMode mode)
//
/**
 * Create BlockMeanHash object
 * @param mode the mode
 */
- (void)setMode:(BlockMeanHashMode)mode NS_SWIFT_NAME(setMode(mode:));


//
//  vector_double cv::img_hash::BlockMeanHash::getMean()
//
- (DoubleVector*)getMean NS_SWIFT_NAME(getMean());


//
// static Ptr_BlockMeanHash cv::img_hash::BlockMeanHash::create(BlockMeanHashMode mode = BLOCK_MEAN_HASH_MODE_0)
//
+ (BlockMeanHash*)create:(BlockMeanHashMode)mode NS_SWIFT_NAME(create(mode:));

+ (BlockMeanHash*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


