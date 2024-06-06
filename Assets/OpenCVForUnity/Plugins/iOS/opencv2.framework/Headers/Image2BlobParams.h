//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/dnn.hpp"
#import "opencv2/dnn/dnn.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>


#import "Dnn.h"
@class Scalar;
@class Size2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class Image2BlobParams
/**
 * Processing params of image to blob.
 *
 * It includes all possible image processing operations and corresponding parameters.
 *
 * @see blobFromImageWithParams
 *
 * NOTE:
 * The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
 * The order and usage of `scalefactor`, `size`, `mean`, `swapRB`, and `ddepth` are consistent
 * with the function of REF: blobFromImage.
 *
 * Member of `Dnn`
 */
CV_EXPORTS @interface Image2BlobParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::dnn::Image2BlobParams> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::dnn::Image2BlobParams>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::dnn::Image2BlobParams>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::dnn::Image2BlobParams::Image2BlobParams()
//
- (instancetype)init;


//
//   cv::dnn::Image2BlobParams::Image2BlobParams(Scalar scalefactor, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, int ddepth = CV_32F, DataLayout datalayout = DNN_LAYOUT_NCHW, ImagePaddingMode mode = DNN_PMODE_NULL)
//
- (instancetype)initWithScalefactor:(Scalar*)scalefactor size:(Size2i*)size mean:(Scalar*)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth datalayout:(DataLayout)datalayout mode:(ImagePaddingMode)mode;

- (instancetype)initWithScalefactor:(Scalar*)scalefactor size:(Size2i*)size mean:(Scalar*)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth datalayout:(DataLayout)datalayout;

- (instancetype)initWithScalefactor:(Scalar*)scalefactor size:(Size2i*)size mean:(Scalar*)mean swapRB:(BOOL)swapRB ddepth:(int)ddepth;

- (instancetype)initWithScalefactor:(Scalar*)scalefactor size:(Size2i*)size mean:(Scalar*)mean swapRB:(BOOL)swapRB;

- (instancetype)initWithScalefactor:(Scalar*)scalefactor size:(Size2i*)size mean:(Scalar*)mean;

- (instancetype)initWithScalefactor:(Scalar*)scalefactor size:(Size2i*)size;

- (instancetype)initWithScalefactor:(Scalar*)scalefactor;


    //
    // C++: Scalar cv::dnn::Image2BlobParams::scalefactor
    //

@property Scalar* scalefactor;

    //
    // C++: Size cv::dnn::Image2BlobParams::size
    //

@property Size2i* size;

    //
    // C++: Scalar cv::dnn::Image2BlobParams::mean
    //

@property Scalar* mean;

    //
    // C++: bool cv::dnn::Image2BlobParams::swapRB
    //

@property BOOL swapRB;

    //
    // C++: int cv::dnn::Image2BlobParams::ddepth
    //

@property int ddepth;

    //
    // C++: DataLayout cv::dnn::Image2BlobParams::datalayout
    //

@property DataLayout datalayout;

    //
    // C++: ImagePaddingMode cv::dnn::Image2BlobParams::paddingmode
    //

@property ImagePaddingMode paddingmode;


@end

NS_ASSUME_NONNULL_END


