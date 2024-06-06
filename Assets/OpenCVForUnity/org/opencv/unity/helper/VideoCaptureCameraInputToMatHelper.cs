#if !OPENCV_DONT_USE_WEBCAMTEXTURE_API

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.VideoioModule;
using System;
using System.Collections;
using UnityEngine;

namespace OpenCVForUnity.UnityUtils.Helper
{
    /// <summary>
    /// VideoCaptureCameraInput to mat helper.
    /// v 1.0.1
    /// Depends on OpenCVForUnity version 2.4.4 (WebCamTextureToMatHelper v 1.1.3) or later.
    /// (Use the WebCamDevice.isFrontFacing and WebCamTexture.videoRotationAngle properties to flip the camera input image in VideoCaptue to the correct orientation.)
    /// </summary>
    public class VideoCaptureCameraInputToMatHelper : WebCamTextureToMatHelper
    {
        //#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX || UNITY_ANDROID || UNITY_IOS) && !DISABLE_VIDEOCAPTURE_API
#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX) && !DISABLE_VIDEOCAPTURE_API
        public override float requestedFPS
        {
            get { return _requestedFPS; }
            set
            {
                float _value = Mathf.Clamp(value, -1f, float.MaxValue);
                if (_requestedFPS != _value)
                {
                    _requestedFPS = _value;
                    if (hasInitDone)
                        Initialize();
                }
            }
        }

        protected VideoCapture videoCapture;
        protected int deviceId = 0;
        protected bool isPlaying = false;
        protected int videoRotationAngle = 0;
        protected bool videoVerticallyMirrored = false;

        // Update is called once per frame
        protected override void Update()
        {
            if (hasInitDone)
            {
                // Catch the orientation change of the screen and correct the mat image to the correct direction.
                if (screenOrientation != Screen.orientation)
                {
                    Initialize();
                }
            }
        }

