
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class EdgeBoxes
    /**
     * Class implementing EdgeBoxes algorithm from CITE: ZitnickECCV14edgeBoxes :
     */

    public class EdgeBoxes : Algorithm
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
                        ximgproc_EdgeBoxes_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EdgeBoxes(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EdgeBoxes __fromPtr__(IntPtr addr) { return new EdgeBoxes(addr); }

        //
        // C++:  void cv::ximgproc::EdgeBoxes::getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes, Mat& scores = Mat())
        //

        /**
         * Returns array containing proposal boxes.
         *
         *     param edge_map edge image.
         *     param orientation_map orientation map.
         *     param boxes proposal boxes.
         *     param scores of the proposal boxes, provided a vector of float types.
         */
        public void getBoundingBoxes(Mat edge_map, Mat orientation_map, MatOfRect boxes, Mat scores)
        {
            ThrowIfDisposed();
            if (edge_map != null) edge_map.ThrowIfDisposed();
            if (orientation_map != null) orientation_map.ThrowIfDisposed();
            if (boxes != null) boxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            Mat boxes_mat = boxes;
            ximgproc_EdgeBoxes_getBoundingBoxes_10(nativeObj, edge_map.nativeObj, orientation_map.nativeObj, boxes_mat.nativeObj, scores.nativeObj);


        }

        /**
         * Returns array containing proposal boxes.
         *
         *     param edge_map edge image.
         *     param orientation_map orientation map.
         *     param boxes proposal boxes.
         */
        public void getBoundingBoxes(Mat edge_map, Mat orientation_map, MatOfRect boxes)
        {
            ThrowIfDisposed();
            if (edge_map != null) edge_map.ThrowIfDisposed();
            if (orientation_map != null) orientation_map.ThrowIfDisposed();
            if (boxes != null) boxes.ThrowIfDisposed();
            Mat boxes_mat = boxes;
            ximgproc_EdgeBoxes_getBoundingBoxes_11(nativeObj, edge_map.nativeObj, orientation_map.nativeObj, boxes_mat.nativeObj);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getAlpha()
        //

        /**
         * Returns the step size of sliding window search.
         * return automatically generated
         */
        public float getAlpha()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getAlpha_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setAlpha(float value)
        //

        /**
         * Sets the step size of sliding window search.
         * param value automatically generated
         */
        public void setAlpha(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setAlpha_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getBeta()
        //

        /**
         * Returns the nms threshold for object proposals.
         * return automatically generated
         */
        public float getBeta()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getBeta_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setBeta(float value)
        //

        /**
         * Sets the nms threshold for object proposals.
         * param value automatically generated
         */
        public void setBeta(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setBeta_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getEta()
        //

        /**
         * Returns adaptation rate for nms threshold.
         * return automatically generated
         */
        public float getEta()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getEta_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setEta(float value)
        //

        /**
         * Sets the adaptation rate for nms threshold.
         * param value automatically generated
         */
        public void setEta(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setEta_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getMinScore()
        //

        /**
         * Returns the min score of boxes to detect.
         * return automatically generated
         */
        public float getMinScore()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getMinScore_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMinScore(float value)
        //

        /**
         * Sets the min score of boxes to detect.
         * param value automatically generated
         */
        public void setMinScore(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setMinScore_10(nativeObj, value);


        }


        //
        // C++:  int cv::ximgproc::EdgeBoxes::getMaxBoxes()
        //

        /**
         * Returns the max number of boxes to detect.
         * return automatically generated
         */
        public int getMaxBoxes()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getMaxBoxes_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMaxBoxes(int value)
        //

        /**
         * Sets max number of boxes to detect.
         * param value automatically generated
         */
        public void setMaxBoxes(int value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setMaxBoxes_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMinMag()
        //

        /**
         * Returns the edge min magnitude.
         * return automatically generated
         */
        public float getEdgeMinMag()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getEdgeMinMag_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMinMag(float value)
        //

        /**
         * Sets the edge min magnitude.
         * param value automatically generated
         */
        public void setEdgeMinMag(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setEdgeMinMag_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMergeThr()
        //

        /**
         * Returns the edge merge threshold.
         * return automatically generated
         */
        public float getEdgeMergeThr()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getEdgeMergeThr_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMergeThr(float value)
        //

        /**
         * Sets the edge merge threshold.
         * param value automatically generated
         */
        public void setEdgeMergeThr(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setEdgeMergeThr_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getClusterMinMag()
        //

        /**
         * Returns the cluster min magnitude.
         * return automatically generated
         */
        public float getClusterMinMag()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getClusterMinMag_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setClusterMinMag(float value)
        //

        /**
         * Sets the cluster min magnitude.
         * param value automatically generated
         */
        public void setClusterMinMag(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setClusterMinMag_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getMaxAspectRatio()
        //

        /**
         * Returns the max aspect ratio of boxes.
         * return automatically generated
         */
        public float getMaxAspectRatio()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getMaxAspectRatio_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMaxAspectRatio(float value)
        //

        /**
         * Sets the max aspect ratio of boxes.
         * param value automatically generated
         */
        public void setMaxAspectRatio(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setMaxAspectRatio_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getMinBoxArea()
        //

        /**
         * Returns the minimum area of boxes.
         * return automatically generated
         */
        public float getMinBoxArea()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getMinBoxArea_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMinBoxArea(float value)
        //

        /**
         * Sets the minimum area of boxes.
         * param value automatically generated
         */
        public void setMinBoxArea(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setMinBoxArea_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getGamma()
        //

        /**
         * Returns the affinity sensitivity.
         * return automatically generated
         */
        public float getGamma()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getGamma_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setGamma(float value)
        //

        /**
         * Sets the affinity sensitivity
         * param value automatically generated
         */
        public void setGamma(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setGamma_10(nativeObj, value);


        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getKappa()
        //

        /**
         * Returns the scale sensitivity.
         * return automatically generated
         */
        public float getKappa()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeBoxes_getKappa_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setKappa(float value)
        //

        /**
         * Sets the scale sensitivity.
         * param value automatically generated
         */
        public void setKappa(float value)
        {
            ThrowIfDisposed();

            ximgproc_EdgeBoxes_setKappa_10(nativeObj, value);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::EdgeBoxes::getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes, Mat& scores = Mat())
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_getBoundingBoxes_10(IntPtr nativeObj, IntPtr edge_map_nativeObj, IntPtr orientation_map_nativeObj, IntPtr boxes_mat_nativeObj, IntPtr scores_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_getBoundingBoxes_11(IntPtr nativeObj, IntPtr edge_map_nativeObj, IntPtr orientation_map_nativeObj, IntPtr boxes_mat_nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getAlpha()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getAlpha_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setAlpha(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setAlpha_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getBeta()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getBeta_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setBeta(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setBeta_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getEta()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEta_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setEta(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEta_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getMinScore()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMinScore_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setMinScore(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMinScore_10(IntPtr nativeObj, float value);

        // C++:  int cv::ximgproc::EdgeBoxes::getMaxBoxes()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeBoxes_getMaxBoxes_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setMaxBoxes(int value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMaxBoxes_10(IntPtr nativeObj, int value);

        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMinMag()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEdgeMinMag_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMinMag(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEdgeMinMag_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMergeThr()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEdgeMergeThr_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMergeThr(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEdgeMergeThr_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getClusterMinMag()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getClusterMinMag_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setClusterMinMag(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setClusterMinMag_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getMaxAspectRatio()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMaxAspectRatio_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setMaxAspectRatio(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMaxAspectRatio_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getMinBoxArea()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMinBoxArea_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setMinBoxArea(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMinBoxArea_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getGamma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getGamma_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setGamma(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setGamma_10(IntPtr nativeObj, float value);

        // C++:  float cv::ximgproc::EdgeBoxes::getKappa()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getKappa_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setKappa(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setKappa_10(IntPtr nativeObj, float value);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_delete(IntPtr nativeObj);

    }
}
