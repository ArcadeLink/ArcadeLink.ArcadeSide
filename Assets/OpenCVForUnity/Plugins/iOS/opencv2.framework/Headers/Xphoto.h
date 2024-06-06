//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xphoto.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class GrayworldWB;
@class LearningBasedWB;
@class Mat;
@class SimpleWB;
@class TonemapDurand;


// C++: enum Bm3dSteps (cv.xphoto.Bm3dSteps)
typedef NS_ENUM(int, Bm3dSteps) {
    BM3D_STEPALL = 0,
    BM3D_STEP1 = 1,
    BM3D_STEP2 = 2
};


// C++: enum InpaintTypes (cv.xphoto.InpaintTypes)
typedef NS_ENUM(int, InpaintTypes) {
    INPAINT_SHIFTMAP = 0,
    INPAINT_FSR_BEST = 1,
    INPAINT_FSR_FAST = 2
};


// C++: enum TransformTypes (cv.xphoto.TransformTypes)
typedef NS_ENUM(int, TransformTypes) {
    HAAR = 0
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Xphoto
/**
 * The Xphoto module
 *
 * Member classes: `TonemapDurand`, `WhiteBalancer`, `SimpleWB`, `GrayworldWB`, `LearningBasedWB`
 *
 * Member enums: `TransformTypes`, `Bm3dSteps`, `InpaintTypes`
 */
CV_EXPORTS @interface Xphoto : NSObject

#pragma mark - Methods


//
//  void cv::xphoto::bm3dDenoising(Mat src, Mat& dstStep1, Mat& dstStep2, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
//
/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 * @param normType Norm used to calculate distance between blocks. L2 is slower than L1
 *         but yields more accurate results.
 * @param step Step of BM3D to be executed. Possible variants are: step 1, step 2, both steps.
 * @param transformType Type of the orthogonal transform used in collaborative filtering step.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta normType:(int)normType step:(int)step transformType:(int)transformType NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:normType:step:transformType:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 * @param normType Norm used to calculate distance between blocks. L2 is slower than L1
 *         but yields more accurate results.
 * @param step Step of BM3D to be executed. Possible variants are: step 1, step 2, both steps.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta normType:(int)normType step:(int)step NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:normType:step:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 * @param normType Norm used to calculate distance between blocks. L2 is slower than L1
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta normType:(int)normType NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:normType:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:blockMatchingStep1:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:searchWindowSize:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h templateWindowSize:(int)templateWindowSize NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:templateWindowSize:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 *         Should be power of 2.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 h:(float)h NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:h:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dstStep1 Output image of the first step of BM3D with the same size and type as src.
 * @param dstStep2 Output image of the second step of BM3D with the same size and type as src.
 *         removes image details, smaller h value preserves details but also preserves some noise.
 *         Should be power of 2.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dstStep1:(Mat*)dstStep1 dstStep2:(Mat*)dstStep2 NS_SWIFT_NAME(bm3dDenoising(src:dstStep1:dstStep2:));


//
//  void cv::xphoto::bm3dDenoising(Mat src, Mat& dst, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
//
/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 * @param normType Norm used to calculate distance between blocks. L2 is slower than L1
 *         but yields more accurate results.
 * @param step Step of BM3D to be executed. Allowed are only BM3D_STEP1 and BM3D_STEPALL.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 * @param transformType Type of the orthogonal transform used in collaborative filtering step.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta normType:(int)normType step:(int)step transformType:(int)transformType NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:normType:step:transformType:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 * @param normType Norm used to calculate distance between blocks. L2 is slower than L1
 *         but yields more accurate results.
 * @param step Step of BM3D to be executed. Allowed are only BM3D_STEP1 and BM3D_STEPALL.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta normType:(int)normType step:(int)step NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:normType:step:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 * @param normType Norm used to calculate distance between blocks. L2 is slower than L1
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta normType:(int)normType NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:normType:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 * @param beta Kaiser window parameter that affects the sidelobe attenuation of the transform of the
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep beta:(float)beta NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:beta:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 * @param slidingStep Sliding step to process every next reference block.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize slidingStep:(int)slidingStep NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:slidingStep:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param groupSize Maximum size of the 3D group for collaborative filtering.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 groupSize:(int)groupSize NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:groupSize:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 * @param blockMatchingStep2 Block matching threshold for the second step of BM3D (Wiener filtering),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 blockMatchingStep2:(int)blockMatchingStep2 NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:blockMatchingStep2:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 * @param blockMatchingStep1 Block matching threshold for the first step of BM3D (hard thresholding),
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize blockMatchingStep1:(int)blockMatchingStep1 NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:blockMatchingStep1:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 * @param searchWindowSize Size in pixels of the window that is used to perform block-matching.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize searchWindowSize:(int)searchWindowSize NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:searchWindowSize:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 * @param templateWindowSize Size in pixels of the template patch that is used for block-matching.
 *         Should be power of 2.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h templateWindowSize:(int)templateWindowSize NS_SWIFT_NAME(bm3dDenoising(src:dst:h:templateWindowSize:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 * @param h Parameter regulating filter strength. Big h value perfectly removes noise but also
 *         removes image details, smaller h value preserves details but also preserves some noise.
 *         Should be power of 2.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst h:(float)h NS_SWIFT_NAME(bm3dDenoising(src:dst:h:));

/**
 * Performs image denoising using the Block-Matching and 3D-filtering algorithm
 *         <http://www.cs.tut.fi/~foi/GCF-BM3D/BM3D_TIP_2007.pdf> with several computational
 *         optimizations. Noise expected to be a gaussian white noise.
 *
 * @param src Input 8-bit or 16-bit 1-channel image.
 * @param dst Output image with the same size and type as src.
 *         removes image details, smaller h value preserves details but also preserves some noise.
 *         Should be power of 2.
 *         Affect performance linearly: greater searchWindowsSize - greater denoising time.
 *         Must be larger than templateWindowSize.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         i.e. maximum distance for which two blocks are considered similar.
 *         Value expressed in euclidean distance.
 *         window. Kaiser window is used in order to reduce border effects. To prevent usage of the window,
 *         set beta to zero.
 *         but yields more accurate results.
 *         BM3D_STEP2 is not allowed as it requires basic estimate to be present.
 *         Currently only Haar transform is supported.
 *
 *         This function expected to be applied to grayscale images. Advanced usage of this function
 *         can be manual denoising of colored image in different colorspaces.
 *
 *         @sa
 *         fastNlMeansDenoising
 */
+ (void)bm3dDenoising:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(bm3dDenoising(src:dst:));


//
//  Ptr_TonemapDurand cv::xphoto::createTonemapDurand(float gamma = 1.0f, float contrast = 4.0f, float saturation = 1.0f, float sigma_color = 2.0f, float sigma_space = 2.0f)
//
/**
 * Creates TonemapDurand object
 *
 * You need to set the OPENCV_ENABLE_NONFREE option in cmake to use those. Use them at your own risk.
 *
 * @param gamma gamma value for gamma correction. See createTonemap
 * @param contrast resulting contrast on logarithmic scale, i. e. log(max / min), where max and min
 * are maximum and minimum luminance values of the resulting image.
 * @param saturation saturation enhancement value. See createTonemapDrago
 * @param sigma_color bilateral filter sigma in color space
 * @param sigma_space bilateral filter sigma in coordinate space
 */
+ (TonemapDurand*)createTonemapDurand:(float)gamma contrast:(float)contrast saturation:(float)saturation sigma_color:(float)sigma_color sigma_space:(float)sigma_space NS_SWIFT_NAME(createTonemapDurand(gamma:contrast:saturation:sigma_color:sigma_space:));

/**
 * Creates TonemapDurand object
 *
 * You need to set the OPENCV_ENABLE_NONFREE option in cmake to use those. Use them at your own risk.
 *
 * @param gamma gamma value for gamma correction. See createTonemap
 * @param contrast resulting contrast on logarithmic scale, i. e. log(max / min), where max and min
 * are maximum and minimum luminance values of the resulting image.
 * @param saturation saturation enhancement value. See createTonemapDrago
 * @param sigma_color bilateral filter sigma in color space
 */
+ (TonemapDurand*)createTonemapDurand:(float)gamma contrast:(float)contrast saturation:(float)saturation sigma_color:(float)sigma_color NS_SWIFT_NAME(createTonemapDurand(gamma:contrast:saturation:sigma_color:));

/**
 * Creates TonemapDurand object
 *
 * You need to set the OPENCV_ENABLE_NONFREE option in cmake to use those. Use them at your own risk.
 *
 * @param gamma gamma value for gamma correction. See createTonemap
 * @param contrast resulting contrast on logarithmic scale, i. e. log(max / min), where max and min
 * are maximum and minimum luminance values of the resulting image.
 * @param saturation saturation enhancement value. See createTonemapDrago
 */
+ (TonemapDurand*)createTonemapDurand:(float)gamma contrast:(float)contrast saturation:(float)saturation NS_SWIFT_NAME(createTonemapDurand(gamma:contrast:saturation:));

/**
 * Creates TonemapDurand object
 *
 * You need to set the OPENCV_ENABLE_NONFREE option in cmake to use those. Use them at your own risk.
 *
 * @param gamma gamma value for gamma correction. See createTonemap
 * @param contrast resulting contrast on logarithmic scale, i. e. log(max / min), where max and min
 * are maximum and minimum luminance values of the resulting image.
 */
+ (TonemapDurand*)createTonemapDurand:(float)gamma contrast:(float)contrast NS_SWIFT_NAME(createTonemapDurand(gamma:contrast:));

/**
 * Creates TonemapDurand object
 *
 * You need to set the OPENCV_ENABLE_NONFREE option in cmake to use those. Use them at your own risk.
 *
 * @param gamma gamma value for gamma correction. See createTonemap
 * are maximum and minimum luminance values of the resulting image.
 */
+ (TonemapDurand*)createTonemapDurand:(float)gamma NS_SWIFT_NAME(createTonemapDurand(gamma:));

/**
 * Creates TonemapDurand object
 *
 * You need to set the OPENCV_ENABLE_NONFREE option in cmake to use those. Use them at your own risk.
 *
 * are maximum and minimum luminance values of the resulting image.
 */
+ (TonemapDurand*)createTonemapDurand NS_SWIFT_NAME(createTonemapDurand());


//
//  void cv::xphoto::inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
//
/**
 * The function implements different single-image inpainting algorithms.
 *
 *     See the original papers CITE: He2012 (Shiftmap) or CITE: GenserPCS2018 and CITE: SeilerTIP2015 (FSR) for details.
 *
 * @param src source image
 *     - #INPAINT_SHIFTMAP: it could be of any type and any number of channels from 1 to 4. In case of
 *     3- and 4-channels images the function expect them in CIELab colorspace or similar one, where first
 *     color component shows intensity, while second and third shows colors. Nonetheless you can try any
 *     colorspaces.
 *     - #INPAINT_FSR_BEST or #INPAINT_FSR_FAST: 1-channel grayscale or 3-channel BGR image.
 * @param mask mask (#CV_8UC1), where non-zero pixels indicate valid image area, while zero pixels
 *     indicate area to be inpainted
 * @param dst destination image
 * @param algorithmType see xphoto::InpaintTypes
 */
+ (void)inpaint:(Mat*)src mask:(Mat*)mask dst:(Mat*)dst algorithmType:(int)algorithmType NS_SWIFT_NAME(inpaint(src:mask:dst:algorithmType:));


//
//  void cv::xphoto::dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
//
/**
 * The function implements simple dct-based denoising
 *
 *     <http://www.ipol.im/pub/art/2011/ys-dct/>.
 * @param src source image
 * @param dst destination image
 * @param sigma expected noise standard deviation
 * @param psize size of block side where dct is computed
 *
 *     @sa
 *        fastNlMeansDenoising
 */
+ (void)dctDenoising:(Mat*)src dst:(Mat*)dst sigma:(double)sigma psize:(int)psize NS_SWIFT_NAME(dctDenoising(src:dst:sigma:psize:));

/**
 * The function implements simple dct-based denoising
 *
 *     <http://www.ipol.im/pub/art/2011/ys-dct/>.
 * @param src source image
 * @param dst destination image
 * @param sigma expected noise standard deviation
 *
 *     @sa
 *        fastNlMeansDenoising
 */
+ (void)dctDenoising:(Mat*)src dst:(Mat*)dst sigma:(double)sigma NS_SWIFT_NAME(dctDenoising(src:dst:sigma:));


//
//  void cv::xphoto::oilPainting(Mat src, Mat& dst, int size, int dynRatio, int code)
//
/**
 * oilPainting
 * See the book CITE: Holzmann1988 for details.
 * @param src Input three-channel or one channel image (either CV_8UC3 or CV_8UC1)
 * @param dst Output image of the same size and type as src.
 * @param size neighbouring size is 2-size+1
 * @param dynRatio image is divided by dynRatio before histogram processing
 */
+ (void)oilPainting:(Mat*)src dst:(Mat*)dst size:(int)size dynRatio:(int)dynRatio code:(int)code NS_SWIFT_NAME(oilPainting(src:dst:size:dynRatio:code:));


//
//  void cv::xphoto::oilPainting(Mat src, Mat& dst, int size, int dynRatio)
//
/**
 * oilPainting
 * See the book CITE: Holzmann1988 for details.
 * @param src Input three-channel or one channel image (either CV_8UC3 or CV_8UC1)
 * @param dst Output image of the same size and type as src.
 * @param size neighbouring size is 2-size+1
 * @param dynRatio image is divided by dynRatio before histogram processing
 */
+ (void)oilPainting:(Mat*)src dst:(Mat*)dst size:(int)size dynRatio:(int)dynRatio NS_SWIFT_NAME(oilPainting(src:dst:size:dynRatio:));


//
//  Ptr_SimpleWB cv::xphoto::createSimpleWB()
//
/**
 * Creates an instance of SimpleWB
 */
+ (SimpleWB*)createSimpleWB NS_SWIFT_NAME(createSimpleWB());


//
//  Ptr_GrayworldWB cv::xphoto::createGrayworldWB()
//
/**
 * Creates an instance of GrayworldWB
 */
+ (GrayworldWB*)createGrayworldWB NS_SWIFT_NAME(createGrayworldWB());


//
//  Ptr_LearningBasedWB cv::xphoto::createLearningBasedWB(String path_to_model = String())
//
/**
 * Creates an instance of LearningBasedWB
 *
 * @param path_to_model Path to a .yml file with the model. If not specified, the default model is used
 */
+ (LearningBasedWB*)createLearningBasedWB:(NSString*)path_to_model NS_SWIFT_NAME(createLearningBasedWB(path_to_model:));

/**
 * Creates an instance of LearningBasedWB
 *
 */
+ (LearningBasedWB*)createLearningBasedWB NS_SWIFT_NAME(createLearningBasedWB());


//
//  void cv::xphoto::applyChannelGains(Mat src, Mat& dst, float gainB, float gainG, float gainR)
//
/**
 * Implements an efficient fixed-point approximation for applying channel gains, which is
 *     the last step of multiple white balance algorithms.
 *
 * @param src Input three-channel image in the BGR color space (either CV_8UC3 or CV_16UC3)
 * @param dst Output image of the same size and type as src.
 * @param gainB gain for the B channel
 * @param gainG gain for the G channel
 * @param gainR gain for the R channel
 */
+ (void)applyChannelGains:(Mat*)src dst:(Mat*)dst gainB:(float)gainB gainG:(float)gainG gainR:(float)gainR NS_SWIFT_NAME(applyChannelGains(src:dst:gainB:gainG:gainR:));



@end

NS_ASSUME_NONNULL_END


