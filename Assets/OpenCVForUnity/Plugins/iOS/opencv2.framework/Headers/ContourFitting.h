//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/fourier_descriptors.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class ContourFitting
/**
 * Class for ContourFitting algorithms.
 *     ContourFitting match two contours `$$ z_a $$` and `$$ z_b $$` minimizing distance
 *     `$$ d(z_a,z_b)=\sum (a_n - s  b_n e^{j(n \alpha +\phi )})^2 $$` where `$$ a_n $$` and `$$ b_n $$` are Fourier descriptors of `$$ z_a $$` and `$$ z_b $$` and s is a scaling factor and  `$$ \phi $$` is angle rotation and `$$ \alpha $$` is starting point factor adjustement
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface ContourFitting : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::ContourFitting> nativePtrContourFitting;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::ContourFitting>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::ContourFitting>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::ContourFitting::estimateTransformation(Mat src, Mat dst, Mat& alphaPhiST, double& dist, bool fdContour = false)
//
/**
 * Fit two closed curves using fourier descriptors. More details in CITE: PersoonFu1977 and CITE: BergerRaghunathan1998
 *
 * @param src Contour defining first shape.
 * @param dst Contour defining second shape (Target).
 * @param alphaPhiST : `$$ \alpha $$`=alphaPhiST(0,0), `$$ \phi $$`=alphaPhiST(0,1) (in radian), s=alphaPhiST(0,2), Tx=alphaPhiST(0,3), Ty=alphaPhiST(0,4) rotation center
 * @param dist distance between src and dst after matching.
 * @param fdContour false then src and dst are contours and true src and dst are fourier descriptors.
 */
- (void)estimateTransformation:(Mat*)src dst:(Mat*)dst alphaPhiST:(Mat*)alphaPhiST dist:(double*)dist fdContour:(BOOL)fdContour NS_SWIFT_NAME(estimateTransformation(src:dst:alphaPhiST:dist:fdContour:));

/**
 * Fit two closed curves using fourier descriptors. More details in CITE: PersoonFu1977 and CITE: BergerRaghunathan1998
 *
 * @param src Contour defining first shape.
 * @param dst Contour defining second shape (Target).
 * @param alphaPhiST : `$$ \alpha $$`=alphaPhiST(0,0), `$$ \phi $$`=alphaPhiST(0,1) (in radian), s=alphaPhiST(0,2), Tx=alphaPhiST(0,3), Ty=alphaPhiST(0,4) rotation center
 * @param dist distance between src and dst after matching.
 */
- (void)estimateTransformation:(Mat*)src dst:(Mat*)dst alphaPhiST:(Mat*)alphaPhiST dist:(double*)dist NS_SWIFT_NAME(estimateTransformation(src:dst:alphaPhiST:dist:));


//
//  void cv::ximgproc::ContourFitting::setCtrSize(int n)
//
/**
 * set number of Fourier descriptors used in estimateTransformation
 *
 * @param n number of Fourier descriptors equal to number of contour points after resampling.
 */
- (void)setCtrSize:(int)n NS_SWIFT_NAME(setCtrSize(n:));


//
//  void cv::ximgproc::ContourFitting::setFDSize(int n)
//
/**
 * set number of Fourier descriptors when estimateTransformation used vector<Point>
 *
 * @param n number of fourier descriptors used for optimal curve matching.
 */
- (void)setFDSize:(int)n NS_SWIFT_NAME(setFDSize(n:));


//
//  int cv::ximgproc::ContourFitting::getCtrSize()
//
/**
 * @return number of fourier descriptors
 */
- (int)getCtrSize NS_SWIFT_NAME(getCtrSize());


//
//  int cv::ximgproc::ContourFitting::getFDSize()
//
/**
 * @return number of fourier descriptors used for optimal curve matching
 */
- (int)getFDSize NS_SWIFT_NAME(getFDSize());



@end

NS_ASSUME_NONNULL_END


