﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RoundRectangleGeneratedExtension
    {
        public static T CornerRadius<T>(this T obj,
            Microsoft.Maui.CornerRadius? cornerRadius)
            where T : Sharp.UI.IRoundRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.RoundRectangle>(obj);
            if (cornerRadius != null) mauiObject.CornerRadius = (Microsoft.Maui.CornerRadius)cornerRadius;
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            Microsoft.Maui.CornerRadius? cornerRadius,
            System.Func<BindableDef<Microsoft.Maui.CornerRadius>, BindableDef<Microsoft.Maui.CornerRadius>> definition)
            where T : Sharp.UI.IRoundRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.RoundRectangle>(obj);
            if (cornerRadius != null) mauiObject.CornerRadius = (Microsoft.Maui.CornerRadius)cornerRadius;
            var def = definition(new BindableDef<Microsoft.Maui.CornerRadius>(mauiObject, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.CornerRadius>, BindableDef<Microsoft.Maui.CornerRadius>> definition)
            where T : Sharp.UI.IRoundRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.RoundRectangle>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.CornerRadius>(mauiObject, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class)
            where T : Sharp.UI.IRoundRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.RoundRectangle>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class,
            System.Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IRoundRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.RoundRectangle>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IRoundRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.RoundRectangle>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
