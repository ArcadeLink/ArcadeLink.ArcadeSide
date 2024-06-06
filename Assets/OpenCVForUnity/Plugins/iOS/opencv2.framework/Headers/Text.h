//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/text.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class ERFilter;
@class ERFilterCallback;
@class Mat;
@class OCRBeamSearchDecoderClassifierCallback;
@class OCRHMMDecoderClassifierCallback;
@class Point2i;
@class Rect2i;


// C++: enum classifier_type (cv.text.classifier_type)
typedef NS_ENUM(int, classifier_type) {
    OCR_KNN_CLASSIFIER = 0,
    OCR_CNN_CLASSIFIER = 1
};


// C++: enum decoder_mode (cv.text.decoder_mode)
typedef NS_ENUM(int, decoder_mode) {
    OCR_DECODER_VITERBI = 0
};


// C++: enum erGrouping_Modes (cv.text.erGrouping_Modes)
typedef NS_ENUM(int, erGrouping_Modes) {
    ERGROUPING_ORIENTATION_HORIZ = 0,
    ERGROUPING_ORIENTATION_ANY = 1
};


// C++: enum ocr_engine_mode (cv.text.ocr_engine_mode)
typedef NS_ENUM(int, ocr_engine_mode) {
    OEM_TESSERACT_ONLY = 0,
    OEM_CUBE_ONLY = 1,
    OEM_TESSERACT_CUBE_COMBINED = 2,
    OEM_DEFAULT = 3
};


