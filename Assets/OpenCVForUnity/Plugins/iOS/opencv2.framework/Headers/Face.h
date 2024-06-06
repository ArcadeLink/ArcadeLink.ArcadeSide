//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>

@class Facemark;
@class Mat;
@class Point2f;
@class Scalar;



NS_ASSUME_NONNULL_BEGIN

// C++: class Face
/**
 * The Face module
 *
 * Member classes: `FaceRecognizer`, `Facemark`, `PredictCollector`, `StandardCollector`, `FacemarkKazemi`, `FacemarkAAM`, `BIF`, `MACE`, `FacemarkTrain`, `FacemarkLBF`, `BasicFaceRecognizer`, `EigenFaceRecognizer`, `FisherFaceRecognizer`, `LBPHFaceRecognizer`
 *
 */
CV_EXPORTS @interface Face : NSObject

#pragma mark - Methods


//
//  Ptr_Facemark cv::face::createFacemarkAAM()
//
+ (Facemark*)createFacemarkAAM NS_SWIFT_NAME(createFacemarkAAM());


//
//  Ptr_Facemark cv::face::createFacemarkLBF()
//
+ (Facemark*)createFacemarkLBF NS_SWIFT_NAME(createFacemarkLBF());


//
//  Ptr_Facemark cv::face::createFacemarkKazemi()
//
+ (Facemark*)createFacemarkKazemi NS_SWIFT_NAME(createFacemarkKazemi());


//
//  bool cv::face::getFacesHAAR(Mat image, Mat& faces, String face_cascade_name)
//
/**
 * Default face detector
 * This function is mainly utilized by the implementation of a Facemark Algorithm.
 * End users are advised to use function Facemark::getFaces which can be manually defined
 * and circumvented to the algorithm by Facemark::setFaceDetector.
 *
 * @param image The input image to be processed.
 * @param faces Output of the function which represent region of interest of the detected faces.
 * Each face is stored in cv::Rect container.
 *
 * <B>Example of usage</B>
 *
 * std::vector<cv::Rect> faces;
 * CParams params("haarcascade_frontalface_alt.xml");
 * cv::face::getFaces(frame, faces, &params);
 * for(int j=0;j<faces.size();j++){
 *     cv::rectangle(frame, faces[j], cv::Scalar(255,0,255));
 * }
 * cv::imshow("detection", frame);
 *
 */
+ (BOOL)getFacesHAAR:(Mat*)image faces:(Mat*)faces face_cascade_name:(NSString*)face_cascade_name NS_SWIFT_NAME(getFacesHAAR(image:faces:face_cascade_name:));


//
//  bool cv::face::loadDatasetList(String imageList, String annotationList, vector_String images, vector_String annotations)
//
/**
 * A utility to load list of paths to training image and annotation file.
 * @param imageList The specified file contains paths to the training images.
 * @param annotationList The specified file contains paths to the training annotations.
 * @param images The loaded paths of training images.
 * @param annotations The loaded paths of annotation files.
 *
 * Example of usage:
 *
 * String imageFiles = "images_path.txt";
 * String ptsFiles = "annotations_path.txt";
 * std::vector<String> images_train;
 * std::vector<String> landmarks_train;
 * loadDatasetList(imageFiles,ptsFiles,images_train,landmarks_train);
 *
 */
+ (BOOL)loadDatasetList:(NSString*)imageList annotationList:(NSString*)annotationList images:(NSArray<NSString*>*)images annotations:(NSArray<NSString*>*)annotations NS_SWIFT_NAME(loadDatasetList(imageList:annotationList:images:annotations:));


