//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class AdaptiveManifoldFilter;
@class ContourFitting;
@class DTFilter;
@class DisparityWLSFilter;
@class EdgeAwareInterpolator;
@class EdgeBoxes;
@class EdgeDrawing;
@class FastBilateralSolverFilter;
@class FastGlobalSmootherFilter;
@class FastLineDetector;
@class GraphSegmentation;
@class GuidedFilter;
@class Int4;
@class Mat;
@class Point2i;
@class RFFeatureGetter;
@class RICInterpolator;
@class Rect2i;
@class ScanSegment;
@class SelectiveSearchSegmentation;
@class SelectiveSearchSegmentationStrategy;
@class SelectiveSearchSegmentationStrategyColor;
@class SelectiveSearchSegmentationStrategyFill;
@class SelectiveSearchSegmentationStrategyMultiple;
@class SelectiveSearchSegmentationStrategySize;
@class SelectiveSearchSegmentationStrategyTexture;
@class StereoMatcher;
@class StructuredEdgeDetection;
@class SuperpixelLSC;
@class SuperpixelSEEDS;
@class SuperpixelSLIC;


// C++: enum AngleRangeOption (cv.ximgproc.AngleRangeOption)
typedef NS_ENUM(int, AngleRangeOption) {
    ARO_0_45 = 0,
    ARO_45_90 = 1,
    ARO_90_135 = 2,
    ARO_315_0 = 3,
    ARO_315_45 = 4,
    ARO_45_135 = 5,
    ARO_315_135 = 6,
    ARO_CTR_HOR = 7,
    ARO_CTR_VER = 8
};


// C++: enum EdgeAwareFiltersList (cv.ximgproc.EdgeAwareFiltersList)
typedef NS_ENUM(int, EdgeAwareFiltersList) {
    DTF_NC = 0,
    DTF_IC = 1,
    DTF_RF = 2,
    GUIDED_FILTER = 3,
    AM_FILTER = 4
};


// C++: enum HoughDeskewOption (cv.ximgproc.HoughDeskewOption)
typedef NS_ENUM(int, HoughDeskewOption) {
    HDO_RAW = 0,
    HDO_DESKEW = 1
};


// C++: enum HoughOp (cv.ximgproc.HoughOp)
typedef NS_ENUM(int, HoughOp) {
    FHT_MIN = 0,
    FHT_MAX = 1,
    FHT_ADD = 2,
    FHT_AVE = 3
};


// C++: enum LocalBinarizationMethods (cv.ximgproc.LocalBinarizationMethods)
typedef NS_ENUM(int, LocalBinarizationMethods) {
    BINARIZATION_NIBLACK = 0,
    BINARIZATION_SAUVOLA = 1,
    BINARIZATION_WOLF = 2,
    BINARIZATION_NICK = 3
};


// C++: enum SLICType (cv.ximgproc.SLICType)
typedef NS_ENUM(int, SLICType) {
    SLIC = 100,
    SLICO = 101,
    MSLIC = 102
};


// C++: enum ThinningTypes (cv.ximgproc.ThinningTypes)
typedef NS_ENUM(int, ThinningTypes) {
    THINNING_ZHANGSUEN = 0,
    THINNING_GUOHALL = 1
};


