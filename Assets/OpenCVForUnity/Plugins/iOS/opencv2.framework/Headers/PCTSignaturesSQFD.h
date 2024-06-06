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
#import "Algorithm.h"

@class FloatVector;
@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class PCTSignaturesSQFD
/**
 * Class implementing Signature Quadratic Form Distance (SQFD).
 * @see Christian Beecks, Merih Seran Uysal, Thomas Seidl.
 * Signature quadratic form distance.
 * In Proceedings of the ACM International Conference on Image and Video Retrieval, pages 438-445.
 * ACM, 2010.
 * CITE: BeecksUS10
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface PCTSignaturesSQFD : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::PCTSignaturesSQFD> nativePtrPCTSignaturesSQFD;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::PCTSignaturesSQFD>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::PCTSignaturesSQFD>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_PCTSignaturesSQFD cv::xfeatures2d::PCTSignaturesSQFD::create(int distanceFunction = 3, int similarityFunction = 2, float similarityParameter = 1.0f)
//
/**
 * Creates the algorithm instance using selected distance function,
 * similarity function and similarity function parameter.
 * @param distanceFunction Distance function selector. Default: L2
 * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
 * @param similarityFunction Similarity function selector. Default: HEURISTIC
 * Available: MINUS, GAUSSIAN, HEURISTIC
 * @param similarityParameter Parameter of the similarity function.
 */
+ (PCTSignaturesSQFD*)create:(int)distanceFunction similarityFunction:(int)similarityFunction similarityParameter:(float)similarityParameter NS_SWIFT_NAME(create(distanceFunction:similarityFunction:similarityParameter:));

/**
 * Creates the algorithm instance using selected distance function,
 * similarity function and similarity function parameter.
 * @param distanceFunction Distance function selector. Default: L2
 * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
 * @param similarityFunction Similarity function selector. Default: HEURISTIC
 * Available: MINUS, GAUSSIAN, HEURISTIC
 */
+ (PCTSignaturesSQFD*)create:(int)distanceFunction similarityFunction:(int)similarityFunction NS_SWIFT_NAME(create(distanceFunction:similarityFunction:));

/**
 * Creates the algorithm instance using selected distance function,
 * similarity function and similarity function parameter.
 * @param distanceFunction Distance function selector. Default: L2
 * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
 * Available: MINUS, GAUSSIAN, HEURISTIC
 */
+ (PCTSignaturesSQFD*)create:(int)distanceFunction NS_SWIFT_NAME(create(distanceFunction:));

/**
 * Creates the algorithm instance using selected distance function,
 * similarity function and similarity function parameter.
 * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
 * Available: MINUS, GAUSSIAN, HEURISTIC
 */
+ (PCTSignaturesSQFD*)create NS_SWIFT_NAME(create());


//
//  float cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
//
/**
 * Computes Signature Quadratic Form Distance of two signatures.
 * @param _signature0 The first signature.
 * @param _signature1 The second signature.
 */
- (float)computeQuadraticFormDistance:(Mat*)_signature0 _signature1:(Mat*)_signature1 NS_SWIFT_NAME(computeQuadraticFormDistance(_signature0:_signature1:));


//
//  void cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistances(Mat sourceSignature, vector_Mat imageSignatures, vector_float distances)
//
/**
 * Computes Signature Quadratic Form Distance between the reference signature
 * and each of the other image signatures.
 * @param sourceSignature The signature to measure distance of other signatures from.
 * @param imageSignatures Vector of signatures to measure distance from the source signature.
 * @param distances Output vector of measured distances.
 */
- (void)computeQuadraticFormDistances:(Mat*)sourceSignature imageSignatures:(NSArray<Mat*>*)imageSignatures distances:(FloatVector*)distances NS_SWIFT_NAME(computeQuadraticFormDistances(sourceSignature:imageSignatures:distances:));



@end

NS_ASSUME_NONNULL_END


