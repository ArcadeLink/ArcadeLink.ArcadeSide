

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class DetectorParameters
    /**
     * struct DetectorParameters is used by ArucoDetector
     */

    public class DetectorParameters : DisposableOpenCVObject
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
                        objdetect_DetectorParameters_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DetectorParameters(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static DetectorParameters __fromPtr__(IntPtr addr) { return new DetectorParameters(addr); }

        //
        // C++:   cv::aruco::DetectorParameters::DetectorParameters()
        //

        public DetectorParameters()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_DetectorParameters_DetectorParameters_10());


        }


        //
        // C++:  bool cv::aruco::DetectorParameters::readDetectorParameters(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  bool cv::aruco::DetectorParameters::writeDetectorParameters(FileStorage fs, String name = String())
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeMin
        //

        public int get_adaptiveThreshWinSizeMin()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1adaptiveThreshWinSizeMin_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeMin
        //

        public void set_adaptiveThreshWinSizeMin(int adaptiveThreshWinSizeMin)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1adaptiveThreshWinSizeMin_10(nativeObj, adaptiveThreshWinSizeMin);


        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeMax
        //

        public int get_adaptiveThreshWinSizeMax()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1adaptiveThreshWinSizeMax_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeMax
        //

        public void set_adaptiveThreshWinSizeMax(int adaptiveThreshWinSizeMax)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1adaptiveThreshWinSizeMax_10(nativeObj, adaptiveThreshWinSizeMax);


        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeStep
        //

        public int get_adaptiveThreshWinSizeStep()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1adaptiveThreshWinSizeStep_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeStep
        //

        public void set_adaptiveThreshWinSizeStep(int adaptiveThreshWinSizeStep)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1adaptiveThreshWinSizeStep_10(nativeObj, adaptiveThreshWinSizeStep);


        }


        //
        // C++: double DetectorParameters::adaptiveThreshConstant
        //

        public double get_adaptiveThreshConstant()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1adaptiveThreshConstant_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshConstant
        //

        public void set_adaptiveThreshConstant(double adaptiveThreshConstant)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1adaptiveThreshConstant_10(nativeObj, adaptiveThreshConstant);


        }


        //
        // C++: double DetectorParameters::minMarkerPerimeterRate
        //

        public double get_minMarkerPerimeterRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minMarkerPerimeterRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minMarkerPerimeterRate
        //

        public void set_minMarkerPerimeterRate(double minMarkerPerimeterRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minMarkerPerimeterRate_10(nativeObj, minMarkerPerimeterRate);


        }


        //
        // C++: double DetectorParameters::maxMarkerPerimeterRate
        //

        public double get_maxMarkerPerimeterRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1maxMarkerPerimeterRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::maxMarkerPerimeterRate
        //

        public void set_maxMarkerPerimeterRate(double maxMarkerPerimeterRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1maxMarkerPerimeterRate_10(nativeObj, maxMarkerPerimeterRate);


        }


        //
        // C++: double DetectorParameters::polygonalApproxAccuracyRate
        //

        public double get_polygonalApproxAccuracyRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1polygonalApproxAccuracyRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::polygonalApproxAccuracyRate
        //

        public void set_polygonalApproxAccuracyRate(double polygonalApproxAccuracyRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1polygonalApproxAccuracyRate_10(nativeObj, polygonalApproxAccuracyRate);


        }


        //
        // C++: double DetectorParameters::minCornerDistanceRate
        //

        public double get_minCornerDistanceRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minCornerDistanceRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minCornerDistanceRate
        //

        public void set_minCornerDistanceRate(double minCornerDistanceRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minCornerDistanceRate_10(nativeObj, minCornerDistanceRate);


        }


        //
        // C++: int DetectorParameters::minDistanceToBorder
        //

        public int get_minDistanceToBorder()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minDistanceToBorder_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minDistanceToBorder
        //

        public void set_minDistanceToBorder(int minDistanceToBorder)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minDistanceToBorder_10(nativeObj, minDistanceToBorder);


        }


        //
        // C++: double DetectorParameters::minMarkerDistanceRate
        //

        public double get_minMarkerDistanceRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minMarkerDistanceRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minMarkerDistanceRate
        //

        public void set_minMarkerDistanceRate(double minMarkerDistanceRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minMarkerDistanceRate_10(nativeObj, minMarkerDistanceRate);


        }


        //
        // C++: int DetectorParameters::cornerRefinementMethod
        //

        public int get_cornerRefinementMethod()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1cornerRefinementMethod_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementMethod
        //

        public void set_cornerRefinementMethod(int cornerRefinementMethod)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1cornerRefinementMethod_10(nativeObj, cornerRefinementMethod);


        }


        //
        // C++: int DetectorParameters::cornerRefinementWinSize
        //

        public int get_cornerRefinementWinSize()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1cornerRefinementWinSize_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementWinSize
        //

        public void set_cornerRefinementWinSize(int cornerRefinementWinSize)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1cornerRefinementWinSize_10(nativeObj, cornerRefinementWinSize);


        }


        //
        // C++: int DetectorParameters::cornerRefinementMaxIterations
        //

        public int get_cornerRefinementMaxIterations()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1cornerRefinementMaxIterations_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementMaxIterations
        //

        public void set_cornerRefinementMaxIterations(int cornerRefinementMaxIterations)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1cornerRefinementMaxIterations_10(nativeObj, cornerRefinementMaxIterations);


        }


        //
        // C++: double DetectorParameters::cornerRefinementMinAccuracy
        //

        public double get_cornerRefinementMinAccuracy()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1cornerRefinementMinAccuracy_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementMinAccuracy
        //

        public void set_cornerRefinementMinAccuracy(double cornerRefinementMinAccuracy)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1cornerRefinementMinAccuracy_10(nativeObj, cornerRefinementMinAccuracy);


        }


        //
        // C++: int DetectorParameters::markerBorderBits
        //

        public int get_markerBorderBits()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1markerBorderBits_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::markerBorderBits
        //

        public void set_markerBorderBits(int markerBorderBits)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1markerBorderBits_10(nativeObj, markerBorderBits);


        }


        //
        // C++: int DetectorParameters::perspectiveRemovePixelPerCell
        //

        public int get_perspectiveRemovePixelPerCell()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1perspectiveRemovePixelPerCell_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::perspectiveRemovePixelPerCell
        //

        public void set_perspectiveRemovePixelPerCell(int perspectiveRemovePixelPerCell)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1perspectiveRemovePixelPerCell_10(nativeObj, perspectiveRemovePixelPerCell);


        }


        //
        // C++: double DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        //

        public double get_perspectiveRemoveIgnoredMarginPerCell()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1perspectiveRemoveIgnoredMarginPerCell_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        //

        public void set_perspectiveRemoveIgnoredMarginPerCell(double perspectiveRemoveIgnoredMarginPerCell)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1perspectiveRemoveIgnoredMarginPerCell_10(nativeObj, perspectiveRemoveIgnoredMarginPerCell);


        }


        //
        // C++: double DetectorParameters::maxErroneousBitsInBorderRate
        //

        public double get_maxErroneousBitsInBorderRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1maxErroneousBitsInBorderRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::maxErroneousBitsInBorderRate
        //

        public void set_maxErroneousBitsInBorderRate(double maxErroneousBitsInBorderRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1maxErroneousBitsInBorderRate_10(nativeObj, maxErroneousBitsInBorderRate);


        }


        //
        // C++: double DetectorParameters::minOtsuStdDev
        //

        public double get_minOtsuStdDev()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minOtsuStdDev_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minOtsuStdDev
        //

        public void set_minOtsuStdDev(double minOtsuStdDev)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minOtsuStdDev_10(nativeObj, minOtsuStdDev);


        }


        //
        // C++: double DetectorParameters::errorCorrectionRate
        //

        public double get_errorCorrectionRate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1errorCorrectionRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::errorCorrectionRate
        //

        public void set_errorCorrectionRate(double errorCorrectionRate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1errorCorrectionRate_10(nativeObj, errorCorrectionRate);


        }


        //
        // C++: float DetectorParameters::aprilTagQuadDecimate
        //

        public float get_aprilTagQuadDecimate()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagQuadDecimate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagQuadDecimate
        //

        public void set_aprilTagQuadDecimate(float aprilTagQuadDecimate)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagQuadDecimate_10(nativeObj, aprilTagQuadDecimate);


        }


        //
        // C++: float DetectorParameters::aprilTagQuadSigma
        //

        public float get_aprilTagQuadSigma()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagQuadSigma_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagQuadSigma
        //

        public void set_aprilTagQuadSigma(float aprilTagQuadSigma)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagQuadSigma_10(nativeObj, aprilTagQuadSigma);


        }


        //
        // C++: int DetectorParameters::aprilTagMinClusterPixels
        //

        public int get_aprilTagMinClusterPixels()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagMinClusterPixels_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMinClusterPixels
        //

        public void set_aprilTagMinClusterPixels(int aprilTagMinClusterPixels)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagMinClusterPixels_10(nativeObj, aprilTagMinClusterPixels);


        }


        //
        // C++: int DetectorParameters::aprilTagMaxNmaxima
        //

        public int get_aprilTagMaxNmaxima()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagMaxNmaxima_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMaxNmaxima
        //

        public void set_aprilTagMaxNmaxima(int aprilTagMaxNmaxima)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagMaxNmaxima_10(nativeObj, aprilTagMaxNmaxima);


        }


        //
        // C++: float DetectorParameters::aprilTagCriticalRad
        //

        public float get_aprilTagCriticalRad()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagCriticalRad_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagCriticalRad
        //

        public void set_aprilTagCriticalRad(float aprilTagCriticalRad)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagCriticalRad_10(nativeObj, aprilTagCriticalRad);


        }


        //
        // C++: float DetectorParameters::aprilTagMaxLineFitMse
        //

        public float get_aprilTagMaxLineFitMse()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagMaxLineFitMse_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMaxLineFitMse
        //

        public void set_aprilTagMaxLineFitMse(float aprilTagMaxLineFitMse)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagMaxLineFitMse_10(nativeObj, aprilTagMaxLineFitMse);


        }


        //
        // C++: int DetectorParameters::aprilTagMinWhiteBlackDiff
        //

        public int get_aprilTagMinWhiteBlackDiff()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagMinWhiteBlackDiff_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMinWhiteBlackDiff
        //

        public void set_aprilTagMinWhiteBlackDiff(int aprilTagMinWhiteBlackDiff)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagMinWhiteBlackDiff_10(nativeObj, aprilTagMinWhiteBlackDiff);


        }


        //
        // C++: int DetectorParameters::aprilTagDeglitch
        //

        public int get_aprilTagDeglitch()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1aprilTagDeglitch_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagDeglitch
        //

        public void set_aprilTagDeglitch(int aprilTagDeglitch)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1aprilTagDeglitch_10(nativeObj, aprilTagDeglitch);


        }


        //
        // C++: bool DetectorParameters::detectInvertedMarker
        //

        public bool get_detectInvertedMarker()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1detectInvertedMarker_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::detectInvertedMarker
        //

        public void set_detectInvertedMarker(bool detectInvertedMarker)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1detectInvertedMarker_10(nativeObj, detectInvertedMarker);


        }


        //
        // C++: bool DetectorParameters::useAruco3Detection
        //

        public bool get_useAruco3Detection()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1useAruco3Detection_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::useAruco3Detection
        //

        public void set_useAruco3Detection(bool useAruco3Detection)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1useAruco3Detection_10(nativeObj, useAruco3Detection);


        }


        //
        // C++: int DetectorParameters::minSideLengthCanonicalImg
        //

        public int get_minSideLengthCanonicalImg()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minSideLengthCanonicalImg_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minSideLengthCanonicalImg
        //

        public void set_minSideLengthCanonicalImg(int minSideLengthCanonicalImg)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minSideLengthCanonicalImg_10(nativeObj, minSideLengthCanonicalImg);


        }


        //
        // C++: float DetectorParameters::minMarkerLengthRatioOriginalImg
        //

        public float get_minMarkerLengthRatioOriginalImg()
        {
            ThrowIfDisposed();

            return objdetect_DetectorParameters_get_1minMarkerLengthRatioOriginalImg_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minMarkerLengthRatioOriginalImg
        //

        public void set_minMarkerLengthRatioOriginalImg(float minMarkerLengthRatioOriginalImg)
        {
            ThrowIfDisposed();

            objdetect_DetectorParameters_set_1minMarkerLengthRatioOriginalImg_10(nativeObj, minMarkerLengthRatioOriginalImg);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::DetectorParameters::DetectorParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_DetectorParameters_DetectorParameters_10();

        // C++: int DetectorParameters::adaptiveThreshWinSizeMin
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1adaptiveThreshWinSizeMin_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeMin
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1adaptiveThreshWinSizeMin_10(IntPtr nativeObj, int adaptiveThreshWinSizeMin);

        // C++: int DetectorParameters::adaptiveThreshWinSizeMax
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1adaptiveThreshWinSizeMax_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeMax
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1adaptiveThreshWinSizeMax_10(IntPtr nativeObj, int adaptiveThreshWinSizeMax);

        // C++: int DetectorParameters::adaptiveThreshWinSizeStep
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1adaptiveThreshWinSizeStep_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeStep
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1adaptiveThreshWinSizeStep_10(IntPtr nativeObj, int adaptiveThreshWinSizeStep);

        // C++: double DetectorParameters::adaptiveThreshConstant
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1adaptiveThreshConstant_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshConstant
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1adaptiveThreshConstant_10(IntPtr nativeObj, double adaptiveThreshConstant);

        // C++: double DetectorParameters::minMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1minMarkerPerimeterRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minMarkerPerimeterRate_10(IntPtr nativeObj, double minMarkerPerimeterRate);

        // C++: double DetectorParameters::maxMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1maxMarkerPerimeterRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::maxMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1maxMarkerPerimeterRate_10(IntPtr nativeObj, double maxMarkerPerimeterRate);

        // C++: double DetectorParameters::polygonalApproxAccuracyRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1polygonalApproxAccuracyRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::polygonalApproxAccuracyRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1polygonalApproxAccuracyRate_10(IntPtr nativeObj, double polygonalApproxAccuracyRate);

        // C++: double DetectorParameters::minCornerDistanceRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1minCornerDistanceRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minCornerDistanceRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minCornerDistanceRate_10(IntPtr nativeObj, double minCornerDistanceRate);

        // C++: int DetectorParameters::minDistanceToBorder
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1minDistanceToBorder_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minDistanceToBorder
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minDistanceToBorder_10(IntPtr nativeObj, int minDistanceToBorder);

        // C++: double DetectorParameters::minMarkerDistanceRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1minMarkerDistanceRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerDistanceRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minMarkerDistanceRate_10(IntPtr nativeObj, double minMarkerDistanceRate);

        // C++: int DetectorParameters::cornerRefinementMethod
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1cornerRefinementMethod_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMethod
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1cornerRefinementMethod_10(IntPtr nativeObj, int cornerRefinementMethod);

        // C++: int DetectorParameters::cornerRefinementWinSize
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1cornerRefinementWinSize_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementWinSize
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1cornerRefinementWinSize_10(IntPtr nativeObj, int cornerRefinementWinSize);

        // C++: int DetectorParameters::cornerRefinementMaxIterations
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1cornerRefinementMaxIterations_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMaxIterations
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1cornerRefinementMaxIterations_10(IntPtr nativeObj, int cornerRefinementMaxIterations);

        // C++: double DetectorParameters::cornerRefinementMinAccuracy
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1cornerRefinementMinAccuracy_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMinAccuracy
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1cornerRefinementMinAccuracy_10(IntPtr nativeObj, double cornerRefinementMinAccuracy);

        // C++: int DetectorParameters::markerBorderBits
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1markerBorderBits_10(IntPtr nativeObj);

        // C++: void DetectorParameters::markerBorderBits
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1markerBorderBits_10(IntPtr nativeObj, int markerBorderBits);

        // C++: int DetectorParameters::perspectiveRemovePixelPerCell
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1perspectiveRemovePixelPerCell_10(IntPtr nativeObj);

        // C++: void DetectorParameters::perspectiveRemovePixelPerCell
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1perspectiveRemovePixelPerCell_10(IntPtr nativeObj, int perspectiveRemovePixelPerCell);

        // C++: double DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1perspectiveRemoveIgnoredMarginPerCell_10(IntPtr nativeObj);

        // C++: void DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1perspectiveRemoveIgnoredMarginPerCell_10(IntPtr nativeObj, double perspectiveRemoveIgnoredMarginPerCell);

        // C++: double DetectorParameters::maxErroneousBitsInBorderRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1maxErroneousBitsInBorderRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::maxErroneousBitsInBorderRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1maxErroneousBitsInBorderRate_10(IntPtr nativeObj, double maxErroneousBitsInBorderRate);

        // C++: double DetectorParameters::minOtsuStdDev
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1minOtsuStdDev_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minOtsuStdDev
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minOtsuStdDev_10(IntPtr nativeObj, double minOtsuStdDev);

        // C++: double DetectorParameters::errorCorrectionRate
        [DllImport(LIBNAME)]
        private static extern double objdetect_DetectorParameters_get_1errorCorrectionRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::errorCorrectionRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1errorCorrectionRate_10(IntPtr nativeObj, double errorCorrectionRate);

        // C++: float DetectorParameters::aprilTagQuadDecimate
        [DllImport(LIBNAME)]
        private static extern float objdetect_DetectorParameters_get_1aprilTagQuadDecimate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagQuadDecimate
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagQuadDecimate_10(IntPtr nativeObj, float aprilTagQuadDecimate);

        // C++: float DetectorParameters::aprilTagQuadSigma
        [DllImport(LIBNAME)]
        private static extern float objdetect_DetectorParameters_get_1aprilTagQuadSigma_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagQuadSigma
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagQuadSigma_10(IntPtr nativeObj, float aprilTagQuadSigma);

        // C++: int DetectorParameters::aprilTagMinClusterPixels
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1aprilTagMinClusterPixels_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMinClusterPixels
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagMinClusterPixels_10(IntPtr nativeObj, int aprilTagMinClusterPixels);

        // C++: int DetectorParameters::aprilTagMaxNmaxima
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1aprilTagMaxNmaxima_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMaxNmaxima
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagMaxNmaxima_10(IntPtr nativeObj, int aprilTagMaxNmaxima);

        // C++: float DetectorParameters::aprilTagCriticalRad
        [DllImport(LIBNAME)]
        private static extern float objdetect_DetectorParameters_get_1aprilTagCriticalRad_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagCriticalRad
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagCriticalRad_10(IntPtr nativeObj, float aprilTagCriticalRad);

        // C++: float DetectorParameters::aprilTagMaxLineFitMse
        [DllImport(LIBNAME)]
        private static extern float objdetect_DetectorParameters_get_1aprilTagMaxLineFitMse_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMaxLineFitMse
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagMaxLineFitMse_10(IntPtr nativeObj, float aprilTagMaxLineFitMse);

        // C++: int DetectorParameters::aprilTagMinWhiteBlackDiff
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1aprilTagMinWhiteBlackDiff_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMinWhiteBlackDiff
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagMinWhiteBlackDiff_10(IntPtr nativeObj, int aprilTagMinWhiteBlackDiff);

        // C++: int DetectorParameters::aprilTagDeglitch
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1aprilTagDeglitch_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagDeglitch
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1aprilTagDeglitch_10(IntPtr nativeObj, int aprilTagDeglitch);

        // C++: bool DetectorParameters::detectInvertedMarker
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_DetectorParameters_get_1detectInvertedMarker_10(IntPtr nativeObj);

        // C++: void DetectorParameters::detectInvertedMarker
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1detectInvertedMarker_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool detectInvertedMarker);

        // C++: bool DetectorParameters::useAruco3Detection
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_DetectorParameters_get_1useAruco3Detection_10(IntPtr nativeObj);

        // C++: void DetectorParameters::useAruco3Detection
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1useAruco3Detection_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool useAruco3Detection);

        // C++: int DetectorParameters::minSideLengthCanonicalImg
        [DllImport(LIBNAME)]
        private static extern int objdetect_DetectorParameters_get_1minSideLengthCanonicalImg_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minSideLengthCanonicalImg
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minSideLengthCanonicalImg_10(IntPtr nativeObj, int minSideLengthCanonicalImg);

        // C++: float DetectorParameters::minMarkerLengthRatioOriginalImg
        [DllImport(LIBNAME)]
        private static extern float objdetect_DetectorParameters_get_1minMarkerLengthRatioOriginalImg_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerLengthRatioOriginalImg
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_set_1minMarkerLengthRatioOriginalImg_10(IntPtr nativeObj, float minMarkerLengthRatioOriginalImg);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_DetectorParameters_delete(IntPtr nativeObj);

    }
}
