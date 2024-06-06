
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class FisherFaceRecognizer


    public class FisherFaceRecognizer : BasicFaceRecognizer
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
                        face_FisherFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FisherFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FisherFaceRecognizer __fromPtr__(IntPtr addr) { return new FisherFaceRecognizer(addr); }

        //
        // C++: static Ptr_FisherFaceRecognizer cv::face::FisherFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        //

        /**
         * param num_components The number of components (read: Fisherfaces) kept for this Linear
         *     Discriminant Analysis with the Fisherfaces criterion. It's useful to keep all components, that
         *     means the number of your classes c (read: subjects, persons you want to recognize). If you leave
         *     this at the default (0) or set it to a value less-equal 0 or greater (c-1), it will be set to the
         *     correct number (c-1) automatically.
         *     param threshold The threshold applied in the prediction. If the distance to the nearest neighbor
         *     is larger than the threshold, this method returns -1.
         *
         *     ### Notes:
         *
         * <ul>
         *   <li>
         *        Training and prediction must be done on grayscale images, use cvtColor to convert between the
         *         color spaces.
         *   </li>
         *   <li>
         *        <b>THE FISHERFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
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
         *        num_components see FisherFaceRecognizer::create.
         *   </li>
         *   <li>
         *        threshold see FisherFaceRecognizer::create.
         *   </li>
         *   <li>
         *        eigenvalues The eigenvalues for this Linear Discriminant Analysis (ordered descending).
         *   </li>
         *   <li>
         *        eigenvectors The eigenvectors for this Linear Discriminant Analysis (ordered by their
         *         eigenvalue).
         *   </li>
         *   <li>
         *        mean The sample mean calculated from the training data.
         *   </li>
         *   <li>
         *        projections The projections of the training data.
         *   </li>
         *   <li>
         *        labels The labels corresponding to the projections.
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static FisherFaceRecognizer create(int num_components, double threshold)
        {


            return FisherFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_FisherFaceRecognizer_create_10(num_components, threshold)));


        }

        /**
         * param num_components The number of components (read: Fisherfaces) kept for this Linear
         *     Discriminant Analysis with the Fisherfaces criterion. It's useful to keep all components, that
         *     means the number of your classes c (read: subjects, persons you want to recognize). If you leave
         *     this at the default (0) or set it to a value less-equal 0 or greater (c-1), it will be set to the
         *     correct number (c-1) automatically.
         *     is larger than the threshold, this method returns -1.
         *
         *     ### Notes:
         *
         * <ul>
         *   <li>
         *        Training and prediction must be done on grayscale images, use cvtColor to convert between the
         *         color spaces.
         *   </li>
         *   <li>
         *        <b>THE FISHERFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
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
         *        num_components see FisherFaceRecognizer::create.
         *   </li>
         *   <li>
         *        threshold see FisherFaceRecognizer::create.
         *   </li>
         *   <li>
         *        eigenvalues The eigenvalues for this Linear Discriminant Analysis (ordered descending).
         *   </li>
         *   <li>
         *        eigenvectors The eigenvectors for this Linear Discriminant Analysis (ordered by their
         *         eigenvalue).
         *   </li>
         *   <li>
         *        mean The sample mean calculated from the training data.
         *   </li>
         *   <li>
         *        projections The projections of the training data.
         *   </li>
         *   <li>
         *        labels The labels corresponding to the projections.
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static FisherFaceRecognizer create(int num_components)
        {


            return FisherFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_FisherFaceRecognizer_create_11(num_components)));


        }

        /**
         *     Discriminant Analysis with the Fisherfaces criterion. It's useful to keep all components, that
         *     means the number of your classes c (read: subjects, persons you want to recognize). If you leave
         *     this at the default (0) or set it to a value less-equal 0 or greater (c-1), it will be set to the
         *     correct number (c-1) automatically.
         *     is larger than the threshold, this method returns -1.
         *
         *     ### Notes:
         *
         * <ul>
         *   <li>
         *        Training and prediction must be done on grayscale images, use cvtColor to convert between the
         *         color spaces.
         *   </li>
         *   <li>
         *        <b>THE FISHERFACES METHOD MAKES THE ASSUMPTION, THAT THE TRAINING AND TEST IMAGES ARE OF EQUAL
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
         *        num_components see FisherFaceRecognizer::create.
         *   </li>
         *   <li>
         *        threshold see FisherFaceRecognizer::create.
         *   </li>
         *   <li>
         *        eigenvalues The eigenvalues for this Linear Discriminant Analysis (ordered descending).
         *   </li>
         *   <li>
         *        eigenvectors The eigenvectors for this Linear Discriminant Analysis (ordered by their
         *         eigenvalue).
         *   </li>
         *   <li>
         *        mean The sample mean calculated from the training data.
         *   </li>
         *   <li>
         *        projections The projections of the training data.
         *   </li>
         *   <li>
         *        labels The labels corresponding to the projections.
         *   </li>
         * </ul>
         * return automatically generated
         */
        public static FisherFaceRecognizer create()
        {


            return FisherFaceRecognizer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_FisherFaceRecognizer_create_12()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_FisherFaceRecognizer cv::face::FisherFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_10(int num_components, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_11(int num_components);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_FisherFaceRecognizer_delete(IntPtr nativeObj);

    }
}
