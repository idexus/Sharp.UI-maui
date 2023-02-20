﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class SkewTransformExtension
    {
        public static T AngleX<T>(this T obj,
            double angleX)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            obj.AngleX = angleX;
            return obj;
        }
        
        public static T AngleX<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.AngleX = builder.GetValue();
            return obj;
        }
        
        public static T AngleX<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T AngleY<T>(this T obj,
            double angleY)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            obj.AngleY = angleY;
            return obj;
        }
        
        public static T AngleY<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.AngleY = builder.GetValue();
            return obj;
        }
        
        public static T AngleY<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CenterX<T>(this T obj,
            double centerX)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            obj.CenterX = centerX;
            return obj;
        }
        
        public static T CenterX<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.CenterX = builder.GetValue();
            return obj;
        }
        
        public static T CenterX<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CenterY<T>(this T obj,
            double centerY)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            obj.CenterY = centerY;
            return obj;
        }
        
        public static T CenterY<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.CenterY = builder.GetValue();
            return obj;
        }
        
        public static T CenterY<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.SkewTransform
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
