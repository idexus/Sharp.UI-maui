﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IBindableObjectGeneratedExtension
    {
        public static T OnPropertyChanged<T>(this T obj, OnEventAction<T, System.ComponentModel.PropertyChangedEventArgs> action)
            where T : Sharp.UI.IBindableObject
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BindableObject>(obj);
            mauiObject.PropertyChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnPropertyChanging<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.PropertyChangingEventArgs> action)
            where T : Sharp.UI.IBindableObject
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BindableObject>(obj);
            mauiObject.PropertyChanging += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnBindingContextChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IBindableObject
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.BindableObject>(obj);
            mauiObject.BindingContextChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
