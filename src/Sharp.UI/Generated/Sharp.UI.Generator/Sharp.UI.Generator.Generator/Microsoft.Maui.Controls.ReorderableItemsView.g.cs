﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class ReorderableItemsViewExtension
    {
        public static T CanMixGroups<T>(this T obj,
            bool canMixGroups)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            obj.CanMixGroups = canMixGroups;
            return obj;
        }
        
        public static T CanMixGroups<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.CanMixGroups = builder.GetValue();
            return obj;
        }
        
        public static T CanMixGroups<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CanReorderItems<T>(this T obj,
            bool canReorderItems)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            obj.CanReorderItems = canReorderItems;
            return obj;
        }
        
        public static T CanReorderItems<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.CanReorderItems = builder.GetValue();
            return obj;
        }
        
        public static T CanReorderItems<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnReorderCompleted<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            obj.ReorderCompleted += handler;
            return obj;
        }
        
        public static T OnReorderCompleted<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            obj.ReorderCompleted += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
