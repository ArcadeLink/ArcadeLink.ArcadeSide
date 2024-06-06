//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/slic.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class SuperpixelSLIC
/**
 * Class implementing the SLIC (Simple Linear Iterative Clustering) superpixels
 * algorithm described in CITE: Achanta2012.
 *
 * SLIC (Simple Linear Iterative Clustering) clusters pixels using pixel channels and image plane space
 * to efficiently generate compact, nearly uniform superpixels. The simplicity of approach makes it
 * extremely easy to use a lone parameter specifies the number of superpixels and the efficiency of
 * the algorithm makes it very practical.
 * Several optimizations are available for SLIC class:
 * SLICO stands for "Zero parameter SLIC" and it is an optimization of baseline SLIC described in CITE: Achanta2012.
 * MSLIC stands for "Manifold SLIC" and it is an optimization of baseline SLIC described in CITE: Liu_2017_IEEE.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SuperpixelSLIC : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::SuperpixelSLIC> nativePtrSuperpixelSLIC;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::SuperpixelSLIC>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::SuperpixelSLIC>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::ximgproc::SuperpixelSLIC::getNumberOfSuperpixels()
//
/**
 * Calculates the actual amount of superpixels on a given segmentation computed
 *     and stored in SuperpixelSLIC object.
 */
- (int)getNumberOfSuperpixels NS_SWIFT_NAME(getNumberOfSuperpixels());


//
//  void cv::ximgproc::SuperpixelSLIC::iterate(int num_iterations = 10)
//
/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the SuperpixelSLIC object.
 *
 *     This function can be called again without the need of initializing the algorithm with
 *     createSuperpixelSLIC(). This save the computational cost of allocating memory for all the
 *     structures of the algorithm.
 *
 * @param num_iterations Number of iterations. Higher number improves the result.
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelSLIC(). The algorithms starts from a grid of superpixels and
 *     then refines the boundaries by proposing updates of edges boundaries.
 */
- (void)iterate:(int)num_iterations NS_SWIFT_NAME(iterate(num_iterations:));

/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the SuperpixelSLIC object.
 *
 *     This function can be called again without the need of initializing the algorithm with
 *     createSuperpixelSLIC(). This save the computational cost of allocating memory for all the
 *     structures of the algorithm.
 *
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelSLIC(). The algorithms starts from a grid of superpixels and
 *     then refines the boundaries by proposing updates of edges boundaries.
 */
- (void)iterate NS_SWIFT_NAME(iterate());


//
//  void cv::ximgproc::SuperpixelSLIC::getLabels(Mat& labels_out)
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
//  void cv::ximgproc::SuperpixelSLIC::getLabelContourMask(Mat& image, bool thick_line = true)
//
/**
 * Returns the mask of the superpixel segmentation stored in SuperpixelSLIC object.
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
 * Returns the mask of the superpixel segmentation stored in SuperpixelSLIC object.
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
//  void cv::ximgproc::SuperpixelSLIC::enforceLabelConnectivity(int min_element_size = 25)
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


