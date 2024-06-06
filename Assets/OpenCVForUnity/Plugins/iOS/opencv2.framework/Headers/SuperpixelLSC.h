//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/lsc.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class SuperpixelLSC
/**
 * Class implementing the LSC (Linear Spectral Clustering) superpixels
 * algorithm described in CITE: LiCVPR2015LSC.
 *
 * LSC (Linear Spectral Clustering) produces compact and uniform superpixels with low
 * computational costs. Basically, a normalized cuts formulation of the superpixel
 * segmentation is adopted based on a similarity metric that measures the color
 * similarity and space proximity between image pixels. LSC is of linear computational
 * complexity and high memory efficiency and is able to preserve global properties of images
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SuperpixelLSC : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::SuperpixelLSC> nativePtrSuperpixelLSC;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::SuperpixelLSC>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::SuperpixelLSC>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::ximgproc::SuperpixelLSC::getNumberOfSuperpixels()
//
/**
 * Calculates the actual amount of superpixels on a given segmentation computed
 *     and stored in SuperpixelLSC object.
 */
- (int)getNumberOfSuperpixels NS_SWIFT_NAME(getNumberOfSuperpixels());


//
//  void cv::ximgproc::SuperpixelLSC::iterate(int num_iterations = 10)
//
/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the SuperpixelLSC object.
 *
 *     This function can be called again without the need of initializing the algorithm with
 *     createSuperpixelLSC(). This save the computational cost of allocating memory for all the
 *     structures of the algorithm.
 *
 * @param num_iterations Number of iterations. Higher number improves the result.
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelLSC(). The algorithms starts from a grid of superpixels and
 *     then refines the boundaries by proposing updates of edges boundaries.
 */
- (void)iterate:(int)num_iterations NS_SWIFT_NAME(iterate(num_iterations:));

/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the SuperpixelLSC object.
 *
 *     This function can be called again without the need of initializing the algorithm with
 *     createSuperpixelLSC(). This save the computational cost of allocating memory for all the
 *     structures of the algorithm.
 *
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelLSC(). The algorithms starts from a grid of superpixels and
 *     then refines the boundaries by proposing updates of edges boundaries.
 */
- (void)iterate NS_SWIFT_NAME(iterate());


//
//  void cv::ximgproc::SuperpixelLSC::getLabels(Mat& labels_out)
//
/**
 * Returns the segmentation labeling of the image.
 *
 *     Each label represents a superpixel, and each pixel is assigned to one superpixel label.
 *
 * @param labels_out Return: A CV_32SC1 integer array containing the labels of the superpixel
 *     segmentation. The labels are in the range [0, getNumberOfSuperpixels()].
 *
 *     The function returns an image with the labels of the superpixel segmentation. The labels are in
 *     the range [0, getNumberOfSuperpixels()].
 */
- (void)getLabels:(Mat*)labels_out NS_SWIFT_NAME(getLabels(labels_out:));


//
//  void cv::ximgproc::SuperpixelLSC::getLabelContourMask(Mat& image, bool thick_line = true)
//
/**
 * Returns the mask of the superpixel segmentation stored in SuperpixelLSC object.
 *
 * @param image Return: CV_8U1 image mask where -1 indicates that the pixel is a superpixel border,
 *     and 0 otherwise.
 *
 * @param thick_line If false, the border is only one pixel wide, otherwise all pixels at the border
 *     are masked.
 *
 *     The function return the boundaries of the superpixel segmentation.
 */
- (void)getLabelContourMask:(Mat*)image thick_line:(BOOL)thick_line NS_SWIFT_NAME(getLabelContourMask(image:thick_line:));

/**
 * Returns the mask of the superpixel segmentation stored in SuperpixelLSC object.
 *
 * @param image Return: CV_8U1 image mask where -1 indicates that the pixel is a superpixel border,
 *     and 0 otherwise.
 *
 *     are masked.
 *
 *     The function return the boundaries of the superpixel segmentation.
 */
- (void)getLabelContourMask:(Mat*)image NS_SWIFT_NAME(getLabelContourMask(image:));


//
//  void cv::ximgproc::SuperpixelLSC::enforceLabelConnectivity(int min_element_size = 25)
//
/**
 * Enforce label connectivity.
 *
 * @param min_element_size The minimum element size in percents that should be absorbed into a bigger
 *     superpixel. Given resulted average superpixel size valid value should be in 0-100 range, 25 means
 *     that less then a quarter sized superpixel should be absorbed, this is default.
 *
 *     The function merge component that is too small, assigning the previously found adjacent label
 *     to this component. Calling this function may change the final number of superpixels.
 */
- (void)enforceLabelConnectivity:(int)min_element_size NS_SWIFT_NAME(enforceLabelConnectivity(min_element_size:));

/**
 * Enforce label connectivity.
 *
 *     superpixel. Given resulted average superpixel size valid value should be in 0-100 range, 25 means
 *     that less then a quarter sized superpixel should be absorbed, this is default.
 *
 *     The function merge component that is too small, assigning the previously found adjacent label
 *     to this component. Calling this function may change the final number of superpixels.
 */
- (void)enforceLabelConnectivity NS_SWIFT_NAME(enforceLabelConnectivity());



@end

NS_ASSUME_NONNULL_END


