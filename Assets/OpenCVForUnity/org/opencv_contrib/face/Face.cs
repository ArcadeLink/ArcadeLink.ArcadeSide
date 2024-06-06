
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{
    // C++: class Face


    public class Face
    {

        //
        // C++:  Ptr_Facemark cv::face::createFacemarkAAM()
        //

        public static Facemark createFacemarkAAM()
        {


            return Facemark.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_Face_createFacemarkAAM_10()));


        }


        //
        // C++:  Ptr_Facemark cv::face::createFacemarkLBF()
        //

        public static Facemark createFacemarkLBF()
        {


            return Facemark.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_Face_createFacemarkLBF_10()));


        }


        //
        // C++:  Ptr_Facemark cv::face::createFacemarkKazemi()
        //

        public static Facemark createFacemarkKazemi()
        {


            return Facemark.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_Face_createFacemarkKazemi_10()));


        }


        //
        // C++:  bool cv::face::getFacesHAAR(Mat image, Mat& faces, String face_cascade_name)
        //

        /**
         * Default face detector
         * This function is mainly utilized by the implementation of a Facemark Algorithm.
         * End users are advised to use function Facemark::getFaces which can be manually defined
         * and circumvented to the algorithm by Facemark::setFaceDetector.
         *
         * param image The input image to be processed.
         * param faces Output of the function which represent region of interest of the detected faces.
         * Each face is stored in cv::Rect container.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * std::vector&lt;cv::Rect&gt; faces;
         * CParams params("haarcascade_frontalface_alt.xml");
         * cv::face::getFaces(frame, faces, &amp;params);
         * for(int j=0;j&lt;faces.size();j++){
         *     cv::rectangle(frame, faces[j], cv::Scalar(255,0,255));
         * }
         * cv::imshow("detection", frame);
         * </code>
         * param face_cascade_name automatically generated
         * return automatically generated
         */
        public static bool getFacesHAAR(Mat image, Mat faces, string face_cascade_name)
        {
            if (image != null) image.ThrowIfDisposed();
            if (faces != null) faces.ThrowIfDisposed();

            return face_Face_getFacesHAAR_10(image.nativeObj, faces.nativeObj, face_cascade_name);


        }


        //
        // C++:  bool cv::face::loadDatasetList(String imageList, String annotationList, vector_String images, vector_String annotations)
        //

        /**
         * A utility to load list of paths to training image and annotation file.
         * param imageList The specified file contains paths to the training images.
         * param annotationList The specified file contains paths to the training annotations.
         * param images The loaded paths of training images.
         * param annotations The loaded paths of annotation files.
         *
         * Example of usage:
         * <code>
         * String imageFiles = "images_path.txt";
         * String ptsFiles = "annotations_path.txt";
         * std::vector&lt;String&gt; images_train;
         * std::vector&lt;String&gt; landmarks_train;
         * loadDatasetList(imageFiles,ptsFiles,images_train,landmarks_train);
         * </code>
         * return automatically generated
         */
        public static bool loadDatasetList(string imageList, string annotationList, List<string> images, List<string> annotations)
        {

            Mat images_mat = Converters.vector_String_to_Mat(images);
            Mat annotations_mat = Converters.vector_String_to_Mat(annotations);
            return face_Face_loadDatasetList_10(imageList, annotationList, images_mat.nativeObj, annotations_mat.nativeObj);


        }


        //
        // C++:  bool cv::face::loadTrainingData(String filename, vector_String images, Mat& facePoints, char delim = ' ', float offset = 0.0f)
        //

        /**
         * A utility to load facial landmark dataset from a single file.
         *
         * param filename The filename of a file that contains the dataset information.
         * Each line contains the filename of an image followed by
         * pairs of x and y values of facial landmarks points separated by a space.
         * Example
         * <code>
         * /home/user/ibug/image_003_1.jpg 336.820955 240.864510 334.238298 260.922709 335.266918 ...
         * /home/user/ibug/image_005_1.jpg 376.158428 230.845712 376.736984 254.924635 383.265403 ...
         * </code>
         * param images A vector where each element represent the filename of image in the dataset.
         * Images are not loaded by default to save the memory.
         * param facePoints The loaded landmark points for all training data.
         * param delim Delimiter between each element, the default value is a whitespace.
         * param offset An offset value to adjust the loaded points.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * cv::String imageFiles = "../data/images_train.txt";
         * cv::String ptsFiles = "../data/points_train.txt";
         * std::vector&lt;String&gt; images;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; facePoints;
         * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
         * </code>
         * return automatically generated
         */
        public static bool loadTrainingData(string filename, List<string> images, Mat facePoints, char delim, float offset)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
            Mat images_mat = Converters.vector_String_to_Mat(images);
            return face_Face_loadTrainingData_10(filename, images_mat.nativeObj, facePoints.nativeObj, delim, offset);


        }

        /**
         * A utility to load facial landmark dataset from a single file.
         *
         * param filename The filename of a file that contains the dataset information.
         * Each line contains the filename of an image followed by
         * pairs of x and y values of facial landmarks points separated by a space.
         * Example
         * <code>
         * /home/user/ibug/image_003_1.jpg 336.820955 240.864510 334.238298 260.922709 335.266918 ...
         * /home/user/ibug/image_005_1.jpg 376.158428 230.845712 376.736984 254.924635 383.265403 ...
         * </code>
         * param images A vector where each element represent the filename of image in the dataset.
         * Images are not loaded by default to save the memory.
         * param facePoints The loaded landmark points for all training data.
         * param delim Delimiter between each element, the default value is a whitespace.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * cv::String imageFiles = "../data/images_train.txt";
         * cv::String ptsFiles = "../data/points_train.txt";
         * std::vector&lt;String&gt; images;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; facePoints;
         * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
         * </code>
         * return automatically generated
         */
        public static bool loadTrainingData(string filename, List<string> images, Mat facePoints, char delim)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
            Mat images_mat = Converters.vector_String_to_Mat(images);
            return face_Face_loadTrainingData_11(filename, images_mat.nativeObj, facePoints.nativeObj, delim);


        }

        /**
         * A utility to load facial landmark dataset from a single file.
         *
         * param filename The filename of a file that contains the dataset information.
         * Each line contains the filename of an image followed by
         * pairs of x and y values of facial landmarks points separated by a space.
         * Example
         * <code>
         * /home/user/ibug/image_003_1.jpg 336.820955 240.864510 334.238298 260.922709 335.266918 ...
         * /home/user/ibug/image_005_1.jpg 376.158428 230.845712 376.736984 254.924635 383.265403 ...
         * </code>
         * param images A vector where each element represent the filename of image in the dataset.
         * Images are not loaded by default to save the memory.
         * param facePoints The loaded landmark points for all training data.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * cv::String imageFiles = "../data/images_train.txt";
         * cv::String ptsFiles = "../data/points_train.txt";
         * std::vector&lt;String&gt; images;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; facePoints;
         * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
         * </code>
         * return automatically generated
         */
        public static bool loadTrainingData(string filename, List<string> images, Mat facePoints)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
            Mat images_mat = Converters.vector_String_to_Mat(images);
            return face_Face_loadTrainingData_12(filename, images_mat.nativeObj, facePoints.nativeObj);


        }


        //
        // C++:  bool cv::face::loadTrainingData(String imageList, String groundTruth, vector_String images, Mat& facePoints, float offset = 0.0f)
        //

        /**
         * A utility to load facial landmark information from the dataset.
         *
         * param imageList A file contains the list of image filenames in the training dataset.
         * param groundTruth A file contains the list of filenames
         * where the landmarks points information are stored.
         * The content in each file should follow the standard format (see face::loadFacePoints).
         * param images A vector where each element represent the filename of image in the dataset.
         * Images are not loaded by default to save the memory.
         * param facePoints The loaded landmark points for all training data.
         * param offset An offset value to adjust the loaded points.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * cv::String imageFiles = "../data/images_train.txt";
         * cv::String ptsFiles = "../data/points_train.txt";
         * std::vector&lt;String&gt; images;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; facePoints;
         * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
         * </code>
         *
         * example of content in the images_train.txt
         * <code>
         * /home/user/ibug/image_003_1.jpg
         * /home/user/ibug/image_004_1.jpg
         * /home/user/ibug/image_005_1.jpg
         * /home/user/ibug/image_006.jpg
         * </code>
         *
         * example of content in the points_train.txt
         * <code>
         * /home/user/ibug/image_003_1.pts
         * /home/user/ibug/image_004_1.pts
         * /home/user/ibug/image_005_1.pts
         * /home/user/ibug/image_006.pts
         * </code>
         * return automatically generated
         */
        public static bool loadTrainingData(string imageList, string groundTruth, List<string> images, Mat facePoints, float offset)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
            Mat images_mat = Converters.vector_String_to_Mat(images);
            return face_Face_loadTrainingData_13(imageList, groundTruth, images_mat.nativeObj, facePoints.nativeObj, offset);


        }

        /**
         * A utility to load facial landmark information from the dataset.
         *
         * param imageList A file contains the list of image filenames in the training dataset.
         * param groundTruth A file contains the list of filenames
         * where the landmarks points information are stored.
         * The content in each file should follow the standard format (see face::loadFacePoints).
         * param images A vector where each element represent the filename of image in the dataset.
         * Images are not loaded by default to save the memory.
         * param facePoints The loaded landmark points for all training data.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * cv::String imageFiles = "../data/images_train.txt";
         * cv::String ptsFiles = "../data/points_train.txt";
         * std::vector&lt;String&gt; images;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; facePoints;
         * loadTrainingData(imageFiles, ptsFiles, images, facePoints, 0.0f);
         * </code>
         *
         * example of content in the images_train.txt
         * <code>
         * /home/user/ibug/image_003_1.jpg
         * /home/user/ibug/image_004_1.jpg
         * /home/user/ibug/image_005_1.jpg
         * /home/user/ibug/image_006.jpg
         * </code>
         *
         * example of content in the points_train.txt
         * <code>
         * /home/user/ibug/image_003_1.pts
         * /home/user/ibug/image_004_1.pts
         * /home/user/ibug/image_005_1.pts
         * /home/user/ibug/image_006.pts
         * </code>
         * return automatically generated
         */
        public static bool loadTrainingData(string imageList, string groundTruth, List<string> images, Mat facePoints)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
            Mat images_mat = Converters.vector_String_to_Mat(images);
            return face_Face_loadTrainingData_14(imageList, groundTruth, images_mat.nativeObj, facePoints.nativeObj);


        }


        //
        // C++:  bool cv::face::loadTrainingData(vector_String filename, vector_vector_Point2f trainlandmarks, vector_String trainimages)
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
         * &lt;a href="http://www.ifp.illinois.edu/~vuongle2/helen/"&gt;HELEN dataset&lt;/a&gt;
         *
         * param filename A vector of type cv::String containing name of the .txt files.
         * param trainlandmarks A vector of type cv::Point2f that would store shape or landmarks of all images.
         * param trainimages A vector of type cv::String which stores the name of images whose landmarks are tracked
         * return A boolean value. It returns true when it reads the data successfully and false otherwise
         */
        public static bool loadTrainingData(List<string> filename, List<MatOfPoint2f> trainlandmarks, List<string> trainimages)
        {

            Mat filename_mat = Converters.vector_String_to_Mat(filename);
            List<Mat> trainlandmarks_tmplm = new List<Mat>((trainlandmarks != null) ? trainlandmarks.Count : 0);
            Mat trainlandmarks_mat = Converters.vector_vector_Point2f_to_Mat(trainlandmarks, trainlandmarks_tmplm);
            Mat trainimages_mat = Converters.vector_String_to_Mat(trainimages);
            return face_Face_loadTrainingData_15(filename_mat.nativeObj, trainlandmarks_mat.nativeObj, trainimages_mat.nativeObj);


        }


        //
        // C++:  bool cv::face::loadFacePoints(String filename, Mat& points, float offset = 0.0f)
        //

        /**
         * A utility to load facial landmark information from a given file.
         *
         * param filename The filename of file contains the facial landmarks data.
         * param points The loaded facial landmark points.
         * param offset An offset value to adjust the loaded points.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * std::vector&lt;Point2f&gt; points;
         * face::loadFacePoints("filename.txt", points, 0.0f);
         * </code>
         *
         * The annotation file should follow the default format which is
         * <code>
         * version: 1
         * n_points:  68
         * {
         * 212.716603 499.771793
         * 230.232816 566.290071
         * ...
         * }
         * </code>
         * where n_points is the number of points considered
         * and each point is represented as its position in x and y.
         * return automatically generated
         */
        public static bool loadFacePoints(string filename, Mat points, float offset)
        {
            if (points != null) points.ThrowIfDisposed();

            return face_Face_loadFacePoints_10(filename, points.nativeObj, offset);


        }

        /**
         * A utility to load facial landmark information from a given file.
         *
         * param filename The filename of file contains the facial landmarks data.
         * param points The loaded facial landmark points.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * std::vector&lt;Point2f&gt; points;
         * face::loadFacePoints("filename.txt", points, 0.0f);
         * </code>
         *
         * The annotation file should follow the default format which is
         * <code>
         * version: 1
         * n_points:  68
         * {
         * 212.716603 499.771793
         * 230.232816 566.290071
         * ...
         * }
         * </code>
         * where n_points is the number of points considered
         * and each point is represented as its position in x and y.
         * return automatically generated
         */
        public static bool loadFacePoints(string filename, Mat points)
        {
            if (points != null) points.ThrowIfDisposed();

            return face_Face_loadFacePoints_11(filename, points.nativeObj);


        }


        //
        // C++:  void cv::face::drawFacemarks(Mat& image, Mat points, Scalar color = Scalar(255,0,0))
        //

        /**
         * Utility to draw the detected facial landmark points
         *
         * param image The input image to be processed.
         * param points Contains the data of points which will be drawn.
         * param color The color of points in BGR format represented by cv::Scalar.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * std::vector&lt;Rect&gt; faces;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; landmarks;
         * facemark-&gt;getFaces(img, faces);
         * facemark-&gt;fit(img, faces, landmarks);
         * for(int j=0;j&lt;rects.size();j++){
         *     face::drawFacemarks(frame, landmarks[j], Scalar(0,0,255));
         * }
         * </code>
         */
        public static void drawFacemarks(Mat image, Mat points, Scalar color)
        {
            if (image != null) image.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();

            face_Face_drawFacemarks_10(image.nativeObj, points.nativeObj, color.val[0], color.val[1], color.val[2], color.val[3]);


        }

        /**
         * Utility to draw the detected facial landmark points
         *
         * param image The input image to be processed.
         * param points Contains the data of points which will be drawn.
         *
         * &lt;B&gt;Example of usage&lt;/B&gt;
         * <code>
         * std::vector&lt;Rect&gt; faces;
         * std::vector&lt;std::vector&lt;Point2f&gt; &gt; landmarks;
         * facemark-&gt;getFaces(img, faces);
         * facemark-&gt;fit(img, faces, landmarks);
         * for(int j=0;j&lt;rects.size();j++){
         *     face::drawFacemarks(frame, landmarks[j], Scalar(0,0,255));
         * }
         * </code>
         */
        public static void drawFacemarks(Mat image, Mat points)
        {
            if (image != null) image.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();

            face_Face_drawFacemarks_11(image.nativeObj, points.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Ptr_Facemark cv::face::createFacemarkAAM()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFacemarkAAM_10();

        // C++:  Ptr_Facemark cv::face::createFacemarkLBF()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFacemarkLBF_10();

        // C++:  Ptr_Facemark cv::face::createFacemarkKazemi()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFacemarkKazemi_10();

        // C++:  bool cv::face::getFacesHAAR(Mat image, Mat& faces, String face_cascade_name)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_getFacesHAAR_10(IntPtr image_nativeObj, IntPtr faces_nativeObj, string face_cascade_name);

        // C++:  bool cv::face::loadDatasetList(String imageList, String annotationList, vector_String images, vector_String annotations)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadDatasetList_10(string imageList, string annotationList, IntPtr images_mat_nativeObj, IntPtr annotations_mat_nativeObj);

        // C++:  bool cv::face::loadTrainingData(String filename, vector_String images, Mat& facePoints, char delim = ' ', float offset = 0.0f)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_10(string filename, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj, char delim, float offset);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_11(string filename, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj, char delim);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_12(string filename, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj);

        // C++:  bool cv::face::loadTrainingData(String imageList, String groundTruth, vector_String images, Mat& facePoints, float offset = 0.0f)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_13(string imageList, string groundTruth, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj, float offset);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_14(string imageList, string groundTruth, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj);

        // C++:  bool cv::face::loadTrainingData(vector_String filename, vector_vector_Point2f trainlandmarks, vector_String trainimages)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_15(IntPtr filename_mat_nativeObj, IntPtr trainlandmarks_mat_nativeObj, IntPtr trainimages_mat_nativeObj);

        // C++:  bool cv::face::loadFacePoints(String filename, Mat& points, float offset = 0.0f)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadFacePoints_10(string filename, IntPtr points_nativeObj, float offset);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadFacePoints_11(string filename, IntPtr points_nativeObj);

        // C++:  void cv::face::drawFacemarks(Mat& image, Mat points, Scalar color = Scalar(255,0,0))
        [DllImport(LIBNAME)]
        private static extern void face_Face_drawFacemarks_10(IntPtr image_nativeObj, IntPtr points_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
        [DllImport(LIBNAME)]
        private static extern void face_Face_drawFacemarks_11(IntPtr image_nativeObj, IntPtr points_nativeObj);

    }
}
