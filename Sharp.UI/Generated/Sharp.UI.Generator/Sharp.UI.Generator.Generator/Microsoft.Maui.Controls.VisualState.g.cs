﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class VisualStateGeneratedExtension
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
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in setters) mauiObject.Setters.Add(item);
            return obj;
        }

        public static T Setters<T>(this T obj,
            params Microsoft.Maui.Controls.Setter[] setters)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in setters) mauiObject.Setters.Add(item);
            return obj;
        }

        public static T Setters<T>(this T obj,
            Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Setters.Add(item);
            }
            return obj;
        }
        
        public static T StateTriggers<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase> stateTriggers)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in stateTriggers) mauiObject.StateTriggers.Add(item);
            return obj;
        }

        public static T StateTriggers<T>(this T obj,
            params Microsoft.Maui.Controls.StateTriggerBase[] stateTriggers)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in stateTriggers) mauiObject.StateTriggers.Add(item);
            return obj;
        }

        public static T StateTriggers<T>(this T obj,
            Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase>>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.StateTriggers.Add(item);
            }
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
