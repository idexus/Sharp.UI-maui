﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class TemplatedViewExtension
    {
        public static T ControlTemplate<T>(this T obj,
            Microsoft.Maui.Controls.ControlTemplate controlTemplate)
            where T : Microsoft.Maui.Controls.TemplatedView
        {
            obj.ControlTemplate = controlTemplate;
            return obj;
        }
        
        public static T ControlTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ControlTemplate>, ValueBuilder<Microsoft.Maui.Controls.ControlTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.TemplatedView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ControlTemplate>());
            if (builder.ValueIsSet()) obj.ControlTemplate = builder.GetValue();
            return obj;
        }
        
        public static T ControlTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ControlTemplate>, BindingBuilder<Microsoft.Maui.Controls.ControlTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.TemplatedView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ControlTemplate>(obj, Microsoft.Maui.Controls.TemplatedView.ControlTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
