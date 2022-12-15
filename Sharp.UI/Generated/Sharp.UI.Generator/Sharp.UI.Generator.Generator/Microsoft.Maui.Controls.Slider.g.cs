﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SliderGeneratedExtension
    {
        public static T MinimumTrackColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? minimumTrackColor)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (minimumTrackColor != null) mauiObject.MinimumTrackColor = (Microsoft.Maui.Graphics.Color)minimumTrackColor;
            return obj;
        }
        
        public static T MinimumTrackColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? minimumTrackColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (minimumTrackColor != null) mauiObject.MinimumTrackColor = (Microsoft.Maui.Graphics.Color)minimumTrackColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Slider.MinimumTrackColorProperty));
            if (def.ValueIsSet()) mauiObject.MinimumTrackColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T MinimumTrackColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Slider.MinimumTrackColorProperty));
            if (def.ValueIsSet()) mauiObject.MinimumTrackColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T MaximumTrackColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? maximumTrackColor)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (maximumTrackColor != null) mauiObject.MaximumTrackColor = (Microsoft.Maui.Graphics.Color)maximumTrackColor;
            return obj;
        }
        
        public static T MaximumTrackColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? maximumTrackColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (maximumTrackColor != null) mauiObject.MaximumTrackColor = (Microsoft.Maui.Graphics.Color)maximumTrackColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Slider.MaximumTrackColorProperty));
            if (def.ValueIsSet()) mauiObject.MaximumTrackColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T MaximumTrackColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Slider.MaximumTrackColorProperty));
            if (def.ValueIsSet()) mauiObject.MaximumTrackColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? thumbColor)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (thumbColor != null) mauiObject.ThumbColor = (Microsoft.Maui.Graphics.Color)thumbColor;
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? thumbColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (thumbColor != null) mauiObject.ThumbColor = (Microsoft.Maui.Graphics.Color)thumbColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Slider.ThumbColorProperty));
            if (def.ValueIsSet()) mauiObject.ThumbColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Slider.ThumbColorProperty));
            if (def.ValueIsSet()) mauiObject.ThumbColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ThumbImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? thumbImageSource)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (thumbImageSource != null) mauiObject.ThumbImageSource = (Microsoft.Maui.Controls.ImageSource)thumbImageSource;
            return obj;
        }
        
        public static T ThumbImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? thumbImageSource,
            System.Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (thumbImageSource != null) mauiObject.ThumbImageSource = (Microsoft.Maui.Controls.ImageSource)thumbImageSource;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.Slider.ThumbImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.ThumbImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ThumbImageSource<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.Slider.ThumbImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.ThumbImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T DragStartedCommand<T>(this T obj,
            System.Windows.Input.ICommand? dragStartedCommand)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (dragStartedCommand != null) mauiObject.DragStartedCommand = (System.Windows.Input.ICommand)dragStartedCommand;
            return obj;
        }
        
        public static T DragStartedCommand<T>(this T obj,
            System.Windows.Input.ICommand? dragStartedCommand,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (dragStartedCommand != null) mauiObject.DragStartedCommand = (System.Windows.Input.ICommand)dragStartedCommand;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.Slider.DragStartedCommandProperty));
            if (def.ValueIsSet()) mauiObject.DragStartedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T DragStartedCommand<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.Slider.DragStartedCommandProperty));
            if (def.ValueIsSet()) mauiObject.DragStartedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T DragCompletedCommand<T>(this T obj,
            System.Windows.Input.ICommand? dragCompletedCommand)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (dragCompletedCommand != null) mauiObject.DragCompletedCommand = (System.Windows.Input.ICommand)dragCompletedCommand;
            return obj;
        }
        
        public static T DragCompletedCommand<T>(this T obj,
            System.Windows.Input.ICommand? dragCompletedCommand,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (dragCompletedCommand != null) mauiObject.DragCompletedCommand = (System.Windows.Input.ICommand)dragCompletedCommand;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.Slider.DragCompletedCommandProperty));
            if (def.ValueIsSet()) mauiObject.DragCompletedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T DragCompletedCommand<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.Slider.DragCompletedCommandProperty));
            if (def.ValueIsSet()) mauiObject.DragCompletedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            double? maximum)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (maximum != null) mauiObject.Maximum = (double)maximum;
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            double? maximum,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (maximum != null) mauiObject.Maximum = (double)maximum;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Slider.MaximumProperty));
            if (def.ValueIsSet()) mauiObject.Maximum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Slider.MaximumProperty));
            if (def.ValueIsSet()) mauiObject.Maximum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            double? minimum)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (minimum != null) mauiObject.Minimum = (double)minimum;
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            double? minimum,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (minimum != null) mauiObject.Minimum = (double)minimum;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Slider.MinimumProperty));
            if (def.ValueIsSet()) mauiObject.Minimum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Slider.MinimumProperty));
            if (def.ValueIsSet()) mauiObject.Minimum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            double? value)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            if (value != null) mauiObject.Value = (double)value;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            double? value,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);         
            if (value != null) mauiObject.Value = (double)value;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Slider.ValueProperty));
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Slider.ValueProperty));
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnValueChanged<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.ValueChangedEventArgs> action)
            where T : Sharp.UI.ISlider
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            mauiObject.ValueChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnDragStarted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            mauiObject.DragStarted += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDragCompleted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISlider
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Slider>(obj);
            mauiObject.DragCompleted += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