// C++: enum WMFWeightType (cv.ximgproc.WMFWeightType)
typedef NS_ENUM(int, WMFWeightType) {
    WMF_EXP = 1,
    WMF_IV1 = 1 << 1,
    WMF_IV2 = 1 << 2,
    WMF_COS = 1 << 3,
    WMF_JAC = 1 << 4,
    WMF_OFF = 1 << 5
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Ximgproc
/**
 * The Ximgproc module
 *
 * Member classes: `DisparityFilter`, `DisparityWLSFilter`, `ScanSegment`, `DTFilter`, `GuidedFilter`, `AdaptiveManifoldFilter`, `FastBilateralSolverFilter`, `FastGlobalSmootherFilter`, `SuperpixelSLIC`, `RFFeatureGetter`, `StructuredEdgeDetection`, `SuperpixelLSC`, `EdgeBoxes`, `GraphSegmentation`, `SelectiveSearchSegmentationStrategy`, `SelectiveSearchSegmentationStrategyColor`, `SelectiveSearchSegmentationStrategySize`, `SelectiveSearchSegmentationStrategyTexture`, `SelectiveSearchSegmentationStrategyFill`, `SelectiveSearchSegmentationStrategyMultiple`, `SelectiveSearchSegmentation`, `ContourFitting`, `SparseMatchInterpolator`, `EdgeAwareInterpolator`, `RICInterpolator`, `EdgeDrawing`, `EdgeDrawingParams`, `RidgeDetectionFilter`, `SuperpixelSEEDS`, `FastLineDetector`
 *
 * Member enums: `ThinningTypes`, `LocalBinarizationMethods`, `EdgeAwareFiltersList`, `SLICType`, `WMFWeightType`, `AngleRangeOption`, `HoughOp`, `HoughDeskewOption`, `GradientOperator`
 */
CV_EXPORTS @interface Ximgproc : NSObject

#pragma mark - Class Constants


@property (class, readonly) int RO_IGNORE_BORDERS NS_SWIFT_NAME(RO_IGNORE_BORDERS);
@property (class, readonly) int RO_STRICT NS_SWIFT_NAME(RO_STRICT);

#pragma mark - Methods


//
//  void cv::ximgproc::niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, LocalBinarizationMethods binarizationMethod = BINARIZATION_NIBLACK, double r = 128)
//
/**
 * Performs thresholding on input images using Niblack's technique or some of the
 * popular variations it inspired.
 *
 * The function transforms a grayscale image to a binary image according to the formulae:
 * -   **THRESH_BINARY**
 *     `$$\newcommand{\fork}[4]{ \left\{ \begin{array}{l l} #1 & \text{#2}\\\\ #3 & \text{#4}\\\\ \end{array} \right.} dst(x,y) =  \fork{\texttt{maxValue}}{if \(src(x,y) > T(x,y)\)}{0}{otherwise}$$`
 * -   **THRESH_BINARY_INV**
 *     `$$\newcommand{\fork}[4]{ \left\{ \begin{array}{l l} #1 & \text{#2}\\\\ #3 & \text{#4}\\\\ \end{array} \right.} dst(x,y) =  \fork{0}{if \(src(x,y) > T(x,y)\)}{\texttt{maxValue}}{otherwise}$$`
 * where `$$T(x,y)$$` is a threshold calculated individually for each pixel.
 *
 * The threshold value `$$T(x, y)$$` is determined based on the binarization method chosen. For
 * classic Niblack, it is the mean minus `$$ k $$` times standard deviation of
 * `$$\texttt{blockSize} \times\texttt{blockSize}$$` neighborhood of `$$(x, y)$$`.
 *
 * The function can't process the image in-place.
 *
 * @param _src Source 8-bit single-channel image.
 * @param _dst Destination image of the same size and the same type as src.
 * @param maxValue Non-zero value assigned to the pixels for which the condition is satisfied,
 * used with the THRESH_BINARY and THRESH_BINARY_INV thresholding types.
 * @param type Thresholding type, see cv::ThresholdTypes.
 * @param blockSize Size of a pixel neighborhood that is used to calculate a threshold value
 * for the pixel: 3, 5, 7, and so on.
 * @param k The user-adjustable parameter used by Niblack and inspired techniques. For Niblack, this is
 * normally a value between 0 and 1 that is multiplied with the standard deviation and subtracted from
 * the mean.
 * @param binarizationMethod Binarization method to use. By default, Niblack's technique is used.
 * Other techniques can be specified, see cv::ximgproc::LocalBinarizationMethods.
 * @param r The user-adjustable parameter used by Sauvola's technique. This is the dynamic range
 * of standard deviation.
 * @see `threshold`, `adaptiveThreshold`
 */
+ (void)niBlackThreshold:(Mat*)_src _dst:(Mat*)_dst maxValue:(double)maxValue type:(int)type blockSize:(int)blockSize k:(double)k binarizationMethod:(LocalBinarizationMethods)binarizationMethod r:(double)r NS_SWIFT_NAME(niBlackThreshold(_src:_dst:maxValue:type:blockSize:k:binarizationMethod:r:));

/**
 * Performs thresholding on input images using Niblack's technique or some of the
 * popular variations it inspired.
 *
 * The function transforms a grayscale image to a binary image according to the formulae:
 * -   **THRESH_BINARY**
 *     `$$\newcommand{\fork}[4]{ \left\{ \begin{array}{l l} #1 & \text{#2}\\\\ #3 & \text{#4}\\\\ \end{array} \right.} dst(x,y) =  \fork{\texttt{maxValue}}{if \(src(x,y) > T(x,y)\)}{0}{otherwise}$$`
 * -   **THRESH_BINARY_INV**
 *     `$$\newcommand{\fork}[4]{ \left\{ \begin{array}{l l} #1 & \text{#2}\\\\ #3 & \text{#4}\\\\ \end{array} \right.} dst(x,y) =  \fork{0}{if \(src(x,y) > T(x,y)\)}{\texttt{maxValue}}{otherwise}$$`
 * where `$$T(x,y)$$` is a threshold calculated individually for each pixel.
 *
 * The threshold value `$$T(x, y)$$` is determined based on the binarization method chosen. For
 * classic Niblack, it is the mean minus `$$ k $$` times standard deviation of
 * `$$\texttt{blockSize} \times\texttt{blockSize}$$` neighborhood of `$$(x, y)$$`.
 *
 * The function can't process the image in-place.
 *
 * @param _src Source 8-bit single-channel image.
 * @param _dst Destination image of the same size and the same type as src.
 * @param maxValue Non-zero value assigned to the pixels for which the condition is satisfied,
 * used with the THRESH_BINARY and THRESH_BINARY_INV thresholding types.
 * @param type Thresholding type, see cv::ThresholdTypes.
 * @param blockSize Size of a pixel neighborhood that is used to calculate a threshold value
 * for the pixel: 3, 5, 7, and so on.
 * @param k The user-adjustable parameter used by Niblack and inspired techniques. For Niblack, this is
 * normally a value between 0 and 1 that is multiplied with the standard deviation and subtracted from
 * the mean.
 * @param binarizationMethod Binarization method to use. By default, Niblack's technique is used.
 * Other techniques can be specified, see cv::ximgproc::LocalBinarizationMethods.
 * of standard deviation.
 * @see `threshold`, `adaptiveThreshold`
 */
+ (void)niBlackThreshold:(Mat*)_src _dst:(Mat*)_dst maxValue:(double)maxValue type:(int)type blockSize:(int)blockSize k:(double)k binarizationMethod:(LocalBinarizationMethods)binarizationMethod NS_SWIFT_NAME(niBlackThreshold(_src:_dst:maxValue:type:blockSize:k:binarizationMethod:));

/**
 * Performs thresholding on input images using Niblack's technique or some of the
 * popular variations it inspired.
 *
 * The function transforms a grayscale image to a binary image according to the formulae:
 * -   **THRESH_BINARY**
 *     `$$\newcommand{\fork}[4]{ \left\{ \begin{array}{l l} #1 & \text{#2}\\\\ #3 & \text{#4}\\\\ \end{array} \right.} dst(x,y) =  \fork{\texttt{maxValue}}{if \(src(x,y) > T(x,y)\)}{0}{otherwise}$$`
 * -   **THRESH_BINARY_INV**
 *     `$$\newcommand{\fork}[4]{ \left\{ \begin{array}{l l} #1 & \text{#2}\\\\ #3 & \text{#4}\\\\ \end{array} \right.} dst(x,y) =  \fork{0}{if \(src(x,y) > T(x,y)\)}{\texttt{maxValue}}{otherwise}$$`
 * where `$$T(x,y)$$` is a threshold calculated individually for each pixel.
 *
 * The threshold value `$$T(x, y)$$` is determined based on the binarization method chosen. For
 * classic Niblack, it is the mean minus `$$ k $$` times standard deviation of
 * `$$\texttt{blockSize} \times\texttt{blockSize}$$` neighborhood of `$$(x, y)$$`.
 *
 * The function can't process the image in-place.
 *
 * @param _src Source 8-bit single-channel image.
 * @param _dst Destination image of the same size and the same type as src.
 * @param maxValue Non-zero value assigned to the pixels for which the condition is satisfied,
 * used with the THRESH_BINARY and THRESH_BINARY_INV thresholding types.
 * @param type Thresholding type, see cv::ThresholdTypes.
 * @param blockSize Size of a pixel neighborhood that is used to calculate a threshold value
 * for the pixel: 3, 5, 7, and so on.
 * @param k The user-adjustable parameter used by Niblack and inspired techniques. For Niblack, this is
 * normally a value between 0 and 1 that is multiplied with the standard deviation and subtracted from
 * the mean.
 * Other techniques can be specified, see cv::ximgproc::LocalBinarizationMethods.
 * of standard deviation.
 * @see `threshold`, `adaptiveThreshold`
 */
+ (void)niBlackThreshold:(Mat*)_src _dst:(Mat*)_dst maxValue:(double)maxValue type:(int)type blockSize:(int)blockSize k:(double)k NS_SWIFT_NAME(niBlackThreshold(_src:_dst:maxValue:type:blockSize:k:));


//
//  void cv::ximgproc::thinning(Mat src, Mat& dst, ThinningTypes thinningType = THINNING_ZHANGSUEN)
//
/**
 * Applies a binary blob thinning operation, to achieve a skeletization of the input image.
 *
 * The function transforms a binary blob image into a skeletized form using the technique of Zhang-Suen.
 *
 * @param src Source 8-bit single-channel image, containing binary blobs, with blobs having 255 pixel values.
 * @param dst Destination image of the same size and the same type as src. The function can work in-place.
 * @param thinningType Value that defines which thinning algorithm should be used. See cv::ximgproc::ThinningTypes
 */
+ (void)thinning:(Mat*)src dst:(Mat*)dst thinningType:(ThinningTypes)thinningType NS_SWIFT_NAME(thinning(src:dst:thinningType:));

/**
 * Applies a binary blob thinning operation, to achieve a skeletization of the input image.
 *
 * The function transforms a binary blob image into a skeletized form using the technique of Zhang-Suen.
 *
 * @param src Source 8-bit single-channel image, containing binary blobs, with blobs having 255 pixel values.
 * @param dst Destination image of the same size and the same type as src. The function can work in-place.
 */
+ (void)thinning:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(thinning(src:dst:));


//
//  void cv::ximgproc::anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
//
/**
 * Performs anisotropic diffusion on an image.
 *
 *  The function applies Perona-Malik anisotropic diffusion to an image. This is the solution to the partial differential equation:
 *
 *  `$${\frac  {\partial I}{\partial t}}={\mathrm  {div}}\left(c(x,y,t)\nabla I\right)=\nabla c\cdot \nabla I+c(x,y,t)\Delta I$$`
 *
 *  Suggested functions for c(x,y,t) are:
 *
 *  `$$c\left(\|\nabla I\|\right)=e^{{-\left(\|\nabla I\|/K\right)^{2}}}$$`
 *
 *  or
 *
 *  `$$ c\left(\|\nabla I\|\right)={\frac {1}{1+\left({\frac  {\|\nabla I\|}{K}}\right)^{2}}} $$`
 *
 * @param src Source image with 3 channels.
 * @param dst Destination image of the same size and the same number of channels as src .
 * @param alpha The amount of time to step forward by on each iteration (normally, it's between 0 and 1).
 * @param K sensitivity to the edges
 * @param niters The number of iterations
 */
+ (void)anisotropicDiffusion:(Mat*)src dst:(Mat*)dst alpha:(float)alpha K:(float)K niters:(int)niters NS_SWIFT_NAME(anisotropicDiffusion(src:dst:alpha:K:niters:));


//
//  void cv::ximgproc::GradientDericheY(Mat op, Mat& dst, double alpha, double omega)
//
/**
 * Applies Y Deriche filter to an image.
 *
 * For more details about this implementation, please see http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.476.5736&rep=rep1&type=pdf
 *
 *
 */
+ (void)GradientDericheY:(Mat*)op dst:(Mat*)dst alpha:(double)alpha omega:(double)omega NS_SWIFT_NAME(GradientDericheY(op:dst:alpha:omega:));


//
//  void cv::ximgproc::GradientDericheX(Mat op, Mat& dst, double alpha, double omega)
//
/**
 * Applies X Deriche filter to an image.
 *
 * For more details about this implementation, please see http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.476.5736&rep=rep1&type=pdf
 *
 *
 */
+ (void)GradientDericheX:(Mat*)op dst:(Mat*)dst alpha:(double)alpha omega:(double)omega NS_SWIFT_NAME(GradientDericheX(op:dst:alpha:omega:));


//
//  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
//
/**
 * Convenience factory method that creates an instance of DisparityWLSFilter and sets up all the relevant
 * filter parameters automatically based on the matcher instance. Currently supports only StereoBM and StereoSGBM.
 *
 * @param matcher_left stereo matcher instance that will be used with the filter
 */
+ (DisparityWLSFilter*)createDisparityWLSFilter:(StereoMatcher*)matcher_left NS_SWIFT_NAME(createDisparityWLSFilter(matcher_left:));


//
//  Ptr_StereoMatcher cv::ximgproc::createRightMatcher(Ptr_StereoMatcher matcher_left)
//
/**
 * Convenience method to set up the matcher for computing the right-view disparity map
 * that is required in case of filtering with confidence.
 *
 * @param matcher_left main stereo matcher instance that will be used with the filter
 */
+ (StereoMatcher*)createRightMatcher:(StereoMatcher*)matcher_left NS_SWIFT_NAME(createRightMatcher(matcher_left:));


//
//  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilterGeneric(bool use_confidence)
//
/**
 * More generic factory method, create instance of DisparityWLSFilter and execute basic
 * initialization routines. When using this method you will need to set-up the ROI, matchers and
 * other parameters by yourself.
 *
 * @param use_confidence filtering with confidence requires two disparity maps (for the left and right views) and is
 * approximately two times slower. However, quality is typically significantly better.
 */
+ (DisparityWLSFilter*)createDisparityWLSFilterGeneric:(BOOL)use_confidence NS_SWIFT_NAME(createDisparityWLSFilterGeneric(use_confidence:));


//
//  int cv::ximgproc::readGT(String src_path, Mat& dst)
//
/**
 * Function for reading ground truth disparity maps. Supports basic Middlebury
 * and MPI-Sintel formats. Note that the resulting disparity map is scaled by 16.
 *
 * @param src_path path to the image, containing ground-truth disparity map
 *
 * @param dst output disparity map, CV_16S depth
 *
 * @result returns zero if successfully read the ground truth
 */
+ (int)readGT:(NSString*)src_path dst:(Mat*)dst NS_SWIFT_NAME(readGT(src_path:dst:));


//
//  double cv::ximgproc::computeMSE(Mat GT, Mat src, Rect ROI)
//
/**
 * Function for computing mean square error for disparity maps
 *
 * @param GT ground truth disparity map
 *
 * @param src disparity map to evaluate
 *
 * @param ROI region of interest
 *
 * @result returns mean square error between GT and src
 */
+ (double)computeMSE:(Mat*)GT src:(Mat*)src ROI:(Rect2i*)ROI NS_SWIFT_NAME(computeMSE(GT:src:ROI:));


//
//  double cv::ximgproc::computeBadPixelPercent(Mat GT, Mat src, Rect ROI, int thresh = 24)
//
/**
 * Function for computing the percent of "bad" pixels in the disparity map
 * (pixels where error is higher than a specified threshold)
 *
 * @param GT ground truth disparity map
 *
 * @param src disparity map to evaluate
 *
 * @param ROI region of interest
 *
 * @param thresh threshold used to determine "bad" pixels
 *
 * @result returns mean square error between GT and src
 */
+ (double)computeBadPixelPercent:(Mat*)GT src:(Mat*)src ROI:(Rect2i*)ROI thresh:(int)thresh NS_SWIFT_NAME(computeBadPixelPercent(GT:src:ROI:thresh:));

/**
 * Function for computing the percent of "bad" pixels in the disparity map
 * (pixels where error is higher than a specified threshold)
 *
 * @param GT ground truth disparity map
 *
 * @param src disparity map to evaluate
 *
 * @param ROI region of interest
 *
 *
 * @result returns mean square error between GT and src
 */
+ (double)computeBadPixelPercent:(Mat*)GT src:(Mat*)src ROI:(Rect2i*)ROI NS_SWIFT_NAME(computeBadPixelPercent(GT:src:ROI:));


//
//  void cv::ximgproc::getDisparityVis(Mat src, Mat& dst, double scale = 1.0)
//
/**
 * Function for creating a disparity map visualization (clamped CV_8U image)
 *
 * @param src input disparity map (CV_16S depth)
 *
 * @param dst output visualization
 *
 * @param scale disparity map will be multiplied by this value for visualization
 */
+ (void)getDisparityVis:(Mat*)src dst:(Mat*)dst scale:(double)scale NS_SWIFT_NAME(getDisparityVis(src:dst:scale:));

/**
 * Function for creating a disparity map visualization (clamped CV_8U image)
 *
 * @param src input disparity map (CV_16S depth)
 *
 * @param dst output visualization
 *
 */
+ (void)getDisparityVis:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(getDisparityVis(src:dst:));


//
//  void cv::ximgproc::edgePreservingFilter(Mat src, Mat& dst, int d, double threshold)
//
/**
 * Smoothes an image using the Edge-Preserving filter.
 *
 * The function smoothes Gaussian noise as well as salt & pepper noise.
 * For more details about this implementation, please see
 * [ReiWoe18]  Reich, S. and Wörgötter, F. and Dellen, B. (2018). A Real-Time Edge-Preserving Denoising Filter. Proceedings of the 13th International Joint Conference on Computer Vision, Imaging and Computer Graphics Theory and Applications (VISIGRAPP): Visapp, 85-94, 4. DOI: 10.5220/0006509000850094.
 *
 * @param src Source 8-bit 3-channel image.
 * @param dst Destination image of the same size and type as src.
 * @param d Diameter of each pixel neighborhood that is used during filtering. Must be greater or equal 3.
 * @param threshold Threshold, which distinguishes between noise, outliers, and data.
 */
+ (void)edgePreservingFilter:(Mat*)src dst:(Mat*)dst d:(int)d threshold:(double)threshold NS_SWIFT_NAME(edgePreservingFilter(src:dst:d:threshold:));


//
//  Ptr_ScanSegment cv::ximgproc::createScanSegment(int image_width, int image_height, int num_superpixels, int slices = 8, bool merge_small = true)
//
/**
 * Initializes a ScanSegment object.
 *
 * The function initializes a ScanSegment object for the input image. It stores the parameters of
 * the image: image_width and image_height. It also sets the parameters of the F-DBSCAN superpixel
 * algorithm, which are: num_superpixels, threads, and merge_small.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size). Use getNumberOfSuperpixels() to
 * get the actual number.
 * @param slices Number of processing threads for parallelisation. Setting -1 uses the maximum number
 * of threads. In practice, four threads is enough for smaller images and eight threads for larger ones.
 * @param merge_small merge small segments to give the desired number of superpixels. Processing is
 * much faster without merging, but many small segments will be left in the image.
 */
+ (ScanSegment*)createScanSegment:(int)image_width image_height:(int)image_height num_superpixels:(int)num_superpixels slices:(int)slices merge_small:(BOOL)merge_small NS_SWIFT_NAME(createScanSegment(image_width:image_height:num_superpixels:slices:merge_small:));

/**
 * Initializes a ScanSegment object.
 *
 * The function initializes a ScanSegment object for the input image. It stores the parameters of
 * the image: image_width and image_height. It also sets the parameters of the F-DBSCAN superpixel
 * algorithm, which are: num_superpixels, threads, and merge_small.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size). Use getNumberOfSuperpixels() to
 * get the actual number.
 * @param slices Number of processing threads for parallelisation. Setting -1 uses the maximum number
 * of threads. In practice, four threads is enough for smaller images and eight threads for larger ones.
 * much faster without merging, but many small segments will be left in the image.
 */
+ (ScanSegment*)createScanSegment:(int)image_width image_height:(int)image_height num_superpixels:(int)num_superpixels slices:(int)slices NS_SWIFT_NAME(createScanSegment(image_width:image_height:num_superpixels:slices:));

/**
 * Initializes a ScanSegment object.
 *
 * The function initializes a ScanSegment object for the input image. It stores the parameters of
 * the image: image_width and image_height. It also sets the parameters of the F-DBSCAN superpixel
 * algorithm, which are: num_superpixels, threads, and merge_small.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size). Use getNumberOfSuperpixels() to
 * get the actual number.
 * of threads. In practice, four threads is enough for smaller images and eight threads for larger ones.
 * much faster without merging, but many small segments will be left in the image.
 */
+ (ScanSegment*)createScanSegment:(int)image_width image_height:(int)image_height num_superpixels:(int)num_superpixels NS_SWIFT_NAME(createScanSegment(image_width:image_height:num_superpixels:));


//
//  Ptr_DTFilter cv::ximgproc::createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, EdgeAwareFiltersList mode = DTF_NC, int numIters = 3)
//
/**
 * Factory method, create instance of DTFilter and produce initialization routines.
 *
 * @param guide guided image (used to build transformed distance, which describes edge structure of
 * guided image).
 *
 * @param sigmaSpatial `$${\sigma}_H$$` parameter in the original article, it's similar to the sigma in the
 * coordinate space into bilateralFilter.
 *
 * @param sigmaColor `$${\sigma}_r$$` parameter in the original article, it's similar to the sigma in the
 * color space into bilateralFilter.
 *
 * @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
 * filtering 2D signals in the article.
 *
 * @param numIters optional number of iterations used for filtering, 3 is quite enough.
 *
 * For more details about Domain Transform filter parameters, see the original article CITE: Gastal11 and
 * [Domain Transform filter homepage](http://www.inf.ufrgs.br/~eslgastal/DomainTransform/).
 */
+ (DTFilter*)createDTFilter:(Mat*)guide sigmaSpatial:(double)sigmaSpatial sigmaColor:(double)sigmaColor mode:(EdgeAwareFiltersList)mode numIters:(int)numIters NS_SWIFT_NAME(createDTFilter(guide:sigmaSpatial:sigmaColor:mode:numIters:));

/**
 * Factory method, create instance of DTFilter and produce initialization routines.
 *
 * @param guide guided image (used to build transformed distance, which describes edge structure of
 * guided image).
 *
 * @param sigmaSpatial `$${\sigma}_H$$` parameter in the original article, it's similar to the sigma in the
 * coordinate space into bilateralFilter.
 *
 * @param sigmaColor `$${\sigma}_r$$` parameter in the original article, it's similar to the sigma in the
 * color space into bilateralFilter.
 *
 * @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
 * filtering 2D signals in the article.
 *
 *
 * For more details about Domain Transform filter parameters, see the original article CITE: Gastal11 and
 * [Domain Transform filter homepage](http://www.inf.ufrgs.br/~eslgastal/DomainTransform/).
 */
+ (DTFilter*)createDTFilter:(Mat*)guide sigmaSpatial:(double)sigmaSpatial sigmaColor:(double)sigmaColor mode:(EdgeAwareFiltersList)mode NS_SWIFT_NAME(createDTFilter(guide:sigmaSpatial:sigmaColor:mode:));

/**
 * Factory method, create instance of DTFilter and produce initialization routines.
 *
 * @param guide guided image (used to build transformed distance, which describes edge structure of
 * guided image).
 *
 * @param sigmaSpatial `$${\sigma}_H$$` parameter in the original article, it's similar to the sigma in the
 * coordinate space into bilateralFilter.
 *
 * @param sigmaColor `$${\sigma}_r$$` parameter in the original article, it's similar to the sigma in the
 * color space into bilateralFilter.
 *
 * filtering 2D signals in the article.
 *
 *
 * For more details about Domain Transform filter parameters, see the original article CITE: Gastal11 and
 * [Domain Transform filter homepage](http://www.inf.ufrgs.br/~eslgastal/DomainTransform/).
 */
+ (DTFilter*)createDTFilter:(Mat*)guide sigmaSpatial:(double)sigmaSpatial sigmaColor:(double)sigmaColor NS_SWIFT_NAME(createDTFilter(guide:sigmaSpatial:sigmaColor:));


//
//  void cv::ximgproc::dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, EdgeAwareFiltersList mode = DTF_NC, int numIters = 3)
//
/**
 * Simple one-line Domain Transform filter call. If you have multiple images to filter with the same
 * guided image then use DTFilter interface to avoid extra computations on initialization stage.
 *
 * @param guide guided image (also called as joint image) with unsigned 8-bit or floating-point 32-bit
 * depth and up to 4 channels.
 * @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
 * @param dst destination image
 * @param sigmaSpatial `$${\sigma}_H$$` parameter in the original article, it's similar to the sigma in the
 * coordinate space into bilateralFilter.
 * @param sigmaColor `$${\sigma}_r$$` parameter in the original article, it's similar to the sigma in the
 * color space into bilateralFilter.
 * @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
 * filtering 2D signals in the article.
 * @param numIters optional number of iterations used for filtering, 3 is quite enough.
 * @see `bilateralFilter`, `+guidedFilter:src:dst:radius:eps:dDepth:`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)dtFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst sigmaSpatial:(double)sigmaSpatial sigmaColor:(double)sigmaColor mode:(EdgeAwareFiltersList)mode numIters:(int)numIters NS_SWIFT_NAME(dtFilter(guide:src:dst:sigmaSpatial:sigmaColor:mode:numIters:));

/**
 * Simple one-line Domain Transform filter call. If you have multiple images to filter with the same
 * guided image then use DTFilter interface to avoid extra computations on initialization stage.
 *
 * @param guide guided image (also called as joint image) with unsigned 8-bit or floating-point 32-bit
 * depth and up to 4 channels.
 * @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
 * @param dst destination image
 * @param sigmaSpatial `$${\sigma}_H$$` parameter in the original article, it's similar to the sigma in the
 * coordinate space into bilateralFilter.
 * @param sigmaColor `$${\sigma}_r$$` parameter in the original article, it's similar to the sigma in the
 * color space into bilateralFilter.
 * @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
 * filtering 2D signals in the article.
 * @see `bilateralFilter`, `+guidedFilter:src:dst:radius:eps:dDepth:`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)dtFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst sigmaSpatial:(double)sigmaSpatial sigmaColor:(double)sigmaColor mode:(EdgeAwareFiltersList)mode NS_SWIFT_NAME(dtFilter(guide:src:dst:sigmaSpatial:sigmaColor:mode:));

/**
 * Simple one-line Domain Transform filter call. If you have multiple images to filter with the same
 * guided image then use DTFilter interface to avoid extra computations on initialization stage.
 *
 * @param guide guided image (also called as joint image) with unsigned 8-bit or floating-point 32-bit
 * depth and up to 4 channels.
 * @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
 * @param dst destination image
 * @param sigmaSpatial `$${\sigma}_H$$` parameter in the original article, it's similar to the sigma in the
 * coordinate space into bilateralFilter.
 * @param sigmaColor `$${\sigma}_r$$` parameter in the original article, it's similar to the sigma in the
 * color space into bilateralFilter.
 * filtering 2D signals in the article.
 * @see `bilateralFilter`, `+guidedFilter:src:dst:radius:eps:dDepth:`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)dtFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst sigmaSpatial:(double)sigmaSpatial sigmaColor:(double)sigmaColor NS_SWIFT_NAME(dtFilter(guide:src:dst:sigmaSpatial:sigmaColor:));


//
//  Ptr_GuidedFilter cv::ximgproc::createGuidedFilter(Mat guide, int radius, double eps)
//
/**
 * Factory method, create instance of GuidedFilter and produce initialization routines.
 *
 * @param guide guided image (or array of images) with up to 3 channels, if it have more then 3
 * channels then only first 3 channels will be used.
 *
 * @param radius radius of Guided Filter.
 *
 * @param eps regularization term of Guided Filter. `$${eps}^2$$` is similar to the sigma in the color
 * space into bilateralFilter.
 *
 * For more details about Guided Filter parameters, see the original article CITE: Kaiming10 .
 */
+ (GuidedFilter*)createGuidedFilter:(Mat*)guide radius:(int)radius eps:(double)eps NS_SWIFT_NAME(createGuidedFilter(guide:radius:eps:));


//
//  void cv::ximgproc::guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
//
/**
 * Simple one-line Guided Filter call.
 *
 * If you have multiple images to filter with the same guided image then use GuidedFilter interface to
 * avoid extra computations on initialization stage.
 *
 * @param guide guided image (or array of images) with up to 3 channels, if it have more then 3
 * channels then only first 3 channels will be used.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 * @param radius radius of Guided Filter.
 *
 * @param eps regularization term of Guided Filter. `$${eps}^2$$` is similar to the sigma in the color
 * space into bilateralFilter.
 *
 * @param dDepth optional depth of the output image.
 *
 * @see `bilateralFilter`, `+dtFilter:src:dst:sigmaSpatial:sigmaColor:mode:numIters:`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)guidedFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst radius:(int)radius eps:(double)eps dDepth:(int)dDepth NS_SWIFT_NAME(guidedFilter(guide:src:dst:radius:eps:dDepth:));

/**
 * Simple one-line Guided Filter call.
 *
 * If you have multiple images to filter with the same guided image then use GuidedFilter interface to
 * avoid extra computations on initialization stage.
 *
 * @param guide guided image (or array of images) with up to 3 channels, if it have more then 3
 * channels then only first 3 channels will be used.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 * @param radius radius of Guided Filter.
 *
 * @param eps regularization term of Guided Filter. `$${eps}^2$$` is similar to the sigma in the color
 * space into bilateralFilter.
 *
 *
 * @see `bilateralFilter`, `+dtFilter:src:dst:sigmaSpatial:sigmaColor:mode:numIters:`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)guidedFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst radius:(int)radius eps:(double)eps NS_SWIFT_NAME(guidedFilter(guide:src:dst:radius:eps:));


//
//  Ptr_AdaptiveManifoldFilter cv::ximgproc::createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
//
/**
 * Factory method, create instance of AdaptiveManifoldFilter and produce some initialization routines.
 *
 * @param sigma_s spatial standard deviation.
 *
 * @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
 * bilateralFilter.
 *
 * @param adjust_outliers optional, specify perform outliers adjust operation or not, (Eq. 9) in the
 * original paper.
 *
 * For more details about Adaptive Manifold Filter parameters, see the original article CITE: Gastal12 .
 *
 * NOTE: Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
 * color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
 * sigmas in bilateralFilter and dtFilter functions.
 */
+ (AdaptiveManifoldFilter*)createAMFilter:(double)sigma_s sigma_r:(double)sigma_r adjust_outliers:(BOOL)adjust_outliers NS_SWIFT_NAME(createAMFilter(sigma_s:sigma_r:adjust_outliers:));

/**
 * Factory method, create instance of AdaptiveManifoldFilter and produce some initialization routines.
 *
 * @param sigma_s spatial standard deviation.
 *
 * @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
 * bilateralFilter.
 *
 * original paper.
 *
 * For more details about Adaptive Manifold Filter parameters, see the original article CITE: Gastal12 .
 *
 * NOTE: Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
 * color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
 * sigmas in bilateralFilter and dtFilter functions.
 */
+ (AdaptiveManifoldFilter*)createAMFilter:(double)sigma_s sigma_r:(double)sigma_r NS_SWIFT_NAME(createAMFilter(sigma_s:sigma_r:));


//
//  void cv::ximgproc::amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
//
/**
 * Simple one-line Adaptive Manifold Filter call.
 *
 * @param joint joint (also called as guided) image or array of images with any numbers of channels.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 * @param sigma_s spatial standard deviation.
 *
 * @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
 * bilateralFilter.
 *
 * @param adjust_outliers optional, specify perform outliers adjust operation or not, (Eq. 9) in the
 * original paper.
 *
 * NOTE: Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
 * color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
 * sigmas in bilateralFilter and dtFilter functions. @see `bilateralFilter`, `+dtFilter:src:dst:sigmaSpatial:sigmaColor:mode:numIters:`, `+guidedFilter:src:dst:radius:eps:dDepth:`
 */
+ (void)amFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst sigma_s:(double)sigma_s sigma_r:(double)sigma_r adjust_outliers:(BOOL)adjust_outliers NS_SWIFT_NAME(amFilter(joint:src:dst:sigma_s:sigma_r:adjust_outliers:));

/**
 * Simple one-line Adaptive Manifold Filter call.
 *
 * @param joint joint (also called as guided) image or array of images with any numbers of channels.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 * @param sigma_s spatial standard deviation.
 *
 * @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
 * bilateralFilter.
 *
 * original paper.
 *
 * NOTE: Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
 * color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
 * sigmas in bilateralFilter and dtFilter functions. @see `bilateralFilter`, `+dtFilter:src:dst:sigmaSpatial:sigmaColor:mode:numIters:`, `+guidedFilter:src:dst:radius:eps:dDepth:`
 */
+ (void)amFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst sigma_s:(double)sigma_s sigma_r:(double)sigma_r NS_SWIFT_NAME(amFilter(joint:src:dst:sigma_s:sigma_r:));


//
//  void cv::ximgproc::jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
//
/**
 * Applies the joint bilateral filter to an image.
 *
 * @param joint Joint 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image with the same depth as joint
 * image.
 *
 * @param dst Destination image of the same size and type as src .
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 * @param borderType
 *
 * NOTE: bilateralFilter and jointBilateralFilter use L1 norm to compute difference between colors.
 *
 * @see `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)jointBilateralFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace borderType:(int)borderType NS_SWIFT_NAME(jointBilateralFilter(joint:src:dst:d:sigmaColor:sigmaSpace:borderType:));

/**
 * Applies the joint bilateral filter to an image.
 *
 * @param joint Joint 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image with the same depth as joint
 * image.
 *
 * @param dst Destination image of the same size and type as src .
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 *
 * NOTE: bilateralFilter and jointBilateralFilter use L1 norm to compute difference between colors.
 *
 * @see `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)jointBilateralFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace NS_SWIFT_NAME(jointBilateralFilter(joint:src:dst:d:sigmaColor:sigmaSpace:));


//
//  void cv::ximgproc::bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
//
/**
 * Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
 * For more details about this filter see CITE: Cho2014.
 *
 * @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param fr Radius of kernel to be used for filtering. It should be positive integer
 *
 * @param numIter Number of iterations of algorithm, It should be positive integer
 *
 * @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
 * a bigger value means sharper transition. When the value is negative, it is automatically calculated.
 *
 * @param sigmaAvg Range blur parameter for texture blurring. Larger value makes result to be more blurred. When the
 * value is negative, it is automatically calculated as described in the paper.
 *
 * @see `+rollingGuidanceFilter:dst:d:sigmaColor:sigmaSpace:numOfIter:borderType:`, `bilateralFilter`
 */
+ (void)bilateralTextureFilter:(Mat*)src dst:(Mat*)dst fr:(int)fr numIter:(int)numIter sigmaAlpha:(double)sigmaAlpha sigmaAvg:(double)sigmaAvg NS_SWIFT_NAME(bilateralTextureFilter(src:dst:fr:numIter:sigmaAlpha:sigmaAvg:));

/**
 * Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
 * For more details about this filter see CITE: Cho2014.
 *
 * @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param fr Radius of kernel to be used for filtering. It should be positive integer
 *
 * @param numIter Number of iterations of algorithm, It should be positive integer
 *
 * @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
 * a bigger value means sharper transition. When the value is negative, it is automatically calculated.
 *
 * value is negative, it is automatically calculated as described in the paper.
 *
 * @see `+rollingGuidanceFilter:dst:d:sigmaColor:sigmaSpace:numOfIter:borderType:`, `bilateralFilter`
 */
+ (void)bilateralTextureFilter:(Mat*)src dst:(Mat*)dst fr:(int)fr numIter:(int)numIter sigmaAlpha:(double)sigmaAlpha NS_SWIFT_NAME(bilateralTextureFilter(src:dst:fr:numIter:sigmaAlpha:));

/**
 * Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
 * For more details about this filter see CITE: Cho2014.
 *
 * @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param fr Radius of kernel to be used for filtering. It should be positive integer
 *
 * @param numIter Number of iterations of algorithm, It should be positive integer
 *
 * a bigger value means sharper transition. When the value is negative, it is automatically calculated.
 *
 * value is negative, it is automatically calculated as described in the paper.
 *
 * @see `+rollingGuidanceFilter:dst:d:sigmaColor:sigmaSpace:numOfIter:borderType:`, `bilateralFilter`
 */
+ (void)bilateralTextureFilter:(Mat*)src dst:(Mat*)dst fr:(int)fr numIter:(int)numIter NS_SWIFT_NAME(bilateralTextureFilter(src:dst:fr:numIter:));

/**
 * Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
 * For more details about this filter see CITE: Cho2014.
 *
 * @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param fr Radius of kernel to be used for filtering. It should be positive integer
 *
 *
 * a bigger value means sharper transition. When the value is negative, it is automatically calculated.
 *
 * value is negative, it is automatically calculated as described in the paper.
 *
 * @see `+rollingGuidanceFilter:dst:d:sigmaColor:sigmaSpace:numOfIter:borderType:`, `bilateralFilter`
 */
+ (void)bilateralTextureFilter:(Mat*)src dst:(Mat*)dst fr:(int)fr NS_SWIFT_NAME(bilateralTextureFilter(src:dst:fr:));

/**
 * Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
 * For more details about this filter see CITE: Cho2014.
 *
 * @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
 *
 * @param dst Destination image of the same size and type as src.
 *
 *
 *
 * a bigger value means sharper transition. When the value is negative, it is automatically calculated.
 *
 * value is negative, it is automatically calculated as described in the paper.
 *
 * @see `+rollingGuidanceFilter:dst:d:sigmaColor:sigmaSpace:numOfIter:borderType:`, `bilateralFilter`
 */
+ (void)bilateralTextureFilter:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(bilateralTextureFilter(src:dst:));


//
//  void cv::ximgproc::rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
//
/**
 * Applies the rolling guidance filter to an image.
 *
 * For more details, please see CITE: zhang2014rolling
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 * @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
 *
 * @param borderType
 *
 * NOTE:  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
 *
 * @see `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`, `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)rollingGuidanceFilter:(Mat*)src dst:(Mat*)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace numOfIter:(int)numOfIter borderType:(int)borderType NS_SWIFT_NAME(rollingGuidanceFilter(src:dst:d:sigmaColor:sigmaSpace:numOfIter:borderType:));

/**
 * Applies the rolling guidance filter to an image.
 *
 * For more details, please see CITE: zhang2014rolling
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 * @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
 *
 *
 * NOTE:  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
 *
 * @see `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`, `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)rollingGuidanceFilter:(Mat*)src dst:(Mat*)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace numOfIter:(int)numOfIter NS_SWIFT_NAME(rollingGuidanceFilter(src:dst:d:sigmaColor:sigmaSpace:numOfIter:));

/**
 * Applies the rolling guidance filter to an image.
 *
 * For more details, please see CITE: zhang2014rolling
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 *
 *
 * NOTE:  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
 *
 * @see `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`, `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)rollingGuidanceFilter:(Mat*)src dst:(Mat*)dst d:(int)d sigmaColor:(double)sigmaColor sigmaSpace:(double)sigmaSpace NS_SWIFT_NAME(rollingGuidanceFilter(src:dst:d:sigmaColor:sigmaSpace:));

/**
 * Applies the rolling guidance filter to an image.
 *
 * For more details, please see CITE: zhang2014rolling
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 *
 *
 * NOTE:  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
 *
 * @see `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`, `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)rollingGuidanceFilter:(Mat*)src dst:(Mat*)dst d:(int)d sigmaColor:(double)sigmaColor NS_SWIFT_NAME(rollingGuidanceFilter(src:dst:d:sigmaColor:));

/**
 * Applies the rolling guidance filter to an image.
 *
 * For more details, please see CITE: zhang2014rolling
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param dst Destination image of the same size and type as src.
 *
 * @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
 * it is computed from sigmaSpace .
 *
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 *
 *
 * NOTE:  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
 *
 * @see `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`, `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)rollingGuidanceFilter:(Mat*)src dst:(Mat*)dst d:(int)d NS_SWIFT_NAME(rollingGuidanceFilter(src:dst:d:));

/**
 * Applies the rolling guidance filter to an image.
 *
 * For more details, please see CITE: zhang2014rolling
 *
 * @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
 *
 * @param dst Destination image of the same size and type as src.
 *
 * it is computed from sigmaSpace .
 *
 * farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
 * larger areas of semi-equal color.
 *
 * farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
 * When d\>0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
 * proportional to sigmaSpace .
 *
 *
 *
 * NOTE:  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
 *
 * @see `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`, `bilateralFilter`, `+amFilter:src:dst:sigma_s:sigma_r:adjust_outliers:`
 */
+ (void)rollingGuidanceFilter:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(rollingGuidanceFilter(src:dst:));


//
//  Ptr_FastBilateralSolverFilter cv::ximgproc::createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
//
/**
 * Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 * @param lambda smoothness strength parameter for solver.
 *
 * @param num_iter number of iterations used for solver, 25 is usually enough.
 *
 * @param max_tol convergence tolerance used for solver.
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 */
+ (FastBilateralSolverFilter*)createFastBilateralSolverFilter:(Mat*)guide sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma lambda:(double)lambda num_iter:(int)num_iter max_tol:(double)max_tol NS_SWIFT_NAME(createFastBilateralSolverFilter(guide:sigma_spatial:sigma_luma:sigma_chroma:lambda:num_iter:max_tol:));

/**
 * Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 * @param lambda smoothness strength parameter for solver.
 *
 * @param num_iter number of iterations used for solver, 25 is usually enough.
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 */
+ (FastBilateralSolverFilter*)createFastBilateralSolverFilter:(Mat*)guide sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma lambda:(double)lambda num_iter:(int)num_iter NS_SWIFT_NAME(createFastBilateralSolverFilter(guide:sigma_spatial:sigma_luma:sigma_chroma:lambda:num_iter:));

/**
 * Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 * @param lambda smoothness strength parameter for solver.
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 */
+ (FastBilateralSolverFilter*)createFastBilateralSolverFilter:(Mat*)guide sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma lambda:(double)lambda NS_SWIFT_NAME(createFastBilateralSolverFilter(guide:sigma_spatial:sigma_luma:sigma_chroma:lambda:));

/**
 * Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 */
+ (FastBilateralSolverFilter*)createFastBilateralSolverFilter:(Mat*)guide sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma NS_SWIFT_NAME(createFastBilateralSolverFilter(guide:sigma_spatial:sigma_luma:sigma_chroma:));


//
//  void cv::ximgproc::fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat& dst, double sigma_spatial = 8, double sigma_luma = 8, double sigma_chroma = 8, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
//
/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 * @param lambda smoothness strength parameter for solver.
 *
 * @param num_iter number of iterations used for solver, 25 is usually enough.
 *
 * @param max_tol convergence tolerance used for solver.
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma lambda:(double)lambda num_iter:(int)num_iter max_tol:(double)max_tol NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:sigma_spatial:sigma_luma:sigma_chroma:lambda:num_iter:max_tol:));

