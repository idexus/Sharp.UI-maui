﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class BoxViewGeneratedExtension
    {
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color? color)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BoxView>(obj);
            if (color != null) mauiObject.Color = (Microsoft.Maui.Graphics.Color)color;
            return obj;
        }
        
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color? color,
            Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BoxView>(obj);
            if (color != null) mauiObject.Color = (Microsoft.Maui.Graphics.Color)color;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.BoxView.ColorProperty));
            if (def.ValueIsSet()) mauiObject.Color = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Color<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BoxView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.BoxView.ColorProperty));
            if (def.ValueIsSet()) mauiObject.Color = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            Microsoft.Maui.CornerRadius? cornerRadius)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BoxView>(obj);
            if (cornerRadius != null) mauiObject.CornerRadius = (Microsoft.Maui.CornerRadius)cornerRadius;
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            Microsoft.Maui.CornerRadius? cornerRadius,
            Func<BindableDef<Microsoft.Maui.CornerRadius>, BindableDef<Microsoft.Maui.CornerRadius>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BoxView>(obj);
            if (cornerRadius != null) mauiObject.CornerRadius = (Microsoft.Maui.CornerRadius)cornerRadius;
            var def = definition(new BindableDef<Microsoft.Maui.CornerRadius>(mauiObject, Microsoft.Maui.Controls.BoxView.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.CornerRadius>, BindableDef<Microsoft.Maui.CornerRadius>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BoxView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.CornerRadius>(mauiObject, Microsoft.Maui.Controls.BoxView.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
