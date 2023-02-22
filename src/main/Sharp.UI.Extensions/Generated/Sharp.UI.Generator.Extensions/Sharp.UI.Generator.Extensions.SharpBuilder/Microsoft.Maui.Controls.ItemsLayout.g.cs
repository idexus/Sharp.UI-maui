﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ItemsLayoutExtension
    {
        public static T SnapPointsAlignment<T>(this T obj,
            Microsoft.Maui.Controls.SnapPointsAlignment snapPointsAlignment)
            where T : Microsoft.Maui.Controls.ItemsLayout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsLayout.SnapPointsAlignmentProperty, snapPointsAlignment);
            return obj;
        }
        
        public static T SnapPointsAlignment<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SnapPointsAlignment>, ValueBuilder<Microsoft.Maui.Controls.SnapPointsAlignment>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.SnapPointsAlignment>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsLayout.SnapPointsAlignmentProperty, builder.GetValue());
            return obj;
        }
        
        public static T SnapPointsAlignment<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SnapPointsAlignment>, BindingBuilder<Microsoft.Maui.Controls.SnapPointsAlignment>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.SnapPointsAlignment>(obj, Microsoft.Maui.Controls.ItemsLayout.SnapPointsAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SnapPointsType<T>(this T obj,
            Microsoft.Maui.Controls.SnapPointsType snapPointsType)
            where T : Microsoft.Maui.Controls.ItemsLayout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsLayout.SnapPointsTypeProperty, snapPointsType);
            return obj;
        }
        
        public static T SnapPointsType<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SnapPointsType>, ValueBuilder<Microsoft.Maui.Controls.SnapPointsType>> buidValue)
            where T : Microsoft.Maui.Controls.ItemsLayout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.SnapPointsType>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ItemsLayout.SnapPointsTypeProperty, builder.GetValue());
            return obj;
        }
        
        public static T SnapPointsType<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SnapPointsType>, BindingBuilder<Microsoft.Maui.Controls.SnapPointsType>> buidBinding)
            where T : Microsoft.Maui.Controls.ItemsLayout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.SnapPointsType>(obj, Microsoft.Maui.Controls.ItemsLayout.SnapPointsTypeProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
