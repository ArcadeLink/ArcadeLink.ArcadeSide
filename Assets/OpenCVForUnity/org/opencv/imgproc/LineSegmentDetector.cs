
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class LineSegmentDetector
    /**
     * Line segment detector class
     *
     * following the algorithm described at CITE: Rafael12 .
     *
     * <b>Note:</b> Implementation has been removed from OpenCV version 3.4.6 to 3.4.15 and version 4.1.0 to 4.5.3 due original code license conflict.
     * restored again after [Computation of a NFA](https://github.com/rafael-grompone-von-gioi/binomial_nfa) code published under the MIT license.
     */

    public class LineSegmentDetector : Algorithm
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
                        imgproc_LineSegmentDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LineSegmentDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LineSegmentDetector __fromPtr__(IntPtr addr) { return new LineSegmentDetector(addr); }

        //
        // C++:  void cv::LineSegmentDetector::detect(Mat image, Mat& lines, Mat& width = Mat(), Mat& prec = Mat(), Mat& nfa = Mat())
        //

        /**
         * Finds lines in the input image.
         *
         *     This is the output of the default parameters of the algorithm on the above shown image.
         *
         *     ![image](pics/building_lsd.png)
         *
         *     param image A grayscale (CV_8UC1) input image. If only a roi needs to be selected, use:
         *     {code lsd_ptr-&gt;detect(image(roi), lines, ...); lines += Scalar(roi.x, roi.y, roi.x, roi.y);}
         *     param lines A vector of Vec4f elements specifying the beginning and ending point of a line. Where
         *     Vec4f is (x1, y1, x2, y2), point 1 is the start, point 2 - end. Returned lines are strictly
         *     oriented depending on the gradient.
         *     param width Vector of widths of the regions, where the lines are found. E.g. Width of line.
         *     param prec Vector of precisions with which the lines are found.
         *     param nfa Vector containing number of false alarms in the line region, with precision of 10%. The
         *     bigger the value, logarithmically better the detection.
         * <ul>
         *   <li>
         *      -1 corresponds to 10 mean false alarms
         *   </li>
         *   <li>
         *      0 corresponds to 1 mean false alarm
         *   </li>
         *   <li>
         *      1 corresponds to 0.1 mean false alarms
         *     This vector will be calculated only when the objects type is #LSD_REFINE_ADV.
         *   </li>
         * </ul>
         */
        public void detect(Mat image, Mat lines, Mat width, Mat prec, Mat nfa)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
            if (width != null) width.ThrowIfDisposed();
            if (prec != null) prec.ThrowIfDisposed();
            if (nfa != null) nfa.ThrowIfDisposed();

            imgproc_LineSegmentDetector_detect_10(nativeObj, image.nativeObj, lines.nativeObj, width.nativeObj, prec.nativeObj, nfa.nativeObj);


        }

        /**
         * Finds lines in the input image.
         *
         *     This is the output of the default parameters of the algorithm on the above shown image.
         *
         *     ![image](pics/building_lsd.png)
         *
         *     param image A grayscale (CV_8UC1) input image. If only a roi needs to be selected, use:
         *     {code lsd_ptr-&gt;detect(image(roi), lines, ...); lines += Scalar(roi.x, roi.y, roi.x, roi.y);}
         *     param lines A vector of Vec4f elements specifying the beginning and ending point of a line. Where
         *     Vec4f is (x1, y1, x2, y2), point 1 is the start, point 2 - end. Returned lines are strictly
         *     oriented depending on the gradient.
         *     param width Vector of widths of the regions, where the lines are found. E.g. Width of line.
         *     param prec Vector of precisions with which the lines are found.
         *     bigger the value, logarithmically better the detection.
         * <ul>
         *   <li>
         *      -1 corresponds to 10 mean false alarms
         *   </li>
         *   <li>
         *      0 corresponds to 1 mean false alarm
         *   </li>
         *   <li>
         *      1 corresponds to 0.1 mean false alarms
         *     This vector will be calculated only when the objects type is #LSD_REFINE_ADV.
         *   </li>
         * </ul>
         */
        public void detect(Mat image, Mat lines, Mat width, Mat prec)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
            if (width != null) width.ThrowIfDisposed();
            if (prec != null) prec.ThrowIfDisposed();

            imgproc_LineSegmentDetector_detect_11(nativeObj, image.nativeObj, lines.nativeObj, width.nativeObj, prec.nativeObj);


        }

        /**
         * Finds lines in the input image.
         *
         *     This is the output of the default parameters of the algorithm on the above shown image.
         *
         *     ![image](pics/building_lsd.png)
         *
         *     param image A grayscale (CV_8UC1) input image. If only a roi needs to be selected, use:
         *     {code lsd_ptr-&gt;detect(image(roi), lines, ...); lines += Scalar(roi.x, roi.y, roi.x, roi.y);}
         *     param lines A vector of Vec4f elements specifying the beginning and ending point of a line. Where
         *     Vec4f is (x1, y1, x2, y2), point 1 is the start, point 2 - end. Returned lines are strictly
         *     oriented depending on the gradient.
         *     param width Vector of widths of the regions, where the lines are found. E.g. Width of line.
         *     bigger the value, logarithmically better the detection.
         * <ul>
         *   <li>
         *      -1 corresponds to 10 mean false alarms
         *   </li>
         *   <li>
         *      0 corresponds to 1 mean false alarm
         *   </li>
         *   <li>
         *      1 corresponds to 0.1 mean false alarms
         *     This vector will be calculated only when the objects type is #LSD_REFINE_ADV.
         *   </li>
         * </ul>
         */
        public void detect(Mat image, Mat lines, Mat width)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
            if (width != null) width.ThrowIfDisposed();

            imgproc_LineSegmentDetector_detect_12(nativeObj, image.nativeObj, lines.nativeObj, width.nativeObj);


        }

        /**
         * Finds lines in the input image.
         *
         *     This is the output of the default parameters of the algorithm on the above shown image.
         *
         *     ![image](pics/building_lsd.png)
         *
         *     param image A grayscale (CV_8UC1) input image. If only a roi needs to be selected, use:
         *     {code lsd_ptr-&gt;detect(image(roi), lines, ...); lines += Scalar(roi.x, roi.y, roi.x, roi.y);}
         *     param lines A vector of Vec4f elements specifying the beginning and ending point of a line. Where
         *     Vec4f is (x1, y1, x2, y2), point 1 is the start, point 2 - end. Returned lines are strictly
         *     oriented depending on the gradient.
         *     bigger the value, logarithmically better the detection.
         * <ul>
         *   <li>
         *      -1 corresponds to 10 mean false alarms
         *   </li>
         *   <li>
         *      0 corresponds to 1 mean false alarm
         *   </li>
         *   <li>
         *      1 corresponds to 0.1 mean false alarms
         *     This vector will be calculated only when the objects type is #LSD_REFINE_ADV.
         *   </li>
         * </ul>
         */
        public void detect(Mat image, Mat lines)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();

            imgproc_LineSegmentDetector_detect_13(nativeObj, image.nativeObj, lines.nativeObj);


        }


        //
        // C++:  void cv::LineSegmentDetector::drawSegments(Mat& image, Mat lines)
        //

        /**
         * Draws the line segments on a given image.
         *     param image The image, where the lines will be drawn. Should be bigger or equal to the image,
         *     where the lines were found.
         *     param lines A vector of the lines that needed to be drawn.
         */
        public void drawSegments(Mat image, Mat lines)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();

            imgproc_LineSegmentDetector_drawSegments_10(nativeObj, image.nativeObj, lines.nativeObj);


        }


        //
        // C++:  int cv::LineSegmentDetector::compareSegments(Size size, Mat lines1, Mat lines2, Mat& image = Mat())
        //

        /**
         * Draws two groups of lines in blue and red, counting the non overlapping (mismatching) pixels.
         *
         *     param size The size of the image, where lines1 and lines2 were found.
         *     param lines1 The first group of lines that needs to be drawn. It is visualized in blue color.
         *     param lines2 The second group of lines. They visualized in red color.
         *     param image Optional image, where the lines will be drawn. The image should be color(3-channel)
         *     in order for lines1 and lines2 to be drawn in the above mentioned colors.
         * return automatically generated
         */
        public int compareSegments(Size size, Mat lines1, Mat lines2, Mat image)
        {
            ThrowIfDisposed();
            if (lines1 != null) lines1.ThrowIfDisposed();
            if (lines2 != null) lines2.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return imgproc_LineSegmentDetector_compareSegments_10(nativeObj, size.width, size.height, lines1.nativeObj, lines2.nativeObj, image.nativeObj);


        }

        /**
         * Draws two groups of lines in blue and red, counting the non overlapping (mismatching) pixels.
         *
         *     param size The size of the image, where lines1 and lines2 were found.
         *     param lines1 The first group of lines that needs to be drawn. It is visualized in blue color.
         *     param lines2 The second group of lines. They visualized in red color.
         *     in order for lines1 and lines2 to be drawn in the above mentioned colors.
         * return automatically generated
         */
        public int compareSegments(Size size, Mat lines1, Mat lines2)
        {
            ThrowIfDisposed();
            if (lines1 != null) lines1.ThrowIfDisposed();
            if (lines2 != null) lines2.ThrowIfDisposed();

            return imgproc_LineSegmentDetector_compareSegments_11(nativeObj, size.width, size.height, lines1.nativeObj, lines2.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::LineSegmentDetector::detect(Mat image, Mat& lines, Mat& width = Mat(), Mat& prec = Mat(), Mat& nfa = Mat())
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr lines_nativeObj, IntPtr width_nativeObj, IntPtr prec_nativeObj, IntPtr nfa_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr lines_nativeObj, IntPtr width_nativeObj, IntPtr prec_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr lines_nativeObj, IntPtr width_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr lines_nativeObj);

        // C++:  void cv::LineSegmentDetector::drawSegments(Mat& image, Mat lines)
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_drawSegments_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr lines_nativeObj);

        // C++:  int cv::LineSegmentDetector::compareSegments(Size size, Mat lines1, Mat lines2, Mat& image = Mat())
        [DllImport(LIBNAME)]
        private static extern int imgproc_LineSegmentDetector_compareSegments_10(IntPtr nativeObj, double size_width, double size_height, IntPtr lines1_nativeObj, IntPtr lines2_nativeObj, IntPtr image_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int imgproc_LineSegmentDetector_compareSegments_11(IntPtr nativeObj, double size_width, double size_height, IntPtr lines1_nativeObj, IntPtr lines2_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_delete(IntPtr nativeObj);

    }
}
