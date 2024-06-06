//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/facerec.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "FaceRecognizer.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class LBPHFaceRecognizer
/**
 * The LBPHFaceRecognizer module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface LBPHFaceRecognizer : FaceRecognizer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::LBPHFaceRecognizer> nativePtrLBPHFaceRecognizer;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::LBPHFaceRecognizer>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::LBPHFaceRecognizer>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::face::LBPHFaceRecognizer::getGridX()
//
/**
 * @see `-setGridX:`
 */
- (int)getGridX NS_SWIFT_NAME(getGridX());


//
//  void cv::face::LBPHFaceRecognizer::setGridX(int val)
//
/**
 *  getGridX @see `-getGridX:`
 */
- (void)setGridX:(int)val NS_SWIFT_NAME(setGridX(val:));


//
//  int cv::face::LBPHFaceRecognizer::getGridY()
//
/**
 * @see `-setGridY:`
 */
- (int)getGridY NS_SWIFT_NAME(getGridY());


//
//  void cv::face::LBPHFaceRecognizer::setGridY(int val)
//
/**
 *  getGridY @see `-getGridY:`
 */
- (void)setGridY:(int)val NS_SWIFT_NAME(setGridY(val:));


//
//  int cv::face::LBPHFaceRecognizer::getRadius()
//
/**
 * @see `-setRadius:`
 */
- (int)getRadius NS_SWIFT_NAME(getRadius());


//
//  void cv::face::LBPHFaceRecognizer::setRadius(int val)
//
/**
 *  getRadius @see `-getRadius:`
 */
- (void)setRadius:(int)val NS_SWIFT_NAME(setRadius(val:));


//
//  int cv::face::LBPHFaceRecognizer::getNeighbors()
//
/**
 * @see `-setNeighbors:`
 */
- (int)getNeighbors NS_SWIFT_NAME(getNeighbors());


//
//  void cv::face::LBPHFaceRecognizer::setNeighbors(int val)
//
/**
 *  getNeighbors @see `-getNeighbors:`
 */
- (void)setNeighbors:(int)val NS_SWIFT_NAME(setNeighbors(val:));


//
//  double cv::face::LBPHFaceRecognizer::getThreshold()
//
/**
 * @see `-setThreshold:`
 */
- (double)getThreshold NS_SWIFT_NAME(getThreshold());


//
//  void cv::face::LBPHFaceRecognizer::setThreshold(double val)
//
/**
 *  getThreshold @see `-getThreshold:`
 */
- (void)setThreshold:(double)val NS_SWIFT_NAME(setThreshold(val:));


//
//  vector_Mat cv::face::LBPHFaceRecognizer::getHistograms()
//
- (NSArray<Mat*>*)getHistograms NS_SWIFT_NAME(getHistograms());


//
//  Mat cv::face::LBPHFaceRecognizer::getLabels()
//
- (Mat*)getLabels NS_SWIFT_NAME(getLabels());


//
// static Ptr_LBPHFaceRecognizer cv::face::LBPHFaceRecognizer::create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
//
/**
 * @param radius The radius used for building the Circular Local Binary Pattern. The greater the
 *     radius, the smoother the image but more spatial information you can get.
 * @param neighbors The number of sample points to build a Circular Local Binary Pattern from. An
 *     appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
 *     the higher the computational cost.
 * @param grid_x The number of cells in the horizontal direction, 8 is a common value used in
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 * @param grid_y The number of cells in the vertical direction, 8 is a common value used in
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 * @param threshold The threshold applied in the prediction. If the distance to the nearest neighbor
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
 *         grayscale images, use cvtColor to convert between the color spaces.
 *     -   This model supports updating.
 *
 *     ### Model internal data:
 *
 *     -   radius see LBPHFaceRecognizer::create.
 *     -   neighbors see LBPHFaceRecognizer::create.
 *     -   grid_x see LLBPHFaceRecognizer::create.
 *     -   grid_y see LBPHFaceRecognizer::create.
 *     -   threshold see LBPHFaceRecognizer::create.
 *     -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
 *         none was given).
 *     -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
 */
+ (LBPHFaceRecognizer*)create:(int)radius neighbors:(int)neighbors grid_x:(int)grid_x grid_y:(int)grid_y threshold:(double)threshold NS_SWIFT_NAME(create(radius:neighbors:grid_x:grid_y:threshold:));

