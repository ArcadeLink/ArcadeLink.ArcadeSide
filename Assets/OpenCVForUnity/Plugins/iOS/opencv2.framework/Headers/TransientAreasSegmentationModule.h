//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/bioinspired.hpp"
#import "opencv2/bioinspired/transientareassegmentationmodule.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;
@class Size2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class TransientAreasSegmentationModule
/**
 * class which provides a transient/moving areas segmentation module
 *
 * perform a locally adapted segmentation by using the retina magno input data Based on Alexandre
 * BENOIT thesis: "Le système visuel humain au secours de la vision par ordinateur"
 *
 * 3 spatio temporal filters are used:
 * - a first one which filters the noise and local variations of the input motion energy
 * - a second (more powerfull low pass spatial filter) which gives the neighborhood motion energy the
 * segmentation consists in the comparison of these both outputs, if the local motion energy is higher
 * to the neighborhood otion energy, then the area is considered as moving and is segmented
 * - a stronger third low pass filter helps decision by providing a smooth information about the
 * "motion context" in a wider area
 *
 * Member of `Bioinspired`
 */
CV_EXPORTS @interface TransientAreasSegmentationModule : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bioinspired::TransientAreasSegmentationModule> nativePtrTransientAreasSegmentationModule;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bioinspired::TransientAreasSegmentationModule>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bioinspired::TransientAreasSegmentationModule>)nativePtr;
#endif


#pragma mark - Methods


//
//  Size cv::bioinspired::TransientAreasSegmentationModule::getSize()
//
/**
 * return the sze of the manage input and output images
 */
- (Size2i*)getSize NS_SWIFT_NAME(getSize());


//
//  void cv::bioinspired::TransientAreasSegmentationModule::setup(String segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
//
/**
 * try to open an XML segmentation parameters file to adjust current segmentation instance setup
 *
 *     - if the xml file does not exist, then default setup is applied
 *     - warning, Exceptions are thrown if read XML file is not valid
 * @param segmentationParameterFile : the parameters filename
 * @param applyDefaultSetupOnFailure : set to true if an error must be thrown on error
 */
- (void)setup:(NSString*)segmentationParameterFile applyDefaultSetupOnFailure:(BOOL)applyDefaultSetupOnFailure NS_SWIFT_NAME(setup(segmentationParameterFile:applyDefaultSetupOnFailure:));

/**
 * try to open an XML segmentation parameters file to adjust current segmentation instance setup
 *
 *     - if the xml file does not exist, then default setup is applied
 *     - warning, Exceptions are thrown if read XML file is not valid
 * @param segmentationParameterFile : the parameters filename
 */
- (void)setup:(NSString*)segmentationParameterFile NS_SWIFT_NAME(setup(segmentationParameterFile:));

/**
 * try to open an XML segmentation parameters file to adjust current segmentation instance setup
 *
 *     - if the xml file does not exist, then default setup is applied
 *     - warning, Exceptions are thrown if read XML file is not valid
 */
- (void)setup NS_SWIFT_NAME(setup());


//
//  String cv::bioinspired::TransientAreasSegmentationModule::printSetup()
//
/**
 * parameters setup display method
 *     @return a string which contains formatted parameters information
 */
- (NSString*)printSetup NS_SWIFT_NAME(printSetup());


//
//  void cv::bioinspired::TransientAreasSegmentationModule::write(String fs)
//
/**
 * write xml/yml formated parameters information
 * @param fs : the filename of the xml file that will be open and writen with formatted parameters information
 */
- (void)write:(NSString*)fs NS_SWIFT_NAME(write(fs:));


//
//  void cv::bioinspired::TransientAreasSegmentationModule::run(Mat inputToSegment, int channelIndex = 0)
//
/**
 * main processing method, get result using methods getSegmentationPicture()
 * @param inputToSegment : the image to process, it must match the instance buffer size !
 * @param channelIndex : the channel to process in case of multichannel images
 */
- (void)run:(Mat*)inputToSegment channelIndex:(int)channelIndex NS_SWIFT_NAME(run(inputToSegment:channelIndex:));

/**
 * main processing method, get result using methods getSegmentationPicture()
 * @param inputToSegment : the image to process, it must match the instance buffer size !
 */
- (void)run:(Mat*)inputToSegment NS_SWIFT_NAME(run(inputToSegment:));


//
//  void cv::bioinspired::TransientAreasSegmentationModule::getSegmentationPicture(Mat& transientAreas)
//
/**
 * access function
 *     return the last segmentation result: a boolean picture which is resampled between 0 and 255 for a display purpose
 */
- (void)getSegmentationPicture:(Mat*)transientAreas NS_SWIFT_NAME(getSegmentationPicture(transientAreas:));


//
//  void cv::bioinspired::TransientAreasSegmentationModule::clearAllBuffers()
//
/**
 * cleans all the buffers of the instance
 */
- (void)clearAllBuffers NS_SWIFT_NAME(clearAllBuffers());


//
// static Ptr_TransientAreasSegmentationModule cv::bioinspired::TransientAreasSegmentationModule::create(Size inputSize)
//
/**
 * allocator
 * @param inputSize : size of the images input to segment (output will be the same size)
 */
+ (TransientAreasSegmentationModule*)create:(Size2i*)inputSize NS_SWIFT_NAME(create(inputSize:));



@end

NS_ASSUME_NONNULL_END


