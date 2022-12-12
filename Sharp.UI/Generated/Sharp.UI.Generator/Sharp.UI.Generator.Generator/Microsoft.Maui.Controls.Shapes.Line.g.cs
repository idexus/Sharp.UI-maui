﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class LineGeneratedExtension
    {
        public static T X1<T>(this T obj,
            double? x1)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (x1 != null) mauiObject.X1 = (double)x1;
            return obj;
        }
        
        public static T X1<T>(this T obj,
            double? x1,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (x1 != null) mauiObject.X1 = (double)x1;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.X1Property));
            if (def.ValueIsSet()) mauiObject.X1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T X1<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.X1Property));
            if (def.ValueIsSet()) mauiObject.X1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Y1<T>(this T obj,
            double? y1)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (y1 != null) mauiObject.Y1 = (double)y1;
            return obj;
        }
        
        public static T Y1<T>(this T obj,
            double? y1,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (y1 != null) mauiObject.Y1 = (double)y1;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.Y1Property));
            if (def.ValueIsSet()) mauiObject.Y1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Y1<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.Y1Property));
            if (def.ValueIsSet()) mauiObject.Y1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T X2<T>(this T obj,
            double? x2)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (x2 != null) mauiObject.X2 = (double)x2;
            return obj;
        }
        
        public static T X2<T>(this T obj,
            double? x2,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (x2 != null) mauiObject.X2 = (double)x2;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.X2Property));
            if (def.ValueIsSet()) mauiObject.X2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T X2<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.X2Property));
            if (def.ValueIsSet()) mauiObject.X2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Y2<T>(this T obj,
            double? y2)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (y2 != null) mauiObject.Y2 = (double)y2;
            return obj;
        }
        
        public static T Y2<T>(this T obj,
            double? y2,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (y2 != null) mauiObject.Y2 = (double)y2;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.Y2Property));
            if (def.ValueIsSet()) mauiObject.Y2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Y2<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Line.Y2Property));
            if (def.ValueIsSet()) mauiObject.Y2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.ILine
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Line>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
