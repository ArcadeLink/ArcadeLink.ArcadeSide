//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/edgeboxes.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;
@class Rect2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class EdgeBoxes
/**
 * Class implementing EdgeBoxes algorithm from CITE: ZitnickECCV14edgeBoxes :
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface EdgeBoxes : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::EdgeBoxes> nativePtrEdgeBoxes;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::EdgeBoxes>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::EdgeBoxes>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::EdgeBoxes::getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes, Mat& scores = Mat())
//
/**
 * Returns array containing proposal boxes.
 *
 * @param edge_map edge image.
 * @param orientation_map orientation map.
 * @param boxes proposal boxes.
 * @param scores of the proposal boxes, provided a vector of float types.
 */
- (void)getBoundingBoxes:(Mat*)edge_map orientation_map:(Mat*)orientation_map boxes:(NSMutableArray<Rect2i*>*)boxes scores:(Mat*)scores NS_SWIFT_NAME(getBoundingBoxes(edge_map:orientation_map:boxes:scores:));

/**
 * Returns array containing proposal boxes.
 *
 * @param edge_map edge image.
 * @param orientation_map orientation map.
 * @param boxes proposal boxes.
 */
- (void)getBoundingBoxes:(Mat*)edge_map orientation_map:(Mat*)orientation_map boxes:(NSMutableArray<Rect2i*>*)boxes NS_SWIFT_NAME(getBoundingBoxes(edge_map:orientation_map:boxes:));


//
//  float cv::ximgproc::EdgeBoxes::getAlpha()
//
/**
 * Returns the step size of sliding window search.
 */
- (float)getAlpha NS_SWIFT_NAME(getAlpha());


//
//  void cv::ximgproc::EdgeBoxes::setAlpha(float value)
//
/**
 * Sets the step size of sliding window search.
 */
- (void)setAlpha:(float)value NS_SWIFT_NAME(setAlpha(value:));


//
//  float cv::ximgproc::EdgeBoxes::getBeta()
//
/**
 * Returns the nms threshold for object proposals.
 */
- (float)getBeta NS_SWIFT_NAME(getBeta());


//
//  void cv::ximgproc::EdgeBoxes::setBeta(float value)
//
/**
 * Sets the nms threshold for object proposals.
 */
- (void)setBeta:(float)value NS_SWIFT_NAME(setBeta(value:));


//
//  float cv::ximgproc::EdgeBoxes::getEta()
//
/**
 * Returns adaptation rate for nms threshold.
 */
- (float)getEta NS_SWIFT_NAME(getEta());


//
//  void cv::ximgproc::EdgeBoxes::setEta(float value)
//
/**
 * Sets the adaptation rate for nms threshold.
 */
- (void)setEta:(float)value NS_SWIFT_NAME(setEta(value:));


//
//  float cv::ximgproc::EdgeBoxes::getMinScore()
//
/**
 * Returns the min score of boxes to detect.
 */
- (float)getMinScore NS_SWIFT_NAME(getMinScore());


//
//  void cv::ximgproc::EdgeBoxes::setMinScore(float value)
//
/**
 * Sets the min score of boxes to detect.
 */
- (void)setMinScore:(float)value NS_SWIFT_NAME(setMinScore(value:));


//
//  int cv::ximgproc::EdgeBoxes::getMaxBoxes()
//
/**
 * Returns the max number of boxes to detect.
 */
- (int)getMaxBoxes NS_SWIFT_NAME(getMaxBoxes());


//
//  void cv::ximgproc::EdgeBoxes::setMaxBoxes(int value)
//
/**
 * Sets max number of boxes to detect.
 */
- (void)setMaxBoxes:(int)value NS_SWIFT_NAME(setMaxBoxes(value:));


//
//  float cv::ximgproc::EdgeBoxes::getEdgeMinMag()
//
/**
 * Returns the edge min magnitude.
 */
- (float)getEdgeMinMag NS_SWIFT_NAME(getEdgeMinMag());


//
//  void cv::ximgproc::EdgeBoxes::setEdgeMinMag(float value)
//
/**
 * Sets the edge min magnitude.
 */
- (void)setEdgeMinMag:(float)value NS_SWIFT_NAME(setEdgeMinMag(value:));


//
//  float cv::ximgproc::EdgeBoxes::getEdgeMergeThr()
//
/**
 * Returns the edge merge threshold.
 */
- (float)getEdgeMergeThr NS_SWIFT_NAME(getEdgeMergeThr());


//
//  void cv::ximgproc::EdgeBoxes::setEdgeMergeThr(float value)
//
/**
 * Sets the edge merge threshold.
 */
- (void)setEdgeMergeThr:(float)value NS_SWIFT_NAME(setEdgeMergeThr(value:));


//
//  float cv::ximgproc::EdgeBoxes::getClusterMinMag()
//
/**
 * Returns the cluster min magnitude.
 */
- (float)getClusterMinMag NS_SWIFT_NAME(getClusterMinMag());


//
//  void cv::ximgproc::EdgeBoxes::setClusterMinMag(float value)
//
/**
 * Sets the cluster min magnitude.
 */
- (void)setClusterMinMag:(float)value NS_SWIFT_NAME(setClusterMinMag(value:));


//
//  float cv::ximgproc::EdgeBoxes::getMaxAspectRatio()
//
/**
 * Returns the max aspect ratio of boxes.
 */
- (float)getMaxAspectRatio NS_SWIFT_NAME(getMaxAspectRatio());


//
//  void cv::ximgproc::EdgeBoxes::setMaxAspectRatio(float value)
//
/**
 * Sets the max aspect ratio of boxes.
 */
- (void)setMaxAspectRatio:(float)value NS_SWIFT_NAME(setMaxAspectRatio(value:));


//
//  float cv::ximgproc::EdgeBoxes::getMinBoxArea()
//
/**
 * Returns the minimum area of boxes.
 */
- (float)getMinBoxArea NS_SWIFT_NAME(getMinBoxArea());


//
//  void cv::ximgproc::EdgeBoxes::setMinBoxArea(float value)
//
/**
 * Sets the minimum area of boxes.
 */
- (void)setMinBoxArea:(float)value NS_SWIFT_NAME(setMinBoxArea(value:));


//
//  float cv::ximgproc::EdgeBoxes::getGamma()
//
/**
 * Returns the affinity sensitivity.
 */
- (float)getGamma NS_SWIFT_NAME(getGamma());


//
//  void cv::ximgproc::EdgeBoxes::setGamma(float value)
//
/**
 * Sets the affinity sensitivity
 */
- (void)setGamma:(float)value NS_SWIFT_NAME(setGamma(value:));


//
//  float cv::ximgproc::EdgeBoxes::getKappa()
//
/**
 * Returns the scale sensitivity.
 */
- (float)getKappa NS_SWIFT_NAME(getKappa());


//
//  void cv::ximgproc::EdgeBoxes::setKappa(float value)
//
/**
 * Sets the scale sensitivity.
 */
- (void)setKappa:(float)value NS_SWIFT_NAME(setKappa(value:));



@end

NS_ASSUME_NONNULL_END