/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 * @param lambda smoothness strength parameter for solver.
 *
 * @param num_iter number of iterations used for solver, 25 is usually enough.
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma lambda:(double)lambda num_iter:(int)num_iter NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:sigma_spatial:sigma_luma:sigma_chroma:lambda:num_iter:));

/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 * @param lambda smoothness strength parameter for solver.
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma lambda:(double)lambda NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:sigma_spatial:sigma_luma:sigma_chroma:lambda:));

/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
 *
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma sigma_chroma:(double)sigma_chroma NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:sigma_spatial:sigma_luma:sigma_chroma:));

/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 * @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
 *
 *
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst sigma_spatial:(double)sigma_spatial sigma_luma:(double)sigma_luma NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:sigma_spatial:sigma_luma:));

/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 * @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
 *
 *
 *
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst sigma_spatial:(double)sigma_spatial NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:sigma_spatial:));

/**
 * Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
 * guide then use FastBilateralSolverFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 *
 *
 *
 *
 *
 *
 * For more details about the Fast Bilateral Solver parameters, see the original paper CITE: BarronPoole2016.
 *
 * NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
+ (void)fastBilateralSolverFilter:(Mat*)guide src:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst NS_SWIFT_NAME(fastBilateralSolverFilter(guide:src:confidence:dst:));


//
//  Ptr_FastGlobalSmootherFilter cv::ximgproc::createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
//
/**
 * Factory method, create instance of FastGlobalSmootherFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param lambda parameter defining the amount of regularization
 *
 * @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
 *
 * @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
 * it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
 *
 * @param num_iter number of iterations used for filtering, 3 is usually enough.
 *
 * For more details about Fast Global Smoother parameters, see the original paper CITE: Min2014. However, please note that
 * there are several differences. Lambda attenuation described in the paper is implemented a bit differently so do not
 * expect the results to be identical to those from the paper; sigma_color values from the paper should be multiplied by 255.0 to
 * achieve the same effect. Also, in case of image filtering where source and guide image are the same, authors
 * propose to dynamically update the guide image after each iteration. To maximize the performance this feature
 * was not implemented here.
 */
