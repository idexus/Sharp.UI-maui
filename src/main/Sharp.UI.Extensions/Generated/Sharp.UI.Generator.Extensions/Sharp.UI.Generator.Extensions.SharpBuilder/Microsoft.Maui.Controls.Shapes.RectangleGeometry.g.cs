﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class RectangleGeometryExtension
    {
        public static T Rect<T>(this T obj,
            Microsoft.Maui.Graphics.Rect rect)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty, rect);
            return obj;
        }
        
        public static T Rect<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Rect>, ValueBuilder<Microsoft.Maui.Graphics.Rect>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty, builder.GetValue());
            return obj;
        }
        
        public static T Rect<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Rect>, BindingBuilder<Microsoft.Maui.Graphics.Rect>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Rect>(obj, Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
