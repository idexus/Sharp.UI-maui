﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IVisualStateGeneratedExtension
    {
        public static T Name<T>(this T obj,
            string? name)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            if (name != null) mauiObject.Name = (string)name;
            return obj;
        }
        
        public static T Name<T>(this T obj,
            string? name,
            Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            if (name != null) mauiObject.Name = (string)name;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Name = def.GetValue();
            return obj;
        }
        
        public static T Name<T>(this T obj,
            Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Name = def.GetValue();
            return obj;
        }
        
        public static T TargetType<T>(this T obj,
            System.Type? targetType)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            if (targetType != null) mauiObject.TargetType = (System.Type)targetType;
            return obj;
        }
        
        public static T TargetType<T>(this T obj,
            System.Type? targetType,
            Func<ValueDef<System.Type>, ValueDef<System.Type>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            if (targetType != null) mauiObject.TargetType = (System.Type)targetType;
            var def = definition(new ValueDef<System.Type>());
            if (def.ValueIsSet()) mauiObject.TargetType = def.GetValue();
            return obj;
        }
        
        public static T TargetType<T>(this T obj,
            Func<ValueDef<System.Type>, ValueDef<System.Type>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new ValueDef<System.Type>());
            if (def.ValueIsSet()) mauiObject.TargetType = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
