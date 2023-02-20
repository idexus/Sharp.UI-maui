﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class CarouselViewExtension
    {
        public static T Loop<T>(this T obj,
            bool loop)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.Loop = loop;
            return obj;
        }
        
        public static T Loop<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.Loop = builder.GetValue();
            return obj;
        }
        
        public static T Loop<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.CarouselView.LoopProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T PeekAreaInsets<T>(this T obj,
            Microsoft.Maui.Thickness peekAreaInsets)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.PeekAreaInsets = peekAreaInsets;
            return obj;
        }
        
        public static T PeekAreaInsets<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.PeekAreaInsets = builder.GetValue();
            return obj;
        }
        
        public static T PeekAreaInsets<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VisibleViews<T>(this T obj,
            IList<Microsoft.Maui.Controls.View> visibleViews)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            foreach (var item in visibleViews)
                obj.VisibleViews.Add(item);
            return obj;
        }

        public static T VisibleViews<T>(this T obj,
            params Microsoft.Maui.Controls.View[] visibleViews)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            foreach (var item in visibleViews)
                obj.VisibleViews.Add(item);
            return obj;
        }
        
        public static T IsBounceEnabled<T>(this T obj,
            bool isBounceEnabled)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.IsBounceEnabled = isBounceEnabled;
            return obj;
        }
        
        public static T IsBounceEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsBounceEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsBounceEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsSwipeEnabled<T>(this T obj,
            bool isSwipeEnabled)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.IsSwipeEnabled = isSwipeEnabled;
            return obj;
        }
        
        public static T IsSwipeEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsSwipeEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsSwipeEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsScrollAnimated<T>(this T obj,
            bool isScrollAnimated)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.IsScrollAnimated = isScrollAnimated;
            return obj;
        }
        
        public static T IsScrollAnimated<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsScrollAnimated = builder.GetValue();
            return obj;
        }
        
        public static T IsScrollAnimated<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            object currentItem)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.CurrentItem = currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CarouselView.CurrentItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CurrentItemChangedCommand<T>(this T obj,
            System.Windows.Input.ICommand currentItemChangedCommand)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.CurrentItemChangedCommand = currentItemChangedCommand;
            return obj;
        }
        
        public static T CurrentItemChangedCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.CurrentItemChangedCommand = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItemChangedCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CurrentItemChangedCommandParameter<T>(this T obj,
            object currentItemChangedCommandParameter)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.CurrentItemChangedCommandParameter = currentItemChangedCommandParameter;
            return obj;
        }
        
        public static T CurrentItemChangedCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CurrentItemChangedCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItemChangedCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            int position)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.Position = position;
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.Position = builder.GetValue();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.CarouselView.PositionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T PositionChangedCommand<T>(this T obj,
            System.Windows.Input.ICommand positionChangedCommand)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.PositionChangedCommand = positionChangedCommand;
            return obj;
        }
        
        public static T PositionChangedCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.PositionChangedCommand = builder.GetValue();
            return obj;
        }
        
        public static T PositionChangedCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T PositionChangedCommandParameter<T>(this T obj,
            object positionChangedCommandParameter)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.PositionChangedCommandParameter = positionChangedCommandParameter;
            return obj;
        }
        
        public static T PositionChangedCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.PositionChangedCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T PositionChangedCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ItemsLayout<T>(this T obj,
            Microsoft.Maui.Controls.LinearItemsLayout itemsLayout)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.ItemsLayout = itemsLayout;
            return obj;
        }
        
        public static T ItemsLayout<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.LinearItemsLayout>, ValueBuilder<Microsoft.Maui.Controls.LinearItemsLayout>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.LinearItemsLayout>());
            if (builder.ValueIsSet()) obj.ItemsLayout = builder.GetValue();
            return obj;
        }
        
        public static T ItemsLayout<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.LinearItemsLayout>, BindingBuilder<Microsoft.Maui.Controls.LinearItemsLayout>> buidBinding)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.LinearItemsLayout>(obj, Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorView<T>(this T obj,
            Microsoft.Maui.Controls.IndicatorView indicatorView)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.IndicatorView = indicatorView;
            return obj;
        }
        
        public static T IndicatorView<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IndicatorView>, ValueBuilder<Microsoft.Maui.Controls.IndicatorView>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.IndicatorView>());
            if (builder.ValueIsSet()) obj.IndicatorView = builder.GetValue();
            return obj;
        }
        
        public static T IsScrolling<T>(this T obj,
            bool isScrolling)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.IsScrolling = isScrolling;
            return obj;
        }
        
        public static T IsScrolling<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsScrolling = builder.GetValue();
            return obj;
        }
        
        public static T OnCurrentItemChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.CurrentItemChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.CurrentItemChanged += handler;
            return obj;
        }
        
        public static T OnCurrentItemChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.CurrentItemChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnPositionChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.PositionChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.PositionChanged += handler;
            return obj;
        }
        
        public static T OnPositionChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.CarouselView
        {
            obj.PositionChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
