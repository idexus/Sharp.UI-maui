﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RadialGradientBrushGeneratedExtension
    {
        public static T Center<T>(this T obj,
            Microsoft.Maui.Graphics.Point center)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            mauiObject.Center = (Microsoft.Maui.Graphics.Point)center;
            return obj;
        }
        
        public static T Center<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) mauiObject.Center = builder.GetValue();
            return obj;
        }
        
        public static T Center<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            double radius)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            mauiObject.Radius = (double)radius;
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.Radius = builder.GetValue();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
