﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PanGestureRecognizerGeneratedExtension
    {
        public static T TouchPoints<T>(this T obj,
            int? touchPoints)
            where T : Sharp.UI.IPanGestureRecognizer
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.PanGestureRecognizer>(obj);
            if (touchPoints != null) mauiObject.TouchPoints = (int)touchPoints;
            return obj;
        }
        
        public static T TouchPoints<T>(this T obj,
            int? touchPoints,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IPanGestureRecognizer
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.PanGestureRecognizer>(obj);
            if (touchPoints != null) mauiObject.TouchPoints = (int)touchPoints;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.PanGestureRecognizer.TouchPointsProperty));
            if (def.ValueIsSet()) mauiObject.TouchPoints = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TouchPoints<T>(this T obj,
            Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IPanGestureRecognizer
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.PanGestureRecognizer>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.PanGestureRecognizer.TouchPointsProperty));
            if (def.ValueIsSet()) mauiObject.TouchPoints = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnPanUpdated<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.PanUpdatedEventArgs> action)
            where T : Sharp.UI.IPanGestureRecognizer
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.PanGestureRecognizer>(obj);
            mauiObject.PanUpdated += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
