
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class EM
    /**
     * The class implements the Expectation Maximization algorithm.
     *
     * SEE: REF: ml_intro_em
     */

    public class EM : StatModel
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
                        ml_EM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EM(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EM __fromPtr__(IntPtr addr) { return new EM(addr); }

        // C++: enum <unnamed>
        public const int DEFAULT_NCLUSTERS = 5;
        public const int DEFAULT_MAX_ITERS = 100;
        public const int START_E_STEP = 1;
        public const int START_M_STEP = 2;
        public const int START_AUTO_STEP = 0;
        // C++: enum cv.ml.EM.Types
        public const int COV_MAT_SPHERICAL = 0;
        public const int COV_MAT_DIAGONAL = 1;
        public const int COV_MAT_GENERIC = 2;
        public const int COV_MAT_DEFAULT = COV_MAT_DIAGONAL;
        //
        // C++:  int cv::ml::EM::getClustersNumber()
        //

        /**
         * SEE: setClustersNumber
         * return automatically generated
         */
        public int getClustersNumber()
        {
            ThrowIfDisposed();

            return ml_EM_getClustersNumber_10(nativeObj);


        }


        //
        // C++:  void cv::ml::EM::setClustersNumber(int val)
        //

        /**
         *  getClustersNumber SEE: getClustersNumber
         * param val automatically generated
         */
        public void setClustersNumber(int val)
        {
            ThrowIfDisposed();

            ml_EM_setClustersNumber_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::EM::getCovarianceMatrixType()
        //

        /**
         * SEE: setCovarianceMatrixType
         * return automatically generated
         */
        public int getCovarianceMatrixType()
        {
            ThrowIfDisposed();

            return ml_EM_getCovarianceMatrixType_10(nativeObj);


        }


        //
        // C++:  void cv::ml::EM::setCovarianceMatrixType(int val)
        //

        /**
         *  getCovarianceMatrixType SEE: getCovarianceMatrixType
         * param val automatically generated
         */
        public void setCovarianceMatrixType(int val)
        {
            ThrowIfDisposed();

            ml_EM_setCovarianceMatrixType_10(nativeObj, val);


        }


        //
        // C++:  TermCriteria cv::ml::EM::getTermCriteria()
        //

        /**
         * SEE: setTermCriteria
         * return automatically generated
         */
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            ml_EM_getTermCriteria_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::ml::EM::setTermCriteria(TermCriteria val)
        //

        /**
         *  getTermCriteria SEE: getTermCriteria
         * param val automatically generated
         */
        public void setTermCriteria(TermCriteria val)
        {
            ThrowIfDisposed();

            ml_EM_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);


        }


        //
        // C++:  Mat cv::ml::EM::getWeights()
        //

        /**
         * Returns weights of the mixtures
         *
         *     Returns vector with the number of elements equal to the number of mixtures.
         * return automatically generated
         */
        public Mat getWeights()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_EM_getWeights_10(nativeObj)));


        }


        //
        // C++:  Mat cv::ml::EM::getMeans()
        //

        /**
         * Returns the cluster centers (means of the Gaussian mixture)
         *
         *     Returns matrix with the number of rows equal to the number of mixtures and number of columns
         *     equal to the space dimensionality.
         * return automatically generated
         */
        public Mat getMeans()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_EM_getMeans_10(nativeObj)));


        }


        //
        // C++:  void cv::ml::EM::getCovs(vector_Mat& covs)
        //

        /**
         * Returns covariation matrices
         *
         *     Returns vector of covariation matrices. Number of matrices is the number of gaussian mixtures,
         *     each matrix is a square floating-point matrix NxN, where N is the space dimensionality.
         * param covs automatically generated
         */
        public void getCovs(List<Mat> covs)
        {
            ThrowIfDisposed();
            Mat covs_mat = new Mat();
            ml_EM_getCovs_10(nativeObj, covs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(covs_mat, covs);
            covs_mat.release();

        }


        //
        // C++:  float cv::ml::EM::predict(Mat samples, Mat& results = Mat(), int flags = 0)
        //

        /**
         * Returns posterior probabilities for the provided samples
         *
         *     param samples The input samples, floating-point matrix
         *     param results The optional output \( nSamples \times nClusters\) matrix of results. It contains
         *     posterior probabilities for each sample from the input
         *     param flags This parameter will be ignored
         * return automatically generated
         */
        public override float predict(Mat samples, Mat results, int flags)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();

            return ml_EM_predict_10(nativeObj, samples.nativeObj, results.nativeObj, flags);


        }

        /**
         * Returns posterior probabilities for the provided samples
         *
         *     param samples The input samples, floating-point matrix
         *     param results The optional output \( nSamples \times nClusters\) matrix of results. It contains
         *     posterior probabilities for each sample from the input
         * return automatically generated
         */
        public override float predict(Mat samples, Mat results)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();

            return ml_EM_predict_11(nativeObj, samples.nativeObj, results.nativeObj);


        }

        /**
         * Returns posterior probabilities for the provided samples
         *
         *     param samples The input samples, floating-point matrix
         *     posterior probabilities for each sample from the input
         * return automatically generated
         */
        public override float predict(Mat samples)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();

            return ml_EM_predict_12(nativeObj, samples.nativeObj);


        }


        //
        // C++:  Vec2d cv::ml::EM::predict2(Mat sample, Mat& probs)
        //

        /**
         * Returns a likelihood logarithm value and an index of the most probable mixture component
         *     for the given sample.
         *
         *     param sample A sample for classification. It should be a one-channel matrix of
         *         \(1 \times dims\) or \(dims \times 1\) size.
         *     param probs Optional output matrix that contains posterior probabilities of each component
         *         given the sample. It has \(1 \times nclusters\) size and CV_64FC1 type.
         *
         *     The method returns a two-element double vector. Zero element is a likelihood logarithm value for
         *     the sample. First element is an index of the most probable mixture component for the given
         *     sample.
         * return automatically generated
         */
        public double[] predict2(Mat sample, Mat probs)
        {
            ThrowIfDisposed();
            if (sample != null) sample.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();

            double[] retVal = new double[2];
            ml_EM_predict2_10(nativeObj, sample.nativeObj, probs.nativeObj, retVal);

            return retVal;
        }


        //
        // C++:  bool cv::ml::EM::trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. Initial values of the model parameters will be
         *     estimated by the k-means algorithm.
         *
         *     Unlike many of the ML models, %EM is an unsupervised learning algorithm and it does not take
         *     responses (class labels or function values) as input. Instead, it computes the *Maximum
         *     Likelihood Estimate* of the Gaussian mixture parameters from an input sample set, stores all the
         *     parameters inside the structure: \(p_{i,k}\) in probs, \(a_k\) in means , \(S_k\) in
         *     covs[k], \(\pi_k\) in weights , and optionally computes the output "class label" for each
         *     sample: \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most
         *     probable mixture component for each sample).
         *
         *     The trained model can be used further for prediction, just like any other classifier. The
         *     trained model is similar to the NormalBayesClassifier.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *     param labels The optional output "class label" for each sample:
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *     param probs The optional output matrix that contains posterior probabilities of each Gaussian
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainEM(Mat samples, Mat logLikelihoods, Mat labels, Mat probs)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();

            return ml_EM_trainEM_10(nativeObj, samples.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. Initial values of the model parameters will be
         *     estimated by the k-means algorithm.
         *
         *     Unlike many of the ML models, %EM is an unsupervised learning algorithm and it does not take
         *     responses (class labels or function values) as input. Instead, it computes the *Maximum
         *     Likelihood Estimate* of the Gaussian mixture parameters from an input sample set, stores all the
         *     parameters inside the structure: \(p_{i,k}\) in probs, \(a_k\) in means , \(S_k\) in
         *     covs[k], \(\pi_k\) in weights , and optionally computes the output "class label" for each
         *     sample: \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most
         *     probable mixture component for each sample).
         *
         *     The trained model can be used further for prediction, just like any other classifier. The
         *     trained model is similar to the NormalBayesClassifier.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *     param labels The optional output "class label" for each sample:
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainEM(Mat samples, Mat logLikelihoods, Mat labels)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();

            return ml_EM_trainEM_11(nativeObj, samples.nativeObj, logLikelihoods.nativeObj, labels.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. Initial values of the model parameters will be
         *     estimated by the k-means algorithm.
         *
         *     Unlike many of the ML models, %EM is an unsupervised learning algorithm and it does not take
         *     responses (class labels or function values) as input. Instead, it computes the *Maximum
         *     Likelihood Estimate* of the Gaussian mixture parameters from an input sample set, stores all the
         *     parameters inside the structure: \(p_{i,k}\) in probs, \(a_k\) in means , \(S_k\) in
         *     covs[k], \(\pi_k\) in weights , and optionally computes the output "class label" for each
         *     sample: \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most
         *     probable mixture component for each sample).
         *
         *     The trained model can be used further for prediction, just like any other classifier. The
         *     trained model is similar to the NormalBayesClassifier.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainEM(Mat samples, Mat logLikelihoods)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();

            return ml_EM_trainEM_12(nativeObj, samples.nativeObj, logLikelihoods.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. Initial values of the model parameters will be
         *     estimated by the k-means algorithm.
         *
         *     Unlike many of the ML models, %EM is an unsupervised learning algorithm and it does not take
         *     responses (class labels or function values) as input. Instead, it computes the *Maximum
         *     Likelihood Estimate* of the Gaussian mixture parameters from an input sample set, stores all the
         *     parameters inside the structure: \(p_{i,k}\) in probs, \(a_k\) in means , \(S_k\) in
         *     covs[k], \(\pi_k\) in weights , and optionally computes the output "class label" for each
         *     sample: \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most
         *     probable mixture component for each sample).
         *
         *     The trained model can be used further for prediction, just like any other classifier. The
         *     trained model is similar to the NormalBayesClassifier.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainEM(Mat samples)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();

            return ml_EM_trainEM_13(nativeObj, samples.nativeObj);


        }


        //
        // C++:  bool cv::ml::EM::trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. You need to provide initial means \(a_k\) of
         *     mixture components. Optionally you can pass initial weights \(\pi_k\) and covariance matrices
         *     \(S_k\) of mixture components.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param means0 Initial means \(a_k\) of mixture components. It is a one-channel matrix of
         *         \(nclusters \times dims\) size. If the matrix does not have CV_64F type it will be
         *         converted to the inner matrix of such type for the further computing.
         *     param covs0 The vector of initial covariance matrices \(S_k\) of mixture components. Each of
         *         covariance matrices is a one-channel matrix of \(dims \times dims\) size. If the matrices
         *         do not have CV_64F type they will be converted to the inner matrices of such type for the
         *         further computing.
         *     param weights0 Initial weights \(\pi_k\) of mixture components. It should be a one-channel
         *         floating-point matrix with \(1 \times nclusters\) or \(nclusters \times 1\) size.
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *     param labels The optional output "class label" for each sample:
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *     param probs The optional output matrix that contains posterior probabilities of each Gaussian
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels, Mat probs)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();

            return ml_EM_trainE_10(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. You need to provide initial means \(a_k\) of
         *     mixture components. Optionally you can pass initial weights \(\pi_k\) and covariance matrices
         *     \(S_k\) of mixture components.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param means0 Initial means \(a_k\) of mixture components. It is a one-channel matrix of
         *         \(nclusters \times dims\) size. If the matrix does not have CV_64F type it will be
         *         converted to the inner matrix of such type for the further computing.
         *     param covs0 The vector of initial covariance matrices \(S_k\) of mixture components. Each of
         *         covariance matrices is a one-channel matrix of \(dims \times dims\) size. If the matrices
         *         do not have CV_64F type they will be converted to the inner matrices of such type for the
         *         further computing.
         *     param weights0 Initial weights \(\pi_k\) of mixture components. It should be a one-channel
         *         floating-point matrix with \(1 \times nclusters\) or \(nclusters \times 1\) size.
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *     param labels The optional output "class label" for each sample:
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();

            return ml_EM_trainE_11(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. You need to provide initial means \(a_k\) of
         *     mixture components. Optionally you can pass initial weights \(\pi_k\) and covariance matrices
         *     \(S_k\) of mixture components.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param means0 Initial means \(a_k\) of mixture components. It is a one-channel matrix of
         *         \(nclusters \times dims\) size. If the matrix does not have CV_64F type it will be
         *         converted to the inner matrix of such type for the further computing.
         *     param covs0 The vector of initial covariance matrices \(S_k\) of mixture components. Each of
         *         covariance matrices is a one-channel matrix of \(dims \times dims\) size. If the matrices
         *         do not have CV_64F type they will be converted to the inner matrices of such type for the
         *         further computing.
         *     param weights0 Initial weights \(\pi_k\) of mixture components. It should be a one-channel
         *         floating-point matrix with \(1 \times nclusters\) or \(nclusters \times 1\) size.
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();

            return ml_EM_trainE_12(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. You need to provide initial means \(a_k\) of
         *     mixture components. Optionally you can pass initial weights \(\pi_k\) and covariance matrices
         *     \(S_k\) of mixture components.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param means0 Initial means \(a_k\) of mixture components. It is a one-channel matrix of
         *         \(nclusters \times dims\) size. If the matrix does not have CV_64F type it will be
         *         converted to the inner matrix of such type for the further computing.
         *     param covs0 The vector of initial covariance matrices \(S_k\) of mixture components. Each of
         *         covariance matrices is a one-channel matrix of \(dims \times dims\) size. If the matrices
         *         do not have CV_64F type they will be converted to the inner matrices of such type for the
         *         further computing.
         *     param weights0 Initial weights \(\pi_k\) of mixture components. It should be a one-channel
         *         floating-point matrix with \(1 \times nclusters\) or \(nclusters \times 1\) size.
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();

            return ml_EM_trainE_13(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. You need to provide initial means \(a_k\) of
         *     mixture components. Optionally you can pass initial weights \(\pi_k\) and covariance matrices
         *     \(S_k\) of mixture components.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param means0 Initial means \(a_k\) of mixture components. It is a one-channel matrix of
         *         \(nclusters \times dims\) size. If the matrix does not have CV_64F type it will be
         *         converted to the inner matrix of such type for the further computing.
         *     param covs0 The vector of initial covariance matrices \(S_k\) of mixture components. Each of
         *         covariance matrices is a one-channel matrix of \(dims \times dims\) size. If the matrices
         *         do not have CV_64F type they will be converted to the inner matrices of such type for the
         *         further computing.
         *         floating-point matrix with \(1 \times nclusters\) or \(nclusters \times 1\) size.
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainE(Mat samples, Mat means0, Mat covs0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();

            return ml_EM_trainE_14(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Expectation step. You need to provide initial means \(a_k\) of
         *     mixture components. Optionally you can pass initial weights \(\pi_k\) and covariance matrices
         *     \(S_k\) of mixture components.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param means0 Initial means \(a_k\) of mixture components. It is a one-channel matrix of
         *         \(nclusters \times dims\) size. If the matrix does not have CV_64F type it will be
         *         converted to the inner matrix of such type for the further computing.
         *         covariance matrices is a one-channel matrix of \(dims \times dims\) size. If the matrices
         *         do not have CV_64F type they will be converted to the inner matrices of such type for the
         *         further computing.
         *         floating-point matrix with \(1 \times nclusters\) or \(nclusters \times 1\) size.
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainE(Mat samples, Mat means0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();

            return ml_EM_trainE_15(nativeObj, samples.nativeObj, means0.nativeObj);


        }


        //
        // C++:  bool cv::ml::EM::trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Maximization step. You need to provide initial probabilities
         *     \(p_{i,k}\) to use this option.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param probs0 the probabilities
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *     param labels The optional output "class label" for each sample:
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *     param probs The optional output matrix that contains posterior probabilities of each Gaussian
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods, Mat labels, Mat probs)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();

            return ml_EM_trainM_10(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Maximization step. You need to provide initial probabilities
         *     \(p_{i,k}\) to use this option.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param probs0 the probabilities
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *     param labels The optional output "class label" for each sample:
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods, Mat labels)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();

            return ml_EM_trainM_11(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Maximization step. You need to provide initial probabilities
         *     \(p_{i,k}\) to use this option.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param probs0 the probabilities
         *     param logLikelihoods The optional output matrix that contains a likelihood logarithm value for
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();

            return ml_EM_trainM_12(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj);


        }

        /**
         * Estimate the Gaussian mixture parameters from a samples set.
         *
         *     This variation starts with Maximization step. You need to provide initial probabilities
         *     \(p_{i,k}\) to use this option.
         *
         *     param samples Samples from which the Gaussian mixture model will be estimated. It should be a
         *         one-channel matrix, each row of which is a sample. If the matrix does not have CV_64F type
         *         it will be converted to the inner matrix of such type for the further computing.
         *     param probs0 the probabilities
         *         each sample. It has \(nsamples \times 1\) size and CV_64FC1 type.
         *         \(\texttt{labels}_i=\texttt{arg max}_k(p_{i,k}), i=1..N\) (indices of the most probable
         *         mixture component for each sample). It has \(nsamples \times 1\) size and CV_32SC1 type.
         *         mixture component given the each sample. It has \(nsamples \times nclusters\) size and
         *         CV_64FC1 type.
         * return automatically generated
         */
        public bool trainM(Mat samples, Mat probs0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();

            return ml_EM_trainM_13(nativeObj, samples.nativeObj, probs0.nativeObj);


        }


        //
        // C++: static Ptr_EM cv::ml::EM::create()
        //

        /**
         * Creates empty %EM model.
         *     The model should be trained then using StatModel::train(traindata, flags) method. Alternatively, you
         *     can use one of the EM::train\* methods or load it from file using Algorithm::load&lt;EM&gt;(filename).
         * return automatically generated
         */
        public static EM create()
        {


            return EM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_EM_create_10()));


        }


        //
        // C++: static Ptr_EM cv::ml::EM::load(String filepath, String nodeName = String())
        //

        /**
         * Loads and creates a serialized EM from a file
         *
         * Use EM::save to serialize and store an EM to disk.
         * Load the EM from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized EM
         * param nodeName name of node containing the classifier
         * return automatically generated
         */
        public static EM load(string filepath, string nodeName)
        {


            return EM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_EM_load_10(filepath, nodeName)));


        }

        /**
         * Loads and creates a serialized EM from a file
         *
         * Use EM::save to serialize and store an EM to disk.
         * Load the EM from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized EM
         * return automatically generated
         */
        public static EM load(string filepath)
        {


            return EM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_EM_load_11(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ml::EM::getClustersNumber()
        [DllImport(LIBNAME)]
        private static extern int ml_EM_getClustersNumber_10(IntPtr nativeObj);

        // C++:  void cv::ml::EM::setClustersNumber(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_setClustersNumber_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::EM::getCovarianceMatrixType()
        [DllImport(LIBNAME)]
        private static extern int ml_EM_getCovarianceMatrixType_10(IntPtr nativeObj);

        // C++:  void cv::ml::EM::setCovarianceMatrixType(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_setCovarianceMatrixType_10(IntPtr nativeObj, int val);

        // C++:  TermCriteria cv::ml::EM::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void ml_EM_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::ml::EM::setTermCriteria(TermCriteria val)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_setTermCriteria_10(IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // C++:  Mat cv::ml::EM::getWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_getWeights_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::EM::getMeans()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_getMeans_10(IntPtr nativeObj);

        // C++:  void cv::ml::EM::getCovs(vector_Mat& covs)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_getCovs_10(IntPtr nativeObj, IntPtr covs_mat_nativeObj);

        // C++:  float cv::ml::EM::predict(Mat samples, Mat& results = Mat(), int flags = 0)
        [DllImport(LIBNAME)]
        private static extern float ml_EM_predict_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern float ml_EM_predict_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_EM_predict_12(IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  Vec2d cv::ml::EM::predict2(Mat sample, Mat& probs)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_predict2_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr probs_nativeObj, double[] retVal);

        // C++:  bool cv::ml::EM::trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_12(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_13(IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  bool cv::ml::EM::trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_12(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_13(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_14(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_15(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj);

        // C++:  bool cv::ml::EM::trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_12(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_13(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj);

        // C++: static Ptr_EM cv::ml::EM::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_create_10();

        // C++: static Ptr_EM cv::ml::EM::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_load_11(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_EM_delete(IntPtr nativeObj);

    }
}
