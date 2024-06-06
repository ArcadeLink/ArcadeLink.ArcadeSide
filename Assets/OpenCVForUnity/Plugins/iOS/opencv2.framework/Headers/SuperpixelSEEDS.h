//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/seeds.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class SuperpixelSEEDS
/**
 * Class implementing the SEEDS (Superpixels Extracted via Energy-Driven Sampling) superpixels
 * algorithm described in CITE: VBRV14 .
 *
 * The algorithm uses an efficient hill-climbing algorithm to optimize the superpixels' energy
 * function that is based on color histograms and a boundary term, which is optional. The energy
 * function encourages superpixels to be of the same color, and if the boundary term is activated, the
 * superpixels have smooth boundaries and are of similar shape. In practice it starts from a regular
 * grid of superpixels and moves the pixels or blocks of pixels at the boundaries to refine the
 * solution. The algorithm runs in real-time using a single CPU.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SuperpixelSEEDS : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::SuperpixelSEEDS> nativePtrSuperpixelSEEDS;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::SuperpixelSEEDS>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::SuperpixelSEEDS>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::ximgproc::SuperpixelSEEDS::getNumberOfSuperpixels()
//
/**
 * Calculates the superpixel segmentation on a given image stored in SuperpixelSEEDS object.
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelSEEDS().
 */
- (int)getNumberOfSuperpixels NS_SWIFT_NAME(getNumberOfSuperpixels());


//
//  void cv::ximgproc::SuperpixelSEEDS::iterate(Mat img, int num_iterations = 4)
//
/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the SuperpixelSEEDS object.
 *
 *     This function can be called again for other images without the need of initializing the
 *     algorithm with createSuperpixelSEEDS(). This save the computational cost of allocating memory
 *     for all the structures of the algorithm.
 *
 * @param img Input image. Supported formats: CV_8U, CV_16U, CV_32F. Image size & number of
 *     channels must match with the initialized image size & channels with the function
 *     createSuperpixelSEEDS(). It should be in HSV or Lab color space. Lab is a bit better, but also
 *     slower.
 *
 * @param num_iterations Number of pixel level iterations. Higher number improves the result.
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelSEEDS(). The algorithms starts from a grid of superpixels and
 *     then refines the boundaries by proposing updates of blocks of pixels that lie at the boundaries
 *     from large to smaller size, finalizing with proposing pixel updates. An illustrative example
 *     can be seen below.
 *
 *     ![image](pics/superpixels_blocks2.png)
 */
- (void)iterate:(Mat*)img num_iterations:(int)num_iterations NS_SWIFT_NAME(iterate(img:num_iterations:));

/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the SuperpixelSEEDS object.
 *
 *     This function can be called again for other images without the need of initializing the
 *     algorithm with createSuperpixelSEEDS(). This save the computational cost of allocating memory
 *     for all the structures of the algorithm.
 *
 * @param img Input image. Supported formats: CV_8U, CV_16U, CV_32F. Image size & number of
 *     channels must match with the initialized image size & channels with the function
 *     createSuperpixelSEEDS(). It should be in HSV or Lab color space. Lab is a bit better, but also
 *     slower.
 *
 *
 *     The function computes the superpixels segmentation of an image with the parameters initialized
 *     with the function createSuperpixelSEEDS(). The algorithms starts from a grid of superpixels and
 *     then refines the boundaries by proposing updates of blocks of pixels that lie at the boundaries
 *     from large to smaller size, finalizing with proposing pixel updates. An illustrative example
 *     can be seen below.
 *
 *     ![image](pics/superpixels_blocks2.png)
 */
- (void)iterate:(Mat*)img NS_SWIFT_NAME(iterate(img:));


//
//  void cv::ximgproc::SuperpixelSEEDS::getLabels(Mat& labels_out)
//
/**
 * Returns the segmentation labeling of the image.
 *
 *     Each label represents a superpixel, and each pixel is assigned to one superpixel label.
 *
 * @param labels_out Return: A CV_32UC1 integer array containing the labels of the superpixel
 *     segmentation. The labels are in the range [0, getNumberOfSuperpixels()].
 *
 *     The function returns an image with ssthe labels of the superpixel segmentation. The labels are in
 *     the range [0, getNumberOfSuperpixels()].
 */
- (void)getLabels:(Mat*)labels_out NS_SWIFT_NAME(getLabels(labels_out:));


//
//  void cv::ximgproc::SuperpixelSEEDS::getLabelContourMask(Mat& image, bool thick_line = false)
//
/**
 * Returns the mask of the superpixel segmentation stored in SuperpixelSEEDS object.
 *
 * @param image Return: CV_8UC1 image mask where -1 indicates that the pixel is a superpixel border,
 *     and 0 otherwise.
 *
 * @param thick_line If false, the border is only one pixel wide, otherwise all pixels at the border
 *     are masked.
 *
 *     The function return the boundaries of the superpixel segmentation.
 *
 *     NOTE:
 *        -   (Python) A demo on how to generate superpixels in images from the webcam can be found at
 *             opencv_source_code/samples/python2/seeds.py
 *         -   (cpp) A demo on how to generate superpixels in images from the webcam can be found at
 *             opencv_source_code/modules/ximgproc/samples/seeds.cpp. By adding a file image as a command
 *             line argument, the static image will be used instead of the webcam.
 *         -   It will show a window with the video from the webcam with the superpixel boundaries marked
 *             in red (see below). Use Space to switch between different output modes. At the top of the
 *             window there are 4 sliders, from which the user can change on-the-fly the number of
 *             superpixels, the number of block levels, the strength of the boundary prior term to modify
 *             the shape, and the number of iterations at pixel level. This is useful to play with the
 *             parameters and set them to the user convenience. In the console the frame-rate of the
 *             algorithm is indicated.
 *
 *     ![image](pics/superpixels_demo.png)
 */
- (void)getLabelContourMask:(Mat*)image thick_line:(BOOL)thick_line NS_SWIFT_NAME(getLabelContourMask(image:thick_line:));

/**
 * Returns the mask of the superpixel segmentation stored in SuperpixelSEEDS object.
 *
 * @param image Return: CV_8UC1 image mask where -1 indicates that the pixel is a superpixel border,
 *     and 0 otherwise.
 *
 *     are masked.
 *
 *     The function return the boundaries of the superpixel segmentation.
 *
 *     NOTE:
 *        -   (Python) A demo on how to generate superpixels in images from the webcam can be found at
 *             opencv_source_code/samples/python2/seeds.py
 *         -   (cpp) A demo on how to generate superpixels in images from the webcam can be found at
 *             opencv_source_code/modules/ximgproc/samples/seeds.cpp. By adding a file image as a command
 *             line argument, the static image will be used instead of the webcam.
 *         -   It will show a window with the video from the webcam with the superpixel boundaries marked
 *             in red (see below). Use Space to switch between different output modes. At the top of the
 *             window there are 4 sliders, from which the user can change on-the-fly the number of
 *             superpixels, the number of block levels, the strength of the boundary prior term to modify
 *             the shape, and the number of iterations at pixel level. This is useful to play with the
 *             parameters and set them to the user convenience. In the console the frame-rate of the
 *             algorithm is indicated.
 *
 *     ![image](pics/superpixels_demo.png)
 */
- (void)getLabelContourMask:(Mat*)image NS_SWIFT_NAME(getLabelContourMask(image:));



@end

NS_ASSUME_NONNULL_END


