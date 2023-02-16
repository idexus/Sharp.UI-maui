﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PropertyConditionGeneratedExtension
    {
        public static T Property<T>(this T obj,
            Microsoft.Maui.Controls.BindableProperty property)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            mauiObject.Property = (Microsoft.Maui.Controls.BindableProperty)property;
            return obj;
        }
        
        public static T Property<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindableProperty>, ValueBuilder<Microsoft.Maui.Controls.BindableProperty>> buildValue)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.BindableProperty>());
            if (builder.ValueIsSet()) mauiObject.Property = builder.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object value)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            mauiObject.Value = (object)value;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Value = builder.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
