﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class RowDefinitionExtension
    {
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition obj,
            Microsoft.Maui.GridLength height)
        {
            obj.Height = height;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition obj,
            System.Func<ValueBuilder<Microsoft.Maui.GridLength>, ValueBuilder<Microsoft.Maui.GridLength>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.GridLength>());
            if (builder.ValueIsSet()) obj.Height = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition obj,
            System.Func<BindingBuilder<Microsoft.Maui.GridLength>, BindingBuilder<Microsoft.Maui.GridLength>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.GridLength>(obj, Microsoft.Maui.Controls.RowDefinition.HeightProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition OnSizeChanged(this Microsoft.Maui.Controls.RowDefinition obj, System.EventHandler handler)
        {
            obj.SizeChanged += handler;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition OnSizeChanged(this Microsoft.Maui.Controls.RowDefinition obj, System.Action<Microsoft.Maui.Controls.RowDefinition> action)
        {
            obj.SizeChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
