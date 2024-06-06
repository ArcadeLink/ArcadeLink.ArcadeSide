//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/tracking.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * The Params module
 *
 * Member of `Tracking`
 */
CV_EXPORTS @interface TrackerKCFParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::TrackerKCF::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::TrackerKCF::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::TrackerKCF::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::TrackerKCF::Params::Params()
//
- (instancetype)init;


    //
    // C++: float cv::TrackerKCF::Params::detect_thresh
    //

@property float detect_thresh;

    //
    // C++: float cv::TrackerKCF::Params::sigma
    //

@property float sigma;

    //
    // C++: float cv::TrackerKCF::Params::lambda
    //

@property float lambda;

    //
    // C++: float cv::TrackerKCF::Params::interp_factor
    //

@property float interp_factor;

    //
    // C++: float cv::TrackerKCF::Params::output_sigma_factor
    //

@property float output_sigma_factor;

    //
    // C++: float cv::TrackerKCF::Params::pca_learning_rate
    //

@property float pca_learning_rate;

    //
    // C++: bool cv::TrackerKCF::Params::resize
    //

@property BOOL resize;

    //
    // C++: bool cv::TrackerKCF::Params::split_coeff
    //

@property BOOL split_coeff;

    //
    // C++: bool cv::TrackerKCF::Params::wrap_kernel
    //

@property BOOL wrap_kernel;

    //
    // C++: bool cv::TrackerKCF::Params::compress_feature
    //

@property BOOL compress_feature;

    //
    // C++: int cv::TrackerKCF::Params::max_patch_size
    //

@property int max_patch_size;

    //
    // C++: int cv::TrackerKCF::Params::compressed_size
    //

@property int compressed_size;

    //
    // C++: int cv::TrackerKCF::Params::desc_pca
    //

@property int desc_pca;

    //
    // C++: int cv::TrackerKCF::Params::desc_npca
    //

@property int desc_npca;


@end

NS_ASSUME_NONNULL_END


