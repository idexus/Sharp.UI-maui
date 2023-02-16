﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeGestureRecognizerGeneratedExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.Command = (System.Windows.Input.ICommand)command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.CommandParameter = (object)commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            Microsoft.Maui.SwipeDirection direction)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.Direction = (Microsoft.Maui.SwipeDirection)direction;
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.SwipeDirection>, ValueBuilder<Microsoft.Maui.SwipeDirection>> buildValue)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.SwipeDirection>());
            if (builder.ValueIsSet()) mauiObject.Direction = builder.GetValue();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.SwipeDirection>, BindingBuilder<Microsoft.Maui.SwipeDirection>> buildBinding)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.SwipeDirection>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.DirectionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            uint threshold)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.Threshold = (uint)threshold;
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<ValueBuilder<uint>, ValueBuilder<uint>> buildValue)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildValue(new ValueBuilder<uint>());
            if (builder.ValueIsSet()) mauiObject.Threshold = builder.GetValue();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<BindingBuilder<uint>, BindingBuilder<uint>> buildBinding)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var builder = buildBinding(new BindingBuilder<uint>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.ThresholdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnSwiped<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipedEventArgs> handler)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.Swiped += handler;
            return obj;
        }
        
        public static T OnSwiped<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.Swiped += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
