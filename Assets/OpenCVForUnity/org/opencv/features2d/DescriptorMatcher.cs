
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class DescriptorMatcher
    /**
     * Abstract base class for matching keypoint descriptors.
     *
     * It has two groups of match methods: for matching descriptors of an image with another image or with
     * an image set.
     */

    public class DescriptorMatcher : Algorithm
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
                        features2d_DescriptorMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DescriptorMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DescriptorMatcher __fromPtr__(IntPtr addr) { return new DescriptorMatcher(addr); }

        // C++: enum cv.DescriptorMatcher.MatcherType
        public const int FLANNBASED = 1;
        public const int BRUTEFORCE = 2;
        public const int BRUTEFORCE_L1 = 3;
        public const int BRUTEFORCE_HAMMING = 4;
        public const int BRUTEFORCE_HAMMINGLUT = 5;
        public const int BRUTEFORCE_SL2 = 6;
        //
        // C++:  void cv::DescriptorMatcher::add(vector_Mat descriptors)
        //

        /**
         * Adds descriptors to train a CPU(trainDescCollectionis) or GPU(utrainDescCollectionis) descriptor
         *     collection.
         *
         *     If the collection is not empty, the new descriptors are added to existing train descriptors.
         *
         *     param descriptors Descriptors to add. Each descriptors[i] is a set of descriptors from the same
         *     train image.
         */
        public void add(List<Mat> descriptors)
        {
            ThrowIfDisposed();
            Mat descriptors_mat = Converters.vector_Mat_to_Mat(descriptors);
            features2d_DescriptorMatcher_add_10(nativeObj, descriptors_mat.nativeObj);


        }


        //
        // C++:  vector_Mat cv::DescriptorMatcher::getTrainDescriptors()
        //

        /**
         * Returns a constant link to the train descriptor collection trainDescCollection .
         * return automatically generated
         */
        public List<Mat> getTrainDescriptors()
        {
            ThrowIfDisposed();
            List<Mat> retVal = new List<Mat>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_DescriptorMatcher_getTrainDescriptors_10(nativeObj)));
            Converters.Mat_to_vector_Mat(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  void cv::DescriptorMatcher::clear()
        //

        /**
         * Clears the train descriptor collections.
         */
        public override void clear()
        {
            ThrowIfDisposed();

            features2d_DescriptorMatcher_clear_10(nativeObj);


        }


        //
        // C++:  bool cv::DescriptorMatcher::empty()
        //

        /**
         * Returns true if there are no train descriptors in the both collections.
         * return automatically generated
         */
        public override bool empty()
        {
            ThrowIfDisposed();

            return features2d_DescriptorMatcher_empty_10(nativeObj);


        }


        //
        // C++:  bool cv::DescriptorMatcher::isMaskSupported()
        //

        /**
         * Returns true if the descriptor matcher supports masking permissible matches.
         * return automatically generated
         */
        public bool isMaskSupported()
        {
            ThrowIfDisposed();

            return features2d_DescriptorMatcher_isMaskSupported_10(nativeObj);


        }


        //
        // C++:  void cv::DescriptorMatcher::train()
        //

        /**
         * Trains a descriptor matcher
         *
         *     Trains a descriptor matcher (for example, the flann index). In all methods to match, the method
         *     train() is run every time before matching. Some descriptor matchers (for example, BruteForceMatcher)
         *     have an empty implementation of this method. Other matchers really train their inner structures (for
         *     example, FlannBasedMatcher trains flann::Index ).
         */
        public void train()
        {
            ThrowIfDisposed();

            features2d_DescriptorMatcher_train_10(nativeObj);


        }


        //
        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
        //

        /**
         * Finds the best match for each descriptor from a query set.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param matches Matches. If a query descriptor is masked out in mask , no match is added for this
         *     descriptor. So, matches size may be smaller than the query descriptors count.
         *     param mask Mask specifying permissible matches between an input query and train matrices of
         *     descriptors.
         *
         *     In the first variant of this method, the train descriptors are passed as an input argument. In the
         *     second variant of the method, train descriptors collection that was set by DescriptorMatcher::add is
         *     used. Optional mask (or masks) can be passed to specify which query and training descriptors can be
         *     matched. Namely, queryDescriptors[i] can be matched with trainDescriptors[j] only if
         *     mask.at&lt;uchar&gt;(i,j) is non-zero.
         */
        public void match(Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches, Mat mask)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat matches_mat = matches;
            features2d_DescriptorMatcher_match_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, mask.nativeObj);


        }

        /**
         * Finds the best match for each descriptor from a query set.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param matches Matches. If a query descriptor is masked out in mask , no match is added for this
         *     descriptor. So, matches size may be smaller than the query descriptors count.
         *     descriptors.
         *
         *     In the first variant of this method, the train descriptors are passed as an input argument. In the
         *     second variant of the method, train descriptors collection that was set by DescriptorMatcher::add is
         *     used. Optional mask (or masks) can be passed to specify which query and training descriptors can be
         *     matched. Namely, queryDescriptors[i] can be matched with trainDescriptors[j] only if
         *     mask.at&lt;uchar&gt;(i,j) is non-zero.
         */
        public void match(Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
            Mat matches_mat = matches;
            features2d_DescriptorMatcher_match_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj);


        }


        //
        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        //

        /**
         * Finds the k best matches for each descriptor from a query set.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param mask Mask specifying permissible matches between an input query and train matrices of
         *     descriptors.
         *     param matches Matches. Each matches[i] is k or less matches for the same query descriptor.
         *     param k Count of best matches found per each query descriptor or less if a query descriptor has
         *     less than k possible matches in total.
         *     param compactResult Parameter used when the mask (or masks) is not empty. If compactResult is
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         *
         *     These extended variants of DescriptorMatcher::match methods find several best matches for each query
         *     descriptor. The matches are returned in the distance increasing order. See DescriptorMatcher::match
         *     for the details about query and train descriptors.
         */
        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_knnMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         * Finds the k best matches for each descriptor from a query set.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param mask Mask specifying permissible matches between an input query and train matrices of
         *     descriptors.
         *     param matches Matches. Each matches[i] is k or less matches for the same query descriptor.
         *     param k Count of best matches found per each query descriptor or less if a query descriptor has
         *     less than k possible matches in total.
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         *
         *     These extended variants of DescriptorMatcher::match methods find several best matches for each query
         *     descriptor. The matches are returned in the distance increasing order. See DescriptorMatcher::match
         *     for the details about query and train descriptors.
         */
        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_knnMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         * Finds the k best matches for each descriptor from a query set.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     descriptors.
         *     param matches Matches. Each matches[i] is k or less matches for the same query descriptor.
         *     param k Count of best matches found per each query descriptor or less if a query descriptor has
         *     less than k possible matches in total.
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         *
         *     These extended variants of DescriptorMatcher::match methods find several best matches for each query
         *     descriptor. The matches are returned in the distance increasing order. See DescriptorMatcher::match
         *     for the details about query and train descriptors.
         */
        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_knnMatch_12(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }


        //
        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        //

        /**
         * For each query descriptor, finds the training descriptors not farther than the specified distance.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param matches Found matches.
         *     param compactResult Parameter used when the mask (or masks) is not empty. If compactResult is
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         *     param maxDistance Threshold for the distance between matched descriptors. Distance means here
         *     metric distance (e.g. Hamming distance), not the distance between coordinates (which is measured
         *     in Pixels)!
         *     param mask Mask specifying permissible matches between an input query and train matrices of
         *     descriptors.
         *
         *     For each query descriptor, the methods find such training descriptors that the distance between the
         *     query descriptor and the training descriptor is equal or smaller than maxDistance. Found matches are
         *     returned in the distance increasing order.
         */
        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_radiusMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         * For each query descriptor, finds the training descriptors not farther than the specified distance.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param matches Found matches.
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         *     param maxDistance Threshold for the distance between matched descriptors. Distance means here
         *     metric distance (e.g. Hamming distance), not the distance between coordinates (which is measured
         *     in Pixels)!
         *     param mask Mask specifying permissible matches between an input query and train matrices of
         *     descriptors.
         *
         *     For each query descriptor, the methods find such training descriptors that the distance between the
         *     query descriptor and the training descriptor is equal or smaller than maxDistance. Found matches are
         *     returned in the distance increasing order.
         */
        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_radiusMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         * For each query descriptor, finds the training descriptors not farther than the specified distance.
         *
         *     param queryDescriptors Query set of descriptors.
         *     param trainDescriptors Train set of descriptors. This set is not added to the train descriptors
         *     collection stored in the class object.
         *     param matches Found matches.
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         *     param maxDistance Threshold for the distance between matched descriptors. Distance means here
         *     metric distance (e.g. Hamming distance), not the distance between coordinates (which is measured
         *     in Pixels)!
         *     descriptors.
         *
         *     For each query descriptor, the methods find such training descriptors that the distance between the
         *     query descriptor and the training descriptor is equal or smaller than maxDistance. Found matches are
         *     returned in the distance increasing order.
         */
        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_radiusMatch_12(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }


        //
        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector_Mat())
        //

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Matches. If a query descriptor is masked out in mask , no match is added for this
         *     descriptor. So, matches size may be smaller than the query descriptors count.
         *     param masks Set of masks. Each masks[i] specifies permissible matches between the input query
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         */
        public void match(Mat queryDescriptors, MatOfDMatch matches, List<Mat> masks)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
            Mat matches_mat = matches;
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            features2d_DescriptorMatcher_match_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);


        }

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Matches. If a query descriptor is masked out in mask , no match is added for this
         *     descriptor. So, matches size may be smaller than the query descriptors count.
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         */
        public void match(Mat queryDescriptors, MatOfDMatch matches)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
            Mat matches_mat = matches;
            features2d_DescriptorMatcher_match_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj);


        }


        //
        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector_Mat(), bool compactResult = false)
        //

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Matches. Each matches[i] is k or less matches for the same query descriptor.
         *     param k Count of best matches found per each query descriptor or less if a query descriptor has
         *     less than k possible matches in total.
         *     param masks Set of masks. Each masks[i] specifies permissible matches between the input query
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         *     param compactResult Parameter used when the mask (or masks) is not empty. If compactResult is
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         */
        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            features2d_DescriptorMatcher_knnMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Matches. Each matches[i] is k or less matches for the same query descriptor.
         *     param k Count of best matches found per each query descriptor or less if a query descriptor has
         *     less than k possible matches in total.
         *     param masks Set of masks. Each masks[i] specifies permissible matches between the input query
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         */
        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            features2d_DescriptorMatcher_knnMatch_14(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Matches. Each matches[i] is k or less matches for the same query descriptor.
         *     param k Count of best matches found per each query descriptor or less if a query descriptor has
         *     less than k possible matches in total.
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         */
        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_knnMatch_15(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }


        //
        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector_Mat(), bool compactResult = false)
        //

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Found matches.
         *     param maxDistance Threshold for the distance between matched descriptors. Distance means here
         *     metric distance (e.g. Hamming distance), not the distance between coordinates (which is measured
         *     in Pixels)!
         *     param masks Set of masks. Each masks[i] specifies permissible matches between the input query
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         *     param compactResult Parameter used when the mask (or masks) is not empty. If compactResult is
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         */
        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            features2d_DescriptorMatcher_radiusMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Found matches.
         *     param maxDistance Threshold for the distance between matched descriptors. Distance means here
         *     metric distance (e.g. Hamming distance), not the distance between coordinates (which is measured
         *     in Pixels)!
         *     param masks Set of masks. Each masks[i] specifies permissible matches between the input query
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         */
        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            features2d_DescriptorMatcher_radiusMatch_14(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }

        /**
         *
         *     param queryDescriptors Query set of descriptors.
         *     param matches Found matches.
         *     param maxDistance Threshold for the distance between matched descriptors. Distance means here
         *     metric distance (e.g. Hamming distance), not the distance between coordinates (which is measured
         *     in Pixels)!
         *     descriptors and stored train descriptors from the i-th image trainDescCollection[i].
         *     false, the matches vector has the same size as queryDescriptors rows. If compactResult is true,
         *     the matches vector does not contain matches for fully masked-out query descriptors.
         */
        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            Mat matches_mat = new Mat();
            features2d_DescriptorMatcher_radiusMatch_15(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
            matches_mat.release();

        }


        //
        // C++:  void cv::DescriptorMatcher::write(String fileName)
        //

        public void write(string fileName)
        {
            ThrowIfDisposed();

            features2d_DescriptorMatcher_write_10(nativeObj, fileName);


        }


        //
        // C++:  void cv::DescriptorMatcher::read(String fileName)
        //

        public void read(string fileName)
        {
            ThrowIfDisposed();

            features2d_DescriptorMatcher_read_10(nativeObj, fileName);


        }


        //
        // C++:  void cv::DescriptorMatcher::read(FileNode arg1)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  Ptr_DescriptorMatcher cv::DescriptorMatcher::clone(bool emptyTrainData = false)
        //

        /**
         * Clones the matcher.
         *
         *     param emptyTrainData If emptyTrainData is false, the method creates a deep copy of the object,
         *     that is, copies both parameters and train data. If emptyTrainData is true, the method creates an
         *     object copy with the current parameters but with empty train data.
         * return automatically generated
         */
        public DescriptorMatcher clone(bool emptyTrainData)
        {
            ThrowIfDisposed();

            return DescriptorMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_DescriptorMatcher_clone_10(nativeObj, emptyTrainData)));


        }

        /**
         * Clones the matcher.
         *
         *     that is, copies both parameters and train data. If emptyTrainData is true, the method creates an
         *     object copy with the current parameters but with empty train data.
         * return automatically generated
         */
        public DescriptorMatcher clone()
        {
            ThrowIfDisposed();

            return DescriptorMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_DescriptorMatcher_clone_11(nativeObj)));


        }


        //
        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(String descriptorMatcherType)
        //

        /**
         * Creates a descriptor matcher of a given type with the default parameters (using default
         *     constructor).
         *
         *     param descriptorMatcherType Descriptor matcher type. Now the following matcher types are
         *     supported:
         * <ul>
         *   <li>
         *        {code BruteForce} (it uses L2 )
         *   </li>
         *   <li>
         *        {code BruteForce-L1}
         *   </li>
         *   <li>
         *        {code BruteForce-Hamming}
         *   </li>
         *   <li>
         *        {code BruteForce-Hamming(2)}
         *   </li>
         *   <li>
         *        {code FlannBased}
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static DescriptorMatcher create(string descriptorMatcherType)
        {


            return DescriptorMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_DescriptorMatcher_create_10(descriptorMatcherType)));


        }


        //
        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(DescriptorMatcher_MatcherType matcherType)
        //

        public static DescriptorMatcher create(int matcherType)
        {


            return DescriptorMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_DescriptorMatcher_create_11(matcherType)));


        }


        //
        // C++:  void cv::DescriptorMatcher::write(FileStorage fs, String name)
        //

        // Unknown type 'FileStorage' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::DescriptorMatcher::add(vector_Mat descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_add_10(IntPtr nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  vector_Mat cv::DescriptorMatcher::getTrainDescriptors()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_getTrainDescriptors_10(IntPtr nativeObj);

        // C++:  void cv::DescriptorMatcher::clear()
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_clear_10(IntPtr nativeObj);

        // C++:  bool cv::DescriptorMatcher::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_DescriptorMatcher_empty_10(IntPtr nativeObj);

        // C++:  bool cv::DescriptorMatcher::isMaskSupported()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_DescriptorMatcher_isMaskSupported_10(IntPtr nativeObj);

        // C++:  void cv::DescriptorMatcher::train()
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_train_10(IntPtr nativeObj);

        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector_Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector_Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_14(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_15(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector_Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_14(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_15(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void cv::DescriptorMatcher::write(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_write_10(IntPtr nativeObj, string fileName);

        // C++:  void cv::DescriptorMatcher::read(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_read_10(IntPtr nativeObj, string fileName);

        // C++:  Ptr_DescriptorMatcher cv::DescriptorMatcher::clone(bool emptyTrainData = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_clone_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool emptyTrainData);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_clone_11(IntPtr nativeObj);

        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(String descriptorMatcherType)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_create_10(string descriptorMatcherType);

        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(DescriptorMatcher_MatcherType matcherType)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_create_11(int matcherType);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_delete(IntPtr nativeObj);

    }
}
