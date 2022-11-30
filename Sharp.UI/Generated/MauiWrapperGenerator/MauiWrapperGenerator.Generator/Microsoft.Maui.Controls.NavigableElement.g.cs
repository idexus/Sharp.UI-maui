﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class INavigableElementGeneratedExtension
    {
        public static T Style<T>(this T obj,
            Microsoft.Maui.Controls.Style? style)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            if (style != null) mauiObject.Style = (Microsoft.Maui.Controls.Style)style;
            return obj;
        }
        
        public static T Style<T>(this T obj,
            Microsoft.Maui.Controls.Style? style,
            Func<BindableDef<Microsoft.Maui.Controls.Style>, BindableDef<Microsoft.Maui.Controls.Style>> definition)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            if (style != null) mauiObject.Style = (Microsoft.Maui.Controls.Style)style;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Style>(mauiObject, Microsoft.Maui.Controls.NavigableElement.StyleProperty));
            if (def.ValueIsSet()) mauiObject.Style = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Style<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.Style>, BindableDef<Microsoft.Maui.Controls.Style>> definition)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Style>(mauiObject, Microsoft.Maui.Controls.NavigableElement.StyleProperty));
            if (def.ValueIsSet()) mauiObject.Style = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Collections.Generic.IList<string>? styleClass)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            if (styleClass != null) mauiObject.StyleClass = (System.Collections.Generic.IList<string>)styleClass;
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Collections.Generic.IList<string>? styleClass,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            if (styleClass != null) mauiObject.StyleClass = (System.Collections.Generic.IList<string>)styleClass;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.StyleClass = def.GetValue();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.StyleClass = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.INavigableElement
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.NavigableElement>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
