﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwitchGeneratedExtension
    {
        public static T OnColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? onColor)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            if (onColor != null) mauiObject.OnColor = (Microsoft.Maui.Graphics.Color)onColor;
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? onColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            if (onColor != null) mauiObject.OnColor = (Microsoft.Maui.Graphics.Color)onColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Switch.OnColorProperty));
            if (def.ValueIsSet()) mauiObject.OnColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Switch.OnColorProperty));
            if (def.ValueIsSet()) mauiObject.OnColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? thumbColor)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            if (thumbColor != null) mauiObject.ThumbColor = (Microsoft.Maui.Graphics.Color)thumbColor;
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? thumbColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            if (thumbColor != null) mauiObject.ThumbColor = (Microsoft.Maui.Graphics.Color)thumbColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Switch.ThumbColorProperty));
            if (def.ValueIsSet()) mauiObject.ThumbColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Switch.ThumbColorProperty));
            if (def.ValueIsSet()) mauiObject.ThumbColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            bool? isToggled)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            if (isToggled != null) mauiObject.IsToggled = (bool)isToggled;
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            bool? isToggled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            if (isToggled != null) mauiObject.IsToggled = (bool)isToggled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Switch.IsToggledProperty));
            if (def.ValueIsSet()) mauiObject.IsToggled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Switch.IsToggledProperty));
            if (def.ValueIsSet()) mauiObject.IsToggled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnToggled<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.ToggledEventArgs> action)
            where T : Sharp.UI.ISwitch
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Switch>(obj);
            mauiObject.Toggled += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