        /// <summary>
        /// Initializes this instance by coroutine.
        /// </summary>
        protected override IEnumerator _Initialize()
        {
            baseColorFormat = ColorFormat.BGR;

            if (hasInitDone)
            {
                ReleaseResources();

                if (onDisposed != null)
                    onDisposed.Invoke();
            }

            isInitWaiting = true;

#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR
            // Checks camera permission state.
            IEnumerator coroutine = hasUserAuthorizedCameraPermission();
            yield return coroutine;

            if (!(bool)coroutine.Current)
            {
                isInitWaiting = false;
                initCoroutine = null;

                if (onErrorOccurred != null)
                    onErrorOccurred.Invoke(ErrorCode.CAMERA_PERMISSION_DENIED);

                yield break;
            }
#endif

            float requestedFPS = this.requestedFPS;

            // Creates the camera
            var devices = WebCamTexture.devices;
            if (!String.IsNullOrEmpty(requestedDeviceName))
            {
                int requestedDeviceIndex = -1;
                if (Int32.TryParse(requestedDeviceName, out requestedDeviceIndex))
                {
                    if (requestedDeviceIndex >= 0 && requestedDeviceIndex < devices.Length)
                    {
                        webCamDevice = devices[requestedDeviceIndex];
                        webCamTexture = new WebCamTexture(webCamDevice.name, requestedWidth, requestedHeight, (int)requestedFPS);

                        deviceId = requestedDeviceIndex;
                    }
                }
                else
                {
                    for (int cameraIndex = 0; cameraIndex < devices.Length; cameraIndex++)
                    {
                        if (devices[cameraIndex].name == requestedDeviceName)
                        {
                            webCamDevice = devices[cameraIndex];
                            webCamTexture = new WebCamTexture(webCamDevice.name, requestedWidth, requestedHeight, (int)requestedFPS);

                            deviceId = cameraIndex;

                            break;
                        }
                    }
                }
                if (webCamTexture == null)
                    Debug.Log("Cannot find camera device " + requestedDeviceName + ".");
            }

            if (webCamTexture == null)
            {
                // Checks how many and which cameras are available on the device
                for (int cameraIndex = 0; cameraIndex < devices.Length; cameraIndex++)
                {
#if UNITY_2018_3_OR_NEWER
                    if (devices[cameraIndex].kind != WebCamKind.ColorAndDepth && devices[cameraIndex].isFrontFacing == requestedIsFrontFacing)
#else
                    if (devices[cameraIndex].isFrontFacing == requestedIsFrontFacing)
#endif
                    {
                        webCamDevice = devices[cameraIndex];
                        webCamTexture = new WebCamTexture(webCamDevice.name, requestedWidth, requestedHeight, (int)requestedFPS);

                        deviceId = cameraIndex;

                        break;
                    }
                }
            }

            if (webCamTexture == null)
            {
                if (devices.Length > 0)
                {
                    webCamDevice = devices[0];
                    webCamTexture = new WebCamTexture(webCamDevice.name, requestedWidth, requestedHeight, (int)requestedFPS);

                    deviceId = 0;
                }
                else
                {
                    isInitWaiting = false;
                    initCoroutine = null;

                    if (onErrorOccurred != null)
                        onErrorOccurred.Invoke(ErrorCode.CAMERA_DEVICE_NOT_EXIST);

                    yield break;
                }
            }

            // Starts the camera.
            videoCapture = new VideoCapture(deviceId);
            webCamTexture.Play();

            int initFrameCount = 0;
            bool isTimeout = false;
            int step = 0;

            while (true)
            {
                if (initFrameCount > timeoutFrameCount)
                {
                    isTimeout = true;
                    break;
                }
                else if (step == 0 && webCamTexture.isPlaying && webCamTexture.didUpdateThisFrame)
                {
                    videoRotationAngle = webCamTexture.videoRotationAngle;
                    videoVerticallyMirrored = webCamTexture.videoVerticallyMirrored;
                    webCamTexture.Stop();

                    step = 1;

                    initFrameCount++;
                    yield return null;
                }
                else if (step == 1 && videoCapture.isOpened())
                {
                    videoCapture.set(Videoio.CAP_PROP_FRAME_WIDTH, requestedWidth);
                    videoCapture.set(Videoio.CAP_PROP_FRAME_HEIGHT, requestedHeight);
                    videoCapture.set(Videoio.CAP_PROP_FPS, (int)requestedFPS);
                    baseMat = new Mat();

                    step = 2;

                    initFrameCount++;
                    yield return null;
                }
                else if (step == 2 && videoCapture.grab() && videoCapture.retrieve(baseMat) && (baseMat.width() > 0 && baseMat.height() > 0))
                {
                    Debug.Log("VideoCaptureCameraInputToMatHelper:: " + "devicename:" + webCamTexture.deviceName + " name:" + webCamTexture.name + " width:" + baseMat.width() + " height:" + baseMat.height() + " fps:" + videoCapture.get(Videoio.CAP_PROP_FPS)
                    + " videoRotationAngle:" + videoRotationAngle + " videoVerticallyMirrored:" + videoVerticallyMirrored + " isFrongFacing:" + webCamDevice.isFrontFacing);

                    if (baseColorFormat == outputColorFormat)
                    {
                        frameMat = new Mat(baseMat.rows(), baseMat.cols(), baseMat.type(), new Scalar(0, 0, 0, 255));
                    }
                    else
                    {
                        frameMat = new Mat(baseMat.rows(), baseMat.cols(), CvType.CV_8UC(Channels(outputColorFormat)), new Scalar(0, 0, 0, 255));
                    }

                    screenOrientation = Screen.orientation;
                    screenWidth = Screen.width;
                    screenHeight = Screen.height;

                    bool isRotatedFrame = false;
#if !UNITY_EDITOR && !(UNITY_STANDALONE || UNITY_WEBGL)
                    if (screenOrientation == ScreenOrientation.Portrait || screenOrientation == ScreenOrientation.PortraitUpsideDown)
                    {
                        if (!rotate90Degree)
                            isRotatedFrame = true;
                    }
                    else if (rotate90Degree)
                    {
                        isRotatedFrame = true;
                    }
#else
                    if (rotate90Degree)
                        isRotatedFrame = true;
#endif
                    if (isRotatedFrame)
                        rotatedFrameMat = new Mat(frameMat.cols(), frameMat.rows(), CvType.CV_8UC(Channels(outputColorFormat)), new Scalar(0, 0, 0, 255));

                    isInitWaiting = false;
                    hasInitDone = true;
                    initCoroutine = null;

                    isPlaying = true;

                    if (onInitialized != null)
                        onInitialized.Invoke();

                    break;
                }
                else
                {
                    initFrameCount++;
                    yield return null;
                }
            }

            if (isTimeout)
            {
                webCamTexture.Stop();
                WebCamTexture.Destroy(webCamTexture);
                if (baseMat != null)
                {
                    baseMat.Dispose();
                    baseMat = null;
                }
                videoCapture.release();
                videoCapture.Dispose();
                videoCapture = null;
                isInitWaiting = false;
                initCoroutine = null;

                if (onErrorOccurred != null)
                    onErrorOccurred.Invoke(ErrorCode.TIMEOUT);
            }
        }

