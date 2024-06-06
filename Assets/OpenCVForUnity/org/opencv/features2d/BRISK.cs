
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class BRISK
    /**
     * Class implementing the BRISK keypoint detector and descriptor extractor, described in CITE: LCS11 .
     */

    public class BRISK : Feature2D
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
                        features2d_BRISK_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BRISK(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BRISK __fromPtr__(IntPtr addr) { return new BRISK(addr); }

        //
        // C++: static Ptr_BRISK cv::BRISK::create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        //

        /**
         * The BRISK constructor
         *
         *     param thresh AGAST detection threshold score.
         *     param octaves detection octaves. Use 0 to do single scale.
         *     param patternScale apply this scale to the pattern used for sampling the neighbourhood of a
         *     keypoint.
         * return automatically generated
         */
        public static BRISK create(int thresh, int octaves, float patternScale)
        {


            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_10(thresh, octaves, patternScale)));


        }

        /**
         * The BRISK constructor
         *
         *     param thresh AGAST detection threshold score.
         *     param octaves detection octaves. Use 0 to do single scale.
         *     keypoint.
         * return automatically generated
         */
        public static BRISK create(int thresh, int octaves)
        {


            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_11(thresh, octaves)));


        }

        /**
         * The BRISK constructor
         *
         *     param thresh AGAST detection threshold score.
         *     keypoint.
         * return automatically generated
         */
        public static BRISK create(int thresh)
        {


            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_12(thresh)));


        }

        /**
         * The BRISK constructor
         *
         *     keypoint.
         * return automatically generated
         */
        public static BRISK create()
        {


            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_13()));


        }


        //
        // C++: static Ptr_BRISK cv::BRISK::create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        /**
         * The BRISK constructor for a custom pattern
         *
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     param dMax threshold for the short pairings used for descriptor formation (in pixels for keypoint
         *     scale 1).
         *     param dMin threshold for the long pairings used for orientation determination (in pixels for
         *     keypoint scale 1).
         * param indexChange index remapping of the bits.
         * return automatically generated
         */
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            if (indexChange != null) indexChange.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            Mat indexChange_mat = indexChange;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_14(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj)));


        }

        /**
         * The BRISK constructor for a custom pattern
         *
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     param dMax threshold for the short pairings used for descriptor formation (in pixels for keypoint
         *     scale 1).
         *     param dMin threshold for the long pairings used for orientation determination (in pixels for
         *     keypoint scale 1).
         * return automatically generated
         */
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_15(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin)));


        }

        /**
         * The BRISK constructor for a custom pattern
         *
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     param dMax threshold for the short pairings used for descriptor formation (in pixels for keypoint
         *     scale 1).
         *     keypoint scale 1).
         * return automatically generated
         */
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList, float dMax)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_16(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax)));


        }

        /**
         * The BRISK constructor for a custom pattern
         *
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     scale 1).
         *     keypoint scale 1).
         * return automatically generated
         */
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_17(radiusList_mat.nativeObj, numberList_mat.nativeObj)));


        }


        //
        // C++: static Ptr_BRISK cv::BRISK::create(int thresh, int octaves, vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        /**
         * The BRISK constructor for a custom pattern, detection threshold and octaves
         *
         *     param thresh AGAST detection threshold score.
         *     param octaves detection octaves. Use 0 to do single scale.
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     param dMax threshold for the short pairings used for descriptor formation (in pixels for keypoint
         *     scale 1).
         *     param dMin threshold for the long pairings used for orientation determination (in pixels for
         *     keypoint scale 1).
         * param indexChange index remapping of the bits.
         * return automatically generated
         */
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            if (indexChange != null) indexChange.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            Mat indexChange_mat = indexChange;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_18(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj)));


        }

        /**
         * The BRISK constructor for a custom pattern, detection threshold and octaves
         *
         *     param thresh AGAST detection threshold score.
         *     param octaves detection octaves. Use 0 to do single scale.
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     param dMax threshold for the short pairings used for descriptor formation (in pixels for keypoint
         *     scale 1).
         *     param dMin threshold for the long pairings used for orientation determination (in pixels for
         *     keypoint scale 1).
         * return automatically generated
         */
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_19(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin)));


        }

        /**
         * The BRISK constructor for a custom pattern, detection threshold and octaves
         *
         *     param thresh AGAST detection threshold score.
         *     param octaves detection octaves. Use 0 to do single scale.
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     param dMax threshold for the short pairings used for descriptor formation (in pixels for keypoint
         *     scale 1).
         *     keypoint scale 1).
         * return automatically generated
         */
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_110(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax)));


        }

        /**
         * The BRISK constructor for a custom pattern, detection threshold and octaves
         *
         *     param thresh AGAST detection threshold score.
         *     param octaves detection octaves. Use 0 to do single scale.
         *     param radiusList defines the radii (in pixels) where the samples around a keypoint are taken (for
         *     keypoint scale 1).
         *     param numberList defines the number of sampling points on the sampling circle. Must be the same
         *     size as radiusList..
         *     scale 1).
         *     keypoint scale 1).
         * return automatically generated
         */
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            return BRISK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_create_111(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj)));


        }


        //
        // C++:  String cv::BRISK::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_BRISK_getDefaultName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::BRISK::setThreshold(int threshold)
        //

        /**
         * Set detection threshold.
         *     param threshold AGAST detection threshold score.
         */
        public void setThreshold(int threshold)
        {
            ThrowIfDisposed();

            features2d_BRISK_setThreshold_10(nativeObj, threshold);


        }


        //
        // C++:  int cv::BRISK::getThreshold()
        //

        public int getThreshold()
        {
            ThrowIfDisposed();

            return features2d_BRISK_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::BRISK::setOctaves(int octaves)
        //

        /**
         * Set detection octaves.
         *     param octaves detection octaves. Use 0 to do single scale.
         */
        public void setOctaves(int octaves)
        {
            ThrowIfDisposed();

            features2d_BRISK_setOctaves_10(nativeObj, octaves);


        }


        //
        // C++:  int cv::BRISK::getOctaves()
        //

        public int getOctaves()
        {
            ThrowIfDisposed();

            return features2d_BRISK_getOctaves_10(nativeObj);


        }


        //
        // C++:  void cv::BRISK::setPatternScale(float patternScale)
        //

        /**
         * Set detection patternScale.
         *     param patternScale apply this scale to the pattern used for sampling the neighbourhood of a
         *     keypoint.
         */
        public void setPatternScale(float patternScale)
        {
            ThrowIfDisposed();

            features2d_BRISK_setPatternScale_10(nativeObj, patternScale);


        }


        //
        // C++:  float cv::BRISK::getPatternScale()
        //

        public float getPatternScale()
        {
            ThrowIfDisposed();

            return features2d_BRISK_getPatternScale_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_BRISK cv::BRISK::create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_10(int thresh, int octaves, float patternScale);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_11(int thresh, int octaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_12(int thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_13();

        // C++: static Ptr_BRISK cv::BRISK::create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_14(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_15(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_16(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_17(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // C++: static Ptr_BRISK cv::BRISK::create(int thresh, int octaves, vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_18(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_19(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_110(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_111(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // C++:  String cv::BRISK::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_getDefaultName_10(IntPtr nativeObj);

        // C++:  void cv::BRISK::setThreshold(int threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_setThreshold_10(IntPtr nativeObj, int threshold);

        // C++:  int cv::BRISK::getThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_BRISK_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::BRISK::setOctaves(int octaves)
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_setOctaves_10(IntPtr nativeObj, int octaves);

        // C++:  int cv::BRISK::getOctaves()
        [DllImport(LIBNAME)]
        private static extern int features2d_BRISK_getOctaves_10(IntPtr nativeObj);

        // C++:  void cv::BRISK::setPatternScale(float patternScale)
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_setPatternScale_10(IntPtr nativeObj, float patternScale);

        // C++:  float cv::BRISK::getPatternScale()
        [DllImport(LIBNAME)]
        private static extern float features2d_BRISK_getPatternScale_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_delete(IntPtr nativeObj);

    }
}
