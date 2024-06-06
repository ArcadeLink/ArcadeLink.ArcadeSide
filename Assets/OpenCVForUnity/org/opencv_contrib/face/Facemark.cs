
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class Facemark
    /**
     * Abstract base class for all facemark models
     *
     * To utilize this API in your program, please take a look at the REF: tutorial_table_of_content_facemark
     * ### Description
     *
     * Facemark is a base class which provides universal access to any specific facemark algorithm.
     * Therefore, the users should declare a desired algorithm before they can use it in their application.
     *
     * Here is an example on how to declare a facemark algorithm:
     * <code>
     * // Using Facemark in your code:
     * Ptr&lt;Facemark&gt; facemark = createFacemarkLBF();
     * </code>
     *
     * The typical pipeline for facemark detection is as follows:
     * <ul>
     *   <li>
     *  Load the trained model using Facemark::loadModel.
     *   </li>
     *   <li>
     *  Perform the fitting on an image via Facemark::fit.
     *   </li>
     * </ul>
     */

    public class Facemark : Algorithm
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
                        face_Facemark_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Facemark(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Facemark __fromPtr__(IntPtr addr) { return new Facemark(addr); }

        //
        // C++:  void cv::face::Facemark::loadModel(String model)
        //

        /**
         * A function to load the trained model before the fitting process.
         *     param model A string represent the filename of a trained model.
         *
         *     &lt;B&gt;Example of usage&lt;/B&gt;
         *     <code>
         *     facemark-&gt;loadModel("../data/lbf.model");
         *     </code>
         */
        public void loadModel(string model)
        {
            ThrowIfDisposed();

            face_Facemark_loadModel_10(nativeObj, model);


        }


        //
        // C++:  bool cv::face::Facemark::fit(Mat image, vector_Rect faces, vector_vector_Point2f& landmarks)
        //

        /**
         * Detect facial landmarks from an image.
         *     param image Input image.
         *     param faces Output of the function which represent region of interest of the detected faces.
         *     Each face is stored in cv::Rect container.
         *     param landmarks The detected landmark points for each faces.
         *
         *     &lt;B&gt;Example of usage&lt;/B&gt;
         *     <code>
         *     Mat image = imread("image.jpg");
         *     std::vector&lt;Rect&gt; faces;
         *     std::vector&lt;std::vector&lt;Point2f&gt; &gt; landmarks;
         *     facemark-&gt;fit(image, faces, landmarks);
         *     </code>
         * return automatically generated
         */
        public bool fit(Mat image, MatOfRect faces, List<MatOfPoint2f> landmarks)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (faces != null) faces.ThrowIfDisposed();
            Mat faces_mat = faces;
            Mat landmarks_mat = new Mat();
            bool retVal = face_Facemark_fit_10(nativeObj, image.nativeObj, faces_mat.nativeObj, landmarks_mat.nativeObj);
            Converters.Mat_to_vector_vector_Point2f(landmarks_mat, landmarks);
            landmarks_mat.release();
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::face::Facemark::loadModel(String model)
        [DllImport(LIBNAME)]
        private static extern void face_Facemark_loadModel_10(IntPtr nativeObj, string model);

        // C++:  bool cv::face::Facemark::fit(Mat image, vector_Rect faces, vector_vector_Point2f& landmarks)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Facemark_fit_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr faces_mat_nativeObj, IntPtr landmarks_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_Facemark_delete(IntPtr nativeObj);

    }
}