// C++: enum page_seg_mode (cv.text.page_seg_mode)
typedef NS_ENUM(int, page_seg_mode) {
    PSM_OSD_ONLY = 0,
    PSM_AUTO_OSD = 1,
    PSM_AUTO_ONLY = 2,
    PSM_AUTO = 3,
    PSM_SINGLE_COLUMN = 4,
    PSM_SINGLE_BLOCK_VERT_TEXT = 5,
    PSM_SINGLE_BLOCK = 6,
    PSM_SINGLE_LINE = 7,
    PSM_SINGLE_WORD = 8,
    PSM_CIRCLE_WORD = 9,
    PSM_SINGLE_CHAR = 10
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Text
/**
 * The Text module
 *
 * Member classes: `ERFilter`, `ERFilterCallback`, `BaseOCR`, `OCRTesseract`, `OCRHMMDecoder`, `OCRHMMDecoderClassifierCallback`, `OCRBeamSearchDecoder`, `OCRBeamSearchDecoderClassifierCallback`, `TextDetector`, `TextDetectorCNN`
 *
 * Member enums: `erGrouping_Modes`, `page_seg_mode`, `ocr_engine_mode`, `decoder_mode`, `classifier_type`
 */
CV_EXPORTS @interface Text : NSObject

#pragma mark - Class Constants


@property (class, readonly) int ERFILTER_NM_RGBLGrad NS_SWIFT_NAME(ERFILTER_NM_RGBLGrad);
@property (class, readonly) int ERFILTER_NM_IHSGrad NS_SWIFT_NAME(ERFILTER_NM_IHSGrad);
@property (class, readonly) int OCR_LEVEL_WORD NS_SWIFT_NAME(OCR_LEVEL_WORD);
@property (class, readonly) int OCR_LEVEL_TEXTLINE NS_SWIFT_NAME(OCR_LEVEL_TEXTLINE);

#pragma mark - Methods


//
//  void cv::text::detectTextSWT(Mat input, vector_Rect& result, bool dark_on_light, Mat& draw = Mat(), Mat& chainBBs = Mat())
//
/**
 * Applies the Stroke Width Transform operator followed by filtering of connected components of similar Stroke Widths to return letter candidates. It also chain them by proximity and size, saving the result in chainBBs.
 * @param input the input image with 3 channels.
 * @param result a vector of resulting bounding boxes where probability of finding text is high
 * @param dark_on_light a boolean value signifying whether the text is darker or lighter than the background, it is observed to reverse the gradient obtained from Scharr operator, and significantly affect the result.
 * @param draw an optional Mat of type CV_8UC3 which visualises the detected letters using bounding boxes.
 * @param chainBBs an optional parameter which chains the letter candidates according to heuristics in the paper and returns all possible regions where text is likely to occur.
 */
+ (void)detectTextSWT:(Mat*)input result:(NSMutableArray<Rect2i*>*)result dark_on_light:(BOOL)dark_on_light draw:(Mat*)draw chainBBs:(Mat*)chainBBs NS_SWIFT_NAME(detectTextSWT(input:result:dark_on_light:draw:chainBBs:));

/**
 * Applies the Stroke Width Transform operator followed by filtering of connected components of similar Stroke Widths to return letter candidates. It also chain them by proximity and size, saving the result in chainBBs.
 * @param input the input image with 3 channels.
 * @param result a vector of resulting bounding boxes where probability of finding text is high
 * @param dark_on_light a boolean value signifying whether the text is darker or lighter than the background, it is observed to reverse the gradient obtained from Scharr operator, and significantly affect the result.
 * @param draw an optional Mat of type CV_8UC3 which visualises the detected letters using bounding boxes.
 */
+ (void)detectTextSWT:(Mat*)input result:(NSMutableArray<Rect2i*>*)result dark_on_light:(BOOL)dark_on_light draw:(Mat*)draw NS_SWIFT_NAME(detectTextSWT(input:result:dark_on_light:draw:));

/**
 * Applies the Stroke Width Transform operator followed by filtering of connected components of similar Stroke Widths to return letter candidates. It also chain them by proximity and size, saving the result in chainBBs.
 * @param input the input image with 3 channels.
 * @param result a vector of resulting bounding boxes where probability of finding text is high
 * @param dark_on_light a boolean value signifying whether the text is darker or lighter than the background, it is observed to reverse the gradient obtained from Scharr operator, and significantly affect the result.
 */
+ (void)detectTextSWT:(Mat*)input result:(NSMutableArray<Rect2i*>*)result dark_on_light:(BOOL)dark_on_light NS_SWIFT_NAME(detectTextSWT(input:result:dark_on_light:));


//
//  Ptr_ERFilter cv::text::createERFilterNM1(Ptr_ERFilter_Callback cb, int thresholdDelta = 1, float minArea = (float)0.00025, float maxArea = (float)0.13, float minProbability = (float)0.4, bool nonMaxSuppression = true, float minProbabilityDiff = (float)0.1)
//
/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea minProbability:(float)minProbability nonMaxSuppression:(BOOL)nonMaxSuppression minProbabilityDiff:(float)minProbabilityDiff NS_SWIFT_NAME(createERFilterNM1(cb:thresholdDelta:minArea:maxArea:minProbability:nonMaxSuppression:minProbabilityDiff:));

/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea minProbability:(float)minProbability nonMaxSuppression:(BOOL)nonMaxSuppression NS_SWIFT_NAME(createERFilterNM1(cb:thresholdDelta:minArea:maxArea:minProbability:nonMaxSuppression:));

/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea minProbability:(float)minProbability NS_SWIFT_NAME(createERFilterNM1(cb:thresholdDelta:minArea:maxArea:minProbability:));

/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea NS_SWIFT_NAME(createERFilterNM1(cb:thresholdDelta:minArea:maxArea:));

/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb thresholdDelta:(int)thresholdDelta minArea:(float)minArea NS_SWIFT_NAME(createERFilterNM1(cb:thresholdDelta:minArea:));

/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb thresholdDelta:(int)thresholdDelta NS_SWIFT_NAME(createERFilterNM1(cb:thresholdDelta:));

/**
 * Create an Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM1, e.g. from file in samples/cpp/trained_classifierNM1.xml
 *
 * The component tree of the image is extracted by a threshold increased step by step from 0 to 255,
 * incrementally computable descriptors (aspect_ratio, compactness, number of holes, and number of
 * horizontal crossings) are computed for each ER and used as features for a classifier which estimates
 * the class-conditional probability P(er|character). The value of P(er|character) is tracked using the
 * inclusion relation of ER across all thresholds and only the ERs which correspond to local maximum of
 * the probability P(er|character) are selected (if the local maximum of the probability is above a
 * global limit pmin and the difference between local maximum and local minimum is greater than
 * minProbabilityDiff).
 */
+ (ERFilter*)createERFilterNM1:(ERFilterCallback*)cb NS_SWIFT_NAME(createERFilterNM1(cb:));


//
//  Ptr_ERFilter cv::text::createERFilterNM2(Ptr_ERFilter_Callback cb, float minProbability = (float)0.3)
//
/**
 * Create an Extremal Region Filter for the 2nd stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM2, e.g. from file in samples/cpp/trained_classifierNM2.xml
 *
 * In the second stage, the ERs that passed the first stage are classified into character and
 * non-character classes using more informative but also more computationally expensive features. The
 * classifier uses all the features calculated in the first stage and the following additional
 * features: hole area ratio, convex hull ratio, and number of outer inflexion points.
 */
+ (ERFilter*)createERFilterNM2:(ERFilterCallback*)cb minProbability:(float)minProbability NS_SWIFT_NAME(createERFilterNM2(cb:minProbability:));

/**
 * Create an Extremal Region Filter for the 2nd stage classifier of N&M algorithm CITE: Neumann12.
 *
 * loadClassifierNM2, e.g. from file in samples/cpp/trained_classifierNM2.xml
 *
 * In the second stage, the ERs that passed the first stage are classified into character and
 * non-character classes using more informative but also more computationally expensive features. The
 * classifier uses all the features calculated in the first stage and the following additional
 * features: hole area ratio, convex hull ratio, and number of outer inflexion points.
 */
+ (ERFilter*)createERFilterNM2:(ERFilterCallback*)cb NS_SWIFT_NAME(createERFilterNM2(cb:));


//
//  Ptr_ERFilter cv::text::createERFilterNM1(String filename, int thresholdDelta = 1, float minArea = (float)0.00025, float maxArea = (float)0.13, float minProbability = (float)0.4, bool nonMaxSuppression = true, float minProbabilityDiff = (float)0.1)
//
/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea minProbability:(float)minProbability nonMaxSuppression:(BOOL)nonMaxSuppression minProbabilityDiff:(float)minProbabilityDiff NS_SWIFT_NAME(createERFilterNM1(filename:thresholdDelta:minArea:maxArea:minProbability:nonMaxSuppression:minProbabilityDiff:));

/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea minProbability:(float)minProbability nonMaxSuppression:(BOOL)nonMaxSuppression NS_SWIFT_NAME(createERFilterNM1(filename:thresholdDelta:minArea:maxArea:minProbability:nonMaxSuppression:));

/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea minProbability:(float)minProbability NS_SWIFT_NAME(createERFilterNM1(filename:thresholdDelta:minArea:maxArea:minProbability:));

/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename thresholdDelta:(int)thresholdDelta minArea:(float)minArea maxArea:(float)maxArea NS_SWIFT_NAME(createERFilterNM1(filename:thresholdDelta:minArea:maxArea:));

/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename thresholdDelta:(int)thresholdDelta minArea:(float)minArea NS_SWIFT_NAME(createERFilterNM1(filename:thresholdDelta:minArea:));

/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename thresholdDelta:(int)thresholdDelta NS_SWIFT_NAME(createERFilterNM1(filename:thresholdDelta:));

/**
 * Reads an Extremal Region Filter for the 1st stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM1.xml
 *
 */
+ (ERFilter*)createERFilterNM1FromFile:(NSString*)filename NS_SWIFT_NAME(createERFilterNM1(filename:));


//
//  Ptr_ERFilter cv::text::createERFilterNM2(String filename, float minProbability = (float)0.3)
//
/**
 * Reads an Extremal Region Filter for the 2nd stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM2.xml
 *
 */
+ (ERFilter*)createERFilterNM2FromFile:(NSString*)filename minProbability:(float)minProbability NS_SWIFT_NAME(createERFilterNM2(filename:minProbability:));

/**
 * Reads an Extremal Region Filter for the 2nd stage classifier of N&M algorithm
 *     from the provided path e.g. /path/to/cpp/trained_classifierNM2.xml
 *
 */
+ (ERFilter*)createERFilterNM2FromFile:(NSString*)filename NS_SWIFT_NAME(createERFilterNM2(filename:));


//
//  Ptr_ERFilter_Callback cv::text::loadClassifierNM1(String filename)
//
/**
 * Allow to implicitly load the default classifier when creating an ERFilter object.
 *
 * @param filename The XML or YAML file with the classifier model (e.g. trained_classifierNM1.xml)
 *
 * returns a pointer to ERFilter::Callback.
 */
+ (ERFilterCallback*)loadClassifierNM1:(NSString*)filename NS_SWIFT_NAME(loadClassifierNM1(filename:));


//
//  Ptr_ERFilter_Callback cv::text::loadClassifierNM2(String filename)
//
/**
 * Allow to implicitly load the default classifier when creating an ERFilter object.
 *
 * @param filename The XML or YAML file with the classifier model (e.g. trained_classifierNM2.xml)
 *
 * returns a pointer to ERFilter::Callback.
 */
+ (ERFilterCallback*)loadClassifierNM2:(NSString*)filename NS_SWIFT_NAME(loadClassifierNM2(filename:));


//
//  void cv::text::computeNMChannels(Mat _src, vector_Mat& _channels, int _mode = ERFILTER_NM_RGBLGrad)
//
/**
 * Compute the different channels to be processed independently in the N&M algorithm CITE: Neumann12.
 *
 * @param _src Source image. Must be RGB CV_8UC3.
 *
 * @param _channels Output vector\<Mat\> where computed channels are stored.
 *
 * @param _mode Mode of operation. Currently the only available options are:
 * *ERFILTER_NM_RGBLGrad** (used by default) and **ERFILTER_NM_IHSGrad**.
 *
 * In N&M algorithm, the combination of intensity (I), hue (H), saturation (S), and gradient magnitude
 * channels (Grad) are used in order to obtain high localization recall. This implementation also
 * provides an alternative combination of red (R), green (G), blue (B), lightness (L), and gradient
 * magnitude (Grad).
 */
+ (void)computeNMChannels:(Mat*)_src _channels:(NSMutableArray<Mat*>*)_channels _mode:(int)_mode NS_SWIFT_NAME(computeNMChannels(_src:_channels:_mode:));

/**
 * Compute the different channels to be processed independently in the N&M algorithm CITE: Neumann12.
 *
 * @param _src Source image. Must be RGB CV_8UC3.
 *
 * @param _channels Output vector\<Mat\> where computed channels are stored.
 *
 * *ERFILTER_NM_RGBLGrad** (used by default) and **ERFILTER_NM_IHSGrad**.
 *
 * In N&M algorithm, the combination of intensity (I), hue (H), saturation (S), and gradient magnitude
 * channels (Grad) are used in order to obtain high localization recall. This implementation also
 * provides an alternative combination of red (R), green (G), blue (B), lightness (L), and gradient
 * magnitude (Grad).
 */
+ (void)computeNMChannels:(Mat*)_src _channels:(NSMutableArray<Mat*>*)_channels NS_SWIFT_NAME(computeNMChannels(_src:_channels:));


//
//  void cv::text::erGrouping(Mat image, Mat channel, vector_vector_Point regions, vector_Rect& groups_rects, erGrouping_Modes method = ERGROUPING_ORIENTATION_HORIZ, String filename = String(), float minProbablity = (float)0.5)
//
/**
 * Find groups of Extremal Regions that are organized as text blocks.
 *
 *
 *
 * @param regions Vector of ER's retrieved from the ERFilter algorithm from each channel.
 *
 * provided regions.
 *
 * @param groups_rects The output of the algorithm are stored in this parameter as list of rectangles.
 *
 * @param method Grouping method (see text::erGrouping_Modes). Can be one of ERGROUPING_ORIENTATION_HORIZ,
 * ERGROUPING_ORIENTATION_ANY.
 *
 * @param filename The XML or YAML file with the classifier model (e.g.
 * samples/trained_classifier_erGrouping.xml). Only to use when grouping method is
 * ERGROUPING_ORIENTATION_ANY.
 *
 * @param minProbablity The minimum probability for accepting a group. Only to use when grouping
 * method is ERGROUPING_ORIENTATION_ANY.
 */
+ (void)erGrouping:(Mat*)image channel:(Mat*)channel regions:(NSArray<NSArray<Point2i*>*>*)regions groups_rects:(NSMutableArray<Rect2i*>*)groups_rects method:(erGrouping_Modes)method filename:(NSString*)filename minProbablity:(float)minProbablity NS_SWIFT_NAME(erGrouping(image:channel:regions:groups_rects:method:filename:minProbablity:));

/**
 * Find groups of Extremal Regions that are organized as text blocks.
 *
 *
 *
 * @param regions Vector of ER's retrieved from the ERFilter algorithm from each channel.
 *
 * provided regions.
 *
 * @param groups_rects The output of the algorithm are stored in this parameter as list of rectangles.
 *
 * @param method Grouping method (see text::erGrouping_Modes). Can be one of ERGROUPING_ORIENTATION_HORIZ,
 * ERGROUPING_ORIENTATION_ANY.
 *
 * @param filename The XML or YAML file with the classifier model (e.g.
 * samples/trained_classifier_erGrouping.xml). Only to use when grouping method is
 * ERGROUPING_ORIENTATION_ANY.
 *
 * method is ERGROUPING_ORIENTATION_ANY.
 */
+ (void)erGrouping:(Mat*)image channel:(Mat*)channel regions:(NSArray<NSArray<Point2i*>*>*)regions groups_rects:(NSMutableArray<Rect2i*>*)groups_rects method:(erGrouping_Modes)method filename:(NSString*)filename NS_SWIFT_NAME(erGrouping(image:channel:regions:groups_rects:method:filename:));

/**
 * Find groups of Extremal Regions that are organized as text blocks.
 *
 *
 *
 * @param regions Vector of ER's retrieved from the ERFilter algorithm from each channel.
 *
 * provided regions.
 *
 * @param groups_rects The output of the algorithm are stored in this parameter as list of rectangles.
 *
 * @param method Grouping method (see text::erGrouping_Modes). Can be one of ERGROUPING_ORIENTATION_HORIZ,
 * ERGROUPING_ORIENTATION_ANY.
 *
 * samples/trained_classifier_erGrouping.xml). Only to use when grouping method is
 * ERGROUPING_ORIENTATION_ANY.
 *
 * method is ERGROUPING_ORIENTATION_ANY.
 */
+ (void)erGrouping:(Mat*)image channel:(Mat*)channel regions:(NSArray<NSArray<Point2i*>*>*)regions groups_rects:(NSMutableArray<Rect2i*>*)groups_rects method:(erGrouping_Modes)method NS_SWIFT_NAME(erGrouping(image:channel:regions:groups_rects:method:));

/**
 * Find groups of Extremal Regions that are organized as text blocks.
 *
 *
 *
 * @param regions Vector of ER's retrieved from the ERFilter algorithm from each channel.
 *
 * provided regions.
 *
 * @param groups_rects The output of the algorithm are stored in this parameter as list of rectangles.
 *
 * ERGROUPING_ORIENTATION_ANY.
 *
 * samples/trained_classifier_erGrouping.xml). Only to use when grouping method is
 * ERGROUPING_ORIENTATION_ANY.
 *
 * method is ERGROUPING_ORIENTATION_ANY.
 */
+ (void)erGrouping:(Mat*)image channel:(Mat*)channel regions:(NSArray<NSArray<Point2i*>*>*)regions groups_rects:(NSMutableArray<Rect2i*>*)groups_rects NS_SWIFT_NAME(erGrouping(image:channel:regions:groups_rects:));


//
//  void cv::text::detectRegions(Mat image, Ptr_ERFilter er_filter1, Ptr_ERFilter er_filter2, vector_vector_Point& regions)
//
/**
 * Converts MSER contours (vector\<Point\>) to ERStat regions.
 *
 * @param image Source image CV_8UC1 from which the MSERs where extracted.
 *
 *
 * @param regions Output where the ERStat regions are stored.
 *
 * It takes as input the contours provided by the OpenCV MSER feature detector and returns as output
 * two vectors of ERStats. This is because MSER() output contains both MSER+ and MSER- regions in a
 * single vector\<Point\>, the function separates them in two different vectors (this is as if the
 * ERStats where extracted from two different channels).
 *
 * An example of MSERsToERStats in use can be found in the text detection webcam_demo:
 * <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/webcam_demo.cpp>
 */
+ (void)detectRegions:(Mat*)image er_filter1:(ERFilter*)er_filter1 er_filter2:(ERFilter*)er_filter2 regions:(NSMutableArray<NSMutableArray<Point2i*>*>*)regions NS_SWIFT_NAME(detectRegions(image:er_filter1:er_filter2:regions:));


//
//  void cv::text::detectRegions(Mat image, Ptr_ERFilter er_filter1, Ptr_ERFilter er_filter2, vector_Rect& groups_rects, erGrouping_Modes method = ERGROUPING_ORIENTATION_HORIZ, String filename = String(), float minProbability = (float)0.5)
//
/**
 * Extracts text regions from image.
 *
 * @param image Source image where text blocks needs to be extracted from.  Should be CV_8UC3 (color).
 * @param er_filter1 Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12
 * @param er_filter2 Extremal Region Filter for the 2nd stage classifier of N&M algorithm CITE: Neumann12
 * @param groups_rects Output list of rectangle blocks with text
 * @param method Grouping method (see text::erGrouping_Modes). Can be one of ERGROUPING_ORIENTATION_HORIZ, ERGROUPING_ORIENTATION_ANY.
 * @param filename The XML or YAML file with the classifier model (e.g. samples/trained_classifier_erGrouping.xml). Only to use when grouping method is ERGROUPING_ORIENTATION_ANY.
 * @param minProbability The minimum probability for accepting a group. Only to use when grouping method is ERGROUPING_ORIENTATION_ANY.
 */
+ (void)detectRegions:(Mat*)image er_filter1:(ERFilter*)er_filter1 er_filter2:(ERFilter*)er_filter2 groups_rects:(NSMutableArray<Rect2i*>*)groups_rects method:(erGrouping_Modes)method filename:(NSString*)filename minProbability:(float)minProbability NS_SWIFT_NAME(detectRegions(image:er_filter1:er_filter2:groups_rects:method:filename:minProbability:));

/**
 * Extracts text regions from image.
 *
 * @param image Source image where text blocks needs to be extracted from.  Should be CV_8UC3 (color).
 * @param er_filter1 Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12
 * @param er_filter2 Extremal Region Filter for the 2nd stage classifier of N&M algorithm CITE: Neumann12
 * @param groups_rects Output list of rectangle blocks with text
 * @param method Grouping method (see text::erGrouping_Modes). Can be one of ERGROUPING_ORIENTATION_HORIZ, ERGROUPING_ORIENTATION_ANY.
 * @param filename The XML or YAML file with the classifier model (e.g. samples/trained_classifier_erGrouping.xml). Only to use when grouping method is ERGROUPING_ORIENTATION_ANY.
 */
+ (void)detectRegions:(Mat*)image er_filter1:(ERFilter*)er_filter1 er_filter2:(ERFilter*)er_filter2 groups_rects:(NSMutableArray<Rect2i*>*)groups_rects method:(erGrouping_Modes)method filename:(NSString*)filename NS_SWIFT_NAME(detectRegions(image:er_filter1:er_filter2:groups_rects:method:filename:));

/**
 * Extracts text regions from image.
 *
 * @param image Source image where text blocks needs to be extracted from.  Should be CV_8UC3 (color).
 * @param er_filter1 Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12
 * @param er_filter2 Extremal Region Filter for the 2nd stage classifier of N&M algorithm CITE: Neumann12
 * @param groups_rects Output list of rectangle blocks with text
 * @param method Grouping method (see text::erGrouping_Modes). Can be one of ERGROUPING_ORIENTATION_HORIZ, ERGROUPING_ORIENTATION_ANY.
 */
+ (void)detectRegions:(Mat*)image er_filter1:(ERFilter*)er_filter1 er_filter2:(ERFilter*)er_filter2 groups_rects:(NSMutableArray<Rect2i*>*)groups_rects method:(erGrouping_Modes)method NS_SWIFT_NAME(detectRegions(image:er_filter1:er_filter2:groups_rects:method:));

/**
 * Extracts text regions from image.
 *
 * @param image Source image where text blocks needs to be extracted from.  Should be CV_8UC3 (color).
 * @param er_filter1 Extremal Region Filter for the 1st stage classifier of N&M algorithm CITE: Neumann12
 * @param er_filter2 Extremal Region Filter for the 2nd stage classifier of N&M algorithm CITE: Neumann12
 * @param groups_rects Output list of rectangle blocks with text
 */
+ (void)detectRegions:(Mat*)image er_filter1:(ERFilter*)er_filter1 er_filter2:(ERFilter*)er_filter2 groups_rects:(NSMutableArray<Rect2i*>*)groups_rects NS_SWIFT_NAME(detectRegions(image:er_filter1:er_filter2:groups_rects:));


//
//  Ptr_OCRHMMDecoder_ClassifierCallback cv::text::loadOCRHMMClassifierNM(String filename)
//
/**
 * Allow to implicitly load the default character classifier when creating an OCRHMMDecoder object.
 *
 * @param filename The XML or YAML file with the classifier model (e.g. OCRHMM_knn_model_data.xml)
 *
 * The KNN default classifier is based in the scene text recognition method proposed by Lukás Neumann &
 * Jiri Matas in [Neumann11b]. Basically, the region (contour) in the input image is normalized to a
 * fixed size, while retaining the centroid and aspect ratio, in order to extract a feature vector
 * based on gradient orientations along the chain-code of its perimeter. Then, the region is classified
 * using a KNN model trained with synthetic data of rendered characters with different standard font
 * types.
 *
 * @deprecated loadOCRHMMClassifier instead
 */
+ (OCRHMMDecoderClassifierCallback*)loadOCRHMMClassifierNM:(NSString*)filename NS_SWIFT_NAME(loadOCRHMMClassifierNM(filename:)) DEPRECATED_ATTRIBUTE;


//
//  Ptr_OCRHMMDecoder_ClassifierCallback cv::text::loadOCRHMMClassifierCNN(String filename)
//
/**
 * Allow to implicitly load the default character classifier when creating an OCRHMMDecoder object.
 *
 * @param filename The XML or YAML file with the classifier model (e.g. OCRBeamSearch_CNN_model_data.xml.gz)
 *
 * The CNN default classifier is based in the scene text recognition method proposed by Adam Coates &
 * Andrew NG in [Coates11a]. The character classifier consists in a Single Layer Convolutional Neural Network and
 * a linear classifier. It is applied to the input image in a sliding window fashion, providing a set of recognitions
 * at each window location.
 *
 * @deprecated use loadOCRHMMClassifier instead
 */
+ (OCRHMMDecoderClassifierCallback*)loadOCRHMMClassifierCNN:(NSString*)filename NS_SWIFT_NAME(loadOCRHMMClassifierCNN(filename:)) DEPRECATED_ATTRIBUTE;


//
//  Ptr_OCRHMMDecoder_ClassifierCallback cv::text::loadOCRHMMClassifier(String filename, classifier_type classifier)
//
/**
 * Allow to implicitly load the default character classifier when creating an OCRHMMDecoder object.
 *
 * @param filename The XML or YAML file with the classifier model (e.g. OCRBeamSearch_CNN_model_data.xml.gz)
 *
 * @param classifier Can be one of classifier_type enum values.
 */
+ (OCRHMMDecoderClassifierCallback*)loadOCRHMMClassifier:(NSString*)filename classifier:(classifier_type)classifier NS_SWIFT_NAME(loadOCRHMMClassifier(filename:classifier:));


//
//  Mat cv::text::createOCRHMMTransitionsTable(String vocabulary, vector_String lexicon)
//
/**
 * Utility function to create a tailored language model transitions table from a given list of words (lexicon).
 *
 * @param vocabulary The language vocabulary (chars when ASCII English text).
 *
 * @param lexicon The list of words that are expected to be found in a particular image.
 *
 *
 * The function calculate frequency statistics of character pairs from the given lexicon and fills the output transition_probabilities_table with them. The transition_probabilities_table can be used as input in the OCRHMMDecoder::create() and OCRBeamSearchDecoder::create() methods.
 * NOTE:
 * -   (C++) An alternative would be to load the default generic language transition table provided in the text module samples folder (created from ispell 42869 english words list) :
 * <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/OCRHMM_transitions_table.xml>
 *
 */
+ (Mat*)createOCRHMMTransitionsTable:(NSString*)vocabulary lexicon:(NSArray<NSString*>*)lexicon NS_SWIFT_NAME(createOCRHMMTransitionsTable(vocabulary:lexicon:));


//
//  Ptr_OCRBeamSearchDecoder_ClassifierCallback cv::text::loadOCRBeamSearchClassifierCNN(String filename)
//
/**
 * Allow to implicitly load the default character classifier when creating an OCRBeamSearchDecoder object.
 *
 * @param filename The XML or YAML file with the classifier model (e.g. OCRBeamSearch_CNN_model_data.xml.gz)
 *
 * The CNN default classifier is based in the scene text recognition method proposed by Adam Coates &
 * Andrew NG in [Coates11a]. The character classifier consists in a Single Layer Convolutional Neural Network and
 * a linear classifier. It is applied to the input image in a sliding window fashion, providing a set of recognitions
 * at each window location.
 */
+ (OCRBeamSearchDecoderClassifierCallback*)loadOCRBeamSearchClassifierCNN:(NSString*)filename NS_SWIFT_NAME(loadOCRBeamSearchClassifierCNN(filename:));



@end

NS_ASSUME_NONNULL_END