//
//  bool cv::face::loadTrainingData(String filename, vector_String images, Mat& facePoints, char delim = ' ', float offset = 0.0f)
//
/**
 * A utility to load facial landmark dataset from a single file.
 *
 * @param filename The filename of a file that contains the dataset information.
 * Each line contains the filename of an image followed by
 * pairs of x and y values of facial landmarks points separated by a space.
 * Example
 *
 * /home/user/ibug/image_003_1.jpg 336.820955 240.864510 334.238298 260.922709 335.266918 ...
 * /home/user/ibug/image_005_1.jpg 376.158428 230.845712 376.736984 254.924635 383.265403 ...
 *
 * @param images A vector where each element represent the filename of image in the dataset.
 * Images are not loaded by default to save the memory.
 * @param facePoints The loaded landmark points for all training data.
 * @param delim Delimiter between each element, the default value is a whitespace.
 * @param offset An offset value to adjust the loaded points.
 *
 * <B>Example of usage</B>
 *
 * cv::String imageFiles = "../data/images_train.txt";
 * cv::String ptsFiles = "../data/points_train.txt";
 * std::vector<String> images;
 * std::vector<std::vector<Point2f> > facePoints;
 * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
 *
 */
+ (BOOL)loadTrainingData:(NSString*)filename images:(NSArray<NSString*>*)images facePoints:(Mat*)facePoints delim:(char)delim offset:(float)offset NS_SWIFT_NAME(loadTrainingData(filename:images:facePoints:delim:offset:));

/**
 * A utility to load facial landmark dataset from a single file.
 *
 * @param filename The filename of a file that contains the dataset information.
 * Each line contains the filename of an image followed by
 * pairs of x and y values of facial landmarks points separated by a space.
 * Example
 *
 * /home/user/ibug/image_003_1.jpg 336.820955 240.864510 334.238298 260.922709 335.266918 ...
 * /home/user/ibug/image_005_1.jpg 376.158428 230.845712 376.736984 254.924635 383.265403 ...
 *
 * @param images A vector where each element represent the filename of image in the dataset.
 * Images are not loaded by default to save the memory.
 * @param facePoints The loaded landmark points for all training data.
 * @param delim Delimiter between each element, the default value is a whitespace.
 *
 * <B>Example of usage</B>
 *
 * cv::String imageFiles = "../data/images_train.txt";
 * cv::String ptsFiles = "../data/points_train.txt";
 * std::vector<String> images;
 * std::vector<std::vector<Point2f> > facePoints;
 * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
 *
 */
+ (BOOL)loadTrainingData:(NSString*)filename images:(NSArray<NSString*>*)images facePoints:(Mat*)facePoints delim:(char)delim NS_SWIFT_NAME(loadTrainingData(filename:images:facePoints:delim:));

/**
 * A utility to load facial landmark dataset from a single file.
 *
 * @param filename The filename of a file that contains the dataset information.
 * Each line contains the filename of an image followed by
 * pairs of x and y values of facial landmarks points separated by a space.
 * Example
 *
 * /home/user/ibug/image_003_1.jpg 336.820955 240.864510 334.238298 260.922709 335.266918 ...
 * /home/user/ibug/image_005_1.jpg 376.158428 230.845712 376.736984 254.924635 383.265403 ...
 *
 * @param images A vector where each element represent the filename of image in the dataset.
 * Images are not loaded by default to save the memory.
 * @param facePoints The loaded landmark points for all training data.
 *
 * <B>Example of usage</B>
 *
 * cv::String imageFiles = "../data/images_train.txt";
 * cv::String ptsFiles = "../data/points_train.txt";
 * std::vector<String> images;
 * std::vector<std::vector<Point2f> > facePoints;
 * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
 *
 */
+ (BOOL)loadTrainingData:(NSString*)filename images:(NSArray<NSString*>*)images facePoints:(Mat*)facePoints NS_SWIFT_NAME(loadTrainingData(filename:images:facePoints:));


