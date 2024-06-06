#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;
using System;
using System.Collections.Generic;

namespace OpenCVForUnity.UtilsModule
{
    public partial class Converters
    {

        public static Mat vector_MatShape_to_Mat(List<MatOfInt> matshapes)
        {

            Mat res;
            int count = (matshapes != null) ? matshapes.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32SC2);
                int[] buff = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    long addr = matshapes[i].nativeObj.ToInt64();//TODO:@check
                    buff[i * 2] = (int)(addr >> 32);
                    buff[i * 2 + 1] = (int)(addr & 0xffffffff);
                }
                res.put(0, 0, buff);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_Target(Mat m, List<int> targets)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (targets == null)
                throw new CvException("targets == null");
            int count = m.rows();
            if (CvType.CV_32SC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC1 != m.type() ||  m.cols()!=1\n" + m);

            targets.Clear();
            int[] buff = new int[count];
            m.get(0, 0, buff);
            for (int i = 0; i < count; i++)
            {
                targets.Add((int)buff[i]);//TODO:@check

            }
        }
    }
}
#endif