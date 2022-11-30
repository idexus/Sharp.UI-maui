﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class HStack : Microsoft.Maui.Controls.HorizontalStackLayout, Sharp.UI.IHorizontalStackLayout, IList<Microsoft.Maui.IView>, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public HStack() { }


        public HStack(out HStack hStack) 
        {
            hStack = this;
        }

        public HStack(Action<HStack> configure) 
        {
            configure(this);
        }

        public HStack(out HStack hStack, Action<HStack> configure) 
        {
            hStack = this;
            configure(this);
        }

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
    
    public static class IHorizontalStackLayoutGeneratedContainerExtension
    {
        // ----- collection container extension -----
        public static T Children<T>(this T obj, params Microsoft.Maui.IView[] children) where T : Sharp.UI.IHorizontalStackLayout
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.HorizontalStackLayout>(obj);
            foreach (var item in children) mauiObject.Children.Add(item);
            return obj;
        }

        public static T Children<T>(this T obj,
            Func<CollectionDef<Microsoft.Maui.IView>, CollectionDef<Microsoft.Maui.IView>> definition)
            where T : Sharp.UI.IHorizontalStackLayout
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.HorizontalStackLayout>(obj);
            var def = definition(new CollectionDef<Microsoft.Maui.IView>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Children.Add(item);
            }
            return obj;
        }
    }

}

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
