#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{
    // C++: class Net
    /**
     * This class allows to create and manipulate comprehensive artificial neural networks.
     *
     * Neural network is presented as directed acyclic graph (DAG), where vertices are Layer instances,
     * and edges specify relationships between layers inputs and outputs.
     *
     * Each network layer has unique integer id and unique string name inside its network.
     * LayerId can store either layer name or layer id.
     *
     * This class supports reference counting of its instances, i. e. copies point to the same instance.
     */

    public class Net : DisposableOpenCVObject
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
                        dnn_Net_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Net(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Net __fromPtr__(IntPtr addr) { return new Net(addr); }

        //
        // C++:   cv::dnn::Net::Net()
        //

        public Net()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_Net_Net_10());


        }


        //
        // C++: static Net cv::dnn::Net::readFromModelOptimizer(String xml, String bin)
        //

        /**
         * Create a network from Intel's Model Optimizer intermediate representation (IR).
         * param xml XML configuration file with network's topology.
         * param bin Binary file with trained weights.
         * Networks imported from Intel's Model Optimizer are launched in Intel's Inference Engine
         * backend.
         * return automatically generated
         */
        public static Net readFromModelOptimizer(string xml, string bin)
        {


            return new Net(DisposableObject.ThrowIfNullIntPtr(dnn_Net_readFromModelOptimizer_10(xml, bin)));


        }


        //
        // C++: static Net cv::dnn::Net::readFromModelOptimizer(vector_uchar bufferModelConfig, vector_uchar bufferWeights)
        //

        /**
         * Create a network from Intel's Model Optimizer in-memory buffers with intermediate representation (IR).
         * param bufferModelConfig buffer with model's configuration.
         * param bufferWeights buffer with model's trained weights.
         * return Net object.
         */
        public static Net readFromModelOptimizer(MatOfByte bufferModelConfig, MatOfByte bufferWeights)
        {
            if (bufferModelConfig != null) bufferModelConfig.ThrowIfDisposed();
            if (bufferWeights != null) bufferWeights.ThrowIfDisposed();
            Mat bufferModelConfig_mat = bufferModelConfig;
            Mat bufferWeights_mat = bufferWeights;
            return new Net(DisposableObject.ThrowIfNullIntPtr(dnn_Net_readFromModelOptimizer_11(bufferModelConfig_mat.nativeObj, bufferWeights_mat.nativeObj)));


        }


        //
        // C++:  bool cv::dnn::Net::empty()
        //

        /**
         * Returns true if there are no layers in the network.
         * return automatically generated
         */
        public bool empty()
        {
            ThrowIfDisposed();

            return dnn_Net_empty_10(nativeObj);


        }


        //
        // C++:  String cv::dnn::Net::dump()
        //

        /**
         * Dump net to String
         * return String with structure, hyperparameters, backend, target and fusion
         * Call method after setInput(). To see correct backend, target and fusion run after forward().
         */
        public string dump()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_Net_dump_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::dnn::Net::dumpToFile(String path)
        //

        /**
         * Dump net structure, hyperparameters, backend, target and fusion to dot file
         * param path   path to output file with .dot extension
         * SEE: dump()
         */
        public void dumpToFile(string path)
        {
            ThrowIfDisposed();

            dnn_Net_dumpToFile_10(nativeObj, path);


        }


        //
        // C++:  int cv::dnn::Net::getLayerId(String layer)
        //

        /**
         * Converts string name of the layer to the integer identifier.
         * return id of the layer, or -1 if the layer wasn't found.
         * param layer automatically generated
         */
        public int getLayerId(string layer)
        {
            ThrowIfDisposed();

            return dnn_Net_getLayerId_10(nativeObj, layer);


        }


        //
        // C++:  vector_String cv::dnn::Net::getLayerNames()
        //

        public List<string> getLayerNames()
        {
            ThrowIfDisposed();
            List<string> retVal = new List<string>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getLayerNames_10(nativeObj)));
            Converters.Mat_to_vector_String(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  Ptr_Layer cv::dnn::Net::getLayer(int layerId)
        //

        /**
         * Returns pointer to layer with specified id or name which the network use.
         * param layerId automatically generated
         * return automatically generated
         */
        public Layer getLayer(int layerId)
        {
            ThrowIfDisposed();

            return Layer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getLayer_10(nativeObj, layerId)));


        }


        //
        // C++:  Ptr_Layer cv::dnn::Net::getLayer(String layerName)
        //

        /**
         *
         * deprecated Use int getLayerId(const String &amp;layer)
         * param layerName automatically generated
         * return automatically generated
         */
        [Obsolete("This method is deprecated.")]
        public Layer getLayer(string layerName)
        {
            ThrowIfDisposed();

            return Layer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getLayer_11(nativeObj, layerName)));


        }


        //
        // C++:  Ptr_Layer cv::dnn::Net::getLayer(LayerId layerId)
        //

        /**
         *
         * deprecated to be removed
         * param layerId automatically generated
         * return automatically generated
         */
        [Obsolete("This method is deprecated.")]
        public Layer getLayer(DictValue layerId)
        {
            ThrowIfDisposed();
            if (layerId != null) layerId.ThrowIfDisposed();

            return Layer.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getLayer_12(nativeObj, layerId.getNativeObjAddr())));


        }


        //
        // C++:  void cv::dnn::Net::connect(String outPin, String inpPin)
        //

        /**
         * Connects output of the first layer to input of the second layer.
         * param outPin descriptor of the first layer output.
         * param inpPin descriptor of the second layer input.
         *
         * Descriptors have the following template &lt;DFN&gt;&amp;lt;layer_name&amp;gt;[.input_number]&lt;/DFN&gt;:
         * - the first part of the template &lt;DFN&gt;layer_name&lt;/DFN&gt; is string name of the added layer.
         * If this part is empty then the network input pseudo layer will be used;
         * - the second optional part of the template &lt;DFN&gt;input_number&lt;/DFN&gt;
         * is either number of the layer input, either label one.
         * If this part is omitted then the first layer input will be used.
         *
         * SEE: setNetInputs(), Layer::inputNameToIndex(), Layer::outputNameToIndex()
         */
        public void connect(string outPin, string inpPin)
        {
            ThrowIfDisposed();

            dnn_Net_connect_10(nativeObj, outPin, inpPin);


        }


        //
        // C++:  void cv::dnn::Net::setInputsNames(vector_String inputBlobNames)
        //

        /**
         * Sets outputs names of the network input pseudo layer.
         *
         * Each net always has special own the network input pseudo layer with id=0.
         * This layer stores the user blobs only and don't make any computations.
         * In fact, this layer provides the only way to pass user data into the network.
         * As any other layer, this layer can label its outputs and this function provides an easy way to do this.
         * param inputBlobNames automatically generated
         */
        public void setInputsNames(List<string> inputBlobNames)
        {
            ThrowIfDisposed();
            Mat inputBlobNames_mat = Converters.vector_String_to_Mat(inputBlobNames);
            dnn_Net_setInputsNames_10(nativeObj, inputBlobNames_mat.nativeObj);


        }


        //
        // C++:  void cv::dnn::Net::setInputShape(String inputName, MatShape shape)
        //

        /**
         * Specify shape of network input.
         * param inputName automatically generated
         * param shape automatically generated
         */
        public void setInputShape(string inputName, MatOfInt shape)
        {
            ThrowIfDisposed();
            if (shape != null) shape.ThrowIfDisposed();
            Mat shape_mat = shape;
            dnn_Net_setInputShape_10(nativeObj, inputName, shape_mat.nativeObj);


        }


        //
        // C++:  Mat cv::dnn::Net::forward(String outputName = String())
        //

        /**
         * Runs forward pass to compute output of layer with name {code outputName}.
         * param outputName name for layer which output is needed to get
         * return blob for first output of specified layer.
         * By default runs forward pass for the whole network.
         */
        public Mat forward(string outputName)
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_forward_10(nativeObj, outputName)));


        }

        /**
         * Runs forward pass to compute output of layer with name {code outputName}.
         * return blob for first output of specified layer.
         * By default runs forward pass for the whole network.
         */
        public Mat forward()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_forward_11(nativeObj)));


        }


        //
        // C++:  AsyncArray cv::dnn::Net::forwardAsync(String outputName = String())
        //

        // Return type 'AsyncArray' is not supported, skipping the function


        //
        // C++:  void cv::dnn::Net::forward(vector_Mat& outputBlobs, String outputName = String())
        //

        /**
         * Runs forward pass to compute output of layer with name {code outputName}.
         * param outputBlobs contains all output blobs for specified layer.
         * param outputName name for layer which output is needed to get
         * If {code outputName} is empty, runs forward pass for the whole network.
         */
        public void forward(List<Mat> outputBlobs, string outputName)
        {
            ThrowIfDisposed();
            Mat outputBlobs_mat = new Mat();
            dnn_Net_forward_12(nativeObj, outputBlobs_mat.nativeObj, outputName);
            Converters.Mat_to_vector_Mat(outputBlobs_mat, outputBlobs);
            outputBlobs_mat.release();

        }

        /**
         * Runs forward pass to compute output of layer with name {code outputName}.
         * param outputBlobs contains all output blobs for specified layer.
         * If {code outputName} is empty, runs forward pass for the whole network.
         */
        public void forward(List<Mat> outputBlobs)
        {
            ThrowIfDisposed();
            Mat outputBlobs_mat = new Mat();
            dnn_Net_forward_13(nativeObj, outputBlobs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(outputBlobs_mat, outputBlobs);
            outputBlobs_mat.release();

        }


        //
        // C++:  void cv::dnn::Net::forward(vector_Mat& outputBlobs, vector_String outBlobNames)
        //

        /**
         * Runs forward pass to compute outputs of layers listed in {code outBlobNames}.
         * param outputBlobs contains blobs for first outputs of specified layers.
         * param outBlobNames names for layers which outputs are needed to get
         */
        public void forward(List<Mat> outputBlobs, List<string> outBlobNames)
        {
            ThrowIfDisposed();
            Mat outputBlobs_mat = new Mat();
            Mat outBlobNames_mat = Converters.vector_String_to_Mat(outBlobNames);
            dnn_Net_forward_14(nativeObj, outputBlobs_mat.nativeObj, outBlobNames_mat.nativeObj);
            Converters.Mat_to_vector_Mat(outputBlobs_mat, outputBlobs);
            outputBlobs_mat.release();

        }


        //
        // C++:  void cv::dnn::Net::forward(vector_vector_Mat& outputBlobs, vector_String outBlobNames)
        //

        // Unknown type 'vector_vector_Mat' (O), skipping the function


        //
        // C++:  Net cv::dnn::Net::quantize(vector_Mat calibData, int inputsDtype, int outputsDtype, bool perChannel = true)
        //

        /**
         * Returns a quantized Net from a floating-point Net.
         * param calibData Calibration data to compute the quantization parameters.
         * param inputsDtype Datatype of quantized net's inputs. Can be CV_32F or CV_8S.
         * param outputsDtype Datatype of quantized net's outputs. Can be CV_32F or CV_8S.
         * param perChannel Quantization granularity of quantized Net. The default is true, that means quantize model
         * in per-channel way (channel-wise). Set it false to quantize model in per-tensor way (or tensor-wise).
         * return automatically generated
         */
        public Net quantize(List<Mat> calibData, int inputsDtype, int outputsDtype, bool perChannel)
        {
            ThrowIfDisposed();
            Mat calibData_mat = Converters.vector_Mat_to_Mat(calibData);
            return new Net(DisposableObject.ThrowIfNullIntPtr(dnn_Net_quantize_10(nativeObj, calibData_mat.nativeObj, inputsDtype, outputsDtype, perChannel)));


        }

        /**
         * Returns a quantized Net from a floating-point Net.
         * param calibData Calibration data to compute the quantization parameters.
         * param inputsDtype Datatype of quantized net's inputs. Can be CV_32F or CV_8S.
         * param outputsDtype Datatype of quantized net's outputs. Can be CV_32F or CV_8S.
         * in per-channel way (channel-wise). Set it false to quantize model in per-tensor way (or tensor-wise).
         * return automatically generated
         */
        public Net quantize(List<Mat> calibData, int inputsDtype, int outputsDtype)
        {
            ThrowIfDisposed();
            Mat calibData_mat = Converters.vector_Mat_to_Mat(calibData);
            return new Net(DisposableObject.ThrowIfNullIntPtr(dnn_Net_quantize_11(nativeObj, calibData_mat.nativeObj, inputsDtype, outputsDtype)));


        }


        //
        // C++:  void cv::dnn::Net::getInputDetails(vector_float& scales, vector_int& zeropoints)
        //

        /**
         * Returns input scale and zeropoint for a quantized Net.
         * param scales output parameter for returning input scales.
         * param zeropoints output parameter for returning input zeropoints.
         */
        public void getInputDetails(MatOfFloat scales, MatOfInt zeropoints)
        {
            ThrowIfDisposed();
            if (scales != null) scales.ThrowIfDisposed();
            if (zeropoints != null) zeropoints.ThrowIfDisposed();
            Mat scales_mat = scales;
            Mat zeropoints_mat = zeropoints;
            dnn_Net_getInputDetails_10(nativeObj, scales_mat.nativeObj, zeropoints_mat.nativeObj);


        }


        //
        // C++:  void cv::dnn::Net::getOutputDetails(vector_float& scales, vector_int& zeropoints)
        //

        /**
         * Returns output scale and zeropoint for a quantized Net.
         * param scales output parameter for returning output scales.
         * param zeropoints output parameter for returning output zeropoints.
         */
        public void getOutputDetails(MatOfFloat scales, MatOfInt zeropoints)
        {
            ThrowIfDisposed();
            if (scales != null) scales.ThrowIfDisposed();
            if (zeropoints != null) zeropoints.ThrowIfDisposed();
            Mat scales_mat = scales;
            Mat zeropoints_mat = zeropoints;
            dnn_Net_getOutputDetails_10(nativeObj, scales_mat.nativeObj, zeropoints_mat.nativeObj);


        }


        //
        // C++:  void cv::dnn::Net::setHalideScheduler(String scheduler)
        //

        /**
         * Compile Halide layers.
         * param scheduler Path to YAML file with scheduling directives.
         * SEE: setPreferableBackend
         *
         * Schedule layers that support Halide backend. Then compile them for
         * specific target. For layers that not represented in scheduling file
         * or if no manual scheduling used at all, automatic scheduling will be applied.
         */
        public void setHalideScheduler(string scheduler)
        {
            ThrowIfDisposed();

            dnn_Net_setHalideScheduler_10(nativeObj, scheduler);


        }


        //
        // C++:  void cv::dnn::Net::setPreferableBackend(int backendId)
        //

        /**
         * Ask network to use specific computation backend where it supported.
         * param backendId backend identifier.
         * SEE: Backend
         *
         * If OpenCV is compiled with Intel's Inference Engine library, DNN_BACKEND_DEFAULT
         * means DNN_BACKEND_INFERENCE_ENGINE. Otherwise it equals to DNN_BACKEND_OPENCV.
         */
        public void setPreferableBackend(int backendId)
        {
            ThrowIfDisposed();

            dnn_Net_setPreferableBackend_10(nativeObj, backendId);


        }


        //
        // C++:  void cv::dnn::Net::setPreferableTarget(int targetId)
        //

        /**
         * Ask network to make computations on specific target device.
         * param targetId target identifier.
         * SEE: Target
         *
         * List of supported combinations backend / target:
         * |                        | DNN_BACKEND_OPENCV | DNN_BACKEND_INFERENCE_ENGINE | DNN_BACKEND_HALIDE |  DNN_BACKEND_CUDA |
         * |------------------------|--------------------|------------------------------|--------------------|-------------------|
         * | DNN_TARGET_CPU         |                  + |                            + |                  + |                   |
         * | DNN_TARGET_OPENCL      |                  + |                            + |                  + |                   |
         * | DNN_TARGET_OPENCL_FP16 |                  + |                            + |                    |                   |
         * | DNN_TARGET_MYRIAD      |                    |                            + |                    |                   |
         * | DNN_TARGET_FPGA        |                    |                            + |                    |                   |
         * | DNN_TARGET_CUDA        |                    |                              |                    |                 + |
         * | DNN_TARGET_CUDA_FP16   |                    |                              |                    |                 + |
         * | DNN_TARGET_HDDL        |                    |                            + |                    |                   |
         */
        public void setPreferableTarget(int targetId)
        {
            ThrowIfDisposed();

            dnn_Net_setPreferableTarget_10(nativeObj, targetId);


        }


        //
        // C++:  void cv::dnn::Net::setInput(Mat blob, String name = "", double scalefactor = 1.0, Scalar mean = Scalar())
        //

        /**
         * Sets the new input value for the network
         * param blob        A new blob. Should have CV_32F or CV_8U depth.
         * param name        A name of input layer.
         * param scalefactor An optional normalization scale.
         * param mean        An optional mean subtraction values.
         * SEE: connect(String, String) to know format of the descriptor.
         *
         * If scale or mean values are specified, a final input blob is computed
         * as:
         * \(input(n,c,h,w) = scalefactor \times (blob(n,c,h,w) - mean_c)\)
         */
        public void setInput(Mat blob, string name, double scalefactor, Scalar mean)
        {
            ThrowIfDisposed();
            if (blob != null) blob.ThrowIfDisposed();

            dnn_Net_setInput_10(nativeObj, blob.nativeObj, name, scalefactor, mean.val[0], mean.val[1], mean.val[2], mean.val[3]);


        }

        /**
         * Sets the new input value for the network
         * param blob        A new blob. Should have CV_32F or CV_8U depth.
         * param name        A name of input layer.
         * param scalefactor An optional normalization scale.
         * SEE: connect(String, String) to know format of the descriptor.
         *
         * If scale or mean values are specified, a final input blob is computed
         * as:
         * \(input(n,c,h,w) = scalefactor \times (blob(n,c,h,w) - mean_c)\)
         */
        public void setInput(Mat blob, string name, double scalefactor)
        {
            ThrowIfDisposed();
            if (blob != null) blob.ThrowIfDisposed();

            dnn_Net_setInput_11(nativeObj, blob.nativeObj, name, scalefactor);


        }

        /**
         * Sets the new input value for the network
         * param blob        A new blob. Should have CV_32F or CV_8U depth.
         * param name        A name of input layer.
         * SEE: connect(String, String) to know format of the descriptor.
         *
         * If scale or mean values are specified, a final input blob is computed
         * as:
         * \(input(n,c,h,w) = scalefactor \times (blob(n,c,h,w) - mean_c)\)
         */
        public void setInput(Mat blob, string name)
        {
            ThrowIfDisposed();
            if (blob != null) blob.ThrowIfDisposed();

            dnn_Net_setInput_12(nativeObj, blob.nativeObj, name);


        }

        /**
         * Sets the new input value for the network
         * param blob        A new blob. Should have CV_32F or CV_8U depth.
         * SEE: connect(String, String) to know format of the descriptor.
         *
         * If scale or mean values are specified, a final input blob is computed
         * as:
         * \(input(n,c,h,w) = scalefactor \times (blob(n,c,h,w) - mean_c)\)
         */
        public void setInput(Mat blob)
        {
            ThrowIfDisposed();
            if (blob != null) blob.ThrowIfDisposed();

            dnn_Net_setInput_13(nativeObj, blob.nativeObj);


        }


        //
        // C++:  void cv::dnn::Net::setParam(int layer, int numParam, Mat blob)
        //

        /**
         * Sets the new value for the learned param of the layer.
         * param layer name or id of the layer.
         * param numParam index of the layer parameter in the Layer::blobs array.
         * param blob the new value.
         * SEE: Layer::blobs
         * <b>Note:</b> If shape of the new blob differs from the previous shape,
         * then the following forward pass may fail.
         */
        public void setParam(int layer, int numParam, Mat blob)
        {
            ThrowIfDisposed();
            if (blob != null) blob.ThrowIfDisposed();

            dnn_Net_setParam_10(nativeObj, layer, numParam, blob.nativeObj);


        }


        //
        // C++:  void cv::dnn::Net::setParam(String layerName, int numParam, Mat blob)
        //

        public void setParam(string layerName, int numParam, Mat blob)
        {
            ThrowIfDisposed();
            if (blob != null) blob.ThrowIfDisposed();

            dnn_Net_setParam_11(nativeObj, layerName, numParam, blob.nativeObj);


        }


        //
        // C++:  Mat cv::dnn::Net::getParam(int layer, int numParam = 0)
        //

        /**
         * Returns parameter blob of the layer.
         * param layer name or id of the layer.
         * param numParam index of the layer parameter in the Layer::blobs array.
         * SEE: Layer::blobs
         * return automatically generated
         */
        public Mat getParam(int layer, int numParam)
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getParam_10(nativeObj, layer, numParam)));


        }

        /**
         * Returns parameter blob of the layer.
         * param layer name or id of the layer.
         * SEE: Layer::blobs
         * return automatically generated
         */
        public Mat getParam(int layer)
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getParam_11(nativeObj, layer)));


        }


        //
        // C++:  Mat cv::dnn::Net::getParam(String layerName, int numParam = 0)
        //

        public Mat getParam(string layerName, int numParam)
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getParam_12(nativeObj, layerName, numParam)));


        }

        public Mat getParam(string layerName)
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getParam_13(nativeObj, layerName)));


        }


        //
        // C++:  vector_int cv::dnn::Net::getUnconnectedOutLayers()
        //

        /**
         * Returns indexes of layers with unconnected outputs.
         *
         * FIXIT: Rework API to registerOutput() approach, deprecate this call
         * return automatically generated
         */
        public MatOfInt getUnconnectedOutLayers()
        {
            ThrowIfDisposed();

            return MatOfInt.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getUnconnectedOutLayers_10(nativeObj)));


        }


        //
        // C++:  vector_String cv::dnn::Net::getUnconnectedOutLayersNames()
        //

        /**
         * Returns names of layers with unconnected outputs.
         *
         * FIXIT: Rework API to registerOutput() approach, deprecate this call
         * return automatically generated
         */
        public List<string> getUnconnectedOutLayersNames()
        {
            ThrowIfDisposed();
            List<string> retVal = new List<string>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Net_getUnconnectedOutLayersNames_10(nativeObj)));
            Converters.Mat_to_vector_String(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  void cv::dnn::Net::getLayersShapes(vector_MatShape netInputShapes, vector_int& layersIds, vector_vector_MatShape& inLayersShapes, vector_vector_MatShape& outLayersShapes)
        //

        // Unknown type 'vector_vector_MatShape' (O), skipping the function


        //
        // C++:  void cv::dnn::Net::getLayersShapes(MatShape netInputShape, vector_int& layersIds, vector_vector_MatShape& inLayersShapes, vector_vector_MatShape& outLayersShapes)
        //

        // Unknown type 'vector_vector_MatShape' (O), skipping the function


        //
        // C++:  int64 cv::dnn::Net::getFLOPS(vector_MatShape netInputShapes)
        //

        /**
         * Computes FLOP for whole loaded model with specified input shapes.
         * param netInputShapes vector of shapes for all net inputs.
         * return computed FLOP.
         */
        public long getFLOPS(List<MatOfInt> netInputShapes)
        {
            ThrowIfDisposed();
            Mat netInputShapes_mat = Converters.vector_MatShape_to_Mat(netInputShapes);
            return dnn_Net_getFLOPS_10(nativeObj, netInputShapes_mat.nativeObj);


        }


        //
        // C++:  int64 cv::dnn::Net::getFLOPS(MatShape netInputShape)
        //

        public long getFLOPS(MatOfInt netInputShape)
        {
            ThrowIfDisposed();
            if (netInputShape != null) netInputShape.ThrowIfDisposed();
            Mat netInputShape_mat = netInputShape;
            return dnn_Net_getFLOPS_11(nativeObj, netInputShape_mat.nativeObj);


        }


        //
        // C++:  int64 cv::dnn::Net::getFLOPS(int layerId, vector_MatShape netInputShapes)
        //

        public long getFLOPS(int layerId, List<MatOfInt> netInputShapes)
        {
            ThrowIfDisposed();
            Mat netInputShapes_mat = Converters.vector_MatShape_to_Mat(netInputShapes);
            return dnn_Net_getFLOPS_12(nativeObj, layerId, netInputShapes_mat.nativeObj);


        }


        //
        // C++:  int64 cv::dnn::Net::getFLOPS(int layerId, MatShape netInputShape)
        //

        public long getFLOPS(int layerId, MatOfInt netInputShape)
        {
            ThrowIfDisposed();
            if (netInputShape != null) netInputShape.ThrowIfDisposed();
            Mat netInputShape_mat = netInputShape;
            return dnn_Net_getFLOPS_13(nativeObj, layerId, netInputShape_mat.nativeObj);


        }


        //
        // C++:  void cv::dnn::Net::getLayerTypes(vector_String& layersTypes)
        //

        /**
         * Returns list of types for layer used in model.
         * param layersTypes output parameter for returning types.
         */
        public void getLayerTypes(List<string> layersTypes)
        {
            ThrowIfDisposed();
            Mat layersTypes_mat = new Mat();
            dnn_Net_getLayerTypes_10(nativeObj, layersTypes_mat.nativeObj);
            Converters.Mat_to_vector_String(layersTypes_mat, layersTypes);
            layersTypes_mat.release();

        }


        //
        // C++:  int cv::dnn::Net::getLayersCount(String layerType)
        //

        /**
         * Returns count of layers of specified type.
         * param layerType type.
         * return count of layers
         */
        public int getLayersCount(string layerType)
        {
            ThrowIfDisposed();

            return dnn_Net_getLayersCount_10(nativeObj, layerType);


        }


        //
        // C++:  void cv::dnn::Net::getMemoryConsumption(MatShape netInputShape, size_t& weights, size_t& blobs)
        //

        public void getMemoryConsumption(MatOfInt netInputShape, long[] weights, long[] blobs)
        {
            ThrowIfDisposed();
            if (netInputShape != null) netInputShape.ThrowIfDisposed();
            Mat netInputShape_mat = netInputShape;
            double[] weights_out = new double[1];
            double[] blobs_out = new double[1];
            dnn_Net_getMemoryConsumption_10(nativeObj, netInputShape_mat.nativeObj, weights_out, blobs_out);
            if (weights != null) weights[0] = (long)weights_out[0];
            if (blobs != null) blobs[0] = (long)blobs_out[0];

        }


        //
        // C++:  void cv::dnn::Net::getMemoryConsumption(int layerId, vector_MatShape netInputShapes, size_t& weights, size_t& blobs)
        //

        public void getMemoryConsumption(int layerId, List<MatOfInt> netInputShapes, long[] weights, long[] blobs)
        {
            ThrowIfDisposed();
            Mat netInputShapes_mat = Converters.vector_MatShape_to_Mat(netInputShapes);
            double[] weights_out = new double[1];
            double[] blobs_out = new double[1];
            dnn_Net_getMemoryConsumption_11(nativeObj, layerId, netInputShapes_mat.nativeObj, weights_out, blobs_out);
            if (weights != null) weights[0] = (long)weights_out[0];
            if (blobs != null) blobs[0] = (long)blobs_out[0];

        }


        //
        // C++:  void cv::dnn::Net::getMemoryConsumption(int layerId, MatShape netInputShape, size_t& weights, size_t& blobs)
        //

        public void getMemoryConsumption(int layerId, MatOfInt netInputShape, long[] weights, long[] blobs)
        {
            ThrowIfDisposed();
            if (netInputShape != null) netInputShape.ThrowIfDisposed();
            Mat netInputShape_mat = netInputShape;
            double[] weights_out = new double[1];
            double[] blobs_out = new double[1];
            dnn_Net_getMemoryConsumption_12(nativeObj, layerId, netInputShape_mat.nativeObj, weights_out, blobs_out);
            if (weights != null) weights[0] = (long)weights_out[0];
            if (blobs != null) blobs[0] = (long)blobs_out[0];

        }


        //
        // C++:  void cv::dnn::Net::enableFusion(bool fusion)
        //

        /**
         * Enables or disables layer fusion in the network.
         * param fusion true to enable the fusion, false to disable. The fusion is enabled by default.
         */
        public void enableFusion(bool fusion)
        {
            ThrowIfDisposed();

            dnn_Net_enableFusion_10(nativeObj, fusion);


        }


        //
        // C++:  void cv::dnn::Net::enableWinograd(bool useWinograd)
        //

        /**
         * Enables or disables the Winograd compute branch. The Winograd compute branch can speed up
         * 3x3 Convolution at a small loss of accuracy.
         * param useWinograd true to enable the Winograd compute branch. The default is true.
         */
        public void enableWinograd(bool useWinograd)
        {
            ThrowIfDisposed();

            dnn_Net_enableWinograd_10(nativeObj, useWinograd);


        }


        //
        // C++:  int64 cv::dnn::Net::getPerfProfile(vector_double& timings)
        //

        /**
         * Returns overall time for inference and timings (in ticks) for layers.
         *
         * Indexes in returned vector correspond to layers ids. Some layers can be fused with others,
         * in this case zero ticks count will be return for that skipped layers. Supported by DNN_BACKEND_OPENCV on DNN_TARGET_CPU only.
         *
         * param timings vector for tick timings for all layers.
         * return overall ticks for model inference.
         */
        public long getPerfProfile(MatOfDouble timings)
        {
            ThrowIfDisposed();
            if (timings != null) timings.ThrowIfDisposed();
            Mat timings_mat = timings;
            return dnn_Net_getPerfProfile_10(nativeObj, timings_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::Net::Net()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_Net_10();

        // C++: static Net cv::dnn::Net::readFromModelOptimizer(String xml, String bin)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_readFromModelOptimizer_10(string xml, string bin);

        // C++: static Net cv::dnn::Net::readFromModelOptimizer(vector_uchar bufferModelConfig, vector_uchar bufferWeights)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_readFromModelOptimizer_11(IntPtr bufferModelConfig_mat_nativeObj, IntPtr bufferWeights_mat_nativeObj);

        // C++:  bool cv::dnn::Net::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_Net_empty_10(IntPtr nativeObj);

        // C++:  String cv::dnn::Net::dump()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_dump_10(IntPtr nativeObj);

        // C++:  void cv::dnn::Net::dumpToFile(String path)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_dumpToFile_10(IntPtr nativeObj, string path);

        // C++:  int cv::dnn::Net::getLayerId(String layer)
        [DllImport(LIBNAME)]
        private static extern int dnn_Net_getLayerId_10(IntPtr nativeObj, string layer);

        // C++:  vector_String cv::dnn::Net::getLayerNames()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getLayerNames_10(IntPtr nativeObj);

        // C++:  Ptr_Layer cv::dnn::Net::getLayer(int layerId)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getLayer_10(IntPtr nativeObj, int layerId);

        // C++:  Ptr_Layer cv::dnn::Net::getLayer(String layerName)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getLayer_11(IntPtr nativeObj, string layerName);

        // C++:  Ptr_Layer cv::dnn::Net::getLayer(LayerId layerId)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getLayer_12(IntPtr nativeObj, IntPtr layerId_nativeObj);

        // C++:  void cv::dnn::Net::connect(String outPin, String inpPin)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_connect_10(IntPtr nativeObj, string outPin, string inpPin);

        // C++:  void cv::dnn::Net::setInputsNames(vector_String inputBlobNames)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setInputsNames_10(IntPtr nativeObj, IntPtr inputBlobNames_mat_nativeObj);

        // C++:  void cv::dnn::Net::setInputShape(String inputName, MatShape shape)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setInputShape_10(IntPtr nativeObj, string inputName, IntPtr shape_mat_nativeObj);

        // C++:  Mat cv::dnn::Net::forward(String outputName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_forward_10(IntPtr nativeObj, string outputName);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_forward_11(IntPtr nativeObj);

        // C++:  void cv::dnn::Net::forward(vector_Mat& outputBlobs, String outputName = String())
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_forward_12(IntPtr nativeObj, IntPtr outputBlobs_mat_nativeObj, string outputName);
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_forward_13(IntPtr nativeObj, IntPtr outputBlobs_mat_nativeObj);

        // C++:  void cv::dnn::Net::forward(vector_Mat& outputBlobs, vector_String outBlobNames)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_forward_14(IntPtr nativeObj, IntPtr outputBlobs_mat_nativeObj, IntPtr outBlobNames_mat_nativeObj);

        // C++:  Net cv::dnn::Net::quantize(vector_Mat calibData, int inputsDtype, int outputsDtype, bool perChannel = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_quantize_10(IntPtr nativeObj, IntPtr calibData_mat_nativeObj, int inputsDtype, int outputsDtype, [MarshalAs(UnmanagedType.U1)] bool perChannel);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_quantize_11(IntPtr nativeObj, IntPtr calibData_mat_nativeObj, int inputsDtype, int outputsDtype);

        // C++:  void cv::dnn::Net::getInputDetails(vector_float& scales, vector_int& zeropoints)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_getInputDetails_10(IntPtr nativeObj, IntPtr scales_mat_nativeObj, IntPtr zeropoints_mat_nativeObj);

        // C++:  void cv::dnn::Net::getOutputDetails(vector_float& scales, vector_int& zeropoints)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_getOutputDetails_10(IntPtr nativeObj, IntPtr scales_mat_nativeObj, IntPtr zeropoints_mat_nativeObj);

        // C++:  void cv::dnn::Net::setHalideScheduler(String scheduler)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setHalideScheduler_10(IntPtr nativeObj, string scheduler);

        // C++:  void cv::dnn::Net::setPreferableBackend(int backendId)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setPreferableBackend_10(IntPtr nativeObj, int backendId);

        // C++:  void cv::dnn::Net::setPreferableTarget(int targetId)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setPreferableTarget_10(IntPtr nativeObj, int targetId);

        // C++:  void cv::dnn::Net::setInput(Mat blob, String name = "", double scalefactor = 1.0, Scalar mean = Scalar())
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setInput_10(IntPtr nativeObj, IntPtr blob_nativeObj, string name, double scalefactor, double mean_val0, double mean_val1, double mean_val2, double mean_val3);
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setInput_11(IntPtr nativeObj, IntPtr blob_nativeObj, string name, double scalefactor);
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setInput_12(IntPtr nativeObj, IntPtr blob_nativeObj, string name);
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setInput_13(IntPtr nativeObj, IntPtr blob_nativeObj);

        // C++:  void cv::dnn::Net::setParam(int layer, int numParam, Mat blob)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setParam_10(IntPtr nativeObj, int layer, int numParam, IntPtr blob_nativeObj);

        // C++:  void cv::dnn::Net::setParam(String layerName, int numParam, Mat blob)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_setParam_11(IntPtr nativeObj, string layerName, int numParam, IntPtr blob_nativeObj);

        // C++:  Mat cv::dnn::Net::getParam(int layer, int numParam = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getParam_10(IntPtr nativeObj, int layer, int numParam);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getParam_11(IntPtr nativeObj, int layer);

        // C++:  Mat cv::dnn::Net::getParam(String layerName, int numParam = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getParam_12(IntPtr nativeObj, string layerName, int numParam);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getParam_13(IntPtr nativeObj, string layerName);

        // C++:  vector_int cv::dnn::Net::getUnconnectedOutLayers()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getUnconnectedOutLayers_10(IntPtr nativeObj);

        // C++:  vector_String cv::dnn::Net::getUnconnectedOutLayersNames()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Net_getUnconnectedOutLayersNames_10(IntPtr nativeObj);

        // C++:  int64 cv::dnn::Net::getFLOPS(vector_MatShape netInputShapes)
        [DllImport(LIBNAME)]
        private static extern long dnn_Net_getFLOPS_10(IntPtr nativeObj, IntPtr netInputShapes_mat_nativeObj);

        // C++:  int64 cv::dnn::Net::getFLOPS(MatShape netInputShape)
        [DllImport(LIBNAME)]
        private static extern long dnn_Net_getFLOPS_11(IntPtr nativeObj, IntPtr netInputShape_mat_nativeObj);

        // C++:  int64 cv::dnn::Net::getFLOPS(int layerId, vector_MatShape netInputShapes)
        [DllImport(LIBNAME)]
        private static extern long dnn_Net_getFLOPS_12(IntPtr nativeObj, int layerId, IntPtr netInputShapes_mat_nativeObj);

        // C++:  int64 cv::dnn::Net::getFLOPS(int layerId, MatShape netInputShape)
        [DllImport(LIBNAME)]
        private static extern long dnn_Net_getFLOPS_13(IntPtr nativeObj, int layerId, IntPtr netInputShape_mat_nativeObj);

        // C++:  void cv::dnn::Net::getLayerTypes(vector_String& layersTypes)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_getLayerTypes_10(IntPtr nativeObj, IntPtr layersTypes_mat_nativeObj);

        // C++:  int cv::dnn::Net::getLayersCount(String layerType)
        [DllImport(LIBNAME)]
        private static extern int dnn_Net_getLayersCount_10(IntPtr nativeObj, string layerType);

        // C++:  void cv::dnn::Net::getMemoryConsumption(MatShape netInputShape, size_t& weights, size_t& blobs)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_getMemoryConsumption_10(IntPtr nativeObj, IntPtr netInputShape_mat_nativeObj, double[] weights_out, double[] blobs_out);

        // C++:  void cv::dnn::Net::getMemoryConsumption(int layerId, vector_MatShape netInputShapes, size_t& weights, size_t& blobs)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_getMemoryConsumption_11(IntPtr nativeObj, int layerId, IntPtr netInputShapes_mat_nativeObj, double[] weights_out, double[] blobs_out);

        // C++:  void cv::dnn::Net::getMemoryConsumption(int layerId, MatShape netInputShape, size_t& weights, size_t& blobs)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_getMemoryConsumption_12(IntPtr nativeObj, int layerId, IntPtr netInputShape_mat_nativeObj, double[] weights_out, double[] blobs_out);

        // C++:  void cv::dnn::Net::enableFusion(bool fusion)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_enableFusion_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool fusion);

        // C++:  void cv::dnn::Net::enableWinograd(bool useWinograd)
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_enableWinograd_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool useWinograd);

        // C++:  int64 cv::dnn::Net::getPerfProfile(vector_double& timings)
        [DllImport(LIBNAME)]
        private static extern long dnn_Net_getPerfProfile_10(IntPtr nativeObj, IntPtr timings_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_Net_delete(IntPtr nativeObj);

    }
}

#endif