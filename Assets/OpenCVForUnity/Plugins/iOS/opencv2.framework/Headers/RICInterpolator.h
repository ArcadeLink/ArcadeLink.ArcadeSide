//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/sparse_match_interpolator.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "SparseMatchInterpolator.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class RICInterpolator
/**
 * Sparse match interpolation algorithm based on modified piecewise locally-weighted affine
 * estimator called Robust Interpolation method of Correspondences or RIC from CITE: Hu2017 and Variational
 * and Fast Global Smoother as post-processing filter. The RICInterpolator is a extension of the EdgeAwareInterpolator.
 * Main concept of this extension is an piece-wise affine model based on over-segmentation via SLIC superpixel estimation.
 * The method contains an efficient propagation mechanism to estimate among the pieces-wise models.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface RICInterpolator : SparseMatchInterpolator


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::RICInterpolator> nativePtrRICInterpolator;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::RICInterpolator>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::RICInterpolator>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::RICInterpolator::setK(int k = 32)
//
/**
 * K is a number of nearest-neighbor matches considered, when fitting a locally affine
 * model for a superpixel segment. However, lower values would make the interpolation
 * noticeably faster. The original implementation of CITE: Hu2017 uses 32.
 */
- (void)setK:(int)k NS_SWIFT_NAME(setK(k:));

/**
 * K is a number of nearest-neighbor matches considered, when fitting a locally affine
 * model for a superpixel segment. However, lower values would make the interpolation
 * noticeably faster. The original implementation of CITE: Hu2017 uses 32.
 */
- (void)setK NS_SWIFT_NAME(setK());


//
//  int cv::ximgproc::RICInterpolator::getK()
//
/**
 *  setK
 * @see `-setK:`
 */
- (int)getK NS_SWIFT_NAME(getK());


//
//  void cv::ximgproc::RICInterpolator::setCostMap(Mat costMap)
//
/**
 * Interface to provide a more elaborated cost map, i.e. edge map, for the edge-aware term.
 * This implementation is based on a rather simple gradient-based edge map estimation.
 * To used more complex edge map estimator (e.g. StructuredEdgeDetection that has been
 * used in the original publication) that may lead to improved accuracies, the internal
 * edge map estimation can be bypassed here.
 * @param costMap a type CV_32FC1 Mat is required.
 * @see `cv::ximgproc::createSuperpixelSLIC`
 */
- (void)setCostMap:(Mat*)costMap NS_SWIFT_NAME(setCostMap(costMap:));


//
//  void cv::ximgproc::RICInterpolator::setSuperpixelSize(int spSize = 15)
//
/**
 * Get the internal cost, i.e. edge map, used for estimating the edge-aware term.
 * @see `-setCostMap:`
 */
- (void)setSuperpixelSize:(int)spSize NS_SWIFT_NAME(setSuperpixelSize(spSize:));

/**
 * Get the internal cost, i.e. edge map, used for estimating the edge-aware term.
 * @see `-setCostMap:`
 */
- (void)setSuperpixelSize NS_SWIFT_NAME(setSuperpixelSize());


//
//  int cv::ximgproc::RICInterpolator::getSuperpixelSize()
//
/**
 *  setSuperpixelSize
 * @see `-setSuperpixelSize:`
 */
- (int)getSuperpixelSize NS_SWIFT_NAME(getSuperpixelSize());


//
//  void cv::ximgproc::RICInterpolator::setSuperpixelNNCnt(int spNN = 150)
//
/**
 * Parameter defines the number of nearest-neighbor matches for each superpixel considered, when fitting a locally affine
 * model.
 */
- (void)setSuperpixelNNCnt:(int)spNN NS_SWIFT_NAME(setSuperpixelNNCnt(spNN:));

/**
 * Parameter defines the number of nearest-neighbor matches for each superpixel considered, when fitting a locally affine
 * model.
 */
- (void)setSuperpixelNNCnt NS_SWIFT_NAME(setSuperpixelNNCnt());


//
//  int cv::ximgproc::RICInterpolator::getSuperpixelNNCnt()
//
/**
 *  setSuperpixelNNCnt
 * @see `-setSuperpixelNNCnt:`
 */
- (int)getSuperpixelNNCnt NS_SWIFT_NAME(getSuperpixelNNCnt());


