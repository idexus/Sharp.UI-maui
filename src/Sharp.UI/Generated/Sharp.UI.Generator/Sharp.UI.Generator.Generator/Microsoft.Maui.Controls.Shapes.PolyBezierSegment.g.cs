﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class PolyBezierSegmentExtension
    {
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment obj,
            IList<Microsoft.Maui.Graphics.Point> points)
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment obj,
            params Microsoft.Maui.Graphics.Point[] points)
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
