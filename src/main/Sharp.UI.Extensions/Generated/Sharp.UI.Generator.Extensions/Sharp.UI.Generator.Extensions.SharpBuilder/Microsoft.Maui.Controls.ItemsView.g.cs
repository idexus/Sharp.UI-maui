﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ItemsViewExtension
    {
        public static T EmptyView<T>(this T obj,
            object emptyView)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewProperty, emptyView);
            return obj;
        }
        
        public static T EmptyView<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewProperty, builder.GetValue());
            return obj;
        }
        
        public static T EmptyView<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.ItemsView.EmptyViewProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate emptyViewTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty, emptyViewTemplate);
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.EmptyViewTemplate = new DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty, itemsSource);
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<ValueBuilder<System.Collections.IEnumerable>, ValueBuilder<System.Collections.IEnumerable>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<System.Collections.IEnumerable>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<BindingBuilder<System.Collections.IEnumerable>, BindingBuilder<System.Collections.IEnumerable>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<System.Collections.IEnumerable>(obj, Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T obj,
            System.Windows.Input.ICommand remainingItemsThresholdReachedCommand)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty, remainingItemsThresholdReachedCommand);
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T obj,
            object remainingItemsThresholdReachedCommandParameter)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, remainingItemsThresholdReachedCommandParameter);
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, builder.GetValue());
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty, builder.GetValue());
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(obj, Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty, builder.GetValue());
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(obj, Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThreshold<T>(this T obj,
            int remainingItemsThreshold)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty, remainingItemsThreshold);
            return obj;
        }
        
        public static T RemainingItemsThreshold<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty, builder.GetValue());
            return obj;
        }
        
        public static T RemainingItemsThreshold<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate itemTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty, itemTemplate);
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.ItemTemplate = new DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T obj,
            Microsoft.Maui.Controls.ItemsUpdatingScrollMode itemsUpdatingScrollMode)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty, itemsUpdatingScrollMode);
            return obj;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>, ValueBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty, builder.GetValue());
            return obj;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>, BindingBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>(obj, Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ScrollToRequestEventArgs> handler)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.ScrollToRequested += handler;
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.ScrollToRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ItemsViewScrolledEventArgs> handler)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.Scrolled += handler;
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.Scrolled += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnRemainingItemsThresholdReached<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.RemainingItemsThresholdReached += handler;
            return obj;
        }
        
        public static T OnRemainingItemsThresholdReached<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            obj.RemainingItemsThresholdReached += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
