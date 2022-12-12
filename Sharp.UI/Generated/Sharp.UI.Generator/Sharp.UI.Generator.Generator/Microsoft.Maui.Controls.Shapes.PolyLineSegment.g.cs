﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PolyLineSegmentGeneratedExtension
    {
        public static T Points<T>(this T obj,
            Microsoft.Maui.Controls.PointCollection? points)
            where T : Sharp.UI.IPolyLineSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PolyLineSegment>(obj);
            if (points != null) mauiObject.Points = (Microsoft.Maui.Controls.PointCollection)points;
            return obj;
        }
        
        public static T Points<T>(this T obj,
            Microsoft.Maui.Controls.PointCollection? points,
            Func<BindableDef<Microsoft.Maui.Controls.PointCollection>, BindableDef<Microsoft.Maui.Controls.PointCollection>> definition)
            where T : Sharp.UI.IPolyLineSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PolyLineSegment>(obj);
            if (points != null) mauiObject.Points = (Microsoft.Maui.Controls.PointCollection)points;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.PointCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty));
            if (def.ValueIsSet()) mauiObject.Points = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Points<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.PointCollection>, BindableDef<Microsoft.Maui.Controls.PointCollection>> definition)
            where T : Sharp.UI.IPolyLineSegment
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PolyLineSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.PointCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty));
            if (def.ValueIsSet()) mauiObject.Points = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
