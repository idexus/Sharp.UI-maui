﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class PolygonExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Polygon Points(this Microsoft.Maui.Controls.Shapes.Polygon obj,
            IList<Microsoft.Maui.Graphics.Point> points)
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.Shapes.Polygon Points(this Microsoft.Maui.Controls.Shapes.Polygon obj,
            params Microsoft.Maui.Graphics.Point[] points)
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon Points(this Microsoft.Maui.Controls.Shapes.Polygon obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(obj, Microsoft.Maui.Controls.Shapes.Polygon.PointsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon FillRule(this Microsoft.Maui.Controls.Shapes.Polygon obj,
            Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        {
            obj.FillRule = fillRule;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon FillRule(this Microsoft.Maui.Controls.Shapes.Polygon obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>, ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>());
            if (builder.ValueIsSet()) obj.FillRule = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon FillRule(this Microsoft.Maui.Controls.Shapes.Polygon obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>, BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>(obj, Microsoft.Maui.Controls.Shapes.Polygon.FillRuleProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