        /// <summary>
        /// Starts the camera.
        /// </summary>
        public override void Play()
        {
            if (hasInitDone && !isPlaying)
            {
                if (!videoCapture.isOpened())
                    videoCapture.open(deviceId);

                isPlaying = true;
            }
        }

        /// <summary>
        /// Pauses the active camera.
        /// </summary>
        public override void Pause()
        {
            if (hasInitDone && isPlaying)
                isPlaying = false;
        }

        /// <summary>
        /// Stops the active camera.
        /// </summary>
        public override void Stop()
        {
            if (hasInitDone && isPlaying)
            {
                if (videoCapture.isOpened())
                    videoCapture.release();

                isPlaying = false;
            }
        }

        /// <summary>
        /// Indicates whether the active camera is currently playing.
        /// </summary>
        /// <returns><c>true</c>, if the active camera is playing, <c>false</c> otherwise.</returns>
        public override bool IsPlaying()
        {
            return hasInitDone ? isPlaying : false;
        }

        /// <summary>
        /// Indicates whether the active camera device is currently front facng.
        /// </summary>
        /// <returns><c>true</c>, if the active camera device is front facng, <c>false</c> otherwise.</returns>
        public override bool IsFrontFacing()
        {
            return hasInitDone ? webCamDevice.isFrontFacing : false;
        }

        /// <summary>
        /// Returns the active camera device name.
        /// </summary>
        /// <returns>The active camera device name.</returns>
        public override string GetDeviceName()
        {
            return hasInitDone ? webCamTexture.deviceName : "";
        }

        /// <summary>
        /// Returns the active camera framerate.
        /// </summary>
        /// <returns>The active camera framerate.</returns>
        public override float GetFPS()
        {
            return hasInitDone ? (float)videoCapture.get(Videoio.CAP_PROP_FPS) : -1f;
        }

        /// <summary>
        /// Indicates whether the video buffer of the frame has been updated.
        /// </summary>
        /// <returns><c>true</c>, if the video buffer has been updated <c>false</c> otherwise.</returns>
        public override bool DidUpdateThisFrame()
        {
            return hasInitDone ? isPlaying : false;
        }
#endif

        /// <summary>
        /// Returns the VideoCapture instanse.
        /// </summary>
        /// <returns>The VideoCapture instanse.</returns>
        public virtual VideoCapture GetVideoCapture()
        {
            //#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX || UNITY_ANDROID || UNITY_IOS) && !DISABLE_VIDEOCAPTURE_API
#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX) && !DISABLE_VIDEOCAPTURE_API
            return videoCapture;
#else
            return null;
#endif
        }

