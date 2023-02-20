﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class ShellItemExtension
    {
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellSection currentItem)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            obj.CurrentItem = currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ShellSection>, ValueBuilder<Microsoft.Maui.Controls.ShellSection>> buidValue)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ShellSection>());
            if (builder.ValueIsSet()) obj.CurrentItem = builder.GetValue();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ShellSection>, BindingBuilder<Microsoft.Maui.Controls.ShellSection>> buidBinding)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ShellSection>(obj, Microsoft.Maui.Controls.ShellItem.CurrentItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Items<T>(this T obj,
            IList<Microsoft.Maui.Controls.ShellSection> items)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }

        public static T Items<T>(this T obj,
            params Microsoft.Maui.Controls.ShellSection[] items)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            foreach (var item in items)
                obj.Items.Add(item);
            return obj;
        }
        
        public static T Items<T>(this T obj,
            System.Func<BindingBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection>>, BindingBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection>>> buidBinding)
            where T : Microsoft.Maui.Controls.ShellItem
        {
            var builder = buidBinding(new BindingBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellSection>>(obj, Microsoft.Maui.Controls.ShellItem.ItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
