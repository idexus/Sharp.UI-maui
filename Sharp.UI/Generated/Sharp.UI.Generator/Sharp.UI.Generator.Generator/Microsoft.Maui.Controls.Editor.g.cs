﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class EditorGeneratedExtension
    {
        public static T AutoSize<T>(this T obj,
            Microsoft.Maui.Controls.EditorAutoSizeOption? autoSize)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (autoSize != null) mauiObject.AutoSize = (Microsoft.Maui.Controls.EditorAutoSizeOption)autoSize;
            return obj;
        }
        
        public static T AutoSize<T>(this T obj,
            Microsoft.Maui.Controls.EditorAutoSizeOption? autoSize,
            Func<BindableDef<Microsoft.Maui.Controls.EditorAutoSizeOption>, BindableDef<Microsoft.Maui.Controls.EditorAutoSizeOption>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (autoSize != null) mauiObject.AutoSize = (Microsoft.Maui.Controls.EditorAutoSizeOption)autoSize;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.EditorAutoSizeOption>(mauiObject, Microsoft.Maui.Controls.Editor.AutoSizeProperty));
            if (def.ValueIsSet()) mauiObject.AutoSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T AutoSize<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.EditorAutoSizeOption>, BindableDef<Microsoft.Maui.Controls.EditorAutoSizeOption>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.EditorAutoSizeOption>(mauiObject, Microsoft.Maui.Controls.Editor.AutoSizeProperty));
            if (def.ValueIsSet()) mauiObject.AutoSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Editor.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Editor.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool? isTextPredictionEnabled)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (isTextPredictionEnabled != null) mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool? isTextPredictionEnabled,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (isTextPredictionEnabled != null) mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Editor.IsTextPredictionEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsTextPredictionEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Editor.IsTextPredictionEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsTextPredictionEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int? cursorPosition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (cursorPosition != null) mauiObject.CursorPosition = (int)cursorPosition;
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int? cursorPosition,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (cursorPosition != null) mauiObject.CursorPosition = (int)cursorPosition;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Editor.CursorPositionProperty));
            if (def.ValueIsSet()) mauiObject.CursorPosition = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Editor.CursorPositionProperty));
            if (def.ValueIsSet()) mauiObject.CursorPosition = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int? selectionLength)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (selectionLength != null) mauiObject.SelectionLength = (int)selectionLength;
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int? selectionLength,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (selectionLength != null) mauiObject.SelectionLength = (int)selectionLength;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Editor.SelectionLengthProperty));
            if (def.ValueIsSet()) mauiObject.SelectionLength = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Editor.SelectionLengthProperty));
            if (def.ValueIsSet()) mauiObject.SelectionLength = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Editor.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Editor.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Editor.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Editor.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Editor.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Editor.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnCompleted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IEditor
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Editor>(obj);
            mauiObject.Completed += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
