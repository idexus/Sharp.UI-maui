﻿//
// <auto-generated>
//

namespace Sharp.UI;


public partial interface ITextCell : ICell { }
public partial interface ICell : IElement { }
public partial interface IElement : IBindableObject { }
public partial interface IBindableObject { }
public partial interface IImageCell : ITextCell { }
public partial interface ISwitchCell : ICell { }
public partial interface IEntryCell : ICell { }
public partial interface IViewCell : ICell { }
public partial interface IGeometry : IBindableObject { }
public partial interface IEllipseGeometry : IGeometry { }
public partial interface ILineGeometry : IGeometry { }
public partial interface IRectangleGeometry : IGeometry { }
public partial interface IGeometryGroup : IGeometry { }
public partial interface IPathGeometry : IGeometry { }
public partial interface IPathFigure : IBindableObject { }
public partial interface IArcSegment : IPathSegment { }
public partial interface IPathSegment : IBindableObject { }
public partial interface IBezierSegment : IPathSegment { }
public partial interface ILineSegment : IPathSegment { }
public partial interface IPolyBezierSegment : IPathSegment { }
public partial interface IPolyLineSegment : IPathSegment { }
public partial interface IPolyQuadraticBezierSegment : IPathSegment { }
public partial interface IQuadraticBezierSegment : IPathSegment { }
public partial interface IAbsoluteLayout : ILayout { }
public partial interface ILayout : IView { }
public partial interface IView : IVisualElement { }
public partial interface IVisualElement : INavigableElement { }
public partial interface INavigableElement : IElement { }
public partial interface IFlexLayout : ILayout { }
public partial interface IGrid : ILayout { }
public partial interface IHorizontalStackLayout : IStackBase { }
public partial interface IStackBase : ILayout { }
public partial interface IStackLayout : IStackBase { }
public partial interface IVerticalStackLayout : IStackBase { }
public partial interface IContentPresenter : ICompatibilityLayout { }
public partial interface ICompatibilityLayout : IView { }
public partial interface IContentPage : ITemplatedPage { }
public partial interface ITemplatedPage : IPage { }
public partial interface IPage : IVisualElement { }
public partial interface IFlyoutPage : IPage { }
public partial interface INavigationPage : IPage { }
public partial interface ITabbedPage : IMultiPagePage { }
public partial interface IMultiPagePage : IPage { }
public partial interface IEllipse : IShape { }
public partial interface IShape : IView { }
public partial interface IPolyline : IShape { }
public partial interface ILine : IShape { }
public partial interface IPath : IShape { }
public partial interface IPolygon : IShape { }
public partial interface IRectangle : IShape { }
public partial interface IRoundRectangle : IShape { }
public partial interface IShell : IPage { }
public partial interface IFlyoutItem : IShellItem { }
public partial interface IShellItem : IShellGroupItem { }
public partial interface IShellGroupItem : IBaseShellItem { }
public partial interface IBaseShellItem : INavigableElement { }
public partial interface ITab : IShellSection { }
public partial interface IShellSection : IShellGroupItem { }
public partial interface IShellContent : IBaseShellItem { }
public partial interface IActivityIndicator : IView { }
public partial interface IBorder : IView { }
public partial interface IBoxView : IView { }
public partial interface IButton : IView { }
public partial interface ICarouselView : IItemsView { }
public partial interface IItemsView : IView { }
public partial interface ICheckBox : IView { }
public partial interface ICollectionView : IReorderableItemsView { }
public partial interface IReorderableItemsView : IGroupableItemsView { }
public partial interface IGroupableItemsView : ISelectableItemsView { }
public partial interface ISelectableItemsView : IStructuredItemsView { }
public partial interface IStructuredItemsView : IItemsView { }
public partial interface IContentView : ITemplatedView { }
public partial interface ITemplatedView : ICompatibilityLayout { }
public partial interface IDatePicker : IView { }
public partial interface IEditor : IInputView { }
public partial interface IInputView : IView { }
public partial interface IEntry : IInputView { }
public partial interface IFrame : IContentView { }
public partial interface IGraphicsView : IView { }
public partial interface IImage : IView { }
public partial interface IImageButton : IView { }
public partial interface IIndicatorView : ITemplatedView { }
public partial interface ILabel : IView { }
public partial interface IListView : IItemsViewCell { }
public partial interface IItemsViewCell : IView { }
public partial interface IPicker : IView { }
public partial interface IProgressBar : IView { }
public partial interface IRadioButton : ITemplatedView { }
public partial interface IRefreshView : IContentView { }
public partial interface IScrollView : ICompatibilityLayout { }
public partial interface ISearchBar : IInputView { }
public partial interface ISlider : IView { }
public partial interface IStepper : IView { }
public partial interface ISwipeView : IContentView { }
public partial interface ISwitch : IView { }
public partial interface ITableView : IView { }
public partial interface ITimePicker : IView { }
public partial interface IWebView : IView { }
public partial interface ISwipeItem : IMenuItem { }
public partial interface IMenuItem : IBaseMenuItem { }
public partial interface IBaseMenuItem : IElement { }
public partial interface ISwipeItemView : IContentView { }
public partial interface ITableSection : ITableSectionBaseCell { }
public partial interface ITableSectionBaseCell : ITableSectionBase { }
public partial interface ITableSectionBase : IBindableObject { }
public partial interface IColumnDefinition : IBindableObject { }
public partial interface IRowDefinition : IBindableObject { }
public partial interface IBinding : IBindingBase { }
public partial interface IBindingBase { }
public partial interface IStyle { }
public partial interface IVisualStateGroupList { }
public partial interface IVisualStateGroup { }
public partial interface IVisualState { }
public partial interface ITrigger : ITriggerBase { }
public partial interface ITriggerBase : IBindableObject { }
public partial interface IDataTrigger : ITriggerBase { }
public partial interface IEventTrigger : ITriggerBase { }
public partial interface IMultiTrigger : ITriggerBase { }
public partial interface IBindingCondition : ICondition { }
public partial interface ICondition { }
public partial interface IPropertyCondition : ICondition { }
public partial interface IStateTrigger : IStateTriggerBase { }
public partial interface IStateTriggerBase : IBindableObject { }
public partial interface IAdaptiveTrigger : IStateTriggerBase { }
public partial interface ICompareStateTrigger : IStateTriggerBase { }
public partial interface IDeviceStateTrigger : IStateTriggerBase { }
public partial interface IOrientationStateTrigger : IStateTriggerBase { }
