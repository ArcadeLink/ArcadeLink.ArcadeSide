using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System.IO;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;

namespace OpenCVForUnity.Editor
{

    public class OpenCVForUnityExampleAssetsDownloaderWindow : EditorWindow
    {

        static Dictionary<string, string>[] files = {
            //ColorizationExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ColorizationExample" }, { "url", "https://github.com/richzhang/colorization/raw/caffe/demo/imgs/ansel_adams3.jpg" } , { "filename", "ansel_adams3.jpg" }, { "sha", "ca4af64f5cd4adc180d167f09f617319871d4608" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ColorizationExample" }, { "url", "https://github.com/EnoxSoftware/OpenCVForUnityExampleAssets/releases/download/dnn%2FColorizationExample/colorization_release_v2.caffemodel" } , { "filename", "colorization_release_v2.caffemodel" }, { "sha", "21e61293a3fa6747308171c11b6dd18a68a26e7f" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ColorizationExample" }, { "url", "https://github.com/richzhang/colorization/raw/caffe/models/colorization_deploy_v2.prototxt" } , { "filename", "colorization_deploy_v2.prototxt" }, { "sha", "f528334e386a69cbaaf237a7611d833bef8e5219" } },
            //ObjectTrackingDaSiamRPNExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectTrackingDaSiamRPNExample" }, { "url", "https://www.dropbox.com/s/rr1lk9355vzolqv/dasiamrpn_model.onnx?dl=1" } , { "filename", "dasiamrpn_model.onnx" }, { "sha", "91b774fce7df4c0e4918469f0f482d9a27d0e2d4" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectTrackingDaSiamRPNExample" }, { "url", "https://www.dropbox.com/s/999cqx5zrfi7w4p/dasiamrpn_kernel_r1.onnx?dl=1" } , { "filename", "dasiamrpn_kernel_r1.onnx" }, { "sha", "bb64620a54348657133eb28be2d3a2a8c76b84b3" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectTrackingDaSiamRPNExample" }, { "url", "https://www.dropbox.com/s/qvmtszx5h339a0w/dasiamrpn_kernel_cls1.onnx?dl=1" } , { "filename", "dasiamrpn_kernel_cls1.onnx" }, { "sha", "e9ccd270ce8059bdf7ed0d1845c03ef4a951ee0f" } },
            //FastNeuralStyleTransferExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FastNeuralStyleTransferExample" }, { "url", "https://cs.stanford.edu/people/jcjohns/fast-neural-style/models/instance_norm/mosaic.t7" } , { "filename", "mosaic.t7" }, { "sha", "f4d3e2a5e3060b3c39a9648ad009de3e09cd0001" } },
            //FaceDetectionResnetSSDExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FaceDetectionResnetSSDExample" }, { "url", "https://github.com/opencv/opencv_3rdparty/raw/dnn_samples_face_detector_20170830/res10_300x300_ssd_iter_140000.caffemodel" } , { "filename", "res10_300x300_ssd_iter_140000.caffemodel" }, { "sha", "15aa726b4d46d9f023526d85537db81cbc8dd566" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FaceDetectionResnetSSDExample" }, { "url", "https://github.com/opencv/opencv/raw/master/samples/dnn/face_detector/deploy.prototxt" } , { "filename", "deploy.prototxt" }, { "sha", "7e5cc2cefc23908176a73f58c9b0ea7e5c74db2d" } },
            //FaceDetectionYuNetExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FaceDetectionYuNetExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/4563a91ba98172b14d7af8bce621b6d1ae7ae0c6/models/face_detection_yunet/face_detection_yunet_2022mar.onnx" }, { "filename", "face_detection_yunet_2022mar.onnx" }, { "sha", "dfe691ae0c8e38d39d1a437e3f7e5fda7b256bdd" } },
            //FaceDetectionYuNetV2Example
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FaceDetectionYuNetV2Example" }, { "url", "https://github.com/opencv/opencv_zoo/raw/f872270fbb034ac326ee5a8d6343299bde765bc4/models/face_detection_yunet/face_detection_yunet_2023mar.onnx" }, { "filename", "face_detection_yunet_2023mar.onnx" }, { "sha", "acbe4b5976ade60c4b866a30d0720d71589c8bbc" } },
            //FacialExpressionRecognitionExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FacialExpressionRecognitionExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/f872270fbb034ac326ee5a8d6343299bde765bc4/models/face_detection_yunet/face_detection_yunet_2023mar.onnx" }, { "filename", "face_detection_yunet_2023mar.onnx" }, { "sha", "acbe4b5976ade60c4b866a30d0720d71589c8bbc" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FacialExpressionRecognitionExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/bc04b1b1c2199fe041723122aa0b4b71032c398c/models/face_recognition_sface/face_recognition_sface_2021dec.onnx" } , { "filename", "face_recognition_sface_2021dec.onnx" }, { "sha", "316ca25772af10f61e356f81f0ec68caf6909a51" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "FacialExpressionRecognitionExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/c3a51f7049977ae29fb4b4781645fc79925b7dde/models/facial_expression_recognition/facial_expression_recognition_mobilefacenet_2022july.onnx" } , { "filename", "facial_expression_recognition_mobilefacenet_2022july.onnx" }, { "sha", "c2ded863504333117c57fddf6941e8c860134183" } },
            //PoseEstimationMediaPipeExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "PoseEstimationMediaPipeExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/0d619617a8e9a389150d8c76e417451a19468150/models/person_detection_mediapipe/person_detection_mediapipe_2023mar.onnx" } , { "filename", "person_detection_mediapipe_2023mar.onnx" }, { "sha", "c99fdade615dbda34c4b51462947e21b2797864f" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "PoseEstimationMediaPipeExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/0d619617a8e9a389150d8c76e417451a19468150/models/pose_estimation_mediapipe/pose_estimation_mediapipe_2023mar.onnx" } , { "filename", "pose_estimation_mediapipe_2023mar.onnx" }, { "sha", "9ecbfab8dec975ba02d8436a65cd69755238be20" } },
            //HandPoseEstimationMediaPipeExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "HandPoseEstimationMediaPipeExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/6c68bc48c6f96042b29b3425174e431ccac38376/models/palm_detection_mediapipe/palm_detection_mediapipe_2023feb.onnx" } , { "filename", "palm_detection_mediapipe_2023feb.onnx" }, { "sha", "b9e6df1d4f93ee1b0b4f5c99a2f88716ccd7ca9a" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "HandPoseEstimationMediaPipeExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/05a07912a619f3dd491ba22ca489245c7847c9ff/models/handpose_estimation_mediapipe/handpose_estimation_mediapipe_2023feb.onnx" } , { "filename", "handpose_estimation_mediapipe_2023feb.onnx" }, { "sha", "48cfa3de98f30986ae2be6ed55e80d46e06713ab" } },
            //HumanSegmentationPPHumanSegExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "HumanSegmentationPPHumanSegExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/2027dd2f5a8a5746b5d4964900a0465afc6d3a53/models/human_segmentation_pphumanseg/human_segmentation_pphumanseg_2023mar.onnx" } , { "filename", "human_segmentation_pphumanseg_2023mar.onnx" }, { "sha", "f0fec695ab7b716eeab4c58b125e98fc3826bb72" } },
            //ImageClassificationMobilenetExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ImageClassificationMobilenetExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/6c59fd8aaedf1728138e3c982f3351bf9ee3013a/models/image_classification_mobilenet/image_classification_mobilenetv2_2022apr.onnx" } , { "filename", "image_classification_mobilenetv2_2022apr.onnx" }, { "sha", "128ea9978b4b46a62a1918040137ee9b0a030c91" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ImageClassificationMobilenetExample" }, { "url", "https://raw.githubusercontent.com/opencv/opencv_zoo/326e15b31a70812eb6d616406d6e6a17ceaddb6f/models/image_classification_ppresnet/imagenet_labels.txt" } , { "filename", "imagenet_labels.txt" }, { "sha", "18673fc90a50d60938a931747ed6d0bfcf40c894" } },
            //ImageClassificationPPResnetExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ImageClassificationPPResnetExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/c8812a7668ea3f285797c0c450d0912add9248f2/models/image_classification_ppresnet/image_classification_ppresnet50_2022jan.onnx" } , { "filename", "image_classification_ppresnet50_2022jan.onnx" }, { "sha", "00fb57af9def8fd00e4f01635d0c4c901268aa02" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ImageClassificationPPResnetExample" }, { "url", "https://raw.githubusercontent.com/opencv/opencv_zoo/326e15b31a70812eb6d616406d6e6a17ceaddb6f/models/image_classification_ppresnet/imagenet_labels.txt" } , { "filename", "imagenet_labels.txt" }, { "sha", "18673fc90a50d60938a931747ed6d0bfcf40c894" } },
            //ObjectDetectionMobileNetSSDExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionMobileNetSSDExample" }, { "url", "https://github.com/chuanqi305/MobileNet-SSD/raw/master/images/004545.jpg" } , { "filename", "004545.jpg" }, { "sha", "2b0c65f59a9f9071f1e7de452f0c2004e8d55b7b" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionMobileNetSSDExample" }, { "url", "https://github.com/PINTO0309/MobileNet-SSD-RealSense/raw/master/caffemodel/MobileNetSSD/MobileNetSSD_deploy.caffemodel" } , { "filename", "MobileNetSSD_deploy.caffemodel" }, { "sha", "994d30a8afaa9e754d17d2373b2d62a7dfbaaf7a" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionMobileNetSSDExample" }, { "url", "https://github.com/chuanqi305/MobileNet-SSD/raw/f5d072ccc7e3dcddaa830e9805da4bf1000b2836/MobileNetSSD_deploy.prototxt" } , { "filename", "MobileNetSSD_deploy.prototxt" }, { "sha", "d77c9cf09619470d49b82a9dd18704813a2043cd" } },
            //ObjectDetectionYOLOv4Example
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOv4Example" }, { "url", "https://github.com/AlexeyAB/darknet/raw/0faed3e60e52f742bbef43b83f6be51dd30f373e/data/person.jpg" } , { "filename", "person.jpg" }, { "sha", "19281b65c5bd43381dfe04e637e78d0cf0b05cbe" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOv4Example" }, { "url", "https://raw.githubusercontent.com/AlexeyAB/darknet/0faed3e60e52f742bbef43b83f6be51dd30f373e/cfg/yolov4-tiny.cfg" } , { "filename", "yolov4-tiny.cfg" }, { "sha", "b161c2b0984b0c3b466c04b0d6cb3e52f06d93dd" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOv4Example" }, { "url", "https://github.com/AlexeyAB/darknet/releases/download/yolov4/yolov4-tiny.weights" } , { "filename", "yolov4-tiny.weights" }, { "sha", "451caaab22fb9831aa1a5ee9b5ba74a35ffa5dcb" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOv4Example" }, { "url", "https://github.com/AlexeyAB/darknet/raw/0faed3e60e52f742bbef43b83f6be51dd30f373e/data/coco.names" } , { "filename", "coco.names" }, { "sha", "b769c7d769385f7640be484dd9c7537b6fb2f35e" } },
            //ObjectDetectionYOLOXExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOXExample" }, { "url", "https://github.com/AlexeyAB/darknet/raw/0faed3e60e52f742bbef43b83f6be51dd30f373e/data/person.jpg" } , { "filename", "person.jpg" }, { "sha", "19281b65c5bd43381dfe04e637e78d0cf0b05cbe" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOXExample" }, { "url", "https://github.com/Megvii-BaseDetection/YOLOX/releases/download/0.1.1rc0/yolox_tiny.onnx" } , { "filename", "yolox_tiny.onnx" }, { "sha", "45985579a307aae54c7b54ca257bc0b48606deac" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionYOLOXExample" }, { "url", "https://github.com/AlexeyAB/darknet/raw/0faed3e60e52f742bbef43b83f6be51dd30f373e/data/coco.names" } , { "filename", "coco.names" }, { "sha", "b769c7d769385f7640be484dd9c7537b6fb2f35e" } },
            //ObjectDetectionNanoDetPlusExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionNanoDetPlusExample" }, { "url", "https://github.com/AlexeyAB/darknet/raw/0faed3e60e52f742bbef43b83f6be51dd30f373e/data/person.jpg" } , { "filename", "person.jpg" }, { "sha", "19281b65c5bd43381dfe04e637e78d0cf0b05cbe" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionNanoDetPlusExample" }, { "url", "https://github.com/RangiLyu/nanodet/releases/download/v1.0.0-alpha-1/nanodet-plus-m_416.onnx" } , { "filename", "nanodet-plus-m_416.onnx" }, { "sha", "79ed0edaab7ea00fe76662aa9d954f0fa5ff5d28" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "ObjectDetectionNanoDetPlusExample" }, { "url", "https://github.com/AlexeyAB/darknet/raw/0faed3e60e52f742bbef43b83f6be51dd30f373e/data/coco.names" } , { "filename", "coco.names" }, { "sha", "b769c7d769385f7640be484dd9c7537b6fb2f35e" } },
            //TextRecognitionCRNNExample
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "TextRecognitionCRNNExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/6a66e0d6e47a693e6d0dd01bbb18e920f3fbae75/models/text_detection_db/text_detection_DB_IC15_resnet18_2021sep.onnx" } , { "filename", "text_detection_DB_IC15_resnet18_2021sep.onnx" }, { "sha", "19543ce09b2efd35f49705c235cc46d0e22df30b" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "TextRecognitionCRNNExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/8a42017a12fe9ed80279737c0b903307371b0e3d/models/text_recognition_crnn/text_recognition_CRNN_EN_2021sep.onnx" } , { "filename", "text_recognition_CRNN_EN_2021sep.onnx" }, { "sha", "dc8c70a52c6880f11859bf074bcd294a45860821" } },
            new Dictionary<string, string>() { { "module", "dnn" }, { "name", "TextRecognitionCRNNExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/8a42017a12fe9ed80279737c0b903307371b0e3d/models/text_recognition_crnn/charset_36_EN.txt" } , { "filename", "charset_36_EN.txt" }, { "sha", "e1562f54307e089f23ce7586d55c994666ed44ac" } },

