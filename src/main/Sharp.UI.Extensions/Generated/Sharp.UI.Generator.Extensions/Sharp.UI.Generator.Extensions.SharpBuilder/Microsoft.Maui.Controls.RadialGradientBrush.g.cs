﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class RadialGradientBrushExtension
    {
        public static T Center<T>(this T obj,
            Microsoft.Maui.Graphics.Point center)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            obj.Center = center;
            return obj;
        }
        
        public static T Center<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.Center = builder.GetValue();
            return obj;
        }
        
        public static T Center<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buidBinding)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(obj, Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            double radius)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            obj.Radius = radius;
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.Radius = builder.GetValue();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
