﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ActivityIndicatorGeneratedExtension
    {
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color color)
            where T : Sharp.UI.IActivityIndicator
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ActivityIndicator>(obj);
            mauiObject.Color = (Microsoft.Maui.Graphics.Color)color;
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IActivityIndicator
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ActivityIndicator>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.Color = builder.GetValue();
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IActivityIndicator
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ActivityIndicator>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.ActivityIndicator.ColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsRunning<T>(this T obj,
            bool isRunning)
            where T : Sharp.UI.IActivityIndicator
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ActivityIndicator>(obj);
            mauiObject.IsRunning = (bool)isRunning;
            return obj;
        }
        
        public static T IsRunning<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IActivityIndicator
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ActivityIndicator>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsRunning = builder.GetValue();
            return obj;
        }
        
        public static T IsRunning<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IActivityIndicator
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ActivityIndicator>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.ActivityIndicator.IsRunningProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
