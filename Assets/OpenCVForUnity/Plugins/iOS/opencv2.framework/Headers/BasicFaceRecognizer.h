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

// C++: class BasicFaceRecognizer
/**
 * The BasicFaceRecognizer module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface BasicFaceRecognizer : FaceRecognizer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::BasicFaceRecognizer> nativePtrBasicFaceRecognizer;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::BasicFaceRecognizer>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::BasicFaceRecognizer>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::face::BasicFaceRecognizer::getNumComponents()
//
/**
 * @see `-setNumComponents:`
 */
- (int)getNumComponents NS_SWIFT_NAME(getNumComponents());


//
//  void cv::face::BasicFaceRecognizer::setNumComponents(int val)
//
/**
 *  getNumComponents @see `-getNumComponents:`
 */
- (void)setNumComponents:(int)val NS_SWIFT_NAME(setNumComponents(val:));


//
//  double cv::face::BasicFaceRecognizer::getThreshold()
//
/**
 * @see `-setThreshold:`
 */
- (double)getThreshold NS_SWIFT_NAME(getThreshold());


//
//  void cv::face::BasicFaceRecognizer::setThreshold(double val)
//
/**
 *  getThreshold @see `-getThreshold:`
 */
- (void)setThreshold:(double)val NS_SWIFT_NAME(setThreshold(val:));


//
//  vector_Mat cv::face::BasicFaceRecognizer::getProjections()
//
- (NSArray<Mat*>*)getProjections NS_SWIFT_NAME(getProjections());


//
//  Mat cv::face::BasicFaceRecognizer::getLabels()
//
- (Mat*)getLabels NS_SWIFT_NAME(getLabels());


//
//  Mat cv::face::BasicFaceRecognizer::getEigenValues()
//
- (Mat*)getEigenValues NS_SWIFT_NAME(getEigenValues());


//
//  Mat cv::face::BasicFaceRecognizer::getEigenVectors()
//
- (Mat*)getEigenVectors NS_SWIFT_NAME(getEigenVectors());


//
//  Mat cv::face::BasicFaceRecognizer::getMean()
//
- (Mat*)getMean NS_SWIFT_NAME(getMean());



@end

NS_ASSUME_NONNULL_END


