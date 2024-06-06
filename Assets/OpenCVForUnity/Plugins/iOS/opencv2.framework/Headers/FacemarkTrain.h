//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/facemark_train.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Facemark.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class FacemarkTrain
/**
 * Abstract base class for trainable facemark models
 *
 * To utilize this API in your program, please take a look at the REF: tutorial_table_of_content_facemark
 * ### Description
 *
 * The AAM and LBF facemark models in OpenCV are derived from the abstract base class FacemarkTrain, which
 * provides a unified access to those facemark algorithms in OpenCV.
 *
 * Here is an example on how to declare facemark algorithm:
 *
 * // Using Facemark in your code:
 * Ptr<Facemark> facemark = FacemarkLBF::create();
 *
 *
 *
 * The typical pipeline for facemark detection is listed as follows:
 * - (Non-mandatory) Set a user defined face detection using FacemarkTrain::setFaceDetector.
 *   The facemark algorithms are designed to fit the facial points into a face.
 *   Therefore, the face information should be provided to the facemark algorithm.
 *   Some algorithms might provides a default face recognition function.
 *   However, the users might prefer to use their own face detector to obtains the best possible detection result.
 * - (Non-mandatory) Training the model for a specific algorithm using FacemarkTrain::training.
 *   In this case, the model should be automatically saved by the algorithm.
 *   If the user already have a trained model, then this part can be omitted.
 * - Load the trained model using Facemark::loadModel.
 * - Perform the fitting via the Facemark::fit.
 *
 * Member of `Face`
 */
CV_EXPORTS @interface FacemarkTrain : Facemark


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::FacemarkTrain> nativePtrFacemarkTrain;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::FacemarkTrain>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::FacemarkTrain>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


