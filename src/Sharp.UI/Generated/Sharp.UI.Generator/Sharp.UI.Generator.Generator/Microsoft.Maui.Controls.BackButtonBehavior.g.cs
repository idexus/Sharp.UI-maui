﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class BackButtonBehaviorExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            obj.Command = command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.BackButtonBehavior.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            obj.CommandParameter = commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BackButtonBehavior.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IconOverride<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource iconOverride)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            obj.IconOverride = iconOverride;
            return obj;
        }
        
        public static T IconOverride<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.IconOverride = builder.GetValue();
            return obj;
        }
        
        public static T IconOverride<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.BackButtonBehavior.IconOverrideProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            obj.IsEnabled = isEnabled;
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.BackButtonBehavior.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool isVisible)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            obj.IsVisible = isVisible;
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsVisible = builder.GetValue();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.BackButtonBehavior.IsVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextOverride<T>(this T obj,
            string textOverride)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            obj.TextOverride = textOverride;
            return obj;
        }
        
        public static T TextOverride<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.TextOverride = builder.GetValue();
            return obj;
        }
        
        public static T TextOverride<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.BackButtonBehavior
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.BackButtonBehavior.TextOverrideProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
