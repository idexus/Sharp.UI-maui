﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeItemGeneratedExtension
    {
        public static T BackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            if (backgroundColor != null) mauiObject.BackgroundColor = (Microsoft.Maui.Graphics.Color)backgroundColor;
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            if (backgroundColor != null) mauiObject.BackgroundColor = (Microsoft.Maui.Graphics.Color)backgroundColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool? isVisible)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            if (isVisible != null) mauiObject.IsVisible = (bool)isVisible;
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool? isVisible,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            if (isVisible != null) mauiObject.IsVisible = (bool)isVisible;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.IsVisible = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.IsVisible = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SwipeItem>(obj);
            mauiObject.Invoked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
