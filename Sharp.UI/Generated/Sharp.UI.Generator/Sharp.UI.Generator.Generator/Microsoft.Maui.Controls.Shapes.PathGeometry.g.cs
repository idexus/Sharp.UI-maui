﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PathGeometryGeneratedExtension
    {
        public static T Figures<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.PathFigureCollection? figures)
            where T : Sharp.UI.IPathGeometry
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PathGeometry>(obj);
            if (figures != null) mauiObject.Figures = (Microsoft.Maui.Controls.Shapes.PathFigureCollection)figures;
            return obj;
        }
        
        public static T Figures<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.PathFigureCollection? figures,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.PathFigureCollection>, BindableDef<Microsoft.Maui.Controls.Shapes.PathFigureCollection>> definition)
            where T : Sharp.UI.IPathGeometry
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PathGeometry>(obj);
            if (figures != null) mauiObject.Figures = (Microsoft.Maui.Controls.Shapes.PathFigureCollection)figures;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.PathFigureCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.PathGeometry.FiguresProperty));
            if (def.ValueIsSet()) mauiObject.Figures = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Figures<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.PathFigureCollection>, BindableDef<Microsoft.Maui.Controls.Shapes.PathFigureCollection>> definition)
            where T : Sharp.UI.IPathGeometry
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PathGeometry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.PathFigureCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.PathGeometry.FiguresProperty));
            if (def.ValueIsSet()) mauiObject.Figures = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FillRule<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.FillRule? fillRule)
            where T : Sharp.UI.IPathGeometry
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PathGeometry>(obj);
            if (fillRule != null) mauiObject.FillRule = (Microsoft.Maui.Controls.Shapes.FillRule)fillRule;
            return obj;
        }
        
        public static T FillRule<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.FillRule? fillRule,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>, BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>> definition)
            where T : Sharp.UI.IPathGeometry
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PathGeometry>(obj);
            if (fillRule != null) mauiObject.FillRule = (Microsoft.Maui.Controls.Shapes.FillRule)fillRule;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>(mauiObject, Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty));
            if (def.ValueIsSet()) mauiObject.FillRule = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FillRule<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>, BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>> definition)
            where T : Sharp.UI.IPathGeometry
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.PathGeometry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>(mauiObject, Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty));
            if (def.ValueIsSet()) mauiObject.FillRule = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
