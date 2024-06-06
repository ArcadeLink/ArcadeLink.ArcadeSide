

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoioModule
{
    // C++: class VideoCapture
    /**
     * Class for video capturing from video files, image sequences or cameras.
     *
     * The class provides C++ API for capturing video from cameras or for reading video files and image sequences.
     *
     * Here is how the class can be used:
     * INCLUDE: samples/cpp/videocapture_basic.cpp
     *
     * <b>Note:</b> In REF: videoio_c "C API" the black-box structure {code CvCapture} is used instead of %VideoCapture.
     * <b>Note:</b>
     * <ul>
     *   <li>
     *    (C++) A basic sample on using the %VideoCapture interface can be found at
     *     {code OPENCV_SOURCE_CODE/samples/cpp/videocapture_starter.cpp}
     *   </li>
     *   <li>
     *    (Python) A basic sample on using the %VideoCapture interface can be found at
     *     {code OPENCV_SOURCE_CODE/samples/python/video.py}
     *   </li>
     *   <li>
     *    (Python) A multi threaded video processing sample can be found at
     *     {code OPENCV_SOURCE_CODE/samples/python/video_threaded.py}
     *   </li>
     *   <li>
     *    (Python) %VideoCapture sample showcasing some features of the Video4Linux2 backend
     *     {code OPENCV_SOURCE_CODE/samples/python/video_v4l2.py}
     *   </li>
     * </ul>
     */

    public class VideoCapture : DisposableOpenCVObject
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
                        videoio_VideoCapture_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VideoCapture(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static VideoCapture __fromPtr__(IntPtr addr) { return new VideoCapture(addr); }

        //
        // C++:   cv::VideoCapture::VideoCapture()
        //

        /**
         * Default constructor
         *     <b>Note:</b> In REF: videoio_c "C API", when you finished working with video, release CvCapture structure with
         *     cvReleaseCapture(), or use Ptr&lt;CvCapture&gt; that calls cvReleaseCapture() automatically in the
         *     destructor.
         */
        public VideoCapture()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_10());


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference = CAP_ANY)
        //

        /**
         *
         *      Opens a video file or a capturing device or an IP video stream for video capturing with API Preference
         *
         *     param filename it can be:
         * <ul>
         *   <li>
         *      name of video file (eg. {code video.avi})
         *   </li>
         *   <li>
         *      or image sequence (eg. {code img_%02d.jpg}, which will read samples like {code img_00.jpg, img_01.jpg, img_02.jpg, ...})
         *   </li>
         *   <li>
         *      or URL of video stream (eg. {code protocol://host:port/script_name?script_params|auth})
         *   </li>
         *   <li>
         *      or GStreamer pipeline string in gst-launch tool format in case if GStreamer is used as backend
         *       Note that each video stream or IP camera feed has its own URL scheme. Please refer to the
         *       documentation of source stream to know the right URL.
         *   </li>
         * </ul>
         *     param apiPreference preferred Capture API backends to use. Can be used to enforce a specific reader
         *     implementation if multiple are available: e.g. cv::CAP_FFMPEG or cv::CAP_IMAGES or cv::CAP_DSHOW.
         *
         *     SEE: cv::VideoCaptureAPIs
         */
        public VideoCapture(string filename, int apiPreference)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_11(filename, apiPreference));


        }

        /**
         *
         *      Opens a video file or a capturing device or an IP video stream for video capturing with API Preference
         *
         *     param filename it can be:
         * <ul>
         *   <li>
         *      name of video file (eg. {code video.avi})
         *   </li>
         *   <li>
         *      or image sequence (eg. {code img_%02d.jpg}, which will read samples like {code img_00.jpg, img_01.jpg, img_02.jpg, ...})
         *   </li>
         *   <li>
         *      or URL of video stream (eg. {code protocol://host:port/script_name?script_params|auth})
         *   </li>
         *   <li>
         *      or GStreamer pipeline string in gst-launch tool format in case if GStreamer is used as backend
         *       Note that each video stream or IP camera feed has its own URL scheme. Please refer to the
         *       documentation of source stream to know the right URL.
         *   </li>
         * </ul>
         *     implementation if multiple are available: e.g. cv::CAP_FFMPEG or cv::CAP_IMAGES or cv::CAP_DSHOW.
         *
         *     SEE: cv::VideoCaptureAPIs
         */
        public VideoCapture(string filename)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_12(filename));


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference, vector_int _params)
        //

        /**
         *
         *     Opens a video file or a capturing device or an IP video stream for video capturing with API Preference and parameters
         *
         *     The {code params} parameter allows to specify extra parameters encoded as pairs {code (paramId_1, paramValue_1, paramId_2, paramValue_2, ...)}.
         *     See cv::VideoCaptureProperties
         * param filename automatically generated
         * param apiPreference automatically generated
         * param _params automatically generated
         */
        public VideoCapture(string filename, int apiPreference, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_13(filename, apiPreference, _params_mat.nativeObj));


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference = CAP_ANY)
        //

        /**
         *
         *      Opens a camera for video capturing
         *
         *     param index id of the video capturing device to open. To open default camera using default backend just pass 0.
         *     (to backward compatibility usage of camera_id + domain_offset (CAP_*) is valid when apiPreference is CAP_ANY)
         *     param apiPreference preferred Capture API backends to use. Can be used to enforce a specific reader
         *     implementation if multiple are available: e.g. cv::CAP_DSHOW or cv::CAP_MSMF or cv::CAP_V4L.
         *
         *     SEE: cv::VideoCaptureAPIs
         */
        public VideoCapture(int index, int apiPreference)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_14(index, apiPreference));


        }

        /**
         *
         *      Opens a camera for video capturing
         *
         *     param index id of the video capturing device to open. To open default camera using default backend just pass 0.
         *     (to backward compatibility usage of camera_id + domain_offset (CAP_*) is valid when apiPreference is CAP_ANY)
         *     implementation if multiple are available: e.g. cv::CAP_DSHOW or cv::CAP_MSMF or cv::CAP_V4L.
         *
         *     SEE: cv::VideoCaptureAPIs
         */
        public VideoCapture(int index)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_15(index));


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference, vector_int _params)
        //

        /**
         *
         *     Opens a camera for video capturing with API Preference and parameters
         *
         *     The {code params} parameter allows to specify extra parameters encoded as pairs {code (paramId_1, paramValue_1, paramId_2, paramValue_2, ...)}.
         *     See cv::VideoCaptureProperties
         * param index automatically generated
         * param apiPreference automatically generated
         * param _params automatically generated
         */
        public VideoCapture(int index, int apiPreference, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_16(index, apiPreference, _params_mat.nativeObj));


        }


        //
        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference = CAP_ANY)
        //

        /**
         *  Opens a video file or a capturing device or an IP video stream for video capturing.
         *
         *     
         *
         *     Parameters are same as the constructor VideoCapture(const String&amp; filename, int apiPreference = CAP_ANY)
         *     return {code true} if the file has been successfully opened
         *
         *     The method first calls VideoCapture::release to close the already opened file or camera.
         * param filename automatically generated
         * param apiPreference automatically generated
         */
        public bool open(string filename, int apiPreference)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_10(nativeObj, filename, apiPreference);


        }

        /**
         *  Opens a video file or a capturing device or an IP video stream for video capturing.
         *
         *     
         *
         *     Parameters are same as the constructor VideoCapture(const String&amp; filename, int apiPreference = CAP_ANY)
         *     return {code true} if the file has been successfully opened
         *
         *     The method first calls VideoCapture::release to close the already opened file or camera.
         * param filename automatically generated
         */
        public bool open(string filename)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_11(nativeObj, filename);


        }


        //
        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference, vector_int _params)
        //

        /**
         *  Opens a video file or a capturing device or an IP video stream for video capturing with API Preference and parameters
         *
         *     
         *
         *     The {code params} parameter allows to specify extra parameters encoded as pairs {code (paramId_1, paramValue_1, paramId_2, paramValue_2, ...)}.
         *     See cv::VideoCaptureProperties
         *
         *     return {code true} if the file has been successfully opened
         *
         *     The method first calls VideoCapture::release to close the already opened file or camera.
         * param filename automatically generated
         * param apiPreference automatically generated
         * param _params automatically generated
         */
        public bool open(string filename, int apiPreference, MatOfInt _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return videoio_VideoCapture_open_12(nativeObj, filename, apiPreference, _params_mat.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::open(int index, int apiPreference = CAP_ANY)
        //

        /**
         *  Opens a camera for video capturing
         *
         *     
         *
         *     Parameters are same as the constructor VideoCapture(int index, int apiPreference = CAP_ANY)
         *     return {code true} if the camera has been successfully opened.
         *
         *     The method first calls VideoCapture::release to close the already opened file or camera.
         * param index automatically generated
         * param apiPreference automatically generated
         */
        public bool open(int index, int apiPreference)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_13(nativeObj, index, apiPreference);


        }

        /**
         *  Opens a camera for video capturing
         *
         *     
         *
         *     Parameters are same as the constructor VideoCapture(int index, int apiPreference = CAP_ANY)
         *     return {code true} if the camera has been successfully opened.
         *
         *     The method first calls VideoCapture::release to close the already opened file or camera.
         * param index automatically generated
         */
        public bool open(int index)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_14(nativeObj, index);


        }


        //
        // C++:  bool cv::VideoCapture::open(int index, int apiPreference, vector_int _params)
        //

        /**
         *  Opens a camera for video capturing with API Preference and parameters
         *
         *     
         *
         *     The {code params} parameter allows to specify extra parameters encoded as pairs {code (paramId_1, paramValue_1, paramId_2, paramValue_2, ...)}.
         *     See cv::VideoCaptureProperties
         *
         *     return {code true} if the camera has been successfully opened.
         *
         *     The method first calls VideoCapture::release to close the already opened file or camera.
         * param index automatically generated
         * param apiPreference automatically generated
         * param _params automatically generated
         */
        public bool open(int index, int apiPreference, MatOfInt _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return videoio_VideoCapture_open_15(nativeObj, index, apiPreference, _params_mat.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::isOpened()
        //

        /**
         * Returns true if video capturing has been initialized already.
         *
         *     If the previous call to VideoCapture constructor or VideoCapture::open() succeeded, the method returns
         *     true.
         * return automatically generated
         */
        public bool isOpened()
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_isOpened_10(nativeObj);


        }


        //
        // C++:  void cv::VideoCapture::release()
        //

        /**
         * Closes video file or capturing device.
         *
         *     The method is automatically called by subsequent VideoCapture::open and by VideoCapture
         *     destructor.
         *
         *     The C function also deallocates memory and clears \*capture pointer.
         */
        public void release()
        {
            ThrowIfDisposed();

            videoio_VideoCapture_release_10(nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::grab()
        //

        /**
         * Grabs the next frame from video file or capturing device.
         *
         *     return {code true} (non-zero) in the case of success.
         *
         *     The method/function grabs the next frame from video file or camera and returns true (non-zero) in
         *     the case of success.
         *
         *     The primary use of the function is in multi-camera environments, especially when the cameras do not
         *     have hardware synchronization. That is, you call VideoCapture::grab() for each camera and after that
         *     call the slower method VideoCapture::retrieve() to decode and get frame from each camera. This way
         *     the overhead on demosaicing or motion jpeg decompression etc. is eliminated and the retrieved frames
         *     from different cameras will be closer in time.
         *
         *     Also, when a connected camera is multi-head (for example, a stereo camera or a Kinect device), the
         *     correct way of retrieving data from it is to call VideoCapture::grab() first and then call
         *     VideoCapture::retrieve() one or more times with different values of the channel parameter.
         *
         *     REF: tutorial_kinect_openni
         */
        public bool grab()
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_grab_10(nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::retrieve(Mat& image, int flag = 0)
        //

        /**
         * Decodes and returns the grabbed video frame.
         *
         *     param flag it could be a frame index or a driver specific flag
         *     return {code false} if no frames has been grabbed
         *
         *     The method decodes and returns the just grabbed frame. If no frames has been grabbed
         *     (camera has been disconnected, or there are no more frames in video file), the method returns false
         *     and the function returns an empty image (with %cv::Mat, test it with Mat::empty()).
         *
         *     SEE: read()
         *
         *     <b>Note:</b> In REF: videoio_c "C API", functions cvRetrieveFrame() and cv.RetrieveFrame() return image stored inside the video
         *     capturing structure. It is not allowed to modify or release the image! You can copy the frame using
         *     cvCloneImage and then do whatever you want with the copy.
         * param image automatically generated
         */
        public bool retrieve(Mat image, int flag)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return videoio_VideoCapture_retrieve_10(nativeObj, image.nativeObj, flag);


        }

        /**
         * Decodes and returns the grabbed video frame.
         *
         *     return {code false} if no frames has been grabbed
         *
         *     The method decodes and returns the just grabbed frame. If no frames has been grabbed
         *     (camera has been disconnected, or there are no more frames in video file), the method returns false
         *     and the function returns an empty image (with %cv::Mat, test it with Mat::empty()).
         *
         *     SEE: read()
         *
         *     <b>Note:</b> In REF: videoio_c "C API", functions cvRetrieveFrame() and cv.RetrieveFrame() return image stored inside the video
         *     capturing structure. It is not allowed to modify or release the image! You can copy the frame using
         *     cvCloneImage and then do whatever you want with the copy.
         * param image automatically generated
         */
        public bool retrieve(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return videoio_VideoCapture_retrieve_11(nativeObj, image.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::read(Mat& image)
        //

        /**
         * Grabs, decodes and returns the next video frame.
         *
         *     return {code false} if no frames has been grabbed
         *
         *     The method/function combines VideoCapture::grab() and VideoCapture::retrieve() in one call. This is the
         *     most convenient method for reading video files or capturing data from decode and returns the just
         *     grabbed frame. If no frames has been grabbed (camera has been disconnected, or there are no more
         *     frames in video file), the method returns false and the function returns empty image (with %cv::Mat, test it with Mat::empty()).
         *
         *     <b>Note:</b> In REF: videoio_c "C API", functions cvRetrieveFrame() and cv.RetrieveFrame() return image stored inside the video
         *     capturing structure. It is not allowed to modify or release the image! You can copy the frame using
         *     cvCloneImage and then do whatever you want with the copy.
         * param image automatically generated
         */
        public bool read(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return videoio_VideoCapture_read_10(nativeObj, image.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::set(int propId, double value)
        //

        /**
         * Sets a property in the VideoCapture.
         *
         *     param propId Property identifier from cv::VideoCaptureProperties (eg. cv::CAP_PROP_POS_MSEC, cv::CAP_PROP_POS_FRAMES, ...)
         *     or one from REF: videoio_flags_others
         *     param value Value of the property.
         *     return {code true} if the property is supported by backend used by the VideoCapture instance.
         *     <b>Note:</b> Even if it returns {code true} this doesn't ensure that the property
         *     value has been accepted by the capture device. See note in VideoCapture::get()
         */
        public bool set(int propId, double value)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_set_10(nativeObj, propId, value);


        }


        //
        // C++:  double cv::VideoCapture::get(int propId)
        //

        /**
         * Returns the specified VideoCapture property
         *
         *     param propId Property identifier from cv::VideoCaptureProperties (eg. cv::CAP_PROP_POS_MSEC, cv::CAP_PROP_POS_FRAMES, ...)
         *     or one from REF: videoio_flags_others
         *     return Value for the specified property. Value 0 is returned when querying a property that is
         *     not supported by the backend used by the VideoCapture instance.
         *
         *     <b>Note:</b> Reading / writing properties involves many layers. Some unexpected result might happens
         *     along this chain.
         *     <code>
         *     VideoCapture -&gt; API Backend -&gt; Operating System -&gt; Device Driver -&gt; Device Hardware
         *     </code>
         *     The returned value might be different from what really used by the device or it could be encoded
         *     using device dependent rules (eg. steps or percentage). Effective behaviour depends from device
         *     driver and API Backend
         */
        public double get(int propId)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_get_10(nativeObj, propId);


        }


        //
        // C++:  String cv::VideoCapture::getBackendName()
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

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_getBackendName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::VideoCapture::setExceptionMode(bool enable)
        //

        /**
         * Switches exceptions mode
         *
         * methods raise exceptions if not successful instead of returning an error code
         * param enable automatically generated
         */
        public void setExceptionMode(bool enable)
        {
            ThrowIfDisposed();

            videoio_VideoCapture_setExceptionMode_10(nativeObj, enable);


        }


        //
        // C++:  bool cv::VideoCapture::getExceptionMode()
        //

        public bool getExceptionMode()
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_getExceptionMode_10(nativeObj);


        }


        //
        // C++: static bool cv::VideoCapture::waitAny(vector_VideoCapture streams, vector_int& readyIndex, int64 timeoutNs = 0)
        //

        // Unknown type 'vector_VideoCapture' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::VideoCapture::VideoCapture()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_10();

        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_11(string filename, int apiPreference);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_12(string filename);

        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_13(string filename, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_14(int index, int apiPreference);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_15(int index);

        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_16(int index, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_10(IntPtr nativeObj, string filename, int apiPreference);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_11(IntPtr nativeObj, string filename);

        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_12(IntPtr nativeObj, string filename, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoCapture::open(int index, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_13(IntPtr nativeObj, int index, int apiPreference);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_14(IntPtr nativeObj, int index);

        // C++:  bool cv::VideoCapture::open(int index, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_15(IntPtr nativeObj, int index, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoCapture::isOpened()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_isOpened_10(IntPtr nativeObj);

        // C++:  void cv::VideoCapture::release()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_release_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::grab()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_grab_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::retrieve(Mat& image, int flag = 0)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_retrieve_10(IntPtr nativeObj, IntPtr image_nativeObj, int flag);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_retrieve_11(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoCapture::read(Mat& image)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_read_10(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoCapture::set(int propId, double value)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_set_10(IntPtr nativeObj, int propId, double value);

        // C++:  double cv::VideoCapture::get(int propId)
        [DllImport(LIBNAME)]
        private static extern double videoio_VideoCapture_get_10(IntPtr nativeObj, int propId);

        // C++:  String cv::VideoCapture::getBackendName()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_getBackendName_10(IntPtr nativeObj);

        // C++:  void cv::VideoCapture::setExceptionMode(bool enable)
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_setExceptionMode_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool enable);

        // C++:  bool cv::VideoCapture::getExceptionMode()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_getExceptionMode_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_delete(IntPtr nativeObj);

    }
}
