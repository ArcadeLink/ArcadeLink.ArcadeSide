
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class SimpleBlobDetector
    /**
     * Class for extracting blobs from an image. :
     *
     * The class implements a simple algorithm for extracting blobs from an image:
     *
     * 1.  Convert the source image to binary images by applying thresholding with several thresholds from
     *     minThreshold (inclusive) to maxThreshold (exclusive) with distance thresholdStep between
     *     neighboring thresholds.
     * 2.  Extract connected components from every binary image by findContours and calculate their
     *     centers.
     * 3.  Group centers from several binary images by their coordinates. Close centers form one group that
     *     corresponds to one blob, which is controlled by the minDistBetweenBlobs parameter.
     * 4.  From the groups, estimate final centers of blobs and their radiuses and return as locations and
     *     sizes of keypoints.
     *
     * This class performs several filtrations of returned blobs. You should set filterBy\* to true/false
     * to turn on/off corresponding filtration. Available filtrations:
     *
     * <ul>
     *   <li>
     *    <b>By color</b>. This filter compares the intensity of a binary image at the center of a blob to
     * blobColor. If they differ, the blob is filtered out. Use blobColor = 0 to extract dark blobs
     * and blobColor = 255 to extract light blobs.
     *   </li>
     *   <li>
     *    <b>By area</b>. Extracted blobs have an area between minArea (inclusive) and maxArea (exclusive).
     *   </li>
     *   <li>
     *    <b>By circularity</b>. Extracted blobs have circularity
     * (\(\frac{4*\pi*Area}{perimeter * perimeter}\)) between minCircularity (inclusive) and
     * maxCircularity (exclusive).
     *   </li>
     *   <li>
     *    <b>By ratio of the minimum inertia to maximum inertia</b>. Extracted blobs have this ratio
     * between minInertiaRatio (inclusive) and maxInertiaRatio (exclusive).
     *   </li>
     *   <li>
     *    <b>By convexity</b>. Extracted blobs have convexity (area / area of blob convex hull) between
     * minConvexity (inclusive) and maxConvexity (exclusive).
     *   </li>
     * </ul>
     *
     * Default values of parameters are tuned to extract dark circular blobs.
     */

    public class SimpleBlobDetector : Feature2D
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
                        features2d_SimpleBlobDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SimpleBlobDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SimpleBlobDetector __fromPtr__(IntPtr addr) { return new SimpleBlobDetector(addr); }

        //
        // C++: static Ptr_SimpleBlobDetector cv::SimpleBlobDetector::create(SimpleBlobDetector_Params parameters = SimpleBlobDetector::Params())
        //

        public static SimpleBlobDetector create(SimpleBlobDetector_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return SimpleBlobDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SimpleBlobDetector_create_10(parameters.nativeObj)));


        }

        public static SimpleBlobDetector create()
        {


            return SimpleBlobDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SimpleBlobDetector_create_11()));


        }


        //
        // C++:  void cv::SimpleBlobDetector::setParams(SimpleBlobDetector_Params _params)
        //

        public void setParams(SimpleBlobDetector_Params _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();

            features2d_SimpleBlobDetector_setParams_10(nativeObj, _params.nativeObj);


        }


        //
        // C++:  SimpleBlobDetector_Params cv::SimpleBlobDetector::getParams()
        //

        public SimpleBlobDetector_Params getParams()
        {
            ThrowIfDisposed();

            return new SimpleBlobDetector_Params(DisposableObject.ThrowIfNullIntPtr(features2d_SimpleBlobDetector_getParams_10(nativeObj)));


        }


        //
        // C++:  String cv::SimpleBlobDetector::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_SimpleBlobDetector_getDefaultName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  vector_vector_Point cv::SimpleBlobDetector::getBlobContours()
        //

        public List<MatOfPoint> getBlobContours()
        {
            ThrowIfDisposed();
            List<MatOfPoint> retVal = new List<MatOfPoint>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_SimpleBlobDetector_getBlobContours_10(nativeObj)));
            Converters.Mat_to_vector_vector_Point(retValMat, retVal);
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_SimpleBlobDetector cv::SimpleBlobDetector::create(SimpleBlobDetector_Params parameters = SimpleBlobDetector::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_create_11();

        // C++:  void cv::SimpleBlobDetector::setParams(SimpleBlobDetector_Params _params)
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_setParams_10(IntPtr nativeObj, IntPtr _params_nativeObj);

        // C++:  SimpleBlobDetector_Params cv::SimpleBlobDetector::getParams()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_getParams_10(IntPtr nativeObj);

        // C++:  String cv::SimpleBlobDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_getDefaultName_10(IntPtr nativeObj);

        // C++:  vector_vector_Point cv::SimpleBlobDetector::getBlobContours()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_getBlobContours_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_delete(IntPtr nativeObj);

    }
}
