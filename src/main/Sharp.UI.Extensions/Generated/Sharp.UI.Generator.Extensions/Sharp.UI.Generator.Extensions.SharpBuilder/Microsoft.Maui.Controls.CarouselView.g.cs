﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class CarouselViewExtension
    {
        public static T Loop<T>(this T self,
            bool loop)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.LoopProperty, loop);
            return self;
        }
        
        public static T Loop<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.LoopProperty);
            configure(context).Build();
            return self;
        }
        
        public static T PeekAreaInsets<T>(this T self,
            Microsoft.Maui.Thickness peekAreaInsets)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, peekAreaInsets);
            return self;
        }
        
        public static T PeekAreaInsets<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T VisibleViews<T>(this T self,
            IList<Microsoft.Maui.Controls.View> visibleViews)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            foreach (var item in visibleViews)
                self.VisibleViews.Add(item);
            return self;
        }

        public static T VisibleViews<T>(this T self,
            params Microsoft.Maui.Controls.View[] visibleViews)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            foreach (var item in visibleViews)
                self.VisibleViews.Add(item);
            return self;
        }
        
        public static T VisibleViews<T>(this T self, Func<PropertyContext<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>, IPropertyBuilder<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>(self, Microsoft.Maui.Controls.CarouselView.VisibleViewsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IsBounceEnabled<T>(this T self,
            bool isBounceEnabled)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty, isBounceEnabled);
            return self;
        }
        
        public static T IsBounceEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IsSwipeEnabled<T>(this T self,
            bool isSwipeEnabled)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty, isSwipeEnabled);
            return self;
        }
        
        public static T IsSwipeEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IsScrollAnimated<T>(this T self,
            bool isScrollAnimated)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty, isScrollAnimated);
            return self;
        }
        
        public static T IsScrollAnimated<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CurrentItem<T>(this T self,
            object currentItem)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.CurrentItemProperty, currentItem);
            return self;
        }
        
        public static T CurrentItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.CarouselView.CurrentItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CurrentItemChangedCommand<T>(this T self,
            System.Windows.Input.ICommand currentItemChangedCommand)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty, currentItemChangedCommand);
            return self;
        }
        
        public static T CurrentItemChangedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CurrentItemChangedCommandParameter<T>(this T self,
            object currentItemChangedCommandParameter)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty, currentItemChangedCommandParameter);
            return self;
        }
        
        public static T CurrentItemChangedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Position<T>(this T self,
            int position)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.PositionProperty, position);
            return self;
        }
        
        public static T Position<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.CarouselView.PositionProperty);
            configure(context).Build();
            return self;
        }
        
        public static T PositionChangedCommand<T>(this T self,
            System.Windows.Input.ICommand positionChangedCommand)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty, positionChangedCommand);
            return self;
        }
        
        public static T PositionChangedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T PositionChangedCommandParameter<T>(this T self,
            object positionChangedCommandParameter)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty, positionChangedCommandParameter);
            return self;
        }
        
        public static T PositionChangedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemsLayout<T>(this T self,
            Microsoft.Maui.Controls.LinearItemsLayout itemsLayout)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty, itemsLayout);
            return self;
        }
        
        public static T ItemsLayout<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.LinearItemsLayout>, IPropertyBuilder<Microsoft.Maui.Controls.LinearItemsLayout>> configure)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.LinearItemsLayout>(self, Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IndicatorView<T>(this T self,
            Microsoft.Maui.Controls.IndicatorView indicatorView)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IndicatorView");
            self.IndicatorView = indicatorView;
            return self;
        }
        
        public static T IsScrolling<T>(this T self,
            bool isScrolling)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IsScrolling");
            self.IsScrolling = isScrolling;
            return self;
        }
        
        public static T OnCurrentItemChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.CurrentItemChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.CurrentItemChanged += handler;
            return self;
        }
        
        public static T OnCurrentItemChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.CurrentItemChanged += (o, arg) => action(self);
            return self;
        }
        
        public static T OnPositionChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.PositionChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.PositionChanged += handler;
            return self;
        }
        
        public static T OnPositionChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            self.PositionChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
