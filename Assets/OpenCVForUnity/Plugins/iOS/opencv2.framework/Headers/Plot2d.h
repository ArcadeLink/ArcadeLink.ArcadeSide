//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/plot.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;
@class Scalar;



NS_ASSUME_NONNULL_BEGIN

// C++: class Plot2d
/**
 *  plot Plot function for Mat data
 *
 * Member of `Plot`
 */
CV_EXPORTS @interface Plot2d : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::plot::Plot2d> nativePtrPlot2d;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::plot::Plot2d>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::plot::Plot2d>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::plot::Plot2d::setMinX(double _plotMinX)
//
- (void)setMinX:(double)_plotMinX NS_SWIFT_NAME(setMinX(_plotMinX:));


//
//  void cv::plot::Plot2d::setMinY(double _plotMinY)
//
- (void)setMinY:(double)_plotMinY NS_SWIFT_NAME(setMinY(_plotMinY:));


//
//  void cv::plot::Plot2d::setMaxX(double _plotMaxX)
//
- (void)setMaxX:(double)_plotMaxX NS_SWIFT_NAME(setMaxX(_plotMaxX:));


//
//  void cv::plot::Plot2d::setMaxY(double _plotMaxY)
//
- (void)setMaxY:(double)_plotMaxY NS_SWIFT_NAME(setMaxY(_plotMaxY:));


//
//  void cv::plot::Plot2d::setPlotLineWidth(int _plotLineWidth)
//
- (void)setPlotLineWidth:(int)_plotLineWidth NS_SWIFT_NAME(setPlotLineWidth(_plotLineWidth:));


//
//  void cv::plot::Plot2d::setNeedPlotLine(bool _needPlotLine)
//
/**
 * Switches data visualization mode
 *
 * @param _needPlotLine if true then neighbour plot points will be connected by lines.
 * In other case data will be plotted as a set of standalone points.
 */
- (void)setNeedPlotLine:(BOOL)_needPlotLine NS_SWIFT_NAME(setNeedPlotLine(_needPlotLine:));


//
//  void cv::plot::Plot2d::setPlotLineColor(Scalar _plotLineColor)
//
- (void)setPlotLineColor:(Scalar*)_plotLineColor NS_SWIFT_NAME(setPlotLineColor(_plotLineColor:));


//
//  void cv::plot::Plot2d::setPlotBackgroundColor(Scalar _plotBackgroundColor)
//
- (void)setPlotBackgroundColor:(Scalar*)_plotBackgroundColor NS_SWIFT_NAME(setPlotBackgroundColor(_plotBackgroundColor:));


//
//  void cv::plot::Plot2d::setPlotAxisColor(Scalar _plotAxisColor)
//
- (void)setPlotAxisColor:(Scalar*)_plotAxisColor NS_SWIFT_NAME(setPlotAxisColor(_plotAxisColor:));


//
//  void cv::plot::Plot2d::setPlotGridColor(Scalar _plotGridColor)
//
- (void)setPlotGridColor:(Scalar*)_plotGridColor NS_SWIFT_NAME(setPlotGridColor(_plotGridColor:));


//
//  void cv::plot::Plot2d::setPlotTextColor(Scalar _plotTextColor)
//
- (void)setPlotTextColor:(Scalar*)_plotTextColor NS_SWIFT_NAME(setPlotTextColor(_plotTextColor:));


//
//  void cv::plot::Plot2d::setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
//
- (void)setPlotSize:(int)_plotSizeWidth _plotSizeHeight:(int)_plotSizeHeight NS_SWIFT_NAME(setPlotSize(_plotSizeWidth:_plotSizeHeight:));


//
//  void cv::plot::Plot2d::setShowGrid(bool needShowGrid)
//
- (void)setShowGrid:(BOOL)needShowGrid NS_SWIFT_NAME(setShowGrid(needShowGrid:));


//
//  void cv::plot::Plot2d::setShowText(bool needShowText)
//
- (void)setShowText:(BOOL)needShowText NS_SWIFT_NAME(setShowText(needShowText:));


//
//  void cv::plot::Plot2d::setGridLinesNumber(int gridLinesNumber)
//
- (void)setGridLinesNumber:(int)gridLinesNumber NS_SWIFT_NAME(setGridLinesNumber(gridLinesNumber:));


//
//  void cv::plot::Plot2d::setInvertOrientation(bool _invertOrientation)
//
- (void)setInvertOrientation:(BOOL)_invertOrientation NS_SWIFT_NAME(setInvertOrientation(_invertOrientation:));


//
//  void cv::plot::Plot2d::setPointIdxToPrint(int pointIdx)
//
/**
 * Sets the index of a point which coordinates will be printed on the top left corner of the plot (if ShowText flag is true).
 *
 * @param pointIdx index of the required point in data array.
 */
- (void)setPointIdxToPrint:(int)pointIdx NS_SWIFT_NAME(setPointIdxToPrint(pointIdx:));


//
//  void cv::plot::Plot2d::render(Mat& _plotResult)
//
- (void)render:(Mat*)_plotResult NS_SWIFT_NAME(render(_plotResult:));


//
// static Ptr_Plot2d cv::plot::Plot2d::create(Mat data)
//
/**
 * Creates Plot2d object
 *
 * @param data `$$1xN$$` or `$$Nx1$$` matrix containing `$$Y$$` values of points to plot. `$$X$$` values
 * will be equal to indexes of correspondind elements in data matrix.
 */
+ (Plot2d*)create:(Mat*)data NS_SWIFT_NAME(create(data:));


//
// static Ptr_Plot2d cv::plot::Plot2d::create(Mat dataX, Mat dataY)
//
/**
 * Creates Plot2d object
 *
 * @param dataX `$$1xN$$` or `$$Nx1$$` matrix `$$X$$` values of points to plot.
 * @param dataY `$$1xN$$` or `$$Nx1$$` matrix containing `$$Y$$` values of points to plot.
 */
+ (Plot2d*)create:(Mat*)dataX dataY:(Mat*)dataY NS_SWIFT_NAME(create(dataX:dataY:));



@end

NS_ASSUME_NONNULL_END


