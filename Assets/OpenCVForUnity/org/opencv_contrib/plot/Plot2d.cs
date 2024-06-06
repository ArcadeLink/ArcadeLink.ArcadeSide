
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PlotModule
{

    // C++: class Plot2d
    /**
     *  plot Plot function for Mat data
     */

    public class Plot2d : Algorithm
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
                        plot_Plot2d_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Plot2d(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Plot2d __fromPtr__(IntPtr addr) { return new Plot2d(addr); }

        //
        // C++:  void cv::plot::Plot2d::setMinX(double _plotMinX)
        //

        public void setMinX(double _plotMinX)
        {
            ThrowIfDisposed();

            plot_Plot2d_setMinX_10(nativeObj, _plotMinX);


        }


        //
        // C++:  void cv::plot::Plot2d::setMinY(double _plotMinY)
        //

        public void setMinY(double _plotMinY)
        {
            ThrowIfDisposed();

            plot_Plot2d_setMinY_10(nativeObj, _plotMinY);


        }


        //
        // C++:  void cv::plot::Plot2d::setMaxX(double _plotMaxX)
        //

        public void setMaxX(double _plotMaxX)
        {
            ThrowIfDisposed();

            plot_Plot2d_setMaxX_10(nativeObj, _plotMaxX);


        }


        //
        // C++:  void cv::plot::Plot2d::setMaxY(double _plotMaxY)
        //

        public void setMaxY(double _plotMaxY)
        {
            ThrowIfDisposed();

            plot_Plot2d_setMaxY_10(nativeObj, _plotMaxY);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotLineWidth(int _plotLineWidth)
        //

        public void setPlotLineWidth(int _plotLineWidth)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotLineWidth_10(nativeObj, _plotLineWidth);


        }


        //
        // C++:  void cv::plot::Plot2d::setNeedPlotLine(bool _needPlotLine)
        //

        /**
         * Switches data visualization mode
         *
         * param _needPlotLine if true then neighbour plot points will be connected by lines.
         * In other case data will be plotted as a set of standalone points.
         */
        public void setNeedPlotLine(bool _needPlotLine)
        {
            ThrowIfDisposed();

            plot_Plot2d_setNeedPlotLine_10(nativeObj, _needPlotLine);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotLineColor(Scalar _plotLineColor)
        //

        public void setPlotLineColor(Scalar _plotLineColor)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotLineColor_10(nativeObj, _plotLineColor.val[0], _plotLineColor.val[1], _plotLineColor.val[2], _plotLineColor.val[3]);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotBackgroundColor(Scalar _plotBackgroundColor)
        //

        public void setPlotBackgroundColor(Scalar _plotBackgroundColor)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotBackgroundColor_10(nativeObj, _plotBackgroundColor.val[0], _plotBackgroundColor.val[1], _plotBackgroundColor.val[2], _plotBackgroundColor.val[3]);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotAxisColor(Scalar _plotAxisColor)
        //

        public void setPlotAxisColor(Scalar _plotAxisColor)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotAxisColor_10(nativeObj, _plotAxisColor.val[0], _plotAxisColor.val[1], _plotAxisColor.val[2], _plotAxisColor.val[3]);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotGridColor(Scalar _plotGridColor)
        //

        public void setPlotGridColor(Scalar _plotGridColor)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotGridColor_10(nativeObj, _plotGridColor.val[0], _plotGridColor.val[1], _plotGridColor.val[2], _plotGridColor.val[3]);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotTextColor(Scalar _plotTextColor)
        //

        public void setPlotTextColor(Scalar _plotTextColor)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotTextColor_10(nativeObj, _plotTextColor.val[0], _plotTextColor.val[1], _plotTextColor.val[2], _plotTextColor.val[3]);


        }


        //
        // C++:  void cv::plot::Plot2d::setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
        //

        public void setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPlotSize_10(nativeObj, _plotSizeWidth, _plotSizeHeight);


        }


        //
        // C++:  void cv::plot::Plot2d::setShowGrid(bool needShowGrid)
        //

        public void setShowGrid(bool needShowGrid)
        {
            ThrowIfDisposed();

            plot_Plot2d_setShowGrid_10(nativeObj, needShowGrid);


        }


        //
        // C++:  void cv::plot::Plot2d::setShowText(bool needShowText)
        //

        public void setShowText(bool needShowText)
        {
            ThrowIfDisposed();

            plot_Plot2d_setShowText_10(nativeObj, needShowText);


        }


        //
        // C++:  void cv::plot::Plot2d::setGridLinesNumber(int gridLinesNumber)
        //

        public void setGridLinesNumber(int gridLinesNumber)
        {
            ThrowIfDisposed();

            plot_Plot2d_setGridLinesNumber_10(nativeObj, gridLinesNumber);


        }


        //
        // C++:  void cv::plot::Plot2d::setInvertOrientation(bool _invertOrientation)
        //

        public void setInvertOrientation(bool _invertOrientation)
        {
            ThrowIfDisposed();

            plot_Plot2d_setInvertOrientation_10(nativeObj, _invertOrientation);


        }


        //
        // C++:  void cv::plot::Plot2d::setPointIdxToPrint(int pointIdx)
        //

        /**
         * Sets the index of a point which coordinates will be printed on the top left corner of the plot (if ShowText flag is true).
         *
         * param pointIdx index of the required point in data array.
         */
        public void setPointIdxToPrint(int pointIdx)
        {
            ThrowIfDisposed();

            plot_Plot2d_setPointIdxToPrint_10(nativeObj, pointIdx);


        }


        //
        // C++:  void cv::plot::Plot2d::render(Mat& _plotResult)
        //

        public void render(Mat _plotResult)
        {
            ThrowIfDisposed();
            if (_plotResult != null) _plotResult.ThrowIfDisposed();

            plot_Plot2d_render_10(nativeObj, _plotResult.nativeObj);


        }


        //
        // C++: static Ptr_Plot2d cv::plot::Plot2d::create(Mat data)
        //

        /**
         * Creates Plot2d object
         *
         * param data \(1xN\) or \(Nx1\) matrix containing \(Y\) values of points to plot. \(X\) values
         * will be equal to indexes of correspondind elements in data matrix.
         * return automatically generated
         */
        public static Plot2d create(Mat data)
        {
            if (data != null) data.ThrowIfDisposed();

            return Plot2d.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(plot_Plot2d_create_10(data.nativeObj)));


        }


        //
        // C++: static Ptr_Plot2d cv::plot::Plot2d::create(Mat dataX, Mat dataY)
        //

        /**
         * Creates Plot2d object
         *
         * param dataX \(1xN\) or \(Nx1\) matrix \(X\) values of points to plot.
         * param dataY \(1xN\) or \(Nx1\) matrix containing \(Y\) values of points to plot.
         * return automatically generated
         */
        public static Plot2d create(Mat dataX, Mat dataY)
        {
            if (dataX != null) dataX.ThrowIfDisposed();
            if (dataY != null) dataY.ThrowIfDisposed();

            return Plot2d.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(plot_Plot2d_create_11(dataX.nativeObj, dataY.nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::plot::Plot2d::setMinX(double _plotMinX)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setMinX_10(IntPtr nativeObj, double _plotMinX);

        // C++:  void cv::plot::Plot2d::setMinY(double _plotMinY)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setMinY_10(IntPtr nativeObj, double _plotMinY);

        // C++:  void cv::plot::Plot2d::setMaxX(double _plotMaxX)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setMaxX_10(IntPtr nativeObj, double _plotMaxX);

        // C++:  void cv::plot::Plot2d::setMaxY(double _plotMaxY)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setMaxY_10(IntPtr nativeObj, double _plotMaxY);

        // C++:  void cv::plot::Plot2d::setPlotLineWidth(int _plotLineWidth)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotLineWidth_10(IntPtr nativeObj, int _plotLineWidth);

        // C++:  void cv::plot::Plot2d::setNeedPlotLine(bool _needPlotLine)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setNeedPlotLine_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool _needPlotLine);

        // C++:  void cv::plot::Plot2d::setPlotLineColor(Scalar _plotLineColor)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotLineColor_10(IntPtr nativeObj, double _plotLineColor_val0, double _plotLineColor_val1, double _plotLineColor_val2, double _plotLineColor_val3);

        // C++:  void cv::plot::Plot2d::setPlotBackgroundColor(Scalar _plotBackgroundColor)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotBackgroundColor_10(IntPtr nativeObj, double _plotBackgroundColor_val0, double _plotBackgroundColor_val1, double _plotBackgroundColor_val2, double _plotBackgroundColor_val3);

        // C++:  void cv::plot::Plot2d::setPlotAxisColor(Scalar _plotAxisColor)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotAxisColor_10(IntPtr nativeObj, double _plotAxisColor_val0, double _plotAxisColor_val1, double _plotAxisColor_val2, double _plotAxisColor_val3);

        // C++:  void cv::plot::Plot2d::setPlotGridColor(Scalar _plotGridColor)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotGridColor_10(IntPtr nativeObj, double _plotGridColor_val0, double _plotGridColor_val1, double _plotGridColor_val2, double _plotGridColor_val3);

        // C++:  void cv::plot::Plot2d::setPlotTextColor(Scalar _plotTextColor)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotTextColor_10(IntPtr nativeObj, double _plotTextColor_val0, double _plotTextColor_val1, double _plotTextColor_val2, double _plotTextColor_val3);

        // C++:  void cv::plot::Plot2d::setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPlotSize_10(IntPtr nativeObj, int _plotSizeWidth, int _plotSizeHeight);

        // C++:  void cv::plot::Plot2d::setShowGrid(bool needShowGrid)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setShowGrid_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool needShowGrid);

        // C++:  void cv::plot::Plot2d::setShowText(bool needShowText)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setShowText_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool needShowText);

        // C++:  void cv::plot::Plot2d::setGridLinesNumber(int gridLinesNumber)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setGridLinesNumber_10(IntPtr nativeObj, int gridLinesNumber);

        // C++:  void cv::plot::Plot2d::setInvertOrientation(bool _invertOrientation)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setInvertOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool _invertOrientation);

        // C++:  void cv::plot::Plot2d::setPointIdxToPrint(int pointIdx)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_setPointIdxToPrint_10(IntPtr nativeObj, int pointIdx);

        // C++:  void cv::plot::Plot2d::render(Mat& _plotResult)
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_render_10(IntPtr nativeObj, IntPtr _plotResult_nativeObj);

        // C++: static Ptr_Plot2d cv::plot::Plot2d::create(Mat data)
        [DllImport(LIBNAME)]
        private static extern IntPtr plot_Plot2d_create_10(IntPtr data_nativeObj);

        // C++: static Ptr_Plot2d cv::plot::Plot2d::create(Mat dataX, Mat dataY)
        [DllImport(LIBNAME)]
        private static extern IntPtr plot_Plot2d_create_11(IntPtr dataX_nativeObj, IntPtr dataY_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void plot_Plot2d_delete(IntPtr nativeObj);

    }
}
