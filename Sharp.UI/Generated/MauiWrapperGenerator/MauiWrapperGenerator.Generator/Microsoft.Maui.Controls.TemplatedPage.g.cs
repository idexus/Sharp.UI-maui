﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ITemplatedPageGeneratedExtension
    {
        public static T ControlTemplate<T>(this T obj,
            Microsoft.Maui.Controls.ControlTemplate? controlTemplate)
            where T : Sharp.UI.ITemplatedPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TemplatedPage>(obj);
            if (controlTemplate != null) mauiObject.ControlTemplate = (Microsoft.Maui.Controls.ControlTemplate)controlTemplate;
            return obj;
        }
        
        public static T ControlTemplate<T>(this T obj,
            Microsoft.Maui.Controls.ControlTemplate? controlTemplate,
            Func<BindableDef<Microsoft.Maui.Controls.ControlTemplate>, BindableDef<Microsoft.Maui.Controls.ControlTemplate>> definition)
            where T : Sharp.UI.ITemplatedPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TemplatedPage>(obj);
            if (controlTemplate != null) mauiObject.ControlTemplate = (Microsoft.Maui.Controls.ControlTemplate)controlTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ControlTemplate>(mauiObject, Microsoft.Maui.Controls.TemplatedPage.ControlTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ControlTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ControlTemplate<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.ControlTemplate>, BindableDef<Microsoft.Maui.Controls.ControlTemplate>> definition)
            where T : Sharp.UI.ITemplatedPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TemplatedPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ControlTemplate>(mauiObject, Microsoft.Maui.Controls.TemplatedPage.ControlTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ControlTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
