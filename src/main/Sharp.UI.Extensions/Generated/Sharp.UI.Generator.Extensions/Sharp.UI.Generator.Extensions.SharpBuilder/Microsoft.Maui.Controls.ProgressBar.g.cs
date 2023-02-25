﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ProgressBarExtension
    {
        public static T ProgressColor<T>(this T self,
            Microsoft.Maui.Graphics.Color progressColor)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ProgressBar.ProgressColorProperty, progressColor);
            return self;
        }
        
        public static T ProgressColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ProgressBar.ProgressColorProperty, builder.GetValue());
            return self;
        }
        
        public static T ProgressColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.ProgressBar.ProgressColorProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateProgressColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            Microsoft.Maui.Graphics.Color fromValue = self.ProgressColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.ProgressColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateProgressColorTo", transform, callback, length, easing);
        }
        
        public static T Progress<T>(this T self,
            double progress)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ProgressBar.ProgressProperty, progress);
            return self;
        }
        
        public static T Progress<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ProgressBar.ProgressProperty, builder.GetValue());
            return self;
        }
        
        public static T Progress<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.ProgressBar.ProgressProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateProgressTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ProgressBar
        {
            double fromValue = self.Progress;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Progress = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateProgressTo", transform, callback, length, easing);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