+ (FastGlobalSmootherFilter*)createFastGlobalSmootherFilter:(Mat*)guide lambda:(double)lambda sigma_color:(double)sigma_color lambda_attenuation:(double)lambda_attenuation num_iter:(int)num_iter NS_SWIFT_NAME(createFastGlobalSmootherFilter(guide:lambda:sigma_color:lambda_attenuation:num_iter:));

/**
 * Factory method, create instance of FastGlobalSmootherFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param lambda parameter defining the amount of regularization
 *
 * @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
 *
 * @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
 * it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
 *
 *
 * For more details about Fast Global Smoother parameters, see the original paper CITE: Min2014. However, please note that
 * there are several differences. Lambda attenuation described in the paper is implemented a bit differently so do not
 * expect the results to be identical to those from the paper; sigma_color values from the paper should be multiplied by 255.0 to
 * achieve the same effect. Also, in case of image filtering where source and guide image are the same, authors
 * propose to dynamically update the guide image after each iteration. To maximize the performance this feature
 * was not implemented here.
 */
+ (FastGlobalSmootherFilter*)createFastGlobalSmootherFilter:(Mat*)guide lambda:(double)lambda sigma_color:(double)sigma_color lambda_attenuation:(double)lambda_attenuation NS_SWIFT_NAME(createFastGlobalSmootherFilter(guide:lambda:sigma_color:lambda_attenuation:));

