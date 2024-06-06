//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/scansegment.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class ScanSegment
/**
 * Class implementing the F-DBSCAN (Accelerated superpixel image segmentation with a parallelized DBSCAN algorithm) superpixels
 * algorithm by Loke SC, et al. CITE: loke2021accelerated for original paper.
 *
 * The algorithm uses a parallelised DBSCAN cluster search that is resistant to noise, competitive in segmentation quality, and faster than
 * existing superpixel segmentation methods. When tested on the Berkeley Segmentation Dataset, the average processing speed is 175 frames/s
 * with a Boundary Recall of 0.797 and an Achievable Segmentation Accuracy of 0.944. The computational complexity is quadratic O(n2) and
 * more suited to smaller images, but can still process a 2MP colour image faster than the SEEDS algorithm in OpenCV. The output is deterministic
 * when the number of processing threads is fixed, and requires the source image to be in Lab colour format.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface ScanSegment : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::ScanSegment> nativePtrScanSegment;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::ScanSegment>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::ScanSegment>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::ximgproc::ScanSegment::getNumberOfSuperpixels()
//
/**
 * Returns the actual superpixel segmentation from the last image processed using iterate.
 *
 *     Returns zero if no image has been processed.
 */
- (int)getNumberOfSuperpixels NS_SWIFT_NAME(getNumberOfSuperpixels());


//
//  void cv::ximgproc::ScanSegment::iterate(Mat img)
//
/**
 * Calculates the superpixel segmentation on a given image with the initialized
 *     parameters in the ScanSegment object.
 *
 *     This function can be called again for other images without the need of initializing the algorithm with createScanSegment().
 *     This save the computational cost of allocating memory for all the structures of the algorithm.
 *
 * @param img Input image. Supported format: CV_8UC3. Image size must match with the initialized
 *     image size with the function createScanSegment(). It MUST be in Lab color space.
 */
- (void)iterate:(Mat*)img NS_SWIFT_NAME(iterate(img:));


//
//  void cv::ximgproc::ScanSegment::getLabels(Mat& labels_out)
//
/**
 * Returns the segmentation labeling of the image.
 *
 *     Each label represents a superpixel, and each pixel is assigned to one superpixel label.
 *
 * @param labels_out Return: A CV_32UC1 integer array containing the labels of the superpixel
 *     segmentation. The labels are in the range [0, getNumberOfSuperpixels()].
 */
- (void)getLabels:(Mat*)labels_out NS_SWIFT_NAME(getLabels(labels_out:));


//
//  void cv::ximgproc::ScanSegment::getLabelContourMask(Mat& image, bool thick_line = false)
//
/**
 * Returns the mask of the superpixel segmentation stored in the ScanSegment object.
 *
 *     The function return the boundaries of the superpixel segmentation.
 *
 * @param image Return: CV_8UC1 image mask where -1 indicates that the pixel is a superpixel border, and 0 otherwise.
 * @param thick_line If false, the border is only one pixel wide, otherwise all pixels at the border are masked.
 */
- (void)getLabelContourMask:(Mat*)image thick_line:(BOOL)thick_line NS_SWIFT_NAME(getLabelContourMask(image:thick_line:));

/**
 * Returns the mask of the superpixel segmentation stored in the ScanSegment object.
 *
 *     The function return the boundaries of the superpixel segmentation.
 *
 * @param image Return: CV_8UC1 image mask where -1 indicates that the pixel is a superpixel border, and 0 otherwise.
 */
- (void)getLabelContourMask:(Mat*)image NS_SWIFT_NAME(getLabelContourMask(image:));



@end

NS_ASSUME_NONNULL_END


