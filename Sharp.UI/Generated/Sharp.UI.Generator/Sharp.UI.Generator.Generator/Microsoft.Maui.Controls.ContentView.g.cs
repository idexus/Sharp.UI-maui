﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ContentViewGeneratedExtension
    {
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content)
            where T : Sharp.UI.IContentView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ContentView>(obj);
            if (content != null) mauiObject.Content = (Microsoft.Maui.Controls.View)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ContentView>(obj);
            if (content != null) mauiObject.Content = (Microsoft.Maui.Controls.View)content;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentView.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentView
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ContentView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentView.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
