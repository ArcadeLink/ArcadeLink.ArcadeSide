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
#import "BasicFaceRecognizer.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class FisherFaceRecognizer
/**
 * The FisherFaceRecognizer module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface FisherFaceRecognizer : BasicFaceRecognizer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::FisherFaceRecognizer> nativePtrFisherFaceRecognizer;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::FisherFaceRecognizer>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::FisherFaceRecognizer>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_FisherFaceRecognizer cv::face::FisherFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
//
/**
 * @param num_components The number of components (read: Fisherfaces) kept for this Linear
 *     Discriminant Analysis with the Fisherfaces criterion. It's useful to keep all components, that
 *     means the number of your classes c (read: subjects, persons you want to recognize). If you leave
 *     this at the default (0) or set it to a value less-equal 0 or greater (c-1), it will be set to the
 *     correct number (c-1) automatically.
 * @param threshold The threshold applied in the prediction. If the distance to the nearest neighbor
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   Training and prediction must be done on grayscale images, use cvtColor to convert between the
 *         color spaces.
 *     -   **THE FISHERFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
 *         SIZE.** (caps-lock, because I got so many mails asking for this). You have to make sure your
 *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
 *         the images.
 *     -   This model does not support updating.
 *
 *     ### Model internal data:
 *
 *     -   num_components see FisherFaceRecognizer::create.
 *     -   threshold see FisherFaceRecognizer::create.
 *     -   eigenvalues The eigenvalues for this Linear Discriminant Analysis (ordered descending).
 *     -   eigenvectors The eigenvectors for this Linear Discriminant Analysis (ordered by their
 *         eigenvalue).
 *     -   mean The sample mean calculated from the training data.
 *     -   projections The projections of the training data.
 *     -   labels The labels corresponding to the projections.
 */
+ (FisherFaceRecognizer*)create:(int)num_components threshold:(double)threshold NS_SWIFT_NAME(create(num_components:threshold:));

/**
 * @param num_components The number of components (read: Fisherfaces) kept for this Linear
 *     Discriminant Analysis with the Fisherfaces criterion. It's useful to keep all components, that
 *     means the number of your classes c (read: subjects, persons you want to recognize). If you leave
 *     this at the default (0) or set it to a value less-equal 0 or greater (c-1), it will be set to the
 *     correct number (c-1) automatically.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   Training and prediction must be done on grayscale images, use cvtColor to convert between the
 *         color spaces.
 *     -   **THE FISHERFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
 *         SIZE.** (caps-lock, because I got so many mails asking for this). You have to make sure your
 *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
 *         the images.
 *     -   This model does not support updating.
 *
 *     ### Model internal data:
 *
 *     -   num_components see FisherFaceRecognizer::create.
 *     -   threshold see FisherFaceRecognizer::create.
 *     -   eigenvalues The eigenvalues for this Linear Discriminant Analysis (ordered descending).
 *     -   eigenvectors The eigenvectors for this Linear Discriminant Analysis (ordered by their
 *         eigenvalue).
 *     -   mean The sample mean calculated from the training data.
 *     -   projections The projections of the training data.
 *     -   labels The labels corresponding to the projections.
 */
+ (FisherFaceRecognizer*)create:(int)num_components NS_SWIFT_NAME(create(num_components:));

/**
 *     Discriminant Analysis with the Fisherfaces criterion. It's useful to keep all components, that
 *     means the number of your classes c (read: subjects, persons you want to recognize). If you leave
 *     this at the default (0) or set it to a value less-equal 0 or greater (c-1), it will be set to the
 *     correct number (c-1) automatically.
 *     is larger than the threshold, this method returns -1.
 *
 *     ### Notes:
 *
 *     -   Training and prediction must be done on grayscale images, use cvtColor to convert between the
 *         color spaces.
 *     -   **THE FISHERFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
 *         SIZE.** (caps-lock, because I got so many mails asking for this). You have to make sure your
 *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
 *         the images.
 *     -   This model does not support updating.
 *
 *     ### Model internal data:
 *
 *     -   num_components see FisherFaceRecognizer::create.
 *     -   threshold see FisherFaceRecognizer::create.
 *     -   eigenvalues The eigenvalues for this Linear Discriminant Analysis (ordered descending).
 *     -   eigenvectors The eigenvectors for this Linear Discriminant Analysis (ordered by their
 *         eigenvalue).
 *     -   mean The sample mean calculated from the training data.
 *     -   projections The projections of the training data.
 *     -   labels The labels corresponding to the projections.
 */
+ (FisherFaceRecognizer*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