            //FaceMarkExample
            new Dictionary<string, string>() { { "module", "face" }, { "name", "FaceMarkExample" }, { "url", "https://raw.githubusercontent.com/kurnianggoro/GSOC2017/master/data/lbfmodel.yaml" } , { "filename", "lbfmodel.yaml" }, { "sha", "2bcd8ce6cff58fa3ad74386b7b3f77b510198d27" }  },

            //FaceDetectorYNWebCamExample
            new Dictionary<string, string>() { { "module", "objdetect" }, { "name", "FaceDetectorYNWebCamExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/f872270fbb034ac326ee5a8d6343299bde765bc4/models/face_detection_yunet/face_detection_yunet_2023mar.onnx" } , { "filename", "face_detection_yunet_2023mar.onnx" }, { "sha", "acbe4b5976ade60c4b866a30d0720d71589c8bbc" } },
            //FaceRecognizerSFExample
            new Dictionary<string, string>() { { "module", "objdetect" }, { "name", "FaceRecognizerSFExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/bc04b1b1c2199fe041723122aa0b4b71032c398c/models/face_recognition_sface/face_recognition_sface_2021dec.onnx" } , { "filename", "face_recognition_sface_2021dec.onnx" }, { "sha", "316ca25772af10f61e356f81f0ec68caf6909a51" } },
            new Dictionary<string, string>() { { "module", "objdetect" }, { "name", "FaceRecognizerSFExample" }, { "url", "https://github.com/opencv/opencv_zoo/raw/f872270fbb034ac326ee5a8d6343299bde765bc4/models/face_detection_yunet/face_detection_yunet_2023mar.onnx" } , { "filename", "face_detection_yunet_2023mar.onnx" }, { "sha", "acbe4b5976ade60c4b866a30d0720d71589c8bbc" } },