//
//  void cv::ximgproc::RICInterpolator::setSuperpixelRuler(float ruler = 15.f)
//
/**
 * Parameter to tune enforcement of superpixel smoothness factor used for oversegmentation.
 * @see `cv::ximgproc::createSuperpixelSLIC`
 */
- (void)setSuperpixelRuler:(float)ruler NS_SWIFT_NAME(setSuperpixelRuler(ruler:));

/**
 * Parameter to tune enforcement of superpixel smoothness factor used for oversegmentation.
 * @see `cv::ximgproc::createSuperpixelSLIC`
 */
- (void)setSuperpixelRuler NS_SWIFT_NAME(setSuperpixelRuler());


//
//  float cv::ximgproc::RICInterpolator::getSuperpixelRuler()
//
/**
 *  setSuperpixelRuler
 * @see `-setSuperpixelRuler:`
 */
- (float)getSuperpixelRuler NS_SWIFT_NAME(getSuperpixelRuler());


//
//  void cv::ximgproc::RICInterpolator::setSuperpixelMode(int mode = 100)
//
/**
 * Parameter to choose superpixel algorithm variant to use:
 * - cv::ximgproc::SLICType SLIC segments image using a desired region_size (value: 100)
 * - cv::ximgproc::SLICType SLICO will optimize using adaptive compactness factor (value: 101)
 * - cv::ximgproc::SLICType MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels (value: 102).
 * @see `cv::ximgproc::createSuperpixelSLIC`
 */
- (void)setSuperpixelMode:(int)mode NS_SWIFT_NAME(setSuperpixelMode(mode:));

/**
 * Parameter to choose superpixel algorithm variant to use:
 * - cv::ximgproc::SLICType SLIC segments image using a desired region_size (value: 100)
 * - cv::ximgproc::SLICType SLICO will optimize using adaptive compactness factor (value: 101)
 * - cv::ximgproc::SLICType MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels (value: 102).
 * @see `cv::ximgproc::createSuperpixelSLIC`
 */
- (void)setSuperpixelMode NS_SWIFT_NAME(setSuperpixelMode());


//
//  int cv::ximgproc::RICInterpolator::getSuperpixelMode()
//
/**
 *  setSuperpixelMode
 * @see `-setSuperpixelMode:`
 */
- (int)getSuperpixelMode NS_SWIFT_NAME(getSuperpixelMode());


//
//  void cv::ximgproc::RICInterpolator::setAlpha(float alpha = 0.7f)
//
/**
 * Alpha is a parameter defining a global weight for transforming geodesic distance into weight.
 */
- (void)setAlpha:(float)alpha NS_SWIFT_NAME(setAlpha(alpha:));

/**
 * Alpha is a parameter defining a global weight for transforming geodesic distance into weight.
 */
- (void)setAlpha NS_SWIFT_NAME(setAlpha());


//
//  float cv::ximgproc::RICInterpolator::getAlpha()
//
/**
 *  setAlpha
 * @see `-setAlpha:`
 */
- (float)getAlpha NS_SWIFT_NAME(getAlpha());


//
//  void cv::ximgproc::RICInterpolator::setModelIter(int modelIter = 4)
//
/**
 * Parameter defining the number of iterations for piece-wise affine model estimation.
 */
- (void)setModelIter:(int)modelIter NS_SWIFT_NAME(setModelIter(modelIter:));

/**
 * Parameter defining the number of iterations for piece-wise affine model estimation.
 */
- (void)setModelIter NS_SWIFT_NAME(setModelIter());


//
//  int cv::ximgproc::RICInterpolator::getModelIter()
//
/**
 *  setModelIter
 * @see `-setModelIter:`
 */
- (int)getModelIter NS_SWIFT_NAME(getModelIter());


//
//  void cv::ximgproc::RICInterpolator::setRefineModels(bool refineModles = true)
//
/**
 * Parameter to choose wether additional refinement of the piece-wise affine models is employed.
 */
- (void)setRefineModels:(BOOL)refineModles NS_SWIFT_NAME(setRefineModels(refineModles:));

/**
 * Parameter to choose wether additional refinement of the piece-wise affine models is employed.
 */
- (void)setRefineModels NS_SWIFT_NAME(setRefineModels());


//
//  bool cv::ximgproc::RICInterpolator::getRefineModels()
//
/**
 *  setRefineModels
 * @see `-setRefineModels:`
 */
