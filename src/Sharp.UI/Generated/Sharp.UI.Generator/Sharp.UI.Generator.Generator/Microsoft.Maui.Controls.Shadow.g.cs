﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class ShadowExtension
    {
        public static T Radius<T>(this T obj,
            float radius)
            where T : Microsoft.Maui.Controls.Shadow
        {
            obj.Radius = radius;
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<ValueBuilder<float>, ValueBuilder<float>> buidValue)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidValue(new ValueBuilder<float>());
            if (builder.ValueIsSet()) obj.Radius = builder.GetValue();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<BindingBuilder<float>, BindingBuilder<float>> buidBinding)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidBinding(new BindingBuilder<float>(obj, Microsoft.Maui.Controls.Shadow.RadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Opacity<T>(this T obj,
            float opacity)
            where T : Microsoft.Maui.Controls.Shadow
        {
            obj.Opacity = opacity;
            return obj;
        }
        
        public static T Opacity<T>(this T obj,
            System.Func<ValueBuilder<float>, ValueBuilder<float>> buidValue)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidValue(new ValueBuilder<float>());
            if (builder.ValueIsSet()) obj.Opacity = builder.GetValue();
            return obj;
        }
        
        public static T Opacity<T>(this T obj,
            System.Func<BindingBuilder<float>, BindingBuilder<float>> buidBinding)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidBinding(new BindingBuilder<float>(obj, Microsoft.Maui.Controls.Shadow.OpacityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Brush<T>(this T obj,
            Microsoft.Maui.Controls.Brush brush)
            where T : Microsoft.Maui.Controls.Shadow
        {
            obj.Brush = brush;
            return obj;
        }
        
        public static T Brush<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buidValue)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) obj.Brush = builder.GetValue();
            return obj;
        }
        
        public static T Brush<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buidBinding)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(obj, Microsoft.Maui.Controls.Shadow.BrushProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Offset<T>(this T obj,
            Microsoft.Maui.Graphics.Point offset)
            where T : Microsoft.Maui.Controls.Shadow
        {
            obj.Offset = offset;
            return obj;
        }
        
        public static T Offset<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.Offset = builder.GetValue();
            return obj;
        }
        
        public static T Offset<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buidBinding)
            where T : Microsoft.Maui.Controls.Shadow
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(obj, Microsoft.Maui.Controls.Shadow.OffsetProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
