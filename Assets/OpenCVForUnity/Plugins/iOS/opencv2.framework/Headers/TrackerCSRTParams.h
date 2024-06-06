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
CV_EXPORTS @interface TrackerCSRTParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::TrackerCSRT::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::TrackerCSRT::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::TrackerCSRT::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::TrackerCSRT::Params::Params()
//
- (instancetype)init;


    //
    // C++: bool cv::TrackerCSRT::Params::use_hog
    //

@property BOOL use_hog;

    //
    // C++: bool cv::TrackerCSRT::Params::use_color_names
    //

@property BOOL use_color_names;

    //
    // C++: bool cv::TrackerCSRT::Params::use_gray
    //

@property BOOL use_gray;

    //
    // C++: bool cv::TrackerCSRT::Params::use_rgb
    //

@property BOOL use_rgb;

    //
    // C++: bool cv::TrackerCSRT::Params::use_channel_weights
    //

@property BOOL use_channel_weights;

    //
    // C++: bool cv::TrackerCSRT::Params::use_segmentation
    //

@property BOOL use_segmentation;

    //
    // C++: string cv::TrackerCSRT::Params::window_function
    //

@property NSString* window_function;

    //
    // C++: float cv::TrackerCSRT::Params::kaiser_alpha
    //

@property float kaiser_alpha;

    //
    // C++: float cv::TrackerCSRT::Params::cheb_attenuation
    //

@property float cheb_attenuation;

    //
    // C++: float cv::TrackerCSRT::Params::template_size
    //

@property float template_size;

    //
    // C++: float cv::TrackerCSRT::Params::gsl_sigma
    //

@property float gsl_sigma;

    //
    // C++: float cv::TrackerCSRT::Params::hog_orientations
    //

@property float hog_orientations;

    //
    // C++: float cv::TrackerCSRT::Params::hog_clip
    //

@property float hog_clip;

    //
    // C++: float cv::TrackerCSRT::Params::padding
    //

@property float padding;

    //
    // C++: float cv::TrackerCSRT::Params::filter_lr
    //

@property float filter_lr;

    //
    // C++: float cv::TrackerCSRT::Params::weights_lr
    //

@property float weights_lr;

    //
    // C++: int cv::TrackerCSRT::Params::num_hog_channels_used
    //

@property int num_hog_channels_used;

    //
    // C++: int cv::TrackerCSRT::Params::admm_iterations
    //

@property int admm_iterations;

    //
    // C++: int cv::TrackerCSRT::Params::histogram_bins
    //

@property int histogram_bins;

    //
    // C++: float cv::TrackerCSRT::Params::histogram_lr
    //

@property float histogram_lr;

    //
    // C++: int cv::TrackerCSRT::Params::background_ratio
    //

@property int background_ratio;

    //
    // C++: int cv::TrackerCSRT::Params::number_of_scales
    //

@property int number_of_scales;

    //
    // C++: float cv::TrackerCSRT::Params::scale_sigma_factor
    //

@property float scale_sigma_factor;

    //
    // C++: float cv::TrackerCSRT::Params::scale_model_max_area
    //

@property float scale_model_max_area;

    //
    // C++: float cv::TrackerCSRT::Params::scale_lr
    //

@property float scale_lr;

    //
    // C++: float cv::TrackerCSRT::Params::scale_step
    //

@property float scale_step;

    //
    // C++: float cv::TrackerCSRT::Params::psr_threshold
    //

@property float psr_threshold;


@end

NS_ASSUME_NONNULL_END


