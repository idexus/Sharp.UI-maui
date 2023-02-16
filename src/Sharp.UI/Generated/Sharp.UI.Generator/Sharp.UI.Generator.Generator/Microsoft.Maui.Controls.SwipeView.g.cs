﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeViewGeneratedExtension
    {
        public static T Threshold<T>(this T obj,
            double threshold)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.Threshold = (double)threshold;
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.Threshold = builder.GetValue();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, Microsoft.Maui.Controls.SwipeView.ThresholdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems leftItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.LeftItems = (Microsoft.Maui.Controls.SwipeItems)leftItems;
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SwipeItems>, ValueBuilder<Microsoft.Maui.Controls.SwipeItems>> buildValue)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.SwipeItems>());
            if (builder.ValueIsSet()) mauiObject.LeftItems = builder.GetValue();
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SwipeItems>, BindingBuilder<Microsoft.Maui.Controls.SwipeItems>> buildBinding)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.LeftItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems rightItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.RightItems = (Microsoft.Maui.Controls.SwipeItems)rightItems;
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SwipeItems>, ValueBuilder<Microsoft.Maui.Controls.SwipeItems>> buildValue)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.SwipeItems>());
            if (builder.ValueIsSet()) mauiObject.RightItems = builder.GetValue();
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SwipeItems>, BindingBuilder<Microsoft.Maui.Controls.SwipeItems>> buildBinding)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.RightItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems topItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.TopItems = (Microsoft.Maui.Controls.SwipeItems)topItems;
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SwipeItems>, ValueBuilder<Microsoft.Maui.Controls.SwipeItems>> buildValue)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.SwipeItems>());
            if (builder.ValueIsSet()) mauiObject.TopItems = builder.GetValue();
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SwipeItems>, BindingBuilder<Microsoft.Maui.Controls.SwipeItems>> buildBinding)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.TopItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems bottomItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.BottomItems = (Microsoft.Maui.Controls.SwipeItems)bottomItems;
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SwipeItems>, ValueBuilder<Microsoft.Maui.Controls.SwipeItems>> buildValue)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.SwipeItems>());
            if (builder.ValueIsSet()) mauiObject.BottomItems = builder.GetValue();
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SwipeItems>, BindingBuilder<Microsoft.Maui.Controls.SwipeItems>> buildBinding)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.BottomItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnSwipeStarted<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipeStartedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeStarted += handler;
            return obj;
        }
        
        public static T OnSwipeStarted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeStarted += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnSwipeChanging<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipeChangingEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeChanging += handler;
            return obj;
        }
        
        public static T OnSwipeChanging<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeChanging += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnSwipeEnded<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipeEndedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeEnded += handler;
            return obj;
        }
        
        public static T OnSwipeEnded<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeEnded += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnOpenRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.OpenRequestedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.OpenRequested += handler;
            return obj;
        }
        
        public static T OnOpenRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.OpenRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnCloseRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.CloseRequestedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.CloseRequested += handler;
            return obj;
        }
        
        public static T OnCloseRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.CloseRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