/**
 * @param radius The radius used for building the Circular Local Binary Pattern. The greater the
 *     radius, the smoother the image but more spatial information you can get.
 * @param neighbors The number of sample points to build a Circular Local Binary Pattern from. An
 *     appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
 *     the higher the computational cost.
 * @param grid_x The number of cells in the horizontal direction, 8 is a common value used in
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 * @param grid_y The number of cells in the vertical direction, 8 is a common value used in
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
 *         grayscale images, use cvtColor to convert between the color spaces.
 *     -   This model supports updating.
 *
 *     ### Model internal data:
 *
 *     -   radius see LBPHFaceRecognizer::create.
 *     -   neighbors see LBPHFaceRecognizer::create.
 *     -   grid_x see LLBPHFaceRecognizer::create.
 *     -   grid_y see LBPHFaceRecognizer::create.
 *     -   threshold see LBPHFaceRecognizer::create.
 *     -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
 *         none was given).
 *     -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
 */
+ (LBPHFaceRecognizer*)create:(int)radius neighbors:(int)neighbors grid_x:(int)grid_x grid_y:(int)grid_y NS_SWIFT_NAME(create(radius:neighbors:grid_x:grid_y:));

/**
 * @param radius The radius used for building the Circular Local Binary Pattern. The greater the
 *     radius, the smoother the image but more spatial information you can get.
 * @param neighbors The number of sample points to build a Circular Local Binary Pattern from. An
 *     appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
 *     the higher the computational cost.
 * @param grid_x The number of cells in the horizontal direction, 8 is a common value used in
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
 *         grayscale images, use cvtColor to convert between the color spaces.
 *     -   This model supports updating.
 *
 *     ### Model internal data:
 *
 *     -   radius see LBPHFaceRecognizer::create.
 *     -   neighbors see LBPHFaceRecognizer::create.
 *     -   grid_x see LLBPHFaceRecognizer::create.
 *     -   grid_y see LBPHFaceRecognizer::create.
 *     -   threshold see LBPHFaceRecognizer::create.
 *     -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
 *         none was given).
 *     -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
 */
+ (LBPHFaceRecognizer*)create:(int)radius neighbors:(int)neighbors grid_x:(int)grid_x NS_SWIFT_NAME(create(radius:neighbors:grid_x:));

/**
 * @param radius The radius used for building the Circular Local Binary Pattern. The greater the
 *     radius, the smoother the image but more spatial information you can get.
 * @param neighbors The number of sample points to build a Circular Local Binary Pattern from. An
 *     appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
 *     the higher the computational cost.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
 *         grayscale images, use cvtColor to convert between the color spaces.
 *     -   This model supports updating.
 *
 *     ### Model internal data:
 *
 *     -   radius see LBPHFaceRecognizer::create.
 *     -   neighbors see LBPHFaceRecognizer::create.
 *     -   grid_x see LLBPHFaceRecognizer::create.
 *     -   grid_y see LBPHFaceRecognizer::create.
 *     -   threshold see LBPHFaceRecognizer::create.
 *     -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
 *         none was given).
 *     -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
 */
+ (LBPHFaceRecognizer*)create:(int)radius neighbors:(int)neighbors NS_SWIFT_NAME(create(radius:neighbors:));

/**
 * @param radius The radius used for building the Circular Local Binary Pattern. The greater the
 *     radius, the smoother the image but more spatial information you can get.
 *     appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
 *     the higher the computational cost.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
 *         grayscale images, use cvtColor to convert between the color spaces.
 *     -   This model supports updating.
 *
 *     ### Model internal data:
 *
 *     -   radius see LBPHFaceRecognizer::create.
 *     -   neighbors see LBPHFaceRecognizer::create.
 *     -   grid_x see LLBPHFaceRecognizer::create.
 *     -   grid_y see LBPHFaceRecognizer::create.
 *     -   threshold see LBPHFaceRecognizer::create.
 *     -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
 *         none was given).
 *     -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
 */
+ (LBPHFaceRecognizer*)create:(int)radius NS_SWIFT_NAME(create(radius:));

/**
 *     radius, the smoother the image but more spatial information you can get.
 *     appropriate value is to use `8` sample points. Keep in mind: the more sample points you include,
 *     the higher the computational cost.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     publications. The more cells, the finer the grid, the higher the dimensionality of the resulting
 *     feature vector.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   The Circular Local Binary Patterns (used in training and prediction) expect the data given as
 *         grayscale images, use cvtColor to convert between the color spaces.
 *     -   This model supports updating.
 *
 *     ### Model internal data:
 *
 *     -   radius see LBPHFaceRecognizer::create.
 *     -   neighbors see LBPHFaceRecognizer::create.
 *     -   grid_x see LLBPHFaceRecognizer::create.
 *     -   grid_y see LBPHFaceRecognizer::create.
 *     -   threshold see LBPHFaceRecognizer::create.
 *     -   histograms Local Binary Patterns Histograms calculated from the given training data (empty if
 *         none was given).
 *     -   labels Labels corresponding to the calculated Local Binary Patterns Histograms.
 */
+ (LBPHFaceRecognizer*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


