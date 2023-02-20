﻿namespace Sharp.UI
{
    public static partial class BaseShellItemExtension
    {
        public static T ShellItemTemplate<T>(this T obj, DataTemplate dataTemplate) where T : Element
        {
            obj.SetValue(Microsoft.Maui.Controls.Shell.ItemTemplateProperty, dataTemplate);
            return obj;
        }
    }
}