//
//  bool cv::face::loadTrainingData(String imageList, String groundTruth, vector_String images, Mat& facePoints, float offset = 0.0f)
//
/**
 * A utility to load facial landmark information from the dataset.
 *
 * @param imageList A file contains the list of image filenames in the training dataset.
 * @param groundTruth A file contains the list of filenames
 * where the landmarks points information are stored.
 * The content in each file should follow the standard format (see face::loadFacePoints).
 * @param images A vector where each element represent the filename of image in the dataset.
 * Images are not loaded by default to save the memory.
 * @param facePoints The loaded landmark points for all training data.
 * @param offset An offset value to adjust the loaded points.
 *
 * <B>Example of usage</B>
 *
 * cv::String imageFiles = "../data/images_train.txt";
 * cv::String ptsFiles = "../data/points_train.txt";
 * std::vector<String> images;
 * std::vector<std::vector<Point2f> > facePoints;
 * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
 *
 *
 * example of content in the images_train.txt
 *
 * /home/user/ibug/image_003_1.jpg
 * /home/user/ibug/image_004_1.jpg
 * /home/user/ibug/image_005_1.jpg
 * /home/user/ibug/image_006.jpg
 *
 *
 * example of content in the points_train.txt
 *
 * /home/user/ibug/image_003_1.pts
 * /home/user/ibug/image_004_1.pts
 * /home/user/ibug/image_005_1.pts
 * /home/user/ibug/image_006.pts
 *
 */
+ (BOOL)loadTrainingData:(NSString*)imageList groundTruth:(NSString*)groundTruth images:(NSArray<NSString*>*)images facePoints:(Mat*)facePoints offset:(float)offset NS_SWIFT_NAME(loadTrainingData(imageList:groundTruth:images:facePoints:offset:));

/**
 * A utility to load facial landmark information from the dataset.
 *
 * @param imageList A file contains the list of image filenames in the training dataset.
 * @param groundTruth A file contains the list of filenames
 * where the landmarks points information are stored.
 * The content in each file should follow the standard format (see face::loadFacePoints).
 * @param images A vector where each element represent the filename of image in the dataset.
 * Images are not loaded by default to save the memory.
 * @param facePoints The loaded landmark points for all training data.
 *
 * <B>Example of usage</B>
 *
 * cv::String imageFiles = "../data/images_train.txt";
 * cv::String ptsFiles = "../data/points_train.txt";
 * std::vector<String> images;
 * std::vector<std::vector<Point2f> > facePoints;
 * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
 *
 *
 * example of content in the images_train.txt
 *
 * /home/user/ibug/image_003_1.jpg
 * /home/user/ibug/image_004_1.jpg
 * /home/user/ibug/image_005_1.jpg
 * /home/user/ibug/image_006.jpg
 *
 *
 * example of content in the points_train.txt
 *
 * /home/user/ibug/image_003_1.pts
 * /home/user/ibug/image_004_1.pts
 * /home/user/ibug/image_005_1.pts
 * /home/user/ibug/image_006.pts
 *
 */
+ (BOOL)loadTrainingData:(NSString*)imageList groundTruth:(NSString*)groundTruth images:(NSArray<NSString*>*)images facePoints:(Mat*)facePoints NS_SWIFT_NAME(loadTrainingData(imageList:groundTruth:images:facePoints:));


//
//  bool cv::face::loadTrainingData(vector_String filename, vector_vector_Point2f trainlandmarks, vector_String trainimages)
//
/**
 * This function extracts the data for training from .txt files which contains the corresponding image name and landmarks.
 * The first file in each file should give the path of the image whose
 * landmarks are being described in the file. Then in the subsequent
 * lines there should be coordinates of the landmarks in the image
 * i.e each line should be of the form x,y
 * where x represents the x coordinate of the landmark and y represents
 * the y coordinate of the landmark.
 *
 * For reference you can see the files as provided in the
 * <a href="http://www.ifp.illinois.edu/~vuongle2/helen/">HELEN dataset</a>
 *
 * @param filename A vector of type cv::String containing name of the .txt files.
 * @param trainlandmarks A vector of type cv::Point2f that would store shape or landmarks of all images.
 * @param trainimages A vector of type cv::String which stores the name of images whose landmarks are tracked
 * @return A boolean value. It returns true when it reads the data successfully and false otherwise
 */
