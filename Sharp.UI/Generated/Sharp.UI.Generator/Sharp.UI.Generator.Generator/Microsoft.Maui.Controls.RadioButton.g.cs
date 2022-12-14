﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RadioButtonGeneratedExtension
    {
        public static T Content<T>(this T obj,
            object? content)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (content != null) mauiObject.Content = (object)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            object? content,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (content != null) mauiObject.Content = (object)content;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.RadioButton.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.RadioButton.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object? value)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (value != null) mauiObject.Value = (object)value;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object? value,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (value != null) mauiObject.Value = (object)value;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.RadioButton.ValueProperty));
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.RadioButton.ValueProperty));
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            bool? isChecked)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (isChecked != null) mauiObject.IsChecked = (bool)isChecked;
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            bool? isChecked,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (isChecked != null) mauiObject.IsChecked = (bool)isChecked;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty));
            if (def.ValueIsSet()) mauiObject.IsChecked = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty));
            if (def.ValueIsSet()) mauiObject.IsChecked = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            string? groupName)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (groupName != null) mauiObject.GroupName = (string)groupName;
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            string? groupName,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (groupName != null) mauiObject.GroupName = (string)groupName;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.RadioButton.GroupNameProperty));
            if (def.ValueIsSet()) mauiObject.GroupName = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.RadioButton.GroupNameProperty));
            if (def.ValueIsSet()) mauiObject.GroupName = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RadioButton.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RadioButton.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform? textTransform)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (textTransform != null) mauiObject.TextTransform = (Microsoft.Maui.TextTransform)textTransform;
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform? textTransform,
            System.Func<BindableDef<Microsoft.Maui.TextTransform>, BindableDef<Microsoft.Maui.TextTransform>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (textTransform != null) mauiObject.TextTransform = (Microsoft.Maui.TextTransform)textTransform;
            var def = definition(new BindableDef<Microsoft.Maui.TextTransform>(mauiObject, Microsoft.Maui.Controls.RadioButton.TextTransformProperty));
            if (def.ValueIsSet()) mauiObject.TextTransform = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextTransform>, BindableDef<Microsoft.Maui.TextTransform>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextTransform>(mauiObject, Microsoft.Maui.Controls.RadioButton.TextTransformProperty));
            if (def.ValueIsSet()) mauiObject.TextTransform = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double? borderWidth)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (borderWidth != null) mauiObject.BorderWidth = (double)borderWidth;
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double? borderWidth,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (borderWidth != null) mauiObject.BorderWidth = (double)borderWidth;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty));
            if (def.ValueIsSet()) mauiObject.BorderWidth = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty));
            if (def.ValueIsSet()) mauiObject.BorderWidth = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? borderColor)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (borderColor != null) mauiObject.BorderColor = (Microsoft.Maui.Graphics.Color)borderColor;
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? borderColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (borderColor != null) mauiObject.BorderColor = (Microsoft.Maui.Graphics.Color)borderColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RadioButton.BorderColorProperty));
            if (def.ValueIsSet()) mauiObject.BorderColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RadioButton.BorderColorProperty));
            if (def.ValueIsSet()) mauiObject.BorderColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            int? cornerRadius)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (cornerRadius != null) mauiObject.CornerRadius = (int)cornerRadius;
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            int? cornerRadius,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            if (cornerRadius != null) mauiObject.CornerRadius = (int)cornerRadius;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.CheckedChangedEventArgs> action)
            where T : Sharp.UI.IRadioButton
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.CheckedChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