- (BOOL)getRefineModels NS_SWIFT_NAME(getRefineModels());


//
//  void cv::ximgproc::RICInterpolator::setMaxFlow(float maxFlow = 250.f)
//
/**
 * MaxFlow is a threshold to validate the predictions using a certain piece-wise affine model.
 * If the prediction exceeds the treshold the translational model will be applied instead.
 */
- (void)setMaxFlow:(float)maxFlow NS_SWIFT_NAME(setMaxFlow(maxFlow:));

/**
 * MaxFlow is a threshold to validate the predictions using a certain piece-wise affine model.
 * If the prediction exceeds the treshold the translational model will be applied instead.
 */
- (void)setMaxFlow NS_SWIFT_NAME(setMaxFlow());


//
//  float cv::ximgproc::RICInterpolator::getMaxFlow()
//
/**
 *  setMaxFlow
 * @see `-setMaxFlow:`
 */
- (float)getMaxFlow NS_SWIFT_NAME(getMaxFlow());


//
//  void cv::ximgproc::RICInterpolator::setUseVariationalRefinement(bool use_variational_refinement = false)
//
/**
 * Parameter to choose wether the VariationalRefinement post-processing  is employed.
 */
- (void)setUseVariationalRefinement:(BOOL)use_variational_refinement NS_SWIFT_NAME(setUseVariationalRefinement(use_variational_refinement:));

/**
 * Parameter to choose wether the VariationalRefinement post-processing  is employed.
 */
- (void)setUseVariationalRefinement NS_SWIFT_NAME(setUseVariationalRefinement());


//
//  bool cv::ximgproc::RICInterpolator::getUseVariationalRefinement()
//
/**
 *  setUseVariationalRefinement
 * @see `-setUseVariationalRefinement:`
 */
- (BOOL)getUseVariationalRefinement NS_SWIFT_NAME(getUseVariationalRefinement());


//
//  void cv::ximgproc::RICInterpolator::setUseGlobalSmootherFilter(bool use_FGS = true)
//
/**
 * Sets whether the fastGlobalSmootherFilter() post-processing is employed.
 */
- (void)setUseGlobalSmootherFilter:(BOOL)use_FGS NS_SWIFT_NAME(setUseGlobalSmootherFilter(use_FGS:));

/**
 * Sets whether the fastGlobalSmootherFilter() post-processing is employed.
 */
- (void)setUseGlobalSmootherFilter NS_SWIFT_NAME(setUseGlobalSmootherFilter());


//
//  bool cv::ximgproc::RICInterpolator::getUseGlobalSmootherFilter()
//
/**
 *  setUseGlobalSmootherFilter
 * @see `-setUseGlobalSmootherFilter:`
 */
- (BOOL)getUseGlobalSmootherFilter NS_SWIFT_NAME(getUseGlobalSmootherFilter());


//
//  void cv::ximgproc::RICInterpolator::setFGSLambda(float lambda = 500.f)
//
/**
 * Sets the respective fastGlobalSmootherFilter() parameter.
 */
- (void)setFGSLambda:(float)lambda NS_SWIFT_NAME(setFGSLambda(lambda:));

/**
 * Sets the respective fastGlobalSmootherFilter() parameter.
 */
- (void)setFGSLambda NS_SWIFT_NAME(setFGSLambda());


//
//  float cv::ximgproc::RICInterpolator::getFGSLambda()
//
/**
 *  setFGSLambda
 * @see `-setFGSLambda:`
 */
- (float)getFGSLambda NS_SWIFT_NAME(getFGSLambda());


//
//  void cv::ximgproc::RICInterpolator::setFGSSigma(float sigma = 1.5f)
//
/**
 * Sets the respective fastGlobalSmootherFilter() parameter.
 */
- (void)setFGSSigma:(float)sigma NS_SWIFT_NAME(setFGSSigma(sigma:));

/**
 * Sets the respective fastGlobalSmootherFilter() parameter.
 */
- (void)setFGSSigma NS_SWIFT_NAME(setFGSSigma());


//
//  float cv::ximgproc::RICInterpolator::getFGSSigma()
//
/**
 *  setFGSSigma
 * @see `-setFGSSigma:`
 */
- (float)getFGSSigma NS_SWIFT_NAME(getFGSSigma());



@end

NS_ASSUME_NONNULL_END