        //#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX || UNITY_ANDROID || UNITY_IOS) && !DISABLE_VIDEOCAPTURE_API
#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX) && !DISABLE_VIDEOCAPTURE_API
        /// <summary>
        /// Gets the mat of the current frame.
        /// The Mat object's type is 'CV_8UC4' or 'CV_8UC3' or 'CV_8UC1' (ColorFormat is determined by the outputColorFormat setting).
        /// Please do not dispose of the returned mat as it will be reused.
        /// </summary>
        /// <returns>The mat of the current frame.</returns>
        public override Mat GetMat()
        {
            if (!hasInitDone || !videoCapture.isOpened() || !isPlaying)
            {
                return (rotatedFrameMat != null) ? rotatedFrameMat : frameMat;
            }

            if (videoCapture.grab())
                videoCapture.retrieve(baseMat);

            if (baseColorFormat == outputColorFormat)
            {
                baseMat.copyTo(frameMat);
            }
            else
            {
                Imgproc.cvtColor(baseMat, frameMat, ColorConversionCodes(baseColorFormat, outputColorFormat));
            }

#if !UNITY_EDITOR && !(UNITY_STANDALONE || UNITY_WEBGL)
            if (rotatedFrameMat != null)
            {
                if (screenOrientation == ScreenOrientation.Portrait || screenOrientation == ScreenOrientation.PortraitUpsideDown)
                {
                    // (Orientation is Portrait, rotate90Degree is false)
                    if (webCamDevice.isFrontFacing)
                    {
                        FlipMat(frameMat, !flipHorizontal, !flipVertical);
                    }
                    else
                    {
                        FlipMat(frameMat, flipHorizontal, flipVertical);
                    }
                }
                else
                {
                    // (Orientation is Landscape, rotate90Degrees=true)
                    FlipMat(frameMat, flipVertical, flipHorizontal);
                }
                Core.rotate(frameMat, rotatedFrameMat, Core.ROTATE_90_CLOCKWISE);
                return rotatedFrameMat;
            }
            else
            {
                if (screenOrientation == ScreenOrientation.Portrait || screenOrientation == ScreenOrientation.PortraitUpsideDown)
                {
                    // (Orientation is Portrait, rotate90Degree is ture)
                    if (webCamDevice.isFrontFacing)
                    {
                        FlipMat(frameMat, flipHorizontal, flipVertical);
                    }
                    else
                    {
                        FlipMat(frameMat, !flipHorizontal, !flipVertical);
                    }
                }
                else
                {
                    // (Orientation is Landscape, rotate90Degree is false)
                    FlipMat(frameMat, flipVertical, flipHorizontal);
                }
                return frameMat;
            }
#else
            FlipMat(frameMat, flipVertical, flipHorizontal);

            if (rotatedFrameMat != null)
            {
                Core.rotate(frameMat, rotatedFrameMat, Core.ROTATE_90_CLOCKWISE);
                return rotatedFrameMat;
            }
            else
            {
                return frameMat;
            }
#endif
        }

        /// <summary>
        /// Flips the mat.
        /// </summary>
        /// <param name="mat">Mat.</param>
        protected override void FlipMat(Mat mat, bool flipVertical, bool flipHorizontal)
        {
            int flipCode = int.MinValue;

            if (webCamDevice.isFrontFacing)
            {
                if (videoRotationAngle == 0 || videoRotationAngle == 90)
                {
                    flipCode = 1;
                }
                else if (videoRotationAngle == 180 || videoRotationAngle == 270)
                {
                    flipCode = 0;
                }
            }
            else
            {
                if (videoRotationAngle == 180 || videoRotationAngle == 270)
                {
                    flipCode = -1;
                }
            }

            if (flipVertical)
            {
                if (flipCode == int.MinValue)
                {
                    flipCode = 0;
                }
                else if (flipCode == 0)
                {
                    flipCode = int.MinValue;
                }
                else if (flipCode == 1)
                {
                    flipCode = -1;
                }
                else if (flipCode == -1)
                {
                    flipCode = 1;
                }
            }

            if (flipHorizontal)
            {
                if (flipCode == int.MinValue)
                {
                    flipCode = 1;
                }
                else if (flipCode == 0)
                {
                    flipCode = -1;
                }
                else if (flipCode == 1)
                {
                    flipCode = int.MinValue;
                }
                else if (flipCode == -1)
                {
                    flipCode = 0;
                }
            }

            if (flipCode > int.MinValue)
            {
                Core.flip(mat, mat, flipCode);
            }
        }

        /// <summary>
        /// To release the resources.
        /// </summary>
        protected override void ReleaseResources()
        {
            isInitWaiting = false;
            hasInitDone = false;
            isPlaying = false;
            videoRotationAngle = 0;
            videoVerticallyMirrored = false;

            if (webCamTexture != null)
            {
                webCamTexture.Stop();
                WebCamTexture.Destroy(webCamTexture);
                webCamTexture = null;
            }
            if (frameMat != null)
            {
                frameMat.Dispose();
                frameMat = null;
            }
            if (baseMat != null)
            {
                baseMat.Dispose();
                baseMat = null;
            }
            if (rotatedFrameMat != null)
            {
                rotatedFrameMat.Dispose();
                rotatedFrameMat = null;
            }
            if (videoCapture != null)
            {
                videoCapture.release();
                videoCapture.Dispose();
                videoCapture = null;
            }
        }
#endif
    }
}

#endif