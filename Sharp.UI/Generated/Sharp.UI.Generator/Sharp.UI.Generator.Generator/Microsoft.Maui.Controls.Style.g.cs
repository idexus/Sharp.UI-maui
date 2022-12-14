﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StyleGeneratedExtension
    {
        public static T ApplyToDerivedTypes<T>(this T obj,
            bool? applyToDerivedTypes)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (applyToDerivedTypes != null) mauiObject.ApplyToDerivedTypes = (bool)applyToDerivedTypes;
            return obj;
        }
        
        public static T ApplyToDerivedTypes<T>(this T obj,
            bool? applyToDerivedTypes,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (applyToDerivedTypes != null) mauiObject.ApplyToDerivedTypes = (bool)applyToDerivedTypes;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.ApplyToDerivedTypes = def.GetValue();
            return obj;
        }
        
        public static T ApplyToDerivedTypes<T>(this T obj,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.ApplyToDerivedTypes = def.GetValue();
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            Microsoft.Maui.Controls.Style? basedOn)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (basedOn != null) mauiObject.BasedOn = (Microsoft.Maui.Controls.Style)basedOn;
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            Microsoft.Maui.Controls.Style? basedOn,
            System.Func<ValueDef<Microsoft.Maui.Controls.Style>, ValueDef<Microsoft.Maui.Controls.Style>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (basedOn != null) mauiObject.BasedOn = (Microsoft.Maui.Controls.Style)basedOn;
            var def = definition(new ValueDef<Microsoft.Maui.Controls.Style>());
            if (def.ValueIsSet()) mauiObject.BasedOn = def.GetValue();
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            System.Func<ValueDef<Microsoft.Maui.Controls.Style>, ValueDef<Microsoft.Maui.Controls.Style>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Controls.Style>());
            if (def.ValueIsSet()) mauiObject.BasedOn = def.GetValue();
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            string? baseResourceKey)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (baseResourceKey != null) mauiObject.BaseResourceKey = (string)baseResourceKey;
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            string? baseResourceKey,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (baseResourceKey != null) mauiObject.BaseResourceKey = (string)baseResourceKey;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.BaseResourceKey = def.GetValue();
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.BaseResourceKey = def.GetValue();
            return obj;
        }
        
        public static T Behaviors<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior> behaviors)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in behaviors) mauiObject.Behaviors.Add(item);
            return obj;
        }

        public static T Behaviors<T>(this T obj,
            params Microsoft.Maui.Controls.Behavior[] behaviors)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in behaviors) mauiObject.Behaviors.Add(item);
            return obj;
        }

        public static T Behaviors<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Behaviors.Add(item);
            }
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            bool? canCascade)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (canCascade != null) mauiObject.CanCascade = (bool)canCascade;
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            bool? canCascade,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (canCascade != null) mauiObject.CanCascade = (bool)canCascade;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.CanCascade = def.GetValue();
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.CanCascade = def.GetValue();
            return obj;
        }
        
        public static T Class<T>(this T obj,
            string? @class)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (@class != null) mauiObject.Class = (string)@class;
            return obj;
        }
        
        public static T Class<T>(this T obj,
            string? @class,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            if (@class != null) mauiObject.Class = (string)@class;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Class = def.GetValue();
            return obj;
        }
        
        public static T Class<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Class = def.GetValue();
            return obj;
        }
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters) mauiObject.Setters.Add(item);
            return obj;
        }

        public static T Setters<T>(this T obj,
            params Microsoft.Maui.Controls.Setter[] setters)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters) mauiObject.Setters.Add(item);
            return obj;
        }

        public static T Setters<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Setters.Add(item);
            }
            return obj;
        }
        
        public static T Triggers<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase> triggers)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in triggers) mauiObject.Triggers.Add(item);
            return obj;
        }

        public static T Triggers<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerBase[] triggers)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in triggers) mauiObject.Triggers.Add(item);
            return obj;
        }

        public static T Triggers<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Triggers.Add(item);
            }
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