            //TrackingExample
            new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://raw.githubusercontent.com/opencv/opencv_extra/c4219d5eb3105ed8e634278fad312a1a8d2c182d/testdata/tracking/goturn.prototxt" } , { "filename", "goturn.prototxt" }, { "sha", "d9016c4f3c0e7b36338564993ea33a5510e715ab" } },
            //new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://drive.google.com/uc?export=dowload&id=1j4UTqVE4EGaUFiK7a5I_CYX7twO9c5br" } , { "filename", "goturn.caffemodel" }, { "sha", "236204886fb6a2cdd942b2e713070ee18f00527b" } },
            new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://www.dropbox.com/s/rr1lk9355vzolqv/dasiamrpn_model.onnx?dl=1" } , { "filename", "dasiamrpn_model.onnx" }, { "sha", "91b774fce7df4c0e4918469f0f482d9a27d0e2d4" } },
            new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://www.dropbox.com/s/999cqx5zrfi7w4p/dasiamrpn_kernel_r1.onnx?dl=1" } , { "filename", "dasiamrpn_kernel_r1.onnx" }, { "sha", "bb64620a54348657133eb28be2d3a2a8c76b84b3" } },
            new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://www.dropbox.com/s/qvmtszx5h339a0w/dasiamrpn_kernel_cls1.onnx?dl=1" } , { "filename", "dasiamrpn_kernel_cls1.onnx" }, { "sha", "e9ccd270ce8059bdf7ed0d1845c03ef4a951ee0f" } },
            new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://github.com/HonglinChu/SiamTrackers/raw/c2ff8479624b12ef2dcd830c47f2495a2c4852d4/NanoTrack/models/nanotrackv2/nanotrack_backbone_sim.onnx" } , { "filename", "nanotrack_backbone_sim.onnx" }, { "sha", "6e773a364457b78574f9f63a23b0659ee8646f8f" } },
            new Dictionary<string, string>() { { "module", "tracking" }, { "name", "TrackingExample" }, { "url", "https://github.com/HonglinChu/SiamTrackers/raw/c2ff8479624b12ef2dcd830c47f2495a2c4852d4/NanoTrack/models/nanotrackv2/nanotrack_head_sim.onnx" } , { "filename", "nanotrack_head_sim.onnx" }, { "sha", "39f168489671700cf739e402dfc67d41ce648aef" } },
        };

        static string[] exampleNames = null;

        static UnityWebRequest unityWebRequest = null;

        public static bool isDownloadinig { get; private set; }

        static List<Dictionary<string, string>> downloadingFiles = null;

        static int downloadingFileIndex = 0;

        static int downloadSuccessFileCount = 0;

        static int downloadFailureFileCount = 0;

        static string streamingAssetsFolderPath = null;

        private Vector2 _scrollPosition = Vector2.zero;

        private static int currentProgressID;


        [MenuItem("Tools/OpenCV for Unity/Open Example Assets Downloader", false, 12)]
        public static void OpenExampleAssetsDownloaderWindow()
        {

            OpenCVForUnityExampleAssetsDownloaderWindow m_Window = GetWindow<OpenCVForUnityExampleAssetsDownloaderWindow>("Example Assets Downloader");
            //m_Window.minSize = new Vector2(320, 535);
            //m_Window.maxSize = new Vector2(320, 800);
        }

