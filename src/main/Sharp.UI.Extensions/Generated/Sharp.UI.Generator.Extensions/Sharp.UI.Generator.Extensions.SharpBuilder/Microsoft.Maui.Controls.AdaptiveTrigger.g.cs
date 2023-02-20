﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class AdaptiveTriggerExtension
    {
        public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowHeight(this Microsoft.Maui.Controls.AdaptiveTrigger obj,
            double minWindowHeight)
        {
            obj.MinWindowHeight = minWindowHeight;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowHeight(this Microsoft.Maui.Controls.AdaptiveTrigger obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.MinWindowHeight = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowHeight(this Microsoft.Maui.Controls.AdaptiveTrigger obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowWidth(this Microsoft.Maui.Controls.AdaptiveTrigger obj,
            double minWindowWidth)
        {
            obj.MinWindowWidth = minWindowWidth;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowWidth(this Microsoft.Maui.Controls.AdaptiveTrigger obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.MinWindowWidth = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowWidth(this Microsoft.Maui.Controls.AdaptiveTrigger obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
