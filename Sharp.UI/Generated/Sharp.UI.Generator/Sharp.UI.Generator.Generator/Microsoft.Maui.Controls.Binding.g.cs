﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class BindingGeneratedExtension
    {
        public static T Converter<T>(this T obj,
            Microsoft.Maui.Controls.IValueConverter? converter)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (converter != null) mauiObject.Converter = (Microsoft.Maui.Controls.IValueConverter)converter;
            return obj;
        }
        
        public static T Converter<T>(this T obj,
            Microsoft.Maui.Controls.IValueConverter? converter,
            System.Func<ValueDef<Microsoft.Maui.Controls.IValueConverter>, ValueDef<Microsoft.Maui.Controls.IValueConverter>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (converter != null) mauiObject.Converter = (Microsoft.Maui.Controls.IValueConverter)converter;
            var def = definition(new ValueDef<Microsoft.Maui.Controls.IValueConverter>());
            if (def.ValueIsSet()) mauiObject.Converter = def.GetValue();
            return obj;
        }
        
        public static T Converter<T>(this T obj,
            System.Func<ValueDef<Microsoft.Maui.Controls.IValueConverter>, ValueDef<Microsoft.Maui.Controls.IValueConverter>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Controls.IValueConverter>());
            if (def.ValueIsSet()) mauiObject.Converter = def.GetValue();
            return obj;
        }
        
        public static T ConverterParameter<T>(this T obj,
            object? converterParameter)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (converterParameter != null) mauiObject.ConverterParameter = (object)converterParameter;
            return obj;
        }
        
        public static T ConverterParameter<T>(this T obj,
            object? converterParameter,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (converterParameter != null) mauiObject.ConverterParameter = (object)converterParameter;
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.ConverterParameter = def.GetValue();
            return obj;
        }
        
        public static T ConverterParameter<T>(this T obj,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.ConverterParameter = def.GetValue();
            return obj;
        }
        
        public static T Path<T>(this T obj,
            string? path)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (path != null) mauiObject.Path = (string)path;
            return obj;
        }
        
        public static T Path<T>(this T obj,
            string? path,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (path != null) mauiObject.Path = (string)path;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Path = def.GetValue();
            return obj;
        }
        
        public static T Path<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Path = def.GetValue();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            object? source)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (source != null) mauiObject.Source = (object)source;
            return obj;
        }
        
        public static T Source<T>(this T obj,
            object? source,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (source != null) mauiObject.Source = (object)source;
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.Source = def.GetValue();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.Source = def.GetValue();
            return obj;
        }
        
        public static T UpdateSourceEventName<T>(this T obj,
            string? updateSourceEventName)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (updateSourceEventName != null) mauiObject.UpdateSourceEventName = (string)updateSourceEventName;
            return obj;
        }
        
        public static T UpdateSourceEventName<T>(this T obj,
            string? updateSourceEventName,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            if (updateSourceEventName != null) mauiObject.UpdateSourceEventName = (string)updateSourceEventName;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.UpdateSourceEventName = def.GetValue();
            return obj;
        }
        
        public static T UpdateSourceEventName<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IBinding
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Binding>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.UpdateSourceEventName = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
