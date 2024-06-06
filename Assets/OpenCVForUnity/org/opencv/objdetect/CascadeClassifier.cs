

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class CascadeClassifier
    /**
     * Cascade classifier class for object detection.
     */

    public class CascadeClassifier : DisposableOpenCVObject
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        objdetect_CascadeClassifier_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CascadeClassifier(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static CascadeClassifier __fromPtr__(IntPtr addr) { return new CascadeClassifier(addr); }

        //
        // C++:   cv::CascadeClassifier::CascadeClassifier()
        //

        public CascadeClassifier()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_CascadeClassifier_CascadeClassifier_10());


        }


        //
        // C++:   cv::CascadeClassifier::CascadeClassifier(String filename)
        //

        /**
         * Loads a classifier from a file.
         *
         *     param filename Name of the file from which the classifier is loaded.
         */
        public CascadeClassifier(string filename)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_CascadeClassifier_CascadeClassifier_11(filename));


        }


        //
        // C++:  bool cv::CascadeClassifier::empty()
        //

        /**
         * Checks whether the classifier has been loaded.
         * return automatically generated
         */
        public bool empty()
        {
            ThrowIfDisposed();

            return objdetect_CascadeClassifier_empty_10(nativeObj);


        }


        //
        // C++:  bool cv::CascadeClassifier::load(String filename)
        //

        /**
         * Loads a classifier from a file.
         *
         *     param filename Name of the file from which the classifier is loaded. The file may contain an old
         *     HAAR classifier trained by the haartraining application or a new cascade classifier trained by the
         *     traincascade application.
         * return automatically generated
         */
        public bool load(string filename)
        {
            ThrowIfDisposed();

            return objdetect_CascadeClassifier_load_10(nativeObj, filename);


        }


        //
        // C++:  bool cv::CascadeClassifier::read(FileNode node)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     param flags Parameter with the same meaning for an old cascade as in the function
         *     cvHaarDetectObjects. It is not used for a new cascade.
         *     param minSize Minimum possible object size. Objects smaller than that are ignored.
         *     param maxSize Maximum possible object size. Objects larger than that are ignored. If {code maxSize == minSize} model is evaluated on single scale.
         */
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            Mat objects_mat = objects;
            objdetect_CascadeClassifier_detectMultiScale_10(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     param flags Parameter with the same meaning for an old cascade as in the function
         *     cvHaarDetectObjects. It is not used for a new cascade.
         *     param minSize Minimum possible object size. Objects smaller than that are ignored.
         */
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            Mat objects_mat = objects;
            objdetect_CascadeClassifier_detectMultiScale_11(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     param flags Parameter with the same meaning for an old cascade as in the function
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            Mat objects_mat = objects;
            objdetect_CascadeClassifier_detectMultiScale_12(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            Mat objects_mat = objects;
            objdetect_CascadeClassifier_detectMultiScale_13(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     to retain it.
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            Mat objects_mat = objects;
            objdetect_CascadeClassifier_detectMultiScale_14(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     to retain it.
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale(Mat image, MatOfRect objects)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            Mat objects_mat = objects;
            objdetect_CascadeClassifier_detectMultiScale_15(nativeObj, image.nativeObj, objects_mat.nativeObj);


        }


        //
        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //

        /**
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param numDetections Vector of detection numbers for the corresponding objects. An object's number
         *     of detections is the number of neighboring positively classified rectangles that were joined
         *     together to form the object.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     param flags Parameter with the same meaning for an old cascade as in the function
         *     cvHaarDetectObjects. It is not used for a new cascade.
         *     param minSize Minimum possible object size. Objects smaller than that are ignored.
         *     param maxSize Maximum possible object size. Objects larger than that are ignored. If {code maxSize == minSize} model is evaluated on single scale.
         */
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat numDetections_mat = numDetections;
            objdetect_CascadeClassifier_detectMultiScale2_10(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);


        }

        /**
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param numDetections Vector of detection numbers for the corresponding objects. An object's number
         *     of detections is the number of neighboring positively classified rectangles that were joined
         *     together to form the object.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     param flags Parameter with the same meaning for an old cascade as in the function
         *     cvHaarDetectObjects. It is not used for a new cascade.
         *     param minSize Minimum possible object size. Objects smaller than that are ignored.
         */
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags, Size minSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat numDetections_mat = numDetections;
            objdetect_CascadeClassifier_detectMultiScale2_11(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height);


        }

        /**
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param numDetections Vector of detection numbers for the corresponding objects. An object's number
         *     of detections is the number of neighboring positively classified rectangles that were joined
         *     together to form the object.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     param flags Parameter with the same meaning for an old cascade as in the function
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat numDetections_mat = numDetections;
            objdetect_CascadeClassifier_detectMultiScale2_12(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags);


        }

        /**
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param numDetections Vector of detection numbers for the corresponding objects. An object's number
         *     of detections is the number of neighboring positively classified rectangles that were joined
         *     together to form the object.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     param minNeighbors Parameter specifying how many neighbors each candidate rectangle should have
         *     to retain it.
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat numDetections_mat = numDetections;
            objdetect_CascadeClassifier_detectMultiScale2_13(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors);


        }

        /**
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param numDetections Vector of detection numbers for the corresponding objects. An object's number
         *     of detections is the number of neighboring positively classified rectangles that were joined
         *     together to form the object.
         *     param scaleFactor Parameter specifying how much the image size is reduced at each image scale.
         *     to retain it.
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat numDetections_mat = numDetections;
            objdetect_CascadeClassifier_detectMultiScale2_14(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor);


        }

        /**
         *
         *     param image Matrix of the type CV_8U containing an image where objects are detected.
         *     param objects Vector of rectangles where each rectangle contains the detected object, the
         *     rectangles may be partially outside the original image.
         *     param numDetections Vector of detection numbers for the corresponding objects. An object's number
         *     of detections is the number of neighboring positively classified rectangles that were joined
         *     together to form the object.
         *     to retain it.
         *     cvHaarDetectObjects. It is not used for a new cascade.
         */
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat numDetections_mat = numDetections;
            objdetect_CascadeClassifier_detectMultiScale2_15(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj);


        }


        //
        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        //

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         * param scaleFactor automatically generated
         * param minNeighbors automatically generated
         * param flags automatically generated
         * param minSize automatically generated
         * param maxSize automatically generated
         * param outputRejectLevels automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize, bool outputRejectLevels)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_10(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height, outputRejectLevels);


        }

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         * param scaleFactor automatically generated
         * param minNeighbors automatically generated
         * param flags automatically generated
         * param minSize automatically generated
         * param maxSize automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_11(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);


        }

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         * param scaleFactor automatically generated
         * param minNeighbors automatically generated
         * param flags automatically generated
         * param minSize automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_12(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height);


        }

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         * param scaleFactor automatically generated
         * param minNeighbors automatically generated
         * param flags automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_13(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags);


        }

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         * param scaleFactor automatically generated
         * param minNeighbors automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_14(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors);


        }

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         * param scaleFactor automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_15(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor);


        }

        /**
         *
         *     This function allows you to retrieve the final stage decision certainty of classification.
         *     For this, one needs to set {code outputRejectLevels} on true and provide the {code rejectLevels} and {code levelWeights} parameter.
         *     For each resulting detection, {code levelWeights} will then contain the certainty of classification at the final stage.
         *     This value can then be used to separate strong from weaker classifications.
         *
         *     A code sample on how to use it efficiently can be found below:
         *     <code>
         *     Mat img;
         *     vector&lt;double&gt; weights;
         *     vector&lt;int&gt; levels;
         *     vector&lt;Rect&gt; detections;
         *     CascadeClassifier model("/path/to/your/model.xml");
         *     model.detectMultiScale(img, detections, levels, weights, 1.1, 3, 0, Size(), Size(), true);
         *     cerr &lt;&lt; "Detection " &lt;&lt; detections[0] &lt;&lt; " with weight " &lt;&lt; weights[0] &lt;&lt; endl;
         *     </code>
         * param image automatically generated
         * param objects automatically generated
         * param rejectLevels automatically generated
         * param levelWeights automatically generated
         */
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            objdetect_CascadeClassifier_detectMultiScale3_16(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj);


        }


        //
        // C++:  bool cv::CascadeClassifier::isOldFormatCascade()
        //

        public bool isOldFormatCascade()
        {
            ThrowIfDisposed();

            return objdetect_CascadeClassifier_isOldFormatCascade_10(nativeObj);


        }


        //
        // C++:  Size cv::CascadeClassifier::getOriginalWindowSize()
        //

        public Size getOriginalWindowSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_CascadeClassifier_getOriginalWindowSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  int cv::CascadeClassifier::getFeatureType()
        //

        public int getFeatureType()
        {
            ThrowIfDisposed();

            return objdetect_CascadeClassifier_getFeatureType_10(nativeObj);


        }


        //
        // C++: static bool cv::CascadeClassifier::convert(String oldcascade, String newcascade)
        //

        public static bool convert(string oldcascade, string newcascade)
        {


            return objdetect_CascadeClassifier_convert_10(oldcascade, newcascade);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::CascadeClassifier::CascadeClassifier()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10();

        // C++:   cv::CascadeClassifier::CascadeClassifier(String filename)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11(string filename);

        // C++:  bool cv::CascadeClassifier::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_empty_10(IntPtr nativeObj);

        // C++:  bool cv::CascadeClassifier::load(String filename)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_load_10(IntPtr nativeObj, string filename);

        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_14(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_15(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);

        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_14(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_15(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj);

        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, [MarshalAs(UnmanagedType.U1)] bool outputRejectLevels);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_14(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_15(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_16(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);

        // C++:  bool cv::CascadeClassifier::isOldFormatCascade()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_isOldFormatCascade_10(IntPtr nativeObj);

        // C++:  Size cv::CascadeClassifier::getOriginalWindowSize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_getOriginalWindowSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  int cv::CascadeClassifier::getFeatureType()
        [DllImport(LIBNAME)]
        private static extern int objdetect_CascadeClassifier_getFeatureType_10(IntPtr nativeObj);

        // C++: static bool cv::CascadeClassifier::convert(String oldcascade, String newcascade)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_convert_10(string oldcascade, string newcascade);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_delete(IntPtr nativeObj);

    }
}
