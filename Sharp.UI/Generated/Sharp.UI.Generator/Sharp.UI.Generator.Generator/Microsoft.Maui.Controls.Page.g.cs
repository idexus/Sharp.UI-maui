﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PageGeneratedExtension
    {
        public static T BackgroundImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? backgroundImageSource)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (backgroundImageSource != null) mauiObject.BackgroundImageSource = (Microsoft.Maui.Controls.ImageSource)backgroundImageSource;
            return obj;
        }
        
        public static T BackgroundImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? backgroundImageSource,
            Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (backgroundImageSource != null) mauiObject.BackgroundImageSource = (Microsoft.Maui.Controls.ImageSource)backgroundImageSource;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.BackgroundImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BackgroundImageSource<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.BackgroundImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? iconImageSource)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (iconImageSource != null) mauiObject.IconImageSource = (Microsoft.Maui.Controls.ImageSource)iconImageSource;
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? iconImageSource,
            Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (iconImageSource != null) mauiObject.IconImageSource = (Microsoft.Maui.Controls.ImageSource)iconImageSource;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.Page.IconImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.IconImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.Page.IconImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.IconImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsBusy<T>(this T obj,
            bool? isBusy)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (isBusy != null) mauiObject.IsBusy = (bool)isBusy;
            return obj;
        }
        
        public static T IsBusy<T>(this T obj,
            bool? isBusy,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (isBusy != null) mauiObject.IsBusy = (bool)isBusy;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Page.IsBusyProperty));
            if (def.ValueIsSet()) mauiObject.IsBusy = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsBusy<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Page.IsBusyProperty));
            if (def.ValueIsSet()) mauiObject.IsBusy = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (padding != null) mauiObject.Padding = (Microsoft.Maui.Thickness)padding;
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding,
            Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (padding != null) mauiObject.Padding = (Microsoft.Maui.Thickness)padding;
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.Page.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.Page.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string? title)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (title != null) mauiObject.Title = (string)title;
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string? title,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (title != null) mauiObject.Title = (string)title;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Page.TitleProperty));
            if (def.ValueIsSet()) mauiObject.Title = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Page.TitleProperty));
            if (def.ValueIsSet()) mauiObject.Title = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ToolbarItems<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.ToolbarItem> toolbarItems)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            foreach (var item in toolbarItems) mauiObject.ToolbarItems.Add(item);
            return obj;
        }

        public static T ToolbarItems<T>(this T obj,
            params Microsoft.Maui.Controls.ToolbarItem[] toolbarItems)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            foreach (var item in toolbarItems) mauiObject.ToolbarItems.Add(item);
            return obj;
        }

        public static T ToolbarItems<T>(this T obj,
            Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.ToolbarItem>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.ToolbarItem>>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.ToolbarItem>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.ToolbarItems.Add(item);
            }
            return obj;
        }
        
        public static T MenuBarItems<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.MenuBarItem> menuBarItems)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            foreach (var item in menuBarItems) mauiObject.MenuBarItems.Add(item);
            return obj;
        }

        public static T MenuBarItems<T>(this T obj,
            params Microsoft.Maui.Controls.MenuBarItem[] menuBarItems)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            foreach (var item in menuBarItems) mauiObject.MenuBarItems.Add(item);
            return obj;
        }

        public static T MenuBarItems<T>(this T obj,
            Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.MenuBarItem>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.MenuBarItem>>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.MenuBarItem>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.MenuBarItems.Add(item);
            }
            return obj;
        }
        
        public static T ContainerArea<T>(this T obj,
            Microsoft.Maui.Graphics.Rect? containerArea)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (containerArea != null) mauiObject.ContainerArea = (Microsoft.Maui.Graphics.Rect)containerArea;
            return obj;
        }
        
        public static T ContainerArea<T>(this T obj,
            Microsoft.Maui.Graphics.Rect? containerArea,
            Func<ValueDef<Microsoft.Maui.Graphics.Rect>, ValueDef<Microsoft.Maui.Graphics.Rect>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (containerArea != null) mauiObject.ContainerArea = (Microsoft.Maui.Graphics.Rect)containerArea;
            var def = definition(new ValueDef<Microsoft.Maui.Graphics.Rect>());
            if (def.ValueIsSet()) mauiObject.ContainerArea = def.GetValue();
            return obj;
        }
        
        public static T ContainerArea<T>(this T obj,
            Func<ValueDef<Microsoft.Maui.Graphics.Rect>, ValueDef<Microsoft.Maui.Graphics.Rect>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Graphics.Rect>());
            if (def.ValueIsSet()) mauiObject.ContainerArea = def.GetValue();
            return obj;
        }
        
        public static T IgnoresContainerArea<T>(this T obj,
            bool? ignoresContainerArea)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (ignoresContainerArea != null) mauiObject.IgnoresContainerArea = (bool)ignoresContainerArea;
            return obj;
        }
        
        public static T IgnoresContainerArea<T>(this T obj,
            bool? ignoresContainerArea,
            Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            if (ignoresContainerArea != null) mauiObject.IgnoresContainerArea = (bool)ignoresContainerArea;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.IgnoresContainerArea = def.GetValue();
            return obj;
        }
        
        public static T IgnoresContainerArea<T>(this T obj,
            Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.IgnoresContainerArea = def.GetValue();
            return obj;
        }
        
        public static T InternalChildren<T>(this T obj,
            System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.Element> internalChildren)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            foreach (var item in internalChildren) mauiObject.InternalChildren.Add(item);
            return obj;
        }

        public static T InternalChildren<T>(this T obj,
            params Microsoft.Maui.Controls.Element[] internalChildren)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            foreach (var item in internalChildren) mauiObject.InternalChildren.Add(item);
            return obj;
        }

        public static T InternalChildren<T>(this T obj,
            Func<Def<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.Element>>, Def<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.Element>>> definition)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            var def = definition(new Def<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.Element>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.InternalChildren.Add(item);
            }
            return obj;
        }
        
        public static T OnNavigatedTo<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.NavigatedToEventArgs> action)
            where T : Sharp.UI.IPage
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            mauiObject.NavigatedTo += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnNavigatingFrom<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.NavigatingFromEventArgs> action)
            where T : Sharp.UI.IPage
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            mauiObject.NavigatingFrom += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnNavigatedFrom<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.NavigatedFromEventArgs> action)
            where T : Sharp.UI.IPage
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            mauiObject.NavigatedFrom += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnLayoutChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            mauiObject.LayoutChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            mauiObject.Appearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IPage
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Page>(obj);
            mauiObject.Disappearing += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
