//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/bgsegm.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class BackgroundSubtractorCNT;
@class BackgroundSubtractorGMG;
@class BackgroundSubtractorGSOC;
@class BackgroundSubtractorLSBP;
@class BackgroundSubtractorMOG;
@class Mat;
@class SyntheticSequenceGenerator;


// C++: enum LSBPCameraMotionCompensation (cv.bgsegm.LSBPCameraMotionCompensation)
typedef NS_ENUM(int, LSBPCameraMotionCompensation) {
    LSBP_CAMERA_MOTION_COMPENSATION_NONE = 0,
    LSBP_CAMERA_MOTION_COMPENSATION_LK = 0+1
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Bgsegm
/**
 * The Bgsegm module
 *
 * Member classes: `BackgroundSubtractorMOG`, `BackgroundSubtractorGMG`, `BackgroundSubtractorCNT`, `BackgroundSubtractorGSOC`, `BackgroundSubtractorLSBP`, `BackgroundSubtractorLSBPDesc`, `SyntheticSequenceGenerator`
 *
 * Member enums: `LSBPCameraMotionCompensation`
 */
CV_EXPORTS @interface Bgsegm : NSObject

#pragma mark - Methods


//
//  Ptr_BackgroundSubtractorMOG cv::bgsegm::createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
//
/**
 * Creates mixture-of-gaussian background subtractor
 *
 * @param history Length of the history.
 * @param nmixtures Number of Gaussian mixtures.
 * @param backgroundRatio Background ratio.
 * @param noiseSigma Noise strength (standard deviation of the brightness or each color channel). 0
 * means some automatic value.
 */
+ (BackgroundSubtractorMOG*)createBackgroundSubtractorMOG:(int)history nmixtures:(int)nmixtures backgroundRatio:(double)backgroundRatio noiseSigma:(double)noiseSigma NS_SWIFT_NAME(createBackgroundSubtractorMOG(history:nmixtures:backgroundRatio:noiseSigma:));

/**
 * Creates mixture-of-gaussian background subtractor
 *
 * @param history Length of the history.
 * @param nmixtures Number of Gaussian mixtures.
 * @param backgroundRatio Background ratio.
 * means some automatic value.
 */
+ (BackgroundSubtractorMOG*)createBackgroundSubtractorMOG:(int)history nmixtures:(int)nmixtures backgroundRatio:(double)backgroundRatio NS_SWIFT_NAME(createBackgroundSubtractorMOG(history:nmixtures:backgroundRatio:));

/**
 * Creates mixture-of-gaussian background subtractor
 *
 * @param history Length of the history.
 * @param nmixtures Number of Gaussian mixtures.
 * means some automatic value.
 */
+ (BackgroundSubtractorMOG*)createBackgroundSubtractorMOG:(int)history nmixtures:(int)nmixtures NS_SWIFT_NAME(createBackgroundSubtractorMOG(history:nmixtures:));

/**
 * Creates mixture-of-gaussian background subtractor
 *
 * @param history Length of the history.
 * means some automatic value.
 */
+ (BackgroundSubtractorMOG*)createBackgroundSubtractorMOG:(int)history NS_SWIFT_NAME(createBackgroundSubtractorMOG(history:));

/**
 * Creates mixture-of-gaussian background subtractor
 *
 * means some automatic value.
 */
+ (BackgroundSubtractorMOG*)createBackgroundSubtractorMOG NS_SWIFT_NAME(createBackgroundSubtractorMOG());


//
//  Ptr_BackgroundSubtractorGMG cv::bgsegm::createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
//
/**
 * Creates a GMG Background Subtractor
 *
 * @param initializationFrames number of frames used to initialize the background models.
 * @param decisionThreshold Threshold value, above which it is marked foreground, else background.
 */
+ (BackgroundSubtractorGMG*)createBackgroundSubtractorGMG:(int)initializationFrames decisionThreshold:(double)decisionThreshold NS_SWIFT_NAME(createBackgroundSubtractorGMG(initializationFrames:decisionThreshold:));

/**
 * Creates a GMG Background Subtractor
 *
 * @param initializationFrames number of frames used to initialize the background models.
 */
+ (BackgroundSubtractorGMG*)createBackgroundSubtractorGMG:(int)initializationFrames NS_SWIFT_NAME(createBackgroundSubtractorGMG(initializationFrames:));

/**
 * Creates a GMG Background Subtractor
 *
 */
+ (BackgroundSubtractorGMG*)createBackgroundSubtractorGMG NS_SWIFT_NAME(createBackgroundSubtractorGMG());


//
//  Ptr_BackgroundSubtractorCNT cv::bgsegm::createBackgroundSubtractorCNT(int minPixelStability = 15, bool useHistory = true, int maxPixelStability = 15*60, bool isParallel = true)
//
/**
 * Creates a CNT Background Subtractor
 *
 * @param minPixelStability number of frames with same pixel color to consider stable
 * @param useHistory determines if we're giving a pixel credit for being stable for a long time
 * @param maxPixelStability maximum allowed credit for a pixel in history
 * @param isParallel determines if we're parallelizing the algorithm
 */
+ (BackgroundSubtractorCNT*)createBackgroundSubtractorCNT:(int)minPixelStability useHistory:(BOOL)useHistory maxPixelStability:(int)maxPixelStability isParallel:(BOOL)isParallel NS_SWIFT_NAME(createBackgroundSubtractorCNT(minPixelStability:useHistory:maxPixelStability:isParallel:));

/**
 * Creates a CNT Background Subtractor
 *
 * @param minPixelStability number of frames with same pixel color to consider stable
 * @param useHistory determines if we're giving a pixel credit for being stable for a long time
 * @param maxPixelStability maximum allowed credit for a pixel in history
 */
+ (BackgroundSubtractorCNT*)createBackgroundSubtractorCNT:(int)minPixelStability useHistory:(BOOL)useHistory maxPixelStability:(int)maxPixelStability NS_SWIFT_NAME(createBackgroundSubtractorCNT(minPixelStability:useHistory:maxPixelStability:));

/**
 * Creates a CNT Background Subtractor
 *
 * @param minPixelStability number of frames with same pixel color to consider stable
 * @param useHistory determines if we're giving a pixel credit for being stable for a long time
 */
+ (BackgroundSubtractorCNT*)createBackgroundSubtractorCNT:(int)minPixelStability useHistory:(BOOL)useHistory NS_SWIFT_NAME(createBackgroundSubtractorCNT(minPixelStability:useHistory:));

/**
 * Creates a CNT Background Subtractor
 *
 * @param minPixelStability number of frames with same pixel color to consider stable
 */
+ (BackgroundSubtractorCNT*)createBackgroundSubtractorCNT:(int)minPixelStability NS_SWIFT_NAME(createBackgroundSubtractorCNT(minPixelStability:));

/**
 * Creates a CNT Background Subtractor
 *
 */
+ (BackgroundSubtractorCNT*)createBackgroundSubtractorCNT NS_SWIFT_NAME(createBackgroundSubtractorCNT());


//
//  Ptr_BackgroundSubtractorGSOC cv::bgsegm::createBackgroundSubtractorGSOC(LSBPCameraMotionCompensation mc = LSBP_CAMERA_MOTION_COMPENSATION_NONE, int nSamples = 20, float replaceRate = 0.003f, float propagationRate = 0.01f, int hitsThreshold = 32, float alpha = 0.01f, float beta = 0.0022f, float blinkingSupressionDecay = 0.1f, float blinkingSupressionMultiplier = 0.1f, float noiseRemovalThresholdFacBG = 0.0004f, float noiseRemovalThresholdFacFG = 0.0008f)
//
/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 * @param alpha Scale coefficient for threshold.
 * @param beta Bias coefficient for threshold.
 * @param blinkingSupressionDecay Blinking supression decay factor.
 * @param blinkingSupressionMultiplier Blinking supression multiplier.
 * @param noiseRemovalThresholdFacBG Strength of the noise removal for background points.
 * @param noiseRemovalThresholdFacFG Strength of the noise removal for foreground points.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold alpha:(float)alpha beta:(float)beta blinkingSupressionDecay:(float)blinkingSupressionDecay blinkingSupressionMultiplier:(float)blinkingSupressionMultiplier noiseRemovalThresholdFacBG:(float)noiseRemovalThresholdFacBG noiseRemovalThresholdFacFG:(float)noiseRemovalThresholdFacFG NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:alpha:beta:blinkingSupressionDecay:blinkingSupressionMultiplier:noiseRemovalThresholdFacBG:noiseRemovalThresholdFacFG:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 * @param alpha Scale coefficient for threshold.
 * @param beta Bias coefficient for threshold.
 * @param blinkingSupressionDecay Blinking supression decay factor.
 * @param blinkingSupressionMultiplier Blinking supression multiplier.
 * @param noiseRemovalThresholdFacBG Strength of the noise removal for background points.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold alpha:(float)alpha beta:(float)beta blinkingSupressionDecay:(float)blinkingSupressionDecay blinkingSupressionMultiplier:(float)blinkingSupressionMultiplier noiseRemovalThresholdFacBG:(float)noiseRemovalThresholdFacBG NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:alpha:beta:blinkingSupressionDecay:blinkingSupressionMultiplier:noiseRemovalThresholdFacBG:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 * @param alpha Scale coefficient for threshold.
 * @param beta Bias coefficient for threshold.
 * @param blinkingSupressionDecay Blinking supression decay factor.
 * @param blinkingSupressionMultiplier Blinking supression multiplier.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold alpha:(float)alpha beta:(float)beta blinkingSupressionDecay:(float)blinkingSupressionDecay blinkingSupressionMultiplier:(float)blinkingSupressionMultiplier NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:alpha:beta:blinkingSupressionDecay:blinkingSupressionMultiplier:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 * @param alpha Scale coefficient for threshold.
 * @param beta Bias coefficient for threshold.
 * @param blinkingSupressionDecay Blinking supression decay factor.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold alpha:(float)alpha beta:(float)beta blinkingSupressionDecay:(float)blinkingSupressionDecay NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:alpha:beta:blinkingSupressionDecay:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 * @param alpha Scale coefficient for threshold.
 * @param beta Bias coefficient for threshold.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold alpha:(float)alpha beta:(float)beta NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:alpha:beta:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 * @param alpha Scale coefficient for threshold.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold alpha:(float)alpha NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:alpha:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 * @param hitsThreshold How many positives the sample must get before it will be considered as a possible replacement.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate hitsThreshold:(int)hitsThreshold NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:hitsThreshold:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 * @param propagationRate Probability of propagating to neighbors.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate propagationRate:(float)propagationRate NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:propagationRate:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param replaceRate Probability of replacing the old sample - how fast the model will update itself.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples replaceRate:(float)replaceRate NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:replaceRate:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:nSamples:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * @param mc Whether to use camera motion compensation.
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC:(LSBPCameraMotionCompensation)mc NS_SWIFT_NAME(createBackgroundSubtractorGSOC(mc:));

/**
 * Creates an instance of BackgroundSubtractorGSOC algorithm.
 *
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 */
+ (BackgroundSubtractorGSOC*)createBackgroundSubtractorGSOC NS_SWIFT_NAME(createBackgroundSubtractorGSOC());


//
//  Ptr_BackgroundSubtractorLSBP cv::bgsegm::createBackgroundSubtractorLSBP(LSBPCameraMotionCompensation mc = LSBP_CAMERA_MOTION_COMPENSATION_NONE, int nSamples = 20, int LSBPRadius = 16, float Tlower = 2.0f, float Tupper = 32.0f, float Tinc = 1.0f, float Tdec = 0.05f, float Rscale = 10.0f, float Rincdec = 0.005f, float noiseRemovalThresholdFacBG = 0.0004f, float noiseRemovalThresholdFacFG = 0.0008f, int LSBPthreshold = 8, int minCount = 2)
//
/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 * @param Rscale Scale coefficient for threshold values.
 * @param Rincdec Increase/Decrease step for threshold values.
 * @param noiseRemovalThresholdFacBG Strength of the noise removal for background points.
 * @param noiseRemovalThresholdFacFG Strength of the noise removal for foreground points.
 * @param LSBPthreshold Threshold for LSBP binary string.
 * @param minCount Minimal number of matches for sample to be considered as foreground.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec Rscale:(float)Rscale Rincdec:(float)Rincdec noiseRemovalThresholdFacBG:(float)noiseRemovalThresholdFacBG noiseRemovalThresholdFacFG:(float)noiseRemovalThresholdFacFG LSBPthreshold:(int)LSBPthreshold minCount:(int)minCount NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:Rscale:Rincdec:noiseRemovalThresholdFacBG:noiseRemovalThresholdFacFG:LSBPthreshold:minCount:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 * @param Rscale Scale coefficient for threshold values.
 * @param Rincdec Increase/Decrease step for threshold values.
 * @param noiseRemovalThresholdFacBG Strength of the noise removal for background points.
 * @param noiseRemovalThresholdFacFG Strength of the noise removal for foreground points.
 * @param LSBPthreshold Threshold for LSBP binary string.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec Rscale:(float)Rscale Rincdec:(float)Rincdec noiseRemovalThresholdFacBG:(float)noiseRemovalThresholdFacBG noiseRemovalThresholdFacFG:(float)noiseRemovalThresholdFacFG LSBPthreshold:(int)LSBPthreshold NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:Rscale:Rincdec:noiseRemovalThresholdFacBG:noiseRemovalThresholdFacFG:LSBPthreshold:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 * @param Rscale Scale coefficient for threshold values.
 * @param Rincdec Increase/Decrease step for threshold values.
 * @param noiseRemovalThresholdFacBG Strength of the noise removal for background points.
 * @param noiseRemovalThresholdFacFG Strength of the noise removal for foreground points.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec Rscale:(float)Rscale Rincdec:(float)Rincdec noiseRemovalThresholdFacBG:(float)noiseRemovalThresholdFacBG noiseRemovalThresholdFacFG:(float)noiseRemovalThresholdFacFG NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:Rscale:Rincdec:noiseRemovalThresholdFacBG:noiseRemovalThresholdFacFG:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 * @param Rscale Scale coefficient for threshold values.
 * @param Rincdec Increase/Decrease step for threshold values.
 * @param noiseRemovalThresholdFacBG Strength of the noise removal for background points.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec Rscale:(float)Rscale Rincdec:(float)Rincdec noiseRemovalThresholdFacBG:(float)noiseRemovalThresholdFacBG NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:Rscale:Rincdec:noiseRemovalThresholdFacBG:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 * @param Rscale Scale coefficient for threshold values.
 * @param Rincdec Increase/Decrease step for threshold values.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec Rscale:(float)Rscale Rincdec:(float)Rincdec NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:Rscale:Rincdec:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 * @param Rscale Scale coefficient for threshold values.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec Rscale:(float)Rscale NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:Rscale:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 * @param Tdec Decrease step for T-values. See CITE: LGuo2016 for details.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc Tdec:(float)Tdec NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:Tdec:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 * @param Tinc Increase step for T-values. See CITE: LGuo2016 for details.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper Tinc:(float)Tinc NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:Tinc:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 * @param Tupper Upper bound for T-values. See CITE: LGuo2016 for details.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower Tupper:(float)Tupper NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:Tupper:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 * @param Tlower Lower bound for T-values. See CITE: LGuo2016 for details.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius Tlower:(float)Tlower NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:Tlower:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 * @param LSBPRadius LSBP descriptor radius.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples LSBPRadius:(int)LSBPRadius NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:LSBPRadius:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 * @param nSamples Number of samples to maintain at each point of the frame.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc nSamples:(int)nSamples NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:nSamples:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * @param mc Whether to use camera motion compensation.
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP:(LSBPCameraMotionCompensation)mc NS_SWIFT_NAME(createBackgroundSubtractorLSBP(mc:));

/**
 * Creates an instance of BackgroundSubtractorLSBP algorithm.
 *
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 */
+ (BackgroundSubtractorLSBP*)createBackgroundSubtractorLSBP NS_SWIFT_NAME(createBackgroundSubtractorLSBP());


//
//  Ptr_SyntheticSequenceGenerator cv::bgsegm::createSyntheticSequenceGenerator(Mat background, Mat object, double amplitude = 2.0, double wavelength = 20.0, double wavespeed = 0.2, double objspeed = 6.0)
//
/**
 * Creates an instance of SyntheticSequenceGenerator.
 *
 * @param background Background image for object.
 * @param object Object image which will move slowly over the background.
 * @param amplitude Amplitude of wave distortion applied to background.
 * @param wavelength Length of waves in distortion applied to background.
 * @param wavespeed How fast waves will move.
 * @param objspeed How fast object will fly over background.
 */
+ (SyntheticSequenceGenerator*)createSyntheticSequenceGenerator:(Mat*)background object:(Mat*)object amplitude:(double)amplitude wavelength:(double)wavelength wavespeed:(double)wavespeed objspeed:(double)objspeed NS_SWIFT_NAME(createSyntheticSequenceGenerator(background:object:amplitude:wavelength:wavespeed:objspeed:));

/**
 * Creates an instance of SyntheticSequenceGenerator.
 *
 * @param background Background image for object.
 * @param object Object image which will move slowly over the background.
 * @param amplitude Amplitude of wave distortion applied to background.
 * @param wavelength Length of waves in distortion applied to background.
 * @param wavespeed How fast waves will move.
 */
+ (SyntheticSequenceGenerator*)createSyntheticSequenceGenerator:(Mat*)background object:(Mat*)object amplitude:(double)amplitude wavelength:(double)wavelength wavespeed:(double)wavespeed NS_SWIFT_NAME(createSyntheticSequenceGenerator(background:object:amplitude:wavelength:wavespeed:));

/**
 * Creates an instance of SyntheticSequenceGenerator.
 *
 * @param background Background image for object.
 * @param object Object image which will move slowly over the background.
 * @param amplitude Amplitude of wave distortion applied to background.
 * @param wavelength Length of waves in distortion applied to background.
 */
+ (SyntheticSequenceGenerator*)createSyntheticSequenceGenerator:(Mat*)background object:(Mat*)object amplitude:(double)amplitude wavelength:(double)wavelength NS_SWIFT_NAME(createSyntheticSequenceGenerator(background:object:amplitude:wavelength:));

/**
 * Creates an instance of SyntheticSequenceGenerator.
 *
 * @param background Background image for object.
 * @param object Object image which will move slowly over the background.
 * @param amplitude Amplitude of wave distortion applied to background.
 */
+ (SyntheticSequenceGenerator*)createSyntheticSequenceGenerator:(Mat*)background object:(Mat*)object amplitude:(double)amplitude NS_SWIFT_NAME(createSyntheticSequenceGenerator(background:object:amplitude:));

/**
 * Creates an instance of SyntheticSequenceGenerator.
 *
 * @param background Background image for object.
 * @param object Object image which will move slowly over the background.
 */
+ (SyntheticSequenceGenerator*)createSyntheticSequenceGenerator:(Mat*)background object:(Mat*)object NS_SWIFT_NAME(createSyntheticSequenceGenerator(background:object:));



@end

NS_ASSUME_NONNULL_END


