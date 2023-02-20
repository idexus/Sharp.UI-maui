﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class PanGestureRecognizerExtension
    {
        public static T TouchPoints<T>(this T obj,
            int touchPoints)
            where T : Microsoft.Maui.Controls.PanGestureRecognizer
        {
            obj.TouchPoints = touchPoints;
            return obj;
        }
        
        public static T TouchPoints<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.PanGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.TouchPoints = builder.GetValue();
            return obj;
        }
        
        public static T TouchPoints<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.PanGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.PanGestureRecognizer.TouchPointsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnPanUpdated<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.PanUpdatedEventArgs> handler)
            where T : Microsoft.Maui.Controls.PanGestureRecognizer
        {
            obj.PanUpdated += handler;
            return obj;
        }
        
        public static T OnPanUpdated<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.PanGestureRecognizer
        {
            obj.PanUpdated += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