#if !UNITY_2020_1_OR_NEWER
        void OnDisable()
        {
            if (isDownloadinig)
            {
                CancelDownloadFiles();
            }
        }
#endif

        void OnGUI()
        {
            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);

            //EditorGUILayout.LabelField("ExampleAssetsFileDownload");
            if (streamingAssetsFolderPath == null) streamingAssetsFolderPath = GetStreamingAssetsFolderPath();
            if (exampleNames == null) exampleNames = GetExampleNames(files);

            using (new EditorGUI.DisabledScope(isDownloadinig))
            {

                EditorGUILayout.Space();

                GUILayout.BeginVertical("box");
                {
                    if (GUILayout.Button("All Download"))
                    {

                        StartDownloadFiles(new List<Dictionary<string, string>>(files));
                    }
                }
                GUILayout.EndVertical();

                EditorGUILayout.Space();

                for (int i = 0; i < exampleNames.Length; i++)
                {
                    if (!exampleNames[i].EndsWith("Example"))
                    {
                        if (i != 0) GUILayout.EndVertical();
                        GUILayout.BeginVertical("box");

                        EditorGUILayout.LabelField(exampleNames[i]);
                        continue;
                    }

                    if (GUILayout.Button(exampleNames[i]))
                    {

                        StartDownloadFiles(ExtractFiles(files, exampleNames[i]));
                    }

                    if (exampleNames[i].Equals("TrackingExample")) EditorGUILayout.LabelField("\"goturn.caffemodel\" must be downloaded manually. See \"setup_tracking_module.pdf\" for details.", EditorStyles.textArea);

                    if (i == exampleNames.Length - 1) GUILayout.EndVertical();
                }
            }

            if (isDownloadinig)
            {
                ShowProgressBar(downloadingFiles[downloadingFileIndex]);
            }

            EditorGUILayout.EndScrollView();
        }

        void OnInspectorUpdate()
        {
            Repaint();
        }

        private string GetStreamingAssetsFolderPath()
        {
            string[] guids = UnityEditor.AssetDatabase.FindAssets("OpenCVForUnityExampleAssetsDownloaderWindow");
            if (guids.Length == 0)
            {
                Debug.LogWarning("OpenCVForUnityExampleAssetsDownloaderWindow.cs is missing.");
                return null;
            }
            string opencvForUnityFolderPath = AssetDatabase.GUIDToAssetPath(guids[0]).Substring(0, AssetDatabase.GUIDToAssetPath(guids[0]).LastIndexOf("/Editor/EditorWindow/OpenCVForUnityExampleAssetsDownloaderWindow.cs"));

            string streamingAssetsFolderPath = opencvForUnityFolderPath + "/StreamingAssets/OpenCVForUnity";
 
            //Debug.Log("streamingAssetsFolderPath " + streamingAssetsFolderPath);

            return streamingAssetsFolderPath;
        }

        private string[] GetExampleNames(Dictionary<string, string>[] files)
        {
            List<string> names = new List<string>();
            foreach (var item in files)
            {
                if (!names.Contains(item["module"]))
                {
                    names.Add(item["module"]);
                }
                if (!names.Contains(item["name"]))
                {
                    names.Add(item["name"]);
                }
            }

            return names.ToArray();
        }

        private List<Dictionary<string, string>> ExtractFiles(Dictionary<string, string>[] files, string exampleName)
        {
            List<Dictionary<string, string>> extractFiles = new List<Dictionary<string, string>>();
            foreach (var item in files)
            {
                if (item["name"].Equals(exampleName))
                    extractFiles.Add(item);
            }

            return extractFiles;
        }

        private void ShowProgressBar(Dictionary<string, string> file)
        {

            float progress = (float)downloadingFileIndex / (float)downloadingFiles.Count + (1/(float)downloadingFiles.Count)* unityWebRequest.downloadProgress;

#if UNITY_2020_1_OR_NEWER
            Progress.Report(currentProgressID, progress, string.Format("{0} / {1} " + file["name"] + " : " + file["filename"], downloadingFileIndex + 1, downloadingFiles.Count));
#else
            bool isCancel = EditorUtility.DisplayCancelableProgressBar("Example Assets Downloader", string.Format("{0} / {1} " + file["name"] + " : " + file["filename"], downloadingFileIndex+1, downloadingFiles.Count), progress);

            if (isCancel)
            {
                CancelDownloadFiles();
            }
#endif
        }

        private void StartDownloadFiles(List<Dictionary<string, string>> downloadFiles)
        {

            downloadingFiles = downloadFiles;

            downloadingFileIndex = 0;

            downloadSuccessFileCount = 0;

            downloadFailureFileCount = 0;

            DownloadFile(downloadingFiles[downloadingFileIndex]);

            isDownloadinig = true;

#if UNITY_2020_1_OR_NEWER
            currentProgressID = Progress.Start("OpenCV for Unity Example Assets Downloader", null, Progress.Options.Sticky);
            Progress.RegisterCancelCallback(currentProgressID, () => {
                //Debug.Log("The task has been canceled.");

                CancelDownloadFiles();

                return true;
            });
            Progress.ShowDetails(false);
#endif
        }

        private void CancelDownloadFiles()
        {
            unityWebRequest.Abort();
            isDownloadinig = false;
            //Debug.LogWarning(file["filename"] + " download canceled.");

#if !UNITY_2020_1_OR_NEWER
            EditorUtility.ClearProgressBar();
#endif
        }

        private void DownloadFile( Dictionary<string,string> file)
        {
            if(unityWebRequest != null)unityWebRequest.Dispose();

            unityWebRequest = new UnityWebRequest(file["url"], UnityWebRequest.kHttpVerbGET);
            string path = streamingAssetsFolderPath + "/" + file["module"] + "/" + file["filename"];
            unityWebRequest.downloadHandler = new DownloadHandlerFile(path);
            unityWebRequest.EditorSendWebRequest(
                //onSuccess
                () => {                   

                    if (CheckSHA1Hash(file))
                    {
                        Debug.Log("Download Success: " + path);

                        downloadSuccessFileCount++;
                    }
                    else
                    {
                        Debug.LogError("Download Failure: " + path + " Incorrect hash value.");
                        FileUtil.DeleteFileOrDirectory(path);

                        downloadFailureFileCount++;
                    }


                    ContinueOrFinishDownloadFile();

                },
                //onError
                () => {

                    //delete error file.
                    if (FileUtil.DeleteFileOrDirectory(path))
                    {
                        //Debug.LogError("delete " + path);
                    }

                    //Candeled by ProgressBar.
                    if (!isDownloadinig)
                    {
                        Debug.LogWarning("Download Cancel: " + path);
                        AssetDatabase.Refresh();
                        return;
                    }

                    Debug.LogError("Download Failure: " + path + " " + unityWebRequest.error + "\nIf the network environment is bad, please retry after a while.");

                    downloadFailureFileCount++;

                    ContinueOrFinishDownloadFile();
                }
                );
        }

        private void ContinueOrFinishDownloadFile()
        {
            downloadingFileIndex++;
            if (downloadingFileIndex > downloadingFiles.Count - 1)
            {
                isDownloadinig = false;

                AssetDatabase.Refresh();

#if UNITY_2020_1_OR_NEWER
                Progress.Finish(currentProgressID, Progress.Status.Succeeded);
#else
                EditorUtility.ClearProgressBar();
#endif

                if (downloadSuccessFileCount == downloadingFiles.Count)
                {
                    EditorUtility.DisplayDialog("Download Completed", "All files have been successfully downloaded.", "OK");
                }
                else
                {
                    EditorUtility.DisplayDialog("Download Completed", "Success: " + downloadSuccessFileCount + ", Failure: " + downloadFailureFileCount + "\nFiles that failed to download are output to the console.", "OK");
                }
            }
            else
            {
                DownloadFile(downloadingFiles[downloadingFileIndex]);
            }
        }

        private bool CheckSHA1Hash(Dictionary<string, string> file)
        {
            //skip check
            if (!file.ContainsKey("sha"))return true;

            FileStream fs = new FileStream(streamingAssetsFolderPath + "/" + file["module"] + "/" + file["filename"], FileMode.Open, FileAccess.Read);

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] bs = sha1.ComputeHash(fs);

            sha1.Clear();

            fs.Close();

            string result = BitConverter.ToString(bs).ToLower().Replace("-", "");
            //Debug.Log("sha1 result: " + result);

            if (result.Equals(file["sha"])) return true;

            return false;
        }
    }



    public static class WebRequestInEditor
    {

        public static void EditorSendWebRequest(this UnityWebRequest self, Action onSuccess = null, Action onError = null)
        {
            self.SendWebRequest();

            EditorApplication.CallbackFunction updateFunc = null;
            updateFunc = () =>
            {
                if (self.isDone)
                {
                    EditorApplication.update -= updateFunc;

#if UNITY_2020_1_OR_NEWER
                    switch ( self.result )
                    {
                        case UnityWebRequest.Result.InProgress:
                        case UnityWebRequest.Result.ConnectionError:
                        case UnityWebRequest.Result.ProtocolError:
                        case UnityWebRequest.Result.DataProcessingError:
                            onError?.Invoke();
                            break;

                        case UnityWebRequest.Result.Success:
                            onSuccess?.Invoke();
                            break;

                        default: throw new ArgumentOutOfRangeException();
                    }
#else
                    if (self.isHttpError || self.isNetworkError || !string.IsNullOrEmpty(self.error))
                    {
                        onError?.Invoke();
                    }
                    else
                    {
                        onSuccess?.Invoke();
                    }
#endif

                }
            };

            EditorApplication.update += updateFunc;
        }
    }
}