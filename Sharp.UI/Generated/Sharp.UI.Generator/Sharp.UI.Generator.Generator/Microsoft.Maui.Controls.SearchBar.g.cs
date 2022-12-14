﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SearchBarGeneratedExtension
    {
        public static T CancelButtonColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? cancelButtonColor)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (cancelButtonColor != null) mauiObject.CancelButtonColor = (Microsoft.Maui.Graphics.Color)cancelButtonColor;
            return obj;
        }
        
        public static T CancelButtonColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? cancelButtonColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (cancelButtonColor != null) mauiObject.CancelButtonColor = (Microsoft.Maui.Graphics.Color)cancelButtonColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SearchBar.CancelButtonColorProperty));
            if (def.ValueIsSet()) mauiObject.CancelButtonColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CancelButtonColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SearchBar.CancelButtonColorProperty));
            if (def.ValueIsSet()) mauiObject.CancelButtonColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Windows.Input.ICommand? searchCommand)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (searchCommand != null) mauiObject.SearchCommand = (System.Windows.Input.ICommand)searchCommand;
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Windows.Input.ICommand? searchCommand,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (searchCommand != null) mauiObject.SearchCommand = (System.Windows.Input.ICommand)searchCommand;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SearchBar.SearchCommandProperty));
            if (def.ValueIsSet()) mauiObject.SearchCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SearchBar.SearchCommandProperty));
            if (def.ValueIsSet()) mauiObject.SearchCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            object? searchCommandParameter)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (searchCommandParameter != null) mauiObject.SearchCommandParameter = (object)searchCommandParameter;
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            object? searchCommandParameter,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (searchCommandParameter != null) mauiObject.SearchCommandParameter = (object)searchCommandParameter;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SearchBar.SearchCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.SearchCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SearchBar.SearchCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.SearchCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool? isTextPredictionEnabled)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (isTextPredictionEnabled != null) mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool? isTextPredictionEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (isTextPredictionEnabled != null) mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SearchBar.IsTextPredictionEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsTextPredictionEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SearchBar.IsTextPredictionEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsTextPredictionEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int? cursorPosition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (cursorPosition != null) mauiObject.CursorPosition = (int)cursorPosition;
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int? cursorPosition,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (cursorPosition != null) mauiObject.CursorPosition = (int)cursorPosition;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.SearchBar.CursorPositionProperty));
            if (def.ValueIsSet()) mauiObject.CursorPosition = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.SearchBar.CursorPositionProperty));
            if (def.ValueIsSet()) mauiObject.CursorPosition = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int? selectionLength)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (selectionLength != null) mauiObject.SelectionLength = (int)selectionLength;
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int? selectionLength,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (selectionLength != null) mauiObject.SelectionLength = (int)selectionLength;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.SearchBar.SelectionLengthProperty));
            if (def.ValueIsSet()) mauiObject.SelectionLength = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.SearchBar.SelectionLengthProperty));
            if (def.ValueIsSet()) mauiObject.SelectionLength = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnSearchButtonPressed<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.SearchButtonPressed += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