/**
 * Factory method, create instance of FastGlobalSmootherFilter and execute the initialization routines.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param lambda parameter defining the amount of regularization
 *
 * @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
 *
 * it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
 *
 *
 * For more details about Fast Global Smoother parameters, see the original paper CITE: Min2014. However, please note that
 * there are several differences. Lambda attenuation described in the paper is implemented a bit differently so do not
 * expect the results to be identical to those from the paper; sigma_color values from the paper should be multiplied by 255.0 to
 * achieve the same effect. Also, in case of image filtering where source and guide image are the same, authors
 * propose to dynamically update the guide image after each iteration. To maximize the performance this feature
 * was not implemented here.
 */
+ (FastGlobalSmootherFilter*)createFastGlobalSmootherFilter:(Mat*)guide lambda:(double)lambda sigma_color:(double)sigma_color NS_SWIFT_NAME(createFastGlobalSmootherFilter(guide:lambda:sigma_color:));


//
//  void cv::ximgproc::fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
//
/**
 * Simple one-line Fast Global Smoother filter call. If you have multiple images to filter with the same
 * guide then use FastGlobalSmootherFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param dst destination image.
 *
 * @param lambda parameter defining the amount of regularization
 *
 * @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
 *
 * @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
 * it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
 *
 * @param num_iter number of iterations used for filtering, 3 is usually enough.
 */
+ (void)fastGlobalSmootherFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst lambda:(double)lambda sigma_color:(double)sigma_color lambda_attenuation:(double)lambda_attenuation num_iter:(int)num_iter NS_SWIFT_NAME(fastGlobalSmootherFilter(guide:src:dst:lambda:sigma_color:lambda_attenuation:num_iter:));

/**
 * Simple one-line Fast Global Smoother filter call. If you have multiple images to filter with the same
 * guide then use FastGlobalSmootherFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param dst destination image.
 *
 * @param lambda parameter defining the amount of regularization
 *
 * @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
 *
 * @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
 * it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
 *
 */
+ (void)fastGlobalSmootherFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst lambda:(double)lambda sigma_color:(double)sigma_color lambda_attenuation:(double)lambda_attenuation NS_SWIFT_NAME(fastGlobalSmootherFilter(guide:src:dst:lambda:sigma_color:lambda_attenuation:));

/**
 * Simple one-line Fast Global Smoother filter call. If you have multiple images to filter with the same
 * guide then use FastGlobalSmootherFilter interface to avoid extra computations.
 *
 * @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param dst destination image.
 *
 * @param lambda parameter defining the amount of regularization
 *
 * @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
 *
 * it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
 *
 */
+ (void)fastGlobalSmootherFilter:(Mat*)guide src:(Mat*)src dst:(Mat*)dst lambda:(double)lambda sigma_color:(double)sigma_color NS_SWIFT_NAME(fastGlobalSmootherFilter(guide:src:dst:lambda:sigma_color:));


//
//  void cv::ximgproc::l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
//
/**
 * Global image smoothing via L0 gradient minimization.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point depth.
 *
 * @param dst destination image.
 *
 * @param lambda parameter defining the smooth term weight.
 *
 * @param kappa parameter defining the increasing factor of the weight of the gradient data term.
 *
 * For more details about L0 Smoother, see the original paper CITE: xu2011image.
 */
+ (void)l0Smooth:(Mat*)src dst:(Mat*)dst lambda:(double)lambda kappa:(double)kappa NS_SWIFT_NAME(l0Smooth(src:dst:lambda:kappa:));

/**
 * Global image smoothing via L0 gradient minimization.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point depth.
 *
 * @param dst destination image.
 *
 * @param lambda parameter defining the smooth term weight.
 *
 *
 * For more details about L0 Smoother, see the original paper CITE: xu2011image.
 */
+ (void)l0Smooth:(Mat*)src dst:(Mat*)dst lambda:(double)lambda NS_SWIFT_NAME(l0Smooth(src:dst:lambda:));

/**
 * Global image smoothing via L0 gradient minimization.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point depth.
 *
 * @param dst destination image.
 *
 *
 *
 * For more details about L0 Smoother, see the original paper CITE: xu2011image.
 */
+ (void)l0Smooth:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(l0Smooth(src:dst:));


//
//  Ptr_SuperpixelSLIC cv::ximgproc::createSuperpixelSLIC(Mat image, SLICType algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
//
/**
 * Initialize a SuperpixelSLIC object
 *
 * @param image Image to segment
 * @param algorithm Chooses the algorithm variant to use:
 * SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
 * while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
 * @param region_size Chooses an average superpixel size measured in pixels
 * @param ruler Chooses the enforcement of superpixel smoothness factor of superpixel
 *
 * The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. For enanched results it is recommended for color images to
 * preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
 * CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
 *
 * ![image](pics/superpixels_slic.png)
 */
+ (SuperpixelSLIC*)createSuperpixelSLIC:(Mat*)image algorithm:(SLICType)algorithm region_size:(int)region_size ruler:(float)ruler NS_SWIFT_NAME(createSuperpixelSLIC(image:algorithm:region_size:ruler:));

/**
 * Initialize a SuperpixelSLIC object
 *
 * @param image Image to segment
 * @param algorithm Chooses the algorithm variant to use:
 * SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
 * while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
 * @param region_size Chooses an average superpixel size measured in pixels
 *
 * The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. For enanched results it is recommended for color images to
 * preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
 * CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
 *
 * ![image](pics/superpixels_slic.png)
 */
+ (SuperpixelSLIC*)createSuperpixelSLIC:(Mat*)image algorithm:(SLICType)algorithm region_size:(int)region_size NS_SWIFT_NAME(createSuperpixelSLIC(image:algorithm:region_size:));

/**
 * Initialize a SuperpixelSLIC object
 *
 * @param image Image to segment
 * @param algorithm Chooses the algorithm variant to use:
 * SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
 * while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
 *
 * The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. For enanched results it is recommended for color images to
 * preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
 * CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
 *
 * ![image](pics/superpixels_slic.png)
 */
+ (SuperpixelSLIC*)createSuperpixelSLIC:(Mat*)image algorithm:(SLICType)algorithm NS_SWIFT_NAME(createSuperpixelSLIC(image:algorithm:));

/**
 * Initialize a SuperpixelSLIC object
 *
 * @param image Image to segment
 * SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
 * while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
 *
 * The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. For enanched results it is recommended for color images to
 * preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
 * CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
 *
 * ![image](pics/superpixels_slic.png)
 */
+ (SuperpixelSLIC*)createSuperpixelSLIC:(Mat*)image NS_SWIFT_NAME(createSuperpixelSLIC(image:));


//
//  void cv::ximgproc::createQuaternionImage(Mat img, Mat& qimg)
//
/**
 * creates a quaternion image.
 *
 */
+ (void)createQuaternionImage:(Mat*)img qimg:(Mat*)qimg NS_SWIFT_NAME(createQuaternionImage(img:qimg:));


//
//  void cv::ximgproc::qconj(Mat qimg, Mat& qcimg)
//
/**
 * calculates conjugate of a quaternion image.
 *
 */
+ (void)qconj:(Mat*)qimg qcimg:(Mat*)qcimg NS_SWIFT_NAME(qconj(qimg:qcimg:));


//
//  void cv::ximgproc::qunitary(Mat qimg, Mat& qnimg)
//
/**
 * divides each element by its modulus.
 *
 */
+ (void)qunitary:(Mat*)qimg qnimg:(Mat*)qnimg NS_SWIFT_NAME(qunitary(qimg:qnimg:));


//
//  void cv::ximgproc::qmultiply(Mat src1, Mat src2, Mat& dst)
//
/**
 * Calculates the per-element quaternion product of two arrays
 *
 */
+ (void)qmultiply:(Mat*)src1 src2:(Mat*)src2 dst:(Mat*)dst NS_SWIFT_NAME(qmultiply(src1:src2:dst:));


//
//  void cv::ximgproc::qdft(Mat img, Mat& qimg, int flags, bool sideLeft)
//
/**
 * Performs a forward or inverse Discrete quaternion Fourier transform of a 2D quaternion array.
 *
 */
+ (void)qdft:(Mat*)img qimg:(Mat*)qimg flags:(int)flags sideLeft:(BOOL)sideLeft NS_SWIFT_NAME(qdft(img:qimg:flags:sideLeft:));


//
//  void cv::ximgproc::colorMatchTemplate(Mat img, Mat templ, Mat& result)
//
/**
 * Compares a color template against overlapped color image regions.
 *
 */
+ (void)colorMatchTemplate:(Mat*)img templ:(Mat*)templ result:(Mat*)result NS_SWIFT_NAME(colorMatchTemplate(img:templ:result:));


//
//  Ptr_RFFeatureGetter cv::ximgproc::createRFFeatureGetter()
//
+ (RFFeatureGetter*)createRFFeatureGetter NS_SWIFT_NAME(createRFFeatureGetter());


//
//  Ptr_StructuredEdgeDetection cv::ximgproc::createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
//
+ (StructuredEdgeDetection*)createStructuredEdgeDetection:(NSString*)model howToGetFeatures:(RFFeatureGetter*)howToGetFeatures NS_SWIFT_NAME(createStructuredEdgeDetection(model:howToGetFeatures:));

+ (StructuredEdgeDetection*)createStructuredEdgeDetection:(NSString*)model NS_SWIFT_NAME(createStructuredEdgeDetection(model:));


//
//  void cv::ximgproc::findEllipses(Mat image, Mat& ellipses, float scoreThreshold = 0.7f, float reliabilityThreshold = 0.5f, float centerDistanceThreshold = 0.05f)
//
/**
 * Finds ellipses fastly in an image using projective invariant pruning.
 *
 * The function detects ellipses in images using projective invariant pruning.
 * For more details about this implementation, please see CITE: jia2017fast
 * Jia, Qi et al, (2017).
 * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
 *
 * @param image input image, could be gray or color.
 * @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
 * @param scoreThreshold float, the threshold of ellipse score.
 * @param reliabilityThreshold float, the threshold of reliability.
 * @param centerDistanceThreshold float, the threshold of center distance.
 */
+ (void)findEllipses:(Mat*)image ellipses:(Mat*)ellipses scoreThreshold:(float)scoreThreshold reliabilityThreshold:(float)reliabilityThreshold centerDistanceThreshold:(float)centerDistanceThreshold NS_SWIFT_NAME(findEllipses(image:ellipses:scoreThreshold:reliabilityThreshold:centerDistanceThreshold:));

/**
 * Finds ellipses fastly in an image using projective invariant pruning.
 *
 * The function detects ellipses in images using projective invariant pruning.
 * For more details about this implementation, please see CITE: jia2017fast
 * Jia, Qi et al, (2017).
 * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
 *
 * @param image input image, could be gray or color.
 * @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
 * @param scoreThreshold float, the threshold of ellipse score.
 * @param reliabilityThreshold float, the threshold of reliability.
 */
