﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PickerGeneratedExtension
    {
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Picker.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Picker.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Picker.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Picker.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Picker.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Picker.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Items<T>(this T obj,
            System.Collections.Generic.IList<string> items)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            foreach (var item in items) mauiObject.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            params string[] items)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            foreach (var item in items) mauiObject.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<string>>, Def<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Items.Add(item);
            }
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Collections.IList? itemsSource)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (itemsSource != null) mauiObject.ItemsSource = (System.Collections.IList)itemsSource;
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Collections.IList? itemsSource,
            System.Func<BindableDef<System.Collections.IList>, BindableDef<System.Collections.IList>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (itemsSource != null) mauiObject.ItemsSource = (System.Collections.IList)itemsSource;
            var def = definition(new BindableDef<System.Collections.IList>(mauiObject, Microsoft.Maui.Controls.Picker.ItemsSourceProperty));
            if (def.ValueIsSet()) mauiObject.ItemsSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<BindableDef<System.Collections.IList>, BindableDef<System.Collections.IList>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<System.Collections.IList>(mauiObject, Microsoft.Maui.Controls.Picker.ItemsSourceProperty));
            if (def.ValueIsSet()) mauiObject.ItemsSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedIndex<T>(this T obj,
            int? selectedIndex)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (selectedIndex != null) mauiObject.SelectedIndex = (int)selectedIndex;
            return obj;
        }
        
        public static T SelectedIndex<T>(this T obj,
            int? selectedIndex,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (selectedIndex != null) mauiObject.SelectedIndex = (int)selectedIndex;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Picker.SelectedIndexProperty));
            if (def.ValueIsSet()) mauiObject.SelectedIndex = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedIndex<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Picker.SelectedIndexProperty));
            if (def.ValueIsSet()) mauiObject.SelectedIndex = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            object? selectedItem)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (selectedItem != null) mauiObject.SelectedItem = (object)selectedItem;
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            object? selectedItem,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (selectedItem != null) mauiObject.SelectedItem = (object)selectedItem;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.Picker.SelectedItemProperty));
            if (def.ValueIsSet()) mauiObject.SelectedItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.Picker.SelectedItemProperty));
            if (def.ValueIsSet()) mauiObject.SelectedItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Picker.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Picker.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Picker.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Picker.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string? title)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (title != null) mauiObject.Title = (string)title;
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string? title,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (title != null) mauiObject.Title = (string)title;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Picker.TitleProperty));
            if (def.ValueIsSet()) mauiObject.Title = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Picker.TitleProperty));
            if (def.ValueIsSet()) mauiObject.Title = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? titleColor)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (titleColor != null) mauiObject.TitleColor = (Microsoft.Maui.Graphics.Color)titleColor;
            return obj;
        }
        
        public static T TitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? titleColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (titleColor != null) mauiObject.TitleColor = (Microsoft.Maui.Graphics.Color)titleColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Picker.TitleColorProperty));
            if (def.ValueIsSet()) mauiObject.TitleColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TitleColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Picker.TitleColorProperty));
            if (def.ValueIsSet()) mauiObject.TitleColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemDisplayBinding<T>(this T obj,
            Microsoft.Maui.Controls.BindingBase? itemDisplayBinding)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (itemDisplayBinding != null) mauiObject.ItemDisplayBinding = (Microsoft.Maui.Controls.BindingBase)itemDisplayBinding;
            return obj;
        }
        
        public static T ItemDisplayBinding<T>(this T obj,
            Microsoft.Maui.Controls.BindingBase? itemDisplayBinding,
            System.Func<ValueDef<Microsoft.Maui.Controls.BindingBase>, ValueDef<Microsoft.Maui.Controls.BindingBase>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            if (itemDisplayBinding != null) mauiObject.ItemDisplayBinding = (Microsoft.Maui.Controls.BindingBase)itemDisplayBinding;
            var def = definition(new ValueDef<Microsoft.Maui.Controls.BindingBase>());
            if (def.ValueIsSet()) mauiObject.ItemDisplayBinding = def.GetValue();
            return obj;
        }
        
        public static T ItemDisplayBinding<T>(this T obj,
            System.Func<ValueDef<Microsoft.Maui.Controls.BindingBase>, ValueDef<Microsoft.Maui.Controls.BindingBase>> definition)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Controls.BindingBase>());
            if (def.ValueIsSet()) mauiObject.ItemDisplayBinding = def.GetValue();
            return obj;
        }
        
        public static T OnSelectedIndexChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IPicker
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Picker>(obj);
            mauiObject.SelectedIndexChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
