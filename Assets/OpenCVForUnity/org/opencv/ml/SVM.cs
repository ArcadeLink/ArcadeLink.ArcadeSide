
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class SVM
    /**
     * Support Vector Machines.
     *
     * SEE: REF: ml_intro_svm
     */

    public class SVM : StatModel
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
                        ml_SVM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SVM(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SVM __fromPtr__(IntPtr addr) { return new SVM(addr); }

        // C++: enum cv.ml.SVM.KernelTypes
        public const int CUSTOM = -1;
        public const int LINEAR = 0;
        public const int POLY = 1;
        public const int RBF = 2;
        public const int SIGMOID = 3;
        public const int CHI2 = 4;
        public const int INTER = 5;
        // C++: enum cv.ml.SVM.ParamTypes
        public const int C = 0;
        public const int GAMMA = 1;
        public const int P = 2;
        public const int NU = 3;
        public const int COEF = 4;
        public const int DEGREE = 5;
        // C++: enum cv.ml.SVM.Types
        public const int C_SVC = 100;
        public const int NU_SVC = 101;
        public const int ONE_CLASS = 102;
        public const int EPS_SVR = 103;
        public const int NU_SVR = 104;
        //
        // C++:  int cv::ml::SVM::getType()
        //

        /**
         * SEE: setType
         * return automatically generated
         */
        public int getType()
        {
            ThrowIfDisposed();

            return ml_SVM_getType_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setType(int val)
        //

        /**
         *  getType SEE: getType
         * param val automatically generated
         */
        public void setType(int val)
        {
            ThrowIfDisposed();

            ml_SVM_setType_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::SVM::getGamma()
        //

        /**
         * SEE: setGamma
         * return automatically generated
         */
        public double getGamma()
        {
            ThrowIfDisposed();

            return ml_SVM_getGamma_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setGamma(double val)
        //

        /**
         *  getGamma SEE: getGamma
         * param val automatically generated
         */
        public void setGamma(double val)
        {
            ThrowIfDisposed();

            ml_SVM_setGamma_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::SVM::getCoef0()
        //

        /**
         * SEE: setCoef0
         * return automatically generated
         */
        public double getCoef0()
        {
            ThrowIfDisposed();

            return ml_SVM_getCoef0_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setCoef0(double val)
        //

        /**
         *  getCoef0 SEE: getCoef0
         * param val automatically generated
         */
        public void setCoef0(double val)
        {
            ThrowIfDisposed();

            ml_SVM_setCoef0_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::SVM::getDegree()
        //

        /**
         * SEE: setDegree
         * return automatically generated
         */
        public double getDegree()
        {
            ThrowIfDisposed();

            return ml_SVM_getDegree_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setDegree(double val)
        //

        /**
         *  getDegree SEE: getDegree
         * param val automatically generated
         */
        public void setDegree(double val)
        {
            ThrowIfDisposed();

            ml_SVM_setDegree_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::SVM::getC()
        //

        /**
         * SEE: setC
         * return automatically generated
         */
        public double getC()
        {
            ThrowIfDisposed();

            return ml_SVM_getC_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setC(double val)
        //

        /**
         *  getC SEE: getC
         * param val automatically generated
         */
        public void setC(double val)
        {
            ThrowIfDisposed();

            ml_SVM_setC_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::SVM::getNu()
        //

        /**
         * SEE: setNu
         * return automatically generated
         */
        public double getNu()
        {
            ThrowIfDisposed();

            return ml_SVM_getNu_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setNu(double val)
        //

        /**
         *  getNu SEE: getNu
         * param val automatically generated
         */
        public void setNu(double val)
        {
            ThrowIfDisposed();

            ml_SVM_setNu_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::SVM::getP()
        //

        /**
         * SEE: setP
         * return automatically generated
         */
        public double getP()
        {
            ThrowIfDisposed();

            return ml_SVM_getP_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setP(double val)
        //

        /**
         *  getP SEE: getP
         * param val automatically generated
         */
        public void setP(double val)
        {
            ThrowIfDisposed();

            ml_SVM_setP_10(nativeObj, val);


        }


        //
        // C++:  Mat cv::ml::SVM::getClassWeights()
        //

        /**
         * SEE: setClassWeights
         * return automatically generated
         */
        public Mat getClassWeights()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_SVM_getClassWeights_10(nativeObj)));


        }


        //
        // C++:  void cv::ml::SVM::setClassWeights(Mat val)
        //

        /**
         *  getClassWeights SEE: getClassWeights
         * param val automatically generated
         */
        public void setClassWeights(Mat val)
        {
            ThrowIfDisposed();
            if (val != null) val.ThrowIfDisposed();

            ml_SVM_setClassWeights_10(nativeObj, val.nativeObj);


        }


        //
        // C++:  TermCriteria cv::ml::SVM::getTermCriteria()
        //

        /**
         * SEE: setTermCriteria
         * return automatically generated
         */
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            ml_SVM_getTermCriteria_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::ml::SVM::setTermCriteria(TermCriteria val)
        //

        /**
         *  getTermCriteria SEE: getTermCriteria
         * param val automatically generated
         */
        public void setTermCriteria(TermCriteria val)
        {
            ThrowIfDisposed();

            ml_SVM_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);


        }


        //
        // C++:  int cv::ml::SVM::getKernelType()
        //

        /**
         * Type of a %SVM kernel.
         * See SVM::KernelTypes. Default value is SVM::RBF.
         * return automatically generated
         */
        public int getKernelType()
        {
            ThrowIfDisposed();

            return ml_SVM_getKernelType_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVM::setKernel(int kernelType)
        //

        /**
         * Initialize with one of predefined kernels.
         * See SVM::KernelTypes.
         * param kernelType automatically generated
         */
        public void setKernel(int kernelType)
        {
            ThrowIfDisposed();

            ml_SVM_setKernel_10(nativeObj, kernelType);


        }


        //
        // C++:  bool cv::ml::SVM::trainAuto(Mat samples, int layout, Mat responses, int kFold = 10, Ptr_ParamGrid Cgrid = SVM::getDefaultGridPtr(SVM::C), Ptr_ParamGrid gammaGrid = SVM::getDefaultGridPtr(SVM::GAMMA), Ptr_ParamGrid pGrid = SVM::getDefaultGridPtr(SVM::P), Ptr_ParamGrid nuGrid = SVM::getDefaultGridPtr(SVM::NU), Ptr_ParamGrid coeffGrid = SVM::getDefaultGridPtr(SVM::COEF), Ptr_ParamGrid degreeGrid = SVM::getDefaultGridPtr(SVM::DEGREE), bool balanced = false)
        //

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *     param gammaGrid grid for gamma
         *     param pGrid grid for p
         *     param nuGrid grid for nu
         *     param coeffGrid grid for coeff
         *     param degreeGrid grid for degree
         *     param balanced If true and the problem is 2-class classification then the method creates more
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid, ParamGrid coeffGrid, ParamGrid degreeGrid, bool balanced)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();
            if (gammaGrid != null) gammaGrid.ThrowIfDisposed();
            if (pGrid != null) pGrid.ThrowIfDisposed();
            if (nuGrid != null) nuGrid.ThrowIfDisposed();
            if (coeffGrid != null) coeffGrid.ThrowIfDisposed();
            if (degreeGrid != null) degreeGrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_10(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr(), gammaGrid.getNativeObjAddr(), pGrid.getNativeObjAddr(), nuGrid.getNativeObjAddr(), coeffGrid.getNativeObjAddr(), degreeGrid.getNativeObjAddr(), balanced);


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *     param gammaGrid grid for gamma
         *     param pGrid grid for p
         *     param nuGrid grid for nu
         *     param coeffGrid grid for coeff
         *     param degreeGrid grid for degree
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid, ParamGrid coeffGrid, ParamGrid degreeGrid)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();
            if (gammaGrid != null) gammaGrid.ThrowIfDisposed();
            if (pGrid != null) pGrid.ThrowIfDisposed();
            if (nuGrid != null) nuGrid.ThrowIfDisposed();
            if (coeffGrid != null) coeffGrid.ThrowIfDisposed();
            if (degreeGrid != null) degreeGrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_11(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr(), gammaGrid.getNativeObjAddr(), pGrid.getNativeObjAddr(), nuGrid.getNativeObjAddr(), coeffGrid.getNativeObjAddr(), degreeGrid.getNativeObjAddr());


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *     param gammaGrid grid for gamma
         *     param pGrid grid for p
         *     param nuGrid grid for nu
         *     param coeffGrid grid for coeff
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid, ParamGrid coeffGrid)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();
            if (gammaGrid != null) gammaGrid.ThrowIfDisposed();
            if (pGrid != null) pGrid.ThrowIfDisposed();
            if (nuGrid != null) nuGrid.ThrowIfDisposed();
            if (coeffGrid != null) coeffGrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_12(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr(), gammaGrid.getNativeObjAddr(), pGrid.getNativeObjAddr(), nuGrid.getNativeObjAddr(), coeffGrid.getNativeObjAddr());


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *     param gammaGrid grid for gamma
         *     param pGrid grid for p
         *     param nuGrid grid for nu
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid, ParamGrid nuGrid)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();
            if (gammaGrid != null) gammaGrid.ThrowIfDisposed();
            if (pGrid != null) pGrid.ThrowIfDisposed();
            if (nuGrid != null) nuGrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_13(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr(), gammaGrid.getNativeObjAddr(), pGrid.getNativeObjAddr(), nuGrid.getNativeObjAddr());


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *     param gammaGrid grid for gamma
         *     param pGrid grid for p
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid, ParamGrid pGrid)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();
            if (gammaGrid != null) gammaGrid.ThrowIfDisposed();
            if (pGrid != null) pGrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_14(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr(), gammaGrid.getNativeObjAddr(), pGrid.getNativeObjAddr());


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *     param gammaGrid grid for gamma
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid, ParamGrid gammaGrid)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();
            if (gammaGrid != null) gammaGrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_15(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr(), gammaGrid.getNativeObjAddr());


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *     param Cgrid grid for C
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold, ParamGrid Cgrid)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (Cgrid != null) Cgrid.ThrowIfDisposed();

            return ml_SVM_trainAuto_16(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold, Cgrid.getNativeObjAddr());


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *     param kFold Cross-validation parameter. The training set is divided into kFold subsets. One
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses, int kFold)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();

            return ml_SVM_trainAuto_17(nativeObj, samples.nativeObj, layout, responses.nativeObj, kFold);


        }

        /**
         * Trains an %SVM with optimal parameters
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         *         subset is used to test the model, the others form the train set. So, the %SVM algorithm is
         *         balanced cross-validation subsets that is proportions between classes in subsets are close
         *         to such proportion in the whole train dataset.
         *
         *     The method trains the %SVM model automatically by choosing the optimal parameters C, gamma, p,
         *     nu, coef0, degree. Parameters are considered optimal when the cross-validation
         *     estimate of the test set error is minimal.
         *
         *     This function only makes use of SVM::getDefaultGrid for parameter optimization and thus only
         *     offers rudimentary parameter options.
         *
         *     This function works for the classification (SVM::C_SVC or SVM::NU_SVC) as well as for the
         *     regression (SVM::EPS_SVR or SVM::NU_SVR). If it is SVM::ONE_CLASS, no optimization is made and
         *     the usual %SVM with parameters specified in params is executed.
         * return automatically generated
         */
        public bool trainAuto(Mat samples, int layout, Mat responses)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();

            return ml_SVM_trainAuto_18(nativeObj, samples.nativeObj, layout, responses.nativeObj);


        }


        //
        // C++:  Mat cv::ml::SVM::getSupportVectors()
        //

        /**
         * Retrieves all the support vectors
         *
         *     The method returns all the support vectors as a floating-point matrix, where support vectors are
         *     stored as matrix rows.
         * return automatically generated
         */
        public Mat getSupportVectors()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_SVM_getSupportVectors_10(nativeObj)));


        }


        //
        // C++:  Mat cv::ml::SVM::getUncompressedSupportVectors()
        //

        /**
         * Retrieves all the uncompressed support vectors of a linear %SVM
         *
         *     The method returns all the uncompressed support vectors of a linear %SVM that the compressed
         *     support vector, used for prediction, was derived from. They are returned in a floating-point
         *     matrix, where the support vectors are stored as matrix rows.
         * return automatically generated
         */
        public Mat getUncompressedSupportVectors()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_SVM_getUncompressedSupportVectors_10(nativeObj)));


        }


        //
        // C++:  double cv::ml::SVM::getDecisionFunction(int i, Mat& alpha, Mat& svidx)
        //

        /**
         * Retrieves the decision function
         *
         *     param i the index of the decision function. If the problem solved is regression, 1-class or
         *         2-class classification, then there will be just one decision function and the index should
         *         always be 0. Otherwise, in the case of N-class classification, there will be \(N(N-1)/2\)
         *         decision functions.
         *     param alpha the optional output vector for weights, corresponding to different support vectors.
         *         In the case of linear %SVM all the alpha's will be 1's.
         *     param svidx the optional output vector of indices of support vectors within the matrix of
         *         support vectors (which can be retrieved by SVM::getSupportVectors). In the case of linear
         *         %SVM each decision function consists of a single "compressed" support vector.
         *
         *     The method returns rho parameter of the decision function, a scalar subtracted from the weighted
         *     sum of kernel responses.
         * return automatically generated
         */
        public double getDecisionFunction(int i, Mat alpha, Mat svidx)
        {
            ThrowIfDisposed();
            if (alpha != null) alpha.ThrowIfDisposed();
            if (svidx != null) svidx.ThrowIfDisposed();

            return ml_SVM_getDecisionFunction_10(nativeObj, i, alpha.nativeObj, svidx.nativeObj);


        }


        //
        // C++: static Ptr_ParamGrid cv::ml::SVM::getDefaultGridPtr(int param_id)
        //

        /**
         * Generates a grid for %SVM parameters.
         *
         *     param param_id %SVM parameters IDs that must be one of the SVM::ParamTypes. The grid is
         *     generated for the parameter with this ID.
         *
         *     The function generates a grid pointer for the specified parameter of the %SVM algorithm.
         *     The grid may be passed to the function SVM::trainAuto.
         * return automatically generated
         */
        public static ParamGrid getDefaultGridPtr(int param_id)
        {


            return ParamGrid.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_SVM_getDefaultGridPtr_10(param_id)));


        }


        //
        // C++: static Ptr_SVM cv::ml::SVM::create()
        //

        /**
         * Creates empty model.
         *     Use StatModel::train to train the model. Since %SVM has several parameters, you may want to
         * find the best parameters for your problem, it can be done with SVM::trainAuto.
         * return automatically generated
         */
        public static SVM create()
        {


            return SVM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_SVM_create_10()));


        }


        //
        // C++: static Ptr_SVM cv::ml::SVM::load(String filepath)
        //

        /**
         * Loads and creates a serialized svm from a file
         *
         * Use SVM::save to serialize and store an SVM to disk.
         * Load the SVM from this file again, by calling this function with the path to the file.
         *
         * param filepath path to serialized svm
         * return automatically generated
         */
        public static SVM load(string filepath)
        {


            return SVM.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_SVM_load_10(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ml::SVM::getType()
        [DllImport(LIBNAME)]
        private static extern int ml_SVM_getType_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setType(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setType_10(IntPtr nativeObj, int val);

        // C++:  double cv::ml::SVM::getGamma()
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getGamma_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setGamma(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setGamma_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::SVM::getCoef0()
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getCoef0_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setCoef0(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setCoef0_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::SVM::getDegree()
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getDegree_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setDegree(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setDegree_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::SVM::getC()
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getC_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setC(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setC_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::SVM::getNu()
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getNu_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setNu(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setNu_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::SVM::getP()
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getP_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setP(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setP_10(IntPtr nativeObj, double val);

        // C++:  Mat cv::ml::SVM::getClassWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVM_getClassWeights_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setClassWeights(Mat val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setClassWeights_10(IntPtr nativeObj, IntPtr val_nativeObj);

        // C++:  TermCriteria cv::ml::SVM::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::ml::SVM::setTermCriteria(TermCriteria val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setTermCriteria_10(IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // C++:  int cv::ml::SVM::getKernelType()
        [DllImport(LIBNAME)]
        private static extern int ml_SVM_getKernelType_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVM::setKernel(int kernelType)
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_setKernel_10(IntPtr nativeObj, int kernelType);

        // C++:  bool cv::ml::SVM::trainAuto(Mat samples, int layout, Mat responses, int kFold = 10, Ptr_ParamGrid Cgrid = SVM::getDefaultGridPtr(SVM::C), Ptr_ParamGrid gammaGrid = SVM::getDefaultGridPtr(SVM::GAMMA), Ptr_ParamGrid pGrid = SVM::getDefaultGridPtr(SVM::P), Ptr_ParamGrid nuGrid = SVM::getDefaultGridPtr(SVM::NU), Ptr_ParamGrid coeffGrid = SVM::getDefaultGridPtr(SVM::COEF), Ptr_ParamGrid degreeGrid = SVM::getDefaultGridPtr(SVM::DEGREE), bool balanced = false)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_10(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj, IntPtr coeffGrid_nativeObj, IntPtr degreeGrid_nativeObj, [MarshalAs(UnmanagedType.U1)] bool balanced);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_11(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj, IntPtr coeffGrid_nativeObj, IntPtr degreeGrid_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_12(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj, IntPtr coeffGrid_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_13(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_14(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_15(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_16(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold, IntPtr Cgrid_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_17(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, int kFold);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_SVM_trainAuto_18(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj);

        // C++:  Mat cv::ml::SVM::getSupportVectors()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVM_getSupportVectors_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::SVM::getUncompressedSupportVectors()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVM_getUncompressedSupportVectors_10(IntPtr nativeObj);

        // C++:  double cv::ml::SVM::getDecisionFunction(int i, Mat& alpha, Mat& svidx)
        [DllImport(LIBNAME)]
        private static extern double ml_SVM_getDecisionFunction_10(IntPtr nativeObj, int i, IntPtr alpha_nativeObj, IntPtr svidx_nativeObj);

        // C++: static Ptr_ParamGrid cv::ml::SVM::getDefaultGridPtr(int param_id)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVM_getDefaultGridPtr_10(int param_id);

        // C++: static Ptr_SVM cv::ml::SVM::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVM_create_10();

        // C++: static Ptr_SVM cv::ml::SVM::load(String filepath)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVM_load_10(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_SVM_delete(IntPtr nativeObj);

    }
}