+ (void)findEllipses:(Mat*)image ellipses:(Mat*)ellipses scoreThreshold:(float)scoreThreshold reliabilityThreshold:(float)reliabilityThreshold NS_SWIFT_NAME(findEllipses(image:ellipses:scoreThreshold:reliabilityThreshold:));

/**
 * Finds ellipses fastly in an image using projective invariant pruning.
 *
 * The function detects ellipses in images using projective invariant pruning.
 * For more details about this implementation, please see CITE: jia2017fast
 * Jia, Qi et al, (2017).
 * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
 *
 * @param image input image, could be gray or color.
 * @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
 * @param scoreThreshold float, the threshold of ellipse score.
 */
+ (void)findEllipses:(Mat*)image ellipses:(Mat*)ellipses scoreThreshold:(float)scoreThreshold NS_SWIFT_NAME(findEllipses(image:ellipses:scoreThreshold:));

/**
 * Finds ellipses fastly in an image using projective invariant pruning.
 *
 * The function detects ellipses in images using projective invariant pruning.
 * For more details about this implementation, please see CITE: jia2017fast
 * Jia, Qi et al, (2017).
 * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
 *
 * @param image input image, could be gray or color.
 * @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
 */
+ (void)findEllipses:(Mat*)image ellipses:(Mat*)ellipses NS_SWIFT_NAME(findEllipses(image:ellipses:));


//
//  Ptr_SuperpixelLSC cv::ximgproc::createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
//
/**
 * Class implementing the LSC (Linear Spectral Clustering) superpixels
 *
 * @param image Image to segment
 * @param region_size Chooses an average superpixel size measured in pixels
 * @param ratio Chooses the enforcement of superpixel compactness factor of superpixel
 *
 * The function initializes a SuperpixelLSC object for the input image. It sets the parameters of
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. An example of LSC is ilustrated in the following picture.
 * For enanched results it is recommended for color images to preprocess image with little gaussian blur
 * with a small 3 x 3 kernel and additional conversion into CieLAB color space.
 *
 * ![image](pics/superpixels_lsc.png)
 */
+ (SuperpixelLSC*)createSuperpixelLSC:(Mat*)image region_size:(int)region_size ratio:(float)ratio NS_SWIFT_NAME(createSuperpixelLSC(image:region_size:ratio:));

/**
 * Class implementing the LSC (Linear Spectral Clustering) superpixels
 *
 * @param image Image to segment
 * @param region_size Chooses an average superpixel size measured in pixels
 *
 * The function initializes a SuperpixelLSC object for the input image. It sets the parameters of
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. An example of LSC is ilustrated in the following picture.
 * For enanched results it is recommended for color images to preprocess image with little gaussian blur
 * with a small 3 x 3 kernel and additional conversion into CieLAB color space.
 *
 * ![image](pics/superpixels_lsc.png)
 */
+ (SuperpixelLSC*)createSuperpixelLSC:(Mat*)image region_size:(int)region_size NS_SWIFT_NAME(createSuperpixelLSC(image:region_size:));

/**
 * Class implementing the LSC (Linear Spectral Clustering) superpixels
 *
 * @param image Image to segment
 *
 * The function initializes a SuperpixelLSC object for the input image. It sets the parameters of
 * superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
 * computing iterations over the given image. An example of LSC is ilustrated in the following picture.
 * For enanched results it is recommended for color images to preprocess image with little gaussian blur
 * with a small 3 x 3 kernel and additional conversion into CieLAB color space.
 *
 * ![image](pics/superpixels_lsc.png)
 */
+ (SuperpixelLSC*)createSuperpixelLSC:(Mat*)image NS_SWIFT_NAME(createSuperpixelLSC(image:));


//
//  Ptr_EdgeBoxes cv::ximgproc::createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
//
/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 * @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
 * @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
 * @param maxAspectRatio max aspect ratio of boxes.
 * @param minBoxArea minimum area of boxes.
 * @param gamma affinity sensitivity.
 * @param kappa scale sensitivity.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag edgeMergeThr:(float)edgeMergeThr clusterMinMag:(float)clusterMinMag maxAspectRatio:(float)maxAspectRatio minBoxArea:(float)minBoxArea gamma:(float)gamma kappa:(float)kappa NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:edgeMergeThr:clusterMinMag:maxAspectRatio:minBoxArea:gamma:kappa:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 * @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
 * @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
 * @param maxAspectRatio max aspect ratio of boxes.
 * @param minBoxArea minimum area of boxes.
 * @param gamma affinity sensitivity.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag edgeMergeThr:(float)edgeMergeThr clusterMinMag:(float)clusterMinMag maxAspectRatio:(float)maxAspectRatio minBoxArea:(float)minBoxArea gamma:(float)gamma NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:edgeMergeThr:clusterMinMag:maxAspectRatio:minBoxArea:gamma:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 * @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
 * @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
 * @param maxAspectRatio max aspect ratio of boxes.
 * @param minBoxArea minimum area of boxes.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag edgeMergeThr:(float)edgeMergeThr clusterMinMag:(float)clusterMinMag maxAspectRatio:(float)maxAspectRatio minBoxArea:(float)minBoxArea NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:edgeMergeThr:clusterMinMag:maxAspectRatio:minBoxArea:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 * @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
 * @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
 * @param maxAspectRatio max aspect ratio of boxes.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag edgeMergeThr:(float)edgeMergeThr clusterMinMag:(float)clusterMinMag maxAspectRatio:(float)maxAspectRatio NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:edgeMergeThr:clusterMinMag:maxAspectRatio:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 * @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
 * @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag edgeMergeThr:(float)edgeMergeThr clusterMinMag:(float)clusterMinMag NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:edgeMergeThr:clusterMinMag:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 * @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag edgeMergeThr:(float)edgeMergeThr NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:edgeMergeThr:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 * @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes edgeMinMag:(float)edgeMinMag NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:edgeMinMag:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 * @param maxBoxes max number of boxes to detect.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore maxBoxes:(int)maxBoxes NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:maxBoxes:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 * @param minScore min score of boxes to detect.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta minScore:(float)minScore NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:minScore:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 * @param eta adaptation rate for nms threshold.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta eta:(float)eta NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:eta:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 * @param beta nms threshold for object proposals.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha beta:(float)beta NS_SWIFT_NAME(createEdgeBoxes(alpha:beta:));

/**
 * Creates a Edgeboxes
 *
 * @param alpha step size of sliding window search.
 */
+ (EdgeBoxes*)createEdgeBoxes:(float)alpha NS_SWIFT_NAME(createEdgeBoxes(alpha:));

/**
 * Creates a Edgeboxes
 *
 */
+ (EdgeBoxes*)createEdgeBoxes NS_SWIFT_NAME(createEdgeBoxes());


//
//  void cv::ximgproc::weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, WMFWeightType weightType = WMF_EXP, Mat mask = Mat())
//
/**
 * Applies weighted median filter to an image.
 *
 * For more details about this implementation, please see CITE: zhang2014100+
 *
 * the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
 *
 * @see `medianBlur`, `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`
 */
+ (void)weightedMedianFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst r:(int)r sigma:(double)sigma weightType:(WMFWeightType)weightType mask:(Mat*)mask NS_SWIFT_NAME(weightedMedianFilter(joint:src:dst:r:sigma:weightType:mask:));

/**
 * Applies weighted median filter to an image.
 *
 * For more details about this implementation, please see CITE: zhang2014100+
 *
 * the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
 *
 * @see `medianBlur`, `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`
 */
+ (void)weightedMedianFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst r:(int)r sigma:(double)sigma weightType:(WMFWeightType)weightType NS_SWIFT_NAME(weightedMedianFilter(joint:src:dst:r:sigma:weightType:));

/**
 * Applies weighted median filter to an image.
 *
 * For more details about this implementation, please see CITE: zhang2014100+
 *
 * the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
 *
 * @see `medianBlur`, `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`
 */
+ (void)weightedMedianFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst r:(int)r sigma:(double)sigma NS_SWIFT_NAME(weightedMedianFilter(joint:src:dst:r:sigma:));

/**
 * Applies weighted median filter to an image.
 *
 * For more details about this implementation, please see CITE: zhang2014100+
 *
 * the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
 *
 * @see `medianBlur`, `+jointBilateralFilter:src:dst:d:sigmaColor:sigmaSpace:borderType:`
 */
+ (void)weightedMedianFilter:(Mat*)joint src:(Mat*)src dst:(Mat*)dst r:(int)r NS_SWIFT_NAME(weightedMedianFilter(joint:src:dst:r:));


//
//  Ptr_GraphSegmentation cv::ximgproc::segmentation::createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
//
/**
 * Creates a graph based segmentor
 * @param sigma The sigma parameter, used to smooth image
 * @param k The k parameter of the algorythm
 * @param min_size The minimum size of segments
 */
+ (GraphSegmentation*)createGraphSegmentation:(double)sigma k:(float)k min_size:(int)min_size NS_SWIFT_NAME(createGraphSegmentation(sigma:k:min_size:));

/**
 * Creates a graph based segmentor
 * @param sigma The sigma parameter, used to smooth image
 * @param k The k parameter of the algorythm
 */
+ (GraphSegmentation*)createGraphSegmentation:(double)sigma k:(float)k NS_SWIFT_NAME(createGraphSegmentation(sigma:k:));

/**
 * Creates a graph based segmentor
 * @param sigma The sigma parameter, used to smooth image
 */
+ (GraphSegmentation*)createGraphSegmentation:(double)sigma NS_SWIFT_NAME(createGraphSegmentation(sigma:));

/**
 * Creates a graph based segmentor
 */
+ (GraphSegmentation*)createGraphSegmentation NS_SWIFT_NAME(createGraphSegmentation());


//
//  Ptr_SelectiveSearchSegmentationStrategyColor cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyColor()
//
/**
 * Create a new color-based strategy
 */
+ (SelectiveSearchSegmentationStrategyColor*)createSelectiveSearchSegmentationStrategyColor NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyColor());


//
//  Ptr_SelectiveSearchSegmentationStrategySize cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategySize()
//
/**
 * Create a new size-based strategy
 */
+ (SelectiveSearchSegmentationStrategySize*)createSelectiveSearchSegmentationStrategySize NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategySize());


//
//  Ptr_SelectiveSearchSegmentationStrategyTexture cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyTexture()
//
/**
 * Create a new size-based strategy
 */
+ (SelectiveSearchSegmentationStrategyTexture*)createSelectiveSearchSegmentationStrategyTexture NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyTexture());


//
//  Ptr_SelectiveSearchSegmentationStrategyFill cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyFill()
//
/**
 * Create a new fill-based strategy
 */
+ (SelectiveSearchSegmentationStrategyFill*)createSelectiveSearchSegmentationStrategyFill NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyFill());


//
//  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple()
//
/**
 * Create a new multiple strategy
 */
+ (SelectiveSearchSegmentationStrategyMultiple*)createSelectiveSearchSegmentationStrategyMultiple NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyMultiple());


//
//  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
//
/**
 * Create a new multiple strategy and set one subtrategy
 * @param s1 The first strategy
 */
+ (SelectiveSearchSegmentationStrategyMultiple*)createSelectiveSearchSegmentationStrategyMultiple:(SelectiveSearchSegmentationStrategy*)s1 NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyMultiple(s1:));


//
//  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
//
/**
 * Create a new multiple strategy and set two subtrategies, with equal weights
 * @param s1 The first strategy
 * @param s2 The second strategy
 */
+ (SelectiveSearchSegmentationStrategyMultiple*)createSelectiveSearchSegmentationStrategyMultiple:(SelectiveSearchSegmentationStrategy*)s1 s2:(SelectiveSearchSegmentationStrategy*)s2 NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyMultiple(s1:s2:));


//
//  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
//
/**
 * Create a new multiple strategy and set three subtrategies, with equal weights
 * @param s1 The first strategy
 * @param s2 The second strategy
 * @param s3 The third strategy
 */
+ (SelectiveSearchSegmentationStrategyMultiple*)createSelectiveSearchSegmentationStrategyMultiple:(SelectiveSearchSegmentationStrategy*)s1 s2:(SelectiveSearchSegmentationStrategy*)s2 s3:(SelectiveSearchSegmentationStrategy*)s3 NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyMultiple(s1:s2:s3:));


