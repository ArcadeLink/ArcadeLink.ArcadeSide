
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class MSDDetector
    /**
     * Class implementing the MSD (*Maximal Self-Dissimilarity*) keypoint detector, described in CITE: Tombari14.
     *
     * The algorithm implements a novel interest point detector stemming from the intuition that image patches
     * which are highly dissimilar over a relatively large extent of their surroundings hold the property of
     * being repeatable and distinctive. This concept of "contextual self-dissimilarity" reverses the key
     * paradigm of recent successful techniques such as the Local Self-Similarity descriptor and the Non-Local
     * Means filter, which build upon the presence of similar - rather than dissimilar - patches. Moreover,
     * it extends to contextual information the local self-dissimilarity notion embedded in established
     * detectors of corner-like interest points, thereby achieving enhanced repeatability, distinctiveness and
     * localization accuracy.
     */

    public class MSDDetector : Feature2D
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
                        xfeatures2d_MSDDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MSDDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MSDDetector __fromPtr__(IntPtr addr) { return new MSDDetector(addr); }

        //
        // C++: static Ptr_MSDDetector cv::xfeatures2d::MSDDetector::create(int m_patch_radius = 3, int m_search_area_radius = 5, int m_nms_radius = 5, int m_nms_scale_radius = 0, float m_th_saliency = 250.0f, int m_kNN = 4, float m_scale_factor = 1.25f, int m_n_scales = -1, bool m_compute_orientation = false)
        //

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN, float m_scale_factor, int m_n_scales, bool m_compute_orientation)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_10(m_patch_radius, m_search_area_radius, m_nms_radius, m_nms_scale_radius, m_th_saliency, m_kNN, m_scale_factor, m_n_scales, m_compute_orientation)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN, float m_scale_factor, int m_n_scales)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_11(m_patch_radius, m_search_area_radius, m_nms_radius, m_nms_scale_radius, m_th_saliency, m_kNN, m_scale_factor, m_n_scales)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN, float m_scale_factor)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_12(m_patch_radius, m_search_area_radius, m_nms_radius, m_nms_scale_radius, m_th_saliency, m_kNN, m_scale_factor)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_13(m_patch_radius, m_search_area_radius, m_nms_radius, m_nms_scale_radius, m_th_saliency, m_kNN)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_14(m_patch_radius, m_search_area_radius, m_nms_radius, m_nms_scale_radius, m_th_saliency)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_15(m_patch_radius, m_search_area_radius, m_nms_radius, m_nms_scale_radius)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius, int m_nms_radius)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_16(m_patch_radius, m_search_area_radius, m_nms_radius)));


        }

        public static MSDDetector create(int m_patch_radius, int m_search_area_radius)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_17(m_patch_radius, m_search_area_radius)));


        }

        public static MSDDetector create(int m_patch_radius)
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_18(m_patch_radius)));


        }

        public static MSDDetector create()
        {


            return MSDDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_create_19()));


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setPatchRadius(int patch_radius)
        //

        public void setPatchRadius(int patch_radius)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setPatchRadius_10(nativeObj, patch_radius);


        }


        //
        // C++:  int cv::xfeatures2d::MSDDetector::getPatchRadius()
        //

        public int getPatchRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getPatchRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setSearchAreaRadius(int use_orientation)
        //

        public void setSearchAreaRadius(int use_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setSearchAreaRadius_10(nativeObj, use_orientation);


        }


        //
        // C++:  int cv::xfeatures2d::MSDDetector::getSearchAreaRadius()
        //

        public int getSearchAreaRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getSearchAreaRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setNmsRadius(int nms_radius)
        //

        public void setNmsRadius(int nms_radius)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setNmsRadius_10(nativeObj, nms_radius);


        }


        //
        // C++:  int cv::xfeatures2d::MSDDetector::getNmsRadius()
        //

        public int getNmsRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getNmsRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setNmsScaleRadius(int nms_scale_radius)
        //

        public void setNmsScaleRadius(int nms_scale_radius)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setNmsScaleRadius_10(nativeObj, nms_scale_radius);


        }


        //
        // C++:  int cv::xfeatures2d::MSDDetector::getNmsScaleRadius()
        //

        public int getNmsScaleRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getNmsScaleRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setThSaliency(float th_saliency)
        //

        public void setThSaliency(float th_saliency)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setThSaliency_10(nativeObj, th_saliency);


        }


        //
        // C++:  float cv::xfeatures2d::MSDDetector::getThSaliency()
        //

        public float getThSaliency()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getThSaliency_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setKNN(int kNN)
        //

        public void setKNN(int kNN)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setKNN_10(nativeObj, kNN);


        }


        //
        // C++:  int cv::xfeatures2d::MSDDetector::getKNN()
        //

        public int getKNN()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getKNN_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setScaleFactor(float scale_factor)
        //

        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setScaleFactor_10(nativeObj, scale_factor);


        }


        //
        // C++:  float cv::xfeatures2d::MSDDetector::getScaleFactor()
        //

        public float getScaleFactor()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getScaleFactor_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setNScales(int use_orientation)
        //

        public void setNScales(int use_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setNScales_10(nativeObj, use_orientation);


        }


        //
        // C++:  int cv::xfeatures2d::MSDDetector::getNScales()
        //

        public int getNScales()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getNScales_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::MSDDetector::setComputeOrientation(bool compute_orientation)
        //

        public void setComputeOrientation(bool compute_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_MSDDetector_setComputeOrientation_10(nativeObj, compute_orientation);


        }


        //
        // C++:  bool cv::xfeatures2d::MSDDetector::getComputeOrientation()
        //

        public bool getComputeOrientation()
        {
            ThrowIfDisposed();

            return xfeatures2d_MSDDetector_getComputeOrientation_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::MSDDetector::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_MSDDetector_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_MSDDetector cv::xfeatures2d::MSDDetector::create(int m_patch_radius = 3, int m_search_area_radius = 5, int m_nms_radius = 5, int m_nms_scale_radius = 0, float m_th_saliency = 250.0f, int m_kNN = 4, float m_scale_factor = 1.25f, int m_n_scales = -1, bool m_compute_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_10(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN, float m_scale_factor, int m_n_scales, [MarshalAs(UnmanagedType.U1)] bool m_compute_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_11(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN, float m_scale_factor, int m_n_scales);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_12(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN, float m_scale_factor);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_13(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency, int m_kNN);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_14(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius, float m_th_saliency);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_15(int m_patch_radius, int m_search_area_radius, int m_nms_radius, int m_nms_scale_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_16(int m_patch_radius, int m_search_area_radius, int m_nms_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_17(int m_patch_radius, int m_search_area_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_18(int m_patch_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_create_19();

        // C++:  void cv::xfeatures2d::MSDDetector::setPatchRadius(int patch_radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setPatchRadius_10(IntPtr nativeObj, int patch_radius);

        // C++:  int cv::xfeatures2d::MSDDetector::getPatchRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_MSDDetector_getPatchRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setSearchAreaRadius(int use_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setSearchAreaRadius_10(IntPtr nativeObj, int use_orientation);

        // C++:  int cv::xfeatures2d::MSDDetector::getSearchAreaRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_MSDDetector_getSearchAreaRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setNmsRadius(int nms_radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setNmsRadius_10(IntPtr nativeObj, int nms_radius);

        // C++:  int cv::xfeatures2d::MSDDetector::getNmsRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_MSDDetector_getNmsRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setNmsScaleRadius(int nms_scale_radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setNmsScaleRadius_10(IntPtr nativeObj, int nms_scale_radius);

        // C++:  int cv::xfeatures2d::MSDDetector::getNmsScaleRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_MSDDetector_getNmsScaleRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setThSaliency(float th_saliency)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setThSaliency_10(IntPtr nativeObj, float th_saliency);

        // C++:  float cv::xfeatures2d::MSDDetector::getThSaliency()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_MSDDetector_getThSaliency_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setKNN(int kNN)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setKNN_10(IntPtr nativeObj, int kNN);

        // C++:  int cv::xfeatures2d::MSDDetector::getKNN()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_MSDDetector_getKNN_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  float cv::xfeatures2d::MSDDetector::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_MSDDetector_getScaleFactor_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setNScales(int use_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setNScales_10(IntPtr nativeObj, int use_orientation);

        // C++:  int cv::xfeatures2d::MSDDetector::getNScales()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_MSDDetector_getNScales_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::MSDDetector::setComputeOrientation(bool compute_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_setComputeOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool compute_orientation);

        // C++:  bool cv::xfeatures2d::MSDDetector::getComputeOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_MSDDetector_getComputeOrientation_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::MSDDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_MSDDetector_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_delete(IntPtr nativeObj);

    }
}