+ (BOOL)loadTrainingData:(NSArray<NSString*>*)filename trainlandmarks:(NSArray<NSArray<Point2f*>*>*)trainlandmarks trainimages:(NSArray<NSString*>*)trainimages NS_SWIFT_NAME(loadTrainingData(filename:trainlandmarks:trainimages:));


//
//  bool cv::face::loadFacePoints(String filename, Mat& points, float offset = 0.0f)
//
/**
 * A utility to load facial landmark information from a given file.
 *
 * @param filename The filename of file contains the facial landmarks data.
 * @param points The loaded facial landmark points.
 * @param offset An offset value to adjust the loaded points.
 *
 * <B>Example of usage</B>
 *
 * std::vector<Point2f> points;
 * face::loadFacePoints("filename.txt", points, 0.0f);
 *
 *
 * The annotation file should follow the default format which is
 *
 * version: 1
 * n_points:  68
 * {
 * 212.716603 499.771793
 * 230.232816 566.290071
 * ...
 * }
 *
 * where n_points is the number of points considered
 * and each point is represented as its position in x and y.
 */
+ (BOOL)loadFacePoints:(NSString*)filename points:(Mat*)points offset:(float)offset NS_SWIFT_NAME(loadFacePoints(filename:points:offset:));

/**
 * A utility to load facial landmark information from a given file.
 *
 * @param filename The filename of file contains the facial landmarks data.
 * @param points The loaded facial landmark points.
 *
 * <B>Example of usage</B>
 *
 * std::vector<Point2f> points;
 * face::loadFacePoints("filename.txt", points, 0.0f);
 *
 *
 * The annotation file should follow the default format which is
 *
 * version: 1
 * n_points:  68
 * {
 * 212.716603 499.771793
 * 230.232816 566.290071
 * ...
 * }
 *
 * where n_points is the number of points considered
 * and each point is represented as its position in x and y.
 */
+ (BOOL)loadFacePoints:(NSString*)filename points:(Mat*)points NS_SWIFT_NAME(loadFacePoints(filename:points:));


//
//  void cv::face::drawFacemarks(Mat& image, Mat points, Scalar color = Scalar(255,0,0))
//
/**
 * Utility to draw the detected facial landmark points
 *
 * @param image The input image to be processed.
 * @param points Contains the data of points which will be drawn.
 * @param color The color of points in BGR format represented by cv::Scalar.
 *
 * <B>Example of usage</B>
 *
 * std::vector<Rect> faces;
 * std::vector<std::vector<Point2f> > landmarks;
 * facemark->getFaces(img, faces);
 * facemark->fit(img, faces, landmarks);
 * for(int j=0;j<rects.size();j++){
 *     face::drawFacemarks(frame, landmarks[j], Scalar(0,0,255));
 * }
 *
 */
+ (void)drawFacemarks:(Mat*)image points:(Mat*)points color:(Scalar*)color NS_SWIFT_NAME(drawFacemarks(image:points:color:));

/**
 * Utility to draw the detected facial landmark points
 *
 * @param image The input image to be processed.
 * @param points Contains the data of points which will be drawn.
 *
 * <B>Example of usage</B>
 *
 * std::vector<Rect> faces;
 * std::vector<std::vector<Point2f> > landmarks;
 * facemark->getFaces(img, faces);
 * facemark->fit(img, faces, landmarks);
 * for(int j=0;j<rects.size();j++){
 *     face::drawFacemarks(frame, landmarks[j], Scalar(0,0,255));
 * }
 *
 */
+ (void)drawFacemarks:(Mat*)image points:(Mat*)points NS_SWIFT_NAME(drawFacemarks(image:points:));



@end

NS_ASSUME_NONNULL_END


