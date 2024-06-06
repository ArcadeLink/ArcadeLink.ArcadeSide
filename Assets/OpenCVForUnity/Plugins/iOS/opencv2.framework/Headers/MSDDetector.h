//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xfeatures2d.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Feature2D.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class MSDDetector
/**
 * Class implementing the MSD (*Maximal Self-Dissimilarity*) keypoint detector, described in CITE: Tombari14.
 *
 * The algorithm implements a novel interest point detector stemming from the intuition that image patches
 * which are highly dissimilar over a relatively large extent of their surroundings hold the property of
 * being repeatable and distinctive. This concept of "contextual self-dissimilarity" reverses the key
 * paradigm of recent successful techniques such as the Local Self-Similarity descriptor and the Non-Local
 * Means filter, which build upon the presence of similar - rather than dissimilar - patches. Moreover,
 * it extends to contextual information the local self-dissimilarity notion embedded in established
 * detectors of corner-like interest points, thereby achieving enhanced repeatability, distinctiveness and
 * localization accuracy.
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface MSDDetector : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::MSDDetector> nativePtrMSDDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::MSDDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::MSDDetector>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_MSDDetector cv::xfeatures2d::MSDDetector::create(int m_patch_radius = 3, int m_search_area_radius = 5, int m_nms_radius = 5, int m_nms_scale_radius = 0, float m_th_saliency = 250.0f, int m_kNN = 4, float m_scale_factor = 1.25f, int m_n_scales = -1, bool m_compute_orientation = false)
//
+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius m_nms_scale_radius:(int)m_nms_scale_radius m_th_saliency:(float)m_th_saliency m_kNN:(int)m_kNN m_scale_factor:(float)m_scale_factor m_n_scales:(int)m_n_scales m_compute_orientation:(BOOL)m_compute_orientation NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:m_nms_scale_radius:m_th_saliency:m_kNN:m_scale_factor:m_n_scales:m_compute_orientation:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius m_nms_scale_radius:(int)m_nms_scale_radius m_th_saliency:(float)m_th_saliency m_kNN:(int)m_kNN m_scale_factor:(float)m_scale_factor m_n_scales:(int)m_n_scales NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:m_nms_scale_radius:m_th_saliency:m_kNN:m_scale_factor:m_n_scales:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius m_nms_scale_radius:(int)m_nms_scale_radius m_th_saliency:(float)m_th_saliency m_kNN:(int)m_kNN m_scale_factor:(float)m_scale_factor NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:m_nms_scale_radius:m_th_saliency:m_kNN:m_scale_factor:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius m_nms_scale_radius:(int)m_nms_scale_radius m_th_saliency:(float)m_th_saliency m_kNN:(int)m_kNN NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:m_nms_scale_radius:m_th_saliency:m_kNN:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius m_nms_scale_radius:(int)m_nms_scale_radius m_th_saliency:(float)m_th_saliency NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:m_nms_scale_radius:m_th_saliency:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius m_nms_scale_radius:(int)m_nms_scale_radius NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:m_nms_scale_radius:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius m_nms_radius:(int)m_nms_radius NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:m_nms_radius:));

+ (MSDDetector*)create:(int)m_patch_radius m_search_area_radius:(int)m_search_area_radius NS_SWIFT_NAME(create(m_patch_radius:m_search_area_radius:));

+ (MSDDetector*)create:(int)m_patch_radius NS_SWIFT_NAME(create(m_patch_radius:));

+ (MSDDetector*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::MSDDetector::setPatchRadius(int patch_radius)
//
- (void)setPatchRadius:(int)patch_radius NS_SWIFT_NAME(setPatchRadius(patch_radius:));


//
//  int cv::xfeatures2d::MSDDetector::getPatchRadius()
//
- (int)getPatchRadius NS_SWIFT_NAME(getPatchRadius());


//
//  void cv::xfeatures2d::MSDDetector::setSearchAreaRadius(int use_orientation)
//
- (void)setSearchAreaRadius:(int)use_orientation NS_SWIFT_NAME(setSearchAreaRadius(use_orientation:));


//
//  int cv::xfeatures2d::MSDDetector::getSearchAreaRadius()
//
- (int)getSearchAreaRadius NS_SWIFT_NAME(getSearchAreaRadius());


//
//  void cv::xfeatures2d::MSDDetector::setNmsRadius(int nms_radius)
//
- (void)setNmsRadius:(int)nms_radius NS_SWIFT_NAME(setNmsRadius(nms_radius:));


//
//  int cv::xfeatures2d::MSDDetector::getNmsRadius()
//
- (int)getNmsRadius NS_SWIFT_NAME(getNmsRadius());


//
//  void cv::xfeatures2d::MSDDetector::setNmsScaleRadius(int nms_scale_radius)
//
- (void)setNmsScaleRadius:(int)nms_scale_radius NS_SWIFT_NAME(setNmsScaleRadius(nms_scale_radius:));


//
//  int cv::xfeatures2d::MSDDetector::getNmsScaleRadius()
//
- (int)getNmsScaleRadius NS_SWIFT_NAME(getNmsScaleRadius());


//
//  void cv::xfeatures2d::MSDDetector::setThSaliency(float th_saliency)
//
- (void)setThSaliency:(float)th_saliency NS_SWIFT_NAME(setThSaliency(th_saliency:));


//
//  float cv::xfeatures2d::MSDDetector::getThSaliency()
//
- (float)getThSaliency NS_SWIFT_NAME(getThSaliency());


//
//  void cv::xfeatures2d::MSDDetector::setKNN(int kNN)
//
- (void)setKNN:(int)kNN NS_SWIFT_NAME(setKNN(kNN:));


//
//  int cv::xfeatures2d::MSDDetector::getKNN()
//
- (int)getKNN NS_SWIFT_NAME(getKNN());


//
//  void cv::xfeatures2d::MSDDetector::setScaleFactor(float scale_factor)
//
- (void)setScaleFactor:(float)scale_factor NS_SWIFT_NAME(setScaleFactor(scale_factor:));


//
//  float cv::xfeatures2d::MSDDetector::getScaleFactor()
//
- (float)getScaleFactor NS_SWIFT_NAME(getScaleFactor());


//
//  void cv::xfeatures2d::MSDDetector::setNScales(int use_orientation)
//
- (void)setNScales:(int)use_orientation NS_SWIFT_NAME(setNScales(use_orientation:));


//
//  int cv::xfeatures2d::MSDDetector::getNScales()
//
- (int)getNScales NS_SWIFT_NAME(getNScales());


//
//  void cv::xfeatures2d::MSDDetector::setComputeOrientation(bool compute_orientation)
//
- (void)setComputeOrientation:(BOOL)compute_orientation NS_SWIFT_NAME(setComputeOrientation(compute_orientation:));


//
//  bool cv::xfeatures2d::MSDDetector::getComputeOrientation()
//
- (BOOL)getComputeOrientation NS_SWIFT_NAME(getComputeOrientation());


//
//  String cv::xfeatures2d::MSDDetector::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


