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

// C++: class EdgeAwareInterpolator
/**
 * Sparse match interpolation algorithm based on modified locally-weighted affine
 * estimator from CITE: Revaud2015 and Fast Global Smoother as post-processing filter.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface EdgeAwareInterpolator : SparseMatchInterpolator


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::EdgeAwareInterpolator> nativePtrEdgeAwareInterpolator;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::EdgeAwareInterpolator>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::EdgeAwareInterpolator>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::EdgeAwareInterpolator::setCostMap(Mat _costMap)
//
/**
 * Interface to provide a more elaborated cost map, i.e. edge map, for the edge-aware term.
 * This implementation is based on a rather simple gradient-based edge map estimation.
 * To used more complex edge map estimator (e.g. StructuredEdgeDetection that has been
 * used in the original publication) that may lead to improved accuracies, the internal
 * edge map estimation can be bypassed here.
 * @param _costMap a type CV_32FC1 Mat is required.
 * @see `cv::ximgproc::createSuperpixelSLIC`
 */
- (void)setCostMap:(Mat*)_costMap NS_SWIFT_NAME(setCostMap(_costMap:));


//
//  void cv::ximgproc::EdgeAwareInterpolator::setK(int _k)
//
/**
 * K is a number of nearest-neighbor matches considered, when fitting a locally affine
 *     model. Usually it should be around 128. However, lower values would make the interpolation
 *     noticeably faster.
 */
- (void)setK:(int)_k NS_SWIFT_NAME(setK(_k:));


//
//  int cv::ximgproc::EdgeAwareInterpolator::getK()
//
/**
 * @see `-setK:`
 */
- (int)getK NS_SWIFT_NAME(getK());


//
//  void cv::ximgproc::EdgeAwareInterpolator::setSigma(float _sigma)
//
/**
 * Sigma is a parameter defining how fast the weights decrease in the locally-weighted affine
 *     fitting. Higher values can help preserve fine details, lower values can help to get rid of noise in the
 *     output flow.
 */
- (void)setSigma:(float)_sigma NS_SWIFT_NAME(setSigma(_sigma:));


//
//  float cv::ximgproc::EdgeAwareInterpolator::getSigma()
//
/**
 * @see `-setSigma:`
 */
- (float)getSigma NS_SWIFT_NAME(getSigma());


//
//  void cv::ximgproc::EdgeAwareInterpolator::setLambda(float _lambda)
//
/**
 * Lambda is a parameter defining the weight of the edge-aware term in geodesic distance,
 *     should be in the range of 0 to 1000.
 */
- (void)setLambda:(float)_lambda NS_SWIFT_NAME(setLambda(_lambda:));


//
//  float cv::ximgproc::EdgeAwareInterpolator::getLambda()
//
/**
 * @see `-setLambda:`
 */
- (float)getLambda NS_SWIFT_NAME(getLambda());


//
//  void cv::ximgproc::EdgeAwareInterpolator::setUsePostProcessing(bool _use_post_proc)
//
/**
 * Sets whether the fastGlobalSmootherFilter() post-processing is employed. It is turned on by
 *     default.
 */
- (void)setUsePostProcessing:(BOOL)_use_post_proc NS_SWIFT_NAME(setUsePostProcessing(_use_post_proc:));


//
//  bool cv::ximgproc::EdgeAwareInterpolator::getUsePostProcessing()
//
/**
 * @see `-setUsePostProcessing:`
 */
- (BOOL)getUsePostProcessing NS_SWIFT_NAME(getUsePostProcessing());


//
//  void cv::ximgproc::EdgeAwareInterpolator::setFGSLambda(float _lambda)
//
/**
 * Sets the respective fastGlobalSmootherFilter() parameter.
 */
- (void)setFGSLambda:(float)_lambda NS_SWIFT_NAME(setFGSLambda(_lambda:));


//
//  float cv::ximgproc::EdgeAwareInterpolator::getFGSLambda()
//
/**
 * @see `-setFGSLambda:`
 */
- (float)getFGSLambda NS_SWIFT_NAME(getFGSLambda());


//
//  void cv::ximgproc::EdgeAwareInterpolator::setFGSSigma(float _sigma)
//
/**
 * @see `-setFGSLambda:`
 */
- (void)setFGSSigma:(float)_sigma NS_SWIFT_NAME(setFGSSigma(_sigma:));


//
//  float cv::ximgproc::EdgeAwareInterpolator::getFGSSigma()
//
/**
 * @see `-setFGSLambda:`
 */
- (float)getFGSSigma NS_SWIFT_NAME(getFGSSigma());



@end

NS_ASSUME_NONNULL_END