//
//  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
//
/**
 * Create a new multiple strategy and set four subtrategies, with equal weights
 * @param s1 The first strategy
 * @param s2 The second strategy
 * @param s3 The third strategy
 * @param s4 The forth strategy
 */
+ (SelectiveSearchSegmentationStrategyMultiple*)createSelectiveSearchSegmentationStrategyMultiple:(SelectiveSearchSegmentationStrategy*)s1 s2:(SelectiveSearchSegmentationStrategy*)s2 s3:(SelectiveSearchSegmentationStrategy*)s3 s4:(SelectiveSearchSegmentationStrategy*)s4 NS_SWIFT_NAME(createSelectiveSearchSegmentationStrategyMultiple(s1:s2:s3:s4:));


//
//  Ptr_SelectiveSearchSegmentation cv::ximgproc::segmentation::createSelectiveSearchSegmentation()
//
/**
 * Create a new SelectiveSearchSegmentation class.
 */
+ (SelectiveSearchSegmentation*)createSelectiveSearchSegmentation NS_SWIFT_NAME(createSelectiveSearchSegmentation());


//
//  void cv::ximgproc::FastHoughTransform(Mat src, Mat& dst, int dstMatDepth, AngleRangeOption angleRange = ARO_315_135, HoughOp op = FHT_ADD, HoughDeskewOption makeSkew = HDO_DESKEW)
//
/**
 * Calculates 2D Fast Hough transform of an image.
 *
 * The function calculates the fast Hough transform for full, half or quarter
 * range of angles.
 */
+ (void)FastHoughTransform:(Mat*)src dst:(Mat*)dst dstMatDepth:(int)dstMatDepth angleRange:(AngleRangeOption)angleRange op:(HoughOp)op makeSkew:(HoughDeskewOption)makeSkew NS_SWIFT_NAME(FastHoughTransform(src:dst:dstMatDepth:angleRange:op:makeSkew:));

/**
 * Calculates 2D Fast Hough transform of an image.
 *
 * The function calculates the fast Hough transform for full, half or quarter
 * range of angles.
 */
+ (void)FastHoughTransform:(Mat*)src dst:(Mat*)dst dstMatDepth:(int)dstMatDepth angleRange:(AngleRangeOption)angleRange op:(HoughOp)op NS_SWIFT_NAME(FastHoughTransform(src:dst:dstMatDepth:angleRange:op:));

/**
 * Calculates 2D Fast Hough transform of an image.
 *
 * The function calculates the fast Hough transform for full, half or quarter
 * range of angles.
 */
+ (void)FastHoughTransform:(Mat*)src dst:(Mat*)dst dstMatDepth:(int)dstMatDepth angleRange:(AngleRangeOption)angleRange NS_SWIFT_NAME(FastHoughTransform(src:dst:dstMatDepth:angleRange:));

/**
 * Calculates 2D Fast Hough transform of an image.
 *
 * The function calculates the fast Hough transform for full, half or quarter
 * range of angles.
 */
+ (void)FastHoughTransform:(Mat*)src dst:(Mat*)dst dstMatDepth:(int)dstMatDepth NS_SWIFT_NAME(FastHoughTransform(src:dst:dstMatDepth:));


//
//  Vec4i cv::ximgproc::HoughPoint2Line(Point houghPoint, Mat srcImgInfo, AngleRangeOption angleRange = ARO_315_135, HoughDeskewOption makeSkew = HDO_DESKEW, int rules = RO_IGNORE_BORDERS)
//
/**
 * Calculates coordinates of line segment corresponded by point in Hough space.
 * @retval  [Vec4i]     Coordinates of line segment corresponded by point in Hough space.
 * @remarks If rules parameter set to RO_STRICT
 *            then returned line cut along the border of source image.
 * @remarks If rules parameter set to RO_WEAK then in case of point, which belongs
 *            the incorrect part of Hough image, returned line will not intersect source image.
 *
 * The function calculates coordinates of line segment corresponded by point in Hough space.
 */
+ (Int4*)HoughPoint2Line:(Point2i*)houghPoint srcImgInfo:(Mat*)srcImgInfo angleRange:(AngleRangeOption)angleRange makeSkew:(HoughDeskewOption)makeSkew rules:(int)rules NS_SWIFT_NAME(HoughPoint2Line(houghPoint:srcImgInfo:angleRange:makeSkew:rules:));

/**
 * Calculates coordinates of line segment corresponded by point in Hough space.
 * @retval  [Vec4i]     Coordinates of line segment corresponded by point in Hough space.
 * @remarks If rules parameter set to RO_STRICT
 *            then returned line cut along the border of source image.
 * @remarks If rules parameter set to RO_WEAK then in case of point, which belongs
 *            the incorrect part of Hough image, returned line will not intersect source image.
 *
 * The function calculates coordinates of line segment corresponded by point in Hough space.
 */
+ (Int4*)HoughPoint2Line:(Point2i*)houghPoint srcImgInfo:(Mat*)srcImgInfo angleRange:(AngleRangeOption)angleRange makeSkew:(HoughDeskewOption)makeSkew NS_SWIFT_NAME(HoughPoint2Line(houghPoint:srcImgInfo:angleRange:makeSkew:));

/**
 * Calculates coordinates of line segment corresponded by point in Hough space.
 * @retval  [Vec4i]     Coordinates of line segment corresponded by point in Hough space.
 * @remarks If rules parameter set to RO_STRICT
 *            then returned line cut along the border of source image.
 * @remarks If rules parameter set to RO_WEAK then in case of point, which belongs
 *            the incorrect part of Hough image, returned line will not intersect source image.
 *
 * The function calculates coordinates of line segment corresponded by point in Hough space.
 */
+ (Int4*)HoughPoint2Line:(Point2i*)houghPoint srcImgInfo:(Mat*)srcImgInfo angleRange:(AngleRangeOption)angleRange NS_SWIFT_NAME(HoughPoint2Line(houghPoint:srcImgInfo:angleRange:));

/**
 * Calculates coordinates of line segment corresponded by point in Hough space.
 * @retval  [Vec4i]     Coordinates of line segment corresponded by point in Hough space.
 * @remarks If rules parameter set to RO_STRICT
 *            then returned line cut along the border of source image.
 * @remarks If rules parameter set to RO_WEAK then in case of point, which belongs
 *            the incorrect part of Hough image, returned line will not intersect source image.
 *
 * The function calculates coordinates of line segment corresponded by point in Hough space.
 */
+ (Int4*)HoughPoint2Line:(Point2i*)houghPoint srcImgInfo:(Mat*)srcImgInfo NS_SWIFT_NAME(HoughPoint2Line(houghPoint:srcImgInfo:));


//
//  void cv::ximgproc::PeiLinNormalization(Mat I, Mat& T)
//
+ (void)PeiLinNormalization:(Mat*)I T:(Mat*)T NS_SWIFT_NAME(PeiLinNormalization(I:T:));


//
//  void cv::ximgproc::fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
//
/**
 * Fourier descriptors for planed closed curves
 *
 * For more details about this implementation, please see CITE: PersoonFu1977
 *
 *
 */
+ (void)fourierDescriptor:(Mat*)src dst:(Mat*)dst nbElt:(int)nbElt nbFD:(int)nbFD NS_SWIFT_NAME(fourierDescriptor(src:dst:nbElt:nbFD:));

/**
 * Fourier descriptors for planed closed curves
 *
 * For more details about this implementation, please see CITE: PersoonFu1977
 *
 *
 */
+ (void)fourierDescriptor:(Mat*)src dst:(Mat*)dst nbElt:(int)nbElt NS_SWIFT_NAME(fourierDescriptor(src:dst:nbElt:));

/**
 * Fourier descriptors for planed closed curves
 *
 * For more details about this implementation, please see CITE: PersoonFu1977
 *
 *
 */
+ (void)fourierDescriptor:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(fourierDescriptor(src:dst:));


//
//  void cv::ximgproc::transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
//
/**
 * transform a contour
 *
 *
 */
+ (void)transformFD:(Mat*)src t:(Mat*)t dst:(Mat*)dst fdContour:(BOOL)fdContour NS_SWIFT_NAME(transformFD(src:t:dst:fdContour:));

/**
 * transform a contour
 *
 *
 */
+ (void)transformFD:(Mat*)src t:(Mat*)t dst:(Mat*)dst NS_SWIFT_NAME(transformFD(src:t:dst:));


//
//  void cv::ximgproc::contourSampling(Mat src, Mat& out, int nbElt)
//
/**
 * Contour sampling .
 *
 *
 */
+ (void)contourSampling:(Mat*)src out:(Mat*)out nbElt:(int)nbElt NS_SWIFT_NAME(contourSampling(src:out:nbElt:));


//
//  Ptr_ContourFitting cv::ximgproc::createContourFitting(int ctr = 1024, int fd = 16)
//
/**
 * create ContourFitting algorithm object
 *
 * @param ctr number of Fourier descriptors equal to number of contour points after resampling.
 * @param fd Contour defining second shape (Target).
 */
+ (ContourFitting*)createContourFitting:(int)ctr fd:(int)fd NS_SWIFT_NAME(createContourFitting(ctr:fd:));

/**
 * create ContourFitting algorithm object
 *
 * @param ctr number of Fourier descriptors equal to number of contour points after resampling.
 */
+ (ContourFitting*)createContourFitting:(int)ctr NS_SWIFT_NAME(createContourFitting(ctr:));

/**
 * create ContourFitting algorithm object
 *
 */
+ (ContourFitting*)createContourFitting NS_SWIFT_NAME(createContourFitting());


//
//  Ptr_EdgeAwareInterpolator cv::ximgproc::createEdgeAwareInterpolator()
//
/**
 * Factory method that creates an instance of the
 * EdgeAwareInterpolator.
 */
+ (EdgeAwareInterpolator*)createEdgeAwareInterpolator NS_SWIFT_NAME(createEdgeAwareInterpolator());


//
//  Ptr_RICInterpolator cv::ximgproc::createRICInterpolator()
//
/**
 * Factory method that creates an instance of the
 * RICInterpolator.
 */
+ (RICInterpolator*)createRICInterpolator NS_SWIFT_NAME(createRICInterpolator());


//
//  Ptr_EdgeDrawing cv::ximgproc::createEdgeDrawing()
//
/**
 * Creates a smart pointer to a EdgeDrawing object and initializes it
 */
+ (EdgeDrawing*)createEdgeDrawing NS_SWIFT_NAME(createEdgeDrawing());


//
//  void cv::ximgproc::RadonTransform(Mat src, Mat& dst, double theta = 1, double start_angle = 0, double end_angle = 180, bool crop = false, bool norm = false)
//
/**
 * Calculate Radon Transform of an image.
 *
 * This function calculates the Radon Transform of a given image in any range.
 * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
 * If the input type is CV_8U, the output will be CV_32S.
 * If the input type is CV_32F or CV_64F, the output will be CV_64F
 * The output size will be num_of_integral x src_diagonal_length.
 * If crop is selected, the input image will be crop into square then circle,
 * and output size will be num_of_integral x min_edge.
 *
 */
+ (void)RadonTransform:(Mat*)src dst:(Mat*)dst theta:(double)theta start_angle:(double)start_angle end_angle:(double)end_angle crop:(BOOL)crop norm:(BOOL)norm NS_SWIFT_NAME(RadonTransform(src:dst:theta:start_angle:end_angle:crop:norm:));

/**
 * Calculate Radon Transform of an image.
 *
 * This function calculates the Radon Transform of a given image in any range.
 * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
 * If the input type is CV_8U, the output will be CV_32S.
 * If the input type is CV_32F or CV_64F, the output will be CV_64F
 * The output size will be num_of_integral x src_diagonal_length.
 * If crop is selected, the input image will be crop into square then circle,
 * and output size will be num_of_integral x min_edge.
 *
 */
+ (void)RadonTransform:(Mat*)src dst:(Mat*)dst theta:(double)theta start_angle:(double)start_angle end_angle:(double)end_angle crop:(BOOL)crop NS_SWIFT_NAME(RadonTransform(src:dst:theta:start_angle:end_angle:crop:));

