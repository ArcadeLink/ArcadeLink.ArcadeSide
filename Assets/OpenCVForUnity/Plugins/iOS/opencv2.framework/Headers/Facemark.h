//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/facemark.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class Facemark
/**
 * Abstract base class for all facemark models
 *
 * To utilize this API in your program, please take a look at the REF: tutorial_table_of_content_facemark
 * ### Description
 *
 * Facemark is a base class which provides universal access to any specific facemark algorithm.
 * Therefore, the users should declare a desired algorithm before they can use it in their application.
 *
 * Here is an example on how to declare a facemark algorithm:
 *
 * // Using Facemark in your code:
 * Ptr<Facemark> facemark = createFacemarkLBF();
 *
 *
 * The typical pipeline for facemark detection is as follows:
 * - Load the trained model using Facemark::loadModel.
 * - Perform the fitting on an image via Facemark::fit.
 *
 * Member of `Face`
 */
CV_EXPORTS @interface Facemark : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::Facemark> nativePtrFacemark;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::Facemark>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::Facemark>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::face::Facemark::loadModel(String model)
//
/**
 * A function to load the trained model before the fitting process.
 * @param model A string represent the filename of a trained model.
 *
 *     <B>Example of usage</B>
 *     
 *     facemark->loadModel("../data/lbf.model");
 *     
 */
- (void)loadModel:(NSString*)model NS_SWIFT_NAME(loadModel(model:));


//
//  bool cv::face::Facemark::fit(Mat image, Mat faces, vector_Mat& landmarks)
//
/**
 * Detect facial landmarks from an image.
 * @param image Input image.
 * @param faces Output of the function which represent region of interest of the detected faces.
 *     Each face is stored in cv::Rect container.
 * @param landmarks The detected landmark points for each faces.
 *
 *     <B>Example of usage</B>
 *     
 *     Mat image = imread("image.jpg");
 *     std::vector<Rect> faces;
 *     std::vector<std::vector<Point2f> > landmarks;
 *     facemark->fit(image, faces, landmarks);
 *     
 */
- (BOOL)fit:(Mat*)image faces:(Mat*)faces landmarks:(NSMutableArray<Mat*>*)landmarks NS_SWIFT_NAME(fit(image:faces:landmarks:));



@end

NS_ASSUME_NONNULL_END


