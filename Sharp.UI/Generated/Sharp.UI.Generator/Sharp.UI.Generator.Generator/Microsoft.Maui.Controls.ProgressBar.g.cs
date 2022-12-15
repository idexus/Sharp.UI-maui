﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ProgressBarGeneratedExtension
    {
        public static T ProgressColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? progressColor)
            where T : Sharp.UI.IProgressBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ProgressBar>(obj);
            if (progressColor != null) mauiObject.ProgressColor = (Microsoft.Maui.Graphics.Color)progressColor;
            return obj;
        }
        
        public static T ProgressColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? progressColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IProgressBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ProgressBar>(obj);         
            if (progressColor != null) mauiObject.ProgressColor = (Microsoft.Maui.Graphics.Color)progressColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.ProgressBar.ProgressColorProperty));
            if (def.ValueIsSet()) mauiObject.ProgressColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ProgressColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IProgressBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ProgressBar>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.ProgressBar.ProgressColorProperty));
            if (def.ValueIsSet()) mauiObject.ProgressColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Progress<T>(this T obj,
            double? progress)
            where T : Sharp.UI.IProgressBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ProgressBar>(obj);
            if (progress != null) mauiObject.Progress = (double)progress;
            return obj;
        }
        
        public static T Progress<T>(this T obj,
            double? progress,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IProgressBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ProgressBar>(obj);         
            if (progress != null) mauiObject.Progress = (double)progress;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.ProgressBar.ProgressProperty));
            if (def.ValueIsSet()) mauiObject.Progress = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Progress<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IProgressBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ProgressBar>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.ProgressBar.ProgressProperty));
            if (def.ValueIsSet()) mauiObject.Progress = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
