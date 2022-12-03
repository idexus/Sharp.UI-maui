﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IPinchGestureRecognizerGeneratedExtension
    {
        public static T OnPinchUpdated<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.PinchGestureUpdatedEventArgs> action)
            where T : Sharp.UI.IPinchGestureRecognizer
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.PinchGestureRecognizer>(obj);
            mauiObject.PinchUpdated += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
