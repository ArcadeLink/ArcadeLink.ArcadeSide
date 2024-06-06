

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{
    // C++: class Subdiv2D


    public class Subdiv2D : DisposableOpenCVObject
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
                        imgproc_Subdiv2D_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Subdiv2D(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Subdiv2D __fromPtr__(IntPtr addr) { return new Subdiv2D(addr); }

        // C++: enum <unnamed>
        public const int PTLOC_ERROR = -2;
        public const int PTLOC_OUTSIDE_RECT = -1;
        public const int PTLOC_INSIDE = 0;
        public const int PTLOC_VERTEX = 1;
        public const int PTLOC_ON_EDGE = 2;
        public const int NEXT_AROUND_ORG = 0x00;
        public const int NEXT_AROUND_DST = 0x22;
        public const int PREV_AROUND_ORG = 0x11;
        public const int PREV_AROUND_DST = 0x33;
        public const int NEXT_AROUND_LEFT = 0x13;
        public const int NEXT_AROUND_RIGHT = 0x31;
        public const int PREV_AROUND_LEFT = 0x20;
        public const int PREV_AROUND_RIGHT = 0x02;
        //
        // C++:   cv::Subdiv2D::Subdiv2D()
        //

        /**
         * creates an empty Subdiv2D object.
         *     To create a new empty Delaunay subdivision you need to use the #initDelaunay function.
         */
        public Subdiv2D()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(imgproc_Subdiv2D_Subdiv2D_10());


        }


        //
        // C++:   cv::Subdiv2D::Subdiv2D(Rect rect)
        //

        /**
         *
         *
         *     param rect Rectangle that includes all of the 2D points that are to be added to the subdivision.
         *
         *     The function creates an empty Delaunay subdivision where 2D points can be added using the function
         *     insert() . All of the points to be added must be within the specified rectangle, otherwise a runtime
         *     error is raised.
         */
        public Subdiv2D(Rect rect)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(imgproc_Subdiv2D_Subdiv2D_11(rect.x, rect.y, rect.width, rect.height));


        }


        //
        // C++:  void cv::Subdiv2D::initDelaunay(Rect rect)
        //

        /**
         * Creates a new empty Delaunay subdivision
         *
         *     param rect Rectangle that includes all of the 2D points that are to be added to the subdivision.
         */
        public void initDelaunay(Rect rect)
        {
            ThrowIfDisposed();

            imgproc_Subdiv2D_initDelaunay_10(nativeObj, rect.x, rect.y, rect.width, rect.height);


        }


        //
        // C++:  int cv::Subdiv2D::insert(Point2f pt)
        //

        /**
         * Insert a single point into a Delaunay triangulation.
         *
         *     param pt Point to insert.
         *
         *     The function inserts a single point into a subdivision and modifies the subdivision topology
         *     appropriately. If a point with the same coordinates exists already, no new point is added.
         *     return the ID of the point.
         *
         *     <b>Note:</b> If the point is outside of the triangulation specified rect a runtime error is raised.
         */
        public int insert(Point pt)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_insert_10(nativeObj, pt.x, pt.y);


        }


        //
        // C++:  void cv::Subdiv2D::insert(vector_Point2f ptvec)
        //

        /**
         * Insert multiple points into a Delaunay triangulation.
         *
         *     param ptvec Points to insert.
         *
         *     The function inserts a vector of points into a subdivision and modifies the subdivision topology
         *     appropriately.
         */
        public void insert(MatOfPoint2f ptvec)
        {
            ThrowIfDisposed();
            if (ptvec != null) ptvec.ThrowIfDisposed();
            Mat ptvec_mat = ptvec;
            imgproc_Subdiv2D_insert_11(nativeObj, ptvec_mat.nativeObj);


        }


        //
        // C++:  int cv::Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
        //

        /**
         * Returns the location of a point within a Delaunay triangulation.
         *
         *     param pt Point to locate.
         *     param edge Output edge that the point belongs to or is located to the right of it.
         *     param vertex Optional output vertex the input point coincides with.
         *
         *     The function locates the input point within the subdivision and gives one of the triangle edges
         *     or vertices.
         *
         *     return an integer which specify one of the following five cases for point location:
         * <ul>
         *   <li>
         *       The point falls into some facet. The function returns #PTLOC_INSIDE and edge will contain one of
         *        edges of the facet.
         *   </li>
         *   <li>
         *       The point falls onto the edge. The function returns #PTLOC_ON_EDGE and edge will contain this edge.
         *   </li>
         *   <li>
         *       The point coincides with one of the subdivision vertices. The function returns #PTLOC_VERTEX and
         *        vertex will contain a pointer to the vertex.
         *   </li>
         *   <li>
         *       The point is outside the subdivision reference rectangle. The function returns #PTLOC_OUTSIDE_RECT
         *        and no pointers are filled.
         *   </li>
         *   <li>
         *       One of input arguments is invalid. A runtime error is raised or, if silent or "parent" error
         *        processing mode is selected, #PTLOC_ERROR is returned.
         *   </li>
         * </ul>
         */
        public int locate(Point pt, int[] edge, int[] vertex)
        {
            ThrowIfDisposed();
            double[] edge_out = new double[1];
            double[] vertex_out = new double[1];
            int retVal = imgproc_Subdiv2D_locate_10(nativeObj, pt.x, pt.y, edge_out, vertex_out);
            if (edge != null) edge[0] = (int)edge_out[0];
            if (vertex != null) vertex[0] = (int)vertex_out[0];
            return retVal;
        }


        //
        // C++:  int cv::Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
        //

        /**
         * Finds the subdivision vertex closest to the given point.
         *
         *     param pt Input point.
         *     param nearestPt Output subdivision vertex point.
         *
         *     The function is another function that locates the input point within the subdivision. It finds the
         *     subdivision vertex that is the closest to the input point. It is not necessarily one of vertices
         *     of the facet containing the input point, though the facet (located using locate() ) is used as a
         *     starting point.
         *
         *     return vertex ID.
         */
        public int findNearest(Point pt, Point nearestPt)
        {
            ThrowIfDisposed();
            double[] nearestPt_out = new double[2];
            int retVal = imgproc_Subdiv2D_findNearest_10(nativeObj, pt.x, pt.y, nearestPt_out);
            if (nearestPt != null) { nearestPt.x = nearestPt_out[0]; nearestPt.y = nearestPt_out[1]; }
            return retVal;
        }

        /**
         * Finds the subdivision vertex closest to the given point.
         *
         *     param pt Input point.
         *
         *     The function is another function that locates the input point within the subdivision. It finds the
         *     subdivision vertex that is the closest to the input point. It is not necessarily one of vertices
         *     of the facet containing the input point, though the facet (located using locate() ) is used as a
         *     starting point.
         *
         *     return vertex ID.
         */
        public int findNearest(Point pt)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_findNearest_11(nativeObj, pt.x, pt.y);


        }


        //
        // C++:  void cv::Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
        //

        /**
         * Returns a list of all edges.
         *
         *     param edgeList Output vector.
         *
         *     The function gives each edge as a 4 numbers vector, where each two are one of the edge
         *     vertices. i.e. org_x = v[0], org_y = v[1], dst_x = v[2], dst_y = v[3].
         */
        public void getEdgeList(MatOfFloat4 edgeList)
        {
            ThrowIfDisposed();
            if (edgeList != null) edgeList.ThrowIfDisposed();
            Mat edgeList_mat = edgeList;
            imgproc_Subdiv2D_getEdgeList_10(nativeObj, edgeList_mat.nativeObj);


        }


        //
        // C++:  void cv::Subdiv2D::getLeadingEdgeList(vector_int& leadingEdgeList)
        //

        /**
         * Returns a list of the leading edge ID connected to each triangle.
         *
         *     param leadingEdgeList Output vector.
         *
         *     The function gives one edge ID for each triangle.
         */
        public void getLeadingEdgeList(MatOfInt leadingEdgeList)
        {
            ThrowIfDisposed();
            if (leadingEdgeList != null) leadingEdgeList.ThrowIfDisposed();
            Mat leadingEdgeList_mat = leadingEdgeList;
            imgproc_Subdiv2D_getLeadingEdgeList_10(nativeObj, leadingEdgeList_mat.nativeObj);


        }


        //
        // C++:  void cv::Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
        //

        /**
         * Returns a list of all triangles.
         *
         *     param triangleList Output vector.
         *
         *     The function gives each triangle as a 6 numbers vector, where each two are one of the triangle
         *     vertices. i.e. p1_x = v[0], p1_y = v[1], p2_x = v[2], p2_y = v[3], p3_x = v[4], p3_y = v[5].
         */
        public void getTriangleList(MatOfFloat6 triangleList)
        {
            ThrowIfDisposed();
            if (triangleList != null) triangleList.ThrowIfDisposed();
            Mat triangleList_mat = triangleList;
            imgproc_Subdiv2D_getTriangleList_10(nativeObj, triangleList_mat.nativeObj);


        }


        //
        // C++:  void cv::Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
        //

        /**
         * Returns a list of all Voronoi facets.
         *
         *     param idx Vector of vertices IDs to consider. For all vertices you can pass empty vector.
         *     param facetList Output vector of the Voronoi facets.
         *     param facetCenters Output vector of the Voronoi facets center points.
         */
        public void getVoronoiFacetList(MatOfInt idx, List<MatOfPoint2f> facetList, MatOfPoint2f facetCenters)
        {
            ThrowIfDisposed();
            if (idx != null) idx.ThrowIfDisposed();
            if (facetCenters != null) facetCenters.ThrowIfDisposed();
            Mat idx_mat = idx;
            Mat facetList_mat = new Mat();
            Mat facetCenters_mat = facetCenters;
            imgproc_Subdiv2D_getVoronoiFacetList_10(nativeObj, idx_mat.nativeObj, facetList_mat.nativeObj, facetCenters_mat.nativeObj);
            Converters.Mat_to_vector_vector_Point2f(facetList_mat, facetList);
            facetList_mat.release();

        }


        //
        // C++:  Point2f cv::Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
        //

        /**
         * Returns vertex location from vertex ID.
         *
         *     param vertex vertex ID.
         *     param firstEdge Optional. The first edge ID which is connected to the vertex.
         *     return vertex (x,y)
         */
        public Point getVertex(int vertex, int[] firstEdge)
        {
            ThrowIfDisposed();
            double[] firstEdge_out = new double[1];
            double[] tmpArray = new double[2];
            imgproc_Subdiv2D_getVertex_10(nativeObj, vertex, firstEdge_out, tmpArray);
            Point retVal = new Point(tmpArray);
            if (firstEdge != null) firstEdge[0] = (int)firstEdge_out[0];
            return retVal;
        }

        /**
         * Returns vertex location from vertex ID.
         *
         *     param vertex vertex ID.
         *     return vertex (x,y)
         */
        public Point getVertex(int vertex)
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            imgproc_Subdiv2D_getVertex_11(nativeObj, vertex, tmpArray);
            Point retVal = new Point(tmpArray);

            return retVal;
        }


        //
        // C++:  int cv::Subdiv2D::getEdge(int edge, int nextEdgeType)
        //

        /**
         * Returns one of the edges related to the given edge.
         *
         *     param edge Subdivision edge ID.
         *     param nextEdgeType Parameter specifying which of the related edges to return.
         *     The following values are possible:
         * <ul>
         *   <li>
         *        NEXT_AROUND_ORG next around the edge origin ( eOnext on the picture below if e is the input edge)
         *   </li>
         *   <li>
         *        NEXT_AROUND_DST next around the edge vertex ( eDnext )
         *   </li>
         *   <li>
         *        PREV_AROUND_ORG previous around the edge origin (reversed eRnext )
         *   </li>
         *   <li>
         *        PREV_AROUND_DST previous around the edge destination (reversed eLnext )
         *   </li>
         *   <li>
         *        NEXT_AROUND_LEFT next around the left facet ( eLnext )
         *   </li>
         *   <li>
         *        NEXT_AROUND_RIGHT next around the right facet ( eRnext )
         *   </li>
         *   <li>
         *        PREV_AROUND_LEFT previous around the left facet (reversed eOnext )
         *   </li>
         *   <li>
         *        PREV_AROUND_RIGHT previous around the right facet (reversed eDnext )
         *   </li>
         * </ul>
         *
         *     ![sample output](pics/quadedge.png)
         *
         *     return edge ID related to the input edge.
         */
        public int getEdge(int edge, int nextEdgeType)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_getEdge_10(nativeObj, edge, nextEdgeType);


        }


        //
        // C++:  int cv::Subdiv2D::nextEdge(int edge)
        //

        /**
         * Returns next edge around the edge origin.
         *
         *     param edge Subdivision edge ID.
         *
         *     return an integer which is next edge ID around the edge origin: eOnext on the
         *     picture above if e is the input edge).
         */
        public int nextEdge(int edge)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_nextEdge_10(nativeObj, edge);


        }


        //
        // C++:  int cv::Subdiv2D::rotateEdge(int edge, int rotate)
        //

        /**
         * Returns another edge of the same quad-edge.
         *
         *     param edge Subdivision edge ID.
         *     param rotate Parameter specifying which of the edges of the same quad-edge as the input
         *     one to return. The following values are possible:
         * <ul>
         *   <li>
         *        0 - the input edge ( e on the picture below if e is the input edge)
         *   </li>
         *   <li>
         *        1 - the rotated edge ( eRot )
         *   </li>
         *   <li>
         *        2 - the reversed edge (reversed e (in green))
         *   </li>
         *   <li>
         *        3 - the reversed rotated edge (reversed eRot (in green))
         *   </li>
         * </ul>
         *
         *     return one of the edges ID of the same quad-edge as the input edge.
         */
        public int rotateEdge(int edge, int rotate)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_rotateEdge_10(nativeObj, edge, rotate);


        }


        //
        // C++:  int cv::Subdiv2D::symEdge(int edge)
        //

        public int symEdge(int edge)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_symEdge_10(nativeObj, edge);


        }


        //
        // C++:  int cv::Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
        //

        /**
         * Returns the edge origin.
         *
         *     param edge Subdivision edge ID.
         *     param orgpt Output vertex location.
         *
         *     return vertex ID.
         */
        public int edgeOrg(int edge, Point orgpt)
        {
            ThrowIfDisposed();
            double[] orgpt_out = new double[2];
            int retVal = imgproc_Subdiv2D_edgeOrg_10(nativeObj, edge, orgpt_out);
            if (orgpt != null) { orgpt.x = orgpt_out[0]; orgpt.y = orgpt_out[1]; }
            return retVal;
        }

        /**
         * Returns the edge origin.
         *
         *     param edge Subdivision edge ID.
         *
         *     return vertex ID.
         */
        public int edgeOrg(int edge)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_edgeOrg_11(nativeObj, edge);


        }


        //
        // C++:  int cv::Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
        //

        /**
         * Returns the edge destination.
         *
         *     param edge Subdivision edge ID.
         *     param dstpt Output vertex location.
         *
         *     return vertex ID.
         */
        public int edgeDst(int edge, Point dstpt)
        {
            ThrowIfDisposed();
            double[] dstpt_out = new double[2];
            int retVal = imgproc_Subdiv2D_edgeDst_10(nativeObj, edge, dstpt_out);
            if (dstpt != null) { dstpt.x = dstpt_out[0]; dstpt.y = dstpt_out[1]; }
            return retVal;
        }

        /**
         * Returns the edge destination.
         *
         *     param edge Subdivision edge ID.
         *
         *     return vertex ID.
         */
        public int edgeDst(int edge)
        {
            ThrowIfDisposed();

            return imgproc_Subdiv2D_edgeDst_11(nativeObj, edge);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::Subdiv2D::Subdiv2D()
        [DllImport(LIBNAME)]
        private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_10();

        // C++:   cv::Subdiv2D::Subdiv2D(Rect rect)
        [DllImport(LIBNAME)]
        private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_11(int rect_x, int rect_y, int rect_width, int rect_height);

        // C++:  void cv::Subdiv2D::initDelaunay(Rect rect)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_initDelaunay_10(IntPtr nativeObj, int rect_x, int rect_y, int rect_width, int rect_height);

        // C++:  int cv::Subdiv2D::insert(Point2f pt)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_insert_10(IntPtr nativeObj, double pt_x, double pt_y);

        // C++:  void cv::Subdiv2D::insert(vector_Point2f ptvec)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_insert_11(IntPtr nativeObj, IntPtr ptvec_mat_nativeObj);

        // C++:  int cv::Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_locate_10(IntPtr nativeObj, double pt_x, double pt_y, double[] edge_out, double[] vertex_out);

        // C++:  int cv::Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_findNearest_10(IntPtr nativeObj, double pt_x, double pt_y, double[] nearestPt_out);
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_findNearest_11(IntPtr nativeObj, double pt_x, double pt_y);

        // C++:  void cv::Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getEdgeList_10(IntPtr nativeObj, IntPtr edgeList_mat_nativeObj);

        // C++:  void cv::Subdiv2D::getLeadingEdgeList(vector_int& leadingEdgeList)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getLeadingEdgeList_10(IntPtr nativeObj, IntPtr leadingEdgeList_mat_nativeObj);

        // C++:  void cv::Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getTriangleList_10(IntPtr nativeObj, IntPtr triangleList_mat_nativeObj);

        // C++:  void cv::Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getVoronoiFacetList_10(IntPtr nativeObj, IntPtr idx_mat_nativeObj, IntPtr facetList_mat_nativeObj, IntPtr facetCenters_mat_nativeObj);

        // C++:  Point2f cv::Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getVertex_10(IntPtr nativeObj, int vertex, double[] firstEdge_out, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getVertex_11(IntPtr nativeObj, int vertex, double[] retVal);

        // C++:  int cv::Subdiv2D::getEdge(int edge, int nextEdgeType)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_getEdge_10(IntPtr nativeObj, int edge, int nextEdgeType);

        // C++:  int cv::Subdiv2D::nextEdge(int edge)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_nextEdge_10(IntPtr nativeObj, int edge);

        // C++:  int cv::Subdiv2D::rotateEdge(int edge, int rotate)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_rotateEdge_10(IntPtr nativeObj, int edge, int rotate);

        // C++:  int cv::Subdiv2D::symEdge(int edge)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_symEdge_10(IntPtr nativeObj, int edge);

        // C++:  int cv::Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeOrg_10(IntPtr nativeObj, int edge, double[] orgpt_out);
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeOrg_11(IntPtr nativeObj, int edge);

        // C++:  int cv::Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeDst_10(IntPtr nativeObj, int edge, double[] dstpt_out);
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeDst_11(IntPtr nativeObj, int edge);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_delete(IntPtr nativeObj);

    }
}
