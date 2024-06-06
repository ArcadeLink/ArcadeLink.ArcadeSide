//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/segmentation.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class GraphSegmentation;
@class Mat;
@class Rect2i;
@class SelectiveSearchSegmentationStrategy;



NS_ASSUME_NONNULL_BEGIN

// C++: class SelectiveSearchSegmentation
/**
 * Selective search segmentation algorithm
 *                         The class implements the algorithm described in CITE: uijlings2013selective.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SelectiveSearchSegmentation : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentation> nativePtrSelectiveSearchSegmentation;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentation>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentation>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::setBaseImage(Mat img)
//
/**
 * Set a image used by switch* functions to initialize the class
 * @param img The image
 */
- (void)setBaseImage:(Mat*)img NS_SWIFT_NAME(setBaseImage(img:));


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSingleStrategy(int k = 200, float sigma = 0.8f)
//
/**
 * Initialize the class with the 'Single stragegy' parameters describled in CITE: uijlings2013selective.
 * @param k The k parameter for the graph segmentation
 * @param sigma The sigma parameter for the graph segmentation
 */
- (void)switchToSingleStrategy:(int)k sigma:(float)sigma NS_SWIFT_NAME(switchToSingleStrategy(k:sigma:));

/**
 * Initialize the class with the 'Single stragegy' parameters describled in CITE: uijlings2013selective.
 * @param k The k parameter for the graph segmentation
 */
- (void)switchToSingleStrategy:(int)k NS_SWIFT_NAME(switchToSingleStrategy(k:));

/**
 * Initialize the class with the 'Single stragegy' parameters describled in CITE: uijlings2013selective.
 */
- (void)switchToSingleStrategy NS_SWIFT_NAME(switchToSingleStrategy());


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchFast(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
//
/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 * @param base_k The k parameter for the first graph segmentation
 * @param inc_k The increment of the k parameter for all graph segmentations
 * @param sigma The sigma parameter for the graph segmentation
 */
- (void)switchToSelectiveSearchFast:(int)base_k inc_k:(int)inc_k sigma:(float)sigma NS_SWIFT_NAME(switchToSelectiveSearchFast(base_k:inc_k:sigma:));

/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 * @param base_k The k parameter for the first graph segmentation
 * @param inc_k The increment of the k parameter for all graph segmentations
 */
- (void)switchToSelectiveSearchFast:(int)base_k inc_k:(int)inc_k NS_SWIFT_NAME(switchToSelectiveSearchFast(base_k:inc_k:));

/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 * @param base_k The k parameter for the first graph segmentation
 */
- (void)switchToSelectiveSearchFast:(int)base_k NS_SWIFT_NAME(switchToSelectiveSearchFast(base_k:));

/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 */
- (void)switchToSelectiveSearchFast NS_SWIFT_NAME(switchToSelectiveSearchFast());


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchQuality(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
//
/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 * @param base_k The k parameter for the first graph segmentation
 * @param inc_k The increment of the k parameter for all graph segmentations
 * @param sigma The sigma parameter for the graph segmentation
 */
- (void)switchToSelectiveSearchQuality:(int)base_k inc_k:(int)inc_k sigma:(float)sigma NS_SWIFT_NAME(switchToSelectiveSearchQuality(base_k:inc_k:sigma:));

/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 * @param base_k The k parameter for the first graph segmentation
 * @param inc_k The increment of the k parameter for all graph segmentations
 */
- (void)switchToSelectiveSearchQuality:(int)base_k inc_k:(int)inc_k NS_SWIFT_NAME(switchToSelectiveSearchQuality(base_k:inc_k:));

/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 * @param base_k The k parameter for the first graph segmentation
 */
- (void)switchToSelectiveSearchQuality:(int)base_k NS_SWIFT_NAME(switchToSelectiveSearchQuality(base_k:));

/**
 * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
 */
- (void)switchToSelectiveSearchQuality NS_SWIFT_NAME(switchToSelectiveSearchQuality());


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addImage(Mat img)
//
/**
 * Add a new image in the list of images to process.
 * @param img The image
 */
- (void)addImage:(Mat*)img NS_SWIFT_NAME(addImage(img:));


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearImages()
//
/**
 * Clear the list of images to process
 */
- (void)clearImages NS_SWIFT_NAME(clearImages());


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addGraphSegmentation(Ptr_GraphSegmentation g)
//
/**
 * Add a new graph segmentation in the list of graph segementations to process.
 * @param g The graph segmentation
 */
- (void)addGraphSegmentation:(GraphSegmentation*)g NS_SWIFT_NAME(addGraphSegmentation(g:));


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearGraphSegmentations()
//
/**
 * Clear the list of graph segmentations to process;
 */
- (void)clearGraphSegmentations NS_SWIFT_NAME(clearGraphSegmentations());


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addStrategy(Ptr_SelectiveSearchSegmentationStrategy s)
//
/**
 * Add a new strategy in the list of strategy to process.
 * @param s The strategy
 */
- (void)addStrategy:(SelectiveSearchSegmentationStrategy*)s NS_SWIFT_NAME(addStrategy(s:));


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearStrategies()
//
/**
 * Clear the list of strategy to process;
 */
- (void)clearStrategies NS_SWIFT_NAME(clearStrategies());


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::process(vector_Rect& rects)
//
/**
 * Based on all images, graph segmentations and stragies, computes all possible rects and return them
 * @param rects The list of rects. The first ones are more relevents than the lasts ones.
 */
- (void)process:(NSMutableArray<Rect2i*>*)rects NS_SWIFT_NAME(process(rects:));



@end

NS_ASSUME_NONNULL_END


