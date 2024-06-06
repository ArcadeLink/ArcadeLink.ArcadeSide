

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class Dictionary
    /**
     * Dictionary/Set of markers, it contains the inner codification
     *
     * BytesList contains the marker codewords where:
     * - bytesList.rows is the dictionary size
     * - each marker is encoded using {code nbytes = ceil(markerSize*markerSize/8.)}
     * - each row contains all 4 rotations of the marker, so its length is {code 4*nbytes}
     *
     * {code bytesList.ptr(i)[k*nbytes + j]} is then the j-th byte of i-th marker, in its k-th rotation.
     */

    public class Dictionary : DisposableOpenCVObject
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
                        objdetect_Dictionary_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Dictionary(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Dictionary __fromPtr__(IntPtr addr) { return new Dictionary(addr); }

        //
        // C++:   cv::aruco::Dictionary::Dictionary()
        //

        public Dictionary()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_Dictionary_Dictionary_10());


        }


        //
        // C++:   cv::aruco::Dictionary::Dictionary(Mat bytesList, int _markerSize, int maxcorr = 0)
        //

        public Dictionary(Mat bytesList, int _markerSize, int maxcorr)
        {
            if (bytesList != null) bytesList.ThrowIfDisposed();

            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_Dictionary_Dictionary_11(bytesList.nativeObj, _markerSize, maxcorr));


        }

        public Dictionary(Mat bytesList, int _markerSize)
        {
            if (bytesList != null) bytesList.ThrowIfDisposed();

            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_Dictionary_Dictionary_12(bytesList.nativeObj, _markerSize));


        }


        //
        // C++:  bool cv::aruco::Dictionary::readDictionary(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void cv::aruco::Dictionary::writeDictionary(FileStorage fs, String name = String())
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++:  bool cv::aruco::Dictionary::identify(Mat onlyBits, int& idx, int& rotation, double maxCorrectionRate)
        //

        /**
         * Given a matrix of bits. Returns whether if marker is identified or not.
         *
         * It returns by reference the correct id (if any) and the correct rotation
         * param onlyBits automatically generated
         * param idx automatically generated
         * param rotation automatically generated
         * param maxCorrectionRate automatically generated
         * return automatically generated
         */
        public bool identify(Mat onlyBits, int[] idx, int[] rotation, double maxCorrectionRate)
        {
            ThrowIfDisposed();
            if (onlyBits != null) onlyBits.ThrowIfDisposed();
            double[] idx_out = new double[1];
            double[] rotation_out = new double[1];
            bool retVal = objdetect_Dictionary_identify_10(nativeObj, onlyBits.nativeObj, idx_out, rotation_out, maxCorrectionRate);
            if (idx != null) idx[0] = (int)idx_out[0];
            if (rotation != null) rotation[0] = (int)rotation_out[0];
            return retVal;
        }


        //
        // C++:  int cv::aruco::Dictionary::getDistanceToId(Mat bits, int id, bool allRotations = true)
        //

        /**
         * Returns the distance of the input bits to the specific id.
         *
         * If allRotations is true, the four posible bits rotation are considered
         * param bits automatically generated
         * param id automatically generated
         * param allRotations automatically generated
         * return automatically generated
         */
        public int getDistanceToId(Mat bits, int id, bool allRotations)
        {
            ThrowIfDisposed();
            if (bits != null) bits.ThrowIfDisposed();

            return objdetect_Dictionary_getDistanceToId_10(nativeObj, bits.nativeObj, id, allRotations);


        }

        /**
         * Returns the distance of the input bits to the specific id.
         *
         * If allRotations is true, the four posible bits rotation are considered
         * param bits automatically generated
         * param id automatically generated
         * return automatically generated
         */
        public int getDistanceToId(Mat bits, int id)
        {
            ThrowIfDisposed();
            if (bits != null) bits.ThrowIfDisposed();

            return objdetect_Dictionary_getDistanceToId_11(nativeObj, bits.nativeObj, id);


        }


        //
        // C++:  void cv::aruco::Dictionary::generateImageMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        //

        /**
         * Generate a canonical marker image
         * param id automatically generated
         * param sidePixels automatically generated
         * param _img automatically generated
         * param borderBits automatically generated
         */
        public void generateImageMarker(int id, int sidePixels, Mat _img, int borderBits)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();

            objdetect_Dictionary_generateImageMarker_10(nativeObj, id, sidePixels, _img.nativeObj, borderBits);


        }

        /**
         * Generate a canonical marker image
         * param id automatically generated
         * param sidePixels automatically generated
         * param _img automatically generated
         */
        public void generateImageMarker(int id, int sidePixels, Mat _img)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();

            objdetect_Dictionary_generateImageMarker_11(nativeObj, id, sidePixels, _img.nativeObj);


        }


        //
        // C++: static Mat cv::aruco::Dictionary::getByteListFromBits(Mat bits)
        //

        /**
         * Transform matrix of bits to list of bytes in the 4 rotations
         * param bits automatically generated
         * return automatically generated
         */
        public static Mat getByteListFromBits(Mat bits)
        {
            if (bits != null) bits.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(objdetect_Dictionary_getByteListFromBits_10(bits.nativeObj)));


        }


        //
        // C++: static Mat cv::aruco::Dictionary::getBitsFromByteList(Mat byteList, int markerSize)
        //

        /**
         * Transform list of bytes to matrix of bits
         * param byteList automatically generated
         * param markerSize automatically generated
         * return automatically generated
         */
        public static Mat getBitsFromByteList(Mat byteList, int markerSize)
        {
            if (byteList != null) byteList.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(objdetect_Dictionary_getBitsFromByteList_10(byteList.nativeObj, markerSize)));


        }


        //
        // C++: Mat Dictionary::bytesList
        //

        public Mat get_bytesList()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(objdetect_Dictionary_get_1bytesList_10(nativeObj)));


        }


        //
        // C++: void Dictionary::bytesList
        //

        public void set_bytesList(Mat bytesList)
        {
            ThrowIfDisposed();
            if (bytesList != null) bytesList.ThrowIfDisposed();

            objdetect_Dictionary_set_1bytesList_10(nativeObj, bytesList.nativeObj);


        }


        //
        // C++: int Dictionary::markerSize
        //

        public int get_markerSize()
        {
            ThrowIfDisposed();

            return objdetect_Dictionary_get_1markerSize_10(nativeObj);


        }


        //
        // C++: void Dictionary::markerSize
        //

        public void set_markerSize(int markerSize)
        {
            ThrowIfDisposed();

            objdetect_Dictionary_set_1markerSize_10(nativeObj, markerSize);


        }


        //
        // C++: int Dictionary::maxCorrectionBits
        //

        public int get_maxCorrectionBits()
        {
            ThrowIfDisposed();

            return objdetect_Dictionary_get_1maxCorrectionBits_10(nativeObj);


        }


        //
        // C++: void Dictionary::maxCorrectionBits
        //

        public void set_maxCorrectionBits(int maxCorrectionBits)
        {
            ThrowIfDisposed();

            objdetect_Dictionary_set_1maxCorrectionBits_10(nativeObj, maxCorrectionBits);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::Dictionary::Dictionary()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Dictionary_Dictionary_10();

        // C++:   cv::aruco::Dictionary::Dictionary(Mat bytesList, int _markerSize, int maxcorr = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Dictionary_Dictionary_11(IntPtr bytesList_nativeObj, int _markerSize, int maxcorr);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Dictionary_Dictionary_12(IntPtr bytesList_nativeObj, int _markerSize);

        // C++:  bool cv::aruco::Dictionary::identify(Mat onlyBits, int& idx, int& rotation, double maxCorrectionRate)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_Dictionary_identify_10(IntPtr nativeObj, IntPtr onlyBits_nativeObj, double[] idx_out, double[] rotation_out, double maxCorrectionRate);

        // C++:  int cv::aruco::Dictionary::getDistanceToId(Mat bits, int id, bool allRotations = true)
        [DllImport(LIBNAME)]
        private static extern int objdetect_Dictionary_getDistanceToId_10(IntPtr nativeObj, IntPtr bits_nativeObj, int id, [MarshalAs(UnmanagedType.U1)] bool allRotations);
        [DllImport(LIBNAME)]
        private static extern int objdetect_Dictionary_getDistanceToId_11(IntPtr nativeObj, IntPtr bits_nativeObj, int id);

        // C++:  void cv::aruco::Dictionary::generateImageMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void objdetect_Dictionary_generateImageMarker_10(IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Dictionary_generateImageMarker_11(IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj);

        // C++: static Mat cv::aruco::Dictionary::getByteListFromBits(Mat bits)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Dictionary_getByteListFromBits_10(IntPtr bits_nativeObj);

        // C++: static Mat cv::aruco::Dictionary::getBitsFromByteList(Mat byteList, int markerSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Dictionary_getBitsFromByteList_10(IntPtr byteList_nativeObj, int markerSize);

        // C++: Mat Dictionary::bytesList
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_Dictionary_get_1bytesList_10(IntPtr nativeObj);

        // C++: void Dictionary::bytesList
        [DllImport(LIBNAME)]
        private static extern void objdetect_Dictionary_set_1bytesList_10(IntPtr nativeObj, IntPtr bytesList_nativeObj);

        // C++: int Dictionary::markerSize
        [DllImport(LIBNAME)]
        private static extern int objdetect_Dictionary_get_1markerSize_10(IntPtr nativeObj);

        // C++: void Dictionary::markerSize
        [DllImport(LIBNAME)]
        private static extern void objdetect_Dictionary_set_1markerSize_10(IntPtr nativeObj, int markerSize);

        // C++: int Dictionary::maxCorrectionBits
        [DllImport(LIBNAME)]
        private static extern int objdetect_Dictionary_get_1maxCorrectionBits_10(IntPtr nativeObj);

        // C++: void Dictionary::maxCorrectionBits
        [DllImport(LIBNAME)]
        private static extern void objdetect_Dictionary_set_1maxCorrectionBits_10(IntPtr nativeObj, int maxCorrectionBits);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_Dictionary_delete(IntPtr nativeObj);

    }
}
