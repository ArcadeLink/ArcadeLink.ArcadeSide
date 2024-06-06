

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class HOGDescriptor
    /**
     * Implementation of HOG (Histogram of Oriented Gradients) descriptor and object detector.
     *
     * the HOG descriptor algorithm introduced by Navneet Dalal and Bill Triggs CITE: Dalal2005 .
     *
     * useful links:
     *
     * https://hal.inria.fr/inria-00548512/document/
     *
     * https://en.wikipedia.org/wiki/Histogram_of_oriented_gradients
     *
     * https://software.intel.com/en-us/ipp-dev-reference-histogram-of-oriented-gradients-hog-descriptor
     *
     * http://www.learnopencv.com/histogram-of-oriented-gradients
     *
     * http://www.learnopencv.com/handwritten-digits-classification-an-opencv-c-python-tutorial
     */

    public class HOGDescriptor : DisposableOpenCVObject
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
                        objdetect_HOGDescriptor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal HOGDescriptor(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static HOGDescriptor __fromPtr__(IntPtr addr) { return new HOGDescriptor(addr); }

        // C++: enum <unnamed>
        public const int DEFAULT_NLEVELS = 64;
        // C++: enum cv.HOGDescriptor.DescriptorStorageFormat
        public const int DESCR_FORMAT_COL_BY_COL = 0;
        public const int DESCR_FORMAT_ROW_BY_ROW = 1;
        // C++: enum cv.HOGDescriptor.HistogramNormType
        public const int L2Hys = 0;
        //
        // C++:   cv::HOGDescriptor::HOGDescriptor()
        //

        /**
         * Creates the HOG descriptor and detector with default parameters.
         *
         *     aqual to HOGDescriptor(Size(64,128), Size(16,16), Size(8,8), Size(8,8), 9 )
         */
        public HOGDescriptor()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_10());


        }


        //
        // C++:   cv::HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, HOGDescriptor_HistogramNormType _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS, bool _signedGradient = false)
        //

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         *     param _winSigma sets winSigma with given value.
         *     param _histogramNormType sets histogramNormType with given value.
         *     param _L2HysThreshold sets L2HysThreshold with given value.
         *     param _gammaCorrection sets gammaCorrection with given value.
         *     param _nlevels sets nlevels with given value.
         *     param _signedGradient sets signedGradient with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels, bool _signedGradient)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_11(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection, _nlevels, _signedGradient));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         *     param _winSigma sets winSigma with given value.
         *     param _histogramNormType sets histogramNormType with given value.
         *     param _L2HysThreshold sets L2HysThreshold with given value.
         *     param _gammaCorrection sets gammaCorrection with given value.
         *     param _nlevels sets nlevels with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_12(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection, _nlevels));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         *     param _winSigma sets winSigma with given value.
         *     param _histogramNormType sets histogramNormType with given value.
         *     param _L2HysThreshold sets L2HysThreshold with given value.
         *     param _gammaCorrection sets gammaCorrection with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_13(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         *     param _winSigma sets winSigma with given value.
         *     param _histogramNormType sets histogramNormType with given value.
         *     param _L2HysThreshold sets L2HysThreshold with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_14(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         *     param _winSigma sets winSigma with given value.
         *     param _histogramNormType sets histogramNormType with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_15(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         *     param _winSigma sets winSigma with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_16(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         *     param _derivAperture sets derivAperture with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_17(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture));


        }

        /**
         *
         *     param _winSize sets winSize with given value.
         *     param _blockSize sets blockSize with given value.
         *     param _blockStride sets blockStride with given value.
         *     param _cellSize sets cellSize with given value.
         *     param _nbins sets nbins with given value.
         */
        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_18(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins));


        }


        //
        // C++:   cv::HOGDescriptor::HOGDescriptor(String filename)
        //

        /**
         *
         *
         *     Creates the HOG descriptor and detector and loads HOGDescriptor parameters and coefficients for the linear SVM classifier from a file.
         *     param filename The file name containing HOGDescriptor properties and coefficients for the linear SVM classifier.
         */
        public HOGDescriptor(string filename)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_HOGDescriptor_19(filename));


        }


        //
        // C++:  size_t cv::HOGDescriptor::getDescriptorSize()
        //

        /**
         * Returns the number of coefficients required for the classification.
         * return automatically generated
         */
        public long getDescriptorSize()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_getDescriptorSize_10(nativeObj);


        }


        //
        // C++:  bool cv::HOGDescriptor::checkDetectorSize()
        //

        /**
         * Checks if detector size equal to descriptor size.
         * return automatically generated
         */
        public bool checkDetectorSize()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_checkDetectorSize_10(nativeObj);


        }


        //
        // C++:  double cv::HOGDescriptor::getWinSigma()
        //

        /**
         * Returns winSigma value
         * return automatically generated
         */
        public double getWinSigma()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_getWinSigma_10(nativeObj);


        }


        //
        // C++:  void cv::HOGDescriptor::setSVMDetector(Mat svmdetector)
        //

        /**
         * Sets coefficients for the linear SVM classifier.
         *     param svmdetector coefficients for the linear SVM classifier.
         */
        public void setSVMDetector(Mat svmdetector)
        {
            ThrowIfDisposed();
            if (svmdetector != null) svmdetector.ThrowIfDisposed();

            objdetect_HOGDescriptor_setSVMDetector_10(nativeObj, svmdetector.nativeObj);


        }


        //
        // C++:  bool cv::HOGDescriptor::load(String filename, String objname = String())
        //

        /**
         * loads HOGDescriptor parameters and coefficients for the linear SVM classifier from a file
         *     param filename Name of the file to read.
         *     param objname The optional name of the node to read (if empty, the first top-level node will be used).
         * return automatically generated
         */
        public bool load(string filename, string objname)
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_load_10(nativeObj, filename, objname);


        }

        /**
         * loads HOGDescriptor parameters and coefficients for the linear SVM classifier from a file
         *     param filename Name of the file to read.
         * return automatically generated
         */
        public bool load(string filename)
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_load_11(nativeObj, filename);


        }


        //
        // C++:  void cv::HOGDescriptor::save(String filename, String objname = String())
        //

        /**
         * saves HOGDescriptor parameters and coefficients for the linear SVM classifier to a file
         *     param filename File name
         *     param objname Object name
         */
        public void save(string filename, string objname)
        {
            ThrowIfDisposed();

            objdetect_HOGDescriptor_save_10(nativeObj, filename, objname);


        }

        /**
         * saves HOGDescriptor parameters and coefficients for the linear SVM classifier to a file
         *     param filename File name
         */
        public void save(string filename)
        {
            ThrowIfDisposed();

            objdetect_HOGDescriptor_save_11(nativeObj, filename);


        }


        //
        // C++:  void cv::HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = std::vector<Point>())
        //

        /**
         * Computes HOG descriptors of given image.
         *     param img Matrix of the type CV_8U containing an image where HOG features will be calculated.
         *     param descriptors Matrix of the type CV_32F
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         *     param locations Vector of Point
         */
        public void compute(Mat img, MatOfFloat descriptors, Size winStride, Size padding, MatOfPoint locations)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            if (locations != null) locations.ThrowIfDisposed();
            Mat descriptors_mat = descriptors;
            Mat locations_mat = locations;
            objdetect_HOGDescriptor_compute_10(nativeObj, img.nativeObj, descriptors_mat.nativeObj, winStride.width, winStride.height, padding.width, padding.height, locations_mat.nativeObj);


        }

        /**
         * Computes HOG descriptors of given image.
         *     param img Matrix of the type CV_8U containing an image where HOG features will be calculated.
         *     param descriptors Matrix of the type CV_32F
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         */
        public void compute(Mat img, MatOfFloat descriptors, Size winStride, Size padding)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            Mat descriptors_mat = descriptors;
            objdetect_HOGDescriptor_compute_11(nativeObj, img.nativeObj, descriptors_mat.nativeObj, winStride.width, winStride.height, padding.width, padding.height);


        }

        /**
         * Computes HOG descriptors of given image.
         *     param img Matrix of the type CV_8U containing an image where HOG features will be calculated.
         *     param descriptors Matrix of the type CV_32F
         *     param winStride Window stride. It must be a multiple of block stride.
         */
        public void compute(Mat img, MatOfFloat descriptors, Size winStride)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            Mat descriptors_mat = descriptors;
            objdetect_HOGDescriptor_compute_12(nativeObj, img.nativeObj, descriptors_mat.nativeObj, winStride.width, winStride.height);


        }

        /**
         * Computes HOG descriptors of given image.
         *     param img Matrix of the type CV_8U containing an image where HOG features will be calculated.
         *     param descriptors Matrix of the type CV_32F
         */
        public void compute(Mat img, MatOfFloat descriptors)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            Mat descriptors_mat = descriptors;
            objdetect_HOGDescriptor_compute_13(nativeObj, img.nativeObj, descriptors_mat.nativeObj);


        }


        //
        // C++:  void cv::HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = std::vector<Point>())
        //

        /**
         * Performs object detection without a multi-scale window.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of point where each point contains left-top corner point of detected object boundaries.
         *     param weights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         *     param searchLocations Vector of Point includes set of requested locations to be evaluated.
         */
        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold, Size winStride, Size padding, MatOfPoint searchLocations)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            if (searchLocations != null) searchLocations.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            Mat searchLocations_mat = searchLocations;
            objdetect_HOGDescriptor_detect_10(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, searchLocations_mat.nativeObj);


        }

        /**
         * Performs object detection without a multi-scale window.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of point where each point contains left-top corner point of detected object boundaries.
         *     param weights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         */
        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold, Size winStride, Size padding)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            objdetect_HOGDescriptor_detect_11(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height);


        }

        /**
         * Performs object detection without a multi-scale window.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of point where each point contains left-top corner point of detected object boundaries.
         *     param weights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         */
        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold, Size winStride)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            objdetect_HOGDescriptor_detect_12(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold, winStride.width, winStride.height);


        }

        /**
         * Performs object detection without a multi-scale window.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of point where each point contains left-top corner point of detected object boundaries.
         *     param weights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         */
        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            objdetect_HOGDescriptor_detect_13(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold);


        }

        /**
         * Performs object detection without a multi-scale window.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of point where each point contains left-top corner point of detected object boundaries.
         *     param weights Vector that will contain confidence values for each detected object.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         */
        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            objdetect_HOGDescriptor_detect_14(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj);


        }


        //
        // C++:  void cv::HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double groupThreshold = 2.0, bool useMeanshiftGrouping = false)
        //

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         *     param scale Coefficient of the detection window increase.
         *     param groupThreshold Coefficient to regulate the similarity threshold. When detected, some objects can be covered
         *     by many rectangles. 0 means not to perform grouping.
         *     param useMeanshiftGrouping indicates grouping algorithm
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding, double scale, double groupThreshold, bool useMeanshiftGrouping)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_10(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, scale, groupThreshold, useMeanshiftGrouping);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         *     param scale Coefficient of the detection window increase.
         *     param groupThreshold Coefficient to regulate the similarity threshold. When detected, some objects can be covered
         *     by many rectangles. 0 means not to perform grouping.
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding, double scale, double groupThreshold)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_11(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, scale, groupThreshold);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         *     param scale Coefficient of the detection window increase.
         *     by many rectangles. 0 means not to perform grouping.
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding, double scale)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_12(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, scale);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     param padding Padding
         *     by many rectangles. 0 means not to perform grouping.
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_13(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     param winStride Window stride. It must be a multiple of block stride.
         *     by many rectangles. 0 means not to perform grouping.
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_14(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     param hitThreshold Threshold for the distance between features and SVM classifying plane.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     by many rectangles. 0 means not to perform grouping.
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_15(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold);


        }

        /**
         * Detects objects of different sizes in the input image. The detected objects are returned as a list
         *     of rectangles.
         *     param img Matrix of the type CV_8U or CV_8UC3 containing an image where objects are detected.
         *     param foundLocations Vector of rectangles where each rectangle contains the detected object.
         *     param foundWeights Vector that will contain confidence values for each detected object.
         *     Usually it is 0 and should be specified in the detector coefficients (as the last free coefficient).
         *     But if the free coefficient is omitted (which is allowed), you can specify it manually here.
         *     by many rectangles. 0 means not to perform grouping.
         */
        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (foundLocations != null) foundLocations.ThrowIfDisposed();
            if (foundWeights != null) foundWeights.ThrowIfDisposed();
            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            objdetect_HOGDescriptor_detectMultiScale_16(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj);


        }


        //
        // C++:  void cv::HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
        //

        /**
         *  Computes gradients and quantized gradient orientations.
         *     param img Matrix contains the image to be computed
         *     param grad Matrix of type CV_32FC2 contains computed gradients
         *     param angleOfs Matrix of type CV_8UC2 contains quantized gradient orientations
         *     param paddingTL Padding from top-left
         *     param paddingBR Padding from bottom-right
         */
        public void computeGradient(Mat img, Mat grad, Mat angleOfs, Size paddingTL, Size paddingBR)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (grad != null) grad.ThrowIfDisposed();
            if (angleOfs != null) angleOfs.ThrowIfDisposed();

            objdetect_HOGDescriptor_computeGradient_10(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj, paddingTL.width, paddingTL.height, paddingBR.width, paddingBR.height);


        }

        /**
         *  Computes gradients and quantized gradient orientations.
         *     param img Matrix contains the image to be computed
         *     param grad Matrix of type CV_32FC2 contains computed gradients
         *     param angleOfs Matrix of type CV_8UC2 contains quantized gradient orientations
         *     param paddingTL Padding from top-left
         */
        public void computeGradient(Mat img, Mat grad, Mat angleOfs, Size paddingTL)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (grad != null) grad.ThrowIfDisposed();
            if (angleOfs != null) angleOfs.ThrowIfDisposed();

            objdetect_HOGDescriptor_computeGradient_11(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj, paddingTL.width, paddingTL.height);


        }

        /**
         *  Computes gradients and quantized gradient orientations.
         *     param img Matrix contains the image to be computed
         *     param grad Matrix of type CV_32FC2 contains computed gradients
         *     param angleOfs Matrix of type CV_8UC2 contains quantized gradient orientations
         */
        public void computeGradient(Mat img, Mat grad, Mat angleOfs)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (grad != null) grad.ThrowIfDisposed();
            if (angleOfs != null) angleOfs.ThrowIfDisposed();

            objdetect_HOGDescriptor_computeGradient_12(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj);


        }


        //
        // C++: static vector_float cv::HOGDescriptor::getDefaultPeopleDetector()
        //

        /**
         * Returns coefficients of the classifier trained for people detection (for 64x128 windows).
         * return automatically generated
         */
        public static MatOfFloat getDefaultPeopleDetector()
        {


            return MatOfFloat.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_getDefaultPeopleDetector_10()));


        }


        //
        // C++: static vector_float cv::HOGDescriptor::getDaimlerPeopleDetector()
        //

        /**
         * Returns coefficients of the classifier trained for people detection (for 48x96 windows).
         * return automatically generated
         */
        public static MatOfFloat getDaimlerPeopleDetector()
        {


            return MatOfFloat.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_getDaimlerPeopleDetector_10()));


        }


        //
        // C++: Size HOGDescriptor::winSize
        //

        public Size get_winSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_HOGDescriptor_get_1winSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: Size HOGDescriptor::blockSize
        //

        public Size get_blockSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_HOGDescriptor_get_1blockSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: Size HOGDescriptor::blockStride
        //

        public Size get_blockStride()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_HOGDescriptor_get_1blockStride_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: Size HOGDescriptor::cellSize
        //

        public Size get_cellSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_HOGDescriptor_get_1cellSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: int HOGDescriptor::nbins
        //

        public int get_nbins()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1nbins_10(nativeObj);


        }


        //
        // C++: int HOGDescriptor::derivAperture
        //

        public int get_derivAperture()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1derivAperture_10(nativeObj);


        }


        //
        // C++: double HOGDescriptor::winSigma
        //

        public double get_winSigma()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1winSigma_10(nativeObj);


        }


        //
        // C++: HOGDescriptor_HistogramNormType HOGDescriptor::histogramNormType
        //

        public int get_histogramNormType()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1histogramNormType_10(nativeObj);


        }


        //
        // C++: double HOGDescriptor::L2HysThreshold
        //

        public double get_L2HysThreshold()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1L2HysThreshold_10(nativeObj);


        }


        //
        // C++: bool HOGDescriptor::gammaCorrection
        //

        public bool get_gammaCorrection()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1gammaCorrection_10(nativeObj);


        }


        //
        // C++: vector_float HOGDescriptor::svmDetector
        //

        public MatOfFloat get_svmDetector()
        {
            ThrowIfDisposed();

            return MatOfFloat.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(objdetect_HOGDescriptor_get_1svmDetector_10(nativeObj)));


        }


        //
        // C++: int HOGDescriptor::nlevels
        //

        public int get_nlevels()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1nlevels_10(nativeObj);


        }


        //
        // C++: bool HOGDescriptor::signedGradient
        //

        public bool get_signedGradient()
        {
            ThrowIfDisposed();

            return objdetect_HOGDescriptor_get_1signedGradient_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::HOGDescriptor::HOGDescriptor()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_10();

        // C++:   cv::HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, HOGDescriptor_HistogramNormType _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS, bool _signedGradient = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_11(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, [MarshalAs(UnmanagedType.U1)] bool _gammaCorrection, int _nlevels, [MarshalAs(UnmanagedType.U1)] bool _signedGradient);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_12(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, [MarshalAs(UnmanagedType.U1)] bool _gammaCorrection, int _nlevels);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_13(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, [MarshalAs(UnmanagedType.U1)] bool _gammaCorrection);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_14(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_15(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_16(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_17(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_18(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins);

        // C++:   cv::HOGDescriptor::HOGDescriptor(String filename)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_19(string filename);

        // C++:  size_t cv::HOGDescriptor::getDescriptorSize()
        [DllImport(LIBNAME)]
        private static extern long objdetect_HOGDescriptor_getDescriptorSize_10(IntPtr nativeObj);

        // C++:  bool cv::HOGDescriptor::checkDetectorSize()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_HOGDescriptor_checkDetectorSize_10(IntPtr nativeObj);

        // C++:  double cv::HOGDescriptor::getWinSigma()
        [DllImport(LIBNAME)]
        private static extern double objdetect_HOGDescriptor_getWinSigma_10(IntPtr nativeObj);

        // C++:  void cv::HOGDescriptor::setSVMDetector(Mat svmdetector)
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_setSVMDetector_10(IntPtr nativeObj, IntPtr svmdetector_nativeObj);

        // C++:  bool cv::HOGDescriptor::load(String filename, String objname = String())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_HOGDescriptor_load_10(IntPtr nativeObj, string filename, string objname);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_HOGDescriptor_load_11(IntPtr nativeObj, string filename);

        // C++:  void cv::HOGDescriptor::save(String filename, String objname = String())
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_save_10(IntPtr nativeObj, string filename, string objname);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_save_11(IntPtr nativeObj, string filename);

        // C++:  void cv::HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = std::vector<Point>())
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_compute_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr locations_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_compute_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height, double padding_width, double padding_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_compute_12(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_compute_13(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void cv::HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = std::vector<Point>())
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr searchLocations_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_12(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_13(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_14(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj);

        // C++:  void cv::HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double groupThreshold = 2.0, bool useMeanshiftGrouping = false)
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale, double groupThreshold, [MarshalAs(UnmanagedType.U1)] bool useMeanshiftGrouping);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale, double groupThreshold);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_12(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_13(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_14(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_15(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_16(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj);

        // C++:  void cv::HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_computeGradient_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj, double paddingTL_width, double paddingTL_height, double paddingBR_width, double paddingBR_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_computeGradient_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj, double paddingTL_width, double paddingTL_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_computeGradient_12(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj);

        // C++: static vector_float cv::HOGDescriptor::getDefaultPeopleDetector()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_getDefaultPeopleDetector_10();

        // C++: static vector_float cv::HOGDescriptor::getDaimlerPeopleDetector()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_getDaimlerPeopleDetector_10();

        // C++: Size HOGDescriptor::winSize
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1winSize_10(IntPtr nativeObj, double[] retVal);

        // C++: Size HOGDescriptor::blockSize
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1blockSize_10(IntPtr nativeObj, double[] retVal);

        // C++: Size HOGDescriptor::blockStride
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1blockStride_10(IntPtr nativeObj, double[] retVal);

        // C++: Size HOGDescriptor::cellSize
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1cellSize_10(IntPtr nativeObj, double[] retVal);

        // C++: int HOGDescriptor::nbins
        [DllImport(LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1nbins_10(IntPtr nativeObj);

        // C++: int HOGDescriptor::derivAperture
        [DllImport(LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1derivAperture_10(IntPtr nativeObj);

        // C++: double HOGDescriptor::winSigma
        [DllImport(LIBNAME)]
        private static extern double objdetect_HOGDescriptor_get_1winSigma_10(IntPtr nativeObj);

        // C++: HOGDescriptor_HistogramNormType HOGDescriptor::histogramNormType
        [DllImport(LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1histogramNormType_10(IntPtr nativeObj);

        // C++: double HOGDescriptor::L2HysThreshold
        [DllImport(LIBNAME)]
        private static extern double objdetect_HOGDescriptor_get_1L2HysThreshold_10(IntPtr nativeObj);

        // C++: bool HOGDescriptor::gammaCorrection
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_HOGDescriptor_get_1gammaCorrection_10(IntPtr nativeObj);

        // C++: vector_float HOGDescriptor::svmDetector
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_get_1svmDetector_10(IntPtr nativeObj);

        // C++: int HOGDescriptor::nlevels
        [DllImport(LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1nlevels_10(IntPtr nativeObj);

        // C++: bool HOGDescriptor::signedGradient
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_HOGDescriptor_get_1signedGradient_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_HOGDescriptor_delete(IntPtr nativeObj);

    }
}
