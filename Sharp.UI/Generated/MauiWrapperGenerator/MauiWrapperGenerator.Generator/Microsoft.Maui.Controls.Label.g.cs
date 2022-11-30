﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ILabelGeneratedExtension
    {
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform? textTransform)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textTransform != null) mauiObject.TextTransform = (Microsoft.Maui.TextTransform)textTransform;
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform? textTransform,
            Func<BindableDef<Microsoft.Maui.TextTransform>, BindableDef<Microsoft.Maui.TextTransform>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textTransform != null) mauiObject.TextTransform = (Microsoft.Maui.TextTransform)textTransform;
            var def = definition(new BindableDef<Microsoft.Maui.TextTransform>(mauiObject, Microsoft.Maui.Controls.Label.TextTransformProperty));
            if (def.ValueIsSet()) mauiObject.TextTransform = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextTransform>, BindableDef<Microsoft.Maui.TextTransform>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextTransform>(mauiObject, Microsoft.Maui.Controls.Label.TextTransformProperty));
            if (def.ValueIsSet()) mauiObject.TextTransform = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FormattedText<T>(this T obj,
            Microsoft.Maui.Controls.FormattedString? formattedText)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (formattedText != null) mauiObject.FormattedText = (Microsoft.Maui.Controls.FormattedString)formattedText;
            return obj;
        }
        
        public static T FormattedText<T>(this T obj,
            Microsoft.Maui.Controls.FormattedString? formattedText,
            Func<BindableDef<Microsoft.Maui.Controls.FormattedString>, BindableDef<Microsoft.Maui.Controls.FormattedString>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (formattedText != null) mauiObject.FormattedText = (Microsoft.Maui.Controls.FormattedString)formattedText;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FormattedString>(mauiObject, Microsoft.Maui.Controls.Label.FormattedTextProperty));
            if (def.ValueIsSet()) mauiObject.FormattedText = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FormattedText<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.FormattedString>, BindableDef<Microsoft.Maui.Controls.FormattedString>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FormattedString>(mauiObject, Microsoft.Maui.Controls.Label.FormattedTextProperty));
            if (def.ValueIsSet()) mauiObject.FormattedText = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LineBreakMode<T>(this T obj,
            Microsoft.Maui.LineBreakMode? lineBreakMode)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (lineBreakMode != null) mauiObject.LineBreakMode = (Microsoft.Maui.LineBreakMode)lineBreakMode;
            return obj;
        }
        
        public static T LineBreakMode<T>(this T obj,
            Microsoft.Maui.LineBreakMode? lineBreakMode,
            Func<BindableDef<Microsoft.Maui.LineBreakMode>, BindableDef<Microsoft.Maui.LineBreakMode>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (lineBreakMode != null) mauiObject.LineBreakMode = (Microsoft.Maui.LineBreakMode)lineBreakMode;
            var def = definition(new BindableDef<Microsoft.Maui.LineBreakMode>(mauiObject, Microsoft.Maui.Controls.Label.LineBreakModeProperty));
            if (def.ValueIsSet()) mauiObject.LineBreakMode = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LineBreakMode<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.LineBreakMode>, BindableDef<Microsoft.Maui.LineBreakMode>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.LineBreakMode>(mauiObject, Microsoft.Maui.Controls.Label.LineBreakModeProperty));
            if (def.ValueIsSet()) mauiObject.LineBreakMode = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string? text)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (text != null) mauiObject.Text = (string)text;
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string? text,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (text != null) mauiObject.Text = (string)text;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Label.TextProperty));
            if (def.ValueIsSet()) mauiObject.Text = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Label.TextProperty));
            if (def.ValueIsSet()) mauiObject.Text = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor,
            Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Label.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Label.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Label.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Label.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Label.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Label.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextDecorations<T>(this T obj,
            Microsoft.Maui.TextDecorations? textDecorations)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textDecorations != null) mauiObject.TextDecorations = (Microsoft.Maui.TextDecorations)textDecorations;
            return obj;
        }
        
        public static T TextDecorations<T>(this T obj,
            Microsoft.Maui.TextDecorations? textDecorations,
            Func<BindableDef<Microsoft.Maui.TextDecorations>, BindableDef<Microsoft.Maui.TextDecorations>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textDecorations != null) mauiObject.TextDecorations = (Microsoft.Maui.TextDecorations)textDecorations;
            var def = definition(new BindableDef<Microsoft.Maui.TextDecorations>(mauiObject, Microsoft.Maui.Controls.Label.TextDecorationsProperty));
            if (def.ValueIsSet()) mauiObject.TextDecorations = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextDecorations<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextDecorations>, BindableDef<Microsoft.Maui.TextDecorations>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextDecorations>(mauiObject, Microsoft.Maui.Controls.Label.TextDecorationsProperty));
            if (def.ValueIsSet()) mauiObject.TextDecorations = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Label.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Label.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Label.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Label.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LineHeight<T>(this T obj,
            double? lineHeight)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (lineHeight != null) mauiObject.LineHeight = (double)lineHeight;
            return obj;
        }
        
        public static T LineHeight<T>(this T obj,
            double? lineHeight,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (lineHeight != null) mauiObject.LineHeight = (double)lineHeight;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Label.LineHeightProperty));
            if (def.ValueIsSet()) mauiObject.LineHeight = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LineHeight<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Label.LineHeightProperty));
            if (def.ValueIsSet()) mauiObject.LineHeight = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T MaxLines<T>(this T obj,
            int? maxLines)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (maxLines != null) mauiObject.MaxLines = (int)maxLines;
            return obj;
        }
        
        public static T MaxLines<T>(this T obj,
            int? maxLines,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (maxLines != null) mauiObject.MaxLines = (int)maxLines;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Label.MaxLinesProperty));
            if (def.ValueIsSet()) mauiObject.MaxLines = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T MaxLines<T>(this T obj,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Label.MaxLinesProperty));
            if (def.ValueIsSet()) mauiObject.MaxLines = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (padding != null) mauiObject.Padding = (Microsoft.Maui.Thickness)padding;
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding,
            Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (padding != null) mauiObject.Padding = (Microsoft.Maui.Thickness)padding;
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.Label.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.Label.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextType<T>(this T obj,
            Microsoft.Maui.TextType? textType)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textType != null) mauiObject.TextType = (Microsoft.Maui.TextType)textType;
            return obj;
        }
        
        public static T TextType<T>(this T obj,
            Microsoft.Maui.TextType? textType,
            Func<BindableDef<Microsoft.Maui.TextType>, BindableDef<Microsoft.Maui.TextType>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            if (textType != null) mauiObject.TextType = (Microsoft.Maui.TextType)textType;
            var def = definition(new BindableDef<Microsoft.Maui.TextType>(mauiObject, Microsoft.Maui.Controls.Label.TextTypeProperty));
            if (def.ValueIsSet()) mauiObject.TextType = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextType<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextType>, BindableDef<Microsoft.Maui.TextType>> definition)
            where T : Sharp.UI.ILabel
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Label>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextType>(mauiObject, Microsoft.Maui.Controls.Label.TextTypeProperty));
            if (def.ValueIsSet()) mauiObject.TextType = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
