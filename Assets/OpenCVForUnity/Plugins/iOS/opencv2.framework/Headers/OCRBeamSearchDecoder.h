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
@class OCRBeamSearchDecoderClassifierCallback;



NS_ASSUME_NONNULL_BEGIN

// C++: class OCRBeamSearchDecoder
/**
 * OCRBeamSearchDecoder class provides an interface for OCR using Beam Search algorithm.
 *
 * NOTE:
 *    -   (C++) An example on using OCRBeamSearchDecoder recognition combined with scene text detection can
 *         be found at the demo sample:
 *         <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/word_recognition.cpp>
 *
 * Member of `Text`
 */
CV_EXPORTS @interface OCRBeamSearchDecoder : BaseOCR


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::OCRBeamSearchDecoder> nativePtrOCRBeamSearchDecoder;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::OCRBeamSearchDecoder>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::OCRBeamSearchDecoder>)nativePtr;
#endif


#pragma mark - Methods


//
//  String cv::text::OCRBeamSearchDecoder::run(Mat image, int min_confidence, int component_level = 0)
//
/**
 * Recognize text using Beam Search.
 *
 *     Takes image on input and returns recognized text in the output_text parameter. Optionally
 *     provides also the Rects for individual text elements found (e.g. words), and the list of those
 *     text elements with their confidence values.
 *
 * @param image Input binary image CV_8UC1 with a single text line (or word).
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
 * Recognize text using Beam Search.
 *
 *     Takes image on input and returns recognized text in the output_text parameter. Optionally
 *     provides also the Rects for individual text elements found (e.g. words), and the list of those
 *     text elements with their confidence values.
 *
 * @param image Input binary image CV_8UC1 with a single text line (or word).
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
//  String cv::text::OCRBeamSearchDecoder::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//
- (NSString*)run:(Mat*)image mask:(Mat*)mask min_confidence:(int)min_confidence component_level:(int)component_level NS_SWIFT_NAME(run(image:mask:min_confidence:component_level:));

- (NSString*)run:(Mat*)image mask:(Mat*)mask min_confidence:(int)min_confidence NS_SWIFT_NAME(run(image:mask:min_confidence:));


//
// static Ptr_OCRBeamSearchDecoder cv::text::OCRBeamSearchDecoder::create(Ptr_OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, decoder_mode mode, int beam_size = 500)
//
/**
 * Creates an instance of the OCRBeamSearchDecoder class. Initializes HMMDecoder.
 *
 * @param classifier The character classifier with built in feature extractor.
 *
 * @param vocabulary The language vocabulary (chars when ASCII English text). vocabulary.size()
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
 *
 * @param beam_size Size of the beam in Beam Search algorithm.
 */
+ (OCRBeamSearchDecoder*)create:(OCRBeamSearchDecoderClassifierCallback*)classifier vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table mode:(decoder_mode)mode beam_size:(int)beam_size NS_SWIFT_NAME(create(classifier:vocabulary:transition_probabilities_table:emission_probabilities_table:mode:beam_size:));

/**
 * Creates an instance of the OCRBeamSearchDecoder class. Initializes HMMDecoder.
 *
 * @param classifier The character classifier with built in feature extractor.
 *
 * @param vocabulary The language vocabulary (chars when ASCII English text). vocabulary.size()
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
 *
 */
+ (OCRBeamSearchDecoder*)create:(OCRBeamSearchDecoderClassifierCallback*)classifier vocabulary:(NSString*)vocabulary transition_probabilities_table:(Mat*)transition_probabilities_table emission_probabilities_table:(Mat*)emission_probabilities_table mode:(decoder_mode)mode NS_SWIFT_NAME(create(classifier:vocabulary:transition_probabilities_table:emission_probabilities_table:mode:));



@end

NS_ASSUME_NONNULL_END


