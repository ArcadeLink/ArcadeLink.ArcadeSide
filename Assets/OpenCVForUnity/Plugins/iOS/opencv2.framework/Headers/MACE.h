//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/mace.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class MACE
/**
 * Minimum Average Correlation Energy Filter
 *     useful for authentication with (cancellable) biometrical features.
 *     (does not need many positives to train (10-50), and no negatives at all, also robust to noise/salting)
 *
 *     see also: CITE: Savvides04
 *
 *     this implementation is largely based on: https://code.google.com/archive/p/pam-face-authentication (GSOC 2009)
 *
 *     use it like:
 *     
 *
 *     Ptr<face::MACE> mace = face::MACE::create(64);
 *
 *     vector<Mat> pos_images = ...
 *     mace->train(pos_images);
 *
 *     Mat query = ...
 *     bool same = mace->same(query);
 *
 *     
 *
 *     you can also use two-factor authentication, with an additional passphrase:
 *
 *     
 *     String owners_passphrase = "ilikehotdogs";
 *     Ptr<face::MACE> mace = face::MACE::create(64);
 *     mace->salt(owners_passphrase);
 *     vector<Mat> pos_images = ...
 *     mace->train(pos_images);
 *
 *     // now, users have to give a valid passphrase, along with the image:
 *     Mat query = ...
 *     cout << "enter passphrase: ";
 *     string pass;
 *     getline(cin, pass);
 *     mace->salt(pass);
 *     bool same = mace->same(query);
 *     
 *
 *     save/load your model:
 *     
 *     Ptr<face::MACE> mace = face::MACE::create(64);
 *     mace->train(pos_images);
 *     mace->save("my_mace.xml");
 *
 *     // later:
 *     Ptr<MACE> reloaded = MACE::load("my_mace.xml");
 *     reloaded->same(some_image);
 *     
 *
 * Member of `Face`
 */
CV_EXPORTS @interface MACE : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::MACE> nativePtrMACE;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::MACE>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::MACE>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::face::MACE::salt(String passphrase)
//
/**
 * optionally encrypt images with random convolution
 * @param passphrase a crc64 random seed will get generated from this
 */
- (void)salt:(NSString*)passphrase NS_SWIFT_NAME(salt(passphrase:));


//
//  void cv::face::MACE::train(vector_Mat images)
//
/**
 * train it on positive features
 *        compute the mace filter: `h = D(-1) * X * (X(+) * D(-1) * X)(-1) * C`
 *        also calculate a minimal threshold for this class, the smallest self-similarity from the train images
 * @param images  a vector<Mat> with the train images
 */
- (void)train:(NSArray<Mat*>*)images NS_SWIFT_NAME(train(images:));


//
//  bool cv::face::MACE::same(Mat query)
//
/**
 * correlate query img and threshold to min class value
 * @param query  a Mat with query image
 */
- (BOOL)same:(Mat*)query NS_SWIFT_NAME(same(query:));


//
// static Ptr_MACE cv::face::MACE::load(String filename, String objname = String())
//
/**
 * constructor
 * @param filename  build a new MACE instance from a pre-serialized FileStorage
 * @param objname (optional) top-level node in the FileStorage
 */
+ (MACE*)load:(NSString*)filename objname:(NSString*)objname NS_SWIFT_NAME(load(filename:objname:));

/**
 * constructor
 * @param filename  build a new MACE instance from a pre-serialized FileStorage
 */
+ (MACE*)load:(NSString*)filename NS_SWIFT_NAME(load(filename:));


//
// static Ptr_MACE cv::face::MACE::create(int IMGSIZE = 64)
//
/**
 * constructor
 * @param IMGSIZE  images will get resized to this (should be an even number)
 */
+ (MACE*)create:(int)IMGSIZE NS_SWIFT_NAME(create(IMGSIZE:));

/**
 * constructor
 */
+ (MACE*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


