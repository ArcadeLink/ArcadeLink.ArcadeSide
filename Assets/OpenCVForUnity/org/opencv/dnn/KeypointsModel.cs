#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class KeypointsModel
    /**
     * This class represents high-level API for keypoints models
     *
     * KeypointsModel allows to set params for preprocessing input image.
     * KeypointsModel creates net from file with trained weights and config,
     * sets preprocessing input, runs forward pass and returns the x and y coordinates of each detected keypoint
     */

    public class KeypointsModel : Model
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
                        dnn_KeypointsModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal KeypointsModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new KeypointsModel __fromPtr__(IntPtr addr) { return new KeypointsModel(addr); }

        //
        // C++:   cv::dnn::KeypointsModel::KeypointsModel(String model, String config = "")
        //

        /**
         * Create keypoints model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         * param config Text file contains network configuration.
         */
        public KeypointsModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_KeypointsModel_KeypointsModel_10(model, config)))
        {



        }

        /**
         * Create keypoints model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         */
        public KeypointsModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_KeypointsModel_KeypointsModel_11(model)))
        {



        }


        //
        // C++:   cv::dnn::KeypointsModel::KeypointsModel(Net network)
        //

        /**
         * Create model from deep learning network.
         * param network Net object.
         */
        public KeypointsModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_KeypointsModel_KeypointsModel_12(network.nativeObj)))
        {



        }


        //
        // C++:  vector_Point2f cv::dnn::KeypointsModel::estimate(Mat frame, float thresh = 0.5)
        //

        /**
         * Given the {code input} frame, create input blob, run net
         * param thresh minimum confidence threshold to select a keypoint
         * return a vector holding the x and y coordinates of each detected keypoint
         *
         * param frame automatically generated
         */
        public MatOfPoint2f estimate(Mat frame, float thresh)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();

            return MatOfPoint2f.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(dnn_KeypointsModel_estimate_10(nativeObj, frame.nativeObj, thresh)));


        }

        /**
         * Given the {code input} frame, create input blob, run net
         * return a vector holding the x and y coordinates of each detected keypoint
         *
         * param frame automatically generated
         */
        public MatOfPoint2f estimate(Mat frame)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();

            return MatOfPoint2f.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(dnn_KeypointsModel_estimate_11(nativeObj, frame.nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::KeypointsModel::KeypointsModel(String model, String config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_KeypointsModel_KeypointsModel_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_KeypointsModel_KeypointsModel_11(string model);

        // C++:   cv::dnn::KeypointsModel::KeypointsModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_KeypointsModel_KeypointsModel_12(IntPtr network_nativeObj);

        // C++:  vector_Point2f cv::dnn::KeypointsModel::estimate(Mat frame, float thresh = 0.5)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_KeypointsModel_estimate_10(IntPtr nativeObj, IntPtr frame_nativeObj, float thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_KeypointsModel_estimate_11(IntPtr nativeObj, IntPtr frame_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_KeypointsModel_delete(IntPtr nativeObj);

    }
}

#endif