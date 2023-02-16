﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class GradientBrushGeneratedExtension
    {
        public static T GradientStops<T>(this T obj,
            Microsoft.Maui.Controls.GradientStopCollection gradientStops)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            mauiObject.GradientStops = (Microsoft.Maui.Controls.GradientStopCollection)gradientStops;
            return obj;
        }
        
        public static T GradientStops<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.GradientStopCollection>, ValueBuilder<Microsoft.Maui.Controls.GradientStopCollection>> buildValue)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.GradientStopCollection>());
            if (builder.ValueIsSet()) mauiObject.GradientStops = builder.GetValue();
            return obj;
        }
        
        public static T GradientStops<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.GradientStopCollection>, BindingBuilder<Microsoft.Maui.Controls.GradientStopCollection>> buildBinding)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.GradientStopCollection>(mauiObject, Microsoft.Maui.Controls.GradientBrush.GradientStopsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnInvalidateGradientBrushRequested<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            mauiObject.InvalidateGradientBrushRequested += handler;
            return obj;
        }
        
        public static T OnInvalidateGradientBrushRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            mauiObject.InvalidateGradientBrushRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
