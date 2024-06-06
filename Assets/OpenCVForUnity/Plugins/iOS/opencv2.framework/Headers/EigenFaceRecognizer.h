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

// C++: class EigenFaceRecognizer
/**
 * The EigenFaceRecognizer module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface EigenFaceRecognizer : BasicFaceRecognizer


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::EigenFaceRecognizer> nativePtrEigenFaceRecognizer;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::EigenFaceRecognizer>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::EigenFaceRecognizer>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_EigenFaceRecognizer cv::face::EigenFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
//
/**
 * @param num_components The number of components (read: Eigenfaces) kept for this Principal
 *     Component Analysis. As a hint: There's no rule how many components (read: Eigenfaces) should be
 *     kept for good reconstruction capabilities. It is based on your input data, so experiment with the
 *     number. Keeping 80 components should almost always be sufficient.
 * @param threshold The threshold applied in the prediction.
 *
 *     ### Notes:
 *
 *     -   Training and prediction must be done on grayscale images, use cvtColor to convert between the
 *         color spaces.
 *     -   **THE EIGENFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
 *         SIZE.** (caps-lock, because I got so many mails asking for this). You have to make sure your
 *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
 *         the images.
 *     -   This model does not support updating.
 *
 *     ### Model internal data:
 *
 *     -   num_components see EigenFaceRecognizer::create.
 *     -   threshold see EigenFaceRecognizer::create.
 *     -   eigenvalues The eigenvalues for this Principal Component Analysis (ordered descending).
 *     -   eigenvectors The eigenvectors for this Principal Component Analysis (ordered by their
 *         eigenvalue).
 *     -   mean The sample mean calculated from the training data.
 *     -   projections The projections of the training data.
 *     -   labels The threshold applied in the prediction. If the distance to the nearest neighbor is
 *         larger than the threshold, this method returns -1.
 */
+ (EigenFaceRecognizer*)create:(int)num_components threshold:(double)threshold NS_SWIFT_NAME(create(num_components:threshold:));

/**
 * @param num_components The number of components (read: Eigenfaces) kept for this Principal
 *     Component Analysis. As a hint: There's no rule how many components (read: Eigenfaces) should be
 *     kept for good reconstruction capabilities. It is based on your input data, so experiment with the
 *     number. Keeping 80 components should almost always be sufficient.
 *
 *     ### Notes:
 *
 *     -   Training and prediction must be done on grayscale images, use cvtColor to convert between the
 *         color spaces.
 *     -   **THE EIGENFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
 *         SIZE.** (caps-lock, because I got so many mails asking for this). You have to make sure your
 *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
 *         the images.
 *     -   This model does not support updating.
 *
 *     ### Model internal data:
 *
 *     -   num_components see EigenFaceRecognizer::create.
 *     -   threshold see EigenFaceRecognizer::create.
 *     -   eigenvalues The eigenvalues for this Principal Component Analysis (ordered descending).
 *     -   eigenvectors The eigenvectors for this Principal Component Analysis (ordered by their
 *         eigenvalue).
 *     -   mean The sample mean calculated from the training data.
 *     -   projections The projections of the training data.
 *     -   labels The threshold applied in the prediction. If the distance to the nearest neighbor is
 *         larger than the threshold, this method returns -1.
 */
+ (EigenFaceRecognizer*)create:(int)num_components NS_SWIFT_NAME(create(num_components:));

/**
 *     Component Analysis. As a hint: There's no rule how many components (read: Eigenfaces) should be
 *     kept for good reconstruction capabilities. It is based on your input data, so experiment with the
 *     number. Keeping 80 components should almost always be sufficient.
 *
 *     ### Notes:
 *
 *     -   Training and prediction must be done on grayscale images, use cvtColor to convert between the
 *         color spaces.
 *     -   **THE EIGENFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
 *         SIZE.** (caps-lock, because I got so many mails asking for this). You have to make sure your
 *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
 *         the images.
 *     -   This model does not support updating.
 *
 *     ### Model internal data:
 *
 *     -   num_components see EigenFaceRecognizer::create.
 *     -   threshold see EigenFaceRecognizer::create.
 *     -   eigenvalues The eigenvalues for this Principal Component Analysis (ordered descending).
 *     -   eigenvectors The eigenvectors for this Principal Component Analysis (ordered by their
 *         eigenvalue).
 *     -   mean The sample mean calculated from the training data.
 *     -   projections The projections of the training data.
 *     -   labels The threshold applied in the prediction. If the distance to the nearest neighbor is
 *         larger than the threshold, this method returns -1.
 */
+ (EigenFaceRecognizer*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


