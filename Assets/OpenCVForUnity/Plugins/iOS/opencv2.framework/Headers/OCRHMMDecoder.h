//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/text.hpp"
#import "opencv2/text/ocr.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "BaseOCR.h"

#import "Text.h"
@class Mat;
@class OCRHMMDecoderClassifierCallback;



NS_ASSUME_NONNULL_BEGIN

// C++: class OCRHMMDecoder
/**
 * OCRHMMDecoder class provides an interface for OCR using Hidden Markov Models.
 *
 * NOTE:
 *    -   (C++) An example on using OCRHMMDecoder recognition combined with scene text detection can
 *         be found at the webcam_demo sample:
 *         <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/webcam_demo.cpp>
 *
 * Member of `Text`
 */
CV_EXPORTS @interface OCRHMMDecoder : BaseOCR


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::OCRHMMDecoder> nativePtrOCRHMMDecoder;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::OCRHMMDecoder>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::OCRHMMDecoder>)nativePtr;
#endif


#pragma mark - Methods


//
//  String cv::text::OCRHMMDecoder::run(Mat image, int min_confidence, int component_level = 0)
//
/**
 * Recognize text using HMM.
 *
 *     Takes an image and a mask (where each connected component corresponds to a segmented character)
 *     on input and returns recognized text in the output_text parameter. Optionally
 *     provides also the Rects for individual text elements found (e.g. words), and the list of those
 *     text elements with their confidence values.
 *
 * @param image Input image CV_8UC1 or CV_8UC3 with a single text line (or word).
 *
 *
 *     text elements found (e.g. words).
 *
 *     recognition of individual text elements found (e.g. words).
 *
 *     for the recognition of individual text elements found (e.g. words).
 *
 * @param component_level Only OCR_LEVEL_WORD is supported.
 */
- (NSString*)run:(Mat*)image min_confidence:(int)min_confidence component_level:(int)component_level NS_SWIFT_NAME(run(image:min_confidence:component_level:));

/**
 * Recognize text using HMM.
 *
 *     Takes an image and a mask (where each connected component corresponds to a segmented character)
 *     on input and returns recognized text in the output_text parameter. Optionally
 *     provides also the Rects for individual text elements found (e.g. words), and the list of those
 *     text elements with their confidence values.
 *
 * @param image Input image CV_8UC1 or CV_8UC3 with a single text line (or word).
 *
 *
 *     text elements found (e.g. words).
 *
 *     recognition of individual text elements found (e.g. words).
 *
 *     for the recognition of individual text elements found (e.g. words).
 *
 */
- (NSString*)run:(Mat*)image min_confidence:(int)min_confidence NS_SWIFT_NAME(run(image:min_confidence:));


//
//  String cv::text::OCRHMMDecoder::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//
- (NSString*)run:(Mat*)image mask:(Mat*)mask min_confidence:(int)min_confidence component_level:(int)component_level NS_SWIFT_NAME(run(image:mask:min_confidence:component_level:));

- (NSString*)run:(Mat*)image mask:(Mat*)mask min_confidence:(int)min_confidence NS_SWIFT_NAME(run(image:mask:min_confidence:));


//
// static Ptr_OCRHMMDecoder cv::text::OCRHMMDecoder::create(Ptr_OCRHMMDecoder_ClassifierCallback classifier, String vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, decoder_mode mode = OCR_DECODER_VITERBI)
//
/**
 * Creates an instance of the OCRHMMDecoder class. Initializes HMMDecoder.
 *
 * @param classifier The character classifier with built in feature extractor.
 *
 * @param vocabulary The language vocabulary (chars when ascii english text). vocabulary.size()
 *     must be equal to the number of classes of the classifier.
 *
 * @param transition_probabilities_table Table with transition probabilities between character
 *     pairs. cols == rows == vocabulary.size().
 *
 * @param emission_probabilities_table Table with observation emission probabilities. cols ==
 *     rows == vocabulary.size().
 *
 * @param mode HMM Decoding algorithm. Only OCR_DECODER_VITERBI is available for the moment
 *     (<http://en.wikipedia.org/wiki/Viterbi_algorithm>).
 */
+ (OCRHMMDecoder*)create:(OCRHMMDecoderClassifierCallback*)classifier vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table mode:(decoder_mode)mode NS_SWIFT_NAME(create(classifier:vocabulary:transition_probabilities_table:emission_probabilities_table:mode:));

/**
 * Creates an instance of the OCRHMMDecoder class. Initializes HMMDecoder.
 *
 * @param classifier The character classifier with built in feature extractor.
 *
 * @param vocabulary The language vocabulary (chars when ascii english text). vocabulary.size()
 *     must be equal to the number of classes of the classifier.
 *
 * @param transition_probabilities_table Table with transition probabilities between character
 *     pairs. cols == rows == vocabulary.size().
 *
 * @param emission_probabilities_table Table with observation emission probabilities. cols ==
 *     rows == vocabulary.size().
 *
 *     (<http://en.wikipedia.org/wiki/Viterbi_algorithm>).
 */
+ (OCRHMMDecoder*)create:(OCRHMMDecoderClassifierCallback*)classifier vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table NS_SWIFT_NAME(create(classifier:vocabulary:transition_probabilities_table:emission_probabilities_table:));


//
// static Ptr_OCRHMMDecoder cv::text::OCRHMMDecoder::create(String filename, String vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, decoder_mode mode = OCR_DECODER_VITERBI, int classifier = OCR_KNN_CLASSIFIER)
//
/**
 * Creates an instance of the OCRHMMDecoder class. Loads and initializes HMMDecoder from the specified path
 *
 *      
 */
+ (OCRHMMDecoder*)createFromFile:(NSString*)filename vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table mode:(decoder_mode)mode classifier:(int)classifier NS_SWIFT_NAME(create(filename:vocabulary:transition_probabilities_table:emission_probabilities_table:mode:classifier:));

/**
 * Creates an instance of the OCRHMMDecoder class. Loads and initializes HMMDecoder from the specified path
 *
 *      
 */
+ (OCRHMMDecoder*)createFromFile:(NSString*)filename vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table mode:(decoder_mode)mode NS_SWIFT_NAME(create(filename:vocabulary:transition_probabilities_table:emission_probabilities_table:mode:));

/**
 * Creates an instance of the OCRHMMDecoder class. Loads and initializes HMMDecoder from the specified path
 *
 *      
 */
+ (OCRHMMDecoder*)createFromFile:(NSString*)filename vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table NS_SWIFT_NAME(create(filename:vocabulary:transition_probabilities_table:emission_probabilities_table:));



@end

NS_ASSUME_NONNULL_END


