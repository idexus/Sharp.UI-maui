﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class PathExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Path Data(this Microsoft.Maui.Controls.Shapes.Path obj,
            Microsoft.Maui.Controls.Shapes.Geometry data)
        {
            obj.Data = data;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Path Data(this Microsoft.Maui.Controls.Shapes.Path obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.Geometry>, ValueBuilder<Microsoft.Maui.Controls.Shapes.Geometry>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.Geometry>());
            if (builder.ValueIsSet()) obj.Data = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Path Data(this Microsoft.Maui.Controls.Shapes.Path obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.Geometry>, BindingBuilder<Microsoft.Maui.Controls.Shapes.Geometry>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.Geometry>(obj, Microsoft.Maui.Controls.Shapes.Path.DataProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Path RenderTransform(this Microsoft.Maui.Controls.Shapes.Path obj,
            Microsoft.Maui.Controls.Shapes.Transform renderTransform)
        {
            obj.RenderTransform = renderTransform;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Path RenderTransform(this Microsoft.Maui.Controls.Shapes.Path obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.Transform>, ValueBuilder<Microsoft.Maui.Controls.Shapes.Transform>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.Transform>());
            if (builder.ValueIsSet()) obj.RenderTransform = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Path RenderTransform(this Microsoft.Maui.Controls.Shapes.Path obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.Transform>, BindingBuilder<Microsoft.Maui.Controls.Shapes.Transform>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.Transform>(obj, Microsoft.Maui.Controls.Shapes.Path.RenderTransformProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
