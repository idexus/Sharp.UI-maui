﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ArcSegmentGeneratedExtension
    {
        public static T Point<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (point != null) mauiObject.Point = (Microsoft.Maui.Graphics.Point)point;
            return obj;
        }
        
        public static T Point<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point,
            Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (point != null) mauiObject.Point = (Microsoft.Maui.Graphics.Point)point;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty));
            if (def.ValueIsSet()) mauiObject.Point = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty));
            if (def.ValueIsSet()) mauiObject.Point = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Size<T>(this T obj,
            Microsoft.Maui.Graphics.Size? size)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (size != null) mauiObject.Size = (Microsoft.Maui.Graphics.Size)size;
            return obj;
        }
        
        public static T Size<T>(this T obj,
            Microsoft.Maui.Graphics.Size? size,
            Func<BindableDef<Microsoft.Maui.Graphics.Size>, BindableDef<Microsoft.Maui.Graphics.Size>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (size != null) mauiObject.Size = (Microsoft.Maui.Graphics.Size)size;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Size>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty));
            if (def.ValueIsSet()) mauiObject.Size = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Size<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Graphics.Size>, BindableDef<Microsoft.Maui.Graphics.Size>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Size>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty));
            if (def.ValueIsSet()) mauiObject.Size = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RotationAngle<T>(this T obj,
            double? rotationAngle)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (rotationAngle != null) mauiObject.RotationAngle = (double)rotationAngle;
            return obj;
        }
        
        public static T RotationAngle<T>(this T obj,
            double? rotationAngle,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (rotationAngle != null) mauiObject.RotationAngle = (double)rotationAngle;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty));
            if (def.ValueIsSet()) mauiObject.RotationAngle = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RotationAngle<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty));
            if (def.ValueIsSet()) mauiObject.RotationAngle = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SweepDirection<T>(this T obj,
            Microsoft.Maui.Controls.SweepDirection? sweepDirection)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (sweepDirection != null) mauiObject.SweepDirection = (Microsoft.Maui.Controls.SweepDirection)sweepDirection;
            return obj;
        }
        
        public static T SweepDirection<T>(this T obj,
            Microsoft.Maui.Controls.SweepDirection? sweepDirection,
            Func<BindableDef<Microsoft.Maui.Controls.SweepDirection>, BindableDef<Microsoft.Maui.Controls.SweepDirection>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (sweepDirection != null) mauiObject.SweepDirection = (Microsoft.Maui.Controls.SweepDirection)sweepDirection;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SweepDirection>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty));
            if (def.ValueIsSet()) mauiObject.SweepDirection = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SweepDirection<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.SweepDirection>, BindableDef<Microsoft.Maui.Controls.SweepDirection>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SweepDirection>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty));
            if (def.ValueIsSet()) mauiObject.SweepDirection = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsLargeArc<T>(this T obj,
            bool? isLargeArc)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (isLargeArc != null) mauiObject.IsLargeArc = (bool)isLargeArc;
            return obj;
        }
        
        public static T IsLargeArc<T>(this T obj,
            bool? isLargeArc,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            if (isLargeArc != null) mauiObject.IsLargeArc = (bool)isLargeArc;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty));
            if (def.ValueIsSet()) mauiObject.IsLargeArc = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsLargeArc<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IArcSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.ArcSegment>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty));
            if (def.ValueIsSet()) mauiObject.IsLargeArc = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