/**
 * Calculate Radon Transform of an image.
 *
 * This function calculates the Radon Transform of a given image in any range.
 * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
 * If the input type is CV_8U, the output will be CV_32S.
 * If the input type is CV_32F or CV_64F, the output will be CV_64F
 * The output size will be num_of_integral x src_diagonal_length.
 * If crop is selected, the input image will be crop into square then circle,
 * and output size will be num_of_integral x min_edge.
 *
 */
+ (void)RadonTransform:(Mat*)src dst:(Mat*)dst theta:(double)theta start_angle:(double)start_angle end_angle:(double)end_angle NS_SWIFT_NAME(RadonTransform(src:dst:theta:start_angle:end_angle:));

/**
 * Calculate Radon Transform of an image.
 *
 * This function calculates the Radon Transform of a given image in any range.
 * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
 * If the input type is CV_8U, the output will be CV_32S.
 * If the input type is CV_32F or CV_64F, the output will be CV_64F
 * The output size will be num_of_integral x src_diagonal_length.
 * If crop is selected, the input image will be crop into square then circle,
 * and output size will be num_of_integral x min_edge.
 *
 */
+ (void)RadonTransform:(Mat*)src dst:(Mat*)dst theta:(double)theta start_angle:(double)start_angle NS_SWIFT_NAME(RadonTransform(src:dst:theta:start_angle:));

/**
 * Calculate Radon Transform of an image.
 *
 * This function calculates the Radon Transform of a given image in any range.
 * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
 * If the input type is CV_8U, the output will be CV_32S.
 * If the input type is CV_32F or CV_64F, the output will be CV_64F
 * The output size will be num_of_integral x src_diagonal_length.
 * If crop is selected, the input image will be crop into square then circle,
 * and output size will be num_of_integral x min_edge.
 *
 */
+ (void)RadonTransform:(Mat*)src dst:(Mat*)dst theta:(double)theta NS_SWIFT_NAME(RadonTransform(src:dst:theta:));

/**
 * Calculate Radon Transform of an image.
 *
 * This function calculates the Radon Transform of a given image in any range.
 * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
 * If the input type is CV_8U, the output will be CV_32S.
 * If the input type is CV_32F or CV_64F, the output will be CV_64F
 * The output size will be num_of_integral x src_diagonal_length.
 * If crop is selected, the input image will be crop into square then circle,
 * and output size will be num_of_integral x min_edge.
 *
 */
+ (void)RadonTransform:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(RadonTransform(src:dst:));


//
//  Ptr_SuperpixelSEEDS cv::ximgproc::createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
//
/**
 * Initializes a SuperpixelSEEDS object.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param image_channels Number of channels of the image.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
 * get the actual number.
 * @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
 * but needs more memory and CPU time.
 * @param prior enable 3x3 shape smoothing term if \>0. A larger value leads to smoother shapes. prior
 * must be in the range [0, 5].
 * @param histogram_bins Number of histogram bins.
 * @param double_step If true, iterate each block level twice for higher accuracy.
 *
 * The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
 * the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
 * superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
 * double_step.
 *
 * The number of levels in num_levels defines the amount of block levels that the algorithm use in the
 * optimization. The initialization is a grid, in which the superpixels are equally distributed through
 * the width and the height of the image. The larger blocks correspond to the superpixel size, and the
 * levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
 * recursively until the smaller block level. An example of initialization of 4 block levels is
 * illustrated in the following figure.
 *
 * ![image](pics/superpixels_blocks.png)
 */
+ (SuperpixelSEEDS*)createSuperpixelSEEDS:(int)image_width image_height:(int)image_height image_channels:(int)image_channels num_superpixels:(int)num_superpixels num_levels:(int)num_levels prior:(int)prior histogram_bins:(int)histogram_bins double_step:(BOOL)double_step NS_SWIFT_NAME(createSuperpixelSEEDS(image_width:image_height:image_channels:num_superpixels:num_levels:prior:histogram_bins:double_step:));

/**
 * Initializes a SuperpixelSEEDS object.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param image_channels Number of channels of the image.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
 * get the actual number.
 * @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
 * but needs more memory and CPU time.
 * @param prior enable 3x3 shape smoothing term if \>0. A larger value leads to smoother shapes. prior
 * must be in the range [0, 5].
 * @param histogram_bins Number of histogram bins.
 *
 * The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
 * the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
 * superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
 * double_step.
 *
 * The number of levels in num_levels defines the amount of block levels that the algorithm use in the
 * optimization. The initialization is a grid, in which the superpixels are equally distributed through
 * the width and the height of the image. The larger blocks correspond to the superpixel size, and the
 * levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
 * recursively until the smaller block level. An example of initialization of 4 block levels is
 * illustrated in the following figure.
 *
 * ![image](pics/superpixels_blocks.png)
 */
+ (SuperpixelSEEDS*)createSuperpixelSEEDS:(int)image_width image_height:(int)image_height image_channels:(int)image_channels num_superpixels:(int)num_superpixels num_levels:(int)num_levels prior:(int)prior histogram_bins:(int)histogram_bins NS_SWIFT_NAME(createSuperpixelSEEDS(image_width:image_height:image_channels:num_superpixels:num_levels:prior:histogram_bins:));

/**
 * Initializes a SuperpixelSEEDS object.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param image_channels Number of channels of the image.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
 * get the actual number.
 * @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
 * but needs more memory and CPU time.
 * @param prior enable 3x3 shape smoothing term if \>0. A larger value leads to smoother shapes. prior
 * must be in the range [0, 5].
 *
 * The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
 * the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
 * superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
 * double_step.
 *
 * The number of levels in num_levels defines the amount of block levels that the algorithm use in the
 * optimization. The initialization is a grid, in which the superpixels are equally distributed through
 * the width and the height of the image. The larger blocks correspond to the superpixel size, and the
 * levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
 * recursively until the smaller block level. An example of initialization of 4 block levels is
 * illustrated in the following figure.
 *
 * ![image](pics/superpixels_blocks.png)
 */
+ (SuperpixelSEEDS*)createSuperpixelSEEDS:(int)image_width image_height:(int)image_height image_channels:(int)image_channels num_superpixels:(int)num_superpixels num_levels:(int)num_levels prior:(int)prior NS_SWIFT_NAME(createSuperpixelSEEDS(image_width:image_height:image_channels:num_superpixels:num_levels:prior:));

/**
 * Initializes a SuperpixelSEEDS object.
 *
 * @param image_width Image width.
 * @param image_height Image height.
 * @param image_channels Number of channels of the image.
 * @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
 * due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
 * get the actual number.
 * @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
 * but needs more memory and CPU time.
 * must be in the range [0, 5].
 *
 * The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
 * the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
 * superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
 * double_step.
 *
 * The number of levels in num_levels defines the amount of block levels that the algorithm use in the
 * optimization. The initialization is a grid, in which the superpixels are equally distributed through
 * the width and the height of the image. The larger blocks correspond to the superpixel size, and the
 * levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
 * recursively until the smaller block level. An example of initialization of 4 block levels is
 * illustrated in the following figure.
 *
 * ![image](pics/superpixels_blocks.png)
 */
+ (SuperpixelSEEDS*)createSuperpixelSEEDS:(int)image_width image_height:(int)image_height image_channels:(int)image_channels num_superpixels:(int)num_superpixels num_levels:(int)num_levels NS_SWIFT_NAME(createSuperpixelSEEDS(image_width:image_height:image_channels:num_superpixels:num_levels:));


//
//  Ptr_FastLineDetector cv::ximgproc::createFastLineDetector(int length_threshold = 10, float distance_threshold = 1.414213562f, double canny_th1 = 50.0, double canny_th2 = 50.0, int canny_aperture_size = 3, bool do_merge = false)
//
/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 * @param length_threshold    Segment shorter than this will be discarded
 * @param distance_threshold  A point placed from a hypothesis line
 *                            segment farther than this will be regarded as an outlier
 * @param canny_th1           First threshold for hysteresis procedure in Canny()
 * @param canny_th2           Second threshold for hysteresis procedure in Canny()
 * @param canny_aperture_size Aperturesize for the sobel operator in Canny().
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 * @param do_merge            If true, incremental merging of segments will be performed
 */
+ (FastLineDetector*)createFastLineDetector:(int)length_threshold distance_threshold:(float)distance_threshold canny_th1:(double)canny_th1 canny_th2:(double)canny_th2 canny_aperture_size:(int)canny_aperture_size do_merge:(BOOL)do_merge NS_SWIFT_NAME(createFastLineDetector(length_threshold:distance_threshold:canny_th1:canny_th2:canny_aperture_size:do_merge:));

/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 * @param length_threshold    Segment shorter than this will be discarded
 * @param distance_threshold  A point placed from a hypothesis line
 *                            segment farther than this will be regarded as an outlier
 * @param canny_th1           First threshold for hysteresis procedure in Canny()
 * @param canny_th2           Second threshold for hysteresis procedure in Canny()
 * @param canny_aperture_size Aperturesize for the sobel operator in Canny().
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 */
+ (FastLineDetector*)createFastLineDetector:(int)length_threshold distance_threshold:(float)distance_threshold canny_th1:(double)canny_th1 canny_th2:(double)canny_th2 canny_aperture_size:(int)canny_aperture_size NS_SWIFT_NAME(createFastLineDetector(length_threshold:distance_threshold:canny_th1:canny_th2:canny_aperture_size:));

/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 * @param length_threshold    Segment shorter than this will be discarded
 * @param distance_threshold  A point placed from a hypothesis line
 *                            segment farther than this will be regarded as an outlier
 * @param canny_th1           First threshold for hysteresis procedure in Canny()
 * @param canny_th2           Second threshold for hysteresis procedure in Canny()
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 */
+ (FastLineDetector*)createFastLineDetector:(int)length_threshold distance_threshold:(float)distance_threshold canny_th1:(double)canny_th1 canny_th2:(double)canny_th2 NS_SWIFT_NAME(createFastLineDetector(length_threshold:distance_threshold:canny_th1:canny_th2:));

/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 * @param length_threshold    Segment shorter than this will be discarded
 * @param distance_threshold  A point placed from a hypothesis line
 *                            segment farther than this will be regarded as an outlier
 * @param canny_th1           First threshold for hysteresis procedure in Canny()
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 */
+ (FastLineDetector*)createFastLineDetector:(int)length_threshold distance_threshold:(float)distance_threshold canny_th1:(double)canny_th1 NS_SWIFT_NAME(createFastLineDetector(length_threshold:distance_threshold:canny_th1:));

/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 * @param length_threshold    Segment shorter than this will be discarded
 * @param distance_threshold  A point placed from a hypothesis line
 *                            segment farther than this will be regarded as an outlier
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 */
+ (FastLineDetector*)createFastLineDetector:(int)length_threshold distance_threshold:(float)distance_threshold NS_SWIFT_NAME(createFastLineDetector(length_threshold:distance_threshold:));

/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 * @param length_threshold    Segment shorter than this will be discarded
 *                            segment farther than this will be regarded as an outlier
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 */
+ (FastLineDetector*)createFastLineDetector:(int)length_threshold NS_SWIFT_NAME(createFastLineDetector(length_threshold:));

/**
 * Creates a smart pointer to a FastLineDetector object and initializes it
 *
 *                            segment farther than this will be regarded as an outlier
 *                            If zero, Canny() is not applied and the input image is taken as an edge image.
 */
+ (FastLineDetector*)createFastLineDetector NS_SWIFT_NAME(createFastLineDetector());


//
//  void cv::ximgproc::covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
//
/**
 * Computes the estimated covariance matrix of an image using the sliding
 * window forumlation.
 *
 * @param src The source image. Input image must be of a complex type.
 * @param dst The destination estimated covariance matrix. Output matrix will be size (windowRows*windowCols, windowRows*windowCols).
 * @param windowRows The number of rows in the window.
 * @param windowCols The number of cols in the window.
 * The window size parameters control the accuracy of the estimation.
 * The sliding window moves over the entire image from the top-left corner
 * to the bottom right corner. Each location of the window represents a sample.
 * If the window is the size of the image, then this gives the exact covariance matrix.
 * For all other cases, the sizes of the window will impact the number of samples
 * and the number of elements in the estimated covariance matrix.
 */
+ (void)covarianceEstimation:(Mat*)src dst:(Mat*)dst windowRows:(int)windowRows windowCols:(int)windowCols NS_SWIFT_NAME(covarianceEstimation(src:dst:windowRows:windowCols:));



@end

NS_ASSUME_NONNULL_END


