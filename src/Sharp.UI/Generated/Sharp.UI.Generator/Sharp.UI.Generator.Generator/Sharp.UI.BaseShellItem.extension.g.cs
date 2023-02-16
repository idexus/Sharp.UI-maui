﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class BaseShellItemGeneratedSharpObjectExtension
    {
        public static T ShellItemTemplate<T>(this T obj,
            Sharp.UI.DataTemplate itemTemplate)
            where T : Sharp.UI.IBaseShellItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BaseShellItem>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ItemTemplateProperty, (Sharp.UI.DataTemplate)itemTemplate);
            return obj;
        }
        
        public static T ShellItemTemplate<T>(this T obj,
            System.Func<ValueBuilder<Sharp.UI.DataTemplate>, ValueBuilder<Sharp.UI.DataTemplate>> buildValue)
            where T : Sharp.UI.IBaseShellItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BaseShellItem>(obj);
            var builder = buildValue(new ValueBuilder<Sharp.UI.DataTemplate>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ItemTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellItemTemplate<T>(this T obj,
            System.Func<BindingBuilder<Sharp.UI.DataTemplate>, BindingBuilder<Sharp.UI.DataTemplate>> buildBinding)
            where T : Sharp.UI.IBaseShellItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BaseShellItem>(obj);
            var builder = buildBinding(new BindingBuilder<Sharp.UI.DataTemplate>(mauiObject, Microsoft.Maui.Controls.Shell.ItemTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellItemTemplate<T>(this T obj, System.Func<object> loadTemplate) where T : Sharp.UI.IBaseShellItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BaseShellItem>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ItemTemplateProperty, new Microsoft.Maui.Controls.DataTemplate(loadTemplate));
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
