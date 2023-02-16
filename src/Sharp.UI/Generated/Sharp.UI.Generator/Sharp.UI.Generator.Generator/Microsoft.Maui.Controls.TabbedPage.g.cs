﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class TabbedPageGeneratedExtension
    {
        public static T BarBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color barBackgroundColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.BarBackgroundColor = (Microsoft.Maui.Graphics.Color)barBackgroundColor;
            return obj;
        }
        
        public static T BarBackgroundColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.BarBackgroundColor = builder.GetValue();
            return obj;
        }
        
        public static T BarBackgroundColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            Microsoft.Maui.Controls.Brush barBackground)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.BarBackground = (Microsoft.Maui.Controls.Brush)barBackground;
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buildValue)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) mauiObject.BarBackground = builder.GetValue();
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buildBinding)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color barTextColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.BarTextColor = (Microsoft.Maui.Graphics.Color)barTextColor;
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.BarTextColor = builder.GetValue();
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T UnselectedTabColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color unselectedTabColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.UnselectedTabColor = (Microsoft.Maui.Graphics.Color)unselectedTabColor;
            return obj;
        }
        
        public static T UnselectedTabColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.UnselectedTabColor = builder.GetValue();
            return obj;
        }
        
        public static T UnselectedTabColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectedTabColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color selectedTabColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.SelectedTabColor = (Microsoft.Maui.Graphics.Color)selectedTabColor;
            return obj;
        }
        
        public static T SelectedTabColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SelectedTabColor = builder.GetValue();
            return obj;
        }
        
        public static T SelectedTabColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
