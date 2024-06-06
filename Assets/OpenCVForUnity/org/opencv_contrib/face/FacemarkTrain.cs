
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class FacemarkTrain
    /**
     * Abstract base class for trainable facemark models
     *
     * To utilize this API in your program, please take a look at the REF: tutorial_table_of_content_facemark
     * ### Description
     *
     * The AAM and LBF facemark models in OpenCV are derived from the abstract base class FacemarkTrain, which
     * provides a unified access to those facemark algorithms in OpenCV.
     *
     * Here is an example on how to declare facemark algorithm:
     * <code>
     * // Using Facemark in your code:
     * Ptr&lt;Facemark&gt; facemark = FacemarkLBF::create();
     * </code>
     *
     *
     * The typical pipeline for facemark detection is listed as follows:
     * <ul>
     *   <li>
     *  (Non-mandatory) Set a user defined face detection using FacemarkTrain::setFaceDetector.
     *   The facemark algorithms are designed to fit the facial points into a face.
     *   Therefore, the face information should be provided to the facemark algorithm.
     *   Some algorithms might provides a default face recognition function.
     *   However, the users might prefer to use their own face detector to obtains the best possible detection result.
     *   </li>
     *   <li>
     *  (Non-mandatory) Training the model for a specific algorithm using FacemarkTrain::training.
     *   In this case, the model should be automatically saved by the algorithm.
     *   If the user already have a trained model, then this part can be omitted.
     *   </li>
     *   <li>
     *  Load the trained model using Facemark::loadModel.
     *   </li>
     *   <li>
     *  Perform the fitting via the Facemark::fit.
     *   </li>
     * </ul>
     */

    public class FacemarkTrain : Facemark
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
                        face_FacemarkTrain_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FacemarkTrain(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FacemarkTrain __fromPtr__(IntPtr addr) { return new FacemarkTrain(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_FacemarkTrain_delete(IntPtr nativeObj);

    }
}
