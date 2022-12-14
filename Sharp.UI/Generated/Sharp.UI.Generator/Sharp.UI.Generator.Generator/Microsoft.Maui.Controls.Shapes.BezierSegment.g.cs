﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class BezierSegmentGeneratedExtension
    {
        public static T Point1<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point1)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            if (point1 != null) mauiObject.Point1 = (Microsoft.Maui.Graphics.Point)point1;
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point1,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            if (point1 != null) mauiObject.Point1 = (Microsoft.Maui.Graphics.Point)point1;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.BezierSegment.Point1Property));
            if (def.ValueIsSet()) mauiObject.Point1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.BezierSegment.Point1Property));
            if (def.ValueIsSet()) mauiObject.Point1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point2)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            if (point2 != null) mauiObject.Point2 = (Microsoft.Maui.Graphics.Point)point2;
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point2,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            if (point2 != null) mauiObject.Point2 = (Microsoft.Maui.Graphics.Point)point2;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.BezierSegment.Point2Property));
            if (def.ValueIsSet()) mauiObject.Point2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.BezierSegment.Point2Property));
            if (def.ValueIsSet()) mauiObject.Point2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point3<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point3)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            if (point3 != null) mauiObject.Point3 = (Microsoft.Maui.Graphics.Point)point3;
            return obj;
        }
        
        public static T Point3<T>(this T obj,
            Microsoft.Maui.Graphics.Point? point3,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            if (point3 != null) mauiObject.Point3 = (Microsoft.Maui.Graphics.Point)point3;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.BezierSegment.Point3Property));
            if (def.ValueIsSet()) mauiObject.Point3 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point3<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IBezierSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.BezierSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.BezierSegment.Point3Property));
            if (def.ValueIsSet()) mauiObject.Point3 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
