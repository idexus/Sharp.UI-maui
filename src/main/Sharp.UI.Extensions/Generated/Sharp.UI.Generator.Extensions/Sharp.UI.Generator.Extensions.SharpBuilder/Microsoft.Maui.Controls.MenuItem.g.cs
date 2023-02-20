﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class MenuItemExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.Command = command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.MenuItem.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.CommandParameter = commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.MenuItem.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.IconImageSource = iconImageSource;
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.IconImageSource = builder.GetValue();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            bool isDestructive)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.IsDestructive = isDestructive;
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsDestructive = builder.GetValue();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string text)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.Text = text;
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Text = builder.GetValue();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.MenuItem.TextProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.IsEnabled = isEnabled;
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.MenuItem.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            IList<string> styleClass)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in styleClass)
                obj.StyleClass.Add(item);
            return obj;
        }

        public static T StyleClass<T>(this T obj,
            params string[] styleClass)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in styleClass)
                obj.StyleClass.Add(item);
            return obj;
        }
        
        public static T @class<T>(this T obj,
            IList<string> @class)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in @class)
                obj.@class.Add(item);
            return obj;
        }

        public static T @class<T>(this T obj,
            params string[] @class)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in @class)
                obj.@class.Add(item);
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.Clicked += handler;
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            obj.Clicked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
