

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoioModule
{
    // C++: class VideoWriter
    /**
     * Video writer class.
     *
     * The class provides C++ API for writing video files or image sequences.
     */

    public class VideoWriter : DisposableOpenCVObject
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
                        videoio_VideoWriter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VideoWriter(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static VideoWriter __fromPtr__(IntPtr addr) { return new VideoWriter(addr); }

        //
        // C++:   cv::VideoWriter::VideoWriter()
        //

        /**
         * Default constructors
         *
         *     The constructors/functions initialize video writers.
         * <ul>
         *   <li>
         *        On Linux FFMPEG is used to write videos;
         *   </li>
         *   <li>
         *        On Windows FFMPEG or MSWF or DSHOW is used;
         *   </li>
         *   <li>
         *        On MacOSX AVFoundation is used.
         *   </li>
         * </ul>
         */
        public VideoWriter()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_10());


        }


        //
        // C++:   cv::VideoWriter::VideoWriter(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        /**
         *
         *     param filename Name of the output video file.
         *     param fourcc 4-character code of codec used to compress the frames. For example,
         *     VideoWriter::fourcc('P','I','M','1') is a MPEG-1 codec, VideoWriter::fourcc('M','J','P','G')
         *     is a motion-jpeg codec etc. List of codes can be obtained at
         *     [MSDN](https://docs.microsoft.com/en-us/windows/win32/medfound/video-fourccs) page
         *     or with this [archived page](https://web.archive.org/web/20220316062600/http://www.fourcc.org/codecs.php)
         *     of the fourcc site for a more complete list). FFMPEG backend with MP4 container natively uses
         *     other values as fourcc code: see [ObjectType](http://mp4ra.org/#/codecs),
         *     so you may receive a warning message from OpenCV about fourcc code conversion.
         *     param fps Framerate of the created video stream.
         *     param frameSize Size of the video frames.
         *     param isColor If it is not zero, the encoder will expect and encode color frames, otherwise it
         *     will work with grayscale frames.
         *
         *     <b>Tips</b>:
         * <ul>
         *   <li>
         *      With some backends {code fourcc=-1} pops up the codec selection dialog from the system.
         *   </li>
         *   <li>
         *      To save image sequence use a proper filename (eg. {code img_%02d.jpg}) and {code fourcc=0}
         *       OR {code fps=0}. Use uncompressed image format (eg. {code img_%02d.BMP}) to save raw frames.
         *   </li>
         *   <li>
         *      Most codecs are lossy. If you want lossless video file you need to use a lossless codecs
         *       (eg. FFMPEG FFV1, Huffman HFYU, Lagarith LAGS, etc...)
         *   </li>
         *   <li>
         *      If FFMPEG is enabled, using {code codec=0; fps=0;} you can create an uncompressed (raw) video file.
         *   </li>
         * </ul>
         */
        public VideoWriter(string filename, int fourcc, double fps, Size frameSize, bool isColor)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_11(filename, fourcc, fps, frameSize.width, frameSize.height, isColor));


        }

        /**
         *
         *     param filename Name of the output video file.
         *     param fourcc 4-character code of codec used to compress the frames. For example,
         *     VideoWriter::fourcc('P','I','M','1') is a MPEG-1 codec, VideoWriter::fourcc('M','J','P','G')
         *     is a motion-jpeg codec etc. List of codes can be obtained at
         *     [MSDN](https://docs.microsoft.com/en-us/windows/win32/medfound/video-fourccs) page
         *     or with this [archived page](https://web.archive.org/web/20220316062600/http://www.fourcc.org/codecs.php)
         *     of the fourcc site for a more complete list). FFMPEG backend with MP4 container natively uses
         *     other values as fourcc code: see [ObjectType](http://mp4ra.org/#/codecs),
         *     so you may receive a warning message from OpenCV about fourcc code conversion.
         *     param fps Framerate of the created video stream.
         *     param frameSize Size of the video frames.
         *     will work with grayscale frames.
         *
         *     <b>Tips</b>:
         * <ul>
         *   <li>
         *      With some backends {code fourcc=-1} pops up the codec selection dialog from the system.
         *   </li>
         *   <li>
         *      To save image sequence use a proper filename (eg. {code img_%02d.jpg}) and {code fourcc=0}
         *       OR {code fps=0}. Use uncompressed image format (eg. {code img_%02d.BMP}) to save raw frames.
         *   </li>
         *   <li>
         *      Most codecs are lossy. If you want lossless video file you need to use a lossless codecs
         *       (eg. FFMPEG FFV1, Huffman HFYU, Lagarith LAGS, etc...)
         *   </li>
         *   <li>
         *      If FFMPEG is enabled, using {code codec=0; fps=0;} you can create an uncompressed (raw) video file.
         *   </li>
         * </ul>
         */
        public VideoWriter(string filename, int fourcc, double fps, Size frameSize)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_12(filename, fourcc, fps, frameSize.width, frameSize.height));


        }


        //
        // C++:   cv::VideoWriter::VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        /**
         *
         *     The {code apiPreference} parameter allows to specify API backends to use. Can be used to enforce a specific reader implementation
         *     if multiple are available: e.g. cv::CAP_FFMPEG or cv::CAP_GSTREAMER.
         * param filename automatically generated
         * param apiPreference automatically generated
         * param fourcc automatically generated
         * param fps automatically generated
         * param frameSize automatically generated
         * param isColor automatically generated
         */
        public VideoWriter(string filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_13(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, isColor));


        }

        /**
         *
         *     The {code apiPreference} parameter allows to specify API backends to use. Can be used to enforce a specific reader implementation
         *     if multiple are available: e.g. cv::CAP_FFMPEG or cv::CAP_GSTREAMER.
         * param filename automatically generated
         * param apiPreference automatically generated
         * param fourcc automatically generated
         * param fps automatically generated
         * param frameSize automatically generated
         */
        public VideoWriter(string filename, int apiPreference, int fourcc, double fps, Size frameSize)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_14(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height));


        }


        //
        // C++:   cv::VideoWriter::VideoWriter(String filename, int fourcc, double fps, Size frameSize, vector_int _params)
        //

        /**
         *
         * The {code params} parameter allows to specify extra encoder parameters encoded as pairs (paramId_1, paramValue_1, paramId_2, paramValue_2, ... .)
         * see cv::VideoWriterProperties
         * param filename automatically generated
         * param fourcc automatically generated
         * param fps automatically generated
         * param frameSize automatically generated
         * param _params automatically generated
         */
        public VideoWriter(string filename, int fourcc, double fps, Size frameSize, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_15(filename, fourcc, fps, frameSize.width, frameSize.height, _params_mat.nativeObj));


        }


        //
        // C++:   cv::VideoWriter::VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, vector_int _params)
        //

        public VideoWriter(string filename, int apiPreference, int fourcc, double fps, Size frameSize, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_VideoWriter_16(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, _params_mat.nativeObj));


        }


        //
        // C++:  bool cv::VideoWriter::open(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        /**
         * Initializes or reinitializes video writer.
         *
         *     The method opens video writer. Parameters are the same as in the constructor
         *     VideoWriter::VideoWriter.
         *     return {code true} if video writer has been successfully initialized
         *
         *     The method first calls VideoWriter::release to close the already opened file.
         * param filename automatically generated
         * param fourcc automatically generated
         * param fps automatically generated
         * param frameSize automatically generated
         * param isColor automatically generated
         */
        public bool open(string filename, int fourcc, double fps, Size frameSize, bool isColor)
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_open_10(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height, isColor);


        }

        /**
         * Initializes or reinitializes video writer.
         *
         *     The method opens video writer. Parameters are the same as in the constructor
         *     VideoWriter::VideoWriter.
         *     return {code true} if video writer has been successfully initialized
         *
         *     The method first calls VideoWriter::release to close the already opened file.
         * param filename automatically generated
         * param fourcc automatically generated
         * param fps automatically generated
         * param frameSize automatically generated
         */
        public bool open(string filename, int fourcc, double fps, Size frameSize)
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_open_11(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height);


        }


        //
        // C++:  bool cv::VideoWriter::open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        public bool open(string filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor)
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_open_12(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, isColor);


        }

        public bool open(string filename, int apiPreference, int fourcc, double fps, Size frameSize)
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_open_13(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height);


        }


        //
        // C++:  bool cv::VideoWriter::open(String filename, int fourcc, double fps, Size frameSize, vector_int _params)
        //

        public bool open(string filename, int fourcc, double fps, Size frameSize, MatOfInt _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return videoio_VideoWriter_open_14(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height, _params_mat.nativeObj);


        }


        //
        // C++:  bool cv::VideoWriter::open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, vector_int _params)
        //

        public bool open(string filename, int apiPreference, int fourcc, double fps, Size frameSize, MatOfInt _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return videoio_VideoWriter_open_15(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, _params_mat.nativeObj);


        }


        //
        // C++:  bool cv::VideoWriter::isOpened()
        //

        /**
         * Returns true if video writer has been successfully initialized.
         * return automatically generated
         */
        public bool isOpened()
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_isOpened_10(nativeObj);


        }


        //
        // C++:  void cv::VideoWriter::release()
        //

        /**
         * Closes the video writer.
         *
         *     The method is automatically called by subsequent VideoWriter::open and by the VideoWriter
         *     destructor.
         */
        public void release()
        {
            ThrowIfDisposed();

            videoio_VideoWriter_release_10(nativeObj);


        }


        //
        // C++:  void cv::VideoWriter::write(Mat image)
        //

        /**
         * Writes the next video frame
         *
         *     param image The written frame. In general, color images are expected in BGR format.
         *
         *     The function/method writes the specified image to video file. It must have the same size as has
         *     been specified when opening the video writer.
         */
        public void write(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            videoio_VideoWriter_write_10(nativeObj, image.nativeObj);


        }


        //
        // C++:  bool cv::VideoWriter::set(int propId, double value)
        //

        /**
         * Sets a property in the VideoWriter.
         *
         *      param propId Property identifier from cv::VideoWriterProperties (eg. cv::VIDEOWRITER_PROP_QUALITY)
         *      or one of REF: videoio_flags_others
         *
         *      param value Value of the property.
         *      return  {code true} if the property is supported by the backend used by the VideoWriter instance.
         */
        public bool set(int propId, double value)
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_set_10(nativeObj, propId, value);


        }


        //
        // C++:  double cv::VideoWriter::get(int propId)
        //

        /**
         * Returns the specified VideoWriter property
         *
         *      param propId Property identifier from cv::VideoWriterProperties (eg. cv::VIDEOWRITER_PROP_QUALITY)
         *      or one of REF: videoio_flags_others
         *
         *      return Value for the specified property. Value 0 is returned when querying a property that is
         *      not supported by the backend used by the VideoWriter instance.
         */
        public double get(int propId)
        {
            ThrowIfDisposed();

            return videoio_VideoWriter_get_10(nativeObj, propId);


        }


        //
        // C++: static int cv::VideoWriter::fourcc(char c1, char c2, char c3, char c4)
        //

        /**
         * Concatenates 4 chars to a fourcc code
         *
         *     return a fourcc code
         *
         *     This static method constructs the fourcc code of the codec to be used in the constructor
         *     VideoWriter::VideoWriter or VideoWriter::open.
         * param c1 automatically generated
         * param c2 automatically generated
         * param c3 automatically generated
         * param c4 automatically generated
         */
        public static int fourcc(char c1, char c2, char c3, char c4)
        {


            return videoio_VideoWriter_fourcc_10(c1, c2, c3, c4);


        }


        //
        // C++:  String cv::VideoWriter::getBackendName()
        //

        /**
         * Returns used backend API name
         *
         *      <b>Note:</b> Stream should be opened.
         * return automatically generated
         */
        public string getBackendName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(videoio_VideoWriter_getBackendName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::VideoWriter::VideoWriter()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_10();

        // C++:   cv::VideoWriter::VideoWriter(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_11(string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_12(string filename, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:   cv::VideoWriter::VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_13(string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_14(string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:   cv::VideoWriter::VideoWriter(String filename, int fourcc, double fps, Size frameSize, vector_int _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_15(string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, IntPtr _params_mat_nativeObj);

        // C++:   cv::VideoWriter::VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, vector_int _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_16(string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoWriter::open(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_10(IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_11(IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:  bool cv::VideoWriter::open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_12(IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_13(IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:  bool cv::VideoWriter::open(String filename, int fourcc, double fps, Size frameSize, vector_int _params)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_14(IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoWriter::open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, vector_int _params)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_15(IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoWriter::isOpened()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_isOpened_10(IntPtr nativeObj);

        // C++:  void cv::VideoWriter::release()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoWriter_release_10(IntPtr nativeObj);

        // C++:  void cv::VideoWriter::write(Mat image)
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoWriter_write_10(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoWriter::set(int propId, double value)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_set_10(IntPtr nativeObj, int propId, double value);

        // C++:  double cv::VideoWriter::get(int propId)
        [DllImport(LIBNAME)]
        private static extern double videoio_VideoWriter_get_10(IntPtr nativeObj, int propId);

        // C++: static int cv::VideoWriter::fourcc(char c1, char c2, char c3, char c4)
        [DllImport(LIBNAME)]
        private static extern int videoio_VideoWriter_fourcc_10(char c1, char c2, char c3, char c4);

        // C++:  String cv::VideoWriter::getBackendName()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_getBackendName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoWriter_delete(IntPtr nativeObj);

    }
}
