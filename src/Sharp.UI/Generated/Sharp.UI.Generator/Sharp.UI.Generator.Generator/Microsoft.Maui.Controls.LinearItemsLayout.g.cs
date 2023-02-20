﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class LinearItemsLayoutExtension
    {
        public static T ItemSpacing<T>(this T obj,
            double itemSpacing)
            where T : Microsoft.Maui.Controls.LinearItemsLayout
        {
            obj.ItemSpacing = itemSpacing;
            return obj;
        }
        
        public static T ItemSpacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.LinearItemsLayout
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.ItemSpacing = builder.GetValue();
            return obj;
        }
        
        public static T ItemSpacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.LinearItemsLayout
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
