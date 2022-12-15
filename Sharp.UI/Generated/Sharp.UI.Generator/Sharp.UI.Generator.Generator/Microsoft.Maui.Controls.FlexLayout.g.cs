﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class FlexLayoutGeneratedExtension
    {
        public static T Direction<T>(this T obj,
            Microsoft.Maui.Layouts.FlexDirection? direction)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            if (direction != null) mauiObject.Direction = (Microsoft.Maui.Layouts.FlexDirection)direction;
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            Microsoft.Maui.Layouts.FlexDirection? direction,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexDirection>, BindableDef<Microsoft.Maui.Layouts.FlexDirection>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);         
            if (direction != null) mauiObject.Direction = (Microsoft.Maui.Layouts.FlexDirection)direction;
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexDirection>(mauiObject, Microsoft.Maui.Controls.FlexLayout.DirectionProperty));
            if (def.ValueIsSet()) mauiObject.Direction = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexDirection>, BindableDef<Microsoft.Maui.Layouts.FlexDirection>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexDirection>(mauiObject, Microsoft.Maui.Controls.FlexLayout.DirectionProperty));
            if (def.ValueIsSet()) mauiObject.Direction = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            Microsoft.Maui.Layouts.FlexJustify? justifyContent)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            if (justifyContent != null) mauiObject.JustifyContent = (Microsoft.Maui.Layouts.FlexJustify)justifyContent;
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            Microsoft.Maui.Layouts.FlexJustify? justifyContent,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexJustify>, BindableDef<Microsoft.Maui.Layouts.FlexJustify>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);         
            if (justifyContent != null) mauiObject.JustifyContent = (Microsoft.Maui.Layouts.FlexJustify)justifyContent;
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexJustify>(mauiObject, Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty));
            if (def.ValueIsSet()) mauiObject.JustifyContent = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T JustifyContent<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexJustify>, BindableDef<Microsoft.Maui.Layouts.FlexJustify>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexJustify>(mauiObject, Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty));
            if (def.ValueIsSet()) mauiObject.JustifyContent = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            Microsoft.Maui.Layouts.FlexAlignContent? alignContent)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            if (alignContent != null) mauiObject.AlignContent = (Microsoft.Maui.Layouts.FlexAlignContent)alignContent;
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            Microsoft.Maui.Layouts.FlexAlignContent? alignContent,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexAlignContent>, BindableDef<Microsoft.Maui.Layouts.FlexAlignContent>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);         
            if (alignContent != null) mauiObject.AlignContent = (Microsoft.Maui.Layouts.FlexAlignContent)alignContent;
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexAlignContent>(mauiObject, Microsoft.Maui.Controls.FlexLayout.AlignContentProperty));
            if (def.ValueIsSet()) mauiObject.AlignContent = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T AlignContent<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexAlignContent>, BindableDef<Microsoft.Maui.Layouts.FlexAlignContent>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexAlignContent>(mauiObject, Microsoft.Maui.Controls.FlexLayout.AlignContentProperty));
            if (def.ValueIsSet()) mauiObject.AlignContent = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            Microsoft.Maui.Layouts.FlexAlignItems? alignItems)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            if (alignItems != null) mauiObject.AlignItems = (Microsoft.Maui.Layouts.FlexAlignItems)alignItems;
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            Microsoft.Maui.Layouts.FlexAlignItems? alignItems,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexAlignItems>, BindableDef<Microsoft.Maui.Layouts.FlexAlignItems>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);         
            if (alignItems != null) mauiObject.AlignItems = (Microsoft.Maui.Layouts.FlexAlignItems)alignItems;
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexAlignItems>(mauiObject, Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty));
            if (def.ValueIsSet()) mauiObject.AlignItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T AlignItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexAlignItems>, BindableDef<Microsoft.Maui.Layouts.FlexAlignItems>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexAlignItems>(mauiObject, Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty));
            if (def.ValueIsSet()) mauiObject.AlignItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            Microsoft.Maui.Layouts.FlexPosition? position)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            if (position != null) mauiObject.Position = (Microsoft.Maui.Layouts.FlexPosition)position;
            return obj;
        }
        
        public static T Position<T>(this T obj,
            Microsoft.Maui.Layouts.FlexPosition? position,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexPosition>, BindableDef<Microsoft.Maui.Layouts.FlexPosition>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);         
            if (position != null) mauiObject.Position = (Microsoft.Maui.Layouts.FlexPosition)position;
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexPosition>(mauiObject, Microsoft.Maui.Controls.FlexLayout.PositionProperty));
            if (def.ValueIsSet()) mauiObject.Position = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexPosition>, BindableDef<Microsoft.Maui.Layouts.FlexPosition>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexPosition>(mauiObject, Microsoft.Maui.Controls.FlexLayout.PositionProperty));
            if (def.ValueIsSet()) mauiObject.Position = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            Microsoft.Maui.Layouts.FlexWrap? wrap)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            if (wrap != null) mauiObject.Wrap = (Microsoft.Maui.Layouts.FlexWrap)wrap;
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            Microsoft.Maui.Layouts.FlexWrap? wrap,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexWrap>, BindableDef<Microsoft.Maui.Layouts.FlexWrap>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);         
            if (wrap != null) mauiObject.Wrap = (Microsoft.Maui.Layouts.FlexWrap)wrap;
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexWrap>(mauiObject, Microsoft.Maui.Controls.FlexLayout.WrapProperty));
            if (def.ValueIsSet()) mauiObject.Wrap = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Wrap<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Layouts.FlexWrap>, BindableDef<Microsoft.Maui.Layouts.FlexWrap>> definition)
            where T : Sharp.UI.IFlexLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.FlexLayout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Layouts.FlexWrap>(mauiObject, Microsoft.Maui.Controls.FlexLayout.WrapProperty));
            if (def.ValueIsSet()) mauiObject.Wrap = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
