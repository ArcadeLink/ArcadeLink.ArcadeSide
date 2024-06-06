
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class TrackerGOTURN
    /**
     * the GOTURN (Generic Object Tracking Using Regression Networks) tracker
     *
     * GOTURN (CITE: GOTURN) is kind of trackers based on Convolutional Neural Networks (CNN). While taking all advantages of CNN trackers,
     * GOTURN is much faster due to offline training without online fine-tuning nature.
     * GOTURN tracker addresses the problem of single target tracking: given a bounding box label of an object in the first frame of the video,
     * we track that object through the rest of the video. NOTE: Current method of GOTURN does not handle occlusions; however, it is fairly
     * robust to viewpoint changes, lighting changes, and deformations.
     * Inputs of GOTURN are two RGB patches representing Target and Search patches resized to 227x227.
     * Outputs of GOTURN are predicted bounding box coordinates, relative to Search patch coordinate system, in format X1,Y1,X2,Y2.
     * Original paper is here: &lt;http://davheld.github.io/GOTURN/GOTURN.pdf&gt;
     * As long as original authors implementation: &lt;https://github.com/davheld/GOTURN#train-the-tracker&gt;
     * Implementation of training algorithm is placed in separately here due to 3d-party dependencies:
     * &lt;https://github.com/Auron-X/GOTURN_Training_Toolkit&gt;
     * GOTURN architecture goturn.prototxt and trained model goturn.caffemodel are accessible on opencv_extra GitHub repository.
     */

    public class TrackerGOTURN : Tracker
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
                        video_TrackerGOTURN_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerGOTURN(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerGOTURN __fromPtr__(IntPtr addr) { return new TrackerGOTURN(addr); }

        //
        // C++: static Ptr_TrackerGOTURN cv::TrackerGOTURN::create(TrackerGOTURN_Params parameters = TrackerGOTURN::Params())
        //

        /**
         * Constructor
         *     param parameters GOTURN parameters TrackerGOTURN::Params
         * return automatically generated
         */
        public static TrackerGOTURN create(TrackerGOTURN_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return TrackerGOTURN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerGOTURN_create_10(parameters.nativeObj)));


        }

        /**
         * Constructor
         * return automatically generated
         */
        public static TrackerGOTURN create()
        {


            return TrackerGOTURN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerGOTURN_create_11()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TrackerGOTURN cv::TrackerGOTURN::create(TrackerGOTURN_Params parameters = TrackerGOTURN::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerGOTURN_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerGOTURN_create_11();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerGOTURN_delete(IntPtr nativeObj);

    }
}
