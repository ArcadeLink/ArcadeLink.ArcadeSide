
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class MSER
    /**
     * Maximally stable extremal region extractor
     *
     * The class encapsulates all the parameters of the %MSER extraction algorithm (see [wiki
     * article](http://en.wikipedia.org/wiki/Maximally_stable_extremal_regions)).
     *
     * <ul>
     *   <li>
     *  there are two different implementation of %MSER: one for grey image, one for color image
     *   </li>
     * </ul>
     *
     * <ul>
     *   <li>
     *  the grey image algorithm is taken from: CITE: nister2008linear ;  the paper claims to be faster
     * than union-find method; it actually get 1.5~2m/s on my centrino L7200 1.2GHz laptop.
     *   </li>
     * </ul>
     *
     * <ul>
     *   <li>
     *  the color image algorithm is taken from: CITE: forssen2007maximally ; it should be much slower
     * than grey image method ( 3~4 times )
     *   </li>
     * </ul>
     *
     * <ul>
     *   <li>
     *  (Python) A complete example showing the use of the %MSER detector can be found at samples/python/mser.py
     *   </li>
     * </ul>
     */

    public class MSER : Feature2D
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
                        features2d_MSER_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MSER(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MSER __fromPtr__(IntPtr addr) { return new MSER(addr); }

        //
        // C++: static Ptr_MSER cv::MSER::create(int delta = 5, int min_area = 60, int max_area = 14400, double max_variation = 0.25, double min_diversity = .2, int max_evolution = 200, double area_threshold = 1.01, double min_margin = 0.003, int edge_blur_size = 5)
        //

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         *     param max_variation prune the area have similar size to its children
         *     param min_diversity for color image, trace back to cut off mser with diversity less than min_diversity
         *     param max_evolution  for color image, the evolution steps
         *     param area_threshold for color image, the area threshold to cause re-initialize
         *     param min_margin for color image, ignore too small margin
         *     param edge_blur_size for color image, the aperture size for edge blur
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold, double min_margin, int edge_blur_size)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_10(delta, min_area, max_area, max_variation, min_diversity, max_evolution, area_threshold, min_margin, edge_blur_size)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         *     param max_variation prune the area have similar size to its children
         *     param min_diversity for color image, trace back to cut off mser with diversity less than min_diversity
         *     param max_evolution  for color image, the evolution steps
         *     param area_threshold for color image, the area threshold to cause re-initialize
         *     param min_margin for color image, ignore too small margin
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold, double min_margin)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_11(delta, min_area, max_area, max_variation, min_diversity, max_evolution, area_threshold, min_margin)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         *     param max_variation prune the area have similar size to its children
         *     param min_diversity for color image, trace back to cut off mser with diversity less than min_diversity
         *     param max_evolution  for color image, the evolution steps
         *     param area_threshold for color image, the area threshold to cause re-initialize
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_12(delta, min_area, max_area, max_variation, min_diversity, max_evolution, area_threshold)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         *     param max_variation prune the area have similar size to its children
         *     param min_diversity for color image, trace back to cut off mser with diversity less than min_diversity
         *     param max_evolution  for color image, the evolution steps
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_13(delta, min_area, max_area, max_variation, min_diversity, max_evolution)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         *     param max_variation prune the area have similar size to its children
         *     param min_diversity for color image, trace back to cut off mser with diversity less than min_diversity
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area, double max_variation, double min_diversity)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_14(delta, min_area, max_area, max_variation, min_diversity)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         *     param max_variation prune the area have similar size to its children
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area, double max_variation)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_15(delta, min_area, max_area, max_variation)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         *     param max_area prune the area which bigger than maxArea
         * return automatically generated
         */
        public static MSER create(int delta, int min_area, int max_area)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_16(delta, min_area, max_area)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         *     param min_area prune the area which smaller than minArea
         * return automatically generated
         */
        public static MSER create(int delta, int min_area)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_17(delta, min_area)));


        }

        /**
         * Full constructor for %MSER detector
         *
         *     param delta it compares \((size_{i}-size_{i-delta})/size_{i-delta}\)
         * return automatically generated
         */
        public static MSER create(int delta)
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_18(delta)));


        }

        /**
         * Full constructor for %MSER detector
         *
         * return automatically generated
         */
        public static MSER create()
        {


            return MSER.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_create_19()));


        }


        //
        // C++:  void cv::MSER::detectRegions(Mat image, vector_vector_Point& msers, vector_Rect& bboxes)
        //

        /**
         * Detect %MSER regions
         *
         *     param image input image (8UC1, 8UC3 or 8UC4, must be greater or equal than 3x3)
         *     param msers resulting list of point sets
         *     param bboxes resulting bounding boxes
         */
        public void detectRegions(Mat image, List<MatOfPoint> msers, MatOfRect bboxes)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (bboxes != null) bboxes.ThrowIfDisposed();
            Mat msers_mat = new Mat();
            Mat bboxes_mat = bboxes;
            features2d_MSER_detectRegions_10(nativeObj, image.nativeObj, msers_mat.nativeObj, bboxes_mat.nativeObj);
            Converters.Mat_to_vector_vector_Point(msers_mat, msers);
            msers_mat.release();

        }


        //
        // C++:  void cv::MSER::setDelta(int delta)
        //

        public void setDelta(int delta)
        {
            ThrowIfDisposed();

            features2d_MSER_setDelta_10(nativeObj, delta);


        }


        //
        // C++:  int cv::MSER::getDelta()
        //

        public int getDelta()
        {
            ThrowIfDisposed();

            return features2d_MSER_getDelta_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setMinArea(int minArea)
        //

        public void setMinArea(int minArea)
        {
            ThrowIfDisposed();

            features2d_MSER_setMinArea_10(nativeObj, minArea);


        }


        //
        // C++:  int cv::MSER::getMinArea()
        //

        public int getMinArea()
        {
            ThrowIfDisposed();

            return features2d_MSER_getMinArea_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setMaxArea(int maxArea)
        //

        public void setMaxArea(int maxArea)
        {
            ThrowIfDisposed();

            features2d_MSER_setMaxArea_10(nativeObj, maxArea);


        }


        //
        // C++:  int cv::MSER::getMaxArea()
        //

        public int getMaxArea()
        {
            ThrowIfDisposed();

            return features2d_MSER_getMaxArea_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setMaxVariation(double maxVariation)
        //

        public void setMaxVariation(double maxVariation)
        {
            ThrowIfDisposed();

            features2d_MSER_setMaxVariation_10(nativeObj, maxVariation);


        }


        //
        // C++:  double cv::MSER::getMaxVariation()
        //

        public double getMaxVariation()
        {
            ThrowIfDisposed();

            return features2d_MSER_getMaxVariation_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setMinDiversity(double minDiversity)
        //

        public void setMinDiversity(double minDiversity)
        {
            ThrowIfDisposed();

            features2d_MSER_setMinDiversity_10(nativeObj, minDiversity);


        }


        //
        // C++:  double cv::MSER::getMinDiversity()
        //

        public double getMinDiversity()
        {
            ThrowIfDisposed();

            return features2d_MSER_getMinDiversity_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setMaxEvolution(int maxEvolution)
        //

        public void setMaxEvolution(int maxEvolution)
        {
            ThrowIfDisposed();

            features2d_MSER_setMaxEvolution_10(nativeObj, maxEvolution);


        }


        //
        // C++:  int cv::MSER::getMaxEvolution()
        //

        public int getMaxEvolution()
        {
            ThrowIfDisposed();

            return features2d_MSER_getMaxEvolution_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setAreaThreshold(double areaThreshold)
        //

        public void setAreaThreshold(double areaThreshold)
        {
            ThrowIfDisposed();

            features2d_MSER_setAreaThreshold_10(nativeObj, areaThreshold);


        }


        //
        // C++:  double cv::MSER::getAreaThreshold()
        //

        public double getAreaThreshold()
        {
            ThrowIfDisposed();

            return features2d_MSER_getAreaThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setMinMargin(double min_margin)
        //

        public void setMinMargin(double min_margin)
        {
            ThrowIfDisposed();

            features2d_MSER_setMinMargin_10(nativeObj, min_margin);


        }


        //
        // C++:  double cv::MSER::getMinMargin()
        //

        public double getMinMargin()
        {
            ThrowIfDisposed();

            return features2d_MSER_getMinMargin_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setEdgeBlurSize(int edge_blur_size)
        //

        public void setEdgeBlurSize(int edge_blur_size)
        {
            ThrowIfDisposed();

            features2d_MSER_setEdgeBlurSize_10(nativeObj, edge_blur_size);


        }


        //
        // C++:  int cv::MSER::getEdgeBlurSize()
        //

        public int getEdgeBlurSize()
        {
            ThrowIfDisposed();

            return features2d_MSER_getEdgeBlurSize_10(nativeObj);


        }


        //
        // C++:  void cv::MSER::setPass2Only(bool f)
        //

        public void setPass2Only(bool f)
        {
            ThrowIfDisposed();

            features2d_MSER_setPass2Only_10(nativeObj, f);


        }


        //
        // C++:  bool cv::MSER::getPass2Only()
        //

        public bool getPass2Only()
        {
            ThrowIfDisposed();

            return features2d_MSER_getPass2Only_10(nativeObj);


        }


        //
        // C++:  String cv::MSER::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_MSER_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_MSER cv::MSER::create(int delta = 5, int min_area = 60, int max_area = 14400, double max_variation = 0.25, double min_diversity = .2, int max_evolution = 200, double area_threshold = 1.01, double min_margin = 0.003, int edge_blur_size = 5)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_10(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold, double min_margin, int edge_blur_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_11(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold, double min_margin);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_12(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution, double area_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_13(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_14(int delta, int min_area, int max_area, double max_variation, double min_diversity);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_15(int delta, int min_area, int max_area, double max_variation);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_16(int delta, int min_area, int max_area);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_17(int delta, int min_area);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_18(int delta);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_create_19();

        // C++:  void cv::MSER::detectRegions(Mat image, vector_vector_Point& msers, vector_Rect& bboxes)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_detectRegions_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr msers_mat_nativeObj, IntPtr bboxes_mat_nativeObj);

        // C++:  void cv::MSER::setDelta(int delta)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setDelta_10(IntPtr nativeObj, int delta);

        // C++:  int cv::MSER::getDelta()
        [DllImport(LIBNAME)]
        private static extern int features2d_MSER_getDelta_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setMinArea(int minArea)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setMinArea_10(IntPtr nativeObj, int minArea);

        // C++:  int cv::MSER::getMinArea()
        [DllImport(LIBNAME)]
        private static extern int features2d_MSER_getMinArea_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setMaxArea(int maxArea)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setMaxArea_10(IntPtr nativeObj, int maxArea);

        // C++:  int cv::MSER::getMaxArea()
        [DllImport(LIBNAME)]
        private static extern int features2d_MSER_getMaxArea_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setMaxVariation(double maxVariation)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setMaxVariation_10(IntPtr nativeObj, double maxVariation);

        // C++:  double cv::MSER::getMaxVariation()
        [DllImport(LIBNAME)]
        private static extern double features2d_MSER_getMaxVariation_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setMinDiversity(double minDiversity)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setMinDiversity_10(IntPtr nativeObj, double minDiversity);

        // C++:  double cv::MSER::getMinDiversity()
        [DllImport(LIBNAME)]
        private static extern double features2d_MSER_getMinDiversity_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setMaxEvolution(int maxEvolution)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setMaxEvolution_10(IntPtr nativeObj, int maxEvolution);

        // C++:  int cv::MSER::getMaxEvolution()
        [DllImport(LIBNAME)]
        private static extern int features2d_MSER_getMaxEvolution_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setAreaThreshold(double areaThreshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setAreaThreshold_10(IntPtr nativeObj, double areaThreshold);

        // C++:  double cv::MSER::getAreaThreshold()
        [DllImport(LIBNAME)]
        private static extern double features2d_MSER_getAreaThreshold_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setMinMargin(double min_margin)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setMinMargin_10(IntPtr nativeObj, double min_margin);

        // C++:  double cv::MSER::getMinMargin()
        [DllImport(LIBNAME)]
        private static extern double features2d_MSER_getMinMargin_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setEdgeBlurSize(int edge_blur_size)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setEdgeBlurSize_10(IntPtr nativeObj, int edge_blur_size);

        // C++:  int cv::MSER::getEdgeBlurSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_MSER_getEdgeBlurSize_10(IntPtr nativeObj);

        // C++:  void cv::MSER::setPass2Only(bool f)
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_setPass2Only_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool f);

        // C++:  bool cv::MSER::getPass2Only()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_MSER_getPass2Only_10(IntPtr nativeObj);

        // C++:  String cv::MSER::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_MSER_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_MSER_delete(IntPtr nativeObj);

    }
}
