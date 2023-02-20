﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class BindingBaseExtension
    {
        public static T Mode<T>(this T obj,
            Microsoft.Maui.Controls.BindingMode mode)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            obj.Mode = mode;
            return obj;
        }
        
        public static T Mode<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindingMode>, ValueBuilder<Microsoft.Maui.Controls.BindingMode>> buidValue)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.BindingMode>());
            if (builder.ValueIsSet()) obj.Mode = builder.GetValue();
            return obj;
        }
        
        public static T StringFormat<T>(this T obj,
            string stringFormat)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            obj.StringFormat = stringFormat;
            return obj;
        }
        
        public static T StringFormat<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.StringFormat = builder.GetValue();
            return obj;
        }
        
        public static T TargetNullValue<T>(this T obj,
            object targetNullValue)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            obj.TargetNullValue = targetNullValue;
            return obj;
        }
        
        public static T TargetNullValue<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.TargetNullValue = builder.GetValue();
            return obj;
        }
        
        public static T FallbackValue<T>(this T obj,
            object fallbackValue)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            obj.FallbackValue = fallbackValue;
            return obj;
        }
        
        public static T FallbackValue<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BindingBase
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.FallbackValue = builder.GetValue();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
