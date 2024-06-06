
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class EigenFaceRecognizer


    public class EigenFaceRecognizer : BasicFaceRecognizer
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
                        face_EigenFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EigenFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EigenFaceRecognizer __fromPtr__(IntPtr addr) { return new EigenFaceRecognizer(addr); }

        //
        // C++: static Ptr_EigenFaceRecognizer cv::face::EigenFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        //

        /**
         * param num_components The number of components (read: Eigenfaces) kept for this Principal
         *     Component Analysis. As a hint: There's no rule how many components (read: Eigenfaces) should be
         *     kept for good reconstruction capabilities. It is based on your input data, so experiment with the
         *     number. Keeping 80 components should almost always be sufficient.
         *     param threshold The threshold applied in the prediction.
         *
         *     ### Notes:
         *
         * <ul>
         *   <li>
         *        Training and prediction must be done on grayscale images, use cvtColor to convert between the
         *         color spaces.
         *   </li>
         *   <li>
         *        <b>THE EIGENFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
         *         SIZE.</b> (caps-lock, because I got so many mails asking for this). You have to make sure your
         *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
         *         the images.
         *   </li>
         *   <li>
         *        This model does not support updating.
         *   </li>
         * </ul>
         *
         *     ### Model internal data:
         *
         * <ul>
         *   <li>
         *        num_components see EigenFaceRecognizer::create.
         *   </li>
         *   <li>
         *        threshold see EigenFaceRecognizer::create.
         *   </li>
         *   <li>
         *        eigenvalues The eigenvalues for this Principal Component Analysis (ordered descending).
         *   </li>
         *   <li>
         *        eigenvectors The eigenvectors for this Principal Component Analysis (ordered by their
         *         eigenvalue).
         *   </li>
         *   <li>
         *        mean The sample mean calculated from the training data.
         *   </li>
         *   <li>
         *        projections The projections of the training data.
         *   </li>
         *   <li>
         *        labels The threshold applied in the prediction. If the distance to the nearest neighbor is
         *         larger than the threshold, this method returns -1.
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static EigenFaceRecognizer create(int num_components, double threshold)
        {


            return EigenFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_EigenFaceRecognizer_create_10(num_components, threshold)));


        }

        /**
         * param num_components The number of components (read: Eigenfaces) kept for this Principal
         *     Component Analysis. As a hint: There's no rule how many components (read: Eigenfaces) should be
         *     kept for good reconstruction capabilities. It is based on your input data, so experiment with the
         *     number. Keeping 80 components should almost always be sufficient.
         *
         *     ### Notes:
         *
         * <ul>
         *   <li>
         *        Training and prediction must be done on grayscale images, use cvtColor to convert between the
         *         color spaces.
         *   </li>
         *   <li>
         *        <b>THE EIGENFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
         *         SIZE.</b> (caps-lock, because I got so many mails asking for this). You have to make sure your
         *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
         *         the images.
         *   </li>
         *   <li>
         *        This model does not support updating.
         *   </li>
         * </ul>
         *
         *     ### Model internal data:
         *
         * <ul>
         *   <li>
         *        num_components see EigenFaceRecognizer::create.
         *   </li>
         *   <li>
         *        threshold see EigenFaceRecognizer::create.
         *   </li>
         *   <li>
         *        eigenvalues The eigenvalues for this Principal Component Analysis (ordered descending).
         *   </li>
         *   <li>
         *        eigenvectors The eigenvectors for this Principal Component Analysis (ordered by their
         *         eigenvalue).
         *   </li>
         *   <li>
         *        mean The sample mean calculated from the training data.
         *   </li>
         *   <li>
         *        projections The projections of the training data.
         *   </li>
         *   <li>
         *        labels The threshold applied in the prediction. If the distance to the nearest neighbor is
         *         larger than the threshold, this method returns -1.
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static EigenFaceRecognizer create(int num_components)
        {


            return EigenFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_EigenFaceRecognizer_create_11(num_components)));


        }

        /**
         *     Component Analysis. As a hint: There's no rule how many components (read: Eigenfaces) should be
         *     kept for good reconstruction capabilities. It is based on your input data, so experiment with the
         *     number. Keeping 80 components should almost always be sufficient.
         *
         *     ### Notes:
         *
         * <ul>
         *   <li>
         *        Training and prediction must be done on grayscale images, use cvtColor to convert between the
         *         color spaces.
         *   </li>
         *   <li>
         *        <b>THE EIGENFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
         *         SIZE.</b> (caps-lock, because I got so many mails asking for this). You have to make sure your
         *         input data has the correct shape, else a meaningful exception is thrown. Use resize to resize
         *         the images.
         *   </li>
         *   <li>
         *        This model does not support updating.
         *   </li>
         * </ul>
         *
         *     ### Model internal data:
         *
         * <ul>
         *   <li>
         *        num_components see EigenFaceRecognizer::create.
         *   </li>
         *   <li>
         *        threshold see EigenFaceRecognizer::create.
         *   </li>
         *   <li>
         *        eigenvalues The eigenvalues for this Principal Component Analysis (ordered descending).
         *   </li>
         *   <li>
         *        eigenvectors The eigenvectors for this Principal Component Analysis (ordered by their
         *         eigenvalue).
         *   </li>
         *   <li>
         *        mean The sample mean calculated from the training data.
         *   </li>
         *   <li>
         *        projections The projections of the training data.
         *   </li>
         *   <li>
         *        labels The threshold applied in the prediction. If the distance to the nearest neighbor is
         *         larger than the threshold, this method returns -1.
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static EigenFaceRecognizer create()
        {


            return EigenFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_EigenFaceRecognizer_create_12()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_EigenFaceRecognizer cv::face::EigenFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_10(int num_components, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_11(int num_components);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_EigenFaceRecognizer_delete(IntPtr nativeObj);

    }
}